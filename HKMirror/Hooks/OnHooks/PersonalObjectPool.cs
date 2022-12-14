namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PersonalObjectPool class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPersonalObjectPool
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.PersonalObjectPool.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.PersonalObjectPool.orig_Start orig, PersonalObjectPool self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.PersonalObjectPool.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.PersonalObjectPool.orig_OnEnable orig, PersonalObjectPool self)
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

        internal static void HookCreateStartupPools()
        {
            if (!HookedList.Contains("CreateStartupPools"))
            {
                HookedList.Add("CreateStartupPools");
                On.PersonalObjectPool.CreateStartupPools += CreateStartupPools;
            }
        }

        internal static event Delegates.CreateStartupPools_BeforeArgs _beforeCreateStartupPools;
        internal static event Delegates.CreateStartupPools_AfterArgs _afterCreateStartupPools;

        private static void CreateStartupPools(On.PersonalObjectPool.orig_CreateStartupPools orig,
            PersonalObjectPool self)
        {
            Delegates.Params_CreateStartupPools @params = new()
            {
                self = self
            };
            if (_beforeCreateStartupPools != null)
                foreach (Delegates.CreateStartupPools_BeforeArgs toInvoke in
                         _beforeCreateStartupPools.GetInvocationList())
                    try
                    {
                        _beforeCreateStartupPools?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterCreateStartupPools != null)
                foreach (Delegates.CreateStartupPools_AfterArgs toInvoke in
                         _afterCreateStartupPools.GetInvocationList())
                    try
                    {
                        _afterCreateStartupPools.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCreatePool()
        {
            if (!HookedList.Contains("CreatePool"))
            {
                HookedList.Add("CreatePool");
                On.PersonalObjectPool.CreatePool += CreatePool;
            }
        }

        internal static event Delegates.CreatePool_BeforeArgs _beforeCreatePool;
        internal static event Delegates.CreatePool_AfterArgs _afterCreatePool;

        private static void CreatePool(On.PersonalObjectPool.orig_CreatePool orig, PersonalObjectPool self,
            GameObject prefab, int initialPoolSize)
        {
            Delegates.Params_CreatePool @params = new()
            {
                self = self, prefab = prefab, initialPoolSize = initialPoolSize
            };
            if (_beforeCreatePool != null)
                foreach (Delegates.CreatePool_BeforeArgs toInvoke in _beforeCreatePool.GetInvocationList())
                    try
                    {
                        _beforeCreatePool?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            prefab = @params.prefab;
            initialPoolSize = @params.initialPoolSize;
            orig(self, prefab, initialPoolSize);
            if (_afterCreatePool != null)
                foreach (Delegates.CreatePool_AfterArgs toInvoke in _afterCreatePool.GetInvocationList())
                    try
                    {
                        _afterCreatePool.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDestroyMyPooledObjects()
        {
            if (!HookedList.Contains("DestroyMyPooledObjects"))
            {
                HookedList.Add("DestroyMyPooledObjects");
                On.PersonalObjectPool.DestroyMyPooledObjects += DestroyMyPooledObjects;
            }
        }

        internal static event Delegates.DestroyMyPooledObjects_BeforeArgs _beforeDestroyMyPooledObjects;
        internal static event Delegates.DestroyMyPooledObjects_AfterArgs _afterDestroyMyPooledObjects;

        private static void DestroyMyPooledObjects(On.PersonalObjectPool.orig_DestroyMyPooledObjects orig,
            PersonalObjectPool self)
        {
            Delegates.Params_DestroyMyPooledObjects @params = new()
            {
                self = self
            };
            if (_beforeDestroyMyPooledObjects != null)
                foreach (Delegates.DestroyMyPooledObjects_BeforeArgs toInvoke in _beforeDestroyMyPooledObjects
                             .GetInvocationList())
                    try
                    {
                        _beforeDestroyMyPooledObjects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDestroyMyPooledObjects != null)
                foreach (Delegates.DestroyMyPooledObjects_AfterArgs toInvoke in _afterDestroyMyPooledObjects
                             .GetInvocationList())
                    try
                    {
                        _afterDestroyMyPooledObjects.Invoke(@params);
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
        public delegate void CreatePool_AfterArgs(Params_CreatePool args);

        public delegate void CreatePool_BeforeArgs(Params_CreatePool args);

        public delegate void CreatePool_WithArgs(Action<PersonalObjectPool, GameObject, int> orig,
            PersonalObjectPool self, GameObject prefab, int initialPoolSize);

        public delegate void CreateStartupPools_AfterArgs(Params_CreateStartupPools args);

        public delegate void CreateStartupPools_BeforeArgs(Params_CreateStartupPools args);

        public delegate void CreateStartupPools_WithArgs(Action<PersonalObjectPool> orig, PersonalObjectPool self);

        public delegate void DestroyMyPooledObjects_AfterArgs(Params_DestroyMyPooledObjects args);

        public delegate void DestroyMyPooledObjects_BeforeArgs(Params_DestroyMyPooledObjects args);

        public delegate void DestroyMyPooledObjects_WithArgs(Action<PersonalObjectPool> orig, PersonalObjectPool self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<PersonalObjectPool> orig, PersonalObjectPool self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<PersonalObjectPool> orig, PersonalObjectPool self);

        public sealed class Params_Start
        {
            public PersonalObjectPool self;
        }

        public sealed class Params_OnEnable
        {
            public PersonalObjectPool self;
        }

        public sealed class Params_CreateStartupPools
        {
            public PersonalObjectPool self;
        }

        public sealed class Params_CreatePool
        {
            public int initialPoolSize;
            public GameObject prefab;
            public PersonalObjectPool self;
        }

        public sealed class Params_DestroyMyPooledObjects
        {
            public PersonalObjectPool self;
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

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.CreateStartupPools_BeforeArgs CreateStartupPools
        {
            add
            {
                HookHandler._beforeCreateStartupPools += value;
                HookHandler.HookCreateStartupPools();
            }
            remove => HookHandler._beforeCreateStartupPools -= value;
        }

        public static event Delegates.CreatePool_BeforeArgs CreatePool
        {
            add
            {
                HookHandler._beforeCreatePool += value;
                HookHandler.HookCreatePool();
            }
            remove => HookHandler._beforeCreatePool -= value;
        }

        public static event Delegates.DestroyMyPooledObjects_BeforeArgs DestroyMyPooledObjects
        {
            add
            {
                HookHandler._beforeDestroyMyPooledObjects += value;
                HookHandler.HookDestroyMyPooledObjects();
            }
            remove => HookHandler._beforeDestroyMyPooledObjects -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.CreateStartupPools_AfterArgs CreateStartupPools
        {
            add
            {
                HookHandler._afterCreateStartupPools += value;
                HookHandler.HookCreateStartupPools();
            }
            remove => HookHandler._afterCreateStartupPools -= value;
        }

        public static event Delegates.CreatePool_AfterArgs CreatePool
        {
            add
            {
                HookHandler._afterCreatePool += value;
                HookHandler.HookCreatePool();
            }
            remove => HookHandler._afterCreatePool -= value;
        }

        public static event Delegates.DestroyMyPooledObjects_AfterArgs DestroyMyPooledObjects
        {
            add
            {
                HookHandler._afterDestroyMyPooledObjects += value;
                HookHandler.HookDestroyMyPooledObjects();
            }
            remove => HookHandler._afterDestroyMyPooledObjects -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PersonalObjectPool.hook_Start Start
        {
            add => On.PersonalObjectPool.Start += value;
            remove => On.PersonalObjectPool.Start -= value;
        }

        public static event On.PersonalObjectPool.hook_OnEnable OnEnable
        {
            add => On.PersonalObjectPool.OnEnable += value;
            remove => On.PersonalObjectPool.OnEnable -= value;
        }

        public static event On.PersonalObjectPool.hook_CreateStartupPools CreateStartupPools
        {
            add => On.PersonalObjectPool.CreateStartupPools += value;
            remove => On.PersonalObjectPool.CreateStartupPools -= value;
        }

        public static event On.PersonalObjectPool.hook_CreatePool CreatePool
        {
            add => On.PersonalObjectPool.CreatePool += value;
            remove => On.PersonalObjectPool.CreatePool -= value;
        }

        public static event On.PersonalObjectPool.hook_DestroyMyPooledObjects DestroyMyPooledObjects
        {
            add => On.PersonalObjectPool.DestroyMyPooledObjects += value;
            remove => On.PersonalObjectPool.DestroyMyPooledObjects -= value;
        }
    }
}