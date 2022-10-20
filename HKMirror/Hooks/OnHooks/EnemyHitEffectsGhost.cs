namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EnemyHitEffectsGhost class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyHitEffectsGhost
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.EnemyHitEffectsGhost.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.EnemyHitEffectsGhost.orig_Awake orig, EnemyHitEffectsGhost self)
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

        internal static void HookRecieveHitEffect()
        {
            if (!HookedList.Contains("RecieveHitEffect"))
            {
                HookedList.Add("RecieveHitEffect");
                On.EnemyHitEffectsGhost.RecieveHitEffect += RecieveHitEffect;
            }
        }

        internal static event Delegates.RecieveHitEffect_BeforeArgs _beforeRecieveHitEffect;
        internal static event Delegates.RecieveHitEffect_NormalArgs _afterRecieveHitEffect;

        private static void RecieveHitEffect(On.EnemyHitEffectsGhost.orig_RecieveHitEffect orig,
            EnemyHitEffectsGhost self, float attackDirection)
        {
            Delegates.Params_RecieveHitEffect @params = new()
            {
                self = self, attackDirection = attackDirection
            };
            _beforeRecieveHitEffect?.Invoke(@params);
            self = @params.self;
            attackDirection = @params.attackDirection;
            orig(self, attackDirection);
            if (_afterRecieveHitEffect != null) _afterRecieveHitEffect.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.EnemyHitEffectsGhost.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.EnemyHitEffectsGhost.orig_Update orig, EnemyHitEffectsGhost self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void RecieveHitEffect_BeforeArgs(Params_RecieveHitEffect args);

        public delegate void RecieveHitEffect_NormalArgs(Params_RecieveHitEffect args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Awake
        {
            public EnemyHitEffectsGhost self;
        }

        public sealed class Params_RecieveHitEffect
        {
            public float attackDirection;
            public EnemyHitEffectsGhost self;
        }

        public sealed class Params_Update
        {
            public EnemyHitEffectsGhost self;
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

        public static event Delegates.RecieveHitEffect_BeforeArgs RecieveHitEffect
        {
            add
            {
                HookHandler._beforeRecieveHitEffect += value;
                HookHandler.HookRecieveHitEffect();
            }
            remove => HookHandler._beforeRecieveHitEffect -= value;
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
        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.RecieveHitEffect_NormalArgs RecieveHitEffect
        {
            add
            {
                HookHandler._afterRecieveHitEffect += value;
                HookHandler.HookRecieveHitEffect();
            }
            remove => HookHandler._afterRecieveHitEffect -= value;
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.EnemyHitEffectsGhost.hook_Awake Awake
        {
            add => On.EnemyHitEffectsGhost.Awake += value;
            remove => On.EnemyHitEffectsGhost.Awake -= value;
        }

        public static event On.EnemyHitEffectsGhost.hook_RecieveHitEffect RecieveHitEffect
        {
            add => On.EnemyHitEffectsGhost.RecieveHitEffect += value;
            remove => On.EnemyHitEffectsGhost.RecieveHitEffect -= value;
        }

        public static event On.EnemyHitEffectsGhost.hook_Update Update
        {
            add => On.EnemyHitEffectsGhost.Update += value;
            remove => On.EnemyHitEffectsGhost.Update -= value;
        }
    }
}