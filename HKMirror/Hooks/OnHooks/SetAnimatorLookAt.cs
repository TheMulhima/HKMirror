using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for SetAnimatorLookAt class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetAnimatorLookAt
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self)
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

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt),
                        "OnPreprocess", true), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self)
        {
            Delegates.Params_OnPreprocess @params = new()
            {
                self = self
            };
            if (_beforeOnPreprocess != null)
            {
                foreach (Delegates.OnPreprocess_BeforeArgs toInvoke in _beforeOnPreprocess.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPreprocess?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnPreprocess != null)
            {
                foreach (Delegates.OnPreprocess_AfterArgs toInvoke in _afterOnPreprocess.GetInvocationList())
                {
                    try
                    {
                        _afterOnPreprocess.Invoke(@params);
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self)
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

        internal static void HookDoAnimatorIK()
        {
            if (!HookedList.Contains("DoAnimatorIK"))
            {
                HookedList.Add("DoAnimatorIK");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt),
                        "DoAnimatorIK", true), DoAnimatorIK);
            }
        }

        internal static event Delegates.DoAnimatorIK_BeforeArgs _beforeDoAnimatorIK;
        internal static event Delegates.DoAnimatorIK_AfterArgs _afterDoAnimatorIK;

        private static void DoAnimatorIK(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt, int> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self, int layerIndex)
        {
            Delegates.Params_DoAnimatorIK @params = new()
            {
                self = self, layerIndex = layerIndex
            };
            if (_beforeDoAnimatorIK != null)
            {
                foreach (Delegates.DoAnimatorIK_BeforeArgs toInvoke in _beforeDoAnimatorIK.GetInvocationList())
                {
                    try
                    {
                        _beforeDoAnimatorIK?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            layerIndex = @params.layerIndex;
            orig(self, layerIndex);
            if (_afterDoAnimatorIK != null)
            {
                foreach (Delegates.DoAnimatorIK_AfterArgs toInvoke in _afterDoAnimatorIK.GetInvocationList())
                {
                    try
                    {
                        _afterDoAnimatorIK.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoSetLookAt()
        {
            if (!HookedList.Contains("DoSetLookAt"))
            {
                HookedList.Add("DoSetLookAt");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt),
                        "DoSetLookAt", true), DoSetLookAt);
            }
        }

        internal static event Delegates.DoSetLookAt_BeforeArgs _beforeDoSetLookAt;
        internal static event Delegates.DoSetLookAt_AfterArgs _afterDoSetLookAt;

        private static void DoSetLookAt(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self)
        {
            Delegates.Params_DoSetLookAt @params = new()
            {
                self = self
            };
            if (_beforeDoSetLookAt != null)
            {
                foreach (Delegates.DoSetLookAt_BeforeArgs toInvoke in _beforeDoSetLookAt.GetInvocationList())
                {
                    try
                    {
                        _beforeDoSetLookAt?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoSetLookAt != null)
            {
                foreach (Delegates.DoSetLookAt_AfterArgs toInvoke in _afterDoSetLookAt.GetInvocationList())
                {
                    try
                    {
                        _afterDoSetLookAt.Invoke(@params);
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
            public HutongGames.PlayMaker.Actions.SetAnimatorLookAt self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self);

        public sealed class Params_OnPreprocess
        {
            public HutongGames.PlayMaker.Actions.SetAnimatorLookAt self;
        }

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_WithArgs(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.SetAnimatorLookAt self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self);

        public sealed class Params_DoAnimatorIK
        {
            public HutongGames.PlayMaker.Actions.SetAnimatorLookAt self;
            public int layerIndex;
        }

        public delegate void DoAnimatorIK_BeforeArgs(Params_DoAnimatorIK args);

        public delegate void DoAnimatorIK_AfterArgs(Params_DoAnimatorIK args);

        public delegate void DoAnimatorIK_WithArgs(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt, int> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self, int layerIndex);

        public sealed class Params_DoSetLookAt
        {
            public HutongGames.PlayMaker.Actions.SetAnimatorLookAt self;
        }

        public delegate void DoSetLookAt_BeforeArgs(Params_DoSetLookAt args);

        public delegate void DoSetLookAt_AfterArgs(Params_DoSetLookAt args);

        public delegate void DoSetLookAt_WithArgs(Action<HutongGames.PlayMaker.Actions.SetAnimatorLookAt> orig,
            HutongGames.PlayMaker.Actions.SetAnimatorLookAt self);
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

        public static event Delegates.OnPreprocess_BeforeArgs OnPreprocess
        {
            add
            {
                HookHandler._beforeOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._beforeOnPreprocess -= value;
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

        public static event Delegates.DoAnimatorIK_BeforeArgs DoAnimatorIK
        {
            add
            {
                HookHandler._beforeDoAnimatorIK += value;
                HookHandler.HookDoAnimatorIK();
            }
            remove => HookHandler._beforeDoAnimatorIK -= value;
        }

        public static event Delegates.DoSetLookAt_BeforeArgs DoSetLookAt
        {
            add
            {
                HookHandler._beforeDoSetLookAt += value;
                HookHandler.HookDoSetLookAt();
            }
            remove => HookHandler._beforeDoSetLookAt -= value;
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

        public static event Delegates.OnPreprocess_AfterArgs OnPreprocess
        {
            add
            {
                HookHandler._afterOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._afterOnPreprocess -= value;
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

        public static event Delegates.DoAnimatorIK_AfterArgs DoAnimatorIK
        {
            add
            {
                HookHandler._afterDoAnimatorIK += value;
                HookHandler.HookDoAnimatorIK();
            }
            remove => HookHandler._afterDoAnimatorIK -= value;
        }

        public static event Delegates.DoSetLookAt_AfterArgs DoSetLookAt
        {
            add
            {
                HookHandler._afterDoSetLookAt += value;
                HookHandler.HookDoSetLookAt();
            }
            remove => HookHandler._afterDoSetLookAt -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "Reset", true),
                value);
        }

        public static event Delegates.OnPreprocess_WithArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "OnPreprocess",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "OnPreprocess",
                    true), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "OnEnter",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "OnEnter",
                    true), value);
        }

        public static event Delegates.DoAnimatorIK_WithArgs DoAnimatorIK
        {
            add => HookEndpointManager.Add<Delegates.DoAnimatorIK_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "DoAnimatorIK",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoAnimatorIK_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "DoAnimatorIK",
                    true), value);
        }

        public static event Delegates.DoSetLookAt_WithArgs DoSetLookAt
        {
            add => HookEndpointManager.Add<Delegates.DoSetLookAt_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "DoSetLookAt",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetLookAt_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.SetAnimatorLookAt), "DoSetLookAt",
                    true), value);
        }
    }
}