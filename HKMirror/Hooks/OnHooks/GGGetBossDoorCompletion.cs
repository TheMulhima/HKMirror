namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GGGetBossDoorCompletion class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGGGetBossDoorCompletion
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.GGGetBossDoorCompletion.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(On.GGGetBossDoorCompletion.orig_Reset orig, GGGetBossDoorCompletion self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                On.GGGetBossDoorCompletion.OnEnter += OnEnter;
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(On.GGGetBossDoorCompletion.orig_OnEnter orig, GGGetBossDoorCompletion self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            _beforeOnEnter?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnter != null) _afterOnEnter.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public GGGetBossDoorCompletion self;
        }

        public sealed class Params_OnEnter
        {
            public GGGetBossDoorCompletion self;
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

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
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

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GGGetBossDoorCompletion.hook_Reset Reset
        {
            add => On.GGGetBossDoorCompletion.Reset += value;
            remove => On.GGGetBossDoorCompletion.Reset -= value;
        }

        public static event On.GGGetBossDoorCompletion.hook_OnEnter OnEnter
        {
            add => On.GGGetBossDoorCompletion.OnEnter += value;
            remove => On.GGGetBossDoorCompletion.OnEnter -= value;
        }
    }
}