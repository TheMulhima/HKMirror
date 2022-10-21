using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for ResolutionCountdownTimer class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnResolutionCountdownTimer
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.ResolutionCountdownTimer.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.ResolutionCountdownTimer.orig_Start orig, ResolutionCountdownTimer self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
            {
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                {
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
            {
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                {
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookStartTimer()
        {
            if (!HookedList.Contains("StartTimer"))
            {
                HookedList.Add("StartTimer");
                On.ResolutionCountdownTimer.StartTimer += StartTimer;
            }
        }

        internal static event Delegates.StartTimer_BeforeArgs _beforeStartTimer;
        internal static event Delegates.StartTimer_AfterArgs _afterStartTimer;

        private static void StartTimer(On.ResolutionCountdownTimer.orig_StartTimer orig, ResolutionCountdownTimer self)
        {
            Delegates.Params_StartTimer @params = new()
            {
                self = self
            };
            if (_beforeStartTimer != null)
            {
                foreach (Delegates.StartTimer_BeforeArgs toInvoke in _beforeStartTimer.GetInvocationList())
                {
                    try
                    {
                        _beforeStartTimer?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStartTimer != null)
            {
                foreach (Delegates.StartTimer_AfterArgs toInvoke in _afterStartTimer.GetInvocationList())
                {
                    try
                    {
                        _afterStartTimer.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookCancelTimer()
        {
            if (!HookedList.Contains("CancelTimer"))
            {
                HookedList.Add("CancelTimer");
                On.ResolutionCountdownTimer.CancelTimer += CancelTimer;
            }
        }

        internal static event Delegates.CancelTimer_BeforeArgs _beforeCancelTimer;
        internal static event Delegates.CancelTimer_AfterArgs _afterCancelTimer;

        private static void CancelTimer(On.ResolutionCountdownTimer.orig_CancelTimer orig,
            ResolutionCountdownTimer self)
        {
            Delegates.Params_CancelTimer @params = new()
            {
                self = self
            };
            if (_beforeCancelTimer != null)
            {
                foreach (Delegates.CancelTimer_BeforeArgs toInvoke in _beforeCancelTimer.GetInvocationList())
                {
                    try
                    {
                        _beforeCancelTimer?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterCancelTimer != null)
            {
                foreach (Delegates.CancelTimer_AfterArgs toInvoke in _afterCancelTimer.GetInvocationList())
                {
                    try
                    {
                        _afterCancelTimer.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookTickDown()
        {
            if (!HookedList.Contains("TickDown"))
            {
                HookedList.Add("TickDown");
                On.ResolutionCountdownTimer.TickDown += TickDown;
            }
        }

        internal static event Delegates.TickDown_BeforeArgs _beforeTickDown;
        internal static event Delegates.TickDown_AfterArgs _afterTickDown;

        private static void TickDown(On.ResolutionCountdownTimer.orig_TickDown orig, ResolutionCountdownTimer self)
        {
            Delegates.Params_TickDown @params = new()
            {
                self = self
            };
            if (_beforeTickDown != null)
            {
                foreach (Delegates.TickDown_BeforeArgs toInvoke in _beforeTickDown.GetInvocationList())
                {
                    try
                    {
                        _beforeTickDown?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterTickDown != null)
            {
                foreach (Delegates.TickDown_AfterArgs toInvoke in _afterTickDown.GetInvocationList())
                {
                    try
                    {
                        _afterTickDown.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookCountDown()
        {
            if (!HookedList.Contains("CountDown"))
            {
                HookedList.Add("CountDown");
                On.ResolutionCountdownTimer.CountDown += CountDown;
            }
        }

        internal static event Delegates.CountDown_BeforeArgs _beforeCountDown;

        private static System.Collections.IEnumerator CountDown(On.ResolutionCountdownTimer.orig_CountDown orig,
            ResolutionCountdownTimer self)
        {
            Delegates.Params_CountDown @params = new()
            {
                self = self
            };
            if (_beforeCountDown != null)
            {
                foreach (Delegates.CountDown_BeforeArgs toInvoke in _beforeCountDown.GetInvocationList())
                {
                    try
                    {
                        _beforeCountDown?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            return orig(self);
        }

        internal static void HookRollbackRes()
        {
            if (!HookedList.Contains("RollbackRes"))
            {
                HookedList.Add("RollbackRes");
                On.ResolutionCountdownTimer.RollbackRes += RollbackRes;
            }
        }

        internal static event Delegates.RollbackRes_BeforeArgs _beforeRollbackRes;

        private static System.Collections.IEnumerator RollbackRes(On.ResolutionCountdownTimer.orig_RollbackRes orig,
            ResolutionCountdownTimer self)
        {
            Delegates.Params_RollbackRes @params = new()
            {
                self = self
            };
            if (_beforeRollbackRes != null)
            {
                foreach (Delegates.RollbackRes_BeforeArgs toInvoke in _beforeRollbackRes.GetInvocationList())
                {
                    try
                    {
                        _beforeRollbackRes?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Start
        {
            public ResolutionCountdownTimer self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<ResolutionCountdownTimer> orig, ResolutionCountdownTimer self);

        public sealed class Params_StartTimer
        {
            public ResolutionCountdownTimer self;
        }

        public delegate void StartTimer_BeforeArgs(Params_StartTimer args);

        public delegate void StartTimer_AfterArgs(Params_StartTimer args);

        public delegate void StartTimer_WithArgs(Action<ResolutionCountdownTimer> orig, ResolutionCountdownTimer self);

        public sealed class Params_CancelTimer
        {
            public ResolutionCountdownTimer self;
        }

        public delegate void CancelTimer_BeforeArgs(Params_CancelTimer args);

        public delegate void CancelTimer_AfterArgs(Params_CancelTimer args);

        public delegate void CancelTimer_WithArgs(Action<ResolutionCountdownTimer> orig, ResolutionCountdownTimer self);

        public sealed class Params_TickDown
        {
            public ResolutionCountdownTimer self;
        }

        public delegate void TickDown_BeforeArgs(Params_TickDown args);

        public delegate void TickDown_AfterArgs(Params_TickDown args);

        public delegate void TickDown_WithArgs(Action<ResolutionCountdownTimer> orig, ResolutionCountdownTimer self);

        public sealed class Params_CountDown
        {
            public ResolutionCountdownTimer self;
        }

        public delegate void CountDown_BeforeArgs(Params_CountDown args);

        public delegate System.Collections.IEnumerator CountDown_AfterArgs(Params_CountDown args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator CountDown_WithArgs(
            Func<ResolutionCountdownTimer, System.Collections.IEnumerator> orig, ResolutionCountdownTimer self);

        public sealed class Params_RollbackRes
        {
            public ResolutionCountdownTimer self;
        }

        public delegate void RollbackRes_BeforeArgs(Params_RollbackRes args);

        public delegate System.Collections.IEnumerator RollbackRes_AfterArgs(Params_RollbackRes args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator RollbackRes_WithArgs(
            Func<ResolutionCountdownTimer, System.Collections.IEnumerator> orig, ResolutionCountdownTimer self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.StartTimer_BeforeArgs StartTimer
        {
            add
            {
                HookHandler._beforeStartTimer += value;
                HookHandler.HookStartTimer();
            }
            remove => HookHandler._beforeStartTimer -= value;
        }

        public static event Delegates.CancelTimer_BeforeArgs CancelTimer
        {
            add
            {
                HookHandler._beforeCancelTimer += value;
                HookHandler.HookCancelTimer();
            }
            remove => HookHandler._beforeCancelTimer -= value;
        }

        public static event Delegates.TickDown_BeforeArgs TickDown
        {
            add
            {
                HookHandler._beforeTickDown += value;
                HookHandler.HookTickDown();
            }
            remove => HookHandler._beforeTickDown -= value;
        }

        public static event Delegates.CountDown_BeforeArgs CountDown
        {
            add
            {
                HookHandler._beforeCountDown += value;
                HookHandler.HookCountDown();
            }
            remove => HookHandler._beforeCountDown -= value;
        }

        public static event Delegates.RollbackRes_BeforeArgs RollbackRes
        {
            add
            {
                HookHandler._beforeRollbackRes += value;
                HookHandler.HookRollbackRes();
            }
            remove => HookHandler._beforeRollbackRes -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.StartTimer_AfterArgs StartTimer
        {
            add
            {
                HookHandler._afterStartTimer += value;
                HookHandler.HookStartTimer();
            }
            remove => HookHandler._afterStartTimer -= value;
        }

        public static event Delegates.CancelTimer_AfterArgs CancelTimer
        {
            add
            {
                HookHandler._afterCancelTimer += value;
                HookHandler.HookCancelTimer();
            }
            remove => HookHandler._afterCancelTimer -= value;
        }

        public static event Delegates.TickDown_AfterArgs TickDown
        {
            add
            {
                HookHandler._afterTickDown += value;
                HookHandler.HookTickDown();
            }
            remove => HookHandler._afterTickDown -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.ResolutionCountdownTimer.hook_Start Start
        {
            add => On.ResolutionCountdownTimer.Start += value;
            remove => On.ResolutionCountdownTimer.Start -= value;
        }

        public static event On.ResolutionCountdownTimer.hook_StartTimer StartTimer
        {
            add => On.ResolutionCountdownTimer.StartTimer += value;
            remove => On.ResolutionCountdownTimer.StartTimer -= value;
        }

        public static event On.ResolutionCountdownTimer.hook_CancelTimer CancelTimer
        {
            add => On.ResolutionCountdownTimer.CancelTimer += value;
            remove => On.ResolutionCountdownTimer.CancelTimer -= value;
        }

        public static event On.ResolutionCountdownTimer.hook_TickDown TickDown
        {
            add => On.ResolutionCountdownTimer.TickDown += value;
            remove => On.ResolutionCountdownTimer.TickDown -= value;
        }

        public static event On.ResolutionCountdownTimer.hook_CountDown CountDown
        {
            add => On.ResolutionCountdownTimer.CountDown += value;
            remove => On.ResolutionCountdownTimer.CountDown -= value;
        }

        public static event On.ResolutionCountdownTimer.hook_RollbackRes RollbackRes
        {
            add => On.ResolutionCountdownTimer.RollbackRes += value;
            remove => On.ResolutionCountdownTimer.RollbackRes -= value;
        }
    }
}