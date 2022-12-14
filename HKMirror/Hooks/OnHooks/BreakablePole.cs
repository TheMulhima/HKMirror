namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BreakablePole class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBreakablePole
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.BreakablePole.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.BreakablePole.orig_Reset orig, BreakablePole self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
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
                On.BreakablePole.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.BreakablePole.orig_Start orig, BreakablePole self)
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

        internal static void HookHit()
        {
            if (!HookedList.Contains("Hit"))
            {
                HookedList.Add("Hit");
                On.BreakablePole.Hit += Hit;
            }
        }

        internal static event Delegates.Hit_BeforeArgs _beforeHit;
        internal static event Delegates.Hit_AfterArgs _afterHit;

        private static void Hit(On.BreakablePole.orig_Hit orig, BreakablePole self, HitInstance damageInstance)
        {
            Delegates.Params_Hit @params = new()
            {
                self = self, damageInstance = damageInstance
            };
            if (_beforeHit != null)
                foreach (Delegates.Hit_BeforeArgs toInvoke in _beforeHit.GetInvocationList())
                    try
                    {
                        _beforeHit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            damageInstance = @params.damageInstance;
            orig(self, damageInstance);
            if (_afterHit != null)
                foreach (Delegates.Hit_AfterArgs toInvoke in _afterHit.GetInvocationList())
                    try
                    {
                        _afterHit.Invoke(@params);
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
        public delegate void Hit_AfterArgs(Params_Hit args);

        public delegate void Hit_BeforeArgs(Params_Hit args);

        public delegate void Hit_WithArgs(Action<BreakablePole, HitInstance> orig, BreakablePole self,
            HitInstance damageInstance);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<BreakablePole> orig, BreakablePole self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<BreakablePole> orig, BreakablePole self);

        public sealed class Params_Reset
        {
            public BreakablePole self;
        }

        public sealed class Params_Start
        {
            public BreakablePole self;
        }

        public sealed class Params_Hit
        {
            public HitInstance damageInstance;
            public BreakablePole self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
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

        public static event Delegates.Hit_BeforeArgs Hit
        {
            add
            {
                HookHandler._beforeHit += value;
                HookHandler.HookHit();
            }
            remove => HookHandler._beforeHit -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
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

        public static event Delegates.Hit_AfterArgs Hit
        {
            add
            {
                HookHandler._afterHit += value;
                HookHandler.HookHit();
            }
            remove => HookHandler._afterHit -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BreakablePole.hook_Reset Reset
        {
            add => On.BreakablePole.Reset += value;
            remove => On.BreakablePole.Reset -= value;
        }

        public static event On.BreakablePole.hook_Start Start
        {
            add => On.BreakablePole.Start += value;
            remove => On.BreakablePole.Start -= value;
        }

        public static event On.BreakablePole.hook_Hit Hit
        {
            add => On.BreakablePole.Hit += value;
            remove => On.BreakablePole.Hit -= value;
        }
    }
}