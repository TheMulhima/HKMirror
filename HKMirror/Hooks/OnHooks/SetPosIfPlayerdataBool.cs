namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetPosIfPlayerdataBool class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetPosIfPlayerdataBool
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.SetPosIfPlayerdataBool.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.SetPosIfPlayerdataBool.orig_OnEnable orig, SetPosIfPlayerdataBool self)
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
                On.SetPosIfPlayerdataBool.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.SetPosIfPlayerdataBool.orig_OnDisable orig, SetPosIfPlayerdataBool self)
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

        internal static void HookDoCheck()
        {
            if (!HookedList.Contains("DoCheck"))
            {
                HookedList.Add("DoCheck");
                On.SetPosIfPlayerdataBool.DoCheck += DoCheck;
            }
        }

        internal static event Delegates.DoCheck_BeforeArgs _beforeDoCheck;
        internal static event Delegates.DoCheck_NormalArgs _afterDoCheck;

        private static void DoCheck(On.SetPosIfPlayerdataBool.orig_DoCheck orig, SetPosIfPlayerdataBool self)
        {
            Delegates.Params_DoCheck @params = new()
            {
                self = self
            };
            _beforeDoCheck?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoCheck != null) _afterDoCheck.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoCheck_BeforeArgs(Params_DoCheck args);

        public delegate void DoCheck_NormalArgs(Params_DoCheck args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public sealed class Params_OnEnable
        {
            public SetPosIfPlayerdataBool self;
        }

        public sealed class Params_OnDisable
        {
            public SetPosIfPlayerdataBool self;
        }

        public sealed class Params_DoCheck
        {
            public SetPosIfPlayerdataBool self;
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

        public static event Delegates.DoCheck_BeforeArgs DoCheck
        {
            add
            {
                HookHandler._beforeDoCheck += value;
                HookHandler.HookDoCheck();
            }
            remove => HookHandler._beforeDoCheck -= value;
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

        public static event Delegates.DoCheck_NormalArgs DoCheck
        {
            add
            {
                HookHandler._afterDoCheck += value;
                HookHandler.HookDoCheck();
            }
            remove => HookHandler._afterDoCheck -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SetPosIfPlayerdataBool.hook_OnEnable OnEnable
        {
            add => On.SetPosIfPlayerdataBool.OnEnable += value;
            remove => On.SetPosIfPlayerdataBool.OnEnable -= value;
        }

        public static event On.SetPosIfPlayerdataBool.hook_OnDisable OnDisable
        {
            add => On.SetPosIfPlayerdataBool.OnDisable += value;
            remove => On.SetPosIfPlayerdataBool.OnDisable -= value;
        }

        public static event On.SetPosIfPlayerdataBool.hook_DoCheck DoCheck
        {
            add => On.SetPosIfPlayerdataBool.DoCheck += value;
            remove => On.SetPosIfPlayerdataBool.DoCheck -= value;
        }
    }
}