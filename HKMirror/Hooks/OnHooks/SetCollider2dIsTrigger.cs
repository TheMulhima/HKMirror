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
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self)
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
        internal static event Delegates.DoSetIsTrigger_AfterArgs _afterDoSetIsTrigger;

        private static void DoSetIsTrigger(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self)
        {
            Delegates.Params_DoSetIsTrigger @params = new()
            {
                self = self
            };
            if (_beforeDoSetIsTrigger != null)
                foreach (Delegates.DoSetIsTrigger_BeforeArgs toInvoke in _beforeDoSetIsTrigger.GetInvocationList())
                    try
                    {
                        _beforeDoSetIsTrigger?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetIsTrigger != null)
                foreach (Delegates.DoSetIsTrigger_AfterArgs toInvoke in _afterDoSetIsTrigger.GetInvocationList())
                    try
                    {
                        _afterDoSetIsTrigger.Invoke(@params);
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
        public delegate void DoSetIsTrigger_AfterArgs(Params_DoSetIsTrigger args);

        public delegate void DoSetIsTrigger_BeforeArgs(Params_DoSetIsTrigger args);

        public delegate void DoSetIsTrigger_WithArgs(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<SetCollider2dIsTrigger> orig, SetCollider2dIsTrigger self);

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

        public static event Delegates.DoSetIsTrigger_AfterArgs DoSetIsTrigger
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
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "OnEnter"), value);
        }

        public static event Delegates.DoSetIsTrigger_WithArgs DoSetIsTrigger
        {
            add => HookEndpointManager.Add<Delegates.DoSetIsTrigger_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "DoSetIsTrigger"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetIsTrigger_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetCollider2dIsTrigger), "DoSetIsTrigger"), value);
        }
    }
}