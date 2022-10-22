namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Drip class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDrip
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.Drip.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.Drip.orig_Awake orig, Drip self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.Drip.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.Drip.orig_Start orig, Drip self)
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

        internal static void HookDripRoutine()
        {
            if (!HookedList.Contains("DripRoutine"))
            {
                HookedList.Add("DripRoutine");
                On.Drip.DripRoutine += DripRoutine;
            }
        }

        internal static event Delegates.DripRoutine_BeforeArgs _beforeDripRoutine;

        private static IEnumerator DripRoutine(On.Drip.orig_DripRoutine orig, Drip self)
        {
            Delegates.Params_DripRoutine @params = new()
            {
                self = self
            };
            if (_beforeDripRoutine != null)
                foreach (Delegates.DripRoutine_BeforeArgs toInvoke in _beforeDripRoutine.GetInvocationList())
                    try
                    {
                        _beforeDripRoutine?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookDropDrip()
        {
            if (!HookedList.Contains("DropDrip"))
            {
                HookedList.Add("DropDrip");
                On.Drip.DropDrip += DropDrip;
            }
        }

        internal static event Delegates.DropDrip_BeforeArgs _beforeDropDrip;

        private static IEnumerator DropDrip(On.Drip.orig_DropDrip orig, Drip self)
        {
            Delegates.Params_DropDrip @params = new()
            {
                self = self
            };
            if (_beforeDropDrip != null)
                foreach (Delegates.DropDrip_BeforeArgs toInvoke in _beforeDropDrip.GetInvocationList())
                    try
                    {
                        _beforeDropDrip?.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<Drip> orig, Drip self);

        public delegate IEnumerator DripRoutine_AfterArgs(Params_DripRoutine args,
            IEnumerator ret);

        public delegate void DripRoutine_BeforeArgs(Params_DripRoutine args);

        public delegate IEnumerator DripRoutine_WithArgs(
            Func<Drip, IEnumerator> orig, Drip self);

        public delegate IEnumerator DropDrip_AfterArgs(Params_DropDrip args,
            IEnumerator ret);

        public delegate void DropDrip_BeforeArgs(Params_DropDrip args);

        public delegate IEnumerator DropDrip_WithArgs(
            Func<Drip, IEnumerator> orig, Drip self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<Drip> orig, Drip self);

        public sealed class Params_Awake
        {
            public Drip self;
        }

        public sealed class Params_Start
        {
            public Drip self;
        }

        public sealed class Params_DripRoutine
        {
            public Drip self;
        }

        public sealed class Params_DropDrip
        {
            public Drip self;
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

        public static event Delegates.DripRoutine_BeforeArgs DripRoutine
        {
            add
            {
                HookHandler._beforeDripRoutine += value;
                HookHandler.HookDripRoutine();
            }
            remove => HookHandler._beforeDripRoutine -= value;
        }

        public static event Delegates.DropDrip_BeforeArgs DropDrip
        {
            add
            {
                HookHandler._beforeDropDrip += value;
                HookHandler.HookDropDrip();
            }
            remove => HookHandler._beforeDropDrip -= value;
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

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.Drip.hook_Awake Awake
        {
            add => On.Drip.Awake += value;
            remove => On.Drip.Awake -= value;
        }

        public static event On.Drip.hook_Start Start
        {
            add => On.Drip.Start += value;
            remove => On.Drip.Start -= value;
        }

        public static event On.Drip.hook_DripRoutine DripRoutine
        {
            add => On.Drip.DripRoutine += value;
            remove => On.Drip.DripRoutine -= value;
        }

        public static event On.Drip.hook_DropDrip DropDrip
        {
            add => On.Drip.DropDrip += value;
            remove => On.Drip.DropDrip -= value;
        }
    }
}