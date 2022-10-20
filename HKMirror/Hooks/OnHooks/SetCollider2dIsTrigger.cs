using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetCollider2dIsTrigger class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetCollider2dIsTrigger
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self)
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

        internal static void HookDoSetIsTrigger()
        {
            if (!HookedList.Contains("DoSetIsTrigger"))
            {
                HookedList.Add("DoSetIsTrigger");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "DoSetIsTrigger"),
                    DoSetIsTrigger);
            }
        }

        internal static event Delegates.DoSetIsTrigger_BeforeArgs _beforeDoSetIsTrigger;
        internal static event Delegates.DoSetIsTrigger_NormalArgs _afterDoSetIsTrigger;

        private static void DoSetIsTrigger(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self)
        {
            Delegates.Params_DoSetIsTrigger @params = new()
            {
                self = self
            };
            _beforeDoSetIsTrigger?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSetIsTrigger != null) _afterDoSetIsTrigger.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoSetIsTrigger_BeforeArgs(Params_DoSetIsTrigger args);

        public delegate void DoSetIsTrigger_NormalArgs(Params_DoSetIsTrigger args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public SetCollider2dIsTrigger self;
        }

        public sealed class Params_OnEnter
        {
            public SetCollider2dIsTrigger self;
        }

        public sealed class Params_DoSetIsTrigger
        {
            public SetCollider2dIsTrigger self;
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

        public static event Delegates.DoSetIsTrigger_BeforeArgs DoSetIsTrigger
        {
            add
            {
                HookHandler._beforeDoSetIsTrigger += value;
                HookHandler.HookDoSetIsTrigger();
            }
            remove => HookHandler._beforeDoSetIsTrigger -= value;
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

        public static event Delegates.DoSetIsTrigger_NormalArgs DoSetIsTrigger
        {
            add
            {
                HookHandler._afterDoSetIsTrigger += value;
                HookHandler.HookDoSetIsTrigger();
            }
            remove => HookHandler._afterDoSetIsTrigger -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "OnEnter"), value);
        }

        public static event Delegates.DoSetIsTrigger_NormalArgs DoSetIsTrigger
        {
            add => HookEndpointManager.Add<Delegates.DoSetIsTrigger_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "DoSetIsTrigger"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetIsTrigger_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "DoSetIsTrigger"), value);
        }
    }
}