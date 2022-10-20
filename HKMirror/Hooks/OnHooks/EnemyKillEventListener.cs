namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EnemyKillEventListener class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyKillEventListener
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.EnemyKillEventListener.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.EnemyKillEventListener.orig_Awake orig, EnemyKillEventListener self)
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
                On.EnemyKillEventListener.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.EnemyKillEventListener.orig_OnEnable orig, EnemyKillEventListener self)
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
                On.EnemyKillEventListener.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.EnemyKillEventListener.orig_OnDisable orig, EnemyKillEventListener self)
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

        internal static void HookDie()
        {
            if (!HookedList.Contains("Die"))
            {
                HookedList.Add("Die");
                On.EnemyKillEventListener.Die += Die;
            }
        }

        internal static event Delegates.Die_BeforeArgs _beforeDie;
        internal static event Delegates.Die_NormalArgs _afterDie;

        private static void Die(On.EnemyKillEventListener.orig_Die orig, EnemyKillEventListener self)
        {
            Delegates.Params_Die @params = new()
            {
                self = self
            };
            _beforeDie?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDie != null) _afterDie.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void Die_BeforeArgs(Params_Die args);

        public delegate void Die_NormalArgs(Params_Die args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public sealed class Params_Awake
        {
            public EnemyKillEventListener self;
        }

        public sealed class Params_OnEnable
        {
            public EnemyKillEventListener self;
        }

        public sealed class Params_OnDisable
        {
            public EnemyKillEventListener self;
        }

        public sealed class Params_Die
        {
            public EnemyKillEventListener self;
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

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.Die_BeforeArgs Die
        {
            add
            {
                HookHandler._beforeDie += value;
                HookHandler.HookDie();
            }
            remove => HookHandler._beforeDie -= value;
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

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.Die_NormalArgs Die
        {
            add
            {
                HookHandler._afterDie += value;
                HookHandler.HookDie();
            }
            remove => HookHandler._afterDie -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.EnemyKillEventListener.hook_Awake Awake
        {
            add => On.EnemyKillEventListener.Awake += value;
            remove => On.EnemyKillEventListener.Awake -= value;
        }

        public static event On.EnemyKillEventListener.hook_OnEnable OnEnable
        {
            add => On.EnemyKillEventListener.OnEnable += value;
            remove => On.EnemyKillEventListener.OnEnable -= value;
        }

        public static event On.EnemyKillEventListener.hook_OnDisable OnDisable
        {
            add => On.EnemyKillEventListener.OnDisable += value;
            remove => On.EnemyKillEventListener.OnDisable -= value;
        }

        public static event On.EnemyKillEventListener.hook_Die Die
        {
            add => On.EnemyKillEventListener.Die += value;
            remove => On.EnemyKillEventListener.Die -= value;
        }
    }
}