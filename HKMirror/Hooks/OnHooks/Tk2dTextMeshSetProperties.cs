using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Tk2dTextMeshSetProperties class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dTextMeshSetProperties
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hook_getTextMesh()
        {
            if (!HookedList.Contains("_getTextMesh"))
            {
                HookedList.Add("_getTextMesh");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "_getTextMesh"),
                    _getTextMesh);
            }
        }

        internal static event Delegates._getTextMesh_BeforeArgs _before_getTextMesh;
        internal static event Delegates._getTextMesh_AfterArgs _after_getTextMesh;

        private static void _getTextMesh(Action<Tk2dTextMeshSetProperties> orig, Tk2dTextMeshSetProperties self)
        {
            Delegates.Params__getTextMesh @params = new()
            {
                self = self
            };
            if (_before_getTextMesh != null)
                foreach (Delegates._getTextMesh_BeforeArgs toInvoke in _before_getTextMesh.GetInvocationList())
                    try
                    {
                        _before_getTextMesh?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_after_getTextMesh != null)
                foreach (Delegates._getTextMesh_AfterArgs toInvoke in _after_getTextMesh.GetInvocationList())
                    try
                    {
                        _after_getTextMesh.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<Tk2dTextMeshSetProperties> orig, Tk2dTextMeshSetProperties self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<Tk2dTextMeshSetProperties> orig, Tk2dTextMeshSetProperties self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoSetProperties()
        {
            if (!HookedList.Contains("DoSetProperties"))
            {
                HookedList.Add("DoSetProperties");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "DoSetProperties"),
                    DoSetProperties);
            }
        }

        internal static event Delegates.DoSetProperties_BeforeArgs _beforeDoSetProperties;
        internal static event Delegates.DoSetProperties_AfterArgs _afterDoSetProperties;

        private static void DoSetProperties(Action<Tk2dTextMeshSetProperties> orig, Tk2dTextMeshSetProperties self)
        {
            Delegates.Params_DoSetProperties @params = new()
            {
                self = self
            };
            if (_beforeDoSetProperties != null)
                foreach (Delegates.DoSetProperties_BeforeArgs toInvoke in _beforeDoSetProperties.GetInvocationList())
                    try
                    {
                        _beforeDoSetProperties?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetProperties != null)
                foreach (Delegates.DoSetProperties_AfterArgs toInvoke in _afterDoSetProperties.GetInvocationList())
                    try
                    {
                        _afterDoSetProperties.Invoke(@params);
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
        public delegate void _getTextMesh_AfterArgs(Params__getTextMesh args);

        public delegate void _getTextMesh_BeforeArgs(Params__getTextMesh args);

        public delegate void _getTextMesh_WithArgs(Action<Tk2dTextMeshSetProperties> orig,
            Tk2dTextMeshSetProperties self);

        public delegate void DoSetProperties_AfterArgs(Params_DoSetProperties args);

        public delegate void DoSetProperties_BeforeArgs(Params_DoSetProperties args);

        public delegate void DoSetProperties_WithArgs(Action<Tk2dTextMeshSetProperties> orig,
            Tk2dTextMeshSetProperties self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<Tk2dTextMeshSetProperties> orig, Tk2dTextMeshSetProperties self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<Tk2dTextMeshSetProperties> orig, Tk2dTextMeshSetProperties self);

        public sealed class Params__getTextMesh
        {
            public Tk2dTextMeshSetProperties self;
        }

        public sealed class Params_Reset
        {
            public Tk2dTextMeshSetProperties self;
        }

        public sealed class Params_OnEnter
        {
            public Tk2dTextMeshSetProperties self;
        }

        public sealed class Params_DoSetProperties
        {
            public Tk2dTextMeshSetProperties self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.DoSetProperties_BeforeArgs DoSetProperties
        {
            add
            {
                HookHandler._beforeDoSetProperties += value;
                HookHandler.HookDoSetProperties();
            }
            remove => HookHandler._beforeDoSetProperties -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.DoSetProperties_AfterArgs DoSetProperties
        {
            add
            {
                HookHandler._afterDoSetProperties += value;
                HookHandler.HookDoSetProperties();
            }
            remove => HookHandler._afterDoSetProperties -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates._getTextMesh_WithArgs _getTextMesh
        {
            add => HookEndpointManager.Add<Delegates._getTextMesh_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "_getTextMesh"), value);
            remove => HookEndpointManager.Remove<Delegates._getTextMesh_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "_getTextMesh"), value);
        }

        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "OnEnter"), value);
        }

        public static event Delegates.DoSetProperties_WithArgs DoSetProperties
        {
            add => HookEndpointManager.Add<Delegates.DoSetProperties_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "DoSetProperties"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetProperties_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetProperties), "DoSetProperties"), value);
        }
    }
}