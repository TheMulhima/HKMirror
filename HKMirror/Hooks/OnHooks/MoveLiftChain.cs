using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for MoveLiftChain class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMoveLiftChain
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookApply()
        {
            if (!HookedList.Contains("Apply"))
            {
                HookedList.Add("Apply");
                On.MoveLiftChain.Apply += Apply;
            }
        }

        internal static event Delegates.Apply_BeforeArgs _beforeApply;
        internal static event Delegates.Apply_AfterArgs _afterApply;

        private static void Apply(On.MoveLiftChain.orig_Apply orig, MoveLiftChain self, LiftChain liftChain)
        {
            Delegates.Params_Apply @params = new()
            {
                self = self, liftChain = liftChain
            };
            if (_beforeApply != null)
            {
                foreach (Delegates.Apply_BeforeArgs toInvoke in _beforeApply.GetInvocationList())
                {
                    try
                    {
                        _beforeApply?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            liftChain = @params.liftChain;
            orig(self, liftChain);
            if (_afterApply != null)
            {
                foreach (Delegates.Apply_AfterArgs toInvoke in _afterApply.GetInvocationList())
                {
                    try
                    {
                        _afterApply.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Apply
        {
            public MoveLiftChain self;
            public LiftChain liftChain;
        }

        public delegate void Apply_BeforeArgs(Params_Apply args);

        public delegate void Apply_AfterArgs(Params_Apply args);

        public delegate void Apply_WithArgs(Action<MoveLiftChain, LiftChain> orig, MoveLiftChain self,
            LiftChain liftChain);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Apply_BeforeArgs Apply
        {
            add
            {
                HookHandler._beforeApply += value;
                HookHandler.HookApply();
            }
            remove => HookHandler._beforeApply -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Apply_AfterArgs Apply
        {
            add
            {
                HookHandler._afterApply += value;
                HookHandler.HookApply();
            }
            remove => HookHandler._afterApply -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MoveLiftChain.hook_Apply Apply
        {
            add => On.MoveLiftChain.Apply += value;
            remove => On.MoveLiftChain.Apply -= value;
        }
    }
}