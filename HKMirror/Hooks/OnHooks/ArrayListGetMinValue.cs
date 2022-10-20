using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListGetMinValue class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListGetMinValue
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ArrayListGetMinValue> orig, ArrayListGetMinValue self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListGetMinValue> orig, ArrayListGetMinValue self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<ArrayListGetMinValue> orig, ArrayListGetMinValue self)
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

        internal static void HookDoFindMinimumValue()
        {
            if (!HookedList.Contains("DoFindMinimumValue"))
            {
                HookedList.Add("DoFindMinimumValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "DoFindMinimumValue"),
                    DoFindMinimumValue);
            }
        }

        internal static event Delegates.DoFindMinimumValue_BeforeArgs _beforeDoFindMinimumValue;
        internal static event Delegates.DoFindMinimumValue_NormalArgs _afterDoFindMinimumValue;

        private static void DoFindMinimumValue(Action<ArrayListGetMinValue> orig, ArrayListGetMinValue self)
        {
            Delegates.Params_DoFindMinimumValue @params = new()
            {
                self = self
            };
            _beforeDoFindMinimumValue?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoFindMinimumValue != null) _afterDoFindMinimumValue.Invoke(@params);
        }

        internal static void HookErrorCheck()
        {
            if (!HookedList.Contains("ErrorCheck"))
            {
                HookedList.Add("ErrorCheck");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "ErrorCheck"), ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_NormalArgs _afterErrorCheck;

        private static string ErrorCheck(Func<ArrayListGetMinValue, string> orig, ArrayListGetMinValue self)
        {
            Delegates.Params_ErrorCheck @params = new()
            {
                self = self
            };
            _beforeErrorCheck?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterErrorCheck != null) retVal = _afterErrorCheck.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoFindMinimumValue_BeforeArgs(Params_DoFindMinimumValue args);

        public delegate void DoFindMinimumValue_NormalArgs(Params_DoFindMinimumValue args);

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_NormalArgs(Params_ErrorCheck args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public ArrayListGetMinValue self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListGetMinValue self;
        }

        public sealed class Params_OnUpdate
        {
            public ArrayListGetMinValue self;
        }

        public sealed class Params_DoFindMinimumValue
        {
            public ArrayListGetMinValue self;
        }

        public sealed class Params_ErrorCheck
        {
            public ArrayListGetMinValue self;
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

        public static event Delegates.DoFindMinimumValue_BeforeArgs DoFindMinimumValue
        {
            add
            {
                HookHandler._beforeDoFindMinimumValue += value;
                HookHandler.HookDoFindMinimumValue();
            }
            remove => HookHandler._beforeDoFindMinimumValue -= value;
        }

        public static event Delegates.ErrorCheck_BeforeArgs ErrorCheck
        {
            add
            {
                HookHandler._beforeErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._beforeErrorCheck -= value;
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

        public static event Delegates.DoFindMinimumValue_NormalArgs DoFindMinimumValue
        {
            add
            {
                HookHandler._afterDoFindMinimumValue += value;
                HookHandler.HookDoFindMinimumValue();
            }
            remove => HookHandler._afterDoFindMinimumValue -= value;
        }

        public static event Delegates.ErrorCheck_NormalArgs ErrorCheck
        {
            add
            {
                HookHandler._afterErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._afterErrorCheck -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "OnUpdate"), value);
        }

        public static event Delegates.DoFindMinimumValue_NormalArgs DoFindMinimumValue
        {
            add => HookEndpointManager.Add<Delegates.DoFindMinimumValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "DoFindMinimumValue"), value);
            remove => HookEndpointManager.Remove<Delegates.DoFindMinimumValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "DoFindMinimumValue"), value);
        }

        public static event Delegates.ErrorCheck_NormalArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "ErrorCheck"), value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetMinValue), "ErrorCheck"), value);
        }
    }
}