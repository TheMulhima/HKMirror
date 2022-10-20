namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ConnectControllerPanel class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnConnectControllerPanel
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.ConnectControllerPanel.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.ConnectControllerPanel.orig_Start orig, ConnectControllerPanel self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.ConnectControllerPanel.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.ConnectControllerPanel.orig_Update orig, ConnectControllerPanel self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookUpdateContent()
        {
            if (!HookedList.Contains("UpdateContent"))
            {
                HookedList.Add("UpdateContent");
                On.ConnectControllerPanel.UpdateContent += UpdateContent;
            }
        }

        internal static event Delegates.UpdateContent_BeforeArgs _beforeUpdateContent;
        internal static event Delegates.UpdateContent_NormalArgs _afterUpdateContent;

        private static void UpdateContent(On.ConnectControllerPanel.orig_UpdateContent orig,
            ConnectControllerPanel self)
        {
            Delegates.Params_UpdateContent @params = new()
            {
                self = self
            };
            _beforeUpdateContent?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdateContent != null) _afterUpdateContent.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public delegate void UpdateContent_BeforeArgs(Params_UpdateContent args);

        public delegate void UpdateContent_NormalArgs(Params_UpdateContent args);

        public sealed class Params_Start
        {
            public ConnectControllerPanel self;
        }

        public sealed class Params_Update
        {
            public ConnectControllerPanel self;
        }

        public sealed class Params_UpdateContent
        {
            public ConnectControllerPanel self;
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
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
        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.UpdateContent_NormalArgs UpdateContent
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
        public static event On.ConnectControllerPanel.hook_Start Start
        {
            add => On.ConnectControllerPanel.Start += value;
            remove => On.ConnectControllerPanel.Start -= value;
        }

        public static event On.ConnectControllerPanel.hook_Update Update
        {
            add => On.ConnectControllerPanel.Update += value;
            remove => On.ConnectControllerPanel.Update -= value;
        }

        public static event On.ConnectControllerPanel.hook_UpdateContent UpdateContent
        {
            add => On.ConnectControllerPanel.UpdateContent += value;
            remove => On.ConnectControllerPanel.UpdateContent -= value;
        }
    }
}