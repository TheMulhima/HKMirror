namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MenuAudioController class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuAudioController
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.MenuAudioController.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.MenuAudioController.orig_Awake orig, MenuAudioController self)
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
                On.MenuAudioController.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;

        private static IEnumerator Start(On.MenuAudioController.orig_Start orig, MenuAudioController self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookPlaySelect()
        {
            if (!HookedList.Contains("PlaySelect"))
            {
                HookedList.Add("PlaySelect");
                On.MenuAudioController.PlaySelect += PlaySelect;
            }
        }

        internal static event Delegates.PlaySelect_BeforeArgs _beforePlaySelect;
        internal static event Delegates.PlaySelect_NormalArgs _afterPlaySelect;

        private static void PlaySelect(On.MenuAudioController.orig_PlaySelect orig, MenuAudioController self)
        {
            Delegates.Params_PlaySelect @params = new()
            {
                self = self
            };
            _beforePlaySelect?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlaySelect != null) _afterPlaySelect.Invoke(@params);
        }

        internal static void HookPlaySubmit()
        {
            if (!HookedList.Contains("PlaySubmit"))
            {
                HookedList.Add("PlaySubmit");
                On.MenuAudioController.PlaySubmit += PlaySubmit;
            }
        }

        internal static event Delegates.PlaySubmit_BeforeArgs _beforePlaySubmit;
        internal static event Delegates.PlaySubmit_NormalArgs _afterPlaySubmit;

        private static void PlaySubmit(On.MenuAudioController.orig_PlaySubmit orig, MenuAudioController self)
        {
            Delegates.Params_PlaySubmit @params = new()
            {
                self = self
            };
            _beforePlaySubmit?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlaySubmit != null) _afterPlaySubmit.Invoke(@params);
        }

        internal static void HookPlayCancel()
        {
            if (!HookedList.Contains("PlayCancel"))
            {
                HookedList.Add("PlayCancel");
                On.MenuAudioController.PlayCancel += PlayCancel;
            }
        }

        internal static event Delegates.PlayCancel_BeforeArgs _beforePlayCancel;
        internal static event Delegates.PlayCancel_NormalArgs _afterPlayCancel;

        private static void PlayCancel(On.MenuAudioController.orig_PlayCancel orig, MenuAudioController self)
        {
            Delegates.Params_PlayCancel @params = new()
            {
                self = self
            };
            _beforePlayCancel?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayCancel != null) _afterPlayCancel.Invoke(@params);
        }

        internal static void HookPlaySlider()
        {
            if (!HookedList.Contains("PlaySlider"))
            {
                HookedList.Add("PlaySlider");
                On.MenuAudioController.PlaySlider += PlaySlider;
            }
        }

        internal static event Delegates.PlaySlider_BeforeArgs _beforePlaySlider;
        internal static event Delegates.PlaySlider_NormalArgs _afterPlaySlider;

        private static void PlaySlider(On.MenuAudioController.orig_PlaySlider orig, MenuAudioController self)
        {
            Delegates.Params_PlaySlider @params = new()
            {
                self = self
            };
            _beforePlaySlider?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlaySlider != null) _afterPlaySlider.Invoke(@params);
        }

        internal static void HookPlayStartGame()
        {
            if (!HookedList.Contains("PlayStartGame"))
            {
                HookedList.Add("PlayStartGame");
                On.MenuAudioController.PlayStartGame += PlayStartGame;
            }
        }

        internal static event Delegates.PlayStartGame_BeforeArgs _beforePlayStartGame;
        internal static event Delegates.PlayStartGame_NormalArgs _afterPlayStartGame;

        private static void PlayStartGame(On.MenuAudioController.orig_PlayStartGame orig, MenuAudioController self)
        {
            Delegates.Params_PlayStartGame @params = new()
            {
                self = self
            };
            _beforePlayStartGame?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPlayStartGame != null) _afterPlayStartGame.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void PlayCancel_BeforeArgs(Params_PlayCancel args);

        public delegate void PlayCancel_NormalArgs(Params_PlayCancel args);

        public delegate void PlaySelect_BeforeArgs(Params_PlaySelect args);

        public delegate void PlaySelect_NormalArgs(Params_PlaySelect args);

        public delegate void PlaySlider_BeforeArgs(Params_PlaySlider args);

        public delegate void PlaySlider_NormalArgs(Params_PlaySlider args);

        public delegate void PlayStartGame_BeforeArgs(Params_PlayStartGame args);

        public delegate void PlayStartGame_NormalArgs(Params_PlayStartGame args);

        public delegate void PlaySubmit_BeforeArgs(Params_PlaySubmit args);

        public delegate void PlaySubmit_NormalArgs(Params_PlaySubmit args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate IEnumerator Start_NormalArgs(Params_Start args);

        public sealed class Params_Awake
        {
            public MenuAudioController self;
        }

        public sealed class Params_Start
        {
            public MenuAudioController self;
        }

        public sealed class Params_PlaySelect
        {
            public MenuAudioController self;
        }

        public sealed class Params_PlaySubmit
        {
            public MenuAudioController self;
        }

        public sealed class Params_PlayCancel
        {
            public MenuAudioController self;
        }

        public sealed class Params_PlaySlider
        {
            public MenuAudioController self;
        }

        public sealed class Params_PlayStartGame
        {
            public MenuAudioController self;
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

        public static event Delegates.PlaySelect_BeforeArgs PlaySelect
        {
            add
            {
                HookHandler._beforePlaySelect += value;
                HookHandler.HookPlaySelect();
            }
            remove => HookHandler._beforePlaySelect -= value;
        }

        public static event Delegates.PlaySubmit_BeforeArgs PlaySubmit
        {
            add
            {
                HookHandler._beforePlaySubmit += value;
                HookHandler.HookPlaySubmit();
            }
            remove => HookHandler._beforePlaySubmit -= value;
        }

        public static event Delegates.PlayCancel_BeforeArgs PlayCancel
        {
            add
            {
                HookHandler._beforePlayCancel += value;
                HookHandler.HookPlayCancel();
            }
            remove => HookHandler._beforePlayCancel -= value;
        }

        public static event Delegates.PlaySlider_BeforeArgs PlaySlider
        {
            add
            {
                HookHandler._beforePlaySlider += value;
                HookHandler.HookPlaySlider();
            }
            remove => HookHandler._beforePlaySlider -= value;
        }

        public static event Delegates.PlayStartGame_BeforeArgs PlayStartGame
        {
            add
            {
                HookHandler._beforePlayStartGame += value;
                HookHandler.HookPlayStartGame();
            }
            remove => HookHandler._beforePlayStartGame -= value;
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

        public static event Delegates.PlaySelect_NormalArgs PlaySelect
        {
            add
            {
                HookHandler._afterPlaySelect += value;
                HookHandler.HookPlaySelect();
            }
            remove => HookHandler._afterPlaySelect -= value;
        }

        public static event Delegates.PlaySubmit_NormalArgs PlaySubmit
        {
            add
            {
                HookHandler._afterPlaySubmit += value;
                HookHandler.HookPlaySubmit();
            }
            remove => HookHandler._afterPlaySubmit -= value;
        }

        public static event Delegates.PlayCancel_NormalArgs PlayCancel
        {
            add
            {
                HookHandler._afterPlayCancel += value;
                HookHandler.HookPlayCancel();
            }
            remove => HookHandler._afterPlayCancel -= value;
        }

        public static event Delegates.PlaySlider_NormalArgs PlaySlider
        {
            add
            {
                HookHandler._afterPlaySlider += value;
                HookHandler.HookPlaySlider();
            }
            remove => HookHandler._afterPlaySlider -= value;
        }

        public static event Delegates.PlayStartGame_NormalArgs PlayStartGame
        {
            add
            {
                HookHandler._afterPlayStartGame += value;
                HookHandler.HookPlayStartGame();
            }
            remove => HookHandler._afterPlayStartGame -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MenuAudioController.hook_Awake Awake
        {
            add => On.MenuAudioController.Awake += value;
            remove => On.MenuAudioController.Awake -= value;
        }

        public static event On.MenuAudioController.hook_Start Start
        {
            add => On.MenuAudioController.Start += value;
            remove => On.MenuAudioController.Start -= value;
        }

        public static event On.MenuAudioController.hook_PlaySelect PlaySelect
        {
            add => On.MenuAudioController.PlaySelect += value;
            remove => On.MenuAudioController.PlaySelect -= value;
        }

        public static event On.MenuAudioController.hook_PlaySubmit PlaySubmit
        {
            add => On.MenuAudioController.PlaySubmit += value;
            remove => On.MenuAudioController.PlaySubmit -= value;
        }

        public static event On.MenuAudioController.hook_PlayCancel PlayCancel
        {
            add => On.MenuAudioController.PlayCancel += value;
            remove => On.MenuAudioController.PlayCancel -= value;
        }

        public static event On.MenuAudioController.hook_PlaySlider PlaySlider
        {
            add => On.MenuAudioController.PlaySlider += value;
            remove => On.MenuAudioController.PlaySlider -= value;
        }

        public static event On.MenuAudioController.hook_PlayStartGame PlayStartGame
        {
            add => On.MenuAudioController.PlayStartGame += value;
            remove => On.MenuAudioController.PlayStartGame -= value;
        }
    }
}