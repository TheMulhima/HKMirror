namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GeoCounter class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGeoCounter
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.GeoCounter.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.GeoCounter.orig_Awake orig, GeoCounter self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
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
                On.GeoCounter.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.GeoCounter.orig_Start orig, GeoCounter self)
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

        internal static void HookUpdateGeo()
        {
            if (!HookedList.Contains("UpdateGeo"))
            {
                HookedList.Add("UpdateGeo");
                On.GeoCounter.UpdateGeo += UpdateGeo;
            }
        }

        internal static event Delegates.UpdateGeo_BeforeArgs _beforeUpdateGeo;
        internal static event Delegates.UpdateGeo_AfterArgs _afterUpdateGeo;

        private static void UpdateGeo(On.GeoCounter.orig_UpdateGeo orig, GeoCounter self)
        {
            Delegates.Params_UpdateGeo @params = new()
            {
                self = self
            };
            if (_beforeUpdateGeo != null)
                foreach (Delegates.UpdateGeo_BeforeArgs toInvoke in _beforeUpdateGeo.GetInvocationList())
                    try
                    {
                        _beforeUpdateGeo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateGeo != null)
                foreach (Delegates.UpdateGeo_AfterArgs toInvoke in _afterUpdateGeo.GetInvocationList())
                    try
                    {
                        _afterUpdateGeo.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookNewSceneRefresh()
        {
            if (!HookedList.Contains("NewSceneRefresh"))
            {
                HookedList.Add("NewSceneRefresh");
                On.GeoCounter.NewSceneRefresh += NewSceneRefresh;
            }
        }

        internal static event Delegates.NewSceneRefresh_BeforeArgs _beforeNewSceneRefresh;
        internal static event Delegates.NewSceneRefresh_AfterArgs _afterNewSceneRefresh;

        private static void NewSceneRefresh(On.GeoCounter.orig_NewSceneRefresh orig, GeoCounter self)
        {
            Delegates.Params_NewSceneRefresh @params = new()
            {
                self = self
            };
            if (_beforeNewSceneRefresh != null)
                foreach (Delegates.NewSceneRefresh_BeforeArgs toInvoke in _beforeNewSceneRefresh.GetInvocationList())
                    try
                    {
                        _beforeNewSceneRefresh?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterNewSceneRefresh != null)
                foreach (Delegates.NewSceneRefresh_AfterArgs toInvoke in _afterNewSceneRefresh.GetInvocationList())
                    try
                    {
                        _afterNewSceneRefresh.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookAddGeo()
        {
            if (!HookedList.Contains("AddGeo"))
            {
                HookedList.Add("AddGeo");
                On.GeoCounter.AddGeo += AddGeo;
            }
        }

        internal static event Delegates.AddGeo_BeforeArgs _beforeAddGeo;
        internal static event Delegates.AddGeo_AfterArgs _afterAddGeo;

        private static void AddGeo(On.GeoCounter.orig_AddGeo orig, GeoCounter self, int geo)
        {
            Delegates.Params_AddGeo @params = new()
            {
                self = self, geo = geo
            };
            if (_beforeAddGeo != null)
                foreach (Delegates.AddGeo_BeforeArgs toInvoke in _beforeAddGeo.GetInvocationList())
                    try
                    {
                        _beforeAddGeo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            geo = @params.geo;
            orig(self, geo);
            if (_afterAddGeo != null)
                foreach (Delegates.AddGeo_AfterArgs toInvoke in _afterAddGeo.GetInvocationList())
                    try
                    {
                        _afterAddGeo.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookTakeGeo()
        {
            if (!HookedList.Contains("TakeGeo"))
            {
                HookedList.Add("TakeGeo");
                On.GeoCounter.TakeGeo += TakeGeo;
            }
        }

        internal static event Delegates.TakeGeo_BeforeArgs _beforeTakeGeo;
        internal static event Delegates.TakeGeo_AfterArgs _afterTakeGeo;

        private static void TakeGeo(On.GeoCounter.orig_TakeGeo orig, GeoCounter self, int geo)
        {
            Delegates.Params_TakeGeo @params = new()
            {
                self = self, geo = geo
            };
            if (_beforeTakeGeo != null)
                foreach (Delegates.TakeGeo_BeforeArgs toInvoke in _beforeTakeGeo.GetInvocationList())
                    try
                    {
                        _beforeTakeGeo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            geo = @params.geo;
            orig(self, geo);
            if (_afterTakeGeo != null)
                foreach (Delegates.TakeGeo_AfterArgs toInvoke in _afterTakeGeo.GetInvocationList())
                    try
                    {
                        _afterTakeGeo.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookToZero()
        {
            if (!HookedList.Contains("ToZero"))
            {
                HookedList.Add("ToZero");
                On.GeoCounter.ToZero += ToZero;
            }
        }

        internal static event Delegates.ToZero_BeforeArgs _beforeToZero;
        internal static event Delegates.ToZero_AfterArgs _afterToZero;

        private static void ToZero(On.GeoCounter.orig_ToZero orig, GeoCounter self)
        {
            Delegates.Params_ToZero @params = new()
            {
                self = self
            };
            if (_beforeToZero != null)
                foreach (Delegates.ToZero_BeforeArgs toInvoke in _beforeToZero.GetInvocationList())
                    try
                    {
                        _beforeToZero?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterToZero != null)
                foreach (Delegates.ToZero_AfterArgs toInvoke in _afterToZero.GetInvocationList())
                    try
                    {
                        _afterToZero.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.GeoCounter.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.GeoCounter.orig_Update orig, GeoCounter self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
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
        public delegate void AddGeo_AfterArgs(Params_AddGeo args);

        public delegate void AddGeo_BeforeArgs(Params_AddGeo args);

        public delegate void AddGeo_WithArgs(Action<GeoCounter, int> orig, GeoCounter self, int geo);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<GeoCounter> orig, GeoCounter self);

        public delegate void NewSceneRefresh_AfterArgs(Params_NewSceneRefresh args);

        public delegate void NewSceneRefresh_BeforeArgs(Params_NewSceneRefresh args);

        public delegate void NewSceneRefresh_WithArgs(Action<GeoCounter> orig, GeoCounter self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<GeoCounter> orig, GeoCounter self);

        public delegate void TakeGeo_AfterArgs(Params_TakeGeo args);

        public delegate void TakeGeo_BeforeArgs(Params_TakeGeo args);

        public delegate void TakeGeo_WithArgs(Action<GeoCounter, int> orig, GeoCounter self, int geo);

        public delegate void ToZero_AfterArgs(Params_ToZero args);

        public delegate void ToZero_BeforeArgs(Params_ToZero args);

        public delegate void ToZero_WithArgs(Action<GeoCounter> orig, GeoCounter self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<GeoCounter> orig, GeoCounter self);

        public delegate void UpdateGeo_AfterArgs(Params_UpdateGeo args);

        public delegate void UpdateGeo_BeforeArgs(Params_UpdateGeo args);

        public delegate void UpdateGeo_WithArgs(Action<GeoCounter> orig, GeoCounter self);

        public sealed class Params_Awake
        {
            public GeoCounter self;
        }

        public sealed class Params_Start
        {
            public GeoCounter self;
        }

        public sealed class Params_UpdateGeo
        {
            public GeoCounter self;
        }

        public sealed class Params_NewSceneRefresh
        {
            public GeoCounter self;
        }

        public sealed class Params_AddGeo
        {
            public int geo;
            public GeoCounter self;
        }

        public sealed class Params_TakeGeo
        {
            public int geo;
            public GeoCounter self;
        }

        public sealed class Params_ToZero
        {
            public GeoCounter self;
        }

        public sealed class Params_Update
        {
            public GeoCounter self;
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

        public static event Delegates.UpdateGeo_BeforeArgs UpdateGeo
        {
            add
            {
                HookHandler._beforeUpdateGeo += value;
                HookHandler.HookUpdateGeo();
            }
            remove => HookHandler._beforeUpdateGeo -= value;
        }

        public static event Delegates.NewSceneRefresh_BeforeArgs NewSceneRefresh
        {
            add
            {
                HookHandler._beforeNewSceneRefresh += value;
                HookHandler.HookNewSceneRefresh();
            }
            remove => HookHandler._beforeNewSceneRefresh -= value;
        }

        public static event Delegates.AddGeo_BeforeArgs AddGeo
        {
            add
            {
                HookHandler._beforeAddGeo += value;
                HookHandler.HookAddGeo();
            }
            remove => HookHandler._beforeAddGeo -= value;
        }

        public static event Delegates.TakeGeo_BeforeArgs TakeGeo
        {
            add
            {
                HookHandler._beforeTakeGeo += value;
                HookHandler.HookTakeGeo();
            }
            remove => HookHandler._beforeTakeGeo -= value;
        }

        public static event Delegates.ToZero_BeforeArgs ToZero
        {
            add
            {
                HookHandler._beforeToZero += value;
                HookHandler.HookToZero();
            }
            remove => HookHandler._beforeToZero -= value;
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
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
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

        public static event Delegates.UpdateGeo_AfterArgs UpdateGeo
        {
            add
            {
                HookHandler._afterUpdateGeo += value;
                HookHandler.HookUpdateGeo();
            }
            remove => HookHandler._afterUpdateGeo -= value;
        }

        public static event Delegates.NewSceneRefresh_AfterArgs NewSceneRefresh
        {
            add
            {
                HookHandler._afterNewSceneRefresh += value;
                HookHandler.HookNewSceneRefresh();
            }
            remove => HookHandler._afterNewSceneRefresh -= value;
        }

        public static event Delegates.AddGeo_AfterArgs AddGeo
        {
            add
            {
                HookHandler._afterAddGeo += value;
                HookHandler.HookAddGeo();
            }
            remove => HookHandler._afterAddGeo -= value;
        }

        public static event Delegates.TakeGeo_AfterArgs TakeGeo
        {
            add
            {
                HookHandler._afterTakeGeo += value;
                HookHandler.HookTakeGeo();
            }
            remove => HookHandler._afterTakeGeo -= value;
        }

        public static event Delegates.ToZero_AfterArgs ToZero
        {
            add
            {
                HookHandler._afterToZero += value;
                HookHandler.HookToZero();
            }
            remove => HookHandler._afterToZero -= value;
        }

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GeoCounter.hook_Awake Awake
        {
            add => On.GeoCounter.Awake += value;
            remove => On.GeoCounter.Awake -= value;
        }

        public static event On.GeoCounter.hook_Start Start
        {
            add => On.GeoCounter.Start += value;
            remove => On.GeoCounter.Start -= value;
        }

        public static event On.GeoCounter.hook_UpdateGeo UpdateGeo
        {
            add => On.GeoCounter.UpdateGeo += value;
            remove => On.GeoCounter.UpdateGeo -= value;
        }

        public static event On.GeoCounter.hook_NewSceneRefresh NewSceneRefresh
        {
            add => On.GeoCounter.NewSceneRefresh += value;
            remove => On.GeoCounter.NewSceneRefresh -= value;
        }

        public static event On.GeoCounter.hook_AddGeo AddGeo
        {
            add => On.GeoCounter.AddGeo += value;
            remove => On.GeoCounter.AddGeo -= value;
        }

        public static event On.GeoCounter.hook_TakeGeo TakeGeo
        {
            add => On.GeoCounter.TakeGeo += value;
            remove => On.GeoCounter.TakeGeo -= value;
        }

        public static event On.GeoCounter.hook_ToZero ToZero
        {
            add => On.GeoCounter.ToZero += value;
            remove => On.GeoCounter.ToZero -= value;
        }

        public static event On.GeoCounter.hook_Update Update
        {
            add => On.GeoCounter.Update += value;
            remove => On.GeoCounter.Update -= value;
        }
    }
}