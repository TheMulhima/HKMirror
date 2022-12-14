namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BossSummaryUI class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossSummaryUI
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.BossSummaryUI.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.BossSummaryUI.orig_Awake orig, BossSummaryUI self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.BossSummaryUI.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.BossSummaryUI.orig_Start orig, BossSummaryUI self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetupUI()
        {
            if (!HookedList.Contains("SetupUI"))
            {
                HookedList.Add("SetupUI");
                On.BossSummaryUI.SetupUI += SetupUI;
            }
        }

        internal static event Delegates.SetupUI_BeforeArgs _beforeSetupUI;
        internal static event Delegates.SetupUI_AfterArgs _afterSetupUI;

        private static void SetupUI(On.BossSummaryUI.orig_SetupUI orig, BossSummaryUI self,
            List<BossStatue> bossStatues)
        {
            Delegates.Params_SetupUI @params = new()
            {
                self = self, bossStatues = bossStatues
            };
            if (_beforeSetupUI != null)
                foreach (Delegates.SetupUI_BeforeArgs toInvoke in _beforeSetupUI.GetInvocationList())
                    try
                    {
                        _beforeSetupUI?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            bossStatues = @params.bossStatues;
            orig(self, bossStatues);
            if (_afterSetupUI != null)
                foreach (Delegates.SetupUI_AfterArgs toInvoke in _afterSetupUI.GetInvocationList())
                    try
                    {
                        _afterSetupUI.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCreateListItem()
        {
            if (!HookedList.Contains("CreateListItem"))
            {
                HookedList.Add("CreateListItem");
                On.BossSummaryUI.CreateListItem += CreateListItem;
            }
        }

        internal static event Delegates.CreateListItem_BeforeArgs _beforeCreateListItem;
        internal static event Delegates.CreateListItem_AfterArgs _afterCreateListItem;

        private static void CreateListItem(On.BossSummaryUI.orig_CreateListItem orig, BossSummaryUI self,
            BossStatue bossStatue, bool isAlt)
        {
            Delegates.Params_CreateListItem @params = new()
            {
                self = self, bossStatue = bossStatue, isAlt = isAlt
            };
            if (_beforeCreateListItem != null)
                foreach (Delegates.CreateListItem_BeforeArgs toInvoke in _beforeCreateListItem.GetInvocationList())
                    try
                    {
                        _beforeCreateListItem?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            bossStatue = @params.bossStatue;
            isAlt = @params.isAlt;
            orig(self, bossStatue, isAlt);
            if (_afterCreateListItem != null)
                foreach (Delegates.CreateListItem_AfterArgs toInvoke in _afterCreateListItem.GetInvocationList())
                    try
                    {
                        _afterCreateListItem.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookShow()
        {
            if (!HookedList.Contains("Show"))
            {
                HookedList.Add("Show");
                On.BossSummaryUI.Show += Show;
            }
        }

        internal static event Delegates.Show_BeforeArgs _beforeShow;
        internal static event Delegates.Show_AfterArgs _afterShow;

        private static void Show(On.BossSummaryUI.orig_Show orig, BossSummaryUI self)
        {
            Delegates.Params_Show @params = new()
            {
                self = self
            };
            if (_beforeShow != null)
                foreach (Delegates.Show_BeforeArgs toInvoke in _beforeShow.GetInvocationList())
                    try
                    {
                        _beforeShow?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterShow != null)
                foreach (Delegates.Show_AfterArgs toInvoke in _afterShow.GetInvocationList())
                    try
                    {
                        _afterShow.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookHide()
        {
            if (!HookedList.Contains("Hide"))
            {
                HookedList.Add("Hide");
                On.BossSummaryUI.Hide += Hide;
            }
        }

        internal static event Delegates.Hide_BeforeArgs _beforeHide;
        internal static event Delegates.Hide_AfterArgs _afterHide;

        private static void Hide(On.BossSummaryUI.orig_Hide orig, BossSummaryUI self)
        {
            Delegates.Params_Hide @params = new()
            {
                self = self
            };
            if (_beforeHide != null)
                foreach (Delegates.Hide_BeforeArgs toInvoke in _beforeHide.GetInvocationList())
                    try
                    {
                        _beforeHide?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterHide != null)
                foreach (Delegates.Hide_AfterArgs toInvoke in _afterHide.GetInvocationList())
                    try
                    {
                        _afterHide.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookClose()
        {
            if (!HookedList.Contains("Close"))
            {
                HookedList.Add("Close");
                On.BossSummaryUI.Close += Close;
            }
        }

        internal static event Delegates.Close_BeforeArgs _beforeClose;

        private static IEnumerator Close(On.BossSummaryUI.orig_Close orig, BossSummaryUI self)
        {
            Delegates.Params_Close @params = new()
            {
                self = self
            };
            if (_beforeClose != null)
                foreach (Delegates.Close_BeforeArgs toInvoke in _beforeClose.GetInvocationList())
                    try
                    {
                        _beforeClose?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<BossSummaryUI> orig, BossSummaryUI self);

        public delegate IEnumerator Close_AfterArgs(Params_Close args, IEnumerator ret);

        public delegate void Close_BeforeArgs(Params_Close args);

        public delegate IEnumerator Close_WithArgs(Func<BossSummaryUI, IEnumerator> orig, BossSummaryUI self);

        public delegate void CreateListItem_AfterArgs(Params_CreateListItem args);

        public delegate void CreateListItem_BeforeArgs(Params_CreateListItem args);

        public delegate void CreateListItem_WithArgs(Action<BossSummaryUI, BossStatue, bool> orig, BossSummaryUI self,
            BossStatue bossStatue, bool isAlt);

        public delegate void Hide_AfterArgs(Params_Hide args);

        public delegate void Hide_BeforeArgs(Params_Hide args);

        public delegate void Hide_WithArgs(Action<BossSummaryUI> orig, BossSummaryUI self);

        public delegate void SetupUI_AfterArgs(Params_SetupUI args);

        public delegate void SetupUI_BeforeArgs(Params_SetupUI args);

        public delegate void SetupUI_WithArgs(Action<BossSummaryUI, List<BossStatue>> orig, BossSummaryUI self,
            List<BossStatue> bossStatues);

        public delegate void Show_AfterArgs(Params_Show args);

        public delegate void Show_BeforeArgs(Params_Show args);

        public delegate void Show_WithArgs(Action<BossSummaryUI> orig, BossSummaryUI self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<BossSummaryUI> orig, BossSummaryUI self);

        public sealed class Params_Awake
        {
            public BossSummaryUI self;
        }

        public sealed class Params_Start
        {
            public BossSummaryUI self;
        }

        public sealed class Params_SetupUI
        {
            public List<BossStatue> bossStatues;
            public BossSummaryUI self;
        }

        public sealed class Params_CreateListItem
        {
            public BossStatue bossStatue;
            public bool isAlt;
            public BossSummaryUI self;
        }

        public sealed class Params_Show
        {
            public BossSummaryUI self;
        }

        public sealed class Params_Hide
        {
            public BossSummaryUI self;
        }

        public sealed class Params_Close
        {
            public BossSummaryUI self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.SetupUI_BeforeArgs SetupUI
        {
            add
            {
                HookHandler._beforeSetupUI += value;
                HookHandler.HookSetupUI();
            }
            remove => HookHandler._beforeSetupUI -= value;
        }

        public static event Delegates.CreateListItem_BeforeArgs CreateListItem
        {
            add
            {
                HookHandler._beforeCreateListItem += value;
                HookHandler.HookCreateListItem();
            }
            remove => HookHandler._beforeCreateListItem -= value;
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

        public static event Delegates.Close_BeforeArgs Close
        {
            add
            {
                HookHandler._beforeClose += value;
                HookHandler.HookClose();
            }
            remove => HookHandler._beforeClose -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.SetupUI_AfterArgs SetupUI
        {
            add
            {
                HookHandler._afterSetupUI += value;
                HookHandler.HookSetupUI();
            }
            remove => HookHandler._afterSetupUI -= value;
        }

        public static event Delegates.CreateListItem_AfterArgs CreateListItem
        {
            add
            {
                HookHandler._afterCreateListItem += value;
                HookHandler.HookCreateListItem();
            }
            remove => HookHandler._afterCreateListItem -= value;
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
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BossSummaryUI.hook_Awake Awake
        {
            add => On.BossSummaryUI.Awake += value;
            remove => On.BossSummaryUI.Awake -= value;
        }

        public static event On.BossSummaryUI.hook_Start Start
        {
            add => On.BossSummaryUI.Start += value;
            remove => On.BossSummaryUI.Start -= value;
        }

        public static event On.BossSummaryUI.hook_SetupUI SetupUI
        {
            add => On.BossSummaryUI.SetupUI += value;
            remove => On.BossSummaryUI.SetupUI -= value;
        }

        public static event On.BossSummaryUI.hook_CreateListItem CreateListItem
        {
            add => On.BossSummaryUI.CreateListItem += value;
            remove => On.BossSummaryUI.CreateListItem -= value;
        }

        public static event On.BossSummaryUI.hook_Show Show
        {
            add => On.BossSummaryUI.Show += value;
            remove => On.BossSummaryUI.Show -= value;
        }

        public static event On.BossSummaryUI.hook_Hide Hide
        {
            add => On.BossSummaryUI.Hide += value;
            remove => On.BossSummaryUI.Hide -= value;
        }

        public static event On.BossSummaryUI.hook_Close Close
        {
            add => On.BossSummaryUI.Close += value;
            remove => On.BossSummaryUI.Close -= value;
        }
    }
}