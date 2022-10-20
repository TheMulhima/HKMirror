namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PreMenuInputModuleActionAdaptor class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPreMenuInputModuleActionAdaptor
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.PreMenuInputModuleActionAdaptor.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.PreMenuInputModuleActionAdaptor.orig_OnEnable orig,
            PreMenuInputModuleActionAdaptor self)
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
                On.PreMenuInputModuleActionAdaptor.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.PreMenuInputModuleActionAdaptor.orig_OnDisable orig,
            PreMenuInputModuleActionAdaptor self)
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

        internal static void HookCreateActions()
        {
            if (!HookedList.Contains("CreateActions"))
            {
                HookedList.Add("CreateActions");
                On.PreMenuInputModuleActionAdaptor.CreateActions += CreateActions;
            }
        }

        internal static event Delegates.CreateActions_BeforeArgs _beforeCreateActions;
        internal static event Delegates.CreateActions_NormalArgs _afterCreateActions;

        private static void CreateActions(On.PreMenuInputModuleActionAdaptor.orig_CreateActions orig,
            PreMenuInputModuleActionAdaptor self)
        {
            Delegates.Params_CreateActions @params = new()
            {
                self = self
            };
            _beforeCreateActions?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterCreateActions != null) _afterCreateActions.Invoke(@params);
        }

        internal static void HookDestroyActions()
        {
            if (!HookedList.Contains("DestroyActions"))
            {
                HookedList.Add("DestroyActions");
                On.PreMenuInputModuleActionAdaptor.DestroyActions += DestroyActions;
            }
        }

        internal static event Delegates.DestroyActions_BeforeArgs _beforeDestroyActions;
        internal static event Delegates.DestroyActions_NormalArgs _afterDestroyActions;

        private static void DestroyActions(On.PreMenuInputModuleActionAdaptor.orig_DestroyActions orig,
            PreMenuInputModuleActionAdaptor self)
        {
            Delegates.Params_DestroyActions @params = new()
            {
                self = self
            };
            _beforeDestroyActions?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDestroyActions != null) _afterDestroyActions.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CreateActions_BeforeArgs(Params_CreateActions args);

        public delegate void CreateActions_NormalArgs(Params_CreateActions args);

        public delegate void DestroyActions_BeforeArgs(Params_DestroyActions args);

        public delegate void DestroyActions_NormalArgs(Params_DestroyActions args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public sealed class Params_OnEnable
        {
            public PreMenuInputModuleActionAdaptor self;
        }

        public sealed class Params_OnDisable
        {
            public PreMenuInputModuleActionAdaptor self;
        }

        public sealed class Params_CreateActions
        {
            public PreMenuInputModuleActionAdaptor self;
        }

        public sealed class Params_DestroyActions
        {
            public PreMenuInputModuleActionAdaptor self;
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

        public static event Delegates.CreateActions_BeforeArgs CreateActions
        {
            add
            {
                HookHandler._beforeCreateActions += value;
                HookHandler.HookCreateActions();
            }
            remove => HookHandler._beforeCreateActions -= value;
        }

        public static event Delegates.DestroyActions_BeforeArgs DestroyActions
        {
            add
            {
                HookHandler._beforeDestroyActions += value;
                HookHandler.HookDestroyActions();
            }
            remove => HookHandler._beforeDestroyActions -= value;
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

        public static event Delegates.CreateActions_NormalArgs CreateActions
        {
            add
            {
                HookHandler._afterCreateActions += value;
                HookHandler.HookCreateActions();
            }
            remove => HookHandler._afterCreateActions -= value;
        }

        public static event Delegates.DestroyActions_NormalArgs DestroyActions
        {
            add
            {
                HookHandler._afterDestroyActions += value;
                HookHandler.HookDestroyActions();
            }
            remove => HookHandler._afterDestroyActions -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PreMenuInputModuleActionAdaptor.hook_OnEnable OnEnable
        {
            add => On.PreMenuInputModuleActionAdaptor.OnEnable += value;
            remove => On.PreMenuInputModuleActionAdaptor.OnEnable -= value;
        }

        public static event On.PreMenuInputModuleActionAdaptor.hook_OnDisable OnDisable
        {
            add => On.PreMenuInputModuleActionAdaptor.OnDisable += value;
            remove => On.PreMenuInputModuleActionAdaptor.OnDisable -= value;
        }

        public static event On.PreMenuInputModuleActionAdaptor.hook_CreateActions CreateActions
        {
            add => On.PreMenuInputModuleActionAdaptor.CreateActions += value;
            remove => On.PreMenuInputModuleActionAdaptor.CreateActions -= value;
        }

        public static event On.PreMenuInputModuleActionAdaptor.hook_DestroyActions DestroyActions
        {
            add => On.PreMenuInputModuleActionAdaptor.DestroyActions += value;
            remove => On.PreMenuInputModuleActionAdaptor.DestroyActions -= value;
        }
    }
}