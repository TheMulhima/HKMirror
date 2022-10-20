namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GrassWind class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGrassWind
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.GrassWind.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.GrassWind.orig_Awake orig, GrassWind self)
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

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.GrassWind.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.GrassWind.orig_OnTriggerEnter2D orig, GrassWind self,
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

        internal static void HookDelayReact()
        {
            if (!HookedList.Contains("DelayReact"))
            {
                HookedList.Add("DelayReact");
                On.GrassWind.DelayReact += DelayReact;
            }
        }

        internal static event Delegates.DelayReact_BeforeArgs _beforeDelayReact;

        private static IEnumerator DelayReact(On.GrassWind.orig_DelayReact orig, GrassWind self,
            GrassBehaviour behaviour, Collider2D collision)
        {
            Delegates.Params_DelayReact @params = new()
            {
                self = self, behaviour = behaviour, collision = collision
            };
            _beforeDelayReact?.Invoke(@params);
            self = @params.self;
            behaviour = @params.behaviour;
            collision = @params.collision;
            return orig(self, behaviour, collision);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void DelayReact_BeforeArgs(Params_DelayReact args);

        public delegate IEnumerator DelayReact_NormalArgs(Params_DelayReact args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public sealed class Params_Awake
        {
            public GrassWind self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public GrassWind self;
        }

        public sealed class Params_DelayReact
        {
            public GrassBehaviour behaviour;
            public Collider2D collision;
            public GrassWind self;
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.DelayReact_BeforeArgs DelayReact
        {
            add
            {
                HookHandler._beforeDelayReact += value;
                HookHandler.HookDelayReact();
            }
            remove => HookHandler._beforeDelayReact -= value;
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
        public static event On.GrassWind.hook_Awake Awake
        {
            add => On.GrassWind.Awake += value;
            remove => On.GrassWind.Awake -= value;
        }

        public static event On.GrassWind.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.GrassWind.OnTriggerEnter2D += value;
            remove => On.GrassWind.OnTriggerEnter2D -= value;
        }

        public static event On.GrassWind.hook_DelayReact DelayReact
        {
            add => On.GrassWind.DelayReact += value;
            remove => On.GrassWind.DelayReact -= value;
        }
    }
}