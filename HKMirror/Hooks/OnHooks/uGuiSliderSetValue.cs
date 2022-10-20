using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for uGuiSliderSetValue class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnuGuiSliderSetValue
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<uGuiSliderSetValue> orig, uGuiSliderSetValue self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<uGuiSliderSetValue> orig, uGuiSliderSetValue self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<uGuiSliderSetValue> orig, uGuiSliderSetValue self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            _beforeOnUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null) _afterOnUpdate.Invoke(@params);
        }

        internal static void HookDoSetValue()
        {
            if (!HookedList.Contains("DoSetValue"))
            {
                HookedList.Add("DoSetValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "DoSetValue"), DoSetValue);
            }
        }

        internal static event Delegates.DoSetValue_BeforeArgs _beforeDoSetValue;
        internal static event Delegates.DoSetValue_NormalArgs _afterDoSetValue;

        private static void DoSetValue(Action<uGuiSliderSetValue> orig, uGuiSliderSetValue self)
        {
            Delegates.Params_DoSetValue @params = new()
            {
                self = self
            };
            _beforeDoSetValue?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSetValue != null) _afterDoSetValue.Invoke(@params);
        }

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_NormalArgs _afterOnExit;

        private static void OnExit(Action<uGuiSliderSetValue> orig, uGuiSliderSetValue self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoSetValue_BeforeArgs(Params_DoSetValue args);

        public delegate void DoSetValue_NormalArgs(Params_DoSetValue args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_NormalArgs(Params_OnExit args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public uGuiSliderSetValue self;
        }

        public sealed class Params_OnEnter
        {
            public uGuiSliderSetValue self;
        }

        public sealed class Params_OnUpdate
        {
            public uGuiSliderSetValue self;
        }

        public sealed class Params_DoSetValue
        {
            public uGuiSliderSetValue self;
        }

        public sealed class Params_OnExit
        {
            public uGuiSliderSetValue self;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoSetValue_BeforeArgs DoSetValue
        {
            add
            {
                HookHandler._beforeDoSetValue += value;
                HookHandler.HookDoSetValue();
            }
            remove => HookHandler._beforeDoSetValue -= value;
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

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoSetValue_NormalArgs DoSetValue
        {
            add
            {
                HookHandler._afterDoSetValue += value;
                HookHandler.HookDoSetValue();
            }
            remove => HookHandler._afterDoSetValue -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnUpdate"), value);
        }

        public static event Delegates.DoSetValue_NormalArgs DoSetValue
        {
            add => HookEndpointManager.Add<Delegates.DoSetValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "DoSetValue"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "DoSetValue"), value);
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderSetValue), "OnExit"), value);
        }
    }
}