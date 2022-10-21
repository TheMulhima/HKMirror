using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for GetAnimatorPivot class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetAnimatorPivot
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self)
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self)
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

        internal static void HookOnActionUpdate()
        {
            if (!HookedList.Contains("OnActionUpdate"))
            {
                HookedList.Add("OnActionUpdate");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot),
                        "OnActionUpdate", true), OnActionUpdate);
            }
        }

        internal static event Delegates.OnActionUpdate_BeforeArgs _beforeOnActionUpdate;
        internal static event Delegates.OnActionUpdate_AfterArgs _afterOnActionUpdate;

        private static void OnActionUpdate(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self)
        {
            Delegates.Params_OnActionUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnActionUpdate != null)
            {
                foreach (Delegates.OnActionUpdate_BeforeArgs toInvoke in _beforeOnActionUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeOnActionUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnActionUpdate != null)
            {
                foreach (Delegates.OnActionUpdate_AfterArgs toInvoke in _afterOnActionUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterOnActionUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoCheckPivot()
        {
            if (!HookedList.Contains("DoCheckPivot"))
            {
                HookedList.Add("DoCheckPivot");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot),
                        "DoCheckPivot", true), DoCheckPivot);
            }
        }

        internal static event Delegates.DoCheckPivot_BeforeArgs _beforeDoCheckPivot;
        internal static event Delegates.DoCheckPivot_AfterArgs _afterDoCheckPivot;

        private static void DoCheckPivot(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self)
        {
            Delegates.Params_DoCheckPivot @params = new()
            {
                self = self
            };
            if (_beforeDoCheckPivot != null)
            {
                foreach (Delegates.DoCheckPivot_BeforeArgs toInvoke in _beforeDoCheckPivot.GetInvocationList())
                {
                    try
                    {
                        _beforeDoCheckPivot?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoCheckPivot != null)
            {
                foreach (Delegates.DoCheckPivot_AfterArgs toInvoke in _afterDoCheckPivot.GetInvocationList())
                {
                    try
                    {
                        _afterDoCheckPivot.Invoke(@params);
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
            public HutongGames.PlayMaker.Actions.GetAnimatorPivot self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.GetAnimatorPivot self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self);

        public sealed class Params_OnActionUpdate
        {
            public HutongGames.PlayMaker.Actions.GetAnimatorPivot self;
        }

        public delegate void OnActionUpdate_BeforeArgs(Params_OnActionUpdate args);

        public delegate void OnActionUpdate_AfterArgs(Params_OnActionUpdate args);

        public delegate void OnActionUpdate_WithArgs(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self);

        public sealed class Params_DoCheckPivot
        {
            public HutongGames.PlayMaker.Actions.GetAnimatorPivot self;
        }

        public delegate void DoCheckPivot_BeforeArgs(Params_DoCheckPivot args);

        public delegate void DoCheckPivot_AfterArgs(Params_DoCheckPivot args);

        public delegate void DoCheckPivot_WithArgs(Action<HutongGames.PlayMaker.Actions.GetAnimatorPivot> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorPivot self);
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

        public static event Delegates.OnActionUpdate_BeforeArgs OnActionUpdate
        {
            add
            {
                HookHandler._beforeOnActionUpdate += value;
                HookHandler.HookOnActionUpdate();
            }
            remove => HookHandler._beforeOnActionUpdate -= value;
        }

        public static event Delegates.DoCheckPivot_BeforeArgs DoCheckPivot
        {
            add
            {
                HookHandler._beforeDoCheckPivot += value;
                HookHandler.HookDoCheckPivot();
            }
            remove => HookHandler._beforeDoCheckPivot -= value;
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

        public static event Delegates.OnActionUpdate_AfterArgs OnActionUpdate
        {
            add
            {
                HookHandler._afterOnActionUpdate += value;
                HookHandler.HookOnActionUpdate();
            }
            remove => HookHandler._afterOnActionUpdate -= value;
        }

        public static event Delegates.DoCheckPivot_AfterArgs DoCheckPivot
        {
            add
            {
                HookHandler._afterDoCheckPivot += value;
                HookHandler.HookDoCheckPivot();
            }
            remove => HookHandler._afterDoCheckPivot -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "Reset", true),
                value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "OnEnter", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "OnEnter", true),
                value);
        }

        public static event Delegates.OnActionUpdate_WithArgs OnActionUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnActionUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "OnActionUpdate",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnActionUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "OnActionUpdate",
                    true), value);
        }

        public static event Delegates.DoCheckPivot_WithArgs DoCheckPivot
        {
            add => HookEndpointManager.Add<Delegates.DoCheckPivot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "DoCheckPivot",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoCheckPivot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorPivot), "DoCheckPivot",
                    true), value);
        }
    }
}