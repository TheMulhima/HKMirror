namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ControllerButtonLabel class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnControllerButtonLabel
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.ControllerButtonLabel.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.ControllerButtonLabel.orig_Awake orig, ControllerButtonLabel self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.ControllerButtonLabel.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.ControllerButtonLabel.orig_OnEnable orig, ControllerButtonLabel self)
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

        internal static void HookShowCurrentBinding()
        {
            if (!HookedList.Contains("ShowCurrentBinding"))
            {
                HookedList.Add("ShowCurrentBinding");
                On.ControllerButtonLabel.ShowCurrentBinding += ShowCurrentBinding;
            }
        }

        internal static event Delegates.ShowCurrentBinding_BeforeArgs _beforeShowCurrentBinding;
        internal static event Delegates.ShowCurrentBinding_AfterArgs _afterShowCurrentBinding;

        private static void ShowCurrentBinding(On.ControllerButtonLabel.orig_ShowCurrentBinding orig,
            ControllerButtonLabel self)
        {
            Delegates.Params_ShowCurrentBinding @params = new()
            {
                self = self
            };
            if (_beforeShowCurrentBinding != null)
                foreach (Delegates.ShowCurrentBinding_BeforeArgs toInvoke in
                         _beforeShowCurrentBinding.GetInvocationList())
                    try
                    {
                        _beforeShowCurrentBinding?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterShowCurrentBinding != null)
                foreach (Delegates.ShowCurrentBinding_AfterArgs toInvoke in
                         _afterShowCurrentBinding.GetInvocationList())
                    try
                    {
                        _afterShowCurrentBinding.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<ControllerButtonLabel> orig, ControllerButtonLabel self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<ControllerButtonLabel> orig, ControllerButtonLabel self);

        public delegate void ShowCurrentBinding_AfterArgs(Params_ShowCurrentBinding args);

        public delegate void ShowCurrentBinding_BeforeArgs(Params_ShowCurrentBinding args);

        public delegate void
            ShowCurrentBinding_WithArgs(Action<ControllerButtonLabel> orig, ControllerButtonLabel self);

        public sealed class Params_Awake
        {
            public ControllerButtonLabel self;
        }

        public sealed class Params_OnEnable
        {
            public ControllerButtonLabel self;
        }

        public sealed class Params_ShowCurrentBinding
        {
            public ControllerButtonLabel self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.ShowCurrentBinding_BeforeArgs ShowCurrentBinding
        {
            add
            {
                HookHandler._beforeShowCurrentBinding += value;
                HookHandler.HookShowCurrentBinding();
            }
            remove => HookHandler._beforeShowCurrentBinding -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.ShowCurrentBinding_AfterArgs ShowCurrentBinding
        {
            add
            {
                HookHandler._afterShowCurrentBinding += value;
                HookHandler.HookShowCurrentBinding();
            }
            remove => HookHandler._afterShowCurrentBinding -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.ControllerButtonLabel.hook_Awake Awake
        {
            add => On.ControllerButtonLabel.Awake += value;
            remove => On.ControllerButtonLabel.Awake -= value;
        }

        public static event On.ControllerButtonLabel.hook_OnEnable OnEnable
        {
            add => On.ControllerButtonLabel.OnEnable += value;
            remove => On.ControllerButtonLabel.OnEnable -= value;
        }

        public static event On.ControllerButtonLabel.hook_ShowCurrentBinding ShowCurrentBinding
        {
            add => On.ControllerButtonLabel.ShowCurrentBinding += value;
            remove => On.ControllerButtonLabel.ShowCurrentBinding -= value;
        }
    }
}