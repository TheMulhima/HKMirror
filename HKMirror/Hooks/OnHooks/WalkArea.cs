namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for WalkArea class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnWalkArea
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.WalkArea.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.WalkArea.orig_Awake orig, WalkArea self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.WalkArea.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.WalkArea.orig_Start orig, WalkArea self)
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

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.WalkArea.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.WalkArea.orig_OnTriggerEnter2D orig, WalkArea self,
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

        internal static void HookOnTriggerStay2D()
        {
            if (!HookedList.Contains("OnTriggerStay2D"))
            {
                HookedList.Add("OnTriggerStay2D");
                On.WalkArea.OnTriggerStay2D += OnTriggerStay2D;
            }
        }

        internal static event Delegates.OnTriggerStay2D_BeforeArgs _beforeOnTriggerStay2D;
        internal static event Delegates.OnTriggerStay2D_NormalArgs _afterOnTriggerStay2D;

        private static void OnTriggerStay2D(On.WalkArea.orig_OnTriggerStay2D orig, WalkArea self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerStay2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            _beforeOnTriggerStay2D?.Invoke(@params);
            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerStay2D != null) _afterOnTriggerStay2D.Invoke(@params);
        }

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.WalkArea.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_NormalArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.WalkArea.orig_OnTriggerExit2D orig, WalkArea self,
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

        internal static void HookDeactivate()
        {
            if (!HookedList.Contains("Deactivate"))
            {
                HookedList.Add("Deactivate");
                On.WalkArea.Deactivate += Deactivate;
            }
        }

        internal static event Delegates.Deactivate_BeforeArgs _beforeDeactivate;
        internal static event Delegates.Deactivate_NormalArgs _afterDeactivate;

        private static void Deactivate(On.WalkArea.orig_Deactivate orig, WalkArea self)
        {
            Delegates.Params_Deactivate @params = new()
            {
                self = self
            };
            _beforeDeactivate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDeactivate != null) _afterDeactivate.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.WalkArea.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.WalkArea.orig_OnDisable orig, WalkArea self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void Deactivate_BeforeArgs(Params_Deactivate args);

        public delegate void Deactivate_NormalArgs(Params_Deactivate args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_NormalArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerStay2D_BeforeArgs(Params_OnTriggerStay2D args);

        public delegate void OnTriggerStay2D_NormalArgs(Params_OnTriggerStay2D args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Awake
        {
            public WalkArea self;
        }

        public sealed class Params_Start
        {
            public WalkArea self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public WalkArea self;
        }

        public sealed class Params_OnTriggerStay2D
        {
            public Collider2D otherCollider;
            public WalkArea self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D otherCollider;
            public WalkArea self;
        }

        public sealed class Params_Deactivate
        {
            public WalkArea self;
        }

        public sealed class Params_OnDisable
        {
            public WalkArea self;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.OnTriggerStay2D_BeforeArgs OnTriggerStay2D
        {
            add
            {
                HookHandler._beforeOnTriggerStay2D += value;
                HookHandler.HookOnTriggerStay2D();
            }
            remove => HookHandler._beforeOnTriggerStay2D -= value;
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

        public static event Delegates.Deactivate_BeforeArgs Deactivate
        {
            add
            {
                HookHandler._beforeDeactivate += value;
                HookHandler.HookDeactivate();
            }
            remove => HookHandler._beforeDeactivate -= value;
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

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.OnTriggerStay2D_NormalArgs OnTriggerStay2D
        {
            add
            {
                HookHandler._afterOnTriggerStay2D += value;
                HookHandler.HookOnTriggerStay2D();
            }
            remove => HookHandler._afterOnTriggerStay2D -= value;
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

        public static event Delegates.Deactivate_NormalArgs Deactivate
        {
            add
            {
                HookHandler._afterDeactivate += value;
                HookHandler.HookDeactivate();
            }
            remove => HookHandler._afterDeactivate -= value;
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.WalkArea.hook_Awake Awake
        {
            add => On.WalkArea.Awake += value;
            remove => On.WalkArea.Awake -= value;
        }

        public static event On.WalkArea.hook_Start Start
        {
            add => On.WalkArea.Start += value;
            remove => On.WalkArea.Start -= value;
        }

        public static event On.WalkArea.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.WalkArea.OnTriggerEnter2D += value;
            remove => On.WalkArea.OnTriggerEnter2D -= value;
        }

        public static event On.WalkArea.hook_OnTriggerStay2D OnTriggerStay2D
        {
            add => On.WalkArea.OnTriggerStay2D += value;
            remove => On.WalkArea.OnTriggerStay2D -= value;
        }

        public static event On.WalkArea.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.WalkArea.OnTriggerExit2D += value;
            remove => On.WalkArea.OnTriggerExit2D -= value;
        }

        public static event On.WalkArea.hook_Deactivate Deactivate
        {
            add => On.WalkArea.Deactivate += value;
            remove => On.WalkArea.Deactivate -= value;
        }

        public static event On.WalkArea.hook_OnDisable OnDisable
        {
            add => On.WalkArea.OnDisable += value;
            remove => On.WalkArea.OnDisable -= value;
        }
    }
}