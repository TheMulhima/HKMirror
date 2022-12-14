using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for uGuiSliderGetMinMax class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnuGuiSliderGetMinMax
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<uGuiSliderGetMinMax> orig, uGuiSliderGetMinMax self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<uGuiSliderGetMinMax> orig, uGuiSliderGetMinMax self)
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

        internal static void HookDoGetValue()
        {
            if (!HookedList.Contains("DoGetValue"))
            {
                HookedList.Add("DoGetValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "DoGetValue"), DoGetValue);
            }
        }

        internal static event Delegates.DoGetValue_BeforeArgs _beforeDoGetValue;
        internal static event Delegates.DoGetValue_AfterArgs _afterDoGetValue;

        private static void DoGetValue(Action<uGuiSliderGetMinMax> orig, uGuiSliderGetMinMax self)
        {
            Delegates.Params_DoGetValue @params = new()
            {
                self = self
            };
            if (_beforeDoGetValue != null)
                foreach (Delegates.DoGetValue_BeforeArgs toInvoke in _beforeDoGetValue.GetInvocationList())
                    try
                    {
                        _beforeDoGetValue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoGetValue != null)
                foreach (Delegates.DoGetValue_AfterArgs toInvoke in _afterDoGetValue.GetInvocationList())
                    try
                    {
                        _afterDoGetValue.Invoke(@params);
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
        public delegate void DoGetValue_AfterArgs(Params_DoGetValue args);

        public delegate void DoGetValue_BeforeArgs(Params_DoGetValue args);

        public delegate void DoGetValue_WithArgs(Action<uGuiSliderGetMinMax> orig, uGuiSliderGetMinMax self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<uGuiSliderGetMinMax> orig, uGuiSliderGetMinMax self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<uGuiSliderGetMinMax> orig, uGuiSliderGetMinMax self);

        public sealed class Params_Reset
        {
            public uGuiSliderGetMinMax self;
        }

        public sealed class Params_OnEnter
        {
            public uGuiSliderGetMinMax self;
        }

        public sealed class Params_DoGetValue
        {
            public uGuiSliderGetMinMax self;
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

        public static event Delegates.DoGetValue_BeforeArgs DoGetValue
        {
            add
            {
                HookHandler._beforeDoGetValue += value;
                HookHandler.HookDoGetValue();
            }
            remove => HookHandler._beforeDoGetValue -= value;
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

        public static event Delegates.DoGetValue_AfterArgs DoGetValue
        {
            add
            {
                HookHandler._afterDoGetValue += value;
                HookHandler.HookDoGetValue();
            }
            remove => HookHandler._afterDoGetValue -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "OnEnter"), value);
        }

        public static event Delegates.DoGetValue_WithArgs DoGetValue
        {
            add => HookEndpointManager.Add<Delegates.DoGetValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "DoGetValue"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSliderGetMinMax), "DoGetValue"), value);
        }
    }
}