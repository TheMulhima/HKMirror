namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BetaGateChanger class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBetaGateChanger
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookSwitchToBetaExit()
        {
            if (!HookedList.Contains("SwitchToBetaExit"))
            {
                HookedList.Add("SwitchToBetaExit");
                On.BetaGateChanger.SwitchToBetaExit += SwitchToBetaExit;
            }
        }

        internal static event Delegates.SwitchToBetaExit_BeforeArgs _beforeSwitchToBetaExit;
        internal static event Delegates.SwitchToBetaExit_NormalArgs _afterSwitchToBetaExit;

        private static void SwitchToBetaExit(On.BetaGateChanger.orig_SwitchToBetaExit orig, BetaGateChanger self)
        {
            Delegates.Params_SwitchToBetaExit @params = new()
            {
                self = self
            };
            _beforeSwitchToBetaExit?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSwitchToBetaExit != null) _afterSwitchToBetaExit.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void SwitchToBetaExit_BeforeArgs(Params_SwitchToBetaExit args);

        public delegate void SwitchToBetaExit_NormalArgs(Params_SwitchToBetaExit args);

        public sealed class Params_SwitchToBetaExit
        {
            public BetaGateChanger self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SwitchToBetaExit_BeforeArgs SwitchToBetaExit
        {
            add
            {
                HookHandler._beforeSwitchToBetaExit += value;
                HookHandler.HookSwitchToBetaExit();
            }
            remove => HookHandler._beforeSwitchToBetaExit -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SwitchToBetaExit_NormalArgs SwitchToBetaExit
        {
            add
            {
                HookHandler._afterSwitchToBetaExit += value;
                HookHandler.HookSwitchToBetaExit();
            }
            remove => HookHandler._afterSwitchToBetaExit -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BetaGateChanger.hook_SwitchToBetaExit SwitchToBetaExit
        {
            add => On.BetaGateChanger.SwitchToBetaExit += value;
            remove => On.BetaGateChanger.SwitchToBetaExit -= value;
        }
    }
}