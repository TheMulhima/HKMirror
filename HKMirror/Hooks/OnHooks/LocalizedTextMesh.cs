namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for LocalizedTextMesh class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnLocalizedTextMesh
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.LocalizedTextMesh.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.LocalizedTextMesh.orig_Awake orig, LocalizedTextMesh self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookLocalizeTextMesh()
        {
            if (!HookedList.Contains("LocalizeTextMesh"))
            {
                HookedList.Add("LocalizeTextMesh");
                On.LocalizedTextMesh.LocalizeTextMesh += LocalizeTextMesh;
            }
        }

        internal static event Delegates.LocalizeTextMesh_BeforeArgs _beforeLocalizeTextMesh;
        internal static event Delegates.LocalizeTextMesh_NormalArgs _afterLocalizeTextMesh;

        private static void LocalizeTextMesh(On.LocalizedTextMesh.orig_LocalizeTextMesh orig, LocalizedTextMesh self,
            string keyValue)
        {
            Delegates.Params_LocalizeTextMesh @params = new()
            {
                self = self, keyValue = keyValue
            };
            _beforeLocalizeTextMesh?.Invoke(@params);
            self = @params.self;
            keyValue = @params.keyValue;
            orig(self, keyValue);
            if (_afterLocalizeTextMesh != null) _afterLocalizeTextMesh.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void LocalizeTextMesh_BeforeArgs(Params_LocalizeTextMesh args);

        public delegate void LocalizeTextMesh_NormalArgs(Params_LocalizeTextMesh args);

        public sealed class Params_Awake
        {
            public LocalizedTextMesh self;
        }

        public sealed class Params_LocalizeTextMesh
        {
            public string keyValue;
            public LocalizedTextMesh self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.LocalizeTextMesh_BeforeArgs LocalizeTextMesh
        {
            add
            {
                HookHandler._beforeLocalizeTextMesh += value;
                HookHandler.HookLocalizeTextMesh();
            }
            remove => HookHandler._beforeLocalizeTextMesh -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.LocalizeTextMesh_NormalArgs LocalizeTextMesh
        {
            add
            {
                HookHandler._afterLocalizeTextMesh += value;
                HookHandler.HookLocalizeTextMesh();
            }
            remove => HookHandler._afterLocalizeTextMesh -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.LocalizedTextMesh.hook_Awake Awake
        {
            add => On.LocalizedTextMesh.Awake += value;
            remove => On.LocalizedTextMesh.Awake -= value;
        }

        public static event On.LocalizedTextMesh.hook_LocalizeTextMesh LocalizeTextMesh
        {
            add => On.LocalizedTextMesh.LocalizeTextMesh += value;
            remove => On.LocalizedTextMesh.LocalizeTextMesh -= value;
        }
    }
}