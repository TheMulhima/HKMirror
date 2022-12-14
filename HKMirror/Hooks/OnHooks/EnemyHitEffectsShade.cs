namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EnemyHitEffectsShade class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyHitEffectsShade
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.EnemyHitEffectsShade.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.EnemyHitEffectsShade.orig_Awake orig, EnemyHitEffectsShade self)
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
                On.EnemyHitEffectsShade.RecieveHitEffect += RecieveHitEffect;
            }
        }

        internal static event Delegates.RecieveHitEffect_BeforeArgs _beforeRecieveHitEffect;
        internal static event Delegates.RecieveHitEffect_AfterArgs _afterRecieveHitEffect;

        private static void RecieveHitEffect(On.EnemyHitEffectsShade.orig_RecieveHitEffect orig,
            EnemyHitEffectsShade self, float attackDirection)
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
                On.EnemyHitEffectsShade.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.EnemyHitEffectsShade.orig_Update orig, EnemyHitEffectsShade self)
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

        public delegate void Awake_WithArgs(Action<EnemyHitEffectsShade> orig, EnemyHitEffectsShade self);

        public delegate void RecieveHitEffect_AfterArgs(Params_RecieveHitEffect args);

        public delegate void RecieveHitEffect_BeforeArgs(Params_RecieveHitEffect args);

        public delegate void RecieveHitEffect_WithArgs(Action<EnemyHitEffectsShade, float> orig,
            EnemyHitEffectsShade self, float attackDirection);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<EnemyHitEffectsShade> orig, EnemyHitEffectsShade self);

        public sealed class Params_Awake
        {
            public EnemyHitEffectsShade self;
        }

        public sealed class Params_RecieveHitEffect
        {
            public float attackDirection;
            public EnemyHitEffectsShade self;
        }

        public sealed class Params_Update
        {
            public EnemyHitEffectsShade self;
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
        public static event On.EnemyHitEffectsShade.hook_Awake Awake
        {
            add => On.EnemyHitEffectsShade.Awake += value;
            remove => On.EnemyHitEffectsShade.Awake -= value;
        }

        public static event On.EnemyHitEffectsShade.hook_RecieveHitEffect RecieveHitEffect
        {
            add => On.EnemyHitEffectsShade.RecieveHitEffect += value;
            remove => On.EnemyHitEffectsShade.RecieveHitEffect -= value;
        }

        public static event On.EnemyHitEffectsShade.hook_Update Update
        {
            add => On.EnemyHitEffectsShade.Update += value;
            remove => On.EnemyHitEffectsShade.Update -= value;
        }
    }
}