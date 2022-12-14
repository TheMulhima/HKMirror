namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Grass class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGrass
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookInit()
        {
            if (!HookedList.Contains("Init"))
            {
                HookedList.Add("Init");
                On.Grass.Init += Init;
            }
        }

        internal static event Delegates.Init_BeforeArgs _beforeInit;
        internal static event Delegates.Init_AfterArgs _afterInit;

        private static void Init(On.Grass.orig_Init orig)
        {
            if (_beforeInit != null)
                foreach (Delegates.Init_BeforeArgs toInvoke in _beforeInit.GetInvocationList())
                    try
                    {
                        _beforeInit?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            orig();
            if (_afterInit != null)
                foreach (Delegates.Init_AfterArgs toInvoke in _afterInit.GetInvocationList())
                    try
                    {
                        _afterInit.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.Grass.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.Grass.orig_Reset orig, Grass self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.Grass.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.Grass.orig_Awake orig, Grass self)
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

        internal static void HookOnDestroy()
        {
            if (!HookedList.Contains("OnDestroy"))
            {
                HookedList.Add("OnDestroy");
                On.Grass.OnDestroy += OnDestroy;
            }
        }

        internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
        internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;

        private static void OnDestroy(On.Grass.orig_OnDestroy orig, Grass self)
        {
            Delegates.Params_OnDestroy @params = new()
            {
                self = self
            };
            if (_beforeOnDestroy != null)
                foreach (Delegates.OnDestroy_BeforeArgs toInvoke in _beforeOnDestroy.GetInvocationList())
                    try
                    {
                        _beforeOnDestroy?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDestroy != null)
                foreach (Delegates.OnDestroy_AfterArgs toInvoke in _afterOnDestroy.GetInvocationList())
                    try
                    {
                        _afterOnDestroy.Invoke(@params);
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
                On.Grass.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.Grass.orig_Start orig, Grass self)
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

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.Grass.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.Grass.orig_OnTriggerEnter2D orig, Grass self,
            Collider2D other)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, other = other
            };
            if (_beforeOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            other = @params.other;
            orig(self, other);
            if (_afterOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookPush()
        {
            if (!HookedList.Contains("Push"))
            {
                HookedList.Add("Push");
                On.Grass.Push += Push;
            }
        }

        internal static event Delegates.Push_BeforeArgs _beforePush;
        internal static event Delegates.Push_AfterArgs _afterPush;

        private static void Push(On.Grass.orig_Push orig, Grass self, bool isAllGrass)
        {
            Delegates.Params_Push @params = new()
            {
                self = self, isAllGrass = isAllGrass
            };
            if (_beforePush != null)
                foreach (Delegates.Push_BeforeArgs toInvoke in _beforePush.GetInvocationList())
                    try
                    {
                        _beforePush?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            isAllGrass = @params.isAllGrass;
            orig(self, isAllGrass);
            if (_afterPush != null)
                foreach (Delegates.Push_AfterArgs toInvoke in _afterPush.GetInvocationList())
                    try
                    {
                        _afterPush.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookPushAll()
        {
            if (!HookedList.Contains("PushAll"))
            {
                HookedList.Add("PushAll");
                On.Grass.PushAll += PushAll;
            }
        }

        internal static event Delegates.PushAll_BeforeArgs _beforePushAll;
        internal static event Delegates.PushAll_AfterArgs _afterPushAll;

        private static void PushAll(On.Grass.orig_PushAll orig)
        {
            if (_beforePushAll != null)
                foreach (Delegates.PushAll_BeforeArgs toInvoke in _beforePushAll.GetInvocationList())
                    try
                    {
                        _beforePushAll?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            orig();
            if (_afterPushAll != null)
                foreach (Delegates.PushAll_AfterArgs toInvoke in _afterPushAll.GetInvocationList())
                    try
                    {
                        _afterPushAll.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookHit()
        {
            if (!HookedList.Contains("Hit"))
            {
                HookedList.Add("Hit");
                On.Grass.Hit += Hit;
            }
        }

        internal static event Delegates.Hit_BeforeArgs _beforeHit;
        internal static event Delegates.Hit_AfterArgs _afterHit;

        private static void Hit(On.Grass.orig_Hit orig, Grass self, HitInstance damageInstance)
        {
            Delegates.Params_Hit @params = new()
            {
                self = self, damageInstance = damageInstance
            };
            if (_beforeHit != null)
                foreach (Delegates.Hit_BeforeArgs toInvoke in _beforeHit.GetInvocationList())
                    try
                    {
                        _beforeHit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            damageInstance = @params.damageInstance;
            orig(self, damageInstance);
            if (_afterHit != null)
                foreach (Delegates.Hit_AfterArgs toInvoke in _afterHit.GetInvocationList())
                    try
                    {
                        _afterHit.Invoke(@params);
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
                On.Grass.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.Grass.orig_Update orig, Grass self)
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<Grass> orig, Grass self);

        public delegate void Hit_AfterArgs(Params_Hit args);

        public delegate void Hit_BeforeArgs(Params_Hit args);

        public delegate void Hit_WithArgs(Action<Grass, HitInstance> orig, Grass self, HitInstance damageInstance);

        public delegate void Init_AfterArgs();

        public delegate void Init_BeforeArgs();

        public delegate void Init_WithArgs(Action orig);

        public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);

        public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);

        public delegate void OnDestroy_WithArgs(Action<Grass> orig, Grass self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<Grass, Collider2D> orig, Grass self,
            Collider2D other);

        public delegate void Push_AfterArgs(Params_Push args);

        public delegate void Push_BeforeArgs(Params_Push args);

        public delegate void Push_WithArgs(Action<Grass, bool> orig, Grass self, bool isAllGrass);

        public delegate void PushAll_AfterArgs();

        public delegate void PushAll_BeforeArgs();

        public delegate void PushAll_WithArgs(Action orig);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<Grass> orig, Grass self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<Grass> orig, Grass self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<Grass> orig, Grass self);

        public sealed class Params_Reset
        {
            public Grass self;
        }

        public sealed class Params_Awake
        {
            public Grass self;
        }

        public sealed class Params_OnDestroy
        {
            public Grass self;
        }

        public sealed class Params_Start
        {
            public Grass self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D other;
            public Grass self;
        }

        public sealed class Params_Push
        {
            public bool isAllGrass;
            public Grass self;
        }

        public sealed class Params_Hit
        {
            public HitInstance damageInstance;
            public Grass self;
        }

        public sealed class Params_Update
        {
            public Grass self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Init_BeforeArgs Init
        {
            add
            {
                HookHandler._beforeInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._beforeInit -= value;
        }

        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.OnDestroy_BeforeArgs OnDestroy
        {
            add
            {
                HookHandler._beforeOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._beforeOnDestroy -= value;
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.Push_BeforeArgs Push
        {
            add
            {
                HookHandler._beforePush += value;
                HookHandler.HookPush();
            }
            remove => HookHandler._beforePush -= value;
        }

        public static event Delegates.PushAll_BeforeArgs PushAll
        {
            add
            {
                HookHandler._beforePushAll += value;
                HookHandler.HookPushAll();
            }
            remove => HookHandler._beforePushAll -= value;
        }

        public static event Delegates.Hit_BeforeArgs Hit
        {
            add
            {
                HookHandler._beforeHit += value;
                HookHandler.HookHit();
            }
            remove => HookHandler._beforeHit -= value;
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
        public static event Delegates.Init_AfterArgs Init
        {
            add
            {
                HookHandler._afterInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._afterInit -= value;
        }

        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnDestroy_AfterArgs OnDestroy
        {
            add
            {
                HookHandler._afterOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._afterOnDestroy -= value;
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

        public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.Push_AfterArgs Push
        {
            add
            {
                HookHandler._afterPush += value;
                HookHandler.HookPush();
            }
            remove => HookHandler._afterPush -= value;
        }

        public static event Delegates.PushAll_AfterArgs PushAll
        {
            add
            {
                HookHandler._afterPushAll += value;
                HookHandler.HookPushAll();
            }
            remove => HookHandler._afterPushAll -= value;
        }

        public static event Delegates.Hit_AfterArgs Hit
        {
            add
            {
                HookHandler._afterHit += value;
                HookHandler.HookHit();
            }
            remove => HookHandler._afterHit -= value;
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
        public static event On.Grass.hook_Init Init
        {
            add => On.Grass.Init += value;
            remove => On.Grass.Init -= value;
        }

        public static event On.Grass.hook_Reset Reset
        {
            add => On.Grass.Reset += value;
            remove => On.Grass.Reset -= value;
        }

        public static event On.Grass.hook_Awake Awake
        {
            add => On.Grass.Awake += value;
            remove => On.Grass.Awake -= value;
        }

        public static event On.Grass.hook_OnDestroy OnDestroy
        {
            add => On.Grass.OnDestroy += value;
            remove => On.Grass.OnDestroy -= value;
        }

        public static event On.Grass.hook_Start Start
        {
            add => On.Grass.Start += value;
            remove => On.Grass.Start -= value;
        }

        public static event On.Grass.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.Grass.OnTriggerEnter2D += value;
            remove => On.Grass.OnTriggerEnter2D -= value;
        }

        public static event On.Grass.hook_Push Push
        {
            add => On.Grass.Push += value;
            remove => On.Grass.Push -= value;
        }

        public static event On.Grass.hook_PushAll PushAll
        {
            add => On.Grass.PushAll += value;
            remove => On.Grass.PushAll -= value;
        }

        public static event On.Grass.hook_Hit Hit
        {
            add => On.Grass.Hit += value;
            remove => On.Grass.Hit -= value;
        }

        public static event On.Grass.hook_Update Update
        {
            add => On.Grass.Update += value;
            remove => On.Grass.Update -= value;
        }
    }
}