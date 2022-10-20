namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for RegionSetAudio class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnRegionSetAudio
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.RegionSetAudio.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.RegionSetAudio.orig_OnTriggerEnter2D orig, RegionSetAudio self,
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
                On.RegionSetAudio.OnTriggerStay2D += OnTriggerStay2D;
            }
        }

        internal static event Delegates.OnTriggerStay2D_BeforeArgs _beforeOnTriggerStay2D;
        internal static event Delegates.OnTriggerStay2D_NormalArgs _afterOnTriggerStay2D;

        private static void OnTriggerStay2D(On.RegionSetAudio.orig_OnTriggerStay2D orig, RegionSetAudio self,
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
                On.RegionSetAudio.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_NormalArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.RegionSetAudio.orig_OnTriggerExit2D orig, RegionSetAudio self,
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_NormalArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerStay2D_BeforeArgs(Params_OnTriggerStay2D args);

        public delegate void OnTriggerStay2D_NormalArgs(Params_OnTriggerStay2D args);

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public RegionSetAudio self;
        }

        public sealed class Params_OnTriggerStay2D
        {
            public Collider2D otherCollider;
            public RegionSetAudio self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D otherCollider;
            public RegionSetAudio self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.RegionSetAudio.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.RegionSetAudio.OnTriggerEnter2D += value;
            remove => On.RegionSetAudio.OnTriggerEnter2D -= value;
        }

        public static event On.RegionSetAudio.hook_OnTriggerStay2D OnTriggerStay2D
        {
            add => On.RegionSetAudio.OnTriggerStay2D += value;
            remove => On.RegionSetAudio.OnTriggerStay2D -= value;
        }

        public static event On.RegionSetAudio.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.RegionSetAudio.OnTriggerExit2D += value;
            remove => On.RegionSetAudio.OnTriggerExit2D -= value;
        }
    }
}