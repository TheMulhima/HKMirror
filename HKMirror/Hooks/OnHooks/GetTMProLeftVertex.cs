namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetTMProLeftVertex class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetTMProLeftVertex
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.GetTMProLeftVertex.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.GetTMProLeftVertex.orig_Start orig, GetTMProLeftVertex self)
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

        internal static void HookGetLeftmostVertex()
        {
            if (!HookedList.Contains("GetLeftmostVertex"))
            {
                HookedList.Add("GetLeftmostVertex");
                On.GetTMProLeftVertex.GetLeftmostVertex += GetLeftmostVertex;
            }
        }

        internal static event Delegates.GetLeftmostVertex_BeforeArgs _beforeGetLeftmostVertex;
        internal static event Delegates.GetLeftmostVertex_NormalArgs _afterGetLeftmostVertex;

        private static float GetLeftmostVertex(On.GetTMProLeftVertex.orig_GetLeftmostVertex orig,
            GetTMProLeftVertex self)
        {
            Delegates.Params_GetLeftmostVertex @params = new()
            {
                self = self
            };
            _beforeGetLeftmostVertex?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetLeftmostVertex != null) retVal = _afterGetLeftmostVertex.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void GetLeftmostVertex_BeforeArgs(Params_GetLeftmostVertex args);

        public delegate float GetLeftmostVertex_NormalArgs(Params_GetLeftmostVertex args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Start
        {
            public GetTMProLeftVertex self;
        }

        public sealed class Params_GetLeftmostVertex
        {
            public GetTMProLeftVertex self;
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

        public static event Delegates.GetLeftmostVertex_BeforeArgs GetLeftmostVertex
        {
            add
            {
                HookHandler._beforeGetLeftmostVertex += value;
                HookHandler.HookGetLeftmostVertex();
            }
            remove => HookHandler._beforeGetLeftmostVertex -= value;
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

        public static event Delegates.GetLeftmostVertex_NormalArgs GetLeftmostVertex
        {
            add
            {
                HookHandler._afterGetLeftmostVertex += value;
                HookHandler.HookGetLeftmostVertex();
            }
            remove => HookHandler._afterGetLeftmostVertex -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GetTMProLeftVertex.hook_Start Start
        {
            add => On.GetTMProLeftVertex.Start += value;
            remove => On.GetTMProLeftVertex.Start -= value;
        }

        public static event On.GetTMProLeftVertex.hook_GetLeftmostVertex GetLeftmostVertex
        {
            add => On.GetTMProLeftVertex.GetLeftmostVertex += value;
            remove => On.GetTMProLeftVertex.GetLeftmostVertex -= value;
        }
    }
}