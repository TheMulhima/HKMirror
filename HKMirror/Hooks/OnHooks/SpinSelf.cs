namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpinSelf class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpinSelf
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.SpinSelf.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.SpinSelf.orig_Start orig, SpinSelf self)
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

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.SpinSelf.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_NormalArgs _afterFixedUpdate;

        private static void FixedUpdate(On.SpinSelf.orig_FixedUpdate orig, SpinSelf self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            _beforeFixedUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null) _afterFixedUpdate.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_NormalArgs(Params_FixedUpdate args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Start
        {
            public SpinSelf self;
        }

        public sealed class Params_FixedUpdate
        {
            public SpinSelf self;
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

        public static event Delegates.FixedUpdate_BeforeArgs FixedUpdate
        {
            add
            {
                HookHandler._beforeFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._beforeFixedUpdate -= value;
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

        public static event Delegates.FixedUpdate_NormalArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpinSelf.hook_Start Start
        {
            add => On.SpinSelf.Start += value;
            remove => On.SpinSelf.Start -= value;
        }

        public static event On.SpinSelf.hook_FixedUpdate FixedUpdate
        {
            add => On.SpinSelf.FixedUpdate += value;
            remove => On.SpinSelf.FixedUpdate -= value;
        }
    }
}