namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DreamPlatform class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDreamPlatform
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.DreamPlatform.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.DreamPlatform.orig_Awake orig, DreamPlatform self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.DreamPlatform.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.DreamPlatform.orig_Start orig, DreamPlatform self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.DreamPlatform.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.DreamPlatform.orig_OnEnable orig, DreamPlatform self)
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

        internal static void HookShow()
        {
            if (!HookedList.Contains("Show"))
            {
                HookedList.Add("Show");
                On.DreamPlatform.Show += Show;
            }
        }

        internal static event Delegates.Show_BeforeArgs _beforeShow;
        internal static event Delegates.Show_NormalArgs _afterShow;

        private static void Show(On.DreamPlatform.orig_Show orig, DreamPlatform self)
        {
            Delegates.Params_Show @params = new()
            {
                self = self
            };
            _beforeShow?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterShow != null) _afterShow.Invoke(@params);
        }

        internal static void HookHide()
        {
            if (!HookedList.Contains("Hide"))
            {
                HookedList.Add("Hide");
                On.DreamPlatform.Hide += Hide;
            }
        }

        internal static event Delegates.Hide_BeforeArgs _beforeHide;
        internal static event Delegates.Hide_NormalArgs _afterHide;

        private static void Hide(On.DreamPlatform.orig_Hide orig, DreamPlatform self)
        {
            Delegates.Params_Hide @params = new()
            {
                self = self
            };
            _beforeHide?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterHide != null) _afterHide.Invoke(@params);
        }

        internal static void HookPlayAnimation()
        {
            if (!HookedList.Contains("PlayAnimation"))
            {
                HookedList.Add("PlayAnimation");
                On.DreamPlatform.PlayAnimation += PlayAnimation;
            }
        }

        internal static event Delegates.PlayAnimation_BeforeArgs _beforePlayAnimation;
        internal static event Delegates.PlayAnimation_NormalArgs _afterPlayAnimation;

        private static void PlayAnimation(On.DreamPlatform.orig_PlayAnimation orig, DreamPlatform self,
            string animationName)
        {
            Delegates.Params_PlayAnimation @params = new()
            {
                self = self, animationName = animationName
            };
            _beforePlayAnimation?.Invoke(@params);
            self = @params.self;
            animationName = @params.animationName;
            orig(self, animationName);
            if (_afterPlayAnimation != null) _afterPlayAnimation.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void Hide_BeforeArgs(Params_Hide args);

        public delegate void Hide_NormalArgs(Params_Hide args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void PlayAnimation_BeforeArgs(Params_PlayAnimation args);

        public delegate void PlayAnimation_NormalArgs(Params_PlayAnimation args);

        public delegate void Show_BeforeArgs(Params_Show args);

        public delegate void Show_NormalArgs(Params_Show args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Awake
        {
            public DreamPlatform self;
        }

        public sealed class Params_Start
        {
            public DreamPlatform self;
        }

        public sealed class Params_OnEnable
        {
            public DreamPlatform self;
        }

        public sealed class Params_Show
        {
            public DreamPlatform self;
        }

        public sealed class Params_Hide
        {
            public DreamPlatform self;
        }

        public sealed class Params_PlayAnimation
        {
            public string animationName;
            public DreamPlatform self;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.Show_BeforeArgs Show
        {
            add
            {
                HookHandler._beforeShow += value;
                HookHandler.HookShow();
            }
            remove => HookHandler._beforeShow -= value;
        }

        public static event Delegates.Hide_BeforeArgs Hide
        {
            add
            {
                HookHandler._beforeHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._beforeHide -= value;
        }

        public static event Delegates.PlayAnimation_BeforeArgs PlayAnimation
        {
            add
            {
                HookHandler._beforePlayAnimation += value;
                HookHandler.HookPlayAnimation();
            }
            remove => HookHandler._beforePlayAnimation -= value;
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

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.Show_NormalArgs Show
        {
            add
            {
                HookHandler._afterShow += value;
                HookHandler.HookShow();
            }
            remove => HookHandler._afterShow -= value;
        }

        public static event Delegates.Hide_NormalArgs Hide
        {
            add
            {
                HookHandler._afterHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._afterHide -= value;
        }

        public static event Delegates.PlayAnimation_NormalArgs PlayAnimation
        {
            add
            {
                HookHandler._afterPlayAnimation += value;
                HookHandler.HookPlayAnimation();
            }
            remove => HookHandler._afterPlayAnimation -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.DreamPlatform.hook_Awake Awake
        {
            add => On.DreamPlatform.Awake += value;
            remove => On.DreamPlatform.Awake -= value;
        }

        public static event On.DreamPlatform.hook_Start Start
        {
            add => On.DreamPlatform.Start += value;
            remove => On.DreamPlatform.Start -= value;
        }

        public static event On.DreamPlatform.hook_OnEnable OnEnable
        {
            add => On.DreamPlatform.OnEnable += value;
            remove => On.DreamPlatform.OnEnable -= value;
        }

        public static event On.DreamPlatform.hook_Show Show
        {
            add => On.DreamPlatform.Show += value;
            remove => On.DreamPlatform.Show -= value;
        }

        public static event On.DreamPlatform.hook_Hide Hide
        {
            add => On.DreamPlatform.Hide += value;
            remove => On.DreamPlatform.Hide -= value;
        }

        public static event On.DreamPlatform.hook_PlayAnimation PlayAnimation
        {
            add => On.DreamPlatform.PlayAnimation += value;
            remove => On.DreamPlatform.PlayAnimation -= value;
        }
    }
}