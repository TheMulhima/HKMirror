namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DamageEffectTicker class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDamageEffectTicker
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.DamageEffectTicker.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.DamageEffectTicker.orig_OnEnable orig, DamageEffectTicker self)
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
                On.DamageEffectTicker.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.DamageEffectTicker.orig_Update orig, DamageEffectTicker self)
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

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.DamageEffectTicker.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.DamageEffectTicker.orig_OnTriggerEnter2D orig, DamageEffectTicker self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            _beforeOnTriggerEnter2D?.Invoke(@params);
            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerEnter2D != null) _afterOnTriggerEnter2D.Invoke(@params);
        }

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.DamageEffectTicker.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_NormalArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.DamageEffectTicker.orig_OnTriggerExit2D orig, DamageEffectTicker self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerExit2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            _beforeOnTriggerExit2D?.Invoke(@params);
            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerExit2D != null) _afterOnTriggerExit2D.Invoke(@params);
        }

        internal static void HookEmptyDamageList()
        {
            if (!HookedList.Contains("EmptyDamageList"))
            {
                HookedList.Add("EmptyDamageList");
                On.DamageEffectTicker.EmptyDamageList += EmptyDamageList;
            }
        }

        internal static event Delegates.EmptyDamageList_BeforeArgs _beforeEmptyDamageList;
        internal static event Delegates.EmptyDamageList_NormalArgs _afterEmptyDamageList;

        private static void EmptyDamageList(On.DamageEffectTicker.orig_EmptyDamageList orig, DamageEffectTicker self)
        {
            Delegates.Params_EmptyDamageList @params = new()
            {
                self = self
            };
            _beforeEmptyDamageList?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEmptyDamageList != null) _afterEmptyDamageList.Invoke(@params);
        }

        internal static void HookSetDamageEvent()
        {
            if (!HookedList.Contains("SetDamageEvent"))
            {
                HookedList.Add("SetDamageEvent");
                On.DamageEffectTicker.SetDamageEvent += SetDamageEvent;
            }
        }

        internal static event Delegates.SetDamageEvent_BeforeArgs _beforeSetDamageEvent;
        internal static event Delegates.SetDamageEvent_NormalArgs _afterSetDamageEvent;

        private static void SetDamageEvent(On.DamageEffectTicker.orig_SetDamageEvent orig, DamageEffectTicker self,
            string newEvent)
        {
            Delegates.Params_SetDamageEvent @params = new()
            {
                self = self, newEvent = newEvent
            };
            _beforeSetDamageEvent?.Invoke(@params);
            self = @params.self;
            newEvent = @params.newEvent;
            orig(self, newEvent);
            if (_afterSetDamageEvent != null) _afterSetDamageEvent.Invoke(@params);
        }

        internal static void HookSetDamageInterval()
        {
            if (!HookedList.Contains("SetDamageInterval"))
            {
                HookedList.Add("SetDamageInterval");
                On.DamageEffectTicker.SetDamageInterval += SetDamageInterval;
            }
        }

        internal static event Delegates.SetDamageInterval_BeforeArgs _beforeSetDamageInterval;
        internal static event Delegates.SetDamageInterval_NormalArgs _afterSetDamageInterval;

        private static void SetDamageInterval(On.DamageEffectTicker.orig_SetDamageInterval orig,
            DamageEffectTicker self, float newInterval)
        {
            Delegates.Params_SetDamageInterval @params = new()
            {
                self = self, newInterval = newInterval
            };
            _beforeSetDamageInterval?.Invoke(@params);
            self = @params.self;
            newInterval = @params.newInterval;
            orig(self, newInterval);
            if (_afterSetDamageInterval != null) _afterSetDamageInterval.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void EmptyDamageList_BeforeArgs(Params_EmptyDamageList args);

        public delegate void EmptyDamageList_NormalArgs(Params_EmptyDamageList args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_NormalArgs(Params_OnTriggerExit2D args);

        public delegate void SetDamageEvent_BeforeArgs(Params_SetDamageEvent args);

        public delegate void SetDamageEvent_NormalArgs(Params_SetDamageEvent args);

        public delegate void SetDamageInterval_BeforeArgs(Params_SetDamageInterval args);

        public delegate void SetDamageInterval_NormalArgs(Params_SetDamageInterval args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_OnEnable
        {
            public DamageEffectTicker self;
        }

        public sealed class Params_Update
        {
            public DamageEffectTicker self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public DamageEffectTicker self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D otherCollider;
            public DamageEffectTicker self;
        }

        public sealed class Params_EmptyDamageList
        {
            public DamageEffectTicker self;
        }

        public sealed class Params_SetDamageEvent
        {
            public string newEvent;
            public DamageEffectTicker self;
        }

        public sealed class Params_SetDamageInterval
        {
            public float newInterval;
            public DamageEffectTicker self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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

        public static event Delegates.EmptyDamageList_BeforeArgs EmptyDamageList
        {
            add
            {
                HookHandler._beforeEmptyDamageList += value;
                HookHandler.HookEmptyDamageList();
            }
            remove => HookHandler._beforeEmptyDamageList -= value;
        }

        public static event Delegates.SetDamageEvent_BeforeArgs SetDamageEvent
        {
            add
            {
                HookHandler._beforeSetDamageEvent += value;
                HookHandler.HookSetDamageEvent();
            }
            remove => HookHandler._beforeSetDamageEvent -= value;
        }

        public static event Delegates.SetDamageInterval_BeforeArgs SetDamageInterval
        {
            add
            {
                HookHandler._beforeSetDamageInterval += value;
                HookHandler.HookSetDamageInterval();
            }
            remove => HookHandler._beforeSetDamageInterval -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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

        public static event Delegates.EmptyDamageList_NormalArgs EmptyDamageList
        {
            add
            {
                HookHandler._afterEmptyDamageList += value;
                HookHandler.HookEmptyDamageList();
            }
            remove => HookHandler._afterEmptyDamageList -= value;
        }

        public static event Delegates.SetDamageEvent_NormalArgs SetDamageEvent
        {
            add
            {
                HookHandler._afterSetDamageEvent += value;
                HookHandler.HookSetDamageEvent();
            }
            remove => HookHandler._afterSetDamageEvent -= value;
        }

        public static event Delegates.SetDamageInterval_NormalArgs SetDamageInterval
        {
            add
            {
                HookHandler._afterSetDamageInterval += value;
                HookHandler.HookSetDamageInterval();
            }
            remove => HookHandler._afterSetDamageInterval -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.DamageEffectTicker.hook_OnEnable OnEnable
        {
            add => On.DamageEffectTicker.OnEnable += value;
            remove => On.DamageEffectTicker.OnEnable -= value;
        }

        public static event On.DamageEffectTicker.hook_Update Update
        {
            add => On.DamageEffectTicker.Update += value;
            remove => On.DamageEffectTicker.Update -= value;
        }

        public static event On.DamageEffectTicker.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.DamageEffectTicker.OnTriggerEnter2D += value;
            remove => On.DamageEffectTicker.OnTriggerEnter2D -= value;
        }

        public static event On.DamageEffectTicker.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.DamageEffectTicker.OnTriggerExit2D += value;
            remove => On.DamageEffectTicker.OnTriggerExit2D -= value;
        }

        public static event On.DamageEffectTicker.hook_EmptyDamageList EmptyDamageList
        {
            add => On.DamageEffectTicker.EmptyDamageList += value;
            remove => On.DamageEffectTicker.EmptyDamageList -= value;
        }

        public static event On.DamageEffectTicker.hook_SetDamageEvent SetDamageEvent
        {
            add => On.DamageEffectTicker.SetDamageEvent += value;
            remove => On.DamageEffectTicker.SetDamageEvent -= value;
        }

        public static event On.DamageEffectTicker.hook_SetDamageInterval SetDamageInterval
        {
            add => On.DamageEffectTicker.SetDamageInterval += value;
            remove => On.DamageEffectTicker.SetDamageInterval -= value;
        }
    }
}