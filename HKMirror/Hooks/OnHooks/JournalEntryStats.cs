namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for JournalEntryStats class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnJournalEntryStats
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.JournalEntryStats.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.JournalEntryStats.orig_Awake orig, JournalEntryStats self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.JournalEntryStats.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.JournalEntryStats.orig_OnEnable orig, JournalEntryStats self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.JournalEntryStats.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.JournalEntryStats.orig_OnDisable orig, JournalEntryStats self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            _beforeOnDisable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnDisable != null) _afterOnDisable.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.JournalEntryStats.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.JournalEntryStats.orig_Update orig, JournalEntryStats self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookGetNameConvo()
        {
            if (!HookedList.Contains("GetNameConvo"))
            {
                HookedList.Add("GetNameConvo");
                On.JournalEntryStats.GetNameConvo += GetNameConvo;
            }
        }

        internal static event Delegates.GetNameConvo_BeforeArgs _beforeGetNameConvo;
        internal static event Delegates.GetNameConvo_NormalArgs _afterGetNameConvo;

        private static string GetNameConvo(On.JournalEntryStats.orig_GetNameConvo orig, JournalEntryStats self)
        {
            Delegates.Params_GetNameConvo @params = new()
            {
                self = self
            };
            _beforeGetNameConvo?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetNameConvo != null) retVal = _afterGetNameConvo.Invoke(@params);
            return retVal;
        }

        internal static void HookGetDescConvo()
        {
            if (!HookedList.Contains("GetDescConvo"))
            {
                HookedList.Add("GetDescConvo");
                On.JournalEntryStats.GetDescConvo += GetDescConvo;
            }
        }

        internal static event Delegates.GetDescConvo_BeforeArgs _beforeGetDescConvo;
        internal static event Delegates.GetDescConvo_NormalArgs _afterGetDescConvo;

        private static string GetDescConvo(On.JournalEntryStats.orig_GetDescConvo orig, JournalEntryStats self)
        {
            Delegates.Params_GetDescConvo @params = new()
            {
                self = self
            };
            _beforeGetDescConvo?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetDescConvo != null) retVal = _afterGetDescConvo.Invoke(@params);
            return retVal;
        }

        internal static void HookGetNotesConvo()
        {
            if (!HookedList.Contains("GetNotesConvo"))
            {
                HookedList.Add("GetNotesConvo");
                On.JournalEntryStats.GetNotesConvo += GetNotesConvo;
            }
        }

        internal static event Delegates.GetNotesConvo_BeforeArgs _beforeGetNotesConvo;
        internal static event Delegates.GetNotesConvo_NormalArgs _afterGetNotesConvo;

        private static string GetNotesConvo(On.JournalEntryStats.orig_GetNotesConvo orig, JournalEntryStats self)
        {
            Delegates.Params_GetNotesConvo @params = new()
            {
                self = self
            };
            _beforeGetNotesConvo?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetNotesConvo != null) retVal = _afterGetNotesConvo.Invoke(@params);
            return retVal;
        }

        internal static void HookGetPlayerDataBoolName()
        {
            if (!HookedList.Contains("GetPlayerDataBoolName"))
            {
                HookedList.Add("GetPlayerDataBoolName");
                On.JournalEntryStats.GetPlayerDataBoolName += GetPlayerDataBoolName;
            }
        }

        internal static event Delegates.GetPlayerDataBoolName_BeforeArgs _beforeGetPlayerDataBoolName;
        internal static event Delegates.GetPlayerDataBoolName_NormalArgs _afterGetPlayerDataBoolName;

        private static string GetPlayerDataBoolName(On.JournalEntryStats.orig_GetPlayerDataBoolName orig,
            JournalEntryStats self)
        {
            Delegates.Params_GetPlayerDataBoolName @params = new()
            {
                self = self
            };
            _beforeGetPlayerDataBoolName?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetPlayerDataBoolName != null) retVal = _afterGetPlayerDataBoolName.Invoke(@params);
            return retVal;
        }

        internal static void HookGetPlayerDataKillsName()
        {
            if (!HookedList.Contains("GetPlayerDataKillsName"))
            {
                HookedList.Add("GetPlayerDataKillsName");
                On.JournalEntryStats.GetPlayerDataKillsName += GetPlayerDataKillsName;
            }
        }

        internal static event Delegates.GetPlayerDataKillsName_BeforeArgs _beforeGetPlayerDataKillsName;
        internal static event Delegates.GetPlayerDataKillsName_NormalArgs _afterGetPlayerDataKillsName;

        private static string GetPlayerDataKillsName(On.JournalEntryStats.orig_GetPlayerDataKillsName orig,
            JournalEntryStats self)
        {
            Delegates.Params_GetPlayerDataKillsName @params = new()
            {
                self = self
            };
            _beforeGetPlayerDataKillsName?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetPlayerDataKillsName != null) retVal = _afterGetPlayerDataKillsName.Invoke(@params);
            return retVal;
        }

        internal static void HookGetPlayerDataNewDataName()
        {
            if (!HookedList.Contains("GetPlayerDataNewDataName"))
            {
                HookedList.Add("GetPlayerDataNewDataName");
                On.JournalEntryStats.GetPlayerDataNewDataName += GetPlayerDataNewDataName;
            }
        }

        internal static event Delegates.GetPlayerDataNewDataName_BeforeArgs _beforeGetPlayerDataNewDataName;
        internal static event Delegates.GetPlayerDataNewDataName_NormalArgs _afterGetPlayerDataNewDataName;

        private static string GetPlayerDataNewDataName(On.JournalEntryStats.orig_GetPlayerDataNewDataName orig,
            JournalEntryStats self)
        {
            Delegates.Params_GetPlayerDataNewDataName @params = new()
            {
                self = self
            };
            _beforeGetPlayerDataNewDataName?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetPlayerDataNewDataName != null) retVal = _afterGetPlayerDataNewDataName.Invoke(@params);
            return retVal;
        }

        internal static void HookGetItemNumber()
        {
            if (!HookedList.Contains("GetItemNumber"))
            {
                HookedList.Add("GetItemNumber");
                On.JournalEntryStats.GetItemNumber += GetItemNumber;
            }
        }

        internal static event Delegates.GetItemNumber_BeforeArgs _beforeGetItemNumber;
        internal static event Delegates.GetItemNumber_NormalArgs _afterGetItemNumber;

        private static int GetItemNumber(On.JournalEntryStats.orig_GetItemNumber orig, JournalEntryStats self)
        {
            Delegates.Params_GetItemNumber @params = new()
            {
                self = self
            };
            _beforeGetItemNumber?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetItemNumber != null) retVal = _afterGetItemNumber.Invoke(@params);
            return retVal;
        }

        internal static void HookGetSprite()
        {
            if (!HookedList.Contains("GetSprite"))
            {
                HookedList.Add("GetSprite");
                On.JournalEntryStats.GetSprite += GetSprite;
            }
        }

        internal static event Delegates.GetSprite_BeforeArgs _beforeGetSprite;
        internal static event Delegates.GetSprite_NormalArgs _afterGetSprite;

        private static Sprite GetSprite(On.JournalEntryStats.orig_GetSprite orig, JournalEntryStats self)
        {
            Delegates.Params_GetSprite @params = new()
            {
                self = self
            };
            _beforeGetSprite?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetSprite != null) retVal = _afterGetSprite.Invoke(@params);
            return retVal;
        }

        internal static void HookGetWarriorGhost()
        {
            if (!HookedList.Contains("GetWarriorGhost"))
            {
                HookedList.Add("GetWarriorGhost");
                On.JournalEntryStats.GetWarriorGhost += GetWarriorGhost;
            }
        }

        internal static event Delegates.GetWarriorGhost_BeforeArgs _beforeGetWarriorGhost;
        internal static event Delegates.GetWarriorGhost_NormalArgs _afterGetWarriorGhost;

        private static bool GetWarriorGhost(On.JournalEntryStats.orig_GetWarriorGhost orig, JournalEntryStats self)
        {
            Delegates.Params_GetWarriorGhost @params = new()
            {
                self = self
            };
            _beforeGetWarriorGhost?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetWarriorGhost != null) retVal = _afterGetWarriorGhost.Invoke(@params);
            return retVal;
        }

        internal static void HookGetGrimm()
        {
            if (!HookedList.Contains("GetGrimm"))
            {
                HookedList.Add("GetGrimm");
                On.JournalEntryStats.GetGrimm += GetGrimm;
            }
        }

        internal static event Delegates.GetGrimm_BeforeArgs _beforeGetGrimm;
        internal static event Delegates.GetGrimm_NormalArgs _afterGetGrimm;

        private static bool GetGrimm(On.JournalEntryStats.orig_GetGrimm orig, JournalEntryStats self)
        {
            Delegates.Params_GetGrimm @params = new()
            {
                self = self
            };
            _beforeGetGrimm?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetGrimm != null) retVal = _afterGetGrimm.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void GetDescConvo_BeforeArgs(Params_GetDescConvo args);

        public delegate string GetDescConvo_NormalArgs(Params_GetDescConvo args);

        public delegate void GetGrimm_BeforeArgs(Params_GetGrimm args);

        public delegate bool GetGrimm_NormalArgs(Params_GetGrimm args);

        public delegate void GetItemNumber_BeforeArgs(Params_GetItemNumber args);

        public delegate int GetItemNumber_NormalArgs(Params_GetItemNumber args);

        public delegate void GetNameConvo_BeforeArgs(Params_GetNameConvo args);

        public delegate string GetNameConvo_NormalArgs(Params_GetNameConvo args);

        public delegate void GetNotesConvo_BeforeArgs(Params_GetNotesConvo args);

        public delegate string GetNotesConvo_NormalArgs(Params_GetNotesConvo args);

        public delegate void GetPlayerDataBoolName_BeforeArgs(Params_GetPlayerDataBoolName args);

        public delegate string GetPlayerDataBoolName_NormalArgs(Params_GetPlayerDataBoolName args);

        public delegate void GetPlayerDataKillsName_BeforeArgs(Params_GetPlayerDataKillsName args);

        public delegate string GetPlayerDataKillsName_NormalArgs(Params_GetPlayerDataKillsName args);

        public delegate void GetPlayerDataNewDataName_BeforeArgs(Params_GetPlayerDataNewDataName args);

        public delegate string GetPlayerDataNewDataName_NormalArgs(Params_GetPlayerDataNewDataName args);

        public delegate void GetSprite_BeforeArgs(Params_GetSprite args);

        public delegate Sprite GetSprite_NormalArgs(Params_GetSprite args);

        public delegate void GetWarriorGhost_BeforeArgs(Params_GetWarriorGhost args);

        public delegate bool GetWarriorGhost_NormalArgs(Params_GetWarriorGhost args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public JournalEntryStats self;
        }

        public sealed class Params_OnEnable
        {
            public JournalEntryStats self;
        }

        public sealed class Params_OnDisable
        {
            public JournalEntryStats self;
        }

        public sealed class Params_Update
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetNameConvo
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetDescConvo
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetNotesConvo
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetPlayerDataBoolName
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetPlayerDataKillsName
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetPlayerDataNewDataName
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetItemNumber
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetSprite
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetWarriorGhost
        {
            public JournalEntryStats self;
        }

        public sealed class Params_GetGrimm
        {
            public JournalEntryStats self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.GetNameConvo_BeforeArgs GetNameConvo
        {
            add
            {
                HookHandler._beforeGetNameConvo += value;
                HookHandler.HookGetNameConvo();
            }
            remove => HookHandler._beforeGetNameConvo -= value;
        }

        public static event Delegates.GetDescConvo_BeforeArgs GetDescConvo
        {
            add
            {
                HookHandler._beforeGetDescConvo += value;
                HookHandler.HookGetDescConvo();
            }
            remove => HookHandler._beforeGetDescConvo -= value;
        }

        public static event Delegates.GetNotesConvo_BeforeArgs GetNotesConvo
        {
            add
            {
                HookHandler._beforeGetNotesConvo += value;
                HookHandler.HookGetNotesConvo();
            }
            remove => HookHandler._beforeGetNotesConvo -= value;
        }

        public static event Delegates.GetPlayerDataBoolName_BeforeArgs GetPlayerDataBoolName
        {
            add
            {
                HookHandler._beforeGetPlayerDataBoolName += value;
                HookHandler.HookGetPlayerDataBoolName();
            }
            remove => HookHandler._beforeGetPlayerDataBoolName -= value;
        }

        public static event Delegates.GetPlayerDataKillsName_BeforeArgs GetPlayerDataKillsName
        {
            add
            {
                HookHandler._beforeGetPlayerDataKillsName += value;
                HookHandler.HookGetPlayerDataKillsName();
            }
            remove => HookHandler._beforeGetPlayerDataKillsName -= value;
        }

        public static event Delegates.GetPlayerDataNewDataName_BeforeArgs GetPlayerDataNewDataName
        {
            add
            {
                HookHandler._beforeGetPlayerDataNewDataName += value;
                HookHandler.HookGetPlayerDataNewDataName();
            }
            remove => HookHandler._beforeGetPlayerDataNewDataName -= value;
        }

        public static event Delegates.GetItemNumber_BeforeArgs GetItemNumber
        {
            add
            {
                HookHandler._beforeGetItemNumber += value;
                HookHandler.HookGetItemNumber();
            }
            remove => HookHandler._beforeGetItemNumber -= value;
        }

        public static event Delegates.GetSprite_BeforeArgs GetSprite
        {
            add
            {
                HookHandler._beforeGetSprite += value;
                HookHandler.HookGetSprite();
            }
            remove => HookHandler._beforeGetSprite -= value;
        }

        public static event Delegates.GetWarriorGhost_BeforeArgs GetWarriorGhost
        {
            add
            {
                HookHandler._beforeGetWarriorGhost += value;
                HookHandler.HookGetWarriorGhost();
            }
            remove => HookHandler._beforeGetWarriorGhost -= value;
        }

        public static event Delegates.GetGrimm_BeforeArgs GetGrimm
        {
            add
            {
                HookHandler._beforeGetGrimm += value;
                HookHandler.HookGetGrimm();
            }
            remove => HookHandler._beforeGetGrimm -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.GetNameConvo_NormalArgs GetNameConvo
        {
            add
            {
                HookHandler._afterGetNameConvo += value;
                HookHandler.HookGetNameConvo();
            }
            remove => HookHandler._afterGetNameConvo -= value;
        }

        public static event Delegates.GetDescConvo_NormalArgs GetDescConvo
        {
            add
            {
                HookHandler._afterGetDescConvo += value;
                HookHandler.HookGetDescConvo();
            }
            remove => HookHandler._afterGetDescConvo -= value;
        }

        public static event Delegates.GetNotesConvo_NormalArgs GetNotesConvo
        {
            add
            {
                HookHandler._afterGetNotesConvo += value;
                HookHandler.HookGetNotesConvo();
            }
            remove => HookHandler._afterGetNotesConvo -= value;
        }

        public static event Delegates.GetPlayerDataBoolName_NormalArgs GetPlayerDataBoolName
        {
            add
            {
                HookHandler._afterGetPlayerDataBoolName += value;
                HookHandler.HookGetPlayerDataBoolName();
            }
            remove => HookHandler._afterGetPlayerDataBoolName -= value;
        }

        public static event Delegates.GetPlayerDataKillsName_NormalArgs GetPlayerDataKillsName
        {
            add
            {
                HookHandler._afterGetPlayerDataKillsName += value;
                HookHandler.HookGetPlayerDataKillsName();
            }
            remove => HookHandler._afterGetPlayerDataKillsName -= value;
        }

        public static event Delegates.GetPlayerDataNewDataName_NormalArgs GetPlayerDataNewDataName
        {
            add
            {
                HookHandler._afterGetPlayerDataNewDataName += value;
                HookHandler.HookGetPlayerDataNewDataName();
            }
            remove => HookHandler._afterGetPlayerDataNewDataName -= value;
        }

        public static event Delegates.GetItemNumber_NormalArgs GetItemNumber
        {
            add
            {
                HookHandler._afterGetItemNumber += value;
                HookHandler.HookGetItemNumber();
            }
            remove => HookHandler._afterGetItemNumber -= value;
        }

        public static event Delegates.GetSprite_NormalArgs GetSprite
        {
            add
            {
                HookHandler._afterGetSprite += value;
                HookHandler.HookGetSprite();
            }
            remove => HookHandler._afterGetSprite -= value;
        }

        public static event Delegates.GetWarriorGhost_NormalArgs GetWarriorGhost
        {
            add
            {
                HookHandler._afterGetWarriorGhost += value;
                HookHandler.HookGetWarriorGhost();
            }
            remove => HookHandler._afterGetWarriorGhost -= value;
        }

        public static event Delegates.GetGrimm_NormalArgs GetGrimm
        {
            add
            {
                HookHandler._afterGetGrimm += value;
                HookHandler.HookGetGrimm();
            }
            remove => HookHandler._afterGetGrimm -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.JournalEntryStats.hook_Awake Awake
        {
            add => On.JournalEntryStats.Awake += value;
            remove => On.JournalEntryStats.Awake -= value;
        }

        public static event On.JournalEntryStats.hook_OnEnable OnEnable
        {
            add => On.JournalEntryStats.OnEnable += value;
            remove => On.JournalEntryStats.OnEnable -= value;
        }

        public static event On.JournalEntryStats.hook_OnDisable OnDisable
        {
            add => On.JournalEntryStats.OnDisable += value;
            remove => On.JournalEntryStats.OnDisable -= value;
        }

        public static event On.JournalEntryStats.hook_Update Update
        {
            add => On.JournalEntryStats.Update += value;
            remove => On.JournalEntryStats.Update -= value;
        }

        public static event On.JournalEntryStats.hook_GetNameConvo GetNameConvo
        {
            add => On.JournalEntryStats.GetNameConvo += value;
            remove => On.JournalEntryStats.GetNameConvo -= value;
        }

        public static event On.JournalEntryStats.hook_GetDescConvo GetDescConvo
        {
            add => On.JournalEntryStats.GetDescConvo += value;
            remove => On.JournalEntryStats.GetDescConvo -= value;
        }

        public static event On.JournalEntryStats.hook_GetNotesConvo GetNotesConvo
        {
            add => On.JournalEntryStats.GetNotesConvo += value;
            remove => On.JournalEntryStats.GetNotesConvo -= value;
        }

        public static event On.JournalEntryStats.hook_GetPlayerDataBoolName GetPlayerDataBoolName
        {
            add => On.JournalEntryStats.GetPlayerDataBoolName += value;
            remove => On.JournalEntryStats.GetPlayerDataBoolName -= value;
        }

        public static event On.JournalEntryStats.hook_GetPlayerDataKillsName GetPlayerDataKillsName
        {
            add => On.JournalEntryStats.GetPlayerDataKillsName += value;
            remove => On.JournalEntryStats.GetPlayerDataKillsName -= value;
        }

        public static event On.JournalEntryStats.hook_GetPlayerDataNewDataName GetPlayerDataNewDataName
        {
            add => On.JournalEntryStats.GetPlayerDataNewDataName += value;
            remove => On.JournalEntryStats.GetPlayerDataNewDataName -= value;
        }

        public static event On.JournalEntryStats.hook_GetItemNumber GetItemNumber
        {
            add => On.JournalEntryStats.GetItemNumber += value;
            remove => On.JournalEntryStats.GetItemNumber -= value;
        }

        public static event On.JournalEntryStats.hook_GetSprite GetSprite
        {
            add => On.JournalEntryStats.GetSprite += value;
            remove => On.JournalEntryStats.GetSprite -= value;
        }

        public static event On.JournalEntryStats.hook_GetWarriorGhost GetWarriorGhost
        {
            add => On.JournalEntryStats.GetWarriorGhost += value;
            remove => On.JournalEntryStats.GetWarriorGhost -= value;
        }

        public static event On.JournalEntryStats.hook_GetGrimm GetGrimm
        {
            add => On.JournalEntryStats.GetGrimm += value;
            remove => On.JournalEntryStats.GetGrimm -= value;
        }
    }
}