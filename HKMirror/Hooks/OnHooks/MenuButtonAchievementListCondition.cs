namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MenuButtonAchievementListCondition class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuButtonAchievementListCondition
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookIsFulfilled()
        {
            if (!HookedList.Contains("IsFulfilled"))
            {
                HookedList.Add("IsFulfilled");
                On.MenuButtonAchievementListCondition.IsFulfilled += IsFulfilled;
            }
        }

        internal static event Delegates.IsFulfilled_BeforeArgs _beforeIsFulfilled;
        internal static event Delegates.IsFulfilled_NormalArgs _afterIsFulfilled;

        private static bool IsFulfilled(On.MenuButtonAchievementListCondition.orig_IsFulfilled orig,
            MenuButtonAchievementListCondition self)
        {
            Delegates.Params_IsFulfilled @params = new()
            {
                self = self
            };
            _beforeIsFulfilled?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterIsFulfilled != null) retVal = _afterIsFulfilled.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void IsFulfilled_BeforeArgs(Params_IsFulfilled args);

        public delegate bool IsFulfilled_NormalArgs(Params_IsFulfilled args);

        public sealed class Params_IsFulfilled
        {
            public MenuButtonAchievementListCondition self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.IsFulfilled_NormalArgs IsFulfilled
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
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MenuButtonAchievementListCondition.hook_IsFulfilled IsFulfilled
        {
            add => On.MenuButtonAchievementListCondition.IsFulfilled += value;
            remove => On.MenuButtonAchievementListCondition.IsFulfilled -= value;
        }
    }
}