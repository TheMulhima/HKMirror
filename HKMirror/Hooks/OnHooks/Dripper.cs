namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Dripper class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDripper
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.Dripper.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.Dripper.orig_OnEnable orig, Dripper self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.Dripper.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.Dripper.orig_OnDisable orig, Dripper self)
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

        internal static void HookBehaviour()
        {
            if (!HookedList.Contains("Behaviour"))
            {
                HookedList.Add("Behaviour");
                On.Dripper.Behaviour += Behaviour;
            }
        }

        internal static event Delegates.Behaviour_BeforeArgs _beforeBehaviour;

        private static IEnumerator Behaviour(On.Dripper.orig_Behaviour orig, Dripper self)
        {
            Delegates.Params_Behaviour @params = new()
            {
                self = self
            };
            _beforeBehaviour?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Behaviour_BeforeArgs(Params_Behaviour args);

        public delegate IEnumerator Behaviour_NormalArgs(Params_Behaviour args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public sealed class Params_OnEnable
        {
            public Dripper self;
        }

        public sealed class Params_OnDisable
        {
            public Dripper self;
        }

        public sealed class Params_Behaviour
        {
            public Dripper self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
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

        public static event Delegates.Behaviour_BeforeArgs Behaviour
        {
            add
            {
                HookHandler._beforeBehaviour += value;
                HookHandler.HookBehaviour();
            }
            remove => HookHandler._beforeBehaviour -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
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
        public static event On.Dripper.hook_OnEnable OnEnable
        {
            add => On.Dripper.OnEnable += value;
            remove => On.Dripper.OnEnable -= value;
        }

        public static event On.Dripper.hook_OnDisable OnDisable
        {
            add => On.Dripper.OnDisable += value;
            remove => On.Dripper.OnDisable -= value;
        }

        public static event On.Dripper.hook_Behaviour Behaviour
        {
            add => On.Dripper.Behaviour += value;
            remove => On.Dripper.Behaviour -= value;
        }
    }
}