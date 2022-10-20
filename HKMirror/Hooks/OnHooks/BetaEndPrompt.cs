namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BetaEndPrompt class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBetaEndPrompt
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.BetaEndPrompt.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.BetaEndPrompt.orig_Awake orig, BetaEndPrompt self)
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
                On.BetaEndPrompt.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;

        private static IEnumerator Start(On.BetaEndPrompt.orig_Start orig, BetaEndPrompt self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.BetaEndPrompt.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.BetaEndPrompt.orig_Update orig, BetaEndPrompt self)
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

        internal static void HookBeginEnd()
        {
            if (!HookedList.Contains("BeginEnd"))
            {
                HookedList.Add("BeginEnd");
                On.BetaEndPrompt.BeginEnd += BeginEnd;
            }
        }

        internal static event Delegates.BeginEnd_BeforeArgs _beforeBeginEnd;

        private static IEnumerator BeginEnd(On.BetaEndPrompt.orig_BeginEnd orig, BetaEndPrompt self)
        {
            Delegates.Params_BeginEnd @params = new()
            {
                self = self
            };
            _beforeBeginEnd?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void BeginEnd_BeforeArgs(Params_BeginEnd args);

        public delegate IEnumerator BeginEnd_NormalArgs(Params_BeginEnd args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate IEnumerator Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public BetaEndPrompt self;
        }

        public sealed class Params_Start
        {
            public BetaEndPrompt self;
        }

        public sealed class Params_Update
        {
            public BetaEndPrompt self;
        }

        public sealed class Params_BeginEnd
        {
            public BetaEndPrompt self;
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

        public static event Delegates.BeginEnd_BeforeArgs BeginEnd
        {
            add
            {
                HookHandler._beforeBeginEnd += value;
                HookHandler.HookBeginEnd();
            }
            remove => HookHandler._beforeBeginEnd -= value;
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

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BetaEndPrompt.hook_Awake Awake
        {
            add => On.BetaEndPrompt.Awake += value;
            remove => On.BetaEndPrompt.Awake -= value;
        }

        public static event On.BetaEndPrompt.hook_Start Start
        {
            add => On.BetaEndPrompt.Start += value;
            remove => On.BetaEndPrompt.Start -= value;
        }

        public static event On.BetaEndPrompt.hook_Update Update
        {
            add => On.BetaEndPrompt.Update += value;
            remove => On.BetaEndPrompt.Update -= value;
        }

        public static event On.BetaEndPrompt.hook_BeginEnd BeginEnd
        {
            add => On.BetaEndPrompt.BeginEnd += value;
            remove => On.BetaEndPrompt.BeginEnd -= value;
        }
    }
}