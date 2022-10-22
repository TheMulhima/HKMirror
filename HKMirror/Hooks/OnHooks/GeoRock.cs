namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GeoRock class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGeoRock
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.GeoRock.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.GeoRock.orig_OnEnable orig, GeoRock self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.GeoRock.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.GeoRock.orig_OnDisable orig, GeoRock self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                    try
                    {
                        _afterOnDisable.Invoke(@params);
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
                On.GeoRock.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.GeoRock.orig_Start orig, GeoRock self)
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

        internal static void HookLevelActivated()
        {
            if (!HookedList.Contains("LevelActivated"))
            {
                HookedList.Add("LevelActivated");
                On.GeoRock.LevelActivated += LevelActivated;
            }
        }

        internal static event Delegates.LevelActivated_BeforeArgs _beforeLevelActivated;
        internal static event Delegates.LevelActivated_AfterArgs _afterLevelActivated;

        private static void LevelActivated(On.GeoRock.orig_LevelActivated orig, GeoRock self, Scene sceneFrom,
            Scene sceneTo)
        {
            Delegates.Params_LevelActivated @params = new()
            {
                self = self, sceneFrom = sceneFrom, sceneTo = sceneTo
            };
            if (_beforeLevelActivated != null)
                foreach (Delegates.LevelActivated_BeforeArgs toInvoke in _beforeLevelActivated.GetInvocationList())
                    try
                    {
                        _beforeLevelActivated?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            sceneFrom = @params.sceneFrom;
            sceneTo = @params.sceneTo;
            orig(self, sceneFrom, sceneTo);
            if (_afterLevelActivated != null)
                foreach (Delegates.LevelActivated_AfterArgs toInvoke in _afterLevelActivated.GetInvocationList())
                    try
                    {
                        _afterLevelActivated.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSaveState()
        {
            if (!HookedList.Contains("SaveState"))
            {
                HookedList.Add("SaveState");
                On.GeoRock.SaveState += SaveState;
            }
        }

        internal static event Delegates.SaveState_BeforeArgs _beforeSaveState;
        internal static event Delegates.SaveState_AfterArgs _afterSaveState;

        private static void SaveState(On.GeoRock.orig_SaveState orig, GeoRock self)
        {
            Delegates.Params_SaveState @params = new()
            {
                self = self
            };
            if (_beforeSaveState != null)
                foreach (Delegates.SaveState_BeforeArgs toInvoke in _beforeSaveState.GetInvocationList())
                    try
                    {
                        _beforeSaveState?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSaveState != null)
                foreach (Delegates.SaveState_AfterArgs toInvoke in _afterSaveState.GetInvocationList())
                    try
                    {
                        _afterSaveState.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetMyID()
        {
            if (!HookedList.Contains("SetMyID"))
            {
                HookedList.Add("SetMyID");
                On.GeoRock.SetMyID += SetMyID;
            }
        }

        internal static event Delegates.SetMyID_BeforeArgs _beforeSetMyID;
        internal static event Delegates.SetMyID_AfterArgs _afterSetMyID;

        private static void SetMyID(On.GeoRock.orig_SetMyID orig, GeoRock self)
        {
            Delegates.Params_SetMyID @params = new()
            {
                self = self
            };
            if (_beforeSetMyID != null)
                foreach (Delegates.SetMyID_BeforeArgs toInvoke in _beforeSetMyID.GetInvocationList())
                    try
                    {
                        _beforeSetMyID?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetMyID != null)
                foreach (Delegates.SetMyID_AfterArgs toInvoke in _afterSetMyID.GetInvocationList())
                    try
                    {
                        _afterSetMyID.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdateHitsLeftFromFSM()
        {
            if (!HookedList.Contains("UpdateHitsLeftFromFSM"))
            {
                HookedList.Add("UpdateHitsLeftFromFSM");
                On.GeoRock.UpdateHitsLeftFromFSM += UpdateHitsLeftFromFSM;
            }
        }

        internal static event Delegates.UpdateHitsLeftFromFSM_BeforeArgs _beforeUpdateHitsLeftFromFSM;
        internal static event Delegates.UpdateHitsLeftFromFSM_AfterArgs _afterUpdateHitsLeftFromFSM;

        private static void UpdateHitsLeftFromFSM(On.GeoRock.orig_UpdateHitsLeftFromFSM orig, GeoRock self)
        {
            Delegates.Params_UpdateHitsLeftFromFSM @params = new()
            {
                self = self
            };
            if (_beforeUpdateHitsLeftFromFSM != null)
                foreach (Delegates.UpdateHitsLeftFromFSM_BeforeArgs toInvoke in _beforeUpdateHitsLeftFromFSM
                             .GetInvocationList())
                    try
                    {
                        _beforeUpdateHitsLeftFromFSM?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateHitsLeftFromFSM != null)
                foreach (Delegates.UpdateHitsLeftFromFSM_AfterArgs toInvoke in _afterUpdateHitsLeftFromFSM
                             .GetInvocationList())
                    try
                    {
                        _afterUpdateHitsLeftFromFSM.Invoke(@params);
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
        public delegate void LevelActivated_AfterArgs(Params_LevelActivated args);

        public delegate void LevelActivated_BeforeArgs(Params_LevelActivated args);

        public delegate void LevelActivated_WithArgs(Action<GeoRock, Scene, Scene> orig, GeoRock self, Scene sceneFrom,
            Scene sceneTo);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<GeoRock> orig, GeoRock self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<GeoRock> orig, GeoRock self);

        public delegate void SaveState_AfterArgs(Params_SaveState args);

        public delegate void SaveState_BeforeArgs(Params_SaveState args);

        public delegate void SaveState_WithArgs(Action<GeoRock> orig, GeoRock self);

        public delegate void SetMyID_AfterArgs(Params_SetMyID args);

        public delegate void SetMyID_BeforeArgs(Params_SetMyID args);

        public delegate void SetMyID_WithArgs(Action<GeoRock> orig, GeoRock self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<GeoRock> orig, GeoRock self);

        public delegate void UpdateHitsLeftFromFSM_AfterArgs(Params_UpdateHitsLeftFromFSM args);

        public delegate void UpdateHitsLeftFromFSM_BeforeArgs(Params_UpdateHitsLeftFromFSM args);

        public delegate void UpdateHitsLeftFromFSM_WithArgs(Action<GeoRock> orig, GeoRock self);

        public sealed class Params_OnEnable
        {
            public GeoRock self;
        }

        public sealed class Params_OnDisable
        {
            public GeoRock self;
        }

        public sealed class Params_Start
        {
            public GeoRock self;
        }

        public sealed class Params_LevelActivated
        {
            public Scene sceneFrom;
            public Scene sceneTo;
            public GeoRock self;
        }

        public sealed class Params_SaveState
        {
            public GeoRock self;
        }

        public sealed class Params_SetMyID
        {
            public GeoRock self;
        }

        public sealed class Params_UpdateHitsLeftFromFSM
        {
            public GeoRock self;
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

        public static event Delegates.LevelActivated_BeforeArgs LevelActivated
        {
            add
            {
                HookHandler._beforeLevelActivated += value;
                HookHandler.HookLevelActivated();
            }
            remove => HookHandler._beforeLevelActivated -= value;
        }

        public static event Delegates.SaveState_BeforeArgs SaveState
        {
            add
            {
                HookHandler._beforeSaveState += value;
                HookHandler.HookSaveState();
            }
            remove => HookHandler._beforeSaveState -= value;
        }

        public static event Delegates.SetMyID_BeforeArgs SetMyID
        {
            add
            {
                HookHandler._beforeSetMyID += value;
                HookHandler.HookSetMyID();
            }
            remove => HookHandler._beforeSetMyID -= value;
        }

        public static event Delegates.UpdateHitsLeftFromFSM_BeforeArgs UpdateHitsLeftFromFSM
        {
            add
            {
                HookHandler._beforeUpdateHitsLeftFromFSM += value;
                HookHandler.HookUpdateHitsLeftFromFSM();
            }
            remove => HookHandler._beforeUpdateHitsLeftFromFSM -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_AfterArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
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

        public static event Delegates.LevelActivated_AfterArgs LevelActivated
        {
            add
            {
                HookHandler._afterLevelActivated += value;
                HookHandler.HookLevelActivated();
            }
            remove => HookHandler._afterLevelActivated -= value;
        }

        public static event Delegates.SaveState_AfterArgs SaveState
        {
            add
            {
                HookHandler._afterSaveState += value;
                HookHandler.HookSaveState();
            }
            remove => HookHandler._afterSaveState -= value;
        }

        public static event Delegates.SetMyID_AfterArgs SetMyID
        {
            add
            {
                HookHandler._afterSetMyID += value;
                HookHandler.HookSetMyID();
            }
            remove => HookHandler._afterSetMyID -= value;
        }

        public static event Delegates.UpdateHitsLeftFromFSM_AfterArgs UpdateHitsLeftFromFSM
        {
            add
            {
                HookHandler._afterUpdateHitsLeftFromFSM += value;
                HookHandler.HookUpdateHitsLeftFromFSM();
            }
            remove => HookHandler._afterUpdateHitsLeftFromFSM -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GeoRock.hook_OnEnable OnEnable
        {
            add => On.GeoRock.OnEnable += value;
            remove => On.GeoRock.OnEnable -= value;
        }

        public static event On.GeoRock.hook_OnDisable OnDisable
        {
            add => On.GeoRock.OnDisable += value;
            remove => On.GeoRock.OnDisable -= value;
        }

        public static event On.GeoRock.hook_Start Start
        {
            add => On.GeoRock.Start += value;
            remove => On.GeoRock.Start -= value;
        }

        public static event On.GeoRock.hook_LevelActivated LevelActivated
        {
            add => On.GeoRock.LevelActivated += value;
            remove => On.GeoRock.LevelActivated -= value;
        }

        public static event On.GeoRock.hook_SaveState SaveState
        {
            add => On.GeoRock.SaveState += value;
            remove => On.GeoRock.SaveState -= value;
        }

        public static event On.GeoRock.hook_SetMyID SetMyID
        {
            add => On.GeoRock.SetMyID += value;
            remove => On.GeoRock.SetMyID -= value;
        }

        public static event On.GeoRock.hook_UpdateHitsLeftFromFSM UpdateHitsLeftFromFSM
        {
            add => On.GeoRock.UpdateHitsLeftFromFSM += value;
            remove => On.GeoRock.UpdateHitsLeftFromFSM -= value;
        }
    }
}