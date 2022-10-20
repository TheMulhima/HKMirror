using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SelectRandomColor class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSelectRandomColor
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<SelectRandomColor> orig, SelectRandomColor self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<SelectRandomColor> orig, SelectRandomColor self)
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

        internal static void HookDoSelectRandomColor()
        {
            if (!HookedList.Contains("DoSelectRandomColor"))
            {
                HookedList.Add("DoSelectRandomColor");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "DoSelectRandomColor"),
                    DoSelectRandomColor);
            }
        }

        internal static event Delegates.DoSelectRandomColor_BeforeArgs _beforeDoSelectRandomColor;
        internal static event Delegates.DoSelectRandomColor_NormalArgs _afterDoSelectRandomColor;

        private static void DoSelectRandomColor(Action<SelectRandomColor> orig, SelectRandomColor self)
        {
            Delegates.Params_DoSelectRandomColor @params = new()
            {
                self = self
            };
            _beforeDoSelectRandomColor?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSelectRandomColor != null) _afterDoSelectRandomColor.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoSelectRandomColor_BeforeArgs(Params_DoSelectRandomColor args);

        public delegate void DoSelectRandomColor_NormalArgs(Params_DoSelectRandomColor args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public SelectRandomColor self;
        }

        public sealed class Params_OnEnter
        {
            public SelectRandomColor self;
        }

        public sealed class Params_DoSelectRandomColor
        {
            public SelectRandomColor self;
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

        public static event Delegates.DoSelectRandomColor_BeforeArgs DoSelectRandomColor
        {
            add
            {
                HookHandler._beforeDoSelectRandomColor += value;
                HookHandler.HookDoSelectRandomColor();
            }
            remove => HookHandler._beforeDoSelectRandomColor -= value;
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

        public static event Delegates.DoSelectRandomColor_NormalArgs DoSelectRandomColor
        {
            add
            {
                HookHandler._afterDoSelectRandomColor += value;
                HookHandler.HookDoSelectRandomColor();
            }
            remove => HookHandler._afterDoSelectRandomColor -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "OnEnter"), value);
        }

        public static event Delegates.DoSelectRandomColor_NormalArgs DoSelectRandomColor
        {
            add => HookEndpointManager.Add<Delegates.DoSelectRandomColor_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "DoSelectRandomColor"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSelectRandomColor_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SelectRandomColor), "DoSelectRandomColor"), value);
        }
    }
}