namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CorpseFungusExplode class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCorpseFungusExplode
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookLandEffects()
        {
            if (!HookedList.Contains("LandEffects"))
            {
                HookedList.Add("LandEffects");
                On.CorpseFungusExplode.LandEffects += LandEffects;
            }
        }

        internal static event Delegates.LandEffects_BeforeArgs _beforeLandEffects;
        internal static event Delegates.LandEffects_AfterArgs _afterLandEffects;

        private static void LandEffects(On.CorpseFungusExplode.orig_LandEffects orig, CorpseFungusExplode self)
        {
            Delegates.Params_LandEffects @params = new()
            {
                self = self
            };
            if (_beforeLandEffects != null)
                foreach (Delegates.LandEffects_BeforeArgs toInvoke in _beforeLandEffects.GetInvocationList())
                    try
                    {
                        _beforeLandEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterLandEffects != null)
                foreach (Delegates.LandEffects_AfterArgs toInvoke in _afterLandEffects.GetInvocationList())
                    try
                    {
                        _afterLandEffects.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoLandEffects()
        {
            if (!HookedList.Contains("DoLandEffects"))
            {
                HookedList.Add("DoLandEffects");
                On.CorpseFungusExplode.DoLandEffects += DoLandEffects;
            }
        }

        internal static event Delegates.DoLandEffects_BeforeArgs _beforeDoLandEffects;

        private static IEnumerator DoLandEffects(On.CorpseFungusExplode.orig_DoLandEffects orig,
            CorpseFungusExplode self)
        {
            Delegates.Params_DoLandEffects @params = new()
            {
                self = self
            };
            if (_beforeDoLandEffects != null)
                foreach (Delegates.DoLandEffects_BeforeArgs toInvoke in _beforeDoLandEffects.GetInvocationList())
                    try
                    {
                        _beforeDoLandEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookJitter()
        {
            if (!HookedList.Contains("Jitter"))
            {
                HookedList.Add("Jitter");
                On.CorpseFungusExplode.Jitter += Jitter;
            }
        }

        internal static event Delegates.Jitter_BeforeArgs _beforeJitter;

        private static IEnumerator Jitter(On.CorpseFungusExplode.orig_Jitter orig, CorpseFungusExplode self,
            float duration)
        {
            Delegates.Params_Jitter @params = new()
            {
                self = self, duration = duration
            };
            if (_beforeJitter != null)
                foreach (Delegates.Jitter_BeforeArgs toInvoke in _beforeJitter.GetInvocationList())
                    try
                    {
                        _beforeJitter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            duration = @params.duration;
            return orig(self, duration);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate IEnumerator DoLandEffects_AfterArgs(Params_DoLandEffects args, IEnumerator ret);

        public delegate void DoLandEffects_BeforeArgs(Params_DoLandEffects args);

        public delegate IEnumerator DoLandEffects_WithArgs(Func<CorpseFungusExplode, IEnumerator> orig,
            CorpseFungusExplode self);

        public delegate IEnumerator Jitter_AfterArgs(Params_Jitter args, IEnumerator ret);

        public delegate void Jitter_BeforeArgs(Params_Jitter args);

        public delegate IEnumerator Jitter_WithArgs(Func<CorpseFungusExplode, float, IEnumerator> orig,
            CorpseFungusExplode self, float duration);

        public delegate void LandEffects_AfterArgs(Params_LandEffects args);

        public delegate void LandEffects_BeforeArgs(Params_LandEffects args);

        public delegate void LandEffects_WithArgs(Action<CorpseFungusExplode> orig, CorpseFungusExplode self);

        public sealed class Params_LandEffects
        {
            public CorpseFungusExplode self;
        }

        public sealed class Params_DoLandEffects
        {
            public CorpseFungusExplode self;
        }

        public sealed class Params_Jitter
        {
            public float duration;
            public CorpseFungusExplode self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.LandEffects_BeforeArgs LandEffects
        {
            add
            {
                HookHandler._beforeLandEffects += value;
                HookHandler.HookLandEffects();
            }
            remove => HookHandler._beforeLandEffects -= value;
        }

        public static event Delegates.DoLandEffects_BeforeArgs DoLandEffects
        {
            add
            {
                HookHandler._beforeDoLandEffects += value;
                HookHandler.HookDoLandEffects();
            }
            remove => HookHandler._beforeDoLandEffects -= value;
        }

        public static event Delegates.Jitter_BeforeArgs Jitter
        {
            add
            {
                HookHandler._beforeJitter += value;
                HookHandler.HookJitter();
            }
            remove => HookHandler._beforeJitter -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.LandEffects_AfterArgs LandEffects
        {
            add
            {
                HookHandler._afterLandEffects += value;
                HookHandler.HookLandEffects();
            }
            remove => HookHandler._afterLandEffects -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CorpseFungusExplode.hook_LandEffects LandEffects
        {
            add => On.CorpseFungusExplode.LandEffects += value;
            remove => On.CorpseFungusExplode.LandEffects -= value;
        }

        public static event On.CorpseFungusExplode.hook_DoLandEffects DoLandEffects
        {
            add => On.CorpseFungusExplode.DoLandEffects += value;
            remove => On.CorpseFungusExplode.DoLandEffects -= value;
        }

        public static event On.CorpseFungusExplode.hook_Jitter Jitter
        {
            add => On.CorpseFungusExplode.Jitter += value;
            remove => On.CorpseFungusExplode.Jitter -= value;
        }
    }
}