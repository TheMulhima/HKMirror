namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CheckpointSprite class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCheckpointSprite
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.CheckpointSprite.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.CheckpointSprite.orig_Awake orig, CheckpointSprite self)
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
                On.CheckpointSprite.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.CheckpointSprite.orig_OnEnable orig, CheckpointSprite self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.CheckpointSprite.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.CheckpointSprite.orig_Start orig, CheckpointSprite self)
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

        internal static void HookShow()
        {
            if (!HookedList.Contains("Show"))
            {
                HookedList.Add("Show");
                On.CheckpointSprite.Show += Show;
            }
        }

        internal static event Delegates.Show_BeforeArgs _beforeShow;
        internal static event Delegates.Show_NormalArgs _afterShow;

        private static void Show(On.CheckpointSprite.orig_Show orig, CheckpointSprite self)
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
                On.CheckpointSprite.Hide += Hide;
            }
        }

        internal static event Delegates.Hide_BeforeArgs _beforeHide;
        internal static event Delegates.Hide_NormalArgs _afterHide;

        private static void Hide(On.CheckpointSprite.orig_Hide orig, CheckpointSprite self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.CheckpointSprite.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.CheckpointSprite.orig_Update orig, CheckpointSprite self)
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

        internal static void HookUpdate_float()
        {
            if (!HookedList.Contains("Update_float"))
            {
                HookedList.Add("Update_float");
                On.CheckpointSprite.Update_float += Update_float;
            }
        }

        internal static event Delegates.Update_float_BeforeArgs _beforeUpdate_float;
        internal static event Delegates.Update_float_NormalArgs _afterUpdate_float;

        private static void Update_float(On.CheckpointSprite.orig_Update_float orig, CheckpointSprite self,
            float deltaTime)
        {
            Delegates.Params_Update_float @params = new()
            {
                self = self, deltaTime = deltaTime
            };
            _beforeUpdate_float?.Invoke(@params);
            self = @params.self;
            deltaTime = @params.deltaTime;
            orig(self, deltaTime);
            if (_afterUpdate_float != null) _afterUpdate_float.Invoke(@params);
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

        public delegate void Show_BeforeArgs(Params_Show args);

        public delegate void Show_NormalArgs(Params_Show args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_float_BeforeArgs(Params_Update_float args);

        public delegate void Update_float_NormalArgs(Params_Update_float args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public CheckpointSprite self;
        }

        public sealed class Params_OnEnable
        {
            public CheckpointSprite self;
        }

        public sealed class Params_Start
        {
            public CheckpointSprite self;
        }

        public sealed class Params_Show
        {
            public CheckpointSprite self;
        }

        public sealed class Params_Hide
        {
            public CheckpointSprite self;
        }

        public sealed class Params_Update
        {
            public CheckpointSprite self;
        }

        public sealed class Params_Update_float
        {
            public float deltaTime;
            public CheckpointSprite self;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.Update_float_BeforeArgs Update_float
        {
            add
            {
                HookHandler._beforeUpdate_float += value;
                HookHandler.HookUpdate_float();
            }
            remove => HookHandler._beforeUpdate_float -= value;
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

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.Update_float_NormalArgs Update_float
        {
            add
            {
                HookHandler._afterUpdate_float += value;
                HookHandler.HookUpdate_float();
            }
            remove => HookHandler._afterUpdate_float -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CheckpointSprite.hook_Awake Awake
        {
            add => On.CheckpointSprite.Awake += value;
            remove => On.CheckpointSprite.Awake -= value;
        }

        public static event On.CheckpointSprite.hook_OnEnable OnEnable
        {
            add => On.CheckpointSprite.OnEnable += value;
            remove => On.CheckpointSprite.OnEnable -= value;
        }

        public static event On.CheckpointSprite.hook_Start Start
        {
            add => On.CheckpointSprite.Start += value;
            remove => On.CheckpointSprite.Start -= value;
        }

        public static event On.CheckpointSprite.hook_Show Show
        {
            add => On.CheckpointSprite.Show += value;
            remove => On.CheckpointSprite.Show -= value;
        }

        public static event On.CheckpointSprite.hook_Hide Hide
        {
            add => On.CheckpointSprite.Hide += value;
            remove => On.CheckpointSprite.Hide -= value;
        }

        public static event On.CheckpointSprite.hook_Update Update
        {
            add => On.CheckpointSprite.Update += value;
            remove => On.CheckpointSprite.Update -= value;
        }

        public static event On.CheckpointSprite.hook_Update_float Update_float
        {
            add => On.CheckpointSprite.Update_float += value;
            remove => On.CheckpointSprite.Update_float -= value;
        }
    }
}