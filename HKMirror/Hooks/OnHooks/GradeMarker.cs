using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GradeMarker class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGradeMarker
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.GradeMarker.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.GradeMarker.orig_OnEnable orig, GradeMarker self)
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
                On.GradeMarker.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.GradeMarker.orig_OnDisable orig, GradeMarker self)
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
                On.GradeMarker.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.GradeMarker.orig_Start orig, GradeMarker self)
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

        internal static void HookOnUnloadingLevel()
        {
            if (!HookedList.Contains("OnUnloadingLevel"))
            {
                HookedList.Add("OnUnloadingLevel");
                On.GradeMarker.OnUnloadingLevel += OnUnloadingLevel;
            }
        }

        internal static event Delegates.OnUnloadingLevel_BeforeArgs _beforeOnUnloadingLevel;
        internal static event Delegates.OnUnloadingLevel_NormalArgs _afterOnUnloadingLevel;

        private static void OnUnloadingLevel(On.GradeMarker.orig_OnUnloadingLevel orig, GradeMarker self)
        {
            Delegates.Params_OnUnloadingLevel @params = new()
            {
                self = self
            };
            _beforeOnUnloadingLevel?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnUnloadingLevel != null) _afterOnUnloadingLevel.Invoke(@params);
        }

        internal static void HookSetStartSizeForTrigger()
        {
            if (!HookedList.Contains("SetStartSizeForTrigger"))
            {
                HookedList.Add("SetStartSizeForTrigger");
                On.GradeMarker.SetStartSizeForTrigger += SetStartSizeForTrigger;
            }
        }

        internal static event Delegates.SetStartSizeForTrigger_BeforeArgs _beforeSetStartSizeForTrigger;
        internal static event Delegates.SetStartSizeForTrigger_NormalArgs _afterSetStartSizeForTrigger;

        private static void SetStartSizeForTrigger(On.GradeMarker.orig_SetStartSizeForTrigger orig, GradeMarker self)
        {
            Delegates.Params_SetStartSizeForTrigger @params = new()
            {
                self = self
            };
            _beforeSetStartSizeForTrigger?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSetStartSizeForTrigger != null) _afterSetStartSizeForTrigger.Invoke(@params);
        }

        internal static void HookActivate()
        {
            if (!HookedList.Contains("Activate"))
            {
                HookedList.Add("Activate");
                On.GradeMarker.Activate += Activate;
            }
        }

        internal static event Delegates.Activate_BeforeArgs _beforeActivate;
        internal static event Delegates.Activate_NormalArgs _afterActivate;

        private static void Activate(On.GradeMarker.orig_Activate orig, GradeMarker self)
        {
            Delegates.Params_Activate @params = new()
            {
                self = self
            };
            _beforeActivate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterActivate != null) _afterActivate.Invoke(@params);
        }

        internal static void HookDeactivate()
        {
            if (!HookedList.Contains("Deactivate"))
            {
                HookedList.Add("Deactivate");
                On.GradeMarker.Deactivate += Deactivate;
            }
        }

        internal static event Delegates.Deactivate_BeforeArgs _beforeDeactivate;
        internal static event Delegates.Deactivate_NormalArgs _afterDeactivate;

        private static void Deactivate(On.GradeMarker.orig_Deactivate orig, GradeMarker self)
        {
            Delegates.Params_Deactivate @params = new()
            {
                self = self
            };
            _beforeDeactivate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDeactivate != null) _afterDeactivate.Invoke(@params);
        }

        internal static void HookActivateGradual()
        {
            if (!HookedList.Contains("ActivateGradual"))
            {
                HookedList.Add("ActivateGradual");
                On.GradeMarker.ActivateGradual += ActivateGradual;
            }
        }

        internal static event Delegates.ActivateGradual_BeforeArgs _beforeActivateGradual;
        internal static event Delegates.ActivateGradual_NormalArgs _afterActivateGradual;

        private static void ActivateGradual(On.GradeMarker.orig_ActivateGradual orig, GradeMarker self)
        {
            Delegates.Params_ActivateGradual @params = new()
            {
                self = self
            };
            _beforeActivateGradual?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterActivateGradual != null) _afterActivateGradual.Invoke(@params);
        }

        internal static void HookDeactivateGradual()
        {
            if (!HookedList.Contains("DeactivateGradual"))
            {
                HookedList.Add("DeactivateGradual");
                On.GradeMarker.DeactivateGradual += DeactivateGradual;
            }
        }

        internal static event Delegates.DeactivateGradual_BeforeArgs _beforeDeactivateGradual;
        internal static event Delegates.DeactivateGradual_NormalArgs _afterDeactivateGradual;

        private static void DeactivateGradual(On.GradeMarker.orig_DeactivateGradual orig, GradeMarker self)
        {
            Delegates.Params_DeactivateGradual @params = new()
            {
                self = self
            };
            _beforeDeactivateGradual?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDeactivateGradual != null) _afterDeactivateGradual.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.GradeMarker.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.GradeMarker.orig_Update orig, GradeMarker self)
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

        internal static void HookUpdateLow()
        {
            if (!HookedList.Contains("UpdateLow"))
            {
                HookedList.Add("UpdateLow");
                On.GradeMarker.UpdateLow += UpdateLow;
            }
        }

        internal static event Delegates.UpdateLow_BeforeArgs _beforeUpdateLow;
        internal static event Delegates.UpdateLow_NormalArgs _afterUpdateLow;

        private static void UpdateLow(On.GradeMarker.orig_UpdateLow orig, GradeMarker self)
        {
            Delegates.Params_UpdateLow @params = new()
            {
                self = self
            };
            _beforeUpdateLow?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdateLow != null) _afterUpdateLow.Invoke(@params);
        }

        internal static void Hookorig_Start()
        {
            if (!HookedList.Contains("orig_Start"))
            {
                HookedList.Add("orig_Start");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Start"), orig_Start);
            }
        }

        internal static event Delegates.orig_Start_BeforeArgs _beforeorig_Start;
        internal static event Delegates.orig_Start_NormalArgs _afterorig_Start;

        private static void orig_Start(Action<GradeMarker> orig, GradeMarker self)
        {
            Delegates.Params_orig_Start @params = new()
            {
                self = self
            };
            _beforeorig_Start?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterorig_Start != null) _afterorig_Start.Invoke(@params);
        }

        internal static void HookOnStart()
        {
            if (!HookedList.Contains("OnStart"))
            {
                HookedList.Add("OnStart");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "OnStart"), OnStart);
            }
        }

        internal static event Delegates.OnStart_BeforeArgs _beforeOnStart;

        private static IEnumerator OnStart(Func<GradeMarker, IEnumerator> orig, GradeMarker self)
        {
            Delegates.Params_OnStart @params = new()
            {
                self = self
            };
            _beforeOnStart?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void Hookorig_Update()
        {
            if (!HookedList.Contains("orig_Update"))
            {
                HookedList.Add("orig_Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Update"), orig_Update);
            }
        }

        internal static event Delegates.orig_Update_BeforeArgs _beforeorig_Update;
        internal static event Delegates.orig_Update_NormalArgs _afterorig_Update;

        private static void orig_Update(Action<GradeMarker> orig, GradeMarker self)
        {
            Delegates.Params_orig_Update @params = new()
            {
                self = self
            };
            _beforeorig_Update?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterorig_Update != null) _afterorig_Update.Invoke(@params);
        }

        internal static void Hookorig_UpdateLow()
        {
            if (!HookedList.Contains("orig_UpdateLow"))
            {
                HookedList.Add("orig_UpdateLow");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_UpdateLow"), orig_UpdateLow);
            }
        }

        internal static event Delegates.orig_UpdateLow_BeforeArgs _beforeorig_UpdateLow;
        internal static event Delegates.orig_UpdateLow_NormalArgs _afterorig_UpdateLow;

        private static void orig_UpdateLow(Action<GradeMarker> orig, GradeMarker self)
        {
            Delegates.Params_orig_UpdateLow @params = new()
            {
                self = self
            };
            _beforeorig_UpdateLow?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterorig_UpdateLow != null) _afterorig_UpdateLow.Invoke(@params);
        }

        internal static void Hookorig_Deactivate()
        {
            if (!HookedList.Contains("orig_Deactivate"))
            {
                HookedList.Add("orig_Deactivate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Deactivate"), orig_Deactivate);
            }
        }

        internal static event Delegates.orig_Deactivate_BeforeArgs _beforeorig_Deactivate;
        internal static event Delegates.orig_Deactivate_NormalArgs _afterorig_Deactivate;

        private static void orig_Deactivate(Action<GradeMarker> orig, GradeMarker self)
        {
            Delegates.Params_orig_Deactivate @params = new()
            {
                self = self
            };
            _beforeorig_Deactivate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterorig_Deactivate != null) _afterorig_Deactivate.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Activate_BeforeArgs(Params_Activate args);

        public delegate void Activate_NormalArgs(Params_Activate args);

        public delegate void ActivateGradual_BeforeArgs(Params_ActivateGradual args);

        public delegate void ActivateGradual_NormalArgs(Params_ActivateGradual args);

        public delegate void Deactivate_BeforeArgs(Params_Deactivate args);

        public delegate void Deactivate_NormalArgs(Params_Deactivate args);

        public delegate void DeactivateGradual_BeforeArgs(Params_DeactivateGradual args);

        public delegate void DeactivateGradual_NormalArgs(Params_DeactivateGradual args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void OnStart_BeforeArgs(Params_OnStart args);

        public delegate IEnumerator OnStart_NormalArgs(Params_OnStart args);

        public delegate void OnUnloadingLevel_BeforeArgs(Params_OnUnloadingLevel args);

        public delegate void OnUnloadingLevel_NormalArgs(Params_OnUnloadingLevel args);

        public delegate void orig_Deactivate_BeforeArgs(Params_orig_Deactivate args);

        public delegate void orig_Deactivate_NormalArgs(Params_orig_Deactivate args);

        public delegate void orig_Start_BeforeArgs(Params_orig_Start args);

        public delegate void orig_Start_NormalArgs(Params_orig_Start args);

        public delegate void orig_Update_BeforeArgs(Params_orig_Update args);

        public delegate void orig_Update_NormalArgs(Params_orig_Update args);

        public delegate void orig_UpdateLow_BeforeArgs(Params_orig_UpdateLow args);

        public delegate void orig_UpdateLow_NormalArgs(Params_orig_UpdateLow args);

        public delegate void SetStartSizeForTrigger_BeforeArgs(Params_SetStartSizeForTrigger args);

        public delegate void SetStartSizeForTrigger_NormalArgs(Params_SetStartSizeForTrigger args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public delegate void UpdateLow_BeforeArgs(Params_UpdateLow args);

        public delegate void UpdateLow_NormalArgs(Params_UpdateLow args);

        public sealed class Params_OnEnable
        {
            public GradeMarker self;
        }

        public sealed class Params_OnDisable
        {
            public GradeMarker self;
        }

        public sealed class Params_Start
        {
            public GradeMarker self;
        }

        public sealed class Params_OnUnloadingLevel
        {
            public GradeMarker self;
        }

        public sealed class Params_SetStartSizeForTrigger
        {
            public GradeMarker self;
        }

        public sealed class Params_Activate
        {
            public GradeMarker self;
        }

        public sealed class Params_Deactivate
        {
            public GradeMarker self;
        }

        public sealed class Params_ActivateGradual
        {
            public GradeMarker self;
        }

        public sealed class Params_DeactivateGradual
        {
            public GradeMarker self;
        }

        public sealed class Params_Update
        {
            public GradeMarker self;
        }

        public sealed class Params_UpdateLow
        {
            public GradeMarker self;
        }

        public sealed class Params_orig_Start
        {
            public GradeMarker self;
        }

        public sealed class Params_OnStart
        {
            public GradeMarker self;
        }

        public sealed class Params_orig_Update
        {
            public GradeMarker self;
        }

        public sealed class Params_orig_UpdateLow
        {
            public GradeMarker self;
        }

        public sealed class Params_orig_Deactivate
        {
            public GradeMarker self;
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

        public static event Delegates.OnUnloadingLevel_BeforeArgs OnUnloadingLevel
        {
            add
            {
                HookHandler._beforeOnUnloadingLevel += value;
                HookHandler.HookOnUnloadingLevel();
            }
            remove => HookHandler._beforeOnUnloadingLevel -= value;
        }

        public static event Delegates.SetStartSizeForTrigger_BeforeArgs SetStartSizeForTrigger
        {
            add
            {
                HookHandler._beforeSetStartSizeForTrigger += value;
                HookHandler.HookSetStartSizeForTrigger();
            }
            remove => HookHandler._beforeSetStartSizeForTrigger -= value;
        }

        public static event Delegates.Activate_BeforeArgs Activate
        {
            add
            {
                HookHandler._beforeActivate += value;
                HookHandler.HookActivate();
            }
            remove => HookHandler._beforeActivate -= value;
        }

        public static event Delegates.Deactivate_BeforeArgs Deactivate
        {
            add
            {
                HookHandler._beforeDeactivate += value;
                HookHandler.HookDeactivate();
            }
            remove => HookHandler._beforeDeactivate -= value;
        }

        public static event Delegates.ActivateGradual_BeforeArgs ActivateGradual
        {
            add
            {
                HookHandler._beforeActivateGradual += value;
                HookHandler.HookActivateGradual();
            }
            remove => HookHandler._beforeActivateGradual -= value;
        }

        public static event Delegates.DeactivateGradual_BeforeArgs DeactivateGradual
        {
            add
            {
                HookHandler._beforeDeactivateGradual += value;
                HookHandler.HookDeactivateGradual();
            }
            remove => HookHandler._beforeDeactivateGradual -= value;
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

        public static event Delegates.UpdateLow_BeforeArgs UpdateLow
        {
            add
            {
                HookHandler._beforeUpdateLow += value;
                HookHandler.HookUpdateLow();
            }
            remove => HookHandler._beforeUpdateLow -= value;
        }

        public static event Delegates.orig_Start_BeforeArgs orig_Start
        {
            add
            {
                HookHandler._beforeorig_Start += value;
                HookHandler.Hookorig_Start();
            }
            remove => HookHandler._beforeorig_Start -= value;
        }

        public static event Delegates.OnStart_BeforeArgs OnStart
        {
            add
            {
                HookHandler._beforeOnStart += value;
                HookHandler.HookOnStart();
            }
            remove => HookHandler._beforeOnStart -= value;
        }

        public static event Delegates.orig_Update_BeforeArgs orig_Update
        {
            add
            {
                HookHandler._beforeorig_Update += value;
                HookHandler.Hookorig_Update();
            }
            remove => HookHandler._beforeorig_Update -= value;
        }

        public static event Delegates.orig_UpdateLow_BeforeArgs orig_UpdateLow
        {
            add
            {
                HookHandler._beforeorig_UpdateLow += value;
                HookHandler.Hookorig_UpdateLow();
            }
            remove => HookHandler._beforeorig_UpdateLow -= value;
        }

        public static event Delegates.orig_Deactivate_BeforeArgs orig_Deactivate
        {
            add
            {
                HookHandler._beforeorig_Deactivate += value;
                HookHandler.Hookorig_Deactivate();
            }
            remove => HookHandler._beforeorig_Deactivate -= value;
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

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.OnUnloadingLevel_NormalArgs OnUnloadingLevel
        {
            add
            {
                HookHandler._afterOnUnloadingLevel += value;
                HookHandler.HookOnUnloadingLevel();
            }
            remove => HookHandler._afterOnUnloadingLevel -= value;
        }

        public static event Delegates.SetStartSizeForTrigger_NormalArgs SetStartSizeForTrigger
        {
            add
            {
                HookHandler._afterSetStartSizeForTrigger += value;
                HookHandler.HookSetStartSizeForTrigger();
            }
            remove => HookHandler._afterSetStartSizeForTrigger -= value;
        }

        public static event Delegates.Activate_NormalArgs Activate
        {
            add
            {
                HookHandler._afterActivate += value;
                HookHandler.HookActivate();
            }
            remove => HookHandler._afterActivate -= value;
        }

        public static event Delegates.Deactivate_NormalArgs Deactivate
        {
            add
            {
                HookHandler._afterDeactivate += value;
                HookHandler.HookDeactivate();
            }
            remove => HookHandler._afterDeactivate -= value;
        }

        public static event Delegates.ActivateGradual_NormalArgs ActivateGradual
        {
            add
            {
                HookHandler._afterActivateGradual += value;
                HookHandler.HookActivateGradual();
            }
            remove => HookHandler._afterActivateGradual -= value;
        }

        public static event Delegates.DeactivateGradual_NormalArgs DeactivateGradual
        {
            add
            {
                HookHandler._afterDeactivateGradual += value;
                HookHandler.HookDeactivateGradual();
            }
            remove => HookHandler._afterDeactivateGradual -= value;
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

        public static event Delegates.UpdateLow_NormalArgs UpdateLow
        {
            add
            {
                HookHandler._afterUpdateLow += value;
                HookHandler.HookUpdateLow();
            }
            remove => HookHandler._afterUpdateLow -= value;
        }

        public static event Delegates.orig_Start_NormalArgs orig_Start
        {
            add
            {
                HookHandler._afterorig_Start += value;
                HookHandler.Hookorig_Start();
            }
            remove => HookHandler._afterorig_Start -= value;
        }

        public static event Delegates.orig_Update_NormalArgs orig_Update
        {
            add
            {
                HookHandler._afterorig_Update += value;
                HookHandler.Hookorig_Update();
            }
            remove => HookHandler._afterorig_Update -= value;
        }

        public static event Delegates.orig_UpdateLow_NormalArgs orig_UpdateLow
        {
            add
            {
                HookHandler._afterorig_UpdateLow += value;
                HookHandler.Hookorig_UpdateLow();
            }
            remove => HookHandler._afterorig_UpdateLow -= value;
        }

        public static event Delegates.orig_Deactivate_NormalArgs orig_Deactivate
        {
            add
            {
                HookHandler._afterorig_Deactivate += value;
                HookHandler.Hookorig_Deactivate();
            }
            remove => HookHandler._afterorig_Deactivate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GradeMarker.hook_OnEnable OnEnable
        {
            add => On.GradeMarker.OnEnable += value;
            remove => On.GradeMarker.OnEnable -= value;
        }

        public static event On.GradeMarker.hook_OnDisable OnDisable
        {
            add => On.GradeMarker.OnDisable += value;
            remove => On.GradeMarker.OnDisable -= value;
        }

        public static event On.GradeMarker.hook_Start Start
        {
            add => On.GradeMarker.Start += value;
            remove => On.GradeMarker.Start -= value;
        }

        public static event On.GradeMarker.hook_OnUnloadingLevel OnUnloadingLevel
        {
            add => On.GradeMarker.OnUnloadingLevel += value;
            remove => On.GradeMarker.OnUnloadingLevel -= value;
        }

        public static event On.GradeMarker.hook_SetStartSizeForTrigger SetStartSizeForTrigger
        {
            add => On.GradeMarker.SetStartSizeForTrigger += value;
            remove => On.GradeMarker.SetStartSizeForTrigger -= value;
        }

        public static event On.GradeMarker.hook_Activate Activate
        {
            add => On.GradeMarker.Activate += value;
            remove => On.GradeMarker.Activate -= value;
        }

        public static event On.GradeMarker.hook_Deactivate Deactivate
        {
            add => On.GradeMarker.Deactivate += value;
            remove => On.GradeMarker.Deactivate -= value;
        }

        public static event On.GradeMarker.hook_ActivateGradual ActivateGradual
        {
            add => On.GradeMarker.ActivateGradual += value;
            remove => On.GradeMarker.ActivateGradual -= value;
        }

        public static event On.GradeMarker.hook_DeactivateGradual DeactivateGradual
        {
            add => On.GradeMarker.DeactivateGradual += value;
            remove => On.GradeMarker.DeactivateGradual -= value;
        }

        public static event On.GradeMarker.hook_Update Update
        {
            add => On.GradeMarker.Update += value;
            remove => On.GradeMarker.Update -= value;
        }

        public static event On.GradeMarker.hook_UpdateLow UpdateLow
        {
            add => On.GradeMarker.UpdateLow += value;
            remove => On.GradeMarker.UpdateLow -= value;
        }

        public static event Delegates.orig_Start_NormalArgs orig_Start
        {
            add => HookEndpointManager.Add<Delegates.orig_Start_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Start"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_Start_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Start"), value);
        }

        public static event Delegates.OnStart_NormalArgs OnStart
        {
            add => HookEndpointManager.Add<Delegates.OnStart_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "OnStart"), value);
            remove => HookEndpointManager.Remove<Delegates.OnStart_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "OnStart"), value);
        }

        public static event Delegates.orig_Update_NormalArgs orig_Update
        {
            add => HookEndpointManager.Add<Delegates.orig_Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Update"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Update"), value);
        }

        public static event Delegates.orig_UpdateLow_NormalArgs orig_UpdateLow
        {
            add => HookEndpointManager.Add<Delegates.orig_UpdateLow_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_UpdateLow"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_UpdateLow_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_UpdateLow"), value);
        }

        public static event Delegates.orig_Deactivate_NormalArgs orig_Deactivate
        {
            add => HookEndpointManager.Add<Delegates.orig_Deactivate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Deactivate"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_Deactivate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Deactivate"), value);
        }
    }
}