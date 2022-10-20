namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for OpeningSequence class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnOpeningSequence
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.OpeningSequence.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.OpeningSequence.orig_OnEnable orig, OpeningSequence self)
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

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.OpeningSequence.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.OpeningSequence.orig_OnDisable orig, OpeningSequence self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            _beforeOnDisable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnDisable != null) _afterOnDisable.Invoke(@params);
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.OpeningSequence.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;

        private static IEnumerator Start(On.OpeningSequence.orig_Start orig, OpeningSequence self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookStartAsync()
        {
            if (!HookedList.Contains("StartAsync"))
            {
                HookedList.Add("StartAsync");
                On.OpeningSequence.StartAsync += StartAsync;
            }
        }

        internal static event Delegates.StartAsync_BeforeArgs _beforeStartAsync;

        private static IEnumerator StartAsync(On.OpeningSequence.orig_StartAsync orig, OpeningSequence self)
        {
            Delegates.Params_StartAsync @params = new()
            {
                self = self
            };
            _beforeStartAsync?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookStartSync()
        {
            if (!HookedList.Contains("StartSync"))
            {
                HookedList.Add("StartSync");
                On.OpeningSequence.StartSync += StartSync;
            }
        }

        internal static event Delegates.StartSync_BeforeArgs _beforeStartSync;

        private static IEnumerator StartSync(On.OpeningSequence.orig_StartSync orig, OpeningSequence self)
        {
            Delegates.Params_StartSync @params = new()
            {
                self = self
            };
            _beforeStartSync?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.OpeningSequence.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.OpeningSequence.orig_Update orig, OpeningSequence self)
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

        internal static void HookIsLevelReady()
        {
            if (!HookedList.Contains("IsLevelReady"))
            {
                HookedList.Add("IsLevelReady");
                On.OpeningSequence.IsLevelReady += IsLevelReady;
            }
        }

        internal static event Delegates.IsLevelReady_BeforeArgs _beforeIsLevelReady;
        internal static event Delegates.IsLevelReady_NormalArgs _afterIsLevelReady;

        private static bool IsLevelReady(On.OpeningSequence.orig_IsLevelReady orig, AsyncOperation operation)
        {
            Delegates.Params_IsLevelReady @params = new()
            {
                operation = operation
            };
            _beforeIsLevelReady?.Invoke(@params);
            operation = @params.operation;
            var retVal = orig(operation);
            if (_afterIsLevelReady != null) retVal = _afterIsLevelReady.Invoke(@params);
            return retVal;
        }

        internal static void HookSkip()
        {
            if (!HookedList.Contains("Skip"))
            {
                HookedList.Add("Skip");
                On.OpeningSequence.Skip += Skip;
            }
        }

        internal static event Delegates.Skip_BeforeArgs _beforeSkip;

        private static IEnumerator Skip(On.OpeningSequence.orig_Skip orig, OpeningSequence self)
        {
            Delegates.Params_Skip @params = new()
            {
                self = self
            };
            _beforeSkip?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookOnChangingSequences()
        {
            if (!HookedList.Contains("OnChangingSequences"))
            {
                HookedList.Add("OnChangingSequences");
                On.OpeningSequence.OnChangingSequences += OnChangingSequences;
            }
        }

        internal static event Delegates.OnChangingSequences_BeforeArgs _beforeOnChangingSequences;
        internal static event Delegates.OnChangingSequences_NormalArgs _afterOnChangingSequences;

        private static void OnChangingSequences(On.OpeningSequence.orig_OnChangingSequences orig, OpeningSequence self)
        {
            Delegates.Params_OnChangingSequences @params = new()
            {
                self = self
            };
            _beforeOnChangingSequences?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnChangingSequences != null) _afterOnChangingSequences.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void IsLevelReady_BeforeArgs(Params_IsLevelReady args);

        public delegate bool IsLevelReady_NormalArgs(Params_IsLevelReady args);

        public delegate void OnChangingSequences_BeforeArgs(Params_OnChangingSequences args);

        public delegate void OnChangingSequences_NormalArgs(Params_OnChangingSequences args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void Skip_BeforeArgs(Params_Skip args);

        public delegate IEnumerator Skip_NormalArgs(Params_Skip args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate IEnumerator Start_NormalArgs(Params_Start args);

        public delegate void StartAsync_BeforeArgs(Params_StartAsync args);

        public delegate IEnumerator StartAsync_NormalArgs(Params_StartAsync args);

        public delegate void StartSync_BeforeArgs(Params_StartSync args);

        public delegate IEnumerator StartSync_NormalArgs(Params_StartSync args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_OnEnable
        {
            public OpeningSequence self;
        }

        public sealed class Params_OnDisable
        {
            public OpeningSequence self;
        }

        public sealed class Params_Start
        {
            public OpeningSequence self;
        }

        public sealed class Params_StartAsync
        {
            public OpeningSequence self;
        }

        public sealed class Params_StartSync
        {
            public OpeningSequence self;
        }

        public sealed class Params_Update
        {
            public OpeningSequence self;
        }

        public sealed class Params_IsLevelReady
        {
            public AsyncOperation operation;
        }

        public sealed class Params_Skip
        {
            public OpeningSequence self;
        }

        public sealed class Params_OnChangingSequences
        {
            public OpeningSequence self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
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

        public static event Delegates.StartAsync_BeforeArgs StartAsync
        {
            add
            {
                HookHandler._beforeStartAsync += value;
                HookHandler.HookStartAsync();
            }
            remove => HookHandler._beforeStartAsync -= value;
        }

        public static event Delegates.StartSync_BeforeArgs StartSync
        {
            add
            {
                HookHandler._beforeStartSync += value;
                HookHandler.HookStartSync();
            }
            remove => HookHandler._beforeStartSync -= value;
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

        public static event Delegates.IsLevelReady_BeforeArgs IsLevelReady
        {
            add
            {
                HookHandler._beforeIsLevelReady += value;
                HookHandler.HookIsLevelReady();
            }
            remove => HookHandler._beforeIsLevelReady -= value;
        }

        public static event Delegates.Skip_BeforeArgs Skip
        {
            add
            {
                HookHandler._beforeSkip += value;
                HookHandler.HookSkip();
            }
            remove => HookHandler._beforeSkip -= value;
        }

        public static event Delegates.OnChangingSequences_BeforeArgs OnChangingSequences
        {
            add
            {
                HookHandler._beforeOnChangingSequences += value;
                HookHandler.HookOnChangingSequences();
            }
            remove => HookHandler._beforeOnChangingSequences -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
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

        public static event Delegates.IsLevelReady_NormalArgs IsLevelReady
        {
            add
            {
                HookHandler._afterIsLevelReady += value;
                HookHandler.HookIsLevelReady();
            }
            remove => HookHandler._afterIsLevelReady -= value;
        }

        public static event Delegates.OnChangingSequences_NormalArgs OnChangingSequences
        {
            add
            {
                HookHandler._afterOnChangingSequences += value;
                HookHandler.HookOnChangingSequences();
            }
            remove => HookHandler._afterOnChangingSequences -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.OpeningSequence.hook_OnEnable OnEnable
        {
            add => On.OpeningSequence.OnEnable += value;
            remove => On.OpeningSequence.OnEnable -= value;
        }

        public static event On.OpeningSequence.hook_OnDisable OnDisable
        {
            add => On.OpeningSequence.OnDisable += value;
            remove => On.OpeningSequence.OnDisable -= value;
        }

        public static event On.OpeningSequence.hook_Start Start
        {
            add => On.OpeningSequence.Start += value;
            remove => On.OpeningSequence.Start -= value;
        }

        public static event On.OpeningSequence.hook_StartAsync StartAsync
        {
            add => On.OpeningSequence.StartAsync += value;
            remove => On.OpeningSequence.StartAsync -= value;
        }

        public static event On.OpeningSequence.hook_StartSync StartSync
        {
            add => On.OpeningSequence.StartSync += value;
            remove => On.OpeningSequence.StartSync -= value;
        }

        public static event On.OpeningSequence.hook_Update Update
        {
            add => On.OpeningSequence.Update += value;
            remove => On.OpeningSequence.Update -= value;
        }

        public static event On.OpeningSequence.hook_IsLevelReady IsLevelReady
        {
            add => On.OpeningSequence.IsLevelReady += value;
            remove => On.OpeningSequence.IsLevelReady -= value;
        }

        public static event On.OpeningSequence.hook_Skip Skip
        {
            add => On.OpeningSequence.Skip += value;
            remove => On.OpeningSequence.Skip -= value;
        }

        public static event On.OpeningSequence.hook_OnChangingSequences OnChangingSequences
        {
            add => On.OpeningSequence.OnChangingSequences += value;
            remove => On.OpeningSequence.OnChangingSequences -= value;
        }
    }
}