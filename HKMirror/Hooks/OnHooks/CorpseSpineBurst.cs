using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for CorpseSpineBurst class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCorpseSpineBurst
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookLandEffects()
        {
            if (!HookedList.Contains("LandEffects"))
            {
                HookedList.Add("LandEffects");
                On.CorpseSpineBurst.LandEffects += LandEffects;
            }
        }

        internal static event Delegates.LandEffects_BeforeArgs _beforeLandEffects;
        internal static event Delegates.LandEffects_AfterArgs _afterLandEffects;

        private static void LandEffects(On.CorpseSpineBurst.orig_LandEffects orig, CorpseSpineBurst self)
        {
            Delegates.Params_LandEffects @params = new()
            {
                self = self
            };
            if (_beforeLandEffects != null)
            {
                foreach (Delegates.LandEffects_BeforeArgs toInvoke in _beforeLandEffects.GetInvocationList())
                {
                    try
                    {
                        _beforeLandEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterLandEffects != null)
            {
                foreach (Delegates.LandEffects_AfterArgs toInvoke in _afterLandEffects.GetInvocationList())
                {
                    try
                    {
                        _afterLandEffects.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoLandEffects()
        {
            if (!HookedList.Contains("DoLandEffects"))
            {
                HookedList.Add("DoLandEffects");
                On.CorpseSpineBurst.DoLandEffects += DoLandEffects;
            }
        }

        internal static event Delegates.DoLandEffects_BeforeArgs _beforeDoLandEffects;

        private static System.Collections.IEnumerator DoLandEffects(On.CorpseSpineBurst.orig_DoLandEffects orig,
            CorpseSpineBurst self, bool burst)
        {
            Delegates.Params_DoLandEffects @params = new()
            {
                self = self, burst = burst
            };
            if (_beforeDoLandEffects != null)
            {
                foreach (Delegates.DoLandEffects_BeforeArgs toInvoke in _beforeDoLandEffects.GetInvocationList())
                {
                    try
                    {
                        _beforeDoLandEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            burst = @params.burst;
            return orig(self, burst);
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_LandEffects
        {
            public CorpseSpineBurst self;
        }

        public delegate void LandEffects_BeforeArgs(Params_LandEffects args);

        public delegate void LandEffects_AfterArgs(Params_LandEffects args);

        public delegate void LandEffects_WithArgs(Action<CorpseSpineBurst> orig, CorpseSpineBurst self);

        public sealed class Params_DoLandEffects
        {
            public CorpseSpineBurst self;
            public bool burst;
        }

        public delegate void DoLandEffects_BeforeArgs(Params_DoLandEffects args);

        public delegate System.Collections.IEnumerator DoLandEffects_AfterArgs(Params_DoLandEffects args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator DoLandEffects_WithArgs(
            Func<CorpseSpineBurst, bool, System.Collections.IEnumerator> orig, CorpseSpineBurst self, bool burst);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CorpseSpineBurst.hook_LandEffects LandEffects
        {
            add => On.CorpseSpineBurst.LandEffects += value;
            remove => On.CorpseSpineBurst.LandEffects -= value;
        }

        public static event On.CorpseSpineBurst.hook_DoLandEffects DoLandEffects
        {
            add => On.CorpseSpineBurst.DoLandEffects += value;
            remove => On.CorpseSpineBurst.DoLandEffects -= value;
        }
    }
}