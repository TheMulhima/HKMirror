using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EnableAnimation class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnableAnimation
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<EnableAnimation> orig, EnableAnimation self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<EnableAnimation> orig, EnableAnimation self)
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

        internal static void HookDoEnableAnimation()
        {
            if (!HookedList.Contains("DoEnableAnimation"))
            {
                HookedList.Add("DoEnableAnimation");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "DoEnableAnimation"),
                    DoEnableAnimation);
            }
        }

        internal static event Delegates.DoEnableAnimation_BeforeArgs _beforeDoEnableAnimation;
        internal static event Delegates.DoEnableAnimation_AfterArgs _afterDoEnableAnimation;

        private static void DoEnableAnimation(Action<EnableAnimation, GameObject> orig, EnableAnimation self,
            GameObject go)
        {
            Delegates.Params_DoEnableAnimation @params = new()
            {
                self = self, go = go
            };
            if (_beforeDoEnableAnimation != null)
                foreach (Delegates.DoEnableAnimation_BeforeArgs toInvoke in
                         _beforeDoEnableAnimation.GetInvocationList())
                    try
                    {
                        _beforeDoEnableAnimation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            go = @params.go;
            orig(self, go);
            if (_afterDoEnableAnimation != null)
                foreach (Delegates.DoEnableAnimation_AfterArgs toInvoke in _afterDoEnableAnimation.GetInvocationList())
                    try
                    {
                        _afterDoEnableAnimation.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<EnableAnimation> orig, EnableAnimation self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            if (_beforeOnExit != null)
                foreach (Delegates.OnExit_BeforeArgs toInvoke in _beforeOnExit.GetInvocationList())
                    try
                    {
                        _beforeOnExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnExit != null)
                foreach (Delegates.OnExit_AfterArgs toInvoke in _afterOnExit.GetInvocationList())
                    try
                    {
                        _afterOnExit.Invoke(@params);
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
        public delegate void DoEnableAnimation_AfterArgs(Params_DoEnableAnimation args);

        public delegate void DoEnableAnimation_BeforeArgs(Params_DoEnableAnimation args);

        public delegate void DoEnableAnimation_WithArgs(Action<EnableAnimation, GameObject> orig, EnableAnimation self,
            GameObject go);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<EnableAnimation> orig, EnableAnimation self);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<EnableAnimation> orig, EnableAnimation self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<EnableAnimation> orig, EnableAnimation self);

        public sealed class Params_Reset
        {
            public EnableAnimation self;
        }

        public sealed class Params_OnEnter
        {
            public EnableAnimation self;
        }

        public sealed class Params_DoEnableAnimation
        {
            public GameObject go;
            public EnableAnimation self;
        }

        public sealed class Params_OnExit
        {
            public EnableAnimation self;
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

        public static event Delegates.DoEnableAnimation_BeforeArgs DoEnableAnimation
        {
            add
            {
                HookHandler._beforeDoEnableAnimation += value;
                HookHandler.HookDoEnableAnimation();
            }
            remove => HookHandler._beforeDoEnableAnimation -= value;
        }

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
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

        public static event Delegates.DoEnableAnimation_AfterArgs DoEnableAnimation
        {
            add
            {
                HookHandler._afterDoEnableAnimation += value;
                HookHandler.HookDoEnableAnimation();
            }
            remove => HookHandler._afterDoEnableAnimation -= value;
        }

        public static event Delegates.OnExit_AfterArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "OnEnter"), value);
        }

        public static event Delegates.DoEnableAnimation_WithArgs DoEnableAnimation
        {
            add => HookEndpointManager.Add<Delegates.DoEnableAnimation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "DoEnableAnimation"), value);
            remove => HookEndpointManager.Remove<Delegates.DoEnableAnimation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "DoEnableAnimation"), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnableAnimation), "OnExit"), value);
        }
    }
}