namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for LookAnimNPC class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnLookAnimNPC
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.LookAnimNPC.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.LookAnimNPC.orig_Awake orig, LookAnimNPC self)
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
                On.LookAnimNPC.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.LookAnimNPC.orig_Start orig, LookAnimNPC self)
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

        internal static void HookOnDrawGizmosSelected()
        {
            if (!HookedList.Contains("OnDrawGizmosSelected"))
            {
                HookedList.Add("OnDrawGizmosSelected");
                On.LookAnimNPC.OnDrawGizmosSelected += OnDrawGizmosSelected;
            }
        }

        internal static event Delegates.OnDrawGizmosSelected_BeforeArgs _beforeOnDrawGizmosSelected;
        internal static event Delegates.OnDrawGizmosSelected_NormalArgs _afterOnDrawGizmosSelected;

        private static void OnDrawGizmosSelected(On.LookAnimNPC.orig_OnDrawGizmosSelected orig, LookAnimNPC self)
        {
            Delegates.Params_OnDrawGizmosSelected @params = new()
            {
                self = self
            };
            _beforeOnDrawGizmosSelected?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnDrawGizmosSelected != null) _afterOnDrawGizmosSelected.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.LookAnimNPC.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.LookAnimNPC.orig_Update orig, LookAnimNPC self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void OnDrawGizmosSelected_BeforeArgs(Params_OnDrawGizmosSelected args);

        public delegate void OnDrawGizmosSelected_NormalArgs(Params_OnDrawGizmosSelected args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public LookAnimNPC self;
        }

        public sealed class Params_Start
        {
            public LookAnimNPC self;
        }

        public sealed class Params_OnDrawGizmosSelected
        {
            public LookAnimNPC self;
        }

        public sealed class Params_Update
        {
            public LookAnimNPC self;
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

        public static event Delegates.OnDrawGizmosSelected_BeforeArgs OnDrawGizmosSelected
        {
            add
            {
                HookHandler._beforeOnDrawGizmosSelected += value;
                HookHandler.HookOnDrawGizmosSelected();
            }
            remove => HookHandler._beforeOnDrawGizmosSelected -= value;
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

        public static event Delegates.OnDrawGizmosSelected_NormalArgs OnDrawGizmosSelected
        {
            add
            {
                HookHandler._afterOnDrawGizmosSelected += value;
                HookHandler.HookOnDrawGizmosSelected();
            }
            remove => HookHandler._afterOnDrawGizmosSelected -= value;
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
        public static event On.LookAnimNPC.hook_Awake Awake
        {
            add => On.LookAnimNPC.Awake += value;
            remove => On.LookAnimNPC.Awake -= value;
        }

        public static event On.LookAnimNPC.hook_Start Start
        {
            add => On.LookAnimNPC.Start += value;
            remove => On.LookAnimNPC.Start -= value;
        }

        public static event On.LookAnimNPC.hook_OnDrawGizmosSelected OnDrawGizmosSelected
        {
            add => On.LookAnimNPC.OnDrawGizmosSelected += value;
            remove => On.LookAnimNPC.OnDrawGizmosSelected -= value;
        }

        public static event On.LookAnimNPC.hook_Update Update
        {
            add => On.LookAnimNPC.Update += value;
            remove => On.LookAnimNPC.Update -= value;
        }
    }
}