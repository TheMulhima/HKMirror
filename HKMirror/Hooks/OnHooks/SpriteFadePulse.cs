namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpriteFadePulse class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpriteFadePulse
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.SpriteFadePulse.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.SpriteFadePulse.orig_Awake orig, SpriteFadePulse self)
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
                On.SpriteFadePulse.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.SpriteFadePulse.orig_OnEnable orig, SpriteFadePulse self)
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
                On.SpriteFadePulse.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.SpriteFadePulse.orig_Update orig, SpriteFadePulse self)
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

        internal static void HookFadeIn()
        {
            if (!HookedList.Contains("FadeIn"))
            {
                HookedList.Add("FadeIn");
                On.SpriteFadePulse.FadeIn += FadeIn;
            }
        }

        internal static event Delegates.FadeIn_BeforeArgs _beforeFadeIn;
        internal static event Delegates.FadeIn_NormalArgs _afterFadeIn;

        private static void FadeIn(On.SpriteFadePulse.orig_FadeIn orig, SpriteFadePulse self)
        {
            Delegates.Params_FadeIn @params = new()
            {
                self = self
            };
            _beforeFadeIn?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFadeIn != null) _afterFadeIn.Invoke(@params);
        }

        internal static void HookFadeOut()
        {
            if (!HookedList.Contains("FadeOut"))
            {
                HookedList.Add("FadeOut");
                On.SpriteFadePulse.FadeOut += FadeOut;
            }
        }

        internal static event Delegates.FadeOut_BeforeArgs _beforeFadeOut;
        internal static event Delegates.FadeOut_NormalArgs _afterFadeOut;

        private static void FadeOut(On.SpriteFadePulse.orig_FadeOut orig, SpriteFadePulse self)
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

        public delegate void FadeIn_BeforeArgs(Params_FadeIn args);

        public delegate void FadeIn_NormalArgs(Params_FadeIn args);

        public delegate void FadeOut_BeforeArgs(Params_FadeOut args);

        public delegate void FadeOut_NormalArgs(Params_FadeOut args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public SpriteFadePulse self;
        }

        public sealed class Params_OnEnable
        {
            public SpriteFadePulse self;
        }

        public sealed class Params_Update
        {
            public SpriteFadePulse self;
        }

        public sealed class Params_FadeIn
        {
            public SpriteFadePulse self;
        }

        public sealed class Params_FadeOut
        {
            public SpriteFadePulse self;
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

        public static event Delegates.FadeIn_BeforeArgs FadeIn
        {
            add
            {
                HookHandler._beforeFadeIn += value;
                HookHandler.HookFadeIn();
            }
            remove => HookHandler._beforeFadeIn -= value;
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

        public static event Delegates.FadeIn_NormalArgs FadeIn
        {
            add
            {
                HookHandler._afterFadeIn += value;
                HookHandler.HookFadeIn();
            }
            remove => HookHandler._afterFadeIn -= value;
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
        public static event On.SpriteFadePulse.hook_Awake Awake
        {
            add => On.SpriteFadePulse.Awake += value;
            remove => On.SpriteFadePulse.Awake -= value;
        }

        public static event On.SpriteFadePulse.hook_OnEnable OnEnable
        {
            add => On.SpriteFadePulse.OnEnable += value;
            remove => On.SpriteFadePulse.OnEnable -= value;
        }

        public static event On.SpriteFadePulse.hook_Update Update
        {
            add => On.SpriteFadePulse.Update += value;
            remove => On.SpriteFadePulse.Update -= value;
        }

        public static event On.SpriteFadePulse.hook_FadeIn FadeIn
        {
            add => On.SpriteFadePulse.FadeIn += value;
            remove => On.SpriteFadePulse.FadeIn -= value;
        }

        public static event On.SpriteFadePulse.hook_FadeOut FadeOut
        {
            add => On.SpriteFadePulse.FadeOut += value;
            remove => On.SpriteFadePulse.FadeOut -= value;
        }
    }
}