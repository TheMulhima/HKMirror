namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpatterHoney class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpatterHoney
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.SpatterHoney.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.SpatterHoney.orig_Start orig, SpatterHoney self)
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
                On.SpatterHoney.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.SpatterHoney.orig_OnEnable orig, SpatterHoney self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.SpatterHoney.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.SpatterHoney.orig_Update orig, SpatterHoney self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookImpact()
        {
            if (!HookedList.Contains("Impact"))
            {
                HookedList.Add("Impact");
                On.SpatterHoney.Impact += Impact;
            }
        }

        internal static event Delegates.Impact_BeforeArgs _beforeImpact;
        internal static event Delegates.Impact_AfterArgs _afterImpact;

        private static void Impact(On.SpatterHoney.orig_Impact orig, SpatterHoney self)
        {
            Delegates.Params_Impact @params = new()
            {
                self = self
            };
            if (_beforeImpact != null)
                foreach (Delegates.Impact_BeforeArgs toInvoke in _beforeImpact.GetInvocationList())
                    try
                    {
                        _beforeImpact?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterImpact != null)
                foreach (Delegates.Impact_AfterArgs toInvoke in _afterImpact.GetInvocationList())
                    try
                    {
                        _afterImpact.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookFaceAngle()
        {
            if (!HookedList.Contains("FaceAngle"))
            {
                HookedList.Add("FaceAngle");
                On.SpatterHoney.FaceAngle += FaceAngle;
            }
        }

        internal static event Delegates.FaceAngle_BeforeArgs _beforeFaceAngle;
        internal static event Delegates.FaceAngle_AfterArgs _afterFaceAngle;

        private static void FaceAngle(On.SpatterHoney.orig_FaceAngle orig, SpatterHoney self)
        {
            Delegates.Params_FaceAngle @params = new()
            {
                self = self
            };
            if (_beforeFaceAngle != null)
                foreach (Delegates.FaceAngle_BeforeArgs toInvoke in _beforeFaceAngle.GetInvocationList())
                    try
                    {
                        _beforeFaceAngle?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterFaceAngle != null)
                foreach (Delegates.FaceAngle_AfterArgs toInvoke in _afterFaceAngle.GetInvocationList())
                    try
                    {
                        _afterFaceAngle.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookProjectileSquash()
        {
            if (!HookedList.Contains("ProjectileSquash"))
            {
                HookedList.Add("ProjectileSquash");
                On.SpatterHoney.ProjectileSquash += ProjectileSquash;
            }
        }

        internal static event Delegates.ProjectileSquash_BeforeArgs _beforeProjectileSquash;
        internal static event Delegates.ProjectileSquash_AfterArgs _afterProjectileSquash;

        private static void ProjectileSquash(On.SpatterHoney.orig_ProjectileSquash orig, SpatterHoney self)
        {
            Delegates.Params_ProjectileSquash @params = new()
            {
                self = self
            };
            if (_beforeProjectileSquash != null)
                foreach (Delegates.ProjectileSquash_BeforeArgs toInvoke in _beforeProjectileSquash.GetInvocationList())
                    try
                    {
                        _beforeProjectileSquash?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterProjectileSquash != null)
                foreach (Delegates.ProjectileSquash_AfterArgs toInvoke in _afterProjectileSquash.GetInvocationList())
                    try
                    {
                        _afterProjectileSquash.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.SpatterHoney.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_AfterArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.SpatterHoney.orig_OnCollisionEnter2D orig, SpatterHoney self,
            Collision2D collision)
        {
            Delegates.Params_OnCollisionEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnCollisionEnter2D != null)
                foreach (Delegates.OnCollisionEnter2D_BeforeArgs toInvoke in
                         _beforeOnCollisionEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnCollisionEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnCollisionEnter2D != null)
                foreach (Delegates.OnCollisionEnter2D_AfterArgs toInvoke in
                         _afterOnCollisionEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnCollisionEnter2D.Invoke(@params);
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
        public delegate void FaceAngle_AfterArgs(Params_FaceAngle args);

        public delegate void FaceAngle_BeforeArgs(Params_FaceAngle args);

        public delegate void FaceAngle_WithArgs(Action<SpatterHoney> orig, SpatterHoney self);

        public delegate void Impact_AfterArgs(Params_Impact args);

        public delegate void Impact_BeforeArgs(Params_Impact args);

        public delegate void Impact_WithArgs(Action<SpatterHoney> orig, SpatterHoney self);

        public delegate void OnCollisionEnter2D_AfterArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_WithArgs(Action<SpatterHoney, Collision2D> orig, SpatterHoney self,
            Collision2D collision);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<SpatterHoney> orig, SpatterHoney self);

        public delegate void ProjectileSquash_AfterArgs(Params_ProjectileSquash args);

        public delegate void ProjectileSquash_BeforeArgs(Params_ProjectileSquash args);

        public delegate void ProjectileSquash_WithArgs(Action<SpatterHoney> orig, SpatterHoney self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<SpatterHoney> orig, SpatterHoney self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<SpatterHoney> orig, SpatterHoney self);

        public sealed class Params_Start
        {
            public SpatterHoney self;
        }

        public sealed class Params_OnEnable
        {
            public SpatterHoney self;
        }

        public sealed class Params_Update
        {
            public SpatterHoney self;
        }

        public sealed class Params_Impact
        {
            public SpatterHoney self;
        }

        public sealed class Params_FaceAngle
        {
            public SpatterHoney self;
        }

        public sealed class Params_ProjectileSquash
        {
            public SpatterHoney self;
        }

        public sealed class Params_OnCollisionEnter2D
        {
            public Collision2D collision;
            public SpatterHoney self;
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

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.Impact_AfterArgs Impact
        {
            add
            {
                HookHandler._afterImpact += value;
                HookHandler.HookImpact();
            }
            remove => HookHandler._afterImpact -= value;
        }

        public static event Delegates.FaceAngle_AfterArgs FaceAngle
        {
            add
            {
                HookHandler._afterFaceAngle += value;
                HookHandler.HookFaceAngle();
            }
            remove => HookHandler._afterFaceAngle -= value;
        }

        public static event Delegates.ProjectileSquash_AfterArgs ProjectileSquash
        {
            add
            {
                HookHandler._afterProjectileSquash += value;
                HookHandler.HookProjectileSquash();
            }
            remove => HookHandler._afterProjectileSquash -= value;
        }

        public static event Delegates.OnCollisionEnter2D_AfterArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._afterOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._afterOnCollisionEnter2D -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpatterHoney.hook_Start Start
        {
            add => On.SpatterHoney.Start += value;
            remove => On.SpatterHoney.Start -= value;
        }

        public static event On.SpatterHoney.hook_OnEnable OnEnable
        {
            add => On.SpatterHoney.OnEnable += value;
            remove => On.SpatterHoney.OnEnable -= value;
        }

        public static event On.SpatterHoney.hook_Update Update
        {
            add => On.SpatterHoney.Update += value;
            remove => On.SpatterHoney.Update -= value;
        }

        public static event On.SpatterHoney.hook_Impact Impact
        {
            add => On.SpatterHoney.Impact += value;
            remove => On.SpatterHoney.Impact -= value;
        }

        public static event On.SpatterHoney.hook_FaceAngle FaceAngle
        {
            add => On.SpatterHoney.FaceAngle += value;
            remove => On.SpatterHoney.FaceAngle -= value;
        }

        public static event On.SpatterHoney.hook_ProjectileSquash ProjectileSquash
        {
            add => On.SpatterHoney.ProjectileSquash += value;
            remove => On.SpatterHoney.ProjectileSquash -= value;
        }

        public static event On.SpatterHoney.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.SpatterHoney.OnCollisionEnter2D += value;
            remove => On.SpatterHoney.OnCollisionEnter2D -= value;
        }
    }
}