using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for ConvertFloatToInt class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnConvertFloatToInt
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self)
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "OnUpdate",
                        true), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
            {
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
            {
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoConvertFloatToInt()
        {
            if (!HookedList.Contains("DoConvertFloatToInt"))
            {
                HookedList.Add("DoConvertFloatToInt");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt),
                        "DoConvertFloatToInt", true), DoConvertFloatToInt);
            }
        }

        internal static event Delegates.DoConvertFloatToInt_BeforeArgs _beforeDoConvertFloatToInt;
        internal static event Delegates.DoConvertFloatToInt_AfterArgs _afterDoConvertFloatToInt;

        private static void DoConvertFloatToInt(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self)
        {
            Delegates.Params_DoConvertFloatToInt @params = new()
            {
                self = self
            };
            if (_beforeDoConvertFloatToInt != null)
            {
                foreach (Delegates.DoConvertFloatToInt_BeforeArgs toInvoke in _beforeDoConvertFloatToInt
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeDoConvertFloatToInt?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoConvertFloatToInt != null)
            {
                foreach (Delegates.DoConvertFloatToInt_AfterArgs toInvoke in
                         _afterDoConvertFloatToInt.GetInvocationList())
                {
                    try
                    {
                        _afterDoConvertFloatToInt.Invoke(@params);
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
            public HutongGames.PlayMaker.Actions.ConvertFloatToInt self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.ConvertFloatToInt self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self);

        public sealed class Params_OnUpdate
        {
            public HutongGames.PlayMaker.Actions.ConvertFloatToInt self;
        }

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self);

        public sealed class Params_DoConvertFloatToInt
        {
            public HutongGames.PlayMaker.Actions.ConvertFloatToInt self;
        }

        public delegate void DoConvertFloatToInt_BeforeArgs(Params_DoConvertFloatToInt args);

        public delegate void DoConvertFloatToInt_AfterArgs(Params_DoConvertFloatToInt args);

        public delegate void DoConvertFloatToInt_WithArgs(Action<HutongGames.PlayMaker.Actions.ConvertFloatToInt> orig,
            HutongGames.PlayMaker.Actions.ConvertFloatToInt self);
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoConvertFloatToInt_BeforeArgs DoConvertFloatToInt
        {
            add
            {
                HookHandler._beforeDoConvertFloatToInt += value;
                HookHandler.HookDoConvertFloatToInt();
            }
            remove => HookHandler._beforeDoConvertFloatToInt -= value;
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

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoConvertFloatToInt_AfterArgs DoConvertFloatToInt
        {
            add
            {
                HookHandler._afterDoConvertFloatToInt += value;
                HookHandler.HookDoConvertFloatToInt();
            }
            remove => HookHandler._afterDoConvertFloatToInt -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "Reset", true),
                value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "OnEnter",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "OnEnter",
                    true), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "OnUpdate",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt), "OnUpdate",
                    true), value);
        }

        public static event Delegates.DoConvertFloatToInt_WithArgs DoConvertFloatToInt
        {
            add => HookEndpointManager.Add<Delegates.DoConvertFloatToInt_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt),
                    "DoConvertFloatToInt", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoConvertFloatToInt_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ConvertFloatToInt),
                    "DoConvertFloatToInt", true), value);
        }
    }
}