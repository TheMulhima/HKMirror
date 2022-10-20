namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BreakableWithExternalDebris class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBreakableWithExternalDebris
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookCreateAdditionalDebrisParts()
        {
            if (!HookedList.Contains("CreateAdditionalDebrisParts"))
            {
                HookedList.Add("CreateAdditionalDebrisParts");
                On.BreakableWithExternalDebris.CreateAdditionalDebrisParts += CreateAdditionalDebrisParts;
            }
        }

        internal static event Delegates.CreateAdditionalDebrisParts_BeforeArgs _beforeCreateAdditionalDebrisParts;
        internal static event Delegates.CreateAdditionalDebrisParts_NormalArgs _afterCreateAdditionalDebrisParts;

        private static void CreateAdditionalDebrisParts(
            On.BreakableWithExternalDebris.orig_CreateAdditionalDebrisParts orig, BreakableWithExternalDebris self,
            List<GameObject> debrisParts)
        {
            Delegates.Params_CreateAdditionalDebrisParts @params = new()
            {
                self = self, debrisParts = debrisParts
            };
            _beforeCreateAdditionalDebrisParts?.Invoke(@params);
            self = @params.self;
            debrisParts = @params.debrisParts;
            orig(self, debrisParts);
            if (_afterCreateAdditionalDebrisParts != null) _afterCreateAdditionalDebrisParts.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CreateAdditionalDebrisParts_BeforeArgs(Params_CreateAdditionalDebrisParts args);

        public delegate void CreateAdditionalDebrisParts_NormalArgs(Params_CreateAdditionalDebrisParts args);

        public sealed class Params_CreateAdditionalDebrisParts
        {
            public List<GameObject> debrisParts;
            public BreakableWithExternalDebris self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.CreateAdditionalDebrisParts_BeforeArgs CreateAdditionalDebrisParts
        {
            add
            {
                HookHandler._beforeCreateAdditionalDebrisParts += value;
                HookHandler.HookCreateAdditionalDebrisParts();
            }
            remove => HookHandler._beforeCreateAdditionalDebrisParts -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.CreateAdditionalDebrisParts_NormalArgs CreateAdditionalDebrisParts
        {
            add
            {
                HookHandler._afterCreateAdditionalDebrisParts += value;
                HookHandler.HookCreateAdditionalDebrisParts();
            }
            remove => HookHandler._afterCreateAdditionalDebrisParts -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BreakableWithExternalDebris.hook_CreateAdditionalDebrisParts CreateAdditionalDebrisParts
        {
            add => On.BreakableWithExternalDebris.CreateAdditionalDebrisParts += value;
            remove => On.BreakableWithExternalDebris.CreateAdditionalDebrisParts -= value;
        }
    }
}