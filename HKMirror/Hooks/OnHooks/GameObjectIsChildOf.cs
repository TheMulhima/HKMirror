using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GameObjectIsChildOf class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGameObjectIsChildOf
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GameObjectIsChildOf> orig, GameObjectIsChildOf self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<GameObjectIsChildOf> orig, GameObjectIsChildOf self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoIsChildOf()
        {
            if (!HookedList.Contains("DoIsChildOf"))
            {
                HookedList.Add("DoIsChildOf");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "DoIsChildOf"), DoIsChildOf);
            }
        }

        internal static event Delegates.DoIsChildOf_BeforeArgs _beforeDoIsChildOf;
        internal static event Delegates.DoIsChildOf_AfterArgs _afterDoIsChildOf;

        private static void DoIsChildOf(Action<GameObjectIsChildOf, GameObject> orig, GameObjectIsChildOf self,
            GameObject go)
        {
            Delegates.Params_DoIsChildOf @params = new()
            {
                self = self, go = go
            };
            if (_beforeDoIsChildOf != null)
                foreach (Delegates.DoIsChildOf_BeforeArgs toInvoke in _beforeDoIsChildOf.GetInvocationList())
                    try
                    {
                        _beforeDoIsChildOf?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            go = @params.go;
            orig(self, go);
            if (_afterDoIsChildOf != null)
                foreach (Delegates.DoIsChildOf_AfterArgs toInvoke in _afterDoIsChildOf.GetInvocationList())
                    try
                    {
                        _afterDoIsChildOf.Invoke(@params);
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
        public delegate void DoIsChildOf_AfterArgs(Params_DoIsChildOf args);

        public delegate void DoIsChildOf_BeforeArgs(Params_DoIsChildOf args);

        public delegate void DoIsChildOf_WithArgs(Action<GameObjectIsChildOf, GameObject> orig,
            GameObjectIsChildOf self, GameObject go);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<GameObjectIsChildOf> orig, GameObjectIsChildOf self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GameObjectIsChildOf> orig, GameObjectIsChildOf self);

        public sealed class Params_Reset
        {
            public GameObjectIsChildOf self;
        }

        public sealed class Params_OnEnter
        {
            public GameObjectIsChildOf self;
        }

        public sealed class Params_DoIsChildOf
        {
            public GameObject go;
            public GameObjectIsChildOf self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.DoIsChildOf_BeforeArgs DoIsChildOf
        {
            add
            {
                HookHandler._beforeDoIsChildOf += value;
                HookHandler.HookDoIsChildOf();
            }
            remove => HookHandler._beforeDoIsChildOf -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.DoIsChildOf_AfterArgs DoIsChildOf
        {
            add
            {
                HookHandler._afterDoIsChildOf += value;
                HookHandler.HookDoIsChildOf();
            }
            remove => HookHandler._afterDoIsChildOf -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "OnEnter"), value);
        }

        public static event Delegates.DoIsChildOf_WithArgs DoIsChildOf
        {
            add => HookEndpointManager.Add<Delegates.DoIsChildOf_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "DoIsChildOf"), value);
            remove => HookEndpointManager.Remove<Delegates.DoIsChildOf_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsChildOf), "DoIsChildOf"), value);
        }
    }
}