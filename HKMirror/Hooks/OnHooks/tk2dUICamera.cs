using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dUICamera class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dUICamera
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAssignRaycastLayerMask()
        {
            if (!HookedList.Contains("AssignRaycastLayerMask"))
            {
                HookedList.Add("AssignRaycastLayerMask");
                On.tk2dUICamera.AssignRaycastLayerMask += AssignRaycastLayerMask;
            }
        }

        internal static event Delegates.AssignRaycastLayerMask_BeforeArgs _beforeAssignRaycastLayerMask;
        internal static event Delegates.AssignRaycastLayerMask_NormalArgs _afterAssignRaycastLayerMask;

        private static void AssignRaycastLayerMask(On.tk2dUICamera.orig_AssignRaycastLayerMask orig, tk2dUICamera self,
            LayerMask mask)
        {
            Delegates.Params_AssignRaycastLayerMask @params = new()
            {
                self = self, mask = mask
            };
            _beforeAssignRaycastLayerMask?.Invoke(@params);
            self = @params.self;
            mask = @params.mask;
            orig(self, mask);
            if (_afterAssignRaycastLayerMask != null) _afterAssignRaycastLayerMask.Invoke(@params);
        }

        internal static void Hookget_FilteredMask()
        {
            if (!HookedList.Contains("get_FilteredMask"))
            {
                HookedList.Add("get_FilteredMask");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_FilteredMask"), get_FilteredMask);
            }
        }

        internal static event Delegates.get_FilteredMask_BeforeArgs _beforeget_FilteredMask;
        internal static event Delegates.get_FilteredMask_NormalArgs _afterget_FilteredMask;

        private static LayerMask get_FilteredMask(Func<tk2dUICamera, LayerMask> orig, tk2dUICamera self)
        {
            Delegates.Params_get_FilteredMask @params = new()
            {
                self = self
            };
            _beforeget_FilteredMask?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_FilteredMask != null) retVal = _afterget_FilteredMask.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_HostCamera()
        {
            if (!HookedList.Contains("get_HostCamera"))
            {
                HookedList.Add("get_HostCamera");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_HostCamera"), get_HostCamera);
            }
        }

        internal static event Delegates.get_HostCamera_BeforeArgs _beforeget_HostCamera;
        internal static event Delegates.get_HostCamera_NormalArgs _afterget_HostCamera;

        private static Camera get_HostCamera(Func<tk2dUICamera, Camera> orig, tk2dUICamera self)
        {
            Delegates.Params_get_HostCamera @params = new()
            {
                self = self
            };
            _beforeget_HostCamera?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_HostCamera != null) retVal = _afterget_HostCamera.Invoke(@params);
            return retVal;
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.tk2dUICamera.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.tk2dUICamera.orig_OnEnable orig, tk2dUICamera self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.tk2dUICamera.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.tk2dUICamera.orig_OnDisable orig, tk2dUICamera self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            _beforeOnDisable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnDisable != null) _afterOnDisable.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void AssignRaycastLayerMask_BeforeArgs(Params_AssignRaycastLayerMask args);

        public delegate void AssignRaycastLayerMask_NormalArgs(Params_AssignRaycastLayerMask args);

        public delegate void get_FilteredMask_BeforeArgs(Params_get_FilteredMask args);

        public delegate LayerMask get_FilteredMask_NormalArgs(Params_get_FilteredMask args);

        public delegate void get_HostCamera_BeforeArgs(Params_get_HostCamera args);

        public delegate Camera get_HostCamera_NormalArgs(Params_get_HostCamera args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public sealed class Params_AssignRaycastLayerMask
        {
            public LayerMask mask;
            public tk2dUICamera self;
        }

        public sealed class Params_get_FilteredMask
        {
            public tk2dUICamera self;
        }

        public sealed class Params_get_HostCamera
        {
            public tk2dUICamera self;
        }

        public sealed class Params_OnEnable
        {
            public tk2dUICamera self;
        }

        public sealed class Params_OnDisable
        {
            public tk2dUICamera self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.AssignRaycastLayerMask_BeforeArgs AssignRaycastLayerMask
        {
            add
            {
                HookHandler._beforeAssignRaycastLayerMask += value;
                HookHandler.HookAssignRaycastLayerMask();
            }
            remove => HookHandler._beforeAssignRaycastLayerMask -= value;
        }

        public static event Delegates.get_FilteredMask_BeforeArgs get_FilteredMask
        {
            add
            {
                HookHandler._beforeget_FilteredMask += value;
                HookHandler.Hookget_FilteredMask();
            }
            remove => HookHandler._beforeget_FilteredMask -= value;
        }

        public static event Delegates.get_HostCamera_BeforeArgs get_HostCamera
        {
            add
            {
                HookHandler._beforeget_HostCamera += value;
                HookHandler.Hookget_HostCamera();
            }
            remove => HookHandler._beforeget_HostCamera -= value;
        }

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.AssignRaycastLayerMask_NormalArgs AssignRaycastLayerMask
        {
            add
            {
                HookHandler._afterAssignRaycastLayerMask += value;
                HookHandler.HookAssignRaycastLayerMask();
            }
            remove => HookHandler._afterAssignRaycastLayerMask -= value;
        }

        public static event Delegates.get_FilteredMask_NormalArgs get_FilteredMask
        {
            add
            {
                HookHandler._afterget_FilteredMask += value;
                HookHandler.Hookget_FilteredMask();
            }
            remove => HookHandler._afterget_FilteredMask -= value;
        }

        public static event Delegates.get_HostCamera_NormalArgs get_HostCamera
        {
            add
            {
                HookHandler._afterget_HostCamera += value;
                HookHandler.Hookget_HostCamera();
            }
            remove => HookHandler._afterget_HostCamera -= value;
        }

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.tk2dUICamera.hook_AssignRaycastLayerMask AssignRaycastLayerMask
        {
            add => On.tk2dUICamera.AssignRaycastLayerMask += value;
            remove => On.tk2dUICamera.AssignRaycastLayerMask -= value;
        }

        public static event Delegates.get_FilteredMask_NormalArgs get_FilteredMask
        {
            add => HookEndpointManager.Add<Delegates.get_FilteredMask_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_FilteredMask"), value);
            remove => HookEndpointManager.Remove<Delegates.get_FilteredMask_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_FilteredMask"), value);
        }

        public static event Delegates.get_HostCamera_NormalArgs get_HostCamera
        {
            add => HookEndpointManager.Add<Delegates.get_HostCamera_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_HostCamera"), value);
            remove => HookEndpointManager.Remove<Delegates.get_HostCamera_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_HostCamera"), value);
        }

        public static event On.tk2dUICamera.hook_OnEnable OnEnable
        {
            add => On.tk2dUICamera.OnEnable += value;
            remove => On.tk2dUICamera.OnEnable -= value;
        }

        public static event On.tk2dUICamera.hook_OnDisable OnDisable
        {
            add => On.tk2dUICamera.OnDisable += value;
            remove => On.tk2dUICamera.OnDisable -= value;
        }
    }
}