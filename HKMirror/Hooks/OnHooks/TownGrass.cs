using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for TownGrass class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTownGrass
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.TownGrass.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.TownGrass.orig_OnTriggerEnter2D orig, TownGrass self,
            UnityEngine.Collider2D collision)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnTriggerEnter2D != null)
            {
                foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
                {
                    try
                    {
                        _beforeOnTriggerEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerEnter2D != null)
            {
                foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
                {
                    try
                    {
                        _afterOnTriggerEnter2D.Invoke(@params);
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
        public sealed class Params_OnTriggerEnter2D
        {
            public TownGrass self;
            public UnityEngine.Collider2D collision;
        }

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<TownGrass, UnityEngine.Collider2D> orig, TownGrass self,
            UnityEngine.Collider2D collision);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.TownGrass.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.TownGrass.OnTriggerEnter2D += value;
            remove => On.TownGrass.OnTriggerEnter2D -= value;
        }
    }
}