namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EnemyHitEffectsUninfected class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyHitEffectsUninfected
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.EnemyHitEffectsUninfected.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.EnemyHitEffectsUninfected.orig_Awake orig, EnemyHitEffectsUninfected self)
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

        internal static void HookRecieveHitEffect()
        {
            if (!HookedList.Contains("RecieveHitEffect"))
            {
                HookedList.Add("RecieveHitEffect");
                On.EnemyHitEffectsUninfected.RecieveHitEffect += RecieveHitEffect;
            }
        }

        internal static event Delegates.RecieveHitEffect_BeforeArgs _beforeRecieveHitEffect;
        internal static event Delegates.RecieveHitEffect_AfterArgs _afterRecieveHitEffect;

        private static void RecieveHitEffect(On.EnemyHitEffectsUninfected.orig_RecieveHitEffect orig,
            EnemyHitEffectsUninfected self, float attackDirection)
        {
            Delegates.Params_RecieveHitEffect @params = new()
            {
                self = self, attackDirection = attackDirection
            };
            if (_beforeRecieveHitEffect != null)
                foreach (Delegates.RecieveHitEffect_BeforeArgs toInvoke in _beforeRecieveHitEffect.GetInvocationList())
                    try
                    {
                        _beforeRecieveHitEffect?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            attackDirection = @params.attackDirection;
            orig(self, attackDirection);
            if (_afterRecieveHitEffect != null)
                foreach (Delegates.RecieveHitEffect_AfterArgs toInvoke in _afterRecieveHitEffect.GetInvocationList())
                    try
                    {
                        _afterRecieveHitEffect.Invoke(@params);
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
                On.EnemyHitEffectsUninfected.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.EnemyHitEffectsUninfected.orig_Update orig, EnemyHitEffectsUninfected self)
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

        public delegate void Awake_WithArgs(Action<EnemyHitEffectsUninfected> orig, EnemyHitEffectsUninfected self);

        public delegate void RecieveHitEffect_AfterArgs(Params_RecieveHitEffect args);

        public delegate void RecieveHitEffect_BeforeArgs(Params_RecieveHitEffect args);

        public delegate void RecieveHitEffect_WithArgs(Action<EnemyHitEffectsUninfected, float> orig,
            EnemyHitEffectsUninfected self, float attackDirection);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<EnemyHitEffectsUninfected> orig, EnemyHitEffectsUninfected self);

        public sealed class Params_Awake
        {
            public EnemyHitEffectsUninfected self;
        }

        public sealed class Params_RecieveHitEffect
        {
            public float attackDirection;
            public EnemyHitEffectsUninfected self;
        }

        public sealed class Params_Update
        {
            public EnemyHitEffectsUninfected self;
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
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.RecieveHitEffect_AfterArgs RecieveHitEffect
        {
            add
            {
                HookHandler._afterRecieveHitEffect += value;
                HookHandler.HookRecieveHitEffect();
            }
            remove => HookHandler._afterRecieveHitEffect -= value;
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
        public static event On.EnemyHitEffectsUninfected.hook_Awake Awake
        {
            add => On.EnemyHitEffectsUninfected.Awake += value;
            remove => On.EnemyHitEffectsUninfected.Awake -= value;
        }

        public static event On.EnemyHitEffectsUninfected.hook_RecieveHitEffect RecieveHitEffect
        {
            add => On.EnemyHitEffectsUninfected.RecieveHitEffect += value;
            remove => On.EnemyHitEffectsUninfected.RecieveHitEffect -= value;
        }

        public static event On.EnemyHitEffectsUninfected.hook_Update Update
        {
            add => On.EnemyHitEffectsUninfected.Update += value;
            remove => On.EnemyHitEffectsUninfected.Update -= value;
        }
    }
}