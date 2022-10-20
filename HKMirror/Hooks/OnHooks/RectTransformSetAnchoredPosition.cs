using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for RectTransformSetAnchoredPosition class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnRectTransformSetAnchoredPosition
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<RectTransformSetAnchoredPosition> orig, RectTransformSetAnchoredPosition self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<RectTransformSetAnchoredPosition> orig,
            RectTransformSetAnchoredPosition self)
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

        internal static void HookOnActionUpdate()
        {
            if (!HookedList.Contains("OnActionUpdate"))
            {
                HookedList.Add("OnActionUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnActionUpdate"),
                    OnActionUpdate);
            }
        }

        internal static event Delegates.OnActionUpdate_BeforeArgs _beforeOnActionUpdate;
        internal static event Delegates.OnActionUpdate_NormalArgs _afterOnActionUpdate;

        private static void OnActionUpdate(Action<RectTransformSetAnchoredPosition> orig,
            RectTransformSetAnchoredPosition self)
        {
            Delegates.Params_OnActionUpdate @params = new()
            {
                self = self
            };
            _beforeOnActionUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnActionUpdate != null) _afterOnActionUpdate.Invoke(@params);
        }

        internal static void HookDoSetAnchoredPosition()
        {
            if (!HookedList.Contains("DoSetAnchoredPosition"))
            {
                HookedList.Add("DoSetAnchoredPosition");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "DoSetAnchoredPosition"),
                    DoSetAnchoredPosition);
            }
        }

        internal static event Delegates.DoSetAnchoredPosition_BeforeArgs _beforeDoSetAnchoredPosition;
        internal static event Delegates.DoSetAnchoredPosition_NormalArgs _afterDoSetAnchoredPosition;

        private static void DoSetAnchoredPosition(Action<RectTransformSetAnchoredPosition> orig,
            RectTransformSetAnchoredPosition self)
        {
            Delegates.Params_DoSetAnchoredPosition @params = new()
            {
                self = self
            };
            _beforeDoSetAnchoredPosition?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSetAnchoredPosition != null) _afterDoSetAnchoredPosition.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoSetAnchoredPosition_BeforeArgs(Params_DoSetAnchoredPosition args);

        public delegate void DoSetAnchoredPosition_NormalArgs(Params_DoSetAnchoredPosition args);

        public delegate void OnActionUpdate_BeforeArgs(Params_OnActionUpdate args);

        public delegate void OnActionUpdate_NormalArgs(Params_OnActionUpdate args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public RectTransformSetAnchoredPosition self;
        }

        public sealed class Params_OnEnter
        {
            public RectTransformSetAnchoredPosition self;
        }

        public sealed class Params_OnActionUpdate
        {
            public RectTransformSetAnchoredPosition self;
        }

        public sealed class Params_DoSetAnchoredPosition
        {
            public RectTransformSetAnchoredPosition self;
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

        public static event Delegates.OnActionUpdate_BeforeArgs OnActionUpdate
        {
            add
            {
                HookHandler._beforeOnActionUpdate += value;
                HookHandler.HookOnActionUpdate();
            }
            remove => HookHandler._beforeOnActionUpdate -= value;
        }

        public static event Delegates.DoSetAnchoredPosition_BeforeArgs DoSetAnchoredPosition
        {
            add
            {
                HookHandler._beforeDoSetAnchoredPosition += value;
                HookHandler.HookDoSetAnchoredPosition();
            }
            remove => HookHandler._beforeDoSetAnchoredPosition -= value;
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

        public static event Delegates.OnActionUpdate_NormalArgs OnActionUpdate
        {
            add
            {
                HookHandler._afterOnActionUpdate += value;
                HookHandler.HookOnActionUpdate();
            }
            remove => HookHandler._afterOnActionUpdate -= value;
        }

        public static event Delegates.DoSetAnchoredPosition_NormalArgs DoSetAnchoredPosition
        {
            add
            {
                HookHandler._afterDoSetAnchoredPosition += value;
                HookHandler.HookDoSetAnchoredPosition();
            }
            remove => HookHandler._afterDoSetAnchoredPosition -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnEnter"), value);
        }

        public static event Delegates.OnActionUpdate_NormalArgs OnActionUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnActionUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnActionUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnActionUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnActionUpdate"), value);
        }

        public static event Delegates.DoSetAnchoredPosition_NormalArgs DoSetAnchoredPosition
        {
            add => HookEndpointManager.Add<Delegates.DoSetAnchoredPosition_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "DoSetAnchoredPosition"),
                value);
            remove => HookEndpointManager.Remove<Delegates.DoSetAnchoredPosition_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "DoSetAnchoredPosition"),
                value);
        }
    }
}