namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DeactivateIfPlayerdataFalseDelayed class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDeactivateIfPlayerdataFalseDelayed
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.DeactivateIfPlayerdataFalseDelayed.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.DeactivateIfPlayerdataFalseDelayed.orig_Start orig,
            DeactivateIfPlayerdataFalseDelayed self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                    try
                    {
                        _afterStart.Invoke(@params);
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
                On.DeactivateIfPlayerdataFalseDelayed.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.DeactivateIfPlayerdataFalseDelayed.orig_OnEnable orig,
            DeactivateIfPlayerdataFalseDelayed self)
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

        internal static void HookDoCheck()
        {
            if (!HookedList.Contains("DoCheck"))
            {
                HookedList.Add("DoCheck");
                On.DeactivateIfPlayerdataFalseDelayed.DoCheck += DoCheck;
            }
        }

        internal static event Delegates.DoCheck_BeforeArgs _beforeDoCheck;
        internal static event Delegates.DoCheck_AfterArgs _afterDoCheck;

        private static void DoCheck(On.DeactivateIfPlayerdataFalseDelayed.orig_DoCheck orig,
            DeactivateIfPlayerdataFalseDelayed self)
        {
            Delegates.Params_DoCheck @params = new()
            {
                self = self
            };
            if (_beforeDoCheck != null)
                foreach (Delegates.DoCheck_BeforeArgs toInvoke in _beforeDoCheck.GetInvocationList())
                    try
                    {
                        _beforeDoCheck?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoCheck != null)
                foreach (Delegates.DoCheck_AfterArgs toInvoke in _afterDoCheck.GetInvocationList())
                    try
                    {
                        _afterDoCheck.Invoke(@params);
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
        public delegate void DoCheck_AfterArgs(Params_DoCheck args);

        public delegate void DoCheck_BeforeArgs(Params_DoCheck args);

        public delegate void DoCheck_WithArgs(Action<DeactivateIfPlayerdataFalseDelayed> orig,
            DeactivateIfPlayerdataFalseDelayed self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<DeactivateIfPlayerdataFalseDelayed> orig,
            DeactivateIfPlayerdataFalseDelayed self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<DeactivateIfPlayerdataFalseDelayed> orig,
            DeactivateIfPlayerdataFalseDelayed self);

        public sealed class Params_Start
        {
            public DeactivateIfPlayerdataFalseDelayed self;
        }

        public sealed class Params_OnEnable
        {
            public DeactivateIfPlayerdataFalseDelayed self;
        }

        public sealed class Params_DoCheck
        {
            public DeactivateIfPlayerdataFalseDelayed self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
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
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.DoCheck_AfterArgs DoCheck
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
        public static event On.DeactivateIfPlayerdataFalseDelayed.hook_Start Start
        {
            add => On.DeactivateIfPlayerdataFalseDelayed.Start += value;
            remove => On.DeactivateIfPlayerdataFalseDelayed.Start -= value;
        }

        public static event On.DeactivateIfPlayerdataFalseDelayed.hook_OnEnable OnEnable
        {
            add => On.DeactivateIfPlayerdataFalseDelayed.OnEnable += value;
            remove => On.DeactivateIfPlayerdataFalseDelayed.OnEnable -= value;
        }

        public static event On.DeactivateIfPlayerdataFalseDelayed.hook_DoCheck DoCheck
        {
            add => On.DeactivateIfPlayerdataFalseDelayed.DoCheck += value;
            remove => On.DeactivateIfPlayerdataFalseDelayed.DoCheck -= value;
        }
    }
}