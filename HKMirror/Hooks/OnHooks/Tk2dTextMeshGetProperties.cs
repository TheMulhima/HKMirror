using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for Tk2dTextMeshGetProperties class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dTextMeshGetProperties
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hook_getTextMesh()
        {
            if (!HookedList.Contains("_getTextMesh"))
            {
                HookedList.Add("_getTextMesh");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                        "_getTextMesh", true), _getTextMesh);
            }
        }

        internal static event Delegates._getTextMesh_BeforeArgs _before_getTextMesh;
        internal static event Delegates._getTextMesh_AfterArgs _after_getTextMesh;

        private static void _getTextMesh(Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self)
        {
            Delegates.Params__getTextMesh @params = new()
            {
                self = self
            };
            if (_before_getTextMesh != null)
            {
                foreach (Delegates._getTextMesh_BeforeArgs toInvoke in _before_getTextMesh.GetInvocationList())
                {
                    try
                    {
                        _before_getTextMesh?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_after_getTextMesh != null)
            {
                foreach (Delegates._getTextMesh_AfterArgs toInvoke in _after_getTextMesh.GetInvocationList())
                {
                    try
                    {
                        _after_getTextMesh.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                        "Reset", true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                        "OnEnter", true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
            {
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
            {
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoGetProperties()
        {
            if (!HookedList.Contains("DoGetProperties"))
            {
                HookedList.Add("DoGetProperties");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                        "DoGetProperties", true), DoGetProperties);
            }
        }

        internal static event Delegates.DoGetProperties_BeforeArgs _beforeDoGetProperties;
        internal static event Delegates.DoGetProperties_AfterArgs _afterDoGetProperties;

        private static void DoGetProperties(Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self)
        {
            Delegates.Params_DoGetProperties @params = new()
            {
                self = self
            };
            if (_beforeDoGetProperties != null)
            {
                foreach (Delegates.DoGetProperties_BeforeArgs toInvoke in _beforeDoGetProperties.GetInvocationList())
                {
                    try
                    {
                        _beforeDoGetProperties?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoGetProperties != null)
            {
                foreach (Delegates.DoGetProperties_AfterArgs toInvoke in _afterDoGetProperties.GetInvocationList())
                {
                    try
                    {
                        _afterDoGetProperties.Invoke(@params);
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
        public sealed class Params__getTextMesh
        {
            public HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self;
        }

        public delegate void _getTextMesh_BeforeArgs(Params__getTextMesh args);

        public delegate void _getTextMesh_AfterArgs(Params__getTextMesh args);

        public delegate void _getTextMesh_WithArgs(Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self);

        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self);

        public sealed class Params_DoGetProperties
        {
            public HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self;
        }

        public delegate void DoGetProperties_BeforeArgs(Params_DoGetProperties args);

        public delegate void DoGetProperties_AfterArgs(Params_DoGetProperties args);

        public delegate void DoGetProperties_WithArgs(
            Action<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties> orig,
            HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates._getTextMesh_BeforeArgs _getTextMesh
        {
            add
            {
                HookHandler._before_getTextMesh += value;
                HookHandler.Hook_getTextMesh();
            }
            remove => HookHandler._before_getTextMesh -= value;
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

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.DoGetProperties_BeforeArgs DoGetProperties
        {
            add
            {
                HookHandler._beforeDoGetProperties += value;
                HookHandler.HookDoGetProperties();
            }
            remove => HookHandler._beforeDoGetProperties -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates._getTextMesh_AfterArgs _getTextMesh
        {
            add
            {
                HookHandler._after_getTextMesh += value;
                HookHandler.Hook_getTextMesh();
            }
            remove => HookHandler._after_getTextMesh -= value;
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

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.DoGetProperties_AfterArgs DoGetProperties
        {
            add
            {
                HookHandler._afterDoGetProperties += value;
                HookHandler.HookDoGetProperties();
            }
            remove => HookHandler._afterDoGetProperties -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates._getTextMesh_WithArgs _getTextMesh
        {
            add => HookEndpointManager.Add<Delegates._getTextMesh_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                    "_getTextMesh", true), value);
            remove => HookEndpointManager.Remove<Delegates._getTextMesh_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                    "_getTextMesh", true), value);
        }

        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties), "Reset",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties), "Reset",
                    true), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                    "OnEnter", true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                    "OnEnter", true), value);
        }

        public static event Delegates.DoGetProperties_WithArgs DoGetProperties
        {
            add => HookEndpointManager.Add<Delegates.DoGetProperties_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                    "DoGetProperties", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetProperties_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetProperties),
                    "DoGetProperties", true), value);
        }
    }
}