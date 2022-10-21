using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for EnemyDeathEffectsNoEffect class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyDeathEffectsNoEffect
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookEmitEffects()
        {
            if (!HookedList.Contains("EmitEffects"))
            {
                HookedList.Add("EmitEffects");
                On.EnemyDeathEffectsNoEffect.EmitEffects += EmitEffects;
            }
        }

        internal static event Delegates.EmitEffects_BeforeArgs _beforeEmitEffects;
        internal static event Delegates.EmitEffects_AfterArgs _afterEmitEffects;

        private static void EmitEffects(On.EnemyDeathEffectsNoEffect.orig_EmitEffects orig,
            EnemyDeathEffectsNoEffect self)
        {
            Delegates.Params_EmitEffects @params = new()
            {
                self = self
            };
            if (_beforeEmitEffects != null)
            {
                foreach (Delegates.EmitEffects_BeforeArgs toInvoke in _beforeEmitEffects.GetInvocationList())
                {
                    try
                    {
                        _beforeEmitEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterEmitEffects != null)
            {
                foreach (Delegates.EmitEffects_AfterArgs toInvoke in _afterEmitEffects.GetInvocationList())
                {
                    try
                    {
                        _afterEmitEffects.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_EmitEffects
        {
            public EnemyDeathEffectsNoEffect self;
        }

        public delegate void EmitEffects_BeforeArgs(Params_EmitEffects args);

        public delegate void EmitEffects_AfterArgs(Params_EmitEffects args);

        public delegate void EmitEffects_WithArgs(Action<EnemyDeathEffectsNoEffect> orig,
            EnemyDeathEffectsNoEffect self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.EmitEffects_BeforeArgs EmitEffects
        {
            add
            {
                HookHandler._beforeEmitEffects += value;
                HookHandler.HookEmitEffects();
            }
            remove => HookHandler._beforeEmitEffects -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.EmitEffects_AfterArgs EmitEffects
        {
            add
            {
                HookHandler._afterEmitEffects += value;
                HookHandler.HookEmitEffects();
            }
            remove => HookHandler._afterEmitEffects -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.EnemyDeathEffectsNoEffect.hook_EmitEffects EmitEffects
        {
            add => On.EnemyDeathEffectsNoEffect.EmitEffects += value;
            remove => On.EnemyDeathEffectsNoEffect.EmitEffects -= value;
        }
    }
}