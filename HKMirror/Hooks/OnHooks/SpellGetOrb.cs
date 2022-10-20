namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpellGetOrb class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpellGetOrb
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.SpellGetOrb.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.SpellGetOrb.orig_Start orig, SpellGetOrb self)
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
                On.SpellGetOrb.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.SpellGetOrb.orig_OnEnable orig, SpellGetOrb self)
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
                On.SpellGetOrb.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.SpellGetOrb.orig_Update orig, SpellGetOrb self)
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

        internal static void HookFaceAngle()
        {
            if (!HookedList.Contains("FaceAngle"))
            {
                HookedList.Add("FaceAngle");
                On.SpellGetOrb.FaceAngle += FaceAngle;
            }
        }

        internal static event Delegates.FaceAngle_BeforeArgs _beforeFaceAngle;
        internal static event Delegates.FaceAngle_NormalArgs _afterFaceAngle;

        private static void FaceAngle(On.SpellGetOrb.orig_FaceAngle orig, SpellGetOrb self)
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
                On.SpellGetOrb.ProjectileSquash += ProjectileSquash;
            }
        }

        internal static event Delegates.ProjectileSquash_BeforeArgs _beforeProjectileSquash;
        internal static event Delegates.ProjectileSquash_NormalArgs _afterProjectileSquash;

        private static void ProjectileSquash(On.SpellGetOrb.orig_ProjectileSquash orig, SpellGetOrb self)
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

        internal static void HookCollect()
        {
            if (!HookedList.Contains("Collect"))
            {
                HookedList.Add("Collect");
                On.SpellGetOrb.Collect += Collect;
            }
        }

        internal static event Delegates.Collect_BeforeArgs _beforeCollect;
        internal static event Delegates.Collect_NormalArgs _afterCollect;

        private static void Collect(On.SpellGetOrb.orig_Collect orig, SpellGetOrb self)
        {
            Delegates.Params_Collect @params = new()
            {
                self = self
            };
            _beforeCollect?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterCollect != null) _afterCollect.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Collect_BeforeArgs(Params_Collect args);

        public delegate void Collect_NormalArgs(Params_Collect args);

        public delegate void FaceAngle_BeforeArgs(Params_FaceAngle args);

        public delegate void FaceAngle_NormalArgs(Params_FaceAngle args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void ProjectileSquash_BeforeArgs(Params_ProjectileSquash args);

        public delegate void ProjectileSquash_NormalArgs(Params_ProjectileSquash args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Start
        {
            public SpellGetOrb self;
        }

        public sealed class Params_OnEnable
        {
            public SpellGetOrb self;
        }

        public sealed class Params_Update
        {
            public SpellGetOrb self;
        }

        public sealed class Params_FaceAngle
        {
            public SpellGetOrb self;
        }

        public sealed class Params_ProjectileSquash
        {
            public SpellGetOrb self;
        }

        public sealed class Params_Collect
        {
            public SpellGetOrb self;
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

        public static event Delegates.Collect_BeforeArgs Collect
        {
            add
            {
                HookHandler._beforeCollect += value;
                HookHandler.HookCollect();
            }
            remove => HookHandler._beforeCollect -= value;
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

        public static event Delegates.Collect_NormalArgs Collect
        {
            add
            {
                HookHandler._afterCollect += value;
                HookHandler.HookCollect();
            }
            remove => HookHandler._afterCollect -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpellGetOrb.hook_Start Start
        {
            add => On.SpellGetOrb.Start += value;
            remove => On.SpellGetOrb.Start -= value;
        }

        public static event On.SpellGetOrb.hook_OnEnable OnEnable
        {
            add => On.SpellGetOrb.OnEnable += value;
            remove => On.SpellGetOrb.OnEnable -= value;
        }

        public static event On.SpellGetOrb.hook_Update Update
        {
            add => On.SpellGetOrb.Update += value;
            remove => On.SpellGetOrb.Update -= value;
        }

        public static event On.SpellGetOrb.hook_FaceAngle FaceAngle
        {
            add => On.SpellGetOrb.FaceAngle += value;
            remove => On.SpellGetOrb.FaceAngle -= value;
        }

        public static event On.SpellGetOrb.hook_ProjectileSquash ProjectileSquash
        {
            add => On.SpellGetOrb.ProjectileSquash += value;
            remove => On.SpellGetOrb.ProjectileSquash -= value;
        }

        public static event On.SpellGetOrb.hook_Collect Collect
        {
            add => On.SpellGetOrb.Collect += value;
            remove => On.SpellGetOrb.Collect -= value;
        }
    }
}