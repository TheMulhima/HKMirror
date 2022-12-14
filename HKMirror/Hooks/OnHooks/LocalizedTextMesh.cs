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
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.LocalizedTextMesh.orig_Awake orig, LocalizedTextMesh self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.LocalizeTextMesh_AfterArgs _afterLocalizeTextMesh;

        private static void LocalizeTextMesh(On.LocalizedTextMesh.orig_LocalizeTextMesh orig, LocalizedTextMesh self,
            string keyValue)
        {
            Delegates.Params_LocalizeTextMesh @params = new()
            {
                self = self, keyValue = keyValue
            };
            if (_beforeLocalizeTextMesh != null)
                foreach (Delegates.LocalizeTextMesh_BeforeArgs toInvoke in _beforeLocalizeTextMesh.GetInvocationList())
                    try
                    {
                        _beforeLocalizeTextMesh?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            keyValue = @params.keyValue;
            orig(self, keyValue);
            if (_afterLocalizeTextMesh != null)
                foreach (Delegates.LocalizeTextMesh_AfterArgs toInvoke in _afterLocalizeTextMesh.GetInvocationList())
                    try
                    {
                        _afterLocalizeTextMesh.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<LocalizedTextMesh> orig, LocalizedTextMesh self);

        public delegate void LocalizeTextMesh_AfterArgs(Params_LocalizeTextMesh args);

        public delegate void LocalizeTextMesh_BeforeArgs(Params_LocalizeTextMesh args);

        public delegate void LocalizeTextMesh_WithArgs(Action<LocalizedTextMesh, string> orig, LocalizedTextMesh self,
            string keyValue);

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
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.LocalizeTextMesh_AfterArgs LocalizeTextMesh
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