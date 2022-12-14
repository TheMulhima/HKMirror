namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EngagedUserPanel class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEngagedUserPanel
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.EngagedUserPanel.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.EngagedUserPanel.orig_Awake orig, EngagedUserPanel self)
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

        internal static void HookOnDestroy()
        {
            if (!HookedList.Contains("OnDestroy"))
            {
                HookedList.Add("OnDestroy");
                On.EngagedUserPanel.OnDestroy += OnDestroy;
            }
        }

        internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
        internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;

        private static void OnDestroy(On.EngagedUserPanel.orig_OnDestroy orig, EngagedUserPanel self)
        {
            Delegates.Params_OnDestroy @params = new()
            {
                self = self
            };
            if (_beforeOnDestroy != null)
                foreach (Delegates.OnDestroy_BeforeArgs toInvoke in _beforeOnDestroy.GetInvocationList())
                    try
                    {
                        _beforeOnDestroy?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDestroy != null)
                foreach (Delegates.OnDestroy_AfterArgs toInvoke in _afterOnDestroy.GetInvocationList())
                    try
                    {
                        _afterOnDestroy.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.EngagedUserPanel.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.EngagedUserPanel.orig_Start orig, EngagedUserPanel self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdateContent()
        {
            if (!HookedList.Contains("UpdateContent"))
            {
                HookedList.Add("UpdateContent");
                On.EngagedUserPanel.UpdateContent += UpdateContent;
            }
        }

        internal static event Delegates.UpdateContent_BeforeArgs _beforeUpdateContent;
        internal static event Delegates.UpdateContent_AfterArgs _afterUpdateContent;

        private static void UpdateContent(On.EngagedUserPanel.orig_UpdateContent orig, EngagedUserPanel self)
        {
            Delegates.Params_UpdateContent @params = new()
            {
                self = self
            };
            if (_beforeUpdateContent != null)
                foreach (Delegates.UpdateContent_BeforeArgs toInvoke in _beforeUpdateContent.GetInvocationList())
                    try
                    {
                        _beforeUpdateContent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateContent != null)
                foreach (Delegates.UpdateContent_AfterArgs toInvoke in _afterUpdateContent.GetInvocationList())
                    try
                    {
                        _afterUpdateContent.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<EngagedUserPanel> orig, EngagedUserPanel self);

        public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);

        public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);

        public delegate void OnDestroy_WithArgs(Action<EngagedUserPanel> orig, EngagedUserPanel self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<EngagedUserPanel> orig, EngagedUserPanel self);

        public delegate void UpdateContent_AfterArgs(Params_UpdateContent args);

        public delegate void UpdateContent_BeforeArgs(Params_UpdateContent args);

        public delegate void UpdateContent_WithArgs(Action<EngagedUserPanel> orig, EngagedUserPanel self);

        public sealed class Params_Awake
        {
            public EngagedUserPanel self;
        }

        public sealed class Params_OnDestroy
        {
            public EngagedUserPanel self;
        }

        public sealed class Params_Start
        {
            public EngagedUserPanel self;
        }

        public sealed class Params_UpdateContent
        {
            public EngagedUserPanel self;
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

        public static event Delegates.OnDestroy_BeforeArgs OnDestroy
        {
            add
            {
                HookHandler._beforeOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._beforeOnDestroy -= value;
        }

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.UpdateContent_BeforeArgs UpdateContent
        {
            add
            {
                HookHandler._beforeUpdateContent += value;
                HookHandler.HookUpdateContent();
            }
            remove => HookHandler._beforeUpdateContent -= value;
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

        public static event Delegates.OnDestroy_AfterArgs OnDestroy
        {
            add
            {
                HookHandler._afterOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._afterOnDestroy -= value;
        }

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.UpdateContent_AfterArgs UpdateContent
        {
            add
            {
                HookHandler._afterUpdateContent += value;
                HookHandler.HookUpdateContent();
            }
            remove => HookHandler._afterUpdateContent -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.EngagedUserPanel.hook_Awake Awake
        {
            add => On.EngagedUserPanel.Awake += value;
            remove => On.EngagedUserPanel.Awake -= value;
        }

        public static event On.EngagedUserPanel.hook_OnDestroy OnDestroy
        {
            add => On.EngagedUserPanel.OnDestroy += value;
            remove => On.EngagedUserPanel.OnDestroy -= value;
        }

        public static event On.EngagedUserPanel.hook_Start Start
        {
            add => On.EngagedUserPanel.Start += value;
            remove => On.EngagedUserPanel.Start -= value;
        }

        public static event On.EngagedUserPanel.hook_UpdateContent UpdateContent
        {
            add => On.EngagedUserPanel.UpdateContent += value;
            remove => On.EngagedUserPanel.UpdateContent -= value;
        }
    }
}