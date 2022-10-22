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
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.Dripper.orig_OnEnable orig, Dripper self)
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
                On.Dripper.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.Dripper.orig_OnDisable orig, Dripper self)
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
            if (_beforeBehaviour != null)
                foreach (Delegates.Behaviour_BeforeArgs toInvoke in _beforeBehaviour.GetInvocationList())
                    try
                    {
                        _beforeBehaviour?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate IEnumerator Behaviour_AfterArgs(Params_Behaviour args, IEnumerator ret);

        public delegate void Behaviour_BeforeArgs(Params_Behaviour args);

        public delegate IEnumerator Behaviour_WithArgs(Func<Dripper, IEnumerator> orig, Dripper self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<Dripper> orig, Dripper self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<Dripper> orig, Dripper self);

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