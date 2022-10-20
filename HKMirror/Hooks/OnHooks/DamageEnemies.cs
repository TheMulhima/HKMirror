namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DamageEnemies class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDamageEnemies
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.DamageEnemies.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(On.DamageEnemies.orig_Reset orig, DamageEnemies self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.DamageEnemies.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_NormalArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.DamageEnemies.orig_OnCollisionEnter2D orig, DamageEnemies self,
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
                On.DamageEnemies.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.DamageEnemies.orig_OnTriggerEnter2D orig, DamageEnemies self,
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

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.DamageEnemies.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_NormalArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.DamageEnemies.orig_OnTriggerExit2D orig, DamageEnemies self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerExit2D @params = new()
            {
                self = self, collision = collision
            };
            _beforeOnTriggerExit2D?.Invoke(@params);
            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerExit2D != null) _afterOnTriggerExit2D.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.DamageEnemies.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.DamageEnemies.orig_OnDisable orig, DamageEnemies self)
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

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.DamageEnemies.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_NormalArgs _afterFixedUpdate;

        private static void FixedUpdate(On.DamageEnemies.orig_FixedUpdate orig, DamageEnemies self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            _beforeFixedUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null) _afterFixedUpdate.Invoke(@params);
        }

        internal static void HookDoDamage()
        {
            if (!HookedList.Contains("DoDamage"))
            {
                HookedList.Add("DoDamage");
                On.DamageEnemies.DoDamage += DoDamage;
            }
        }

        internal static event Delegates.DoDamage_BeforeArgs _beforeDoDamage;
        internal static event Delegates.DoDamage_NormalArgs _afterDoDamage;

        private static void DoDamage(On.DamageEnemies.orig_DoDamage orig, DamageEnemies self, GameObject target)
        {
            Delegates.Params_DoDamage @params = new()
            {
                self = self, target = target
            };
            _beforeDoDamage?.Invoke(@params);
            self = @params.self;
            target = @params.target;
            orig(self, target);
            if (_afterDoDamage != null) _afterDoDamage.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoDamage_BeforeArgs(Params_DoDamage args);

        public delegate void DoDamage_NormalArgs(Params_DoDamage args);

        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_NormalArgs(Params_FixedUpdate args);

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_NormalArgs(Params_OnCollisionEnter2D args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_NormalArgs(Params_OnTriggerExit2D args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public DamageEnemies self;
        }

        public sealed class Params_OnCollisionEnter2D
        {
            public Collision2D collision;
            public DamageEnemies self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public DamageEnemies self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D collision;
            public DamageEnemies self;
        }

        public sealed class Params_OnDisable
        {
            public DamageEnemies self;
        }

        public sealed class Params_FixedUpdate
        {
            public DamageEnemies self;
        }

        public sealed class Params_DoDamage
        {
            public DamageEnemies self;
            public GameObject target;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
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

        public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._beforeOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._beforeOnTriggerExit2D -= value;
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

        public static event Delegates.FixedUpdate_BeforeArgs FixedUpdate
        {
            add
            {
                HookHandler._beforeFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._beforeFixedUpdate -= value;
        }

        public static event Delegates.DoDamage_BeforeArgs DoDamage
        {
            add
            {
                HookHandler._beforeDoDamage += value;
                HookHandler.HookDoDamage();
            }
            remove => HookHandler._beforeDoDamage -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
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

        public static event Delegates.OnTriggerExit2D_NormalArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._afterOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._afterOnTriggerExit2D -= value;
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

        public static event Delegates.FixedUpdate_NormalArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }

        public static event Delegates.DoDamage_NormalArgs DoDamage
        {
            add
            {
                HookHandler._afterDoDamage += value;
                HookHandler.HookDoDamage();
            }
            remove => HookHandler._afterDoDamage -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.DamageEnemies.hook_Reset Reset
        {
            add => On.DamageEnemies.Reset += value;
            remove => On.DamageEnemies.Reset -= value;
        }

        public static event On.DamageEnemies.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.DamageEnemies.OnCollisionEnter2D += value;
            remove => On.DamageEnemies.OnCollisionEnter2D -= value;
        }

        public static event On.DamageEnemies.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.DamageEnemies.OnTriggerEnter2D += value;
            remove => On.DamageEnemies.OnTriggerEnter2D -= value;
        }

        public static event On.DamageEnemies.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.DamageEnemies.OnTriggerExit2D += value;
            remove => On.DamageEnemies.OnTriggerExit2D -= value;
        }

        public static event On.DamageEnemies.hook_OnDisable OnDisable
        {
            add => On.DamageEnemies.OnDisable += value;
            remove => On.DamageEnemies.OnDisable -= value;
        }

        public static event On.DamageEnemies.hook_FixedUpdate FixedUpdate
        {
            add => On.DamageEnemies.FixedUpdate += value;
            remove => On.DamageEnemies.FixedUpdate -= value;
        }

        public static event On.DamageEnemies.hook_DoDamage DoDamage
        {
            add => On.DamageEnemies.DoDamage += value;
            remove => On.DamageEnemies.DoDamage -= value;
        }
    }
}