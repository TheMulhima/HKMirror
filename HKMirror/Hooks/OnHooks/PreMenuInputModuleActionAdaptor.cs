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
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.PreMenuInputModuleActionAdaptor.orig_OnEnable orig,
            PreMenuInputModuleActionAdaptor self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.PreMenuInputModuleActionAdaptor.orig_OnDisable orig,
            PreMenuInputModuleActionAdaptor self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                    try
                    {
                        _afterOnDisable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.CreateActions_AfterArgs _afterCreateActions;

        private static void CreateActions(On.PreMenuInputModuleActionAdaptor.orig_CreateActions orig,
            PreMenuInputModuleActionAdaptor self)
        {
            Delegates.Params_CreateActions @params = new()
            {
                self = self
            };
            if (_beforeCreateActions != null)
                foreach (Delegates.CreateActions_BeforeArgs toInvoke in _beforeCreateActions.GetInvocationList())
                    try
                    {
                        _beforeCreateActions?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterCreateActions != null)
                foreach (Delegates.CreateActions_AfterArgs toInvoke in _afterCreateActions.GetInvocationList())
                    try
                    {
                        _afterCreateActions.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.DestroyActions_AfterArgs _afterDestroyActions;

        private static void DestroyActions(On.PreMenuInputModuleActionAdaptor.orig_DestroyActions orig,
            PreMenuInputModuleActionAdaptor self)
        {
            Delegates.Params_DestroyActions @params = new()
            {
                self = self
            };
            if (_beforeDestroyActions != null)
                foreach (Delegates.DestroyActions_BeforeArgs toInvoke in _beforeDestroyActions.GetInvocationList())
                    try
                    {
                        _beforeDestroyActions?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDestroyActions != null)
                foreach (Delegates.DestroyActions_AfterArgs toInvoke in _afterDestroyActions.GetInvocationList())
                    try
                    {
                        _afterDestroyActions.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CreateActions_AfterArgs(Params_CreateActions args);

        public delegate void CreateActions_BeforeArgs(Params_CreateActions args);

        public delegate void CreateActions_WithArgs(Action<PreMenuInputModuleActionAdaptor> orig,
            PreMenuInputModuleActionAdaptor self);

        public delegate void DestroyActions_AfterArgs(Params_DestroyActions args);

        public delegate void DestroyActions_BeforeArgs(Params_DestroyActions args);

        public delegate void DestroyActions_WithArgs(Action<PreMenuInputModuleActionAdaptor> orig,
            PreMenuInputModuleActionAdaptor self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<PreMenuInputModuleActionAdaptor> orig,
            PreMenuInputModuleActionAdaptor self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<PreMenuInputModuleActionAdaptor> orig,
            PreMenuInputModuleActionAdaptor self);

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
        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_AfterArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.CreateActions_AfterArgs CreateActions
        {
            add
            {
                HookHandler._afterCreateActions += value;
                HookHandler.HookCreateActions();
            }
            remove => HookHandler._afterCreateActions -= value;
        }

        public static event Delegates.DestroyActions_AfterArgs DestroyActions
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