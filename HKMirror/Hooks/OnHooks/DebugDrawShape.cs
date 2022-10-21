using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for DebugDrawShape class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDebugDrawShape
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.DebugDrawShape), "Reset", true),
                    Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.DebugDrawShape> orig,
            HutongGames.PlayMaker.Actions.DebugDrawShape self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnDrawActionGizmos()
        {
            if (!HookedList.Contains("OnDrawActionGizmos"))
            {
                HookedList.Add("OnDrawActionGizmos");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.DebugDrawShape),
                        "OnDrawActionGizmos", true), OnDrawActionGizmos);
            }
        }

        internal static event Delegates.OnDrawActionGizmos_BeforeArgs _beforeOnDrawActionGizmos;
        internal static event Delegates.OnDrawActionGizmos_AfterArgs _afterOnDrawActionGizmos;

        private static void OnDrawActionGizmos(Action<HutongGames.PlayMaker.Actions.DebugDrawShape> orig,
            HutongGames.PlayMaker.Actions.DebugDrawShape self)
        {
            Delegates.Params_OnDrawActionGizmos @params = new()
            {
                self = self
            };
            if (_beforeOnDrawActionGizmos != null)
            {
                foreach (Delegates.OnDrawActionGizmos_BeforeArgs toInvoke in
                         _beforeOnDrawActionGizmos.GetInvocationList())
                {
                    try
                    {
                        _beforeOnDrawActionGizmos?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnDrawActionGizmos != null)
            {
                foreach (Delegates.OnDrawActionGizmos_AfterArgs toInvoke in
                         _afterOnDrawActionGizmos.GetInvocationList())
                {
                    try
                    {
                        _afterOnDrawActionGizmos.Invoke(@params);
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
        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.DebugDrawShape self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.DebugDrawShape> orig,
            HutongGames.PlayMaker.Actions.DebugDrawShape self);

        public sealed class Params_OnDrawActionGizmos
        {
            public HutongGames.PlayMaker.Actions.DebugDrawShape self;
        }

        public delegate void OnDrawActionGizmos_BeforeArgs(Params_OnDrawActionGizmos args);

        public delegate void OnDrawActionGizmos_AfterArgs(Params_OnDrawActionGizmos args);

        public delegate void OnDrawActionGizmos_WithArgs(Action<HutongGames.PlayMaker.Actions.DebugDrawShape> orig,
            HutongGames.PlayMaker.Actions.DebugDrawShape self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.OnDrawActionGizmos_BeforeArgs OnDrawActionGizmos
        {
            add
            {
                HookHandler._beforeOnDrawActionGizmos += value;
                HookHandler.HookOnDrawActionGizmos();
            }
            remove => HookHandler._beforeOnDrawActionGizmos -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.OnDrawActionGizmos_AfterArgs OnDrawActionGizmos
        {
            add
            {
                HookHandler._afterOnDrawActionGizmos += value;
                HookHandler.HookOnDrawActionGizmos();
            }
            remove => HookHandler._afterOnDrawActionGizmos -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.DebugDrawShape), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.DebugDrawShape), "Reset", true),
                value);
        }

        public static event Delegates.OnDrawActionGizmos_WithArgs OnDrawActionGizmos
        {
            add => HookEndpointManager.Add<Delegates.OnDrawActionGizmos_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.DebugDrawShape),
                    "OnDrawActionGizmos", true), value);
            remove => HookEndpointManager.Remove<Delegates.OnDrawActionGizmos_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.DebugDrawShape),
                    "OnDrawActionGizmos", true), value);
        }
    }
}