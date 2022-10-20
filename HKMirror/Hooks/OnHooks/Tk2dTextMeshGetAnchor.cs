using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Tk2dTextMeshGetAnchor class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dTextMeshGetAnchor
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hook_getTextMesh()
        {
            if (!HookedList.Contains("_getTextMesh"))
            {
                HookedList.Add("_getTextMesh");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "_getTextMesh"), _getTextMesh);
            }
        }

        internal static event Delegates._getTextMesh_BeforeArgs _before_getTextMesh;
        internal static event Delegates._getTextMesh_NormalArgs _after_getTextMesh;

        private static void _getTextMesh(Action<Tk2dTextMeshGetAnchor> orig, Tk2dTextMeshGetAnchor self)
        {
            Delegates.Params__getTextMesh @params = new()
            {
                self = self
            };
            _before_getTextMesh?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_after_getTextMesh != null) _after_getTextMesh.Invoke(@params);
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<Tk2dTextMeshGetAnchor> orig, Tk2dTextMeshGetAnchor self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<Tk2dTextMeshGetAnchor> orig, Tk2dTextMeshGetAnchor self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            _beforeOnEnter?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnter != null) _afterOnEnter.Invoke(@params);
        }

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<Tk2dTextMeshGetAnchor> orig, Tk2dTextMeshGetAnchor self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            _beforeOnUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null) _afterOnUpdate.Invoke(@params);
        }

        internal static void HookDoGetAnchor()
        {
            if (!HookedList.Contains("DoGetAnchor"))
            {
                HookedList.Add("DoGetAnchor");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "DoGetAnchor"), DoGetAnchor);
            }
        }

        internal static event Delegates.DoGetAnchor_BeforeArgs _beforeDoGetAnchor;
        internal static event Delegates.DoGetAnchor_NormalArgs _afterDoGetAnchor;

        private static void DoGetAnchor(Action<Tk2dTextMeshGetAnchor> orig, Tk2dTextMeshGetAnchor self)
        {
            Delegates.Params_DoGetAnchor @params = new()
            {
                self = self
            };
            _beforeDoGetAnchor?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoGetAnchor != null) _afterDoGetAnchor.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void _getTextMesh_BeforeArgs(Params__getTextMesh args);

        public delegate void _getTextMesh_NormalArgs(Params__getTextMesh args);

        public delegate void DoGetAnchor_BeforeArgs(Params_DoGetAnchor args);

        public delegate void DoGetAnchor_NormalArgs(Params_DoGetAnchor args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params__getTextMesh
        {
            public Tk2dTextMeshGetAnchor self;
        }

        public sealed class Params_Reset
        {
            public Tk2dTextMeshGetAnchor self;
        }

        public sealed class Params_OnEnter
        {
            public Tk2dTextMeshGetAnchor self;
        }

        public sealed class Params_OnUpdate
        {
            public Tk2dTextMeshGetAnchor self;
        }

        public sealed class Params_DoGetAnchor
        {
            public Tk2dTextMeshGetAnchor self;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoGetAnchor_BeforeArgs DoGetAnchor
        {
            add
            {
                HookHandler._beforeDoGetAnchor += value;
                HookHandler.HookDoGetAnchor();
            }
            remove => HookHandler._beforeDoGetAnchor -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates._getTextMesh_NormalArgs _getTextMesh
        {
            add
            {
                HookHandler._after_getTextMesh += value;
                HookHandler.Hook_getTextMesh();
            }
            remove => HookHandler._after_getTextMesh -= value;
        }

        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoGetAnchor_NormalArgs DoGetAnchor
        {
            add
            {
                HookHandler._afterDoGetAnchor += value;
                HookHandler.HookDoGetAnchor();
            }
            remove => HookHandler._afterDoGetAnchor -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates._getTextMesh_NormalArgs _getTextMesh
        {
            add => HookEndpointManager.Add<Delegates._getTextMesh_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "_getTextMesh"), value);
            remove => HookEndpointManager.Remove<Delegates._getTextMesh_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "_getTextMesh"), value);
        }

        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "OnUpdate"), value);
        }

        public static event Delegates.DoGetAnchor_NormalArgs DoGetAnchor
        {
            add => HookEndpointManager.Add<Delegates.DoGetAnchor_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "DoGetAnchor"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetAnchor_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshGetAnchor), "DoGetAnchor"), value);
        }
    }
}