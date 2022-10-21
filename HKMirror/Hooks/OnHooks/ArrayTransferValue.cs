using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for ArrayTransferValue class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayTransferValue
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.ArrayTransferValue> orig,
            HutongGames.PlayMaker.Actions.ArrayTransferValue self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.ArrayTransferValue> orig,
            HutongGames.PlayMaker.Actions.ArrayTransferValue self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
            {
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
            {
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoTransferValue()
        {
            if (!HookedList.Contains("DoTransferValue"))
            {
                HookedList.Add("DoTransferValue");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue),
                        "DoTransferValue", true), DoTransferValue);
            }
        }

        internal static event Delegates.DoTransferValue_BeforeArgs _beforeDoTransferValue;
        internal static event Delegates.DoTransferValue_AfterArgs _afterDoTransferValue;

        private static void DoTransferValue(Action<HutongGames.PlayMaker.Actions.ArrayTransferValue> orig,
            HutongGames.PlayMaker.Actions.ArrayTransferValue self)
        {
            Delegates.Params_DoTransferValue @params = new()
            {
                self = self
            };
            if (_beforeDoTransferValue != null)
            {
                foreach (Delegates.DoTransferValue_BeforeArgs toInvoke in _beforeDoTransferValue.GetInvocationList())
                {
                    try
                    {
                        _beforeDoTransferValue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoTransferValue != null)
            {
                foreach (Delegates.DoTransferValue_AfterArgs toInvoke in _afterDoTransferValue.GetInvocationList())
                {
                    try
                    {
                        _afterDoTransferValue.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.ArrayTransferValue self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.ArrayTransferValue> orig,
            HutongGames.PlayMaker.Actions.ArrayTransferValue self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.ArrayTransferValue self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.ArrayTransferValue> orig,
            HutongGames.PlayMaker.Actions.ArrayTransferValue self);

        public sealed class Params_DoTransferValue
        {
            public HutongGames.PlayMaker.Actions.ArrayTransferValue self;
        }

        public delegate void DoTransferValue_BeforeArgs(Params_DoTransferValue args);

        public delegate void DoTransferValue_AfterArgs(Params_DoTransferValue args);

        public delegate void DoTransferValue_WithArgs(Action<HutongGames.PlayMaker.Actions.ArrayTransferValue> orig,
            HutongGames.PlayMaker.Actions.ArrayTransferValue self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.DoTransferValue_BeforeArgs DoTransferValue
        {
            add
            {
                HookHandler._beforeDoTransferValue += value;
                HookHandler.HookDoTransferValue();
            }
            remove => HookHandler._beforeDoTransferValue -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.DoTransferValue_AfterArgs DoTransferValue
        {
            add
            {
                HookHandler._afterDoTransferValue += value;
                HookHandler.HookDoTransferValue();
            }
            remove => HookHandler._afterDoTransferValue -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue), "Reset", true),
                value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue), "OnEnter",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue), "OnEnter",
                    true), value);
        }

        public static event Delegates.DoTransferValue_WithArgs DoTransferValue
        {
            add => HookEndpointManager.Add<Delegates.DoTransferValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue),
                    "DoTransferValue", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoTransferValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayTransferValue),
                    "DoTransferValue", true), value);
        }
    }
}