using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PreInstantiateGameObject class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPreInstantiateGameObject
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_InstantiatedGameObject()
        {
            if (!HookedList.Contains("get_InstantiatedGameObject"))
            {
                HookedList.Add("get_InstantiatedGameObject");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PreInstantiateGameObject), "get_InstantiatedGameObject"),
                    get_InstantiatedGameObject);
            }
        }

        internal static event Delegates.get_InstantiatedGameObject_BeforeArgs _beforeget_InstantiatedGameObject;
        internal static event Delegates.get_InstantiatedGameObject_AfterArgs _afterget_InstantiatedGameObject;

        private static GameObject get_InstantiatedGameObject(Func<PreInstantiateGameObject, GameObject> orig,
            PreInstantiateGameObject self)
        {
            Delegates.Params_get_InstantiatedGameObject @params = new()
            {
                self = self
            };
            if (_beforeget_InstantiatedGameObject != null)
                foreach (Delegates.get_InstantiatedGameObject_BeforeArgs toInvoke in _beforeget_InstantiatedGameObject
                             .GetInvocationList())
                    try
                    {
                        _beforeget_InstantiatedGameObject?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_InstantiatedGameObject != null)
                foreach (Delegates.get_InstantiatedGameObject_AfterArgs toInvoke in _afterget_InstantiatedGameObject
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_InstantiatedGameObject.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.PreInstantiateGameObject.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.PreInstantiateGameObject.orig_Awake orig, PreInstantiateGameObject self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<PreInstantiateGameObject> orig, PreInstantiateGameObject self);

        public delegate GameObject get_InstantiatedGameObject_AfterArgs(Params_get_InstantiatedGameObject args,
            GameObject ret);

        public delegate void get_InstantiatedGameObject_BeforeArgs(Params_get_InstantiatedGameObject args);

        public delegate GameObject get_InstantiatedGameObject_WithArgs(Func<PreInstantiateGameObject, GameObject> orig,
            PreInstantiateGameObject self);

        public sealed class Params_get_InstantiatedGameObject
        {
            public PreInstantiateGameObject self;
        }

        public sealed class Params_Awake
        {
            public PreInstantiateGameObject self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_InstantiatedGameObject_BeforeArgs get_InstantiatedGameObject
        {
            add
            {
                HookHandler._beforeget_InstantiatedGameObject += value;
                HookHandler.Hookget_InstantiatedGameObject();
            }
            remove => HookHandler._beforeget_InstantiatedGameObject -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_InstantiatedGameObject_AfterArgs get_InstantiatedGameObject
        {
            add
            {
                HookHandler._afterget_InstantiatedGameObject += value;
                HookHandler.Hookget_InstantiatedGameObject();
            }
            remove => HookHandler._afterget_InstantiatedGameObject -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_InstantiatedGameObject_WithArgs get_InstantiatedGameObject
        {
            add => HookEndpointManager.Add<Delegates.get_InstantiatedGameObject_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PreInstantiateGameObject), "get_InstantiatedGameObject"), value);
            remove => HookEndpointManager.Remove<Delegates.get_InstantiatedGameObject_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PreInstantiateGameObject), "get_InstantiatedGameObject"), value);
        }

        public static event On.PreInstantiateGameObject.hook_Awake Awake
        {
            add => On.PreInstantiateGameObject.Awake += value;
            remove => On.PreInstantiateGameObject.Awake -= value;
        }
    }
}