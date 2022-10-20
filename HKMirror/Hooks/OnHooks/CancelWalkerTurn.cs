namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CancelWalkerTurn class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCancelWalkerTurn
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookApply()
        {
            if (!HookedList.Contains("Apply"))
            {
                HookedList.Add("Apply");
                On.CancelWalkerTurn.Apply += Apply;
            }
        }

        internal static event Delegates.Apply_BeforeArgs _beforeApply;
        internal static event Delegates.Apply_NormalArgs _afterApply;

        private static void Apply(On.CancelWalkerTurn.orig_Apply orig, CancelWalkerTurn self, Walker walker)
        {
            Delegates.Params_Apply @params = new()
            {
                self = self, walker = walker
            };
            _beforeApply?.Invoke(@params);
            self = @params.self;
            walker = @params.walker;
            orig(self, walker);
            if (_afterApply != null) _afterApply.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Apply_BeforeArgs(Params_Apply args);

        public delegate void Apply_NormalArgs(Params_Apply args);

        public sealed class Params_Apply
        {
            public CancelWalkerTurn self;
            public Walker walker;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Apply_NormalArgs Apply
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
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CancelWalkerTurn.hook_Apply Apply
        {
            add => On.CancelWalkerTurn.Apply += value;
            remove => On.CancelWalkerTurn.Apply -= value;
        }
    }
}