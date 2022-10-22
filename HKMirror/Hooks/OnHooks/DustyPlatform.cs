namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DustyPlatform class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDustyPlatform
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.DustyPlatform.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.DustyPlatform.orig_Reset orig, DustyPlatform self)
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
                On.DustyPlatform.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.DustyPlatform.orig_Awake orig, DustyPlatform self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.DustyPlatform.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.DustyPlatform.orig_Update orig, DustyPlatform self)
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

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.DustyPlatform.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_AfterArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.DustyPlatform.orig_OnCollisionEnter2D orig, DustyPlatform self,
            Collision2D collision)
        {
            Delegates.Params_OnCollisionEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnCollisionEnter2D != null)
                foreach (Delegates.OnCollisionEnter2D_BeforeArgs toInvoke in
                         _beforeOnCollisionEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnCollisionEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnCollisionEnter2D != null)
                foreach (Delegates.OnCollisionEnter2D_AfterArgs toInvoke in
                         _afterOnCollisionEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnCollisionEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSpawnRocks()
        {
            if (!HookedList.Contains("SpawnRocks"))
            {
                HookedList.Add("SpawnRocks");
                On.DustyPlatform.SpawnRocks += SpawnRocks;
            }
        }

        internal static event Delegates.SpawnRocks_BeforeArgs _beforeSpawnRocks;
        internal static event Delegates.SpawnRocks_AfterArgs _afterSpawnRocks;

        private static void SpawnRocks(On.DustyPlatform.orig_SpawnRocks orig, DustyPlatform self)
        {
            Delegates.Params_SpawnRocks @params = new()
            {
                self = self
            };
            if (_beforeSpawnRocks != null)
                foreach (Delegates.SpawnRocks_BeforeArgs toInvoke in _beforeSpawnRocks.GetInvocationList())
                    try
                    {
                        _beforeSpawnRocks?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSpawnRocks != null)
                foreach (Delegates.SpawnRocks_AfterArgs toInvoke in _afterSpawnRocks.GetInvocationList())
                    try
                    {
                        _afterSpawnRocks.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetRateOverTime()
        {
            if (!HookedList.Contains("SetRateOverTime"))
            {
                HookedList.Add("SetRateOverTime");
                On.DustyPlatform.SetRateOverTime += SetRateOverTime;
            }
        }

        internal static event Delegates.SetRateOverTime_BeforeArgs _beforeSetRateOverTime;
        internal static event Delegates.SetRateOverTime_AfterArgs _afterSetRateOverTime;

        private static void SetRateOverTime(On.DustyPlatform.orig_SetRateOverTime orig, DustyPlatform self,
            ParticleSystem ps, float rateOverTime)
        {
            Delegates.Params_SetRateOverTime @params = new()
            {
                self = self, ps = ps, rateOverTime = rateOverTime
            };
            if (_beforeSetRateOverTime != null)
                foreach (Delegates.SetRateOverTime_BeforeArgs toInvoke in _beforeSetRateOverTime.GetInvocationList())
                    try
                    {
                        _beforeSetRateOverTime?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            ps = @params.ps;
            rateOverTime = @params.rateOverTime;
            orig(self, ps, rateOverTime);
            if (_afterSetRateOverTime != null)
                foreach (Delegates.SetRateOverTime_AfterArgs toInvoke in _afterSetRateOverTime.GetInvocationList())
                    try
                    {
                        _afterSetRateOverTime.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<DustyPlatform> orig, DustyPlatform self);

        public delegate void OnCollisionEnter2D_AfterArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_WithArgs(Action<DustyPlatform, Collision2D> orig, DustyPlatform self,
            Collision2D collision);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<DustyPlatform> orig, DustyPlatform self);

        public delegate void SetRateOverTime_AfterArgs(Params_SetRateOverTime args);

        public delegate void SetRateOverTime_BeforeArgs(Params_SetRateOverTime args);

        public delegate void SetRateOverTime_WithArgs(Action<DustyPlatform, ParticleSystem, float> orig,
            DustyPlatform self, ParticleSystem ps, float rateOverTime);

        public delegate void SpawnRocks_AfterArgs(Params_SpawnRocks args);

        public delegate void SpawnRocks_BeforeArgs(Params_SpawnRocks args);

        public delegate void SpawnRocks_WithArgs(Action<DustyPlatform> orig, DustyPlatform self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<DustyPlatform> orig, DustyPlatform self);

        public sealed class Params_Reset
        {
            public DustyPlatform self;
        }

        public sealed class Params_Awake
        {
            public DustyPlatform self;
        }

        public sealed class Params_Update
        {
            public DustyPlatform self;
        }

        public sealed class Params_OnCollisionEnter2D
        {
            public Collision2D collision;
            public DustyPlatform self;
        }

        public sealed class Params_SpawnRocks
        {
            public DustyPlatform self;
        }

        public sealed class Params_SetRateOverTime
        {
            public ParticleSystem ps;
            public float rateOverTime;
            public DustyPlatform self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.OnCollisionEnter2D_BeforeArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._beforeOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._beforeOnCollisionEnter2D -= value;
        }

        public static event Delegates.SpawnRocks_BeforeArgs SpawnRocks
        {
            add
            {
                HookHandler._beforeSpawnRocks += value;
                HookHandler.HookSpawnRocks();
            }
            remove => HookHandler._beforeSpawnRocks -= value;
        }

        public static event Delegates.SetRateOverTime_BeforeArgs SetRateOverTime
        {
            add
            {
                HookHandler._beforeSetRateOverTime += value;
                HookHandler.HookSetRateOverTime();
            }
            remove => HookHandler._beforeSetRateOverTime -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.OnCollisionEnter2D_AfterArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._afterOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._afterOnCollisionEnter2D -= value;
        }

        public static event Delegates.SpawnRocks_AfterArgs SpawnRocks
        {
            add
            {
                HookHandler._afterSpawnRocks += value;
                HookHandler.HookSpawnRocks();
            }
            remove => HookHandler._afterSpawnRocks -= value;
        }

        public static event Delegates.SetRateOverTime_AfterArgs SetRateOverTime
        {
            add
            {
                HookHandler._afterSetRateOverTime += value;
                HookHandler.HookSetRateOverTime();
            }
            remove => HookHandler._afterSetRateOverTime -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.DustyPlatform.hook_Reset Reset
        {
            add => On.DustyPlatform.Reset += value;
            remove => On.DustyPlatform.Reset -= value;
        }

        public static event On.DustyPlatform.hook_Awake Awake
        {
            add => On.DustyPlatform.Awake += value;
            remove => On.DustyPlatform.Awake -= value;
        }

        public static event On.DustyPlatform.hook_Update Update
        {
            add => On.DustyPlatform.Update += value;
            remove => On.DustyPlatform.Update -= value;
        }

        public static event On.DustyPlatform.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.DustyPlatform.OnCollisionEnter2D += value;
            remove => On.DustyPlatform.OnCollisionEnter2D -= value;
        }

        public static event On.DustyPlatform.hook_SpawnRocks SpawnRocks
        {
            add => On.DustyPlatform.SpawnRocks += value;
            remove => On.DustyPlatform.SpawnRocks -= value;
        }

        public static event On.DustyPlatform.hook_SetRateOverTime SetRateOverTime
        {
            add => On.DustyPlatform.SetRateOverTime += value;
            remove => On.DustyPlatform.SetRateOverTime -= value;
        }
    }
}