using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for MenuButtonControllerListCondition class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuButtonControllerListCondition
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookIsFulfilled()
        {
            if (!HookedList.Contains("IsFulfilled"))
            {
                HookedList.Add("IsFulfilled");
                On.MenuButtonControllerListCondition.IsFulfilled += IsFulfilled;
            }
        }

        internal static event Delegates.IsFulfilled_BeforeArgs _beforeIsFulfilled;
        internal static event Delegates.IsFulfilled_AfterArgs _afterIsFulfilled;

        private static bool IsFulfilled(On.MenuButtonControllerListCondition.orig_IsFulfilled orig,
            MenuButtonControllerListCondition self)
        {
            Delegates.Params_IsFulfilled @params = new()
            {
                self = self
            };
            if (_beforeIsFulfilled != null)
            {
                foreach (Delegates.IsFulfilled_BeforeArgs toInvoke in _beforeIsFulfilled.GetInvocationList())
                {
                    try
                    {
                        _beforeIsFulfilled?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterIsFulfilled != null)
            {
                foreach (Delegates.IsFulfilled_AfterArgs toInvoke in _afterIsFulfilled.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterIsFulfilled.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_IsFulfilled
        {
            public MenuButtonControllerListCondition self;
        }

        public delegate void IsFulfilled_BeforeArgs(Params_IsFulfilled args);

        public delegate bool IsFulfilled_AfterArgs(Params_IsFulfilled args, bool ret);

        public delegate bool IsFulfilled_WithArgs(Func<MenuButtonControllerListCondition, bool> orig,
            MenuButtonControllerListCondition self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.IsFulfilled_BeforeArgs IsFulfilled
        {
            add
            {
                HookHandler._beforeIsFulfilled += value;
                HookHandler.HookIsFulfilled();
            }
            remove => HookHandler._beforeIsFulfilled -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.IsFulfilled_AfterArgs IsFulfilled
        {
            add
            {
                HookHandler._afterIsFulfilled += value;
                HookHandler.HookIsFulfilled();
            }
            remove => HookHandler._afterIsFulfilled -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MenuButtonControllerListCondition.hook_IsFulfilled IsFulfilled
        {
            add => On.MenuButtonControllerListCondition.IsFulfilled += value;
            remove => On.MenuButtonControllerListCondition.IsFulfilled -= value;
        }
    }
}