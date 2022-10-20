namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetWalkerFacing class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetWalkerFacing
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.SetWalkerFacing.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(On.SetWalkerFacing.orig_Reset orig, SetWalkerFacing self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookApply()
        {
            if (!HookedList.Contains("Apply"))
            {
                HookedList.Add("Apply");
                On.SetWalkerFacing.Apply += Apply;
            }
        }

        internal static event Delegates.Apply_BeforeArgs _beforeApply;
        internal static event Delegates.Apply_NormalArgs _afterApply;

        private static void Apply(On.SetWalkerFacing.orig_Apply orig, SetWalkerFacing self, Walker walker)
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

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public SetWalkerFacing self;
        }

        public sealed class Params_Apply
        {
            public SetWalkerFacing self;
            public Walker walker;
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
        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

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
        public static event On.SetWalkerFacing.hook_Reset Reset
        {
            add => On.SetWalkerFacing.Reset += value;
            remove => On.SetWalkerFacing.Reset -= value;
        }

        public static event On.SetWalkerFacing.hook_Apply Apply
        {
            add => On.SetWalkerFacing.Apply += value;
            remove => On.SetWalkerFacing.Apply -= value;
        }
    }
}