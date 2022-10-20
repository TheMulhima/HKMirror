namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AudioLoopMaster class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAudioLoopMaster
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.AudioLoopMaster.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.AudioLoopMaster.orig_Start orig, AudioLoopMaster self)
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
                On.AudioLoopMaster.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.AudioLoopMaster.orig_Update orig, AudioLoopMaster self)
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

        internal static void HookSetSyncAction()
        {
            if (!HookedList.Contains("SetSyncAction"))
            {
                HookedList.Add("SetSyncAction");
                On.AudioLoopMaster.SetSyncAction += SetSyncAction;
            }
        }

        internal static event Delegates.SetSyncAction_BeforeArgs _beforeSetSyncAction;
        internal static event Delegates.SetSyncAction_NormalArgs _afterSetSyncAction;

        private static void SetSyncAction(On.AudioLoopMaster.orig_SetSyncAction orig, AudioLoopMaster self, bool set)
        {
            Delegates.Params_SetSyncAction @params = new()
            {
                self = self, set = set
            };
            _beforeSetSyncAction?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetSyncAction != null) _afterSetSyncAction.Invoke(@params);
        }

        internal static void HookSetSyncSub()
        {
            if (!HookedList.Contains("SetSyncSub"))
            {
                HookedList.Add("SetSyncSub");
                On.AudioLoopMaster.SetSyncSub += SetSyncSub;
            }
        }

        internal static event Delegates.SetSyncSub_BeforeArgs _beforeSetSyncSub;
        internal static event Delegates.SetSyncSub_NormalArgs _afterSetSyncSub;

        private static void SetSyncSub(On.AudioLoopMaster.orig_SetSyncSub orig, AudioLoopMaster self, bool set)
        {
            Delegates.Params_SetSyncSub @params = new()
            {
                self = self, set = set
            };
            _beforeSetSyncSub?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetSyncSub != null) _afterSetSyncSub.Invoke(@params);
        }

        internal static void HookSetSyncMainAlt()
        {
            if (!HookedList.Contains("SetSyncMainAlt"))
            {
                HookedList.Add("SetSyncMainAlt");
                On.AudioLoopMaster.SetSyncMainAlt += SetSyncMainAlt;
            }
        }

        internal static event Delegates.SetSyncMainAlt_BeforeArgs _beforeSetSyncMainAlt;
        internal static event Delegates.SetSyncMainAlt_NormalArgs _afterSetSyncMainAlt;

        private static void SetSyncMainAlt(On.AudioLoopMaster.orig_SetSyncMainAlt orig, AudioLoopMaster self, bool set)
        {
            Delegates.Params_SetSyncMainAlt @params = new()
            {
                self = self, set = set
            };
            _beforeSetSyncMainAlt?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetSyncMainAlt != null) _afterSetSyncMainAlt.Invoke(@params);
        }

        internal static void HookSetSyncTension()
        {
            if (!HookedList.Contains("SetSyncTension"))
            {
                HookedList.Add("SetSyncTension");
                On.AudioLoopMaster.SetSyncTension += SetSyncTension;
            }
        }

        internal static event Delegates.SetSyncTension_BeforeArgs _beforeSetSyncTension;
        internal static event Delegates.SetSyncTension_NormalArgs _afterSetSyncTension;

        private static void SetSyncTension(On.AudioLoopMaster.orig_SetSyncTension orig, AudioLoopMaster self, bool set)
        {
            Delegates.Params_SetSyncTension @params = new()
            {
                self = self, set = set
            };
            _beforeSetSyncTension?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetSyncTension != null) _afterSetSyncTension.Invoke(@params);
        }

        internal static void HookSetSyncExtra()
        {
            if (!HookedList.Contains("SetSyncExtra"))
            {
                HookedList.Add("SetSyncExtra");
                On.AudioLoopMaster.SetSyncExtra += SetSyncExtra;
            }
        }

        internal static event Delegates.SetSyncExtra_BeforeArgs _beforeSetSyncExtra;
        internal static event Delegates.SetSyncExtra_NormalArgs _afterSetSyncExtra;

        private static void SetSyncExtra(On.AudioLoopMaster.orig_SetSyncExtra orig, AudioLoopMaster self, bool set)
        {
            Delegates.Params_SetSyncExtra @params = new()
            {
                self = self, set = set
            };
            _beforeSetSyncExtra?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetSyncExtra != null) _afterSetSyncExtra.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void SetSyncAction_BeforeArgs(Params_SetSyncAction args);

        public delegate void SetSyncAction_NormalArgs(Params_SetSyncAction args);

        public delegate void SetSyncExtra_BeforeArgs(Params_SetSyncExtra args);

        public delegate void SetSyncExtra_NormalArgs(Params_SetSyncExtra args);

        public delegate void SetSyncMainAlt_BeforeArgs(Params_SetSyncMainAlt args);

        public delegate void SetSyncMainAlt_NormalArgs(Params_SetSyncMainAlt args);

        public delegate void SetSyncSub_BeforeArgs(Params_SetSyncSub args);

        public delegate void SetSyncSub_NormalArgs(Params_SetSyncSub args);

        public delegate void SetSyncTension_BeforeArgs(Params_SetSyncTension args);

        public delegate void SetSyncTension_NormalArgs(Params_SetSyncTension args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Start
        {
            public AudioLoopMaster self;
        }

        public sealed class Params_Update
        {
            public AudioLoopMaster self;
        }

        public sealed class Params_SetSyncAction
        {
            public AudioLoopMaster self;
            public bool set;
        }

        public sealed class Params_SetSyncSub
        {
            public AudioLoopMaster self;
            public bool set;
        }

        public sealed class Params_SetSyncMainAlt
        {
            public AudioLoopMaster self;
            public bool set;
        }

        public sealed class Params_SetSyncTension
        {
            public AudioLoopMaster self;
            public bool set;
        }

        public sealed class Params_SetSyncExtra
        {
            public AudioLoopMaster self;
            public bool set;
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

        public static event Delegates.SetSyncAction_BeforeArgs SetSyncAction
        {
            add
            {
                HookHandler._beforeSetSyncAction += value;
                HookHandler.HookSetSyncAction();
            }
            remove => HookHandler._beforeSetSyncAction -= value;
        }

        public static event Delegates.SetSyncSub_BeforeArgs SetSyncSub
        {
            add
            {
                HookHandler._beforeSetSyncSub += value;
                HookHandler.HookSetSyncSub();
            }
            remove => HookHandler._beforeSetSyncSub -= value;
        }

        public static event Delegates.SetSyncMainAlt_BeforeArgs SetSyncMainAlt
        {
            add
            {
                HookHandler._beforeSetSyncMainAlt += value;
                HookHandler.HookSetSyncMainAlt();
            }
            remove => HookHandler._beforeSetSyncMainAlt -= value;
        }

        public static event Delegates.SetSyncTension_BeforeArgs SetSyncTension
        {
            add
            {
                HookHandler._beforeSetSyncTension += value;
                HookHandler.HookSetSyncTension();
            }
            remove => HookHandler._beforeSetSyncTension -= value;
        }

        public static event Delegates.SetSyncExtra_BeforeArgs SetSyncExtra
        {
            add
            {
                HookHandler._beforeSetSyncExtra += value;
                HookHandler.HookSetSyncExtra();
            }
            remove => HookHandler._beforeSetSyncExtra -= value;
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

        public static event Delegates.SetSyncAction_NormalArgs SetSyncAction
        {
            add
            {
                HookHandler._afterSetSyncAction += value;
                HookHandler.HookSetSyncAction();
            }
            remove => HookHandler._afterSetSyncAction -= value;
        }

        public static event Delegates.SetSyncSub_NormalArgs SetSyncSub
        {
            add
            {
                HookHandler._afterSetSyncSub += value;
                HookHandler.HookSetSyncSub();
            }
            remove => HookHandler._afterSetSyncSub -= value;
        }

        public static event Delegates.SetSyncMainAlt_NormalArgs SetSyncMainAlt
        {
            add
            {
                HookHandler._afterSetSyncMainAlt += value;
                HookHandler.HookSetSyncMainAlt();
            }
            remove => HookHandler._afterSetSyncMainAlt -= value;
        }

        public static event Delegates.SetSyncTension_NormalArgs SetSyncTension
        {
            add
            {
                HookHandler._afterSetSyncTension += value;
                HookHandler.HookSetSyncTension();
            }
            remove => HookHandler._afterSetSyncTension -= value;
        }

        public static event Delegates.SetSyncExtra_NormalArgs SetSyncExtra
        {
            add
            {
                HookHandler._afterSetSyncExtra += value;
                HookHandler.HookSetSyncExtra();
            }
            remove => HookHandler._afterSetSyncExtra -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.AudioLoopMaster.hook_Start Start
        {
            add => On.AudioLoopMaster.Start += value;
            remove => On.AudioLoopMaster.Start -= value;
        }

        public static event On.AudioLoopMaster.hook_Update Update
        {
            add => On.AudioLoopMaster.Update += value;
            remove => On.AudioLoopMaster.Update -= value;
        }

        public static event On.AudioLoopMaster.hook_SetSyncAction SetSyncAction
        {
            add => On.AudioLoopMaster.SetSyncAction += value;
            remove => On.AudioLoopMaster.SetSyncAction -= value;
        }

        public static event On.AudioLoopMaster.hook_SetSyncSub SetSyncSub
        {
            add => On.AudioLoopMaster.SetSyncSub += value;
            remove => On.AudioLoopMaster.SetSyncSub -= value;
        }

        public static event On.AudioLoopMaster.hook_SetSyncMainAlt SetSyncMainAlt
        {
            add => On.AudioLoopMaster.SetSyncMainAlt += value;
            remove => On.AudioLoopMaster.SetSyncMainAlt -= value;
        }

        public static event On.AudioLoopMaster.hook_SetSyncTension SetSyncTension
        {
            add => On.AudioLoopMaster.SetSyncTension += value;
            remove => On.AudioLoopMaster.SetSyncTension -= value;
        }

        public static event On.AudioLoopMaster.hook_SetSyncExtra SetSyncExtra
        {
            add => On.AudioLoopMaster.SetSyncExtra += value;
            remove => On.AudioLoopMaster.SetSyncExtra -= value;
        }
    }
}