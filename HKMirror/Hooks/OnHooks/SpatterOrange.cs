namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpatterOrange class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpatterOrange
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.SpatterOrange.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.SpatterOrange.orig_Start orig, SpatterOrange self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.SpatterOrange.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.SpatterOrange.orig_OnEnable orig, SpatterOrange self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.SpatterOrange.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.SpatterOrange.orig_Update orig, SpatterOrange self)
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

        internal static void HookImpact()
        {
            if (!HookedList.Contains("Impact"))
            {
                HookedList.Add("Impact");
                On.SpatterOrange.Impact += Impact;
            }
        }

        internal static event Delegates.Impact_BeforeArgs _beforeImpact;
        internal static event Delegates.Impact_NormalArgs _afterImpact;

        private static void Impact(On.SpatterOrange.orig_Impact orig, SpatterOrange self)
        {
            Delegates.Params_Impact @params = new()
            {
                self = self
            };
            _beforeImpact?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterImpact != null) _afterImpact.Invoke(@params);
        }

        internal static void HookFaceAngle()
        {
            if (!HookedList.Contains("FaceAngle"))
            {
                HookedList.Add("FaceAngle");
                On.SpatterOrange.FaceAngle += FaceAngle;
            }
        }

        internal static event Delegates.FaceAngle_BeforeArgs _beforeFaceAngle;
        internal static event Delegates.FaceAngle_NormalArgs _afterFaceAngle;

        private static void FaceAngle(On.SpatterOrange.orig_FaceAngle orig, SpatterOrange self)
        {
            Delegates.Params_FaceAngle @params = new()
            {
                self = self
            };
            _beforeFaceAngle?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFaceAngle != null) _afterFaceAngle.Invoke(@params);
        }

        internal static void HookProjectileSquash()
        {
            if (!HookedList.Contains("ProjectileSquash"))
            {
                HookedList.Add("ProjectileSquash");
                On.SpatterOrange.ProjectileSquash += ProjectileSquash;
            }
        }

        internal static event Delegates.ProjectileSquash_BeforeArgs _beforeProjectileSquash;
        internal static event Delegates.ProjectileSquash_NormalArgs _afterProjectileSquash;

        private static void ProjectileSquash(On.SpatterOrange.orig_ProjectileSquash orig, SpatterOrange self)
        {
            Delegates.Params_ProjectileSquash @params = new()
            {
                self = self
            };
            _beforeProjectileSquash?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterProjectileSquash != null) _afterProjectileSquash.Invoke(@params);
        }

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.SpatterOrange.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_NormalArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.SpatterOrange.orig_OnCollisionEnter2D orig, SpatterOrange self,
            Collision2D collision)
        {
            Delegates.Params_OnCollisionEnter2D @params = new()
            {
                self = self, collision = collision
            };
            _beforeOnCollisionEnter2D?.Invoke(@params);
            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnCollisionEnter2D != null) _afterOnCollisionEnter2D.Invoke(@params);
        }

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.SpatterOrange.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.SpatterOrange.orig_OnTriggerEnter2D orig, SpatterOrange self)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self
            };
            _beforeOnTriggerEnter2D?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnTriggerEnter2D != null) _afterOnTriggerEnter2D.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void FaceAngle_BeforeArgs(Params_FaceAngle args);

        public delegate void FaceAngle_NormalArgs(Params_FaceAngle args);

        public delegate void Impact_BeforeArgs(Params_Impact args);

        public delegate void Impact_NormalArgs(Params_Impact args);

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_NormalArgs(Params_OnCollisionEnter2D args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void ProjectileSquash_BeforeArgs(Params_ProjectileSquash args);

        public delegate void ProjectileSquash_NormalArgs(Params_ProjectileSquash args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Start
        {
            public SpatterOrange self;
        }

        public sealed class Params_OnEnable
        {
            public SpatterOrange self;
        }

        public sealed class Params_Update
        {
            public SpatterOrange self;
        }

        public sealed class Params_Impact
        {
            public SpatterOrange self;
        }

        public sealed class Params_FaceAngle
        {
            public SpatterOrange self;
        }

        public sealed class Params_ProjectileSquash
        {
            public SpatterOrange self;
        }

        public sealed class Params_OnCollisionEnter2D
        {
            public Collision2D collision;
            public SpatterOrange self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public SpatterOrange self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
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

        public static event Delegates.Impact_BeforeArgs Impact
        {
            add
            {
                HookHandler._beforeImpact += value;
                HookHandler.HookImpact();
            }
            remove => HookHandler._beforeImpact -= value;
        }

        public static event Delegates.FaceAngle_BeforeArgs FaceAngle
        {
            add
            {
                HookHandler._beforeFaceAngle += value;
                HookHandler.HookFaceAngle();
            }
            remove => HookHandler._beforeFaceAngle -= value;
        }

        public static event Delegates.ProjectileSquash_BeforeArgs ProjectileSquash
        {
            add
            {
                HookHandler._beforeProjectileSquash += value;
                HookHandler.HookProjectileSquash();
            }
            remove => HookHandler._beforeProjectileSquash -= value;
        }

        public static event Delegates.OnCollisionEnter2D_BeforeArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._beforeOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._beforeOnCollisionEnter2D -= value;
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

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
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

        public static event Delegates.Impact_NormalArgs Impact
        {
            add
            {
                HookHandler._afterImpact += value;
                HookHandler.HookImpact();
            }
            remove => HookHandler._afterImpact -= value;
        }

        public static event Delegates.FaceAngle_NormalArgs FaceAngle
        {
            add
            {
                HookHandler._afterFaceAngle += value;
                HookHandler.HookFaceAngle();
            }
            remove => HookHandler._afterFaceAngle -= value;
        }

        public static event Delegates.ProjectileSquash_NormalArgs ProjectileSquash
        {
            add
            {
                HookHandler._afterProjectileSquash += value;
                HookHandler.HookProjectileSquash();
            }
            remove => HookHandler._afterProjectileSquash -= value;
        }

        public static event Delegates.OnCollisionEnter2D_NormalArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._afterOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._afterOnCollisionEnter2D -= value;
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpatterOrange.hook_Start Start
        {
            add => On.SpatterOrange.Start += value;
            remove => On.SpatterOrange.Start -= value;
        }

        public static event On.SpatterOrange.hook_OnEnable OnEnable
        {
            add => On.SpatterOrange.OnEnable += value;
            remove => On.SpatterOrange.OnEnable -= value;
        }

        public static event On.SpatterOrange.hook_Update Update
        {
            add => On.SpatterOrange.Update += value;
            remove => On.SpatterOrange.Update -= value;
        }

        public static event On.SpatterOrange.hook_Impact Impact
        {
            add => On.SpatterOrange.Impact += value;
            remove => On.SpatterOrange.Impact -= value;
        }

        public static event On.SpatterOrange.hook_FaceAngle FaceAngle
        {
            add => On.SpatterOrange.FaceAngle += value;
            remove => On.SpatterOrange.FaceAngle -= value;
        }

        public static event On.SpatterOrange.hook_ProjectileSquash ProjectileSquash
        {
            add => On.SpatterOrange.ProjectileSquash += value;
            remove => On.SpatterOrange.ProjectileSquash -= value;
        }

        public static event On.SpatterOrange.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.SpatterOrange.OnCollisionEnter2D += value;
            remove => On.SpatterOrange.OnCollisionEnter2D -= value;
        }

        public static event On.SpatterOrange.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.SpatterOrange.OnTriggerEnter2D += value;
            remove => On.SpatterOrange.OnTriggerEnter2D -= value;
        }
    }
}