namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MakeSkippable class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMakeSkippable
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.MakeSkippable.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.MakeSkippable.orig_Awake orig, MakeSkippable self)
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
                On.MakeSkippable.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.MakeSkippable.orig_Start orig, MakeSkippable self)
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

        internal static void HookUnlockSkip()
        {
            if (!HookedList.Contains("UnlockSkip"))
            {
                HookedList.Add("UnlockSkip");
                On.MakeSkippable.UnlockSkip += UnlockSkip;
            }
        }

        internal static event Delegates.UnlockSkip_BeforeArgs _beforeUnlockSkip;
        internal static event Delegates.UnlockSkip_NormalArgs _afterUnlockSkip;

        private static void UnlockSkip(On.MakeSkippable.orig_UnlockSkip orig, MakeSkippable self)
        {
            Delegates.Params_UnlockSkip @params = new()
            {
                self = self
            };
            _beforeUnlockSkip?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUnlockSkip != null) _afterUnlockSkip.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void UnlockSkip_BeforeArgs(Params_UnlockSkip args);

        public delegate void UnlockSkip_NormalArgs(Params_UnlockSkip args);

        public sealed class Params_Awake
        {
            public MakeSkippable self;
        }

        public sealed class Params_Start
        {
            public MakeSkippable self;
        }

        public sealed class Params_UnlockSkip
        {
            public MakeSkippable self;
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

        public static event Delegates.UnlockSkip_BeforeArgs UnlockSkip
        {
            add
            {
                HookHandler._beforeUnlockSkip += value;
                HookHandler.HookUnlockSkip();
            }
            remove => HookHandler._beforeUnlockSkip -= value;
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

        public static event Delegates.UnlockSkip_NormalArgs UnlockSkip
        {
            add
            {
                HookHandler._afterUnlockSkip += value;
                HookHandler.HookUnlockSkip();
            }
            remove => HookHandler._afterUnlockSkip -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MakeSkippable.hook_Awake Awake
        {
            add => On.MakeSkippable.Awake += value;
            remove => On.MakeSkippable.Awake -= value;
        }

        public static event On.MakeSkippable.hook_Start Start
        {
            add => On.MakeSkippable.Start += value;
            remove => On.MakeSkippable.Start -= value;
        }

        public static event On.MakeSkippable.hook_UnlockSkip UnlockSkip
        {
            add => On.MakeSkippable.UnlockSkip += value;
            remove => On.MakeSkippable.UnlockSkip -= value;
        }
    }
}