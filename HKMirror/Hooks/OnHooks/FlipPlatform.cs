namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for FlipPlatform class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFlipPlatform
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.FlipPlatform.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.FlipPlatform.orig_Awake orig, FlipPlatform self)
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
                On.FlipPlatform.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.FlipPlatform.orig_Start orig, FlipPlatform self)
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

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.FlipPlatform.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_NormalArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.FlipPlatform.orig_OnCollisionEnter2D orig, FlipPlatform self,
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

        internal static void HookPlaySound()
        {
            if (!HookedList.Contains("PlaySound"))
            {
                HookedList.Add("PlaySound");
                On.FlipPlatform.PlaySound += PlaySound;
            }
        }

        internal static event Delegates.PlaySound_BeforeArgs _beforePlaySound;
        internal static event Delegates.PlaySound_NormalArgs _afterPlaySound;

        private static void PlaySound(On.FlipPlatform.orig_PlaySound orig, FlipPlatform self, AudioClip clip)
        {
            Delegates.Params_PlaySound @params = new()
            {
                self = self, clip = clip
            };
            _beforePlaySound?.Invoke(@params);
            self = @params.self;
            clip = @params.clip;
            orig(self, clip);
            if (_afterPlaySound != null) _afterPlaySound.Invoke(@params);
        }

        internal static void HookIdle()
        {
            if (!HookedList.Contains("Idle"))
            {
                HookedList.Add("Idle");
                On.FlipPlatform.Idle += Idle;
            }
        }

        internal static event Delegates.Idle_BeforeArgs _beforeIdle;

        private static IEnumerator Idle(On.FlipPlatform.orig_Idle orig, FlipPlatform self)
        {
            Delegates.Params_Idle @params = new()
            {
                self = self
            };
            _beforeIdle?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookFlip()
        {
            if (!HookedList.Contains("Flip"))
            {
                HookedList.Add("Flip");
                On.FlipPlatform.Flip += Flip;
            }
        }

        internal static event Delegates.Flip_BeforeArgs _beforeFlip;

        private static IEnumerator Flip(On.FlipPlatform.orig_Flip orig, FlipPlatform self)
        {
            Delegates.Params_Flip @params = new()
            {
                self = self
            };
            _beforeFlip?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookJitter()
        {
            if (!HookedList.Contains("Jitter"))
            {
                HookedList.Add("Jitter");
                On.FlipPlatform.Jitter += Jitter;
            }
        }

        internal static event Delegates.Jitter_BeforeArgs _beforeJitter;

        private static IEnumerator Jitter(On.FlipPlatform.orig_Jitter orig, FlipPlatform self, float duration)
        {
            Delegates.Params_Jitter @params = new()
            {
                self = self, duration = duration
            };
            _beforeJitter?.Invoke(@params);
            self = @params.self;
            duration = @params.duration;
            return orig(self, duration);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void Flip_BeforeArgs(Params_Flip args);

        public delegate IEnumerator Flip_NormalArgs(Params_Flip args);

        public delegate void Idle_BeforeArgs(Params_Idle args);

        public delegate IEnumerator Idle_NormalArgs(Params_Idle args);

        public delegate void Jitter_BeforeArgs(Params_Jitter args);

        public delegate IEnumerator Jitter_NormalArgs(Params_Jitter args);

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_NormalArgs(Params_OnCollisionEnter2D args);

        public delegate void PlaySound_BeforeArgs(Params_PlaySound args);

        public delegate void PlaySound_NormalArgs(Params_PlaySound args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Awake
        {
            public FlipPlatform self;
        }

        public sealed class Params_Start
        {
            public FlipPlatform self;
        }

        public sealed class Params_OnCollisionEnter2D
        {
            public Collision2D collision;
            public FlipPlatform self;
        }

        public sealed class Params_PlaySound
        {
            public AudioClip clip;
            public FlipPlatform self;
        }

        public sealed class Params_Idle
        {
            public FlipPlatform self;
        }

        public sealed class Params_Flip
        {
            public FlipPlatform self;
        }

        public sealed class Params_Jitter
        {
            public float duration;
            public FlipPlatform self;
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

        public static event Delegates.OnCollisionEnter2D_BeforeArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._beforeOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._beforeOnCollisionEnter2D -= value;
        }

        public static event Delegates.PlaySound_BeforeArgs PlaySound
        {
            add
            {
                HookHandler._beforePlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._beforePlaySound -= value;
        }

        public static event Delegates.Idle_BeforeArgs Idle
        {
            add
            {
                HookHandler._beforeIdle += value;
                HookHandler.HookIdle();
            }
            remove => HookHandler._beforeIdle -= value;
        }

        public static event Delegates.Flip_BeforeArgs Flip
        {
            add
            {
                HookHandler._beforeFlip += value;
                HookHandler.HookFlip();
            }
            remove => HookHandler._beforeFlip -= value;
        }

        public static event Delegates.Jitter_BeforeArgs Jitter
        {
            add
            {
                HookHandler._beforeJitter += value;
                HookHandler.HookJitter();
            }
            remove => HookHandler._beforeJitter -= value;
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

        public static event Delegates.OnCollisionEnter2D_NormalArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._afterOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._afterOnCollisionEnter2D -= value;
        }

        public static event Delegates.PlaySound_NormalArgs PlaySound
        {
            add
            {
                HookHandler._afterPlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._afterPlaySound -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.FlipPlatform.hook_Awake Awake
        {
            add => On.FlipPlatform.Awake += value;
            remove => On.FlipPlatform.Awake -= value;
        }

        public static event On.FlipPlatform.hook_Start Start
        {
            add => On.FlipPlatform.Start += value;
            remove => On.FlipPlatform.Start -= value;
        }

        public static event On.FlipPlatform.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.FlipPlatform.OnCollisionEnter2D += value;
            remove => On.FlipPlatform.OnCollisionEnter2D -= value;
        }

        public static event On.FlipPlatform.hook_PlaySound PlaySound
        {
            add => On.FlipPlatform.PlaySound += value;
            remove => On.FlipPlatform.PlaySound -= value;
        }

        public static event On.FlipPlatform.hook_Idle Idle
        {
            add => On.FlipPlatform.Idle += value;
            remove => On.FlipPlatform.Idle -= value;
        }

        public static event On.FlipPlatform.hook_Flip Flip
        {
            add => On.FlipPlatform.Flip += value;
            remove => On.FlipPlatform.Flip -= value;
        }

        public static event On.FlipPlatform.hook_Jitter Jitter
        {
            add => On.FlipPlatform.Jitter += value;
            remove => On.FlipPlatform.Jitter -= value;
        }
    }
}