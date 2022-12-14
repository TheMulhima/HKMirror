using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for InGameCutsceneInfo class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnInGameCutsceneInfo
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsInCutscene()
        {
            if (!HookedList.Contains("get_IsInCutscene"))
            {
                HookedList.Add("get_IsInCutscene");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_IsInCutscene", false),
                    get_IsInCutscene);
            }
        }

        internal static event Delegates.get_IsInCutscene_BeforeArgs _beforeget_IsInCutscene;
        internal static event Delegates.get_IsInCutscene_AfterArgs _afterget_IsInCutscene;

        private static bool get_IsInCutscene(Func<bool> orig)
        {
            if (_beforeget_IsInCutscene != null)
                foreach (Delegates.get_IsInCutscene_BeforeArgs toInvoke in _beforeget_IsInCutscene.GetInvocationList())
                    try
                    {
                        _beforeget_IsInCutscene?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterget_IsInCutscene != null)
                foreach (Delegates.get_IsInCutscene_AfterArgs toInvoke in _afterget_IsInCutscene.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsInCutscene.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_CameraPosition()
        {
            if (!HookedList.Contains("get_CameraPosition"))
            {
                HookedList.Add("get_CameraPosition");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_CameraPosition", false),
                    get_CameraPosition);
            }
        }

        internal static event Delegates.get_CameraPosition_BeforeArgs _beforeget_CameraPosition;
        internal static event Delegates.get_CameraPosition_AfterArgs _afterget_CameraPosition;

        private static Vector2 get_CameraPosition(Func<Vector2> orig)
        {
            if (_beforeget_CameraPosition != null)
                foreach (Delegates.get_CameraPosition_BeforeArgs toInvoke in
                         _beforeget_CameraPosition.GetInvocationList())
                    try
                    {
                        _beforeget_CameraPosition?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterget_CameraPosition != null)
                foreach (Delegates.get_CameraPosition_AfterArgs toInvoke in
                         _afterget_CameraPosition.GetInvocationList())
                    try
                    {
                        retVal = _afterget_CameraPosition.Invoke(retVal);
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
                On.InGameCutsceneInfo.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.InGameCutsceneInfo.orig_Awake orig, InGameCutsceneInfo self)
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

        internal static void HookOnDestroy()
        {
            if (!HookedList.Contains("OnDestroy"))
            {
                HookedList.Add("OnDestroy");
                On.InGameCutsceneInfo.OnDestroy += OnDestroy;
            }
        }

        internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
        internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;

        private static void OnDestroy(On.InGameCutsceneInfo.orig_OnDestroy orig, InGameCutsceneInfo self)
        {
            Delegates.Params_OnDestroy @params = new()
            {
                self = self
            };
            if (_beforeOnDestroy != null)
                foreach (Delegates.OnDestroy_BeforeArgs toInvoke in _beforeOnDestroy.GetInvocationList())
                    try
                    {
                        _beforeOnDestroy?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDestroy != null)
                foreach (Delegates.OnDestroy_AfterArgs toInvoke in _afterOnDestroy.GetInvocationList())
                    try
                    {
                        _afterOnDestroy.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<InGameCutsceneInfo> orig, InGameCutsceneInfo self);

        public delegate Vector2 get_CameraPosition_AfterArgs(Vector2 ret);

        public delegate void get_CameraPosition_BeforeArgs();

        public delegate Vector2 get_CameraPosition_WithArgs(Func<Vector2> orig);

        public delegate bool get_IsInCutscene_AfterArgs(bool ret);

        public delegate void get_IsInCutscene_BeforeArgs();

        public delegate bool get_IsInCutscene_WithArgs(Func<bool> orig);

        public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);

        public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);

        public delegate void OnDestroy_WithArgs(Action<InGameCutsceneInfo> orig, InGameCutsceneInfo self);

        public sealed class Params_Awake
        {
            public InGameCutsceneInfo self;
        }

        public sealed class Params_OnDestroy
        {
            public InGameCutsceneInfo self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsInCutscene_BeforeArgs get_IsInCutscene
        {
            add
            {
                HookHandler._beforeget_IsInCutscene += value;
                HookHandler.Hookget_IsInCutscene();
            }
            remove => HookHandler._beforeget_IsInCutscene -= value;
        }

        public static event Delegates.get_CameraPosition_BeforeArgs get_CameraPosition
        {
            add
            {
                HookHandler._beforeget_CameraPosition += value;
                HookHandler.Hookget_CameraPosition();
            }
            remove => HookHandler._beforeget_CameraPosition -= value;
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

        public static event Delegates.OnDestroy_BeforeArgs OnDestroy
        {
            add
            {
                HookHandler._beforeOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._beforeOnDestroy -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsInCutscene_AfterArgs get_IsInCutscene
        {
            add
            {
                HookHandler._afterget_IsInCutscene += value;
                HookHandler.Hookget_IsInCutscene();
            }
            remove => HookHandler._afterget_IsInCutscene -= value;
        }

        public static event Delegates.get_CameraPosition_AfterArgs get_CameraPosition
        {
            add
            {
                HookHandler._afterget_CameraPosition += value;
                HookHandler.Hookget_CameraPosition();
            }
            remove => HookHandler._afterget_CameraPosition -= value;
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

        public static event Delegates.OnDestroy_AfterArgs OnDestroy
        {
            add
            {
                HookHandler._afterOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._afterOnDestroy -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsInCutscene_WithArgs get_IsInCutscene
        {
            add => HookEndpointManager.Add<Delegates.get_IsInCutscene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_IsInCutscene", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsInCutscene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_IsInCutscene", false), value);
        }

        public static event Delegates.get_CameraPosition_WithArgs get_CameraPosition
        {
            add => HookEndpointManager.Add<Delegates.get_CameraPosition_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_CameraPosition", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_CameraPosition_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_CameraPosition", false), value);
        }

        public static event On.InGameCutsceneInfo.hook_Awake Awake
        {
            add => On.InGameCutsceneInfo.Awake += value;
            remove => On.InGameCutsceneInfo.Awake -= value;
        }

        public static event On.InGameCutsceneInfo.hook_OnDestroy OnDestroy
        {
            add => On.InGameCutsceneInfo.OnDestroy += value;
            remove => On.InGameCutsceneInfo.OnDestroy -= value;
        }
    }
}