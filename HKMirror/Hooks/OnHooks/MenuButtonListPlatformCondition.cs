using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for MenuButtonListPlatformCondition class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuButtonListPlatformCondition
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookIsFulfilled()
        {
            if (!HookedList.Contains("IsFulfilled"))
            {
                HookedList.Add("IsFulfilled");
                On.MenuButtonListPlatformCondition.IsFulfilled += IsFulfilled;
            }
        }

        internal static event Delegates.IsFulfilled_BeforeArgs _beforeIsFulfilled;
        internal static event Delegates.IsFulfilled_AfterArgs _afterIsFulfilled;

        private static bool IsFulfilled(On.MenuButtonListPlatformCondition.orig_IsFulfilled orig,
            MenuButtonListPlatformCondition self)
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
            public MenuButtonListPlatformCondition self;
        }

        public delegate void IsFulfilled_BeforeArgs(Params_IsFulfilled args);

        public delegate bool IsFulfilled_AfterArgs(Params_IsFulfilled args, bool ret);

        public delegate bool IsFulfilled_WithArgs(Func<MenuButtonListPlatformCondition, bool> orig,
            MenuButtonListPlatformCondition self);
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
        public static event On.MenuButtonListPlatformCondition.hook_IsFulfilled IsFulfilled
        {
            add => On.MenuButtonListPlatformCondition.IsFulfilled += value;
            remove => On.MenuButtonListPlatformCondition.IsFulfilled -= value;
        }
    }
}