namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BossDoorChallengeUI class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossDoorChallengeUI
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.BossDoorChallengeUI.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.BossDoorChallengeUI.orig_Awake orig, BossDoorChallengeUI self)
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
                On.BossDoorChallengeUI.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.BossDoorChallengeUI.orig_Start orig, BossDoorChallengeUI self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.BossDoorChallengeUI.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.BossDoorChallengeUI.orig_OnEnable orig, BossDoorChallengeUI self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetup()
        {
            if (!HookedList.Contains("Setup"))
            {
                HookedList.Add("Setup");
                On.BossDoorChallengeUI.Setup += Setup;
            }
        }

        internal static event Delegates.Setup_BeforeArgs _beforeSetup;
        internal static event Delegates.Setup_AfterArgs _afterSetup;

        private static void Setup(On.BossDoorChallengeUI.orig_Setup orig, BossDoorChallengeUI self,
            BossSequenceDoor door)
        {
            Delegates.Params_Setup @params = new()
            {
                self = self, door = door
            };
            if (_beforeSetup != null)
                foreach (Delegates.Setup_BeforeArgs toInvoke in _beforeSetup.GetInvocationList())
                    try
                    {
                        _beforeSetup?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            door = @params.door;
            orig(self, door);
            if (_afterSetup != null)
                foreach (Delegates.Setup_AfterArgs toInvoke in _afterSetup.GetInvocationList())
                    try
                    {
                        _afterSetup.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdateAllButtons()
        {
            if (!HookedList.Contains("UpdateAllButtons"))
            {
                HookedList.Add("UpdateAllButtons");
                On.BossDoorChallengeUI.UpdateAllButtons += UpdateAllButtons;
            }
        }

        internal static event Delegates.UpdateAllButtons_BeforeArgs _beforeUpdateAllButtons;
        internal static event Delegates.UpdateAllButtons_AfterArgs _afterUpdateAllButtons;

        private static void UpdateAllButtons(On.BossDoorChallengeUI.orig_UpdateAllButtons orig,
            BossDoorChallengeUI self)
        {
            Delegates.Params_UpdateAllButtons @params = new()
            {
                self = self
            };
            if (_beforeUpdateAllButtons != null)
                foreach (Delegates.UpdateAllButtons_BeforeArgs toInvoke in _beforeUpdateAllButtons.GetInvocationList())
                    try
                    {
                        _beforeUpdateAllButtons?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateAllButtons != null)
                foreach (Delegates.UpdateAllButtons_AfterArgs toInvoke in _afterUpdateAllButtons.GetInvocationList())
                    try
                    {
                        _afterUpdateAllButtons.Invoke(@params);
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
                On.BossDoorChallengeUI.Show += Show;
            }
        }

        internal static event Delegates.Show_BeforeArgs _beforeShow;
        internal static event Delegates.Show_AfterArgs _afterShow;

        private static void Show(On.BossDoorChallengeUI.orig_Show orig, BossDoorChallengeUI self)
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

        internal static void HookShowSequence()
        {
            if (!HookedList.Contains("ShowSequence"))
            {
                HookedList.Add("ShowSequence");
                On.BossDoorChallengeUI.ShowSequence += ShowSequence;
            }
        }

        internal static event Delegates.ShowSequence_BeforeArgs _beforeShowSequence;

        private static IEnumerator ShowSequence(On.BossDoorChallengeUI.orig_ShowSequence orig, BossDoorChallengeUI self)
        {
            Delegates.Params_ShowSequence @params = new()
            {
                self = self
            };
            if (_beforeShowSequence != null)
                foreach (Delegates.ShowSequence_BeforeArgs toInvoke in _beforeShowSequence.GetInvocationList())
                    try
                    {
                        _beforeShowSequence?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookHide()
        {
            if (!HookedList.Contains("Hide"))
            {
                HookedList.Add("Hide");
                On.BossDoorChallengeUI.Hide += Hide;
            }
        }

        internal static event Delegates.Hide_BeforeArgs _beforeHide;
        internal static event Delegates.Hide_AfterArgs _afterHide;

        private static void Hide(On.BossDoorChallengeUI.orig_Hide orig, BossDoorChallengeUI self)
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

        internal static void HookHideSequence()
        {
            if (!HookedList.Contains("HideSequence"))
            {
                HookedList.Add("HideSequence");
                On.BossDoorChallengeUI.HideSequence += HideSequence;
            }
        }

        internal static event Delegates.HideSequence_BeforeArgs _beforeHideSequence;

        private static IEnumerator HideSequence(On.BossDoorChallengeUI.orig_HideSequence orig, BossDoorChallengeUI self,
            bool sendEvent)
        {
            Delegates.Params_HideSequence @params = new()
            {
                self = self, sendEvent = sendEvent
            };
            if (_beforeHideSequence != null)
                foreach (Delegates.HideSequence_BeforeArgs toInvoke in _beforeHideSequence.GetInvocationList())
                    try
                    {
                        _beforeHideSequence?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            sendEvent = @params.sendEvent;
            return orig(self, sendEvent);
        }

        internal static void HookBegin()
        {
            if (!HookedList.Contains("Begin"))
            {
                HookedList.Add("Begin");
                On.BossDoorChallengeUI.Begin += Begin;
            }
        }

        internal static event Delegates.Begin_BeforeArgs _beforeBegin;
        internal static event Delegates.Begin_AfterArgs _afterBegin;

        private static void Begin(On.BossDoorChallengeUI.orig_Begin orig, BossDoorChallengeUI self)
        {
            Delegates.Params_Begin @params = new()
            {
                self = self
            };
            if (_beforeBegin != null)
                foreach (Delegates.Begin_BeforeArgs toInvoke in _beforeBegin.GetInvocationList())
                    try
                    {
                        _beforeBegin?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterBegin != null)
                foreach (Delegates.Begin_AfterArgs toInvoke in _afterBegin.GetInvocationList())
                    try
                    {
                        _afterBegin.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<BossDoorChallengeUI> orig, BossDoorChallengeUI self);

        public delegate void Begin_AfterArgs(Params_Begin args);

        public delegate void Begin_BeforeArgs(Params_Begin args);

        public delegate void Begin_WithArgs(Action<BossDoorChallengeUI> orig, BossDoorChallengeUI self);

        public delegate void Hide_AfterArgs(Params_Hide args);

        public delegate void Hide_BeforeArgs(Params_Hide args);

        public delegate void Hide_WithArgs(Action<BossDoorChallengeUI> orig, BossDoorChallengeUI self);

        public delegate IEnumerator HideSequence_AfterArgs(Params_HideSequence args, IEnumerator ret);

        public delegate void HideSequence_BeforeArgs(Params_HideSequence args);

        public delegate IEnumerator HideSequence_WithArgs(Func<BossDoorChallengeUI, bool, IEnumerator> orig,
            BossDoorChallengeUI self, bool sendEvent);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<BossDoorChallengeUI> orig, BossDoorChallengeUI self);

        public delegate void Setup_AfterArgs(Params_Setup args);

        public delegate void Setup_BeforeArgs(Params_Setup args);

        public delegate void Setup_WithArgs(Action<BossDoorChallengeUI, BossSequenceDoor> orig,
            BossDoorChallengeUI self, BossSequenceDoor door);

        public delegate void Show_AfterArgs(Params_Show args);

        public delegate void Show_BeforeArgs(Params_Show args);

        public delegate void Show_WithArgs(Action<BossDoorChallengeUI> orig, BossDoorChallengeUI self);

        public delegate IEnumerator ShowSequence_AfterArgs(Params_ShowSequence args, IEnumerator ret);

        public delegate void ShowSequence_BeforeArgs(Params_ShowSequence args);

        public delegate IEnumerator ShowSequence_WithArgs(Func<BossDoorChallengeUI, IEnumerator> orig,
            BossDoorChallengeUI self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<BossDoorChallengeUI> orig, BossDoorChallengeUI self);

        public delegate void UpdateAllButtons_AfterArgs(Params_UpdateAllButtons args);

        public delegate void UpdateAllButtons_BeforeArgs(Params_UpdateAllButtons args);

        public delegate void UpdateAllButtons_WithArgs(Action<BossDoorChallengeUI> orig, BossDoorChallengeUI self);

        public sealed class Params_Awake
        {
            public BossDoorChallengeUI self;
        }

        public sealed class Params_Start
        {
            public BossDoorChallengeUI self;
        }

        public sealed class Params_OnEnable
        {
            public BossDoorChallengeUI self;
        }

        public sealed class Params_Setup
        {
            public BossSequenceDoor door;
            public BossDoorChallengeUI self;
        }

        public sealed class Params_UpdateAllButtons
        {
            public BossDoorChallengeUI self;
        }

        public sealed class Params_Show
        {
            public BossDoorChallengeUI self;
        }

        public sealed class Params_ShowSequence
        {
            public BossDoorChallengeUI self;
        }

        public sealed class Params_Hide
        {
            public BossDoorChallengeUI self;
        }

        public sealed class Params_HideSequence
        {
            public BossDoorChallengeUI self;
            public bool sendEvent;
        }

        public sealed class Params_Begin
        {
            public BossDoorChallengeUI self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.Setup_BeforeArgs Setup
        {
            add
            {
                HookHandler._beforeSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._beforeSetup -= value;
        }

        public static event Delegates.UpdateAllButtons_BeforeArgs UpdateAllButtons
        {
            add
            {
                HookHandler._beforeUpdateAllButtons += value;
                HookHandler.HookUpdateAllButtons();
            }
            remove => HookHandler._beforeUpdateAllButtons -= value;
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

        public static event Delegates.ShowSequence_BeforeArgs ShowSequence
        {
            add
            {
                HookHandler._beforeShowSequence += value;
                HookHandler.HookShowSequence();
            }
            remove => HookHandler._beforeShowSequence -= value;
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

        public static event Delegates.HideSequence_BeforeArgs HideSequence
        {
            add
            {
                HookHandler._beforeHideSequence += value;
                HookHandler.HookHideSequence();
            }
            remove => HookHandler._beforeHideSequence -= value;
        }

        public static event Delegates.Begin_BeforeArgs Begin
        {
            add
            {
                HookHandler._beforeBegin += value;
                HookHandler.HookBegin();
            }
            remove => HookHandler._beforeBegin -= value;
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

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.Setup_AfterArgs Setup
        {
            add
            {
                HookHandler._afterSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._afterSetup -= value;
        }

        public static event Delegates.UpdateAllButtons_AfterArgs UpdateAllButtons
        {
            add
            {
                HookHandler._afterUpdateAllButtons += value;
                HookHandler.HookUpdateAllButtons();
            }
            remove => HookHandler._afterUpdateAllButtons -= value;
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

        public static event Delegates.Begin_AfterArgs Begin
        {
            add
            {
                HookHandler._afterBegin += value;
                HookHandler.HookBegin();
            }
            remove => HookHandler._afterBegin -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BossDoorChallengeUI.hook_Awake Awake
        {
            add => On.BossDoorChallengeUI.Awake += value;
            remove => On.BossDoorChallengeUI.Awake -= value;
        }

        public static event On.BossDoorChallengeUI.hook_Start Start
        {
            add => On.BossDoorChallengeUI.Start += value;
            remove => On.BossDoorChallengeUI.Start -= value;
        }

        public static event On.BossDoorChallengeUI.hook_OnEnable OnEnable
        {
            add => On.BossDoorChallengeUI.OnEnable += value;
            remove => On.BossDoorChallengeUI.OnEnable -= value;
        }

        public static event On.BossDoorChallengeUI.hook_Setup Setup
        {
            add => On.BossDoorChallengeUI.Setup += value;
            remove => On.BossDoorChallengeUI.Setup -= value;
        }

        public static event On.BossDoorChallengeUI.hook_UpdateAllButtons UpdateAllButtons
        {
            add => On.BossDoorChallengeUI.UpdateAllButtons += value;
            remove => On.BossDoorChallengeUI.UpdateAllButtons -= value;
        }

        public static event On.BossDoorChallengeUI.hook_Show Show
        {
            add => On.BossDoorChallengeUI.Show += value;
            remove => On.BossDoorChallengeUI.Show -= value;
        }

        public static event On.BossDoorChallengeUI.hook_ShowSequence ShowSequence
        {
            add => On.BossDoorChallengeUI.ShowSequence += value;
            remove => On.BossDoorChallengeUI.ShowSequence -= value;
        }

        public static event On.BossDoorChallengeUI.hook_Hide Hide
        {
            add => On.BossDoorChallengeUI.Hide += value;
            remove => On.BossDoorChallengeUI.Hide -= value;
        }

        public static event On.BossDoorChallengeUI.hook_HideSequence HideSequence
        {
            add => On.BossDoorChallengeUI.HideSequence += value;
            remove => On.BossDoorChallengeUI.HideSequence -= value;
        }

        public static event On.BossDoorChallengeUI.hook_Begin Begin
        {
            add => On.BossDoorChallengeUI.Begin += value;
            remove => On.BossDoorChallengeUI.Begin -= value;
        }
    }
}