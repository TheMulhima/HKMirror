namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EndBeta class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEndBeta
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.EndBeta.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.EndBeta.orig_Awake orig, EndBeta self)
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
                On.EndBeta.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.EndBeta.orig_Start orig, EndBeta self)
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
                On.EndBeta.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.EndBeta.orig_Update orig, EndBeta self)
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
                On.EndBeta.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.EndBeta.orig_OnTriggerEnter2D orig, EndBeta self,
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

        internal static void HookReactivate()
        {
            if (!HookedList.Contains("Reactivate"))
            {
                HookedList.Add("Reactivate");
                On.EndBeta.Reactivate += Reactivate;
            }
        }

        internal static event Delegates.Reactivate_BeforeArgs _beforeReactivate;
        internal static event Delegates.Reactivate_NormalArgs _afterReactivate;

        private static void Reactivate(On.EndBeta.orig_Reactivate orig, EndBeta self)
        {
            Delegates.Params_Reactivate @params = new()
            {
                self = self
            };
            _beforeReactivate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReactivate != null) _afterReactivate.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void Reactivate_BeforeArgs(Params_Reactivate args);

        public delegate void Reactivate_NormalArgs(Params_Reactivate args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public EndBeta self;
        }

        public sealed class Params_Start
        {
            public EndBeta self;
        }

        public sealed class Params_Update
        {
            public EndBeta self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public EndBeta self;
        }

        public sealed class Params_Reactivate
        {
            public EndBeta self;
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

        public static event Delegates.Reactivate_BeforeArgs Reactivate
        {
            add
            {
                HookHandler._beforeReactivate += value;
                HookHandler.HookReactivate();
            }
            remove => HookHandler._beforeReactivate -= value;
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

        public static event Delegates.Reactivate_NormalArgs Reactivate
        {
            add
            {
                HookHandler._afterReactivate += value;
                HookHandler.HookReactivate();
            }
            remove => HookHandler._afterReactivate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.EndBeta.hook_Awake Awake
        {
            add => On.EndBeta.Awake += value;
            remove => On.EndBeta.Awake -= value;
        }

        public static event On.EndBeta.hook_Start Start
        {
            add => On.EndBeta.Start += value;
            remove => On.EndBeta.Start -= value;
        }

        public static event On.EndBeta.hook_Update Update
        {
            add => On.EndBeta.Update += value;
            remove => On.EndBeta.Update -= value;
        }

        public static event On.EndBeta.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.EndBeta.OnTriggerEnter2D += value;
            remove => On.EndBeta.OnTriggerEnter2D -= value;
        }

        public static event On.EndBeta.hook_Reactivate Reactivate
        {
            add => On.EndBeta.Reactivate += value;
            remove => On.EndBeta.Reactivate -= value;
        }
    }
}