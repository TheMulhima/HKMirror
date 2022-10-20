namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CaptureAnimationEvent class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCaptureAnimationEvent
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.CaptureAnimationEvent.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.CaptureAnimationEvent.orig_Start orig, CaptureAnimationEvent self)
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

        internal static void HookSetPlayerDataBoolTrue()
        {
            if (!HookedList.Contains("SetPlayerDataBoolTrue"))
            {
                HookedList.Add("SetPlayerDataBoolTrue");
                On.CaptureAnimationEvent.SetPlayerDataBoolTrue += SetPlayerDataBoolTrue;
            }
        }

        internal static event Delegates.SetPlayerDataBoolTrue_BeforeArgs _beforeSetPlayerDataBoolTrue;
        internal static event Delegates.SetPlayerDataBoolTrue_NormalArgs _afterSetPlayerDataBoolTrue;

        private static void SetPlayerDataBoolTrue(On.CaptureAnimationEvent.orig_SetPlayerDataBoolTrue orig,
            CaptureAnimationEvent self, string boolName)
        {
            Delegates.Params_SetPlayerDataBoolTrue @params = new()
            {
                self = self, boolName = boolName
            };
            _beforeSetPlayerDataBoolTrue?.Invoke(@params);
            self = @params.self;
            boolName = @params.boolName;
            orig(self, boolName);
            if (_afterSetPlayerDataBoolTrue != null) _afterSetPlayerDataBoolTrue.Invoke(@params);
        }

        internal static void HookSetPlayerDataBoolFalse()
        {
            if (!HookedList.Contains("SetPlayerDataBoolFalse"))
            {
                HookedList.Add("SetPlayerDataBoolFalse");
                On.CaptureAnimationEvent.SetPlayerDataBoolFalse += SetPlayerDataBoolFalse;
            }
        }

        internal static event Delegates.SetPlayerDataBoolFalse_BeforeArgs _beforeSetPlayerDataBoolFalse;
        internal static event Delegates.SetPlayerDataBoolFalse_NormalArgs _afterSetPlayerDataBoolFalse;

        private static void SetPlayerDataBoolFalse(On.CaptureAnimationEvent.orig_SetPlayerDataBoolFalse orig,
            CaptureAnimationEvent self, string boolName)
        {
            Delegates.Params_SetPlayerDataBoolFalse @params = new()
            {
                self = self, boolName = boolName
            };
            _beforeSetPlayerDataBoolFalse?.Invoke(@params);
            self = @params.self;
            boolName = @params.boolName;
            orig(self, boolName);
            if (_afterSetPlayerDataBoolFalse != null) _afterSetPlayerDataBoolFalse.Invoke(@params);
        }

        internal static void HookIncrementPlayerDataInt()
        {
            if (!HookedList.Contains("IncrementPlayerDataInt"))
            {
                HookedList.Add("IncrementPlayerDataInt");
                On.CaptureAnimationEvent.IncrementPlayerDataInt += IncrementPlayerDataInt;
            }
        }

        internal static event Delegates.IncrementPlayerDataInt_BeforeArgs _beforeIncrementPlayerDataInt;
        internal static event Delegates.IncrementPlayerDataInt_NormalArgs _afterIncrementPlayerDataInt;

        private static void IncrementPlayerDataInt(On.CaptureAnimationEvent.orig_IncrementPlayerDataInt orig,
            CaptureAnimationEvent self, string intName)
        {
            Delegates.Params_IncrementPlayerDataInt @params = new()
            {
                self = self, intName = intName
            };
            _beforeIncrementPlayerDataInt?.Invoke(@params);
            self = @params.self;
            intName = @params.intName;
            orig(self, intName);
            if (_afterIncrementPlayerDataInt != null) _afterIncrementPlayerDataInt.Invoke(@params);
        }

        internal static void HookDecrementPlayerDataInt()
        {
            if (!HookedList.Contains("DecrementPlayerDataInt"))
            {
                HookedList.Add("DecrementPlayerDataInt");
                On.CaptureAnimationEvent.DecrementPlayerDataInt += DecrementPlayerDataInt;
            }
        }

        internal static event Delegates.DecrementPlayerDataInt_BeforeArgs _beforeDecrementPlayerDataInt;
        internal static event Delegates.DecrementPlayerDataInt_NormalArgs _afterDecrementPlayerDataInt;

        private static void DecrementPlayerDataInt(On.CaptureAnimationEvent.orig_DecrementPlayerDataInt orig,
            CaptureAnimationEvent self, string intName)
        {
            Delegates.Params_DecrementPlayerDataInt @params = new()
            {
                self = self, intName = intName
            };
            _beforeDecrementPlayerDataInt?.Invoke(@params);
            self = @params.self;
            intName = @params.intName;
            orig(self, intName);
            if (_afterDecrementPlayerDataInt != null) _afterDecrementPlayerDataInt.Invoke(@params);
        }

        internal static void HookGetPlayerDataBool()
        {
            if (!HookedList.Contains("GetPlayerDataBool"))
            {
                HookedList.Add("GetPlayerDataBool");
                On.CaptureAnimationEvent.GetPlayerDataBool += GetPlayerDataBool;
            }
        }

        internal static event Delegates.GetPlayerDataBool_BeforeArgs _beforeGetPlayerDataBool;
        internal static event Delegates.GetPlayerDataBool_NormalArgs _afterGetPlayerDataBool;

        private static bool GetPlayerDataBool(On.CaptureAnimationEvent.orig_GetPlayerDataBool orig,
            CaptureAnimationEvent self, string boolName)
        {
            Delegates.Params_GetPlayerDataBool @params = new()
            {
                self = self, boolName = boolName
            };
            _beforeGetPlayerDataBool?.Invoke(@params);
            self = @params.self;
            boolName = @params.boolName;
            var retVal = orig(self, boolName);
            if (_afterGetPlayerDataBool != null) retVal = _afterGetPlayerDataBool.Invoke(@params);
            return retVal;
        }

        internal static void HookGetPlayerDataInt()
        {
            if (!HookedList.Contains("GetPlayerDataInt"))
            {
                HookedList.Add("GetPlayerDataInt");
                On.CaptureAnimationEvent.GetPlayerDataInt += GetPlayerDataInt;
            }
        }

        internal static event Delegates.GetPlayerDataInt_BeforeArgs _beforeGetPlayerDataInt;
        internal static event Delegates.GetPlayerDataInt_NormalArgs _afterGetPlayerDataInt;

        private static int GetPlayerDataInt(On.CaptureAnimationEvent.orig_GetPlayerDataInt orig,
            CaptureAnimationEvent self, string intName)
        {
            Delegates.Params_GetPlayerDataInt @params = new()
            {
                self = self, intName = intName
            };
            _beforeGetPlayerDataInt?.Invoke(@params);
            self = @params.self;
            intName = @params.intName;
            var retVal = orig(self, intName);
            if (_afterGetPlayerDataInt != null) retVal = _afterGetPlayerDataInt.Invoke(@params);
            return retVal;
        }

        internal static void HookGetPlayerDataFloat()
        {
            if (!HookedList.Contains("GetPlayerDataFloat"))
            {
                HookedList.Add("GetPlayerDataFloat");
                On.CaptureAnimationEvent.GetPlayerDataFloat += GetPlayerDataFloat;
            }
        }

        internal static event Delegates.GetPlayerDataFloat_BeforeArgs _beforeGetPlayerDataFloat;
        internal static event Delegates.GetPlayerDataFloat_NormalArgs _afterGetPlayerDataFloat;

        private static float GetPlayerDataFloat(On.CaptureAnimationEvent.orig_GetPlayerDataFloat orig,
            CaptureAnimationEvent self, string floatName)
        {
            Delegates.Params_GetPlayerDataFloat @params = new()
            {
                self = self, floatName = floatName
            };
            _beforeGetPlayerDataFloat?.Invoke(@params);
            self = @params.self;
            floatName = @params.floatName;
            var retVal = orig(self, floatName);
            if (_afterGetPlayerDataFloat != null) retVal = _afterGetPlayerDataFloat.Invoke(@params);
            return retVal;
        }

        internal static void HookGetPlayerDataString()
        {
            if (!HookedList.Contains("GetPlayerDataString"))
            {
                HookedList.Add("GetPlayerDataString");
                On.CaptureAnimationEvent.GetPlayerDataString += GetPlayerDataString;
            }
        }

        internal static event Delegates.GetPlayerDataString_BeforeArgs _beforeGetPlayerDataString;
        internal static event Delegates.GetPlayerDataString_NormalArgs _afterGetPlayerDataString;

        private static string GetPlayerDataString(On.CaptureAnimationEvent.orig_GetPlayerDataString orig,
            CaptureAnimationEvent self, string stringName)
        {
            Delegates.Params_GetPlayerDataString @params = new()
            {
                self = self, stringName = stringName
            };
            _beforeGetPlayerDataString?.Invoke(@params);
            self = @params.self;
            stringName = @params.stringName;
            var retVal = orig(self, stringName);
            if (_afterGetPlayerDataString != null) retVal = _afterGetPlayerDataString.Invoke(@params);
            return retVal;
        }

        internal static void HookEquipCharm()
        {
            if (!HookedList.Contains("EquipCharm"))
            {
                HookedList.Add("EquipCharm");
                On.CaptureAnimationEvent.EquipCharm += EquipCharm;
            }
        }

        internal static event Delegates.EquipCharm_BeforeArgs _beforeEquipCharm;
        internal static event Delegates.EquipCharm_NormalArgs _afterEquipCharm;

        private static void EquipCharm(On.CaptureAnimationEvent.orig_EquipCharm orig, CaptureAnimationEvent self,
            int charmNum)
        {
            Delegates.Params_EquipCharm @params = new()
            {
                self = self, charmNum = charmNum
            };
            _beforeEquipCharm?.Invoke(@params);
            self = @params.self;
            charmNum = @params.charmNum;
            orig(self, charmNum);
            if (_afterEquipCharm != null) _afterEquipCharm.Invoke(@params);
        }

        internal static void HookUnequipCharm()
        {
            if (!HookedList.Contains("UnequipCharm"))
            {
                HookedList.Add("UnequipCharm");
                On.CaptureAnimationEvent.UnequipCharm += UnequipCharm;
            }
        }

        internal static event Delegates.UnequipCharm_BeforeArgs _beforeUnequipCharm;
        internal static event Delegates.UnequipCharm_NormalArgs _afterUnequipCharm;

        private static void UnequipCharm(On.CaptureAnimationEvent.orig_UnequipCharm orig, CaptureAnimationEvent self,
            int charmNum)
        {
            Delegates.Params_UnequipCharm @params = new()
            {
                self = self, charmNum = charmNum
            };
            _beforeUnequipCharm?.Invoke(@params);
            self = @params.self;
            charmNum = @params.charmNum;
            orig(self, charmNum);
            if (_afterUnequipCharm != null) _afterUnequipCharm.Invoke(@params);
        }

        internal static void HookUpdateBlueHealth()
        {
            if (!HookedList.Contains("UpdateBlueHealth"))
            {
                HookedList.Add("UpdateBlueHealth");
                On.CaptureAnimationEvent.UpdateBlueHealth += UpdateBlueHealth;
            }
        }

        internal static event Delegates.UpdateBlueHealth_BeforeArgs _beforeUpdateBlueHealth;
        internal static event Delegates.UpdateBlueHealth_NormalArgs _afterUpdateBlueHealth;

        private static void UpdateBlueHealth(On.CaptureAnimationEvent.orig_UpdateBlueHealth orig,
            CaptureAnimationEvent self)
        {
            Delegates.Params_UpdateBlueHealth @params = new()
            {
                self = self
            };
            _beforeUpdateBlueHealth?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdateBlueHealth != null) _afterUpdateBlueHealth.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DecrementPlayerDataInt_BeforeArgs(Params_DecrementPlayerDataInt args);

        public delegate void DecrementPlayerDataInt_NormalArgs(Params_DecrementPlayerDataInt args);

        public delegate void EquipCharm_BeforeArgs(Params_EquipCharm args);

        public delegate void EquipCharm_NormalArgs(Params_EquipCharm args);

        public delegate void GetPlayerDataBool_BeforeArgs(Params_GetPlayerDataBool args);

        public delegate bool GetPlayerDataBool_NormalArgs(Params_GetPlayerDataBool args);

        public delegate void GetPlayerDataFloat_BeforeArgs(Params_GetPlayerDataFloat args);

        public delegate float GetPlayerDataFloat_NormalArgs(Params_GetPlayerDataFloat args);

        public delegate void GetPlayerDataInt_BeforeArgs(Params_GetPlayerDataInt args);

        public delegate int GetPlayerDataInt_NormalArgs(Params_GetPlayerDataInt args);

        public delegate void GetPlayerDataString_BeforeArgs(Params_GetPlayerDataString args);

        public delegate string GetPlayerDataString_NormalArgs(Params_GetPlayerDataString args);

        public delegate void IncrementPlayerDataInt_BeforeArgs(Params_IncrementPlayerDataInt args);

        public delegate void IncrementPlayerDataInt_NormalArgs(Params_IncrementPlayerDataInt args);

        public delegate void SetPlayerDataBoolFalse_BeforeArgs(Params_SetPlayerDataBoolFalse args);

        public delegate void SetPlayerDataBoolFalse_NormalArgs(Params_SetPlayerDataBoolFalse args);

        public delegate void SetPlayerDataBoolTrue_BeforeArgs(Params_SetPlayerDataBoolTrue args);

        public delegate void SetPlayerDataBoolTrue_NormalArgs(Params_SetPlayerDataBoolTrue args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void UnequipCharm_BeforeArgs(Params_UnequipCharm args);

        public delegate void UnequipCharm_NormalArgs(Params_UnequipCharm args);

        public delegate void UpdateBlueHealth_BeforeArgs(Params_UpdateBlueHealth args);

        public delegate void UpdateBlueHealth_NormalArgs(Params_UpdateBlueHealth args);

        public sealed class Params_Start
        {
            public CaptureAnimationEvent self;
        }

        public sealed class Params_SetPlayerDataBoolTrue
        {
            public string boolName;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_SetPlayerDataBoolFalse
        {
            public string boolName;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_IncrementPlayerDataInt
        {
            public string intName;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_DecrementPlayerDataInt
        {
            public string intName;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_GetPlayerDataBool
        {
            public string boolName;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_GetPlayerDataInt
        {
            public string intName;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_GetPlayerDataFloat
        {
            public string floatName;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_GetPlayerDataString
        {
            public CaptureAnimationEvent self;
            public string stringName;
        }

        public sealed class Params_EquipCharm
        {
            public int charmNum;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_UnequipCharm
        {
            public int charmNum;
            public CaptureAnimationEvent self;
        }

        public sealed class Params_UpdateBlueHealth
        {
            public CaptureAnimationEvent self;
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

        public static event Delegates.SetPlayerDataBoolTrue_BeforeArgs SetPlayerDataBoolTrue
        {
            add
            {
                HookHandler._beforeSetPlayerDataBoolTrue += value;
                HookHandler.HookSetPlayerDataBoolTrue();
            }
            remove => HookHandler._beforeSetPlayerDataBoolTrue -= value;
        }

        public static event Delegates.SetPlayerDataBoolFalse_BeforeArgs SetPlayerDataBoolFalse
        {
            add
            {
                HookHandler._beforeSetPlayerDataBoolFalse += value;
                HookHandler.HookSetPlayerDataBoolFalse();
            }
            remove => HookHandler._beforeSetPlayerDataBoolFalse -= value;
        }

        public static event Delegates.IncrementPlayerDataInt_BeforeArgs IncrementPlayerDataInt
        {
            add
            {
                HookHandler._beforeIncrementPlayerDataInt += value;
                HookHandler.HookIncrementPlayerDataInt();
            }
            remove => HookHandler._beforeIncrementPlayerDataInt -= value;
        }

        public static event Delegates.DecrementPlayerDataInt_BeforeArgs DecrementPlayerDataInt
        {
            add
            {
                HookHandler._beforeDecrementPlayerDataInt += value;
                HookHandler.HookDecrementPlayerDataInt();
            }
            remove => HookHandler._beforeDecrementPlayerDataInt -= value;
        }

        public static event Delegates.GetPlayerDataBool_BeforeArgs GetPlayerDataBool
        {
            add
            {
                HookHandler._beforeGetPlayerDataBool += value;
                HookHandler.HookGetPlayerDataBool();
            }
            remove => HookHandler._beforeGetPlayerDataBool -= value;
        }

        public static event Delegates.GetPlayerDataInt_BeforeArgs GetPlayerDataInt
        {
            add
            {
                HookHandler._beforeGetPlayerDataInt += value;
                HookHandler.HookGetPlayerDataInt();
            }
            remove => HookHandler._beforeGetPlayerDataInt -= value;
        }

        public static event Delegates.GetPlayerDataFloat_BeforeArgs GetPlayerDataFloat
        {
            add
            {
                HookHandler._beforeGetPlayerDataFloat += value;
                HookHandler.HookGetPlayerDataFloat();
            }
            remove => HookHandler._beforeGetPlayerDataFloat -= value;
        }

        public static event Delegates.GetPlayerDataString_BeforeArgs GetPlayerDataString
        {
            add
            {
                HookHandler._beforeGetPlayerDataString += value;
                HookHandler.HookGetPlayerDataString();
            }
            remove => HookHandler._beforeGetPlayerDataString -= value;
        }

        public static event Delegates.EquipCharm_BeforeArgs EquipCharm
        {
            add
            {
                HookHandler._beforeEquipCharm += value;
                HookHandler.HookEquipCharm();
            }
            remove => HookHandler._beforeEquipCharm -= value;
        }

        public static event Delegates.UnequipCharm_BeforeArgs UnequipCharm
        {
            add
            {
                HookHandler._beforeUnequipCharm += value;
                HookHandler.HookUnequipCharm();
            }
            remove => HookHandler._beforeUnequipCharm -= value;
        }

        public static event Delegates.UpdateBlueHealth_BeforeArgs UpdateBlueHealth
        {
            add
            {
                HookHandler._beforeUpdateBlueHealth += value;
                HookHandler.HookUpdateBlueHealth();
            }
            remove => HookHandler._beforeUpdateBlueHealth -= value;
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

        public static event Delegates.SetPlayerDataBoolTrue_NormalArgs SetPlayerDataBoolTrue
        {
            add
            {
                HookHandler._afterSetPlayerDataBoolTrue += value;
                HookHandler.HookSetPlayerDataBoolTrue();
            }
            remove => HookHandler._afterSetPlayerDataBoolTrue -= value;
        }

        public static event Delegates.SetPlayerDataBoolFalse_NormalArgs SetPlayerDataBoolFalse
        {
            add
            {
                HookHandler._afterSetPlayerDataBoolFalse += value;
                HookHandler.HookSetPlayerDataBoolFalse();
            }
            remove => HookHandler._afterSetPlayerDataBoolFalse -= value;
        }

        public static event Delegates.IncrementPlayerDataInt_NormalArgs IncrementPlayerDataInt
        {
            add
            {
                HookHandler._afterIncrementPlayerDataInt += value;
                HookHandler.HookIncrementPlayerDataInt();
            }
            remove => HookHandler._afterIncrementPlayerDataInt -= value;
        }

        public static event Delegates.DecrementPlayerDataInt_NormalArgs DecrementPlayerDataInt
        {
            add
            {
                HookHandler._afterDecrementPlayerDataInt += value;
                HookHandler.HookDecrementPlayerDataInt();
            }
            remove => HookHandler._afterDecrementPlayerDataInt -= value;
        }

        public static event Delegates.GetPlayerDataBool_NormalArgs GetPlayerDataBool
        {
            add
            {
                HookHandler._afterGetPlayerDataBool += value;
                HookHandler.HookGetPlayerDataBool();
            }
            remove => HookHandler._afterGetPlayerDataBool -= value;
        }

        public static event Delegates.GetPlayerDataInt_NormalArgs GetPlayerDataInt
        {
            add
            {
                HookHandler._afterGetPlayerDataInt += value;
                HookHandler.HookGetPlayerDataInt();
            }
            remove => HookHandler._afterGetPlayerDataInt -= value;
        }

        public static event Delegates.GetPlayerDataFloat_NormalArgs GetPlayerDataFloat
        {
            add
            {
                HookHandler._afterGetPlayerDataFloat += value;
                HookHandler.HookGetPlayerDataFloat();
            }
            remove => HookHandler._afterGetPlayerDataFloat -= value;
        }

        public static event Delegates.GetPlayerDataString_NormalArgs GetPlayerDataString
        {
            add
            {
                HookHandler._afterGetPlayerDataString += value;
                HookHandler.HookGetPlayerDataString();
            }
            remove => HookHandler._afterGetPlayerDataString -= value;
        }

        public static event Delegates.EquipCharm_NormalArgs EquipCharm
        {
            add
            {
                HookHandler._afterEquipCharm += value;
                HookHandler.HookEquipCharm();
            }
            remove => HookHandler._afterEquipCharm -= value;
        }

        public static event Delegates.UnequipCharm_NormalArgs UnequipCharm
        {
            add
            {
                HookHandler._afterUnequipCharm += value;
                HookHandler.HookUnequipCharm();
            }
            remove => HookHandler._afterUnequipCharm -= value;
        }

        public static event Delegates.UpdateBlueHealth_NormalArgs UpdateBlueHealth
        {
            add
            {
                HookHandler._afterUpdateBlueHealth += value;
                HookHandler.HookUpdateBlueHealth();
            }
            remove => HookHandler._afterUpdateBlueHealth -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CaptureAnimationEvent.hook_Start Start
        {
            add => On.CaptureAnimationEvent.Start += value;
            remove => On.CaptureAnimationEvent.Start -= value;
        }

        public static event On.CaptureAnimationEvent.hook_SetPlayerDataBoolTrue SetPlayerDataBoolTrue
        {
            add => On.CaptureAnimationEvent.SetPlayerDataBoolTrue += value;
            remove => On.CaptureAnimationEvent.SetPlayerDataBoolTrue -= value;
        }

        public static event On.CaptureAnimationEvent.hook_SetPlayerDataBoolFalse SetPlayerDataBoolFalse
        {
            add => On.CaptureAnimationEvent.SetPlayerDataBoolFalse += value;
            remove => On.CaptureAnimationEvent.SetPlayerDataBoolFalse -= value;
        }

        public static event On.CaptureAnimationEvent.hook_IncrementPlayerDataInt IncrementPlayerDataInt
        {
            add => On.CaptureAnimationEvent.IncrementPlayerDataInt += value;
            remove => On.CaptureAnimationEvent.IncrementPlayerDataInt -= value;
        }

        public static event On.CaptureAnimationEvent.hook_DecrementPlayerDataInt DecrementPlayerDataInt
        {
            add => On.CaptureAnimationEvent.DecrementPlayerDataInt += value;
            remove => On.CaptureAnimationEvent.DecrementPlayerDataInt -= value;
        }

        public static event On.CaptureAnimationEvent.hook_GetPlayerDataBool GetPlayerDataBool
        {
            add => On.CaptureAnimationEvent.GetPlayerDataBool += value;
            remove => On.CaptureAnimationEvent.GetPlayerDataBool -= value;
        }

        public static event On.CaptureAnimationEvent.hook_GetPlayerDataInt GetPlayerDataInt
        {
            add => On.CaptureAnimationEvent.GetPlayerDataInt += value;
            remove => On.CaptureAnimationEvent.GetPlayerDataInt -= value;
        }

        public static event On.CaptureAnimationEvent.hook_GetPlayerDataFloat GetPlayerDataFloat
        {
            add => On.CaptureAnimationEvent.GetPlayerDataFloat += value;
            remove => On.CaptureAnimationEvent.GetPlayerDataFloat -= value;
        }

        public static event On.CaptureAnimationEvent.hook_GetPlayerDataString GetPlayerDataString
        {
            add => On.CaptureAnimationEvent.GetPlayerDataString += value;
            remove => On.CaptureAnimationEvent.GetPlayerDataString -= value;
        }

        public static event On.CaptureAnimationEvent.hook_EquipCharm EquipCharm
        {
            add => On.CaptureAnimationEvent.EquipCharm += value;
            remove => On.CaptureAnimationEvent.EquipCharm -= value;
        }

        public static event On.CaptureAnimationEvent.hook_UnequipCharm UnequipCharm
        {
            add => On.CaptureAnimationEvent.UnequipCharm += value;
            remove => On.CaptureAnimationEvent.UnequipCharm -= value;
        }

        public static event On.CaptureAnimationEvent.hook_UpdateBlueHealth UpdateBlueHealth
        {
            add => On.CaptureAnimationEvent.UpdateBlueHealth += value;
            remove => On.CaptureAnimationEvent.UpdateBlueHealth -= value;
        }
    }
}