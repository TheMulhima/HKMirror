using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PS4SimpleInputDeviceManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPS4SimpleInputDeviceManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Device()
        {
            if (!HookedList.Contains("get_Device"))
            {
                HookedList.Add("get_Device");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "get_Device"), get_Device);
            }
        }

        internal static event Delegates.get_Device_BeforeArgs _beforeget_Device;
        internal static event Delegates.get_Device_AfterArgs _afterget_Device;

        private static PS4SimpleInputDevice get_Device(Func<PS4SimpleInputDeviceManager, PS4SimpleInputDevice> orig,
            PS4SimpleInputDeviceManager self)
        {
            Delegates.Params_get_Device @params = new()
            {
                self = self
            };
            if (_beforeget_Device != null)
                foreach (Delegates.get_Device_BeforeArgs toInvoke in _beforeget_Device.GetInvocationList())
                    try
                    {
                        _beforeget_Device?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Device != null)
                foreach (Delegates.get_Device_AfterArgs toInvoke in _afterget_Device.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Device.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(Action<PS4SimpleInputDeviceManager, ulong, float> orig,
            PS4SimpleInputDeviceManager self, ulong updateTick, float deltaTime)
        {
            Delegates.Params_Update @params = new()
            {
                self = self, updateTick = updateTick, deltaTime = deltaTime
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
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            orig(self, updateTick, deltaTime);
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

        internal static void HookCheckPlatformSupport()
        {
            if (!HookedList.Contains("CheckPlatformSupport"))
            {
                HookedList.Add("CheckPlatformSupport");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "CheckPlatformSupport", false),
                    CheckPlatformSupport);
            }
        }

        internal static event Delegates.CheckPlatformSupport_BeforeArgs _beforeCheckPlatformSupport;
        internal static event Delegates.CheckPlatformSupport_AfterArgs _afterCheckPlatformSupport;

        private static bool CheckPlatformSupport(Func<ICollection<string>, bool> orig, ICollection<string> errors)
        {
            Delegates.Params_CheckPlatformSupport @params = new()
            {
                errors = errors
            };
            if (_beforeCheckPlatformSupport != null)
                foreach (Delegates.CheckPlatformSupport_BeforeArgs toInvoke in _beforeCheckPlatformSupport
                             .GetInvocationList())
                    try
                    {
                        _beforeCheckPlatformSupport?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            errors = @params.errors;
            var retVal = orig(errors);
            if (_afterCheckPlatformSupport != null)
                foreach (Delegates.CheckPlatformSupport_AfterArgs toInvoke in _afterCheckPlatformSupport
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterCheckPlatformSupport.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookEnable()
        {
            if (!HookedList.Contains("Enable"))
            {
                HookedList.Add("Enable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Enable", false), Enable);
            }
        }

        internal static event Delegates.Enable_BeforeArgs _beforeEnable;
        internal static event Delegates.Enable_AfterArgs _afterEnable;

        private static bool Enable(Func<bool> orig)
        {
            if (_beforeEnable != null)
                foreach (Delegates.Enable_BeforeArgs toInvoke in _beforeEnable.GetInvocationList())
                    try
                    {
                        _beforeEnable?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterEnable != null)
                foreach (Delegates.Enable_AfterArgs toInvoke in _afterEnable.GetInvocationList())
                    try
                    {
                        retVal = _afterEnable.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate bool CheckPlatformSupport_AfterArgs(Params_CheckPlatformSupport args, bool ret);

        public delegate void CheckPlatformSupport_BeforeArgs(Params_CheckPlatformSupport args);

        public delegate bool CheckPlatformSupport_WithArgs(Func<ICollection<string>, bool> orig,
            ICollection<string> errors);

        public delegate bool Enable_AfterArgs(bool ret);

        public delegate void Enable_BeforeArgs();

        public delegate bool Enable_WithArgs(Func<bool> orig);

        public delegate PS4SimpleInputDevice get_Device_AfterArgs(Params_get_Device args, PS4SimpleInputDevice ret);

        public delegate void get_Device_BeforeArgs(Params_get_Device args);

        public delegate PS4SimpleInputDevice get_Device_WithArgs(
            Func<PS4SimpleInputDeviceManager, PS4SimpleInputDevice> orig, PS4SimpleInputDeviceManager self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<PS4SimpleInputDeviceManager, ulong, float> orig,
            PS4SimpleInputDeviceManager self, ulong updateTick, float deltaTime);

        public sealed class Params_get_Device
        {
            public PS4SimpleInputDeviceManager self;
        }

        public sealed class Params_Update
        {
            public float deltaTime;
            public PS4SimpleInputDeviceManager self;
            public ulong updateTick;
        }

        public sealed class Params_CheckPlatformSupport
        {
            public ICollection<string> errors;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Device_BeforeArgs get_Device
        {
            add
            {
                HookHandler._beforeget_Device += value;
                HookHandler.Hookget_Device();
            }
            remove => HookHandler._beforeget_Device -= value;
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

        public static event Delegates.CheckPlatformSupport_BeforeArgs CheckPlatformSupport
        {
            add
            {
                HookHandler._beforeCheckPlatformSupport += value;
                HookHandler.HookCheckPlatformSupport();
            }
            remove => HookHandler._beforeCheckPlatformSupport -= value;
        }

        public static event Delegates.Enable_BeforeArgs Enable
        {
            add
            {
                HookHandler._beforeEnable += value;
                HookHandler.HookEnable();
            }
            remove => HookHandler._beforeEnable -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Device_AfterArgs get_Device
        {
            add
            {
                HookHandler._afterget_Device += value;
                HookHandler.Hookget_Device();
            }
            remove => HookHandler._afterget_Device -= value;
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

        public static event Delegates.CheckPlatformSupport_AfterArgs CheckPlatformSupport
        {
            add
            {
                HookHandler._afterCheckPlatformSupport += value;
                HookHandler.HookCheckPlatformSupport();
            }
            remove => HookHandler._afterCheckPlatformSupport -= value;
        }

        public static event Delegates.Enable_AfterArgs Enable
        {
            add
            {
                HookHandler._afterEnable += value;
                HookHandler.HookEnable();
            }
            remove => HookHandler._afterEnable -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Device_WithArgs get_Device
        {
            add => HookEndpointManager.Add<Delegates.get_Device_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "get_Device"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Device_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "get_Device"), value);
        }

        public static event Delegates.Update_WithArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Update"), value);
        }

        public static event Delegates.CheckPlatformSupport_WithArgs CheckPlatformSupport
        {
            add => HookEndpointManager.Add<Delegates.CheckPlatformSupport_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "CheckPlatformSupport", false),
                value);
            remove => HookEndpointManager.Remove<Delegates.CheckPlatformSupport_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "CheckPlatformSupport", false),
                value);
        }

        public static event Delegates.Enable_WithArgs Enable
        {
            add => HookEndpointManager.Add<Delegates.Enable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Enable", false), value);
            remove => HookEndpointManager.Remove<Delegates.Enable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Enable", false), value);
        }
    }
}