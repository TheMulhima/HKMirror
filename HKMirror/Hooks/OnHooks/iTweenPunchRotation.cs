using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for iTweenPunchRotation class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OniTweenPunchRotation
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<iTweenPunchRotation> orig, iTweenPunchRotation self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<iTweenPunchRotation> orig, iTweenPunchRotation self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            _beforeOnEnter?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnter != null) _afterOnEnter.Invoke(@params);
        }

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_NormalArgs _afterOnExit;

        private static void OnExit(Action<iTweenPunchRotation> orig, iTweenPunchRotation self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            _beforeOnExit?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnExit != null) _afterOnExit.Invoke(@params);
        }

        internal static void HookDoiTween()
        {
            if (!HookedList.Contains("DoiTween"))
            {
                HookedList.Add("DoiTween");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "DoiTween"), DoiTween);
            }
        }

        internal static event Delegates.DoiTween_BeforeArgs _beforeDoiTween;
        internal static event Delegates.DoiTween_NormalArgs _afterDoiTween;

        private static void DoiTween(Action<iTweenPunchRotation> orig, iTweenPunchRotation self)
        {
            Delegates.Params_DoiTween @params = new()
            {
                self = self
            };
            _beforeDoiTween?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoiTween != null) _afterDoiTween.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoiTween_BeforeArgs(Params_DoiTween args);

        public delegate void DoiTween_NormalArgs(Params_DoiTween args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_NormalArgs(Params_OnExit args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public iTweenPunchRotation self;
        }

        public sealed class Params_OnEnter
        {
            public iTweenPunchRotation self;
        }

        public sealed class Params_OnExit
        {
            public iTweenPunchRotation self;
        }

        public sealed class Params_DoiTween
        {
            public iTweenPunchRotation self;
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

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }

        public static event Delegates.DoiTween_BeforeArgs DoiTween
        {
            add
            {
                HookHandler._beforeDoiTween += value;
                HookHandler.HookDoiTween();
            }
            remove => HookHandler._beforeDoiTween -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }

        public static event Delegates.DoiTween_NormalArgs DoiTween
        {
            add
            {
                HookHandler._afterDoiTween += value;
                HookHandler.HookDoiTween();
            }
            remove => HookHandler._afterDoiTween -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "OnEnter"), value);
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "OnExit"), value);
        }

        public static event Delegates.DoiTween_NormalArgs DoiTween
        {
            add => HookEndpointManager.Add<Delegates.DoiTween_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "DoiTween"), value);
            remove => HookEndpointManager.Remove<Delegates.DoiTween_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(iTweenPunchRotation), "DoiTween"), value);
        }
    }
}