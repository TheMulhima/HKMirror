namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ShineAnimSequence class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnShineAnimSequence
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.ShineAnimSequence.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.ShineAnimSequence.orig_Start orig, ShineAnimSequence self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStart != null) _afterStart.Invoke(@params);
        }

        internal static void HookShineSequence()
        {
            if (!HookedList.Contains("ShineSequence"))
            {
                HookedList.Add("ShineSequence");
                On.ShineAnimSequence.ShineSequence += ShineSequence;
            }
        }

        internal static event Delegates.ShineSequence_BeforeArgs _beforeShineSequence;

        private static IEnumerator ShineSequence(On.ShineAnimSequence.orig_ShineSequence orig, ShineAnimSequence self)
        {
            Delegates.Params_ShineSequence @params = new()
            {
                self = self
            };
            _beforeShineSequence?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void ShineSequence_BeforeArgs(Params_ShineSequence args);

        public delegate IEnumerator ShineSequence_NormalArgs(Params_ShineSequence args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Start
        {
            public ShineAnimSequence self;
        }

        public sealed class Params_ShineSequence
        {
            public ShineAnimSequence self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.ShineSequence_BeforeArgs ShineSequence
        {
            add
            {
                HookHandler._beforeShineSequence += value;
                HookHandler.HookShineSequence();
            }
            remove => HookHandler._beforeShineSequence -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.ShineAnimSequence.hook_Start Start
        {
            add => On.ShineAnimSequence.Start += value;
            remove => On.ShineAnimSequence.Start -= value;
        }

        public static event On.ShineAnimSequence.hook_ShineSequence ShineSequence
        {
            add => On.ShineAnimSequence.ShineSequence += value;
            remove => On.ShineAnimSequence.ShineSequence -= value;
        }
    }
}