using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for BossSummaryBoard class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossSummaryBoard
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.BossSummaryBoard.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.BossSummaryBoard.orig_Start orig, BossSummaryBoard self)
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

        internal static void HookShow()
        {
            if (!HookedList.Contains("Show"))
            {
                HookedList.Add("Show");
                On.BossSummaryBoard.Show += Show;
            }
        }

        internal static event Delegates.Show_BeforeArgs _beforeShow;
        internal static event Delegates.Show_AfterArgs _afterShow;

        private static void Show(On.BossSummaryBoard.orig_Show orig, BossSummaryBoard self)
        {
            Delegates.Params_Show @params = new()
            {
                self = self
            };
            if (_beforeShow != null)
            {
                foreach (Delegates.Show_BeforeArgs toInvoke in _beforeShow.GetInvocationList())
                {
                    try
                    {
                        _beforeShow?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterShow != null)
            {
                foreach (Delegates.Show_AfterArgs toInvoke in _afterShow.GetInvocationList())
                {
                    try
                    {
                        _afterShow.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookHide()
        {
            if (!HookedList.Contains("Hide"))
            {
                HookedList.Add("Hide");
                On.BossSummaryBoard.Hide += Hide;
            }
        }

        internal static event Delegates.Hide_BeforeArgs _beforeHide;
        internal static event Delegates.Hide_AfterArgs _afterHide;

        private static void Hide(On.BossSummaryBoard.orig_Hide orig, BossSummaryBoard self)
        {
            Delegates.Params_Hide @params = new()
            {
                self = self
            };
            if (_beforeHide != null)
            {
                foreach (Delegates.Hide_BeforeArgs toInvoke in _beforeHide.GetInvocationList())
                {
                    try
                    {
                        _beforeHide?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterHide != null)
            {
                foreach (Delegates.Hide_AfterArgs toInvoke in _afterHide.GetInvocationList())
                {
                    try
                    {
                        _afterHide.Invoke(@params);
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
        public sealed class Params_Start
        {
            public BossSummaryBoard self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<BossSummaryBoard> orig, BossSummaryBoard self);

        public sealed class Params_Show
        {
            public BossSummaryBoard self;
        }

        public delegate void Show_BeforeArgs(Params_Show args);

        public delegate void Show_AfterArgs(Params_Show args);

        public delegate void Show_WithArgs(Action<BossSummaryBoard> orig, BossSummaryBoard self);

        public sealed class Params_Hide
        {
            public BossSummaryBoard self;
        }

        public delegate void Hide_BeforeArgs(Params_Hide args);

        public delegate void Hide_AfterArgs(Params_Hide args);

        public delegate void Hide_WithArgs(Action<BossSummaryBoard> orig, BossSummaryBoard self);
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

        public static event Delegates.Show_BeforeArgs Show
        {
            add
            {
                HookHandler._beforeShow += value;
                HookHandler.HookShow();
            }
            remove => HookHandler._beforeShow -= value;
        }

        public static event Delegates.Hide_BeforeArgs Hide
        {
            add
            {
                HookHandler._beforeHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._beforeHide -= value;
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

        public static event Delegates.Show_AfterArgs Show
        {
            add
            {
                HookHandler._afterShow += value;
                HookHandler.HookShow();
            }
            remove => HookHandler._afterShow -= value;
        }

        public static event Delegates.Hide_AfterArgs Hide
        {
            add
            {
                HookHandler._afterHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._afterHide -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BossSummaryBoard.hook_Start Start
        {
            add => On.BossSummaryBoard.Start += value;
            remove => On.BossSummaryBoard.Start -= value;
        }

        public static event On.BossSummaryBoard.hook_Show Show
        {
            add => On.BossSummaryBoard.Show += value;
            remove => On.BossSummaryBoard.Show -= value;
        }

        public static event On.BossSummaryBoard.hook_Hide Hide
        {
            add => On.BossSummaryBoard.Hide += value;
            remove => On.BossSummaryBoard.Hide -= value;
        }
    }
}