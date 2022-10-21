using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for CameraControlAnimationEvents class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCameraControlAnimationEvents
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookBigShake()
        {
            if (!HookedList.Contains("BigShake"))
            {
                HookedList.Add("BigShake");
                On.CameraControlAnimationEvents.BigShake += BigShake;
            }
        }

        internal static event Delegates.BigShake_BeforeArgs _beforeBigShake;
        internal static event Delegates.BigShake_AfterArgs _afterBigShake;

        private static void BigShake(On.CameraControlAnimationEvents.orig_BigShake orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_BigShake @params = new()
            {
                self = self
            };
            if (_beforeBigShake != null)
            {
                foreach (Delegates.BigShake_BeforeArgs toInvoke in _beforeBigShake.GetInvocationList())
                {
                    try
                    {
                        _beforeBigShake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterBigShake != null)
            {
                foreach (Delegates.BigShake_AfterArgs toInvoke in _afterBigShake.GetInvocationList())
                {
                    try
                    {
                        _afterBigShake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSmallShake()
        {
            if (!HookedList.Contains("SmallShake"))
            {
                HookedList.Add("SmallShake");
                On.CameraControlAnimationEvents.SmallShake += SmallShake;
            }
        }

        internal static event Delegates.SmallShake_BeforeArgs _beforeSmallShake;
        internal static event Delegates.SmallShake_AfterArgs _afterSmallShake;

        private static void SmallShake(On.CameraControlAnimationEvents.orig_SmallShake orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_SmallShake @params = new()
            {
                self = self
            };
            if (_beforeSmallShake != null)
            {
                foreach (Delegates.SmallShake_BeforeArgs toInvoke in _beforeSmallShake.GetInvocationList())
                {
                    try
                    {
                        _beforeSmallShake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterSmallShake != null)
            {
                foreach (Delegates.SmallShake_AfterArgs toInvoke in _afterSmallShake.GetInvocationList())
                {
                    try
                    {
                        _afterSmallShake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAverageShake()
        {
            if (!HookedList.Contains("AverageShake"))
            {
                HookedList.Add("AverageShake");
                On.CameraControlAnimationEvents.AverageShake += AverageShake;
            }
        }

        internal static event Delegates.AverageShake_BeforeArgs _beforeAverageShake;
        internal static event Delegates.AverageShake_AfterArgs _afterAverageShake;

        private static void AverageShake(On.CameraControlAnimationEvents.orig_AverageShake orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_AverageShake @params = new()
            {
                self = self
            };
            if (_beforeAverageShake != null)
            {
                foreach (Delegates.AverageShake_BeforeArgs toInvoke in _beforeAverageShake.GetInvocationList())
                {
                    try
                    {
                        _beforeAverageShake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAverageShake != null)
            {
                foreach (Delegates.AverageShake_AfterArgs toInvoke in _afterAverageShake.GetInvocationList())
                {
                    try
                    {
                        _afterAverageShake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookEnemyKillShake()
        {
            if (!HookedList.Contains("EnemyKillShake"))
            {
                HookedList.Add("EnemyKillShake");
                On.CameraControlAnimationEvents.EnemyKillShake += EnemyKillShake;
            }
        }

        internal static event Delegates.EnemyKillShake_BeforeArgs _beforeEnemyKillShake;
        internal static event Delegates.EnemyKillShake_AfterArgs _afterEnemyKillShake;

        private static void EnemyKillShake(On.CameraControlAnimationEvents.orig_EnemyKillShake orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_EnemyKillShake @params = new()
            {
                self = self
            };
            if (_beforeEnemyKillShake != null)
            {
                foreach (Delegates.EnemyKillShake_BeforeArgs toInvoke in _beforeEnemyKillShake.GetInvocationList())
                {
                    try
                    {
                        _beforeEnemyKillShake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterEnemyKillShake != null)
            {
                foreach (Delegates.EnemyKillShake_AfterArgs toInvoke in _afterEnemyKillShake.GetInvocationList())
                {
                    try
                    {
                        _afterEnemyKillShake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSmallRumble()
        {
            if (!HookedList.Contains("SmallRumble"))
            {
                HookedList.Add("SmallRumble");
                On.CameraControlAnimationEvents.SmallRumble += SmallRumble;
            }
        }

        internal static event Delegates.SmallRumble_BeforeArgs _beforeSmallRumble;
        internal static event Delegates.SmallRumble_AfterArgs _afterSmallRumble;

        private static void SmallRumble(On.CameraControlAnimationEvents.orig_SmallRumble orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_SmallRumble @params = new()
            {
                self = self
            };
            if (_beforeSmallRumble != null)
            {
                foreach (Delegates.SmallRumble_BeforeArgs toInvoke in _beforeSmallRumble.GetInvocationList())
                {
                    try
                    {
                        _beforeSmallRumble?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterSmallRumble != null)
            {
                foreach (Delegates.SmallRumble_AfterArgs toInvoke in _afterSmallRumble.GetInvocationList())
                {
                    try
                    {
                        _afterSmallRumble.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookMedRumble()
        {
            if (!HookedList.Contains("MedRumble"))
            {
                HookedList.Add("MedRumble");
                On.CameraControlAnimationEvents.MedRumble += MedRumble;
            }
        }

        internal static event Delegates.MedRumble_BeforeArgs _beforeMedRumble;
        internal static event Delegates.MedRumble_AfterArgs _afterMedRumble;

        private static void MedRumble(On.CameraControlAnimationEvents.orig_MedRumble orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_MedRumble @params = new()
            {
                self = self
            };
            if (_beforeMedRumble != null)
            {
                foreach (Delegates.MedRumble_BeforeArgs toInvoke in _beforeMedRumble.GetInvocationList())
                {
                    try
                    {
                        _beforeMedRumble?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterMedRumble != null)
            {
                foreach (Delegates.MedRumble_AfterArgs toInvoke in _afterMedRumble.GetInvocationList())
                {
                    try
                    {
                        _afterMedRumble.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBigRumble()
        {
            if (!HookedList.Contains("BigRumble"))
            {
                HookedList.Add("BigRumble");
                On.CameraControlAnimationEvents.BigRumble += BigRumble;
            }
        }

        internal static event Delegates.BigRumble_BeforeArgs _beforeBigRumble;
        internal static event Delegates.BigRumble_AfterArgs _afterBigRumble;

        private static void BigRumble(On.CameraControlAnimationEvents.orig_BigRumble orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_BigRumble @params = new()
            {
                self = self
            };
            if (_beforeBigRumble != null)
            {
                foreach (Delegates.BigRumble_BeforeArgs toInvoke in _beforeBigRumble.GetInvocationList())
                {
                    try
                    {
                        _beforeBigRumble?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterBigRumble != null)
            {
                foreach (Delegates.BigRumble_AfterArgs toInvoke in _afterBigRumble.GetInvocationList())
                {
                    try
                    {
                        _afterBigRumble.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookStopRumble()
        {
            if (!HookedList.Contains("StopRumble"))
            {
                HookedList.Add("StopRumble");
                On.CameraControlAnimationEvents.StopRumble += StopRumble;
            }
        }

        internal static event Delegates.StopRumble_BeforeArgs _beforeStopRumble;
        internal static event Delegates.StopRumble_AfterArgs _afterStopRumble;

        private static void StopRumble(On.CameraControlAnimationEvents.orig_StopRumble orig,
            CameraControlAnimationEvents self)
        {
            Delegates.Params_StopRumble @params = new()
            {
                self = self
            };
            if (_beforeStopRumble != null)
            {
                foreach (Delegates.StopRumble_BeforeArgs toInvoke in _beforeStopRumble.GetInvocationList())
                {
                    try
                    {
                        _beforeStopRumble?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStopRumble != null)
            {
                foreach (Delegates.StopRumble_AfterArgs toInvoke in _afterStopRumble.GetInvocationList())
                {
                    try
                    {
                        _afterStopRumble.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSendCameraEvent()
        {
            if (!HookedList.Contains("SendCameraEvent"))
            {
                HookedList.Add("SendCameraEvent");
                On.CameraControlAnimationEvents.SendCameraEvent += SendCameraEvent;
            }
        }

        internal static event Delegates.SendCameraEvent_BeforeArgs _beforeSendCameraEvent;
        internal static event Delegates.SendCameraEvent_AfterArgs _afterSendCameraEvent;

        private static void SendCameraEvent(On.CameraControlAnimationEvents.orig_SendCameraEvent orig,
            CameraControlAnimationEvents self, string eventName)
        {
            Delegates.Params_SendCameraEvent @params = new()
            {
                self = self, eventName = eventName
            };
            if (_beforeSendCameraEvent != null)
            {
                foreach (Delegates.SendCameraEvent_BeforeArgs toInvoke in _beforeSendCameraEvent.GetInvocationList())
                {
                    try
                    {
                        _beforeSendCameraEvent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            eventName = @params.eventName;
            orig(self, eventName);
            if (_afterSendCameraEvent != null)
            {
                foreach (Delegates.SendCameraEvent_AfterArgs toInvoke in _afterSendCameraEvent.GetInvocationList())
                {
                    try
                    {
                        _afterSendCameraEvent.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSetCameraBool()
        {
            if (!HookedList.Contains("SetCameraBool"))
            {
                HookedList.Add("SetCameraBool");
                On.CameraControlAnimationEvents.SetCameraBool += SetCameraBool;
            }
        }

        internal static event Delegates.SetCameraBool_BeforeArgs _beforeSetCameraBool;
        internal static event Delegates.SetCameraBool_AfterArgs _afterSetCameraBool;

        private static void SetCameraBool(On.CameraControlAnimationEvents.orig_SetCameraBool orig,
            CameraControlAnimationEvents self, string boolName, bool value)
        {
            Delegates.Params_SetCameraBool @params = new()
            {
                self = self, boolName = boolName, value = value
            };
            if (_beforeSetCameraBool != null)
            {
                foreach (Delegates.SetCameraBool_BeforeArgs toInvoke in _beforeSetCameraBool.GetInvocationList())
                {
                    try
                    {
                        _beforeSetCameraBool?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            boolName = @params.boolName;
            value = @params.value;
            orig(self, boolName, value);
            if (_afterSetCameraBool != null)
            {
                foreach (Delegates.SetCameraBool_AfterArgs toInvoke in _afterSetCameraBool.GetInvocationList())
                {
                    try
                    {
                        _afterSetCameraBool.Invoke(@params);
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
        public sealed class Params_BigShake
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void BigShake_BeforeArgs(Params_BigShake args);

        public delegate void BigShake_AfterArgs(Params_BigShake args);

        public delegate void BigShake_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_SmallShake
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void SmallShake_BeforeArgs(Params_SmallShake args);

        public delegate void SmallShake_AfterArgs(Params_SmallShake args);

        public delegate void SmallShake_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_AverageShake
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void AverageShake_BeforeArgs(Params_AverageShake args);

        public delegate void AverageShake_AfterArgs(Params_AverageShake args);

        public delegate void AverageShake_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_EnemyKillShake
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void EnemyKillShake_BeforeArgs(Params_EnemyKillShake args);

        public delegate void EnemyKillShake_AfterArgs(Params_EnemyKillShake args);

        public delegate void EnemyKillShake_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_SmallRumble
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void SmallRumble_BeforeArgs(Params_SmallRumble args);

        public delegate void SmallRumble_AfterArgs(Params_SmallRumble args);

        public delegate void SmallRumble_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_MedRumble
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void MedRumble_BeforeArgs(Params_MedRumble args);

        public delegate void MedRumble_AfterArgs(Params_MedRumble args);

        public delegate void MedRumble_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_BigRumble
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void BigRumble_BeforeArgs(Params_BigRumble args);

        public delegate void BigRumble_AfterArgs(Params_BigRumble args);

        public delegate void BigRumble_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_StopRumble
        {
            public CameraControlAnimationEvents self;
        }

        public delegate void StopRumble_BeforeArgs(Params_StopRumble args);

        public delegate void StopRumble_AfterArgs(Params_StopRumble args);

        public delegate void StopRumble_WithArgs(Action<CameraControlAnimationEvents> orig,
            CameraControlAnimationEvents self);

        public sealed class Params_SendCameraEvent
        {
            public CameraControlAnimationEvents self;
            public string eventName;
        }

        public delegate void SendCameraEvent_BeforeArgs(Params_SendCameraEvent args);

        public delegate void SendCameraEvent_AfterArgs(Params_SendCameraEvent args);

        public delegate void SendCameraEvent_WithArgs(Action<CameraControlAnimationEvents, string> orig,
            CameraControlAnimationEvents self, string eventName);

        public sealed class Params_SetCameraBool
        {
            public CameraControlAnimationEvents self;
            public string boolName;
            public bool value;
        }

        public delegate void SetCameraBool_BeforeArgs(Params_SetCameraBool args);

        public delegate void SetCameraBool_AfterArgs(Params_SetCameraBool args);

        public delegate void SetCameraBool_WithArgs(Action<CameraControlAnimationEvents, string, bool> orig,
            CameraControlAnimationEvents self, string boolName, bool value);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.BigShake_BeforeArgs BigShake
        {
            add
            {
                HookHandler._beforeBigShake += value;
                HookHandler.HookBigShake();
            }
            remove => HookHandler._beforeBigShake -= value;
        }

        public static event Delegates.SmallShake_BeforeArgs SmallShake
        {
            add
            {
                HookHandler._beforeSmallShake += value;
                HookHandler.HookSmallShake();
            }
            remove => HookHandler._beforeSmallShake -= value;
        }

        public static event Delegates.AverageShake_BeforeArgs AverageShake
        {
            add
            {
                HookHandler._beforeAverageShake += value;
                HookHandler.HookAverageShake();
            }
            remove => HookHandler._beforeAverageShake -= value;
        }

        public static event Delegates.EnemyKillShake_BeforeArgs EnemyKillShake
        {
            add
            {
                HookHandler._beforeEnemyKillShake += value;
                HookHandler.HookEnemyKillShake();
            }
            remove => HookHandler._beforeEnemyKillShake -= value;
        }

        public static event Delegates.SmallRumble_BeforeArgs SmallRumble
        {
            add
            {
                HookHandler._beforeSmallRumble += value;
                HookHandler.HookSmallRumble();
            }
            remove => HookHandler._beforeSmallRumble -= value;
        }

        public static event Delegates.MedRumble_BeforeArgs MedRumble
        {
            add
            {
                HookHandler._beforeMedRumble += value;
                HookHandler.HookMedRumble();
            }
            remove => HookHandler._beforeMedRumble -= value;
        }

        public static event Delegates.BigRumble_BeforeArgs BigRumble
        {
            add
            {
                HookHandler._beforeBigRumble += value;
                HookHandler.HookBigRumble();
            }
            remove => HookHandler._beforeBigRumble -= value;
        }

        public static event Delegates.StopRumble_BeforeArgs StopRumble
        {
            add
            {
                HookHandler._beforeStopRumble += value;
                HookHandler.HookStopRumble();
            }
            remove => HookHandler._beforeStopRumble -= value;
        }

        public static event Delegates.SendCameraEvent_BeforeArgs SendCameraEvent
        {
            add
            {
                HookHandler._beforeSendCameraEvent += value;
                HookHandler.HookSendCameraEvent();
            }
            remove => HookHandler._beforeSendCameraEvent -= value;
        }

        public static event Delegates.SetCameraBool_BeforeArgs SetCameraBool
        {
            add
            {
                HookHandler._beforeSetCameraBool += value;
                HookHandler.HookSetCameraBool();
            }
            remove => HookHandler._beforeSetCameraBool -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.BigShake_AfterArgs BigShake
        {
            add
            {
                HookHandler._afterBigShake += value;
                HookHandler.HookBigShake();
            }
            remove => HookHandler._afterBigShake -= value;
        }

        public static event Delegates.SmallShake_AfterArgs SmallShake
        {
            add
            {
                HookHandler._afterSmallShake += value;
                HookHandler.HookSmallShake();
            }
            remove => HookHandler._afterSmallShake -= value;
        }

        public static event Delegates.AverageShake_AfterArgs AverageShake
        {
            add
            {
                HookHandler._afterAverageShake += value;
                HookHandler.HookAverageShake();
            }
            remove => HookHandler._afterAverageShake -= value;
        }

        public static event Delegates.EnemyKillShake_AfterArgs EnemyKillShake
        {
            add
            {
                HookHandler._afterEnemyKillShake += value;
                HookHandler.HookEnemyKillShake();
            }
            remove => HookHandler._afterEnemyKillShake -= value;
        }

        public static event Delegates.SmallRumble_AfterArgs SmallRumble
        {
            add
            {
                HookHandler._afterSmallRumble += value;
                HookHandler.HookSmallRumble();
            }
            remove => HookHandler._afterSmallRumble -= value;
        }

        public static event Delegates.MedRumble_AfterArgs MedRumble
        {
            add
            {
                HookHandler._afterMedRumble += value;
                HookHandler.HookMedRumble();
            }
            remove => HookHandler._afterMedRumble -= value;
        }

        public static event Delegates.BigRumble_AfterArgs BigRumble
        {
            add
            {
                HookHandler._afterBigRumble += value;
                HookHandler.HookBigRumble();
            }
            remove => HookHandler._afterBigRumble -= value;
        }

        public static event Delegates.StopRumble_AfterArgs StopRumble
        {
            add
            {
                HookHandler._afterStopRumble += value;
                HookHandler.HookStopRumble();
            }
            remove => HookHandler._afterStopRumble -= value;
        }

        public static event Delegates.SendCameraEvent_AfterArgs SendCameraEvent
        {
            add
            {
                HookHandler._afterSendCameraEvent += value;
                HookHandler.HookSendCameraEvent();
            }
            remove => HookHandler._afterSendCameraEvent -= value;
        }

        public static event Delegates.SetCameraBool_AfterArgs SetCameraBool
        {
            add
            {
                HookHandler._afterSetCameraBool += value;
                HookHandler.HookSetCameraBool();
            }
            remove => HookHandler._afterSetCameraBool -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CameraControlAnimationEvents.hook_BigShake BigShake
        {
            add => On.CameraControlAnimationEvents.BigShake += value;
            remove => On.CameraControlAnimationEvents.BigShake -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_SmallShake SmallShake
        {
            add => On.CameraControlAnimationEvents.SmallShake += value;
            remove => On.CameraControlAnimationEvents.SmallShake -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_AverageShake AverageShake
        {
            add => On.CameraControlAnimationEvents.AverageShake += value;
            remove => On.CameraControlAnimationEvents.AverageShake -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_EnemyKillShake EnemyKillShake
        {
            add => On.CameraControlAnimationEvents.EnemyKillShake += value;
            remove => On.CameraControlAnimationEvents.EnemyKillShake -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_SmallRumble SmallRumble
        {
            add => On.CameraControlAnimationEvents.SmallRumble += value;
            remove => On.CameraControlAnimationEvents.SmallRumble -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_MedRumble MedRumble
        {
            add => On.CameraControlAnimationEvents.MedRumble += value;
            remove => On.CameraControlAnimationEvents.MedRumble -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_BigRumble BigRumble
        {
            add => On.CameraControlAnimationEvents.BigRumble += value;
            remove => On.CameraControlAnimationEvents.BigRumble -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_StopRumble StopRumble
        {
            add => On.CameraControlAnimationEvents.StopRumble += value;
            remove => On.CameraControlAnimationEvents.StopRumble -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_SendCameraEvent SendCameraEvent
        {
            add => On.CameraControlAnimationEvents.SendCameraEvent += value;
            remove => On.CameraControlAnimationEvents.SendCameraEvent -= value;
        }

        public static event On.CameraControlAnimationEvents.hook_SetCameraBool SetCameraBool
        {
            add => On.CameraControlAnimationEvents.SetCameraBool += value;
            remove => On.CameraControlAnimationEvents.SetCameraBool -= value;
        }
    }
}