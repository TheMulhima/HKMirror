namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TouchShake class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTouchShake
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.TouchShake.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.TouchShake.orig_Start orig, TouchShake self)
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
                On.TouchShake.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.TouchShake.orig_OnTriggerEnter2D orig, TouchShake self,
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

        internal static void HookDoAnimation()
        {
            if (!HookedList.Contains("DoAnimation"))
            {
                HookedList.Add("DoAnimation");
                On.TouchShake.DoAnimation += DoAnimation;
            }
        }

        internal static event Delegates.DoAnimation_BeforeArgs _beforeDoAnimation;

        private static IEnumerator DoAnimation(On.TouchShake.orig_DoAnimation orig, TouchShake self)
        {
            Delegates.Params_DoAnimation @params = new()
            {
                self = self
            };
            _beforeDoAnimation?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookSpriteAnimation()
        {
            if (!HookedList.Contains("SpriteAnimation"))
            {
                HookedList.Add("SpriteAnimation");
                On.TouchShake.SpriteAnimation += SpriteAnimation;
            }
        }

        internal static event Delegates.SpriteAnimation_BeforeArgs _beforeSpriteAnimation;

        private static IEnumerator SpriteAnimation(On.TouchShake.orig_SpriteAnimation orig, TouchShake self)
        {
            Delegates.Params_SpriteAnimation @params = new()
            {
                self = self
            };
            _beforeSpriteAnimation?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void Hooktk2dAnimation()
        {
            if (!HookedList.Contains("tk2dAnimation"))
            {
                HookedList.Add("tk2dAnimation");
                On.TouchShake.tk2dAnimation += tk2dAnimation;
            }
        }

        internal static event Delegates.tk2dAnimation_BeforeArgs _beforetk2dAnimation;

        private static IEnumerator tk2dAnimation(On.TouchShake.orig_tk2dAnimation orig, TouchShake self)
        {
            Delegates.Params_tk2dAnimation @params = new()
            {
                self = self
            };
            _beforetk2dAnimation?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoAnimation_BeforeArgs(Params_DoAnimation args);

        public delegate IEnumerator DoAnimation_NormalArgs(Params_DoAnimation args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void SpriteAnimation_BeforeArgs(Params_SpriteAnimation args);

        public delegate IEnumerator SpriteAnimation_NormalArgs(Params_SpriteAnimation args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void tk2dAnimation_BeforeArgs(Params_tk2dAnimation args);

        public delegate IEnumerator tk2dAnimation_NormalArgs(Params_tk2dAnimation args);

        public sealed class Params_Start
        {
            public TouchShake self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public TouchShake self;
        }

        public sealed class Params_DoAnimation
        {
            public TouchShake self;
        }

        public sealed class Params_SpriteAnimation
        {
            public TouchShake self;
        }

        public sealed class Params_tk2dAnimation
        {
            public TouchShake self;
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.DoAnimation_BeforeArgs DoAnimation
        {
            add
            {
                HookHandler._beforeDoAnimation += value;
                HookHandler.HookDoAnimation();
            }
            remove => HookHandler._beforeDoAnimation -= value;
        }

        public static event Delegates.SpriteAnimation_BeforeArgs SpriteAnimation
        {
            add
            {
                HookHandler._beforeSpriteAnimation += value;
                HookHandler.HookSpriteAnimation();
            }
            remove => HookHandler._beforeSpriteAnimation -= value;
        }

        public static event Delegates.tk2dAnimation_BeforeArgs tk2dAnimation
        {
            add
            {
                HookHandler._beforetk2dAnimation += value;
                HookHandler.Hooktk2dAnimation();
            }
            remove => HookHandler._beforetk2dAnimation -= value;
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
        public static event On.TouchShake.hook_Start Start
        {
            add => On.TouchShake.Start += value;
            remove => On.TouchShake.Start -= value;
        }

        public static event On.TouchShake.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.TouchShake.OnTriggerEnter2D += value;
            remove => On.TouchShake.OnTriggerEnter2D -= value;
        }

        public static event On.TouchShake.hook_DoAnimation DoAnimation
        {
            add => On.TouchShake.DoAnimation += value;
            remove => On.TouchShake.DoAnimation -= value;
        }

        public static event On.TouchShake.hook_SpriteAnimation SpriteAnimation
        {
            add => On.TouchShake.SpriteAnimation += value;
            remove => On.TouchShake.SpriteAnimation -= value;
        }

        public static event On.TouchShake.hook_tk2dAnimation tk2dAnimation
        {
            add => On.TouchShake.tk2dAnimation += value;
            remove => On.TouchShake.tk2dAnimation -= value;
        }
    }
}