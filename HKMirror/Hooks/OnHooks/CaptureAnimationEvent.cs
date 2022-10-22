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
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.CaptureAnimationEvent.orig_Start orig, CaptureAnimationEvent self)
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

        internal static void HookSetPlayerDataBoolTrue()
        {
            if (!HookedList.Contains("SetPlayerDataBoolTrue"))
            {
                HookedList.Add("SetPlayerDataBoolTrue");
                On.CaptureAnimationEvent.SetPlayerDataBoolTrue += SetPlayerDataBoolTrue;
            }
        }

        internal static event Delegates.SetPlayerDataBoolTrue_BeforeArgs _beforeSetPlayerDataBoolTrue;
        internal static event Delegates.SetPlayerDataBoolTrue_AfterArgs _afterSetPlayerDataBoolTrue;

        private static void SetPlayerDataBoolTrue(On.CaptureAnimationEvent.orig_SetPlayerDataBoolTrue orig,
            CaptureAnimationEvent self, string boolName)
        {
            Delegates.Params_SetPlayerDataBoolTrue @params = new()
            {
                self = self, boolName = boolName
            };
            if (_beforeSetPlayerDataBoolTrue != null)
                foreach (Delegates.SetPlayerDataBoolTrue_BeforeArgs toInvoke in _beforeSetPlayerDataBoolTrue
                             .GetInvocationList())
                    try
                    {
                        _beforeSetPlayerDataBoolTrue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            boolName = @params.boolName;
            orig(self, boolName);
            if (_afterSetPlayerDataBoolTrue != null)
                foreach (Delegates.SetPlayerDataBoolTrue_AfterArgs toInvoke in _afterSetPlayerDataBoolTrue
                             .GetInvocationList())
                    try
                    {
                        _afterSetPlayerDataBoolTrue.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.SetPlayerDataBoolFalse_AfterArgs _afterSetPlayerDataBoolFalse;

        private static void SetPlayerDataBoolFalse(On.CaptureAnimationEvent.orig_SetPlayerDataBoolFalse orig,
            CaptureAnimationEvent self, string boolName)
        {
            Delegates.Params_SetPlayerDataBoolFalse @params = new()
            {
                self = self, boolName = boolName
            };
            if (_beforeSetPlayerDataBoolFalse != null)
                foreach (Delegates.SetPlayerDataBoolFalse_BeforeArgs toInvoke in _beforeSetPlayerDataBoolFalse
                             .GetInvocationList())
                    try
                    {
                        _beforeSetPlayerDataBoolFalse?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            boolName = @params.boolName;
            orig(self, boolName);
            if (_afterSetPlayerDataBoolFalse != null)
                foreach (Delegates.SetPlayerDataBoolFalse_AfterArgs toInvoke in _afterSetPlayerDataBoolFalse
                             .GetInvocationList())
                    try
                    {
                        _afterSetPlayerDataBoolFalse.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.IncrementPlayerDataInt_AfterArgs _afterIncrementPlayerDataInt;

        private static void IncrementPlayerDataInt(On.CaptureAnimationEvent.orig_IncrementPlayerDataInt orig,
            CaptureAnimationEvent self, string intName)
        {
            Delegates.Params_IncrementPlayerDataInt @params = new()
            {
                self = self, intName = intName
            };
            if (_beforeIncrementPlayerDataInt != null)
                foreach (Delegates.IncrementPlayerDataInt_BeforeArgs toInvoke in _beforeIncrementPlayerDataInt
                             .GetInvocationList())
                    try
                    {
                        _beforeIncrementPlayerDataInt?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            intName = @params.intName;
            orig(self, intName);
            if (_afterIncrementPlayerDataInt != null)
                foreach (Delegates.IncrementPlayerDataInt_AfterArgs toInvoke in _afterIncrementPlayerDataInt
                             .GetInvocationList())
                    try
                    {
                        _afterIncrementPlayerDataInt.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.DecrementPlayerDataInt_AfterArgs _afterDecrementPlayerDataInt;

        private static void DecrementPlayerDataInt(On.CaptureAnimationEvent.orig_DecrementPlayerDataInt orig,
            CaptureAnimationEvent self, string intName)
        {
            Delegates.Params_DecrementPlayerDataInt @params = new()
            {
                self = self, intName = intName
            };
            if (_beforeDecrementPlayerDataInt != null)
                foreach (Delegates.DecrementPlayerDataInt_BeforeArgs toInvoke in _beforeDecrementPlayerDataInt
                             .GetInvocationList())
                    try
                    {
                        _beforeDecrementPlayerDataInt?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            intName = @params.intName;
            orig(self, intName);
            if (_afterDecrementPlayerDataInt != null)
                foreach (Delegates.DecrementPlayerDataInt_AfterArgs toInvoke in _afterDecrementPlayerDataInt
                             .GetInvocationList())
                    try
                    {
                        _afterDecrementPlayerDataInt.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.GetPlayerDataBool_AfterArgs _afterGetPlayerDataBool;

        private static bool GetPlayerDataBool(On.CaptureAnimationEvent.orig_GetPlayerDataBool orig,
            CaptureAnimationEvent self, string boolName)
        {
            Delegates.Params_GetPlayerDataBool @params = new()
            {
                self = self, boolName = boolName
            };
            if (_beforeGetPlayerDataBool != null)
                foreach (Delegates.GetPlayerDataBool_BeforeArgs toInvoke in
                         _beforeGetPlayerDataBool.GetInvocationList())
                    try
                    {
                        _beforeGetPlayerDataBool?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            boolName = @params.boolName;
            var retVal = orig(self, boolName);
            if (_afterGetPlayerDataBool != null)
                foreach (Delegates.GetPlayerDataBool_AfterArgs toInvoke in _afterGetPlayerDataBool.GetInvocationList())
                    try
                    {
                        retVal = _afterGetPlayerDataBool.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.GetPlayerDataInt_AfterArgs _afterGetPlayerDataInt;

        private static int GetPlayerDataInt(On.CaptureAnimationEvent.orig_GetPlayerDataInt orig,
            CaptureAnimationEvent self, string intName)
        {
            Delegates.Params_GetPlayerDataInt @params = new()
            {
                self = self, intName = intName
            };
            if (_beforeGetPlayerDataInt != null)
                foreach (Delegates.GetPlayerDataInt_BeforeArgs toInvoke in _beforeGetPlayerDataInt.GetInvocationList())
                    try
                    {
                        _beforeGetPlayerDataInt?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            intName = @params.intName;
            var retVal = orig(self, intName);
            if (_afterGetPlayerDataInt != null)
                foreach (Delegates.GetPlayerDataInt_AfterArgs toInvoke in _afterGetPlayerDataInt.GetInvocationList())
                    try
                    {
                        retVal = _afterGetPlayerDataInt.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.GetPlayerDataFloat_AfterArgs _afterGetPlayerDataFloat;

        private static float GetPlayerDataFloat(On.CaptureAnimationEvent.orig_GetPlayerDataFloat orig,
            CaptureAnimationEvent self, string floatName)
        {
            Delegates.Params_GetPlayerDataFloat @params = new()
            {
                self = self, floatName = floatName
            };
            if (_beforeGetPlayerDataFloat != null)
                foreach (Delegates.GetPlayerDataFloat_BeforeArgs toInvoke in
                         _beforeGetPlayerDataFloat.GetInvocationList())
                    try
                    {
                        _beforeGetPlayerDataFloat?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            floatName = @params.floatName;
            var retVal = orig(self, floatName);
            if (_afterGetPlayerDataFloat != null)
                foreach (Delegates.GetPlayerDataFloat_AfterArgs toInvoke in
                         _afterGetPlayerDataFloat.GetInvocationList())
                    try
                    {
                        retVal = _afterGetPlayerDataFloat.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.GetPlayerDataString_AfterArgs _afterGetPlayerDataString;

        private static string GetPlayerDataString(On.CaptureAnimationEvent.orig_GetPlayerDataString orig,
            CaptureAnimationEvent self, string stringName)
        {
            Delegates.Params_GetPlayerDataString @params = new()
            {
                self = self, stringName = stringName
            };
            if (_beforeGetPlayerDataString != null)
                foreach (Delegates.GetPlayerDataString_BeforeArgs toInvoke in _beforeGetPlayerDataString
                             .GetInvocationList())
                    try
                    {
                        _beforeGetPlayerDataString?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            stringName = @params.stringName;
            var retVal = orig(self, stringName);
            if (_afterGetPlayerDataString != null)
                foreach (Delegates.GetPlayerDataString_AfterArgs toInvoke in
                         _afterGetPlayerDataString.GetInvocationList())
                    try
                    {
                        retVal = _afterGetPlayerDataString.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.EquipCharm_AfterArgs _afterEquipCharm;

        private static void EquipCharm(On.CaptureAnimationEvent.orig_EquipCharm orig, CaptureAnimationEvent self,
            int charmNum)
        {
            Delegates.Params_EquipCharm @params = new()
            {
                self = self, charmNum = charmNum
            };
            if (_beforeEquipCharm != null)
                foreach (Delegates.EquipCharm_BeforeArgs toInvoke in _beforeEquipCharm.GetInvocationList())
                    try
                    {
                        _beforeEquipCharm?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            charmNum = @params.charmNum;
            orig(self, charmNum);
            if (_afterEquipCharm != null)
                foreach (Delegates.EquipCharm_AfterArgs toInvoke in _afterEquipCharm.GetInvocationList())
                    try
                    {
                        _afterEquipCharm.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.UnequipCharm_AfterArgs _afterUnequipCharm;

        private static void UnequipCharm(On.CaptureAnimationEvent.orig_UnequipCharm orig, CaptureAnimationEvent self,
            int charmNum)
        {
            Delegates.Params_UnequipCharm @params = new()
            {
                self = self, charmNum = charmNum
            };
            if (_beforeUnequipCharm != null)
                foreach (Delegates.UnequipCharm_BeforeArgs toInvoke in _beforeUnequipCharm.GetInvocationList())
                    try
                    {
                        _beforeUnequipCharm?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            charmNum = @params.charmNum;
            orig(self, charmNum);
            if (_afterUnequipCharm != null)
                foreach (Delegates.UnequipCharm_AfterArgs toInvoke in _afterUnequipCharm.GetInvocationList())
                    try
                    {
                        _afterUnequipCharm.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.UpdateBlueHealth_AfterArgs _afterUpdateBlueHealth;

        private static void UpdateBlueHealth(On.CaptureAnimationEvent.orig_UpdateBlueHealth orig,
            CaptureAnimationEvent self)
        {
            Delegates.Params_UpdateBlueHealth @params = new()
            {
                self = self
            };
            if (_beforeUpdateBlueHealth != null)
                foreach (Delegates.UpdateBlueHealth_BeforeArgs toInvoke in _beforeUpdateBlueHealth.GetInvocationList())
                    try
                    {
                        _beforeUpdateBlueHealth?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateBlueHealth != null)
                foreach (Delegates.UpdateBlueHealth_AfterArgs toInvoke in _afterUpdateBlueHealth.GetInvocationList())
                    try
                    {
                        _afterUpdateBlueHealth.Invoke(@params);
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
        public delegate void DecrementPlayerDataInt_AfterArgs(Params_DecrementPlayerDataInt args);

        public delegate void DecrementPlayerDataInt_BeforeArgs(Params_DecrementPlayerDataInt args);

        public delegate void DecrementPlayerDataInt_WithArgs(Action<CaptureAnimationEvent, string> orig,
            CaptureAnimationEvent self, string intName);

        public delegate void EquipCharm_AfterArgs(Params_EquipCharm args);

        public delegate void EquipCharm_BeforeArgs(Params_EquipCharm args);

        public delegate void EquipCharm_WithArgs(Action<CaptureAnimationEvent, int> orig, CaptureAnimationEvent self,
            int charmNum);

        public delegate bool GetPlayerDataBool_AfterArgs(Params_GetPlayerDataBool args, bool ret);

        public delegate void GetPlayerDataBool_BeforeArgs(Params_GetPlayerDataBool args);

        public delegate bool GetPlayerDataBool_WithArgs(Func<CaptureAnimationEvent, string, bool> orig,
            CaptureAnimationEvent self, string boolName);

        public delegate float GetPlayerDataFloat_AfterArgs(Params_GetPlayerDataFloat args, float ret);

        public delegate void GetPlayerDataFloat_BeforeArgs(Params_GetPlayerDataFloat args);

        public delegate float GetPlayerDataFloat_WithArgs(Func<CaptureAnimationEvent, string, float> orig,
            CaptureAnimationEvent self, string floatName);

        public delegate int GetPlayerDataInt_AfterArgs(Params_GetPlayerDataInt args, int ret);

        public delegate void GetPlayerDataInt_BeforeArgs(Params_GetPlayerDataInt args);

        public delegate int GetPlayerDataInt_WithArgs(Func<CaptureAnimationEvent, string, int> orig,
            CaptureAnimationEvent self, string intName);

        public delegate string GetPlayerDataString_AfterArgs(Params_GetPlayerDataString args, string ret);

        public delegate void GetPlayerDataString_BeforeArgs(Params_GetPlayerDataString args);

        public delegate string GetPlayerDataString_WithArgs(Func<CaptureAnimationEvent, string, string> orig,
            CaptureAnimationEvent self, string stringName);

        public delegate void IncrementPlayerDataInt_AfterArgs(Params_IncrementPlayerDataInt args);

        public delegate void IncrementPlayerDataInt_BeforeArgs(Params_IncrementPlayerDataInt args);

        public delegate void IncrementPlayerDataInt_WithArgs(Action<CaptureAnimationEvent, string> orig,
            CaptureAnimationEvent self, string intName);

        public delegate void SetPlayerDataBoolFalse_AfterArgs(Params_SetPlayerDataBoolFalse args);

        public delegate void SetPlayerDataBoolFalse_BeforeArgs(Params_SetPlayerDataBoolFalse args);

        public delegate void SetPlayerDataBoolFalse_WithArgs(Action<CaptureAnimationEvent, string> orig,
            CaptureAnimationEvent self, string boolName);

        public delegate void SetPlayerDataBoolTrue_AfterArgs(Params_SetPlayerDataBoolTrue args);

        public delegate void SetPlayerDataBoolTrue_BeforeArgs(Params_SetPlayerDataBoolTrue args);

        public delegate void SetPlayerDataBoolTrue_WithArgs(Action<CaptureAnimationEvent, string> orig,
            CaptureAnimationEvent self, string boolName);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<CaptureAnimationEvent> orig, CaptureAnimationEvent self);

        public delegate void UnequipCharm_AfterArgs(Params_UnequipCharm args);

        public delegate void UnequipCharm_BeforeArgs(Params_UnequipCharm args);

        public delegate void UnequipCharm_WithArgs(Action<CaptureAnimationEvent, int> orig, CaptureAnimationEvent self,
            int charmNum);

        public delegate void UpdateBlueHealth_AfterArgs(Params_UpdateBlueHealth args);

        public delegate void UpdateBlueHealth_BeforeArgs(Params_UpdateBlueHealth args);

        public delegate void UpdateBlueHealth_WithArgs(Action<CaptureAnimationEvent> orig, CaptureAnimationEvent self);

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
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.SetPlayerDataBoolTrue_AfterArgs SetPlayerDataBoolTrue
        {
            add
            {
                HookHandler._afterSetPlayerDataBoolTrue += value;
                HookHandler.HookSetPlayerDataBoolTrue();
            }
            remove => HookHandler._afterSetPlayerDataBoolTrue -= value;
        }

        public static event Delegates.SetPlayerDataBoolFalse_AfterArgs SetPlayerDataBoolFalse
        {
            add
            {
                HookHandler._afterSetPlayerDataBoolFalse += value;
                HookHandler.HookSetPlayerDataBoolFalse();
            }
            remove => HookHandler._afterSetPlayerDataBoolFalse -= value;
        }

        public static event Delegates.IncrementPlayerDataInt_AfterArgs IncrementPlayerDataInt
        {
            add
            {
                HookHandler._afterIncrementPlayerDataInt += value;
                HookHandler.HookIncrementPlayerDataInt();
            }
            remove => HookHandler._afterIncrementPlayerDataInt -= value;
        }

        public static event Delegates.DecrementPlayerDataInt_AfterArgs DecrementPlayerDataInt
        {
            add
            {
                HookHandler._afterDecrementPlayerDataInt += value;
                HookHandler.HookDecrementPlayerDataInt();
            }
            remove => HookHandler._afterDecrementPlayerDataInt -= value;
        }

        public static event Delegates.GetPlayerDataBool_AfterArgs GetPlayerDataBool
        {
            add
            {
                HookHandler._afterGetPlayerDataBool += value;
                HookHandler.HookGetPlayerDataBool();
            }
            remove => HookHandler._afterGetPlayerDataBool -= value;
        }

        public static event Delegates.GetPlayerDataInt_AfterArgs GetPlayerDataInt
        {
            add
            {
                HookHandler._afterGetPlayerDataInt += value;
                HookHandler.HookGetPlayerDataInt();
            }
            remove => HookHandler._afterGetPlayerDataInt -= value;
        }

        public static event Delegates.GetPlayerDataFloat_AfterArgs GetPlayerDataFloat
        {
            add
            {
                HookHandler._afterGetPlayerDataFloat += value;
                HookHandler.HookGetPlayerDataFloat();
            }
            remove => HookHandler._afterGetPlayerDataFloat -= value;
        }

        public static event Delegates.GetPlayerDataString_AfterArgs GetPlayerDataString
        {
            add
            {
                HookHandler._afterGetPlayerDataString += value;
                HookHandler.HookGetPlayerDataString();
            }
            remove => HookHandler._afterGetPlayerDataString -= value;
        }

        public static event Delegates.EquipCharm_AfterArgs EquipCharm
        {
            add
            {
                HookHandler._afterEquipCharm += value;
                HookHandler.HookEquipCharm();
            }
            remove => HookHandler._afterEquipCharm -= value;
        }

        public static event Delegates.UnequipCharm_AfterArgs UnequipCharm
        {
            add
            {
                HookHandler._afterUnequipCharm += value;
                HookHandler.HookUnequipCharm();
            }
            remove => HookHandler._afterUnequipCharm -= value;
        }

        public static event Delegates.UpdateBlueHealth_AfterArgs UpdateBlueHealth
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