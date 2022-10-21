using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for HashTableValues class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHashTableValues
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.HashTableValues> orig,
            HutongGames.PlayMaker.Actions.HashTableValues self)
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.HashTableValues> orig,
            HutongGames.PlayMaker.Actions.HashTableValues self)
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

        internal static void HookdoHashTableValues()
        {
            if (!HookedList.Contains("doHashTableValues"))
            {
                HookedList.Add("doHashTableValues");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues),
                        "doHashTableValues", true), doHashTableValues);
            }
        }

        internal static event Delegates.doHashTableValues_BeforeArgs _beforedoHashTableValues;
        internal static event Delegates.doHashTableValues_AfterArgs _afterdoHashTableValues;

        private static void doHashTableValues(Action<HutongGames.PlayMaker.Actions.HashTableValues> orig,
            HutongGames.PlayMaker.Actions.HashTableValues self)
        {
            Delegates.Params_doHashTableValues @params = new()
            {
                self = self
            };
            if (_beforedoHashTableValues != null)
            {
                foreach (Delegates.doHashTableValues_BeforeArgs toInvoke in
                         _beforedoHashTableValues.GetInvocationList())
                {
                    try
                    {
                        _beforedoHashTableValues?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterdoHashTableValues != null)
            {
                foreach (Delegates.doHashTableValues_AfterArgs toInvoke in _afterdoHashTableValues.GetInvocationList())
                {
                    try
                    {
                        _afterdoHashTableValues.Invoke(@params);
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
            public HutongGames.PlayMaker.Actions.HashTableValues self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.HashTableValues> orig,
            HutongGames.PlayMaker.Actions.HashTableValues self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.HashTableValues self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.HashTableValues> orig,
            HutongGames.PlayMaker.Actions.HashTableValues self);

        public sealed class Params_doHashTableValues
        {
            public HutongGames.PlayMaker.Actions.HashTableValues self;
        }

        public delegate void doHashTableValues_BeforeArgs(Params_doHashTableValues args);

        public delegate void doHashTableValues_AfterArgs(Params_doHashTableValues args);

        public delegate void doHashTableValues_WithArgs(Action<HutongGames.PlayMaker.Actions.HashTableValues> orig,
            HutongGames.PlayMaker.Actions.HashTableValues self);
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

        public static event Delegates.doHashTableValues_BeforeArgs doHashTableValues
        {
            add
            {
                HookHandler._beforedoHashTableValues += value;
                HookHandler.HookdoHashTableValues();
            }
            remove => HookHandler._beforedoHashTableValues -= value;
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

        public static event Delegates.doHashTableValues_AfterArgs doHashTableValues
        {
            add
            {
                HookHandler._afterdoHashTableValues += value;
                HookHandler.HookdoHashTableValues();
            }
            remove => HookHandler._afterdoHashTableValues -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues), "Reset", true),
                value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues), "OnEnter", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues), "OnEnter", true),
                value);
        }

        public static event Delegates.doHashTableValues_WithArgs doHashTableValues
        {
            add => HookEndpointManager.Add<Delegates.doHashTableValues_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues),
                    "doHashTableValues", true), value);
            remove => HookEndpointManager.Remove<Delegates.doHashTableValues_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.HashTableValues),
                    "doHashTableValues", true), value);
        }
    }
}