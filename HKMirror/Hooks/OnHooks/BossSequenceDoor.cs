namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BossSequenceDoor class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossSequenceDoor
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.BossSequenceDoor.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.BossSequenceDoor.orig_Start orig, BossSequenceDoor self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStart != null) _afterStart.Invoke(@params);
        }

        internal static void HookSaveState()
        {
            if (!HookedList.Contains("SaveState"))
            {
                HookedList.Add("SaveState");
                On.BossSequenceDoor.SaveState += SaveState;
            }
        }

        internal static event Delegates.SaveState_BeforeArgs _beforeSaveState;
        internal static event Delegates.SaveState_NormalArgs _afterSaveState;

        private static void SaveState(On.BossSequenceDoor.orig_SaveState orig, BossSequenceDoor self)
        {
            Delegates.Params_SaveState @params = new()
            {
                self = self
            };
            _beforeSaveState?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSaveState != null) _afterSaveState.Invoke(@params);
        }

        internal static void HookIsUnlocked()
        {
            if (!HookedList.Contains("IsUnlocked"))
            {
                HookedList.Add("IsUnlocked");
                On.BossSequenceDoor.IsUnlocked += IsUnlocked;
            }
        }

        internal static event Delegates.IsUnlocked_BeforeArgs _beforeIsUnlocked;
        internal static event Delegates.IsUnlocked_NormalArgs _afterIsUnlocked;

        private static bool IsUnlocked(On.BossSequenceDoor.orig_IsUnlocked orig, BossSequenceDoor self)
        {
            Delegates.Params_IsUnlocked @params = new()
            {
                self = self
            };
            _beforeIsUnlocked?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterIsUnlocked != null) retVal = _afterIsUnlocked.Invoke(@params);
            return retVal;
        }

        internal static void HookShowLockUI()
        {
            if (!HookedList.Contains("ShowLockUI"))
            {
                HookedList.Add("ShowLockUI");
                On.BossSequenceDoor.ShowLockUI += ShowLockUI;
            }
        }

        internal static event Delegates.ShowLockUI_BeforeArgs _beforeShowLockUI;
        internal static event Delegates.ShowLockUI_NormalArgs _afterShowLockUI;

        private static void ShowLockUI(On.BossSequenceDoor.orig_ShowLockUI orig, BossSequenceDoor self, bool value)
        {
            Delegates.Params_ShowLockUI @params = new()
            {
                self = self, value = value
            };
            _beforeShowLockUI?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterShowLockUI != null) _afterShowLockUI.Invoke(@params);
        }

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.BossSequenceDoor.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.BossSequenceDoor.orig_OnTriggerEnter2D orig, BossSequenceDoor self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, collision = collision
            };
            _beforeOnTriggerEnter2D?.Invoke(@params);
            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerEnter2D != null) _afterOnTriggerEnter2D.Invoke(@params);
        }

        internal static void HookStartShake()
        {
            if (!HookedList.Contains("StartShake"))
            {
                HookedList.Add("StartShake");
                On.BossSequenceDoor.StartShake += StartShake;
            }
        }

        internal static event Delegates.StartShake_BeforeArgs _beforeStartShake;
        internal static event Delegates.StartShake_NormalArgs _afterStartShake;

        private static void StartShake(On.BossSequenceDoor.orig_StartShake orig, BossSequenceDoor self)
        {
            Delegates.Params_StartShake @params = new()
            {
                self = self
            };
            _beforeStartShake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStartShake != null) _afterStartShake.Invoke(@params);
        }

        internal static void HookStopShake()
        {
            if (!HookedList.Contains("StopShake"))
            {
                HookedList.Add("StopShake");
                On.BossSequenceDoor.StopShake += StopShake;
            }
        }

        internal static event Delegates.StopShake_BeforeArgs _beforeStopShake;
        internal static event Delegates.StopShake_NormalArgs _afterStopShake;

        private static void StopShake(On.BossSequenceDoor.orig_StopShake orig, BossSequenceDoor self)
        {
            Delegates.Params_StopShake @params = new()
            {
                self = self
            };
            _beforeStopShake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStopShake != null) _afterStopShake.Invoke(@params);
        }

        internal static void HookDoorUnlockSequence()
        {
            if (!HookedList.Contains("DoorUnlockSequence"))
            {
                HookedList.Add("DoorUnlockSequence");
                On.BossSequenceDoor.DoorUnlockSequence += DoorUnlockSequence;
            }
        }

        internal static event Delegates.DoorUnlockSequence_BeforeArgs _beforeDoorUnlockSequence;

        private static IEnumerator DoorUnlockSequence(On.BossSequenceDoor.orig_DoorUnlockSequence orig,
            BossSequenceDoor self)
        {
            Delegates.Params_DoorUnlockSequence @params = new()
            {
                self = self
            };
            _beforeDoorUnlockSequence?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoorUnlockSequence_BeforeArgs(Params_DoorUnlockSequence args);

        public delegate IEnumerator DoorUnlockSequence_NormalArgs(Params_DoorUnlockSequence args);

        public delegate void IsUnlocked_BeforeArgs(Params_IsUnlocked args);

        public delegate bool IsUnlocked_NormalArgs(Params_IsUnlocked args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void SaveState_BeforeArgs(Params_SaveState args);

        public delegate void SaveState_NormalArgs(Params_SaveState args);

        public delegate void ShowLockUI_BeforeArgs(Params_ShowLockUI args);

        public delegate void ShowLockUI_NormalArgs(Params_ShowLockUI args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void StartShake_BeforeArgs(Params_StartShake args);

        public delegate void StartShake_NormalArgs(Params_StartShake args);

        public delegate void StopShake_BeforeArgs(Params_StopShake args);

        public delegate void StopShake_NormalArgs(Params_StopShake args);

        public sealed class Params_Start
        {
            public BossSequenceDoor self;
        }

        public sealed class Params_SaveState
        {
            public BossSequenceDoor self;
        }

        public sealed class Params_IsUnlocked
        {
            public BossSequenceDoor self;
        }

        public sealed class Params_ShowLockUI
        {
            public BossSequenceDoor self;
            public bool value;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public BossSequenceDoor self;
        }

        public sealed class Params_StartShake
        {
            public BossSequenceDoor self;
        }

        public sealed class Params_StopShake
        {
            public BossSequenceDoor self;
        }

        public sealed class Params_DoorUnlockSequence
        {
            public BossSequenceDoor self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.SaveState_BeforeArgs SaveState
        {
            add
            {
                HookHandler._beforeSaveState += value;
                HookHandler.HookSaveState();
            }
            remove => HookHandler._beforeSaveState -= value;
        }

        public static event Delegates.IsUnlocked_BeforeArgs IsUnlocked
        {
            add
            {
                HookHandler._beforeIsUnlocked += value;
                HookHandler.HookIsUnlocked();
            }
            remove => HookHandler._beforeIsUnlocked -= value;
        }

        public static event Delegates.ShowLockUI_BeforeArgs ShowLockUI
        {
            add
            {
                HookHandler._beforeShowLockUI += value;
                HookHandler.HookShowLockUI();
            }
            remove => HookHandler._beforeShowLockUI -= value;
        }

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.StartShake_BeforeArgs StartShake
        {
            add
            {
                HookHandler._beforeStartShake += value;
                HookHandler.HookStartShake();
            }
            remove => HookHandler._beforeStartShake -= value;
        }

        public static event Delegates.StopShake_BeforeArgs StopShake
        {
            add
            {
                HookHandler._beforeStopShake += value;
                HookHandler.HookStopShake();
            }
            remove => HookHandler._beforeStopShake -= value;
        }

        public static event Delegates.DoorUnlockSequence_BeforeArgs DoorUnlockSequence
        {
            add
            {
                HookHandler._beforeDoorUnlockSequence += value;
                HookHandler.HookDoorUnlockSequence();
            }
            remove => HookHandler._beforeDoorUnlockSequence -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.SaveState_NormalArgs SaveState
        {
            add
            {
                HookHandler._afterSaveState += value;
                HookHandler.HookSaveState();
            }
            remove => HookHandler._afterSaveState -= value;
        }

        public static event Delegates.IsUnlocked_NormalArgs IsUnlocked
        {
            add
            {
                HookHandler._afterIsUnlocked += value;
                HookHandler.HookIsUnlocked();
            }
            remove => HookHandler._afterIsUnlocked -= value;
        }

        public static event Delegates.ShowLockUI_NormalArgs ShowLockUI
        {
            add
            {
                HookHandler._afterShowLockUI += value;
                HookHandler.HookShowLockUI();
            }
            remove => HookHandler._afterShowLockUI -= value;
        }

        public static event Delegates.OnTriggerEnter2D_NormalArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.StartShake_NormalArgs StartShake
        {
            add
            {
                HookHandler._afterStartShake += value;
                HookHandler.HookStartShake();
            }
            remove => HookHandler._afterStartShake -= value;
        }

        public static event Delegates.StopShake_NormalArgs StopShake
        {
            add
            {
                HookHandler._afterStopShake += value;
                HookHandler.HookStopShake();
            }
            remove => HookHandler._afterStopShake -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BossSequenceDoor.hook_Start Start
        {
            add => On.BossSequenceDoor.Start += value;
            remove => On.BossSequenceDoor.Start -= value;
        }

        public static event On.BossSequenceDoor.hook_SaveState SaveState
        {
            add => On.BossSequenceDoor.SaveState += value;
            remove => On.BossSequenceDoor.SaveState -= value;
        }

        public static event On.BossSequenceDoor.hook_IsUnlocked IsUnlocked
        {
            add => On.BossSequenceDoor.IsUnlocked += value;
            remove => On.BossSequenceDoor.IsUnlocked -= value;
        }

        public static event On.BossSequenceDoor.hook_ShowLockUI ShowLockUI
        {
            add => On.BossSequenceDoor.ShowLockUI += value;
            remove => On.BossSequenceDoor.ShowLockUI -= value;
        }

        public static event On.BossSequenceDoor.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.BossSequenceDoor.OnTriggerEnter2D += value;
            remove => On.BossSequenceDoor.OnTriggerEnter2D -= value;
        }

        public static event On.BossSequenceDoor.hook_StartShake StartShake
        {
            add => On.BossSequenceDoor.StartShake += value;
            remove => On.BossSequenceDoor.StartShake -= value;
        }

        public static event On.BossSequenceDoor.hook_StopShake StopShake
        {
            add => On.BossSequenceDoor.StopShake += value;
            remove => On.BossSequenceDoor.StopShake -= value;
        }

        public static event On.BossSequenceDoor.hook_DoorUnlockSequence DoorUnlockSequence
        {
            add => On.BossSequenceDoor.DoorUnlockSequence += value;
            remove => On.BossSequenceDoor.DoorUnlockSequence -= value;
        }
    }
}