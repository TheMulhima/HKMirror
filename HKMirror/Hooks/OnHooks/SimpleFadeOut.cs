namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SimpleFadeOut class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSimpleFadeOut
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.SimpleFadeOut.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.SimpleFadeOut.orig_Awake orig, SimpleFadeOut self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.SimpleFadeOut.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.SimpleFadeOut.orig_OnEnable orig, SimpleFadeOut self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.SimpleFadeOut.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.SimpleFadeOut.orig_Update orig, SimpleFadeOut self)
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

        internal static void HookFadeOut()
        {
            if (!HookedList.Contains("FadeOut"))
            {
                HookedList.Add("FadeOut");
                On.SimpleFadeOut.FadeOut += FadeOut;
            }
        }

        internal static event Delegates.FadeOut_BeforeArgs _beforeFadeOut;
        internal static event Delegates.FadeOut_NormalArgs _afterFadeOut;

        private static void FadeOut(On.SimpleFadeOut.orig_FadeOut orig, SimpleFadeOut self)
        {
            Delegates.Params_FadeOut @params = new()
            {
                self = self
            };
            _beforeFadeOut?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFadeOut != null) _afterFadeOut.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void FadeOut_BeforeArgs(Params_FadeOut args);

        public delegate void FadeOut_NormalArgs(Params_FadeOut args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public SimpleFadeOut self;
        }

        public sealed class Params_OnEnable
        {
            public SimpleFadeOut self;
        }

        public sealed class Params_Update
        {
            public SimpleFadeOut self;
        }

        public sealed class Params_FadeOut
        {
            public SimpleFadeOut self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
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

        public static event Delegates.FadeOut_BeforeArgs FadeOut
        {
            add
            {
                HookHandler._beforeFadeOut += value;
                HookHandler.HookFadeOut();
            }
            remove => HookHandler._beforeFadeOut -= value;
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

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
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

        public static event Delegates.FadeOut_NormalArgs FadeOut
        {
            add
            {
                HookHandler._afterFadeOut += value;
                HookHandler.HookFadeOut();
            }
            remove => HookHandler._afterFadeOut -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SimpleFadeOut.hook_Awake Awake
        {
            add => On.SimpleFadeOut.Awake += value;
            remove => On.SimpleFadeOut.Awake -= value;
        }

        public static event On.SimpleFadeOut.hook_OnEnable OnEnable
        {
            add => On.SimpleFadeOut.OnEnable += value;
            remove => On.SimpleFadeOut.OnEnable -= value;
        }

        public static event On.SimpleFadeOut.hook_Update Update
        {
            add => On.SimpleFadeOut.Update += value;
            remove => On.SimpleFadeOut.Update -= value;
        }

        public static event On.SimpleFadeOut.hook_FadeOut FadeOut
        {
            add => On.SimpleFadeOut.FadeOut += value;
            remove => On.SimpleFadeOut.FadeOut -= value;
        }
    }
}