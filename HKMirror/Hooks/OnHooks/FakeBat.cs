namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for FakeBat class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFakeBat
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.FakeBat.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.FakeBat.orig_Awake orig, FakeBat self)
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

        internal static void HookInit()
        {
            if (!HookedList.Contains("Init"))
            {
                HookedList.Add("Init");
                On.FakeBat.Init += Init;
            }
        }

        internal static event Delegates.Init_BeforeArgs _beforeInit;
        internal static event Delegates.Init_NormalArgs _afterInit;

        private static void Init(On.FakeBat.orig_Init orig)
        {
            _beforeInit?.Invoke();
            orig();
            if (_afterInit != null) _afterInit.Invoke();
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.FakeBat.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.FakeBat.orig_OnEnable orig, FakeBat self)
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
                On.FakeBat.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.FakeBat.orig_OnDisable orig, FakeBat self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.FakeBat.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.FakeBat.orig_Start orig, FakeBat self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.FakeBat.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.FakeBat.orig_Update orig, FakeBat self)
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

        internal static void HookNotifyAllBossAwake()
        {
            if (!HookedList.Contains("NotifyAllBossAwake"))
            {
                HookedList.Add("NotifyAllBossAwake");
                On.FakeBat.NotifyAllBossAwake += NotifyAllBossAwake;
            }
        }

        internal static event Delegates.NotifyAllBossAwake_BeforeArgs _beforeNotifyAllBossAwake;
        internal static event Delegates.NotifyAllBossAwake_NormalArgs _afterNotifyAllBossAwake;

        private static void NotifyAllBossAwake(On.FakeBat.orig_NotifyAllBossAwake orig)
        {
            _beforeNotifyAllBossAwake?.Invoke();
            orig();
            if (_afterNotifyAllBossAwake != null) _afterNotifyAllBossAwake.Invoke();
        }

        internal static void HookNotifyBossAwake()
        {
            if (!HookedList.Contains("NotifyBossAwake"))
            {
                HookedList.Add("NotifyBossAwake");
                On.FakeBat.NotifyBossAwake += NotifyBossAwake;
            }
        }

        internal static event Delegates.NotifyBossAwake_BeforeArgs _beforeNotifyBossAwake;
        internal static event Delegates.NotifyBossAwake_NormalArgs _afterNotifyBossAwake;

        private static void NotifyBossAwake(On.FakeBat.orig_NotifyBossAwake orig, FakeBat self)
        {
            Delegates.Params_NotifyBossAwake @params = new()
            {
                self = self
            };
            _beforeNotifyBossAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterNotifyBossAwake != null) _afterNotifyBossAwake.Invoke(@params);
        }

        internal static void HookSendAllOut()
        {
            if (!HookedList.Contains("SendAllOut"))
            {
                HookedList.Add("SendAllOut");
                On.FakeBat.SendAllOut += SendAllOut;
            }
        }

        internal static event Delegates.SendAllOut_BeforeArgs _beforeSendAllOut;
        internal static event Delegates.SendAllOut_NormalArgs _afterSendAllOut;

        private static void SendAllOut(On.FakeBat.orig_SendAllOut orig)
        {
            _beforeSendAllOut?.Invoke();
            orig();
            if (_afterSendAllOut != null) _afterSendAllOut.Invoke();
        }

        internal static void HookSendOut()
        {
            if (!HookedList.Contains("SendOut"))
            {
                HookedList.Add("SendOut");
                On.FakeBat.SendOut += SendOut;
            }
        }

        internal static event Delegates.SendOut_BeforeArgs _beforeSendOut;
        internal static event Delegates.SendOut_NormalArgs _afterSendOut;

        private static void SendOut(On.FakeBat.orig_SendOut orig, FakeBat self)
        {
            Delegates.Params_SendOut @params = new()
            {
                self = self
            };
            _beforeSendOut?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSendOut != null) _afterSendOut.Invoke(@params);
        }

        internal static void HookSendOutRoutine()
        {
            if (!HookedList.Contains("SendOutRoutine"))
            {
                HookedList.Add("SendOutRoutine");
                On.FakeBat.SendOutRoutine += SendOutRoutine;
            }
        }

        internal static event Delegates.SendOutRoutine_BeforeArgs _beforeSendOutRoutine;

        private static IEnumerator SendOutRoutine(On.FakeBat.orig_SendOutRoutine orig, FakeBat self)
        {
            Delegates.Params_SendOutRoutine @params = new()
            {
                self = self
            };
            _beforeSendOutRoutine?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookBringAllIn()
        {
            if (!HookedList.Contains("BringAllIn"))
            {
                HookedList.Add("BringAllIn");
                On.FakeBat.BringAllIn += BringAllIn;
            }
        }

        internal static event Delegates.BringAllIn_BeforeArgs _beforeBringAllIn;
        internal static event Delegates.BringAllIn_NormalArgs _afterBringAllIn;

        private static void BringAllIn(On.FakeBat.orig_BringAllIn orig)
        {
            _beforeBringAllIn?.Invoke();
            orig();
            if (_afterBringAllIn != null) _afterBringAllIn.Invoke();
        }

        internal static void HookBringIn()
        {
            if (!HookedList.Contains("BringIn"))
            {
                HookedList.Add("BringIn");
                On.FakeBat.BringIn += BringIn;
            }
        }

        internal static event Delegates.BringIn_BeforeArgs _beforeBringIn;
        internal static event Delegates.BringIn_NormalArgs _afterBringIn;

        private static void BringIn(On.FakeBat.orig_BringIn orig, FakeBat self)
        {
            Delegates.Params_BringIn @params = new()
            {
                self = self
            };
            _beforeBringIn?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterBringIn != null) _afterBringIn.Invoke(@params);
        }

        internal static void HookBringInRoutine()
        {
            if (!HookedList.Contains("BringInRoutine"))
            {
                HookedList.Add("BringInRoutine");
                On.FakeBat.BringInRoutine += BringInRoutine;
            }
        }

        internal static event Delegates.BringInRoutine_BeforeArgs _beforeBringInRoutine;

        private static IEnumerator BringInRoutine(On.FakeBat.orig_BringInRoutine orig, FakeBat self)
        {
            Delegates.Params_BringInRoutine @params = new()
            {
                self = self
            };
            _beforeBringInRoutine?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookFaceDirection()
        {
            if (!HookedList.Contains("FaceDirection"))
            {
                HookedList.Add("FaceDirection");
                On.FakeBat.FaceDirection += FaceDirection;
            }
        }

        internal static event Delegates.FaceDirection_BeforeArgs _beforeFaceDirection;
        internal static event Delegates.FaceDirection_NormalArgs _afterFaceDirection;

        private static void FaceDirection(On.FakeBat.orig_FaceDirection orig, FakeBat self, int sign, bool snap)
        {
            Delegates.Params_FaceDirection @params = new()
            {
                self = self, sign = sign, snap = snap
            };
            _beforeFaceDirection?.Invoke(@params);
            self = @params.self;
            sign = @params.sign;
            snap = @params.snap;
            orig(self, sign, snap);
            if (_afterFaceDirection != null) _afterFaceDirection.Invoke(@params);
        }

        internal static void HookAccelerate()
        {
            if (!HookedList.Contains("Accelerate"))
            {
                HookedList.Add("Accelerate");
                On.FakeBat.Accelerate += Accelerate;
            }
        }

        internal static event Delegates.Accelerate_BeforeArgs _beforeAccelerate;
        internal static event Delegates.Accelerate_NormalArgs _afterAccelerate;

        private static void Accelerate(On.FakeBat.orig_Accelerate orig, FakeBat self, Vector2 fixedAcceleration,
            Vector2 speedLimit)
        {
            Delegates.Params_Accelerate @params = new()
            {
                self = self, fixedAcceleration = fixedAcceleration, speedLimit = speedLimit
            };
            _beforeAccelerate?.Invoke(@params);
            self = @params.self;
            fixedAcceleration = @params.fixedAcceleration;
            speedLimit = @params.speedLimit;
            orig(self, fixedAcceleration, speedLimit);
            if (_afterAccelerate != null) _afterAccelerate.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Accelerate_BeforeArgs(Params_Accelerate args);

        public delegate void Accelerate_NormalArgs(Params_Accelerate args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void BringAllIn_BeforeArgs();

        public delegate void BringAllIn_NormalArgs();

        public delegate void BringIn_BeforeArgs(Params_BringIn args);

        public delegate void BringIn_NormalArgs(Params_BringIn args);

        public delegate void BringInRoutine_BeforeArgs(Params_BringInRoutine args);

        public delegate IEnumerator BringInRoutine_NormalArgs(Params_BringInRoutine args);

        public delegate void FaceDirection_BeforeArgs(Params_FaceDirection args);

        public delegate void FaceDirection_NormalArgs(Params_FaceDirection args);

        public delegate void Init_BeforeArgs();

        public delegate void Init_NormalArgs();

        public delegate void NotifyAllBossAwake_BeforeArgs();

        public delegate void NotifyAllBossAwake_NormalArgs();

        public delegate void NotifyBossAwake_BeforeArgs(Params_NotifyBossAwake args);

        public delegate void NotifyBossAwake_NormalArgs(Params_NotifyBossAwake args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void SendAllOut_BeforeArgs();

        public delegate void SendAllOut_NormalArgs();

        public delegate void SendOut_BeforeArgs(Params_SendOut args);

        public delegate void SendOut_NormalArgs(Params_SendOut args);

        public delegate void SendOutRoutine_BeforeArgs(Params_SendOutRoutine args);

        public delegate IEnumerator SendOutRoutine_NormalArgs(Params_SendOutRoutine args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public FakeBat self;
        }

        public sealed class Params_OnEnable
        {
            public FakeBat self;
        }

        public sealed class Params_OnDisable
        {
            public FakeBat self;
        }

        public sealed class Params_Start
        {
            public FakeBat self;
        }

        public sealed class Params_Update
        {
            public FakeBat self;
        }

        public sealed class Params_NotifyBossAwake
        {
            public FakeBat self;
        }

        public sealed class Params_SendOut
        {
            public FakeBat self;
        }

        public sealed class Params_SendOutRoutine
        {
            public FakeBat self;
        }

        public sealed class Params_BringIn
        {
            public FakeBat self;
        }

        public sealed class Params_BringInRoutine
        {
            public FakeBat self;
        }

        public sealed class Params_FaceDirection
        {
            public FakeBat self;
            public int sign;
            public bool snap;
        }

        public sealed class Params_Accelerate
        {
            public Vector2 fixedAcceleration;
            public FakeBat self;
            public Vector2 speedLimit;
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

        public static event Delegates.Init_BeforeArgs Init
        {
            add
            {
                HookHandler._beforeInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._beforeInit -= value;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.NotifyAllBossAwake_BeforeArgs NotifyAllBossAwake
        {
            add
            {
                HookHandler._beforeNotifyAllBossAwake += value;
                HookHandler.HookNotifyAllBossAwake();
            }
            remove => HookHandler._beforeNotifyAllBossAwake -= value;
        }

        public static event Delegates.NotifyBossAwake_BeforeArgs NotifyBossAwake
        {
            add
            {
                HookHandler._beforeNotifyBossAwake += value;
                HookHandler.HookNotifyBossAwake();
            }
            remove => HookHandler._beforeNotifyBossAwake -= value;
        }

        public static event Delegates.SendAllOut_BeforeArgs SendAllOut
        {
            add
            {
                HookHandler._beforeSendAllOut += value;
                HookHandler.HookSendAllOut();
            }
            remove => HookHandler._beforeSendAllOut -= value;
        }

        public static event Delegates.SendOut_BeforeArgs SendOut
        {
            add
            {
                HookHandler._beforeSendOut += value;
                HookHandler.HookSendOut();
            }
            remove => HookHandler._beforeSendOut -= value;
        }

        public static event Delegates.SendOutRoutine_BeforeArgs SendOutRoutine
        {
            add
            {
                HookHandler._beforeSendOutRoutine += value;
                HookHandler.HookSendOutRoutine();
            }
            remove => HookHandler._beforeSendOutRoutine -= value;
        }

        public static event Delegates.BringAllIn_BeforeArgs BringAllIn
        {
            add
            {
                HookHandler._beforeBringAllIn += value;
                HookHandler.HookBringAllIn();
            }
            remove => HookHandler._beforeBringAllIn -= value;
        }

        public static event Delegates.BringIn_BeforeArgs BringIn
        {
            add
            {
                HookHandler._beforeBringIn += value;
                HookHandler.HookBringIn();
            }
            remove => HookHandler._beforeBringIn -= value;
        }

        public static event Delegates.BringInRoutine_BeforeArgs BringInRoutine
        {
            add
            {
                HookHandler._beforeBringInRoutine += value;
                HookHandler.HookBringInRoutine();
            }
            remove => HookHandler._beforeBringInRoutine -= value;
        }

        public static event Delegates.FaceDirection_BeforeArgs FaceDirection
        {
            add
            {
                HookHandler._beforeFaceDirection += value;
                HookHandler.HookFaceDirection();
            }
            remove => HookHandler._beforeFaceDirection -= value;
        }

        public static event Delegates.Accelerate_BeforeArgs Accelerate
        {
            add
            {
                HookHandler._beforeAccelerate += value;
                HookHandler.HookAccelerate();
            }
            remove => HookHandler._beforeAccelerate -= value;
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

        public static event Delegates.Init_NormalArgs Init
        {
            add
            {
                HookHandler._afterInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._afterInit -= value;
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

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.NotifyAllBossAwake_NormalArgs NotifyAllBossAwake
        {
            add
            {
                HookHandler._afterNotifyAllBossAwake += value;
                HookHandler.HookNotifyAllBossAwake();
            }
            remove => HookHandler._afterNotifyAllBossAwake -= value;
        }

        public static event Delegates.NotifyBossAwake_NormalArgs NotifyBossAwake
        {
            add
            {
                HookHandler._afterNotifyBossAwake += value;
                HookHandler.HookNotifyBossAwake();
            }
            remove => HookHandler._afterNotifyBossAwake -= value;
        }

        public static event Delegates.SendAllOut_NormalArgs SendAllOut
        {
            add
            {
                HookHandler._afterSendAllOut += value;
                HookHandler.HookSendAllOut();
            }
            remove => HookHandler._afterSendAllOut -= value;
        }

        public static event Delegates.SendOut_NormalArgs SendOut
        {
            add
            {
                HookHandler._afterSendOut += value;
                HookHandler.HookSendOut();
            }
            remove => HookHandler._afterSendOut -= value;
        }

        public static event Delegates.BringAllIn_NormalArgs BringAllIn
        {
            add
            {
                HookHandler._afterBringAllIn += value;
                HookHandler.HookBringAllIn();
            }
            remove => HookHandler._afterBringAllIn -= value;
        }

        public static event Delegates.BringIn_NormalArgs BringIn
        {
            add
            {
                HookHandler._afterBringIn += value;
                HookHandler.HookBringIn();
            }
            remove => HookHandler._afterBringIn -= value;
        }

        public static event Delegates.FaceDirection_NormalArgs FaceDirection
        {
            add
            {
                HookHandler._afterFaceDirection += value;
                HookHandler.HookFaceDirection();
            }
            remove => HookHandler._afterFaceDirection -= value;
        }

        public static event Delegates.Accelerate_NormalArgs Accelerate
        {
            add
            {
                HookHandler._afterAccelerate += value;
                HookHandler.HookAccelerate();
            }
            remove => HookHandler._afterAccelerate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.FakeBat.hook_Awake Awake
        {
            add => On.FakeBat.Awake += value;
            remove => On.FakeBat.Awake -= value;
        }

        public static event On.FakeBat.hook_Init Init
        {
            add => On.FakeBat.Init += value;
            remove => On.FakeBat.Init -= value;
        }

        public static event On.FakeBat.hook_OnEnable OnEnable
        {
            add => On.FakeBat.OnEnable += value;
            remove => On.FakeBat.OnEnable -= value;
        }

        public static event On.FakeBat.hook_OnDisable OnDisable
        {
            add => On.FakeBat.OnDisable += value;
            remove => On.FakeBat.OnDisable -= value;
        }

        public static event On.FakeBat.hook_Start Start
        {
            add => On.FakeBat.Start += value;
            remove => On.FakeBat.Start -= value;
        }

        public static event On.FakeBat.hook_Update Update
        {
            add => On.FakeBat.Update += value;
            remove => On.FakeBat.Update -= value;
        }

        public static event On.FakeBat.hook_NotifyAllBossAwake NotifyAllBossAwake
        {
            add => On.FakeBat.NotifyAllBossAwake += value;
            remove => On.FakeBat.NotifyAllBossAwake -= value;
        }

        public static event On.FakeBat.hook_NotifyBossAwake NotifyBossAwake
        {
            add => On.FakeBat.NotifyBossAwake += value;
            remove => On.FakeBat.NotifyBossAwake -= value;
        }

        public static event On.FakeBat.hook_SendAllOut SendAllOut
        {
            add => On.FakeBat.SendAllOut += value;
            remove => On.FakeBat.SendAllOut -= value;
        }

        public static event On.FakeBat.hook_SendOut SendOut
        {
            add => On.FakeBat.SendOut += value;
            remove => On.FakeBat.SendOut -= value;
        }

        public static event On.FakeBat.hook_SendOutRoutine SendOutRoutine
        {
            add => On.FakeBat.SendOutRoutine += value;
            remove => On.FakeBat.SendOutRoutine -= value;
        }

        public static event On.FakeBat.hook_BringAllIn BringAllIn
        {
            add => On.FakeBat.BringAllIn += value;
            remove => On.FakeBat.BringAllIn -= value;
        }

        public static event On.FakeBat.hook_BringIn BringIn
        {
            add => On.FakeBat.BringIn += value;
            remove => On.FakeBat.BringIn -= value;
        }

        public static event On.FakeBat.hook_BringInRoutine BringInRoutine
        {
            add => On.FakeBat.BringInRoutine += value;
            remove => On.FakeBat.BringInRoutine -= value;
        }

        public static event On.FakeBat.hook_FaceDirection FaceDirection
        {
            add => On.FakeBat.FaceDirection += value;
            remove => On.FakeBat.FaceDirection -= value;
        }

        public static event On.FakeBat.hook_Accelerate Accelerate
        {
            add => On.FakeBat.Accelerate += value;
            remove => On.FakeBat.Accelerate -= value;
        }
    }
}