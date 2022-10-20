using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for uGuiNavigationGetMode class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnuGuiNavigationGetMode
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<uGuiNavigationGetMode> orig, uGuiNavigationGetMode self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<uGuiNavigationGetMode> orig, uGuiNavigationGetMode self)
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

        internal static void HookDoGetValue()
        {
            if (!HookedList.Contains("DoGetValue"))
            {
                HookedList.Add("DoGetValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "DoGetValue"), DoGetValue);
            }
        }

        internal static event Delegates.DoGetValue_BeforeArgs _beforeDoGetValue;
        internal static event Delegates.DoGetValue_NormalArgs _afterDoGetValue;

        private static void DoGetValue(Action<uGuiNavigationGetMode> orig, uGuiNavigationGetMode self)
        {
            Delegates.Params_DoGetValue @params = new()
            {
                self = self
            };
            _beforeDoGetValue?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoGetValue != null) _afterDoGetValue.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoGetValue_BeforeArgs(Params_DoGetValue args);

        public delegate void DoGetValue_NormalArgs(Params_DoGetValue args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public uGuiNavigationGetMode self;
        }

        public sealed class Params_OnEnter
        {
            public uGuiNavigationGetMode self;
        }

        public sealed class Params_DoGetValue
        {
            public uGuiNavigationGetMode self;
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

        public static event Delegates.DoGetValue_NormalArgs DoGetValue
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
        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "OnEnter"), value);
        }

        public static event Delegates.DoGetValue_NormalArgs DoGetValue
        {
            add => HookEndpointManager.Add<Delegates.DoGetValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "DoGetValue"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiNavigationGetMode), "DoGetValue"), value);
        }
    }
}