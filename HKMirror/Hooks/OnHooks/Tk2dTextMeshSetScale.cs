using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Tk2dTextMeshSetScale class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dTextMeshSetScale
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hook_getTextMesh()
        {
            if (!HookedList.Contains("_getTextMesh"))
            {
                HookedList.Add("_getTextMesh");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "_getTextMesh"), _getTextMesh);
            }
        }

        internal static event Delegates._getTextMesh_BeforeArgs _before_getTextMesh;
        internal static event Delegates._getTextMesh_NormalArgs _after_getTextMesh;

        private static void _getTextMesh(Action<Tk2dTextMeshSetScale> orig, Tk2dTextMeshSetScale self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<Tk2dTextMeshSetScale> orig, Tk2dTextMeshSetScale self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<Tk2dTextMeshSetScale> orig, Tk2dTextMeshSetScale self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<Tk2dTextMeshSetScale> orig, Tk2dTextMeshSetScale self)
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

        internal static void HookDoSetScale()
        {
            if (!HookedList.Contains("DoSetScale"))
            {
                HookedList.Add("DoSetScale");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "DoSetScale"), DoSetScale);
            }
        }

        internal static event Delegates.DoSetScale_BeforeArgs _beforeDoSetScale;
        internal static event Delegates.DoSetScale_NormalArgs _afterDoSetScale;

        private static void DoSetScale(Action<Tk2dTextMeshSetScale> orig, Tk2dTextMeshSetScale self)
        {
            Delegates.Params_DoSetScale @params = new()
            {
                self = self
            };
            _beforeDoSetScale?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSetScale != null) _afterDoSetScale.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void _getTextMesh_BeforeArgs(Params__getTextMesh args);

        public delegate void _getTextMesh_NormalArgs(Params__getTextMesh args);

        public delegate void DoSetScale_BeforeArgs(Params_DoSetScale args);

        public delegate void DoSetScale_NormalArgs(Params_DoSetScale args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params__getTextMesh
        {
            public Tk2dTextMeshSetScale self;
        }

        public sealed class Params_Reset
        {
            public Tk2dTextMeshSetScale self;
        }

        public sealed class Params_OnEnter
        {
            public Tk2dTextMeshSetScale self;
        }

        public sealed class Params_OnUpdate
        {
            public Tk2dTextMeshSetScale self;
        }

        public sealed class Params_DoSetScale
        {
            public Tk2dTextMeshSetScale self;
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

        public static event Delegates.DoSetScale_BeforeArgs DoSetScale
        {
            add
            {
                HookHandler._beforeDoSetScale += value;
                HookHandler.HookDoSetScale();
            }
            remove => HookHandler._beforeDoSetScale -= value;
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

        public static event Delegates.DoSetScale_NormalArgs DoSetScale
        {
            add
            {
                HookHandler._afterDoSetScale += value;
                HookHandler.HookDoSetScale();
            }
            remove => HookHandler._afterDoSetScale -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "_getTextMesh"), value);
            remove => HookEndpointManager.Remove<Delegates._getTextMesh_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "_getTextMesh"), value);
        }

        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "OnUpdate"), value);
        }

        public static event Delegates.DoSetScale_NormalArgs DoSetScale
        {
            add => HookEndpointManager.Add<Delegates.DoSetScale_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "DoSetScale"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetScale_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetScale), "DoSetScale"), value);
        }
    }
}