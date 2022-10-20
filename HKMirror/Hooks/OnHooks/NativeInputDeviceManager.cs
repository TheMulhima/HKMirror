using System.Collections.ObjectModel;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for NativeInputDeviceManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnNativeInputDeviceManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookDestroy()
        {
            if (!HookedList.Contains("Destroy"))
            {
                HookedList.Add("Destroy");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Destroy"), Destroy);
            }
        }

        internal static event Delegates.Destroy_BeforeArgs _beforeDestroy;
        internal static event Delegates.Destroy_NormalArgs _afterDestroy;

        private static void Destroy(Action<NativeInputDeviceManager> orig, NativeInputDeviceManager self)
        {
            Delegates.Params_Destroy @params = new()
            {
                self = self
            };
            _beforeDestroy?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDestroy != null) _afterDestroy.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(Action<NativeInputDeviceManager, ulong, float> orig, NativeInputDeviceManager self,
            ulong updateTick, float deltaTime)
        {
            Delegates.Params_Update @params = new()
            {
                self = self, updateTick = updateTick, deltaTime = deltaTime
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            orig(self, updateTick, deltaTime);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookDetectDevice()
        {
            if (!HookedList.Contains("DetectDevice"))
            {
                HookedList.Add("DetectDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetectDevice"),
                    DetectDevice);
            }
        }

        internal static event Delegates.DetectDevice_BeforeArgs _beforeDetectDevice;
        internal static event Delegates.DetectDevice_NormalArgs _afterDetectDevice;

        private static void DetectDevice(Action<NativeInputDeviceManager, uint, InputDeviceInfo> orig,
            NativeInputDeviceManager self, uint deviceHandle, InputDeviceInfo deviceInfo)
        {
            Delegates.Params_DetectDevice @params = new()
            {
                self = self, deviceHandle = deviceHandle, deviceInfo = deviceInfo
            };
            _beforeDetectDevice?.Invoke(@params);
            self = @params.self;
            deviceHandle = @params.deviceHandle;
            deviceInfo = @params.deviceInfo;
            orig(self, deviceHandle, deviceInfo);
            if (_afterDetectDevice != null) _afterDetectDevice.Invoke(@params);
        }

        internal static void HookAttachDevice()
        {
            if (!HookedList.Contains("AttachDevice"))
            {
                HookedList.Add("AttachDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AttachDevice"),
                    AttachDevice);
            }
        }

        internal static event Delegates.AttachDevice_BeforeArgs _beforeAttachDevice;
        internal static event Delegates.AttachDevice_NormalArgs _afterAttachDevice;

        private static void AttachDevice(Action<NativeInputDeviceManager, NativeInputDevice> orig,
            NativeInputDeviceManager self, NativeInputDevice device)
        {
            Delegates.Params_AttachDevice @params = new()
            {
                self = self, device = device
            };
            _beforeAttachDevice?.Invoke(@params);
            self = @params.self;
            device = @params.device;
            orig(self, device);
            if (_afterAttachDevice != null) _afterAttachDevice.Invoke(@params);
        }

        internal static void HookDetachDevice()
        {
            if (!HookedList.Contains("DetachDevice"))
            {
                HookedList.Add("DetachDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetachDevice"),
                    DetachDevice);
            }
        }

        internal static event Delegates.DetachDevice_BeforeArgs _beforeDetachDevice;
        internal static event Delegates.DetachDevice_NormalArgs _afterDetachDevice;

        private static void DetachDevice(Action<NativeInputDeviceManager, NativeInputDevice> orig,
            NativeInputDeviceManager self, NativeInputDevice device)
        {
            Delegates.Params_DetachDevice @params = new()
            {
                self = self, device = device
            };
            _beforeDetachDevice?.Invoke(@params);
            self = @params.self;
            device = @params.device;
            orig(self, device);
            if (_afterDetachDevice != null) _afterDetachDevice.Invoke(@params);
        }

        internal static void HookFindAttachedDevice()
        {
            if (!HookedList.Contains("FindAttachedDevice"))
            {
                HookedList.Add("FindAttachedDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindAttachedDevice"),
                    FindAttachedDevice);
            }
        }

        internal static event Delegates.FindAttachedDevice_BeforeArgs _beforeFindAttachedDevice;
        internal static event Delegates.FindAttachedDevice_NormalArgs _afterFindAttachedDevice;

        private static NativeInputDevice FindAttachedDevice(
            Func<NativeInputDeviceManager, uint, NativeInputDevice> orig, NativeInputDeviceManager self,
            uint deviceHandle)
        {
            Delegates.Params_FindAttachedDevice @params = new()
            {
                self = self, deviceHandle = deviceHandle
            };
            _beforeFindAttachedDevice?.Invoke(@params);
            self = @params.self;
            deviceHandle = @params.deviceHandle;
            var retVal = orig(self, deviceHandle);
            if (_afterFindAttachedDevice != null) retVal = _afterFindAttachedDevice.Invoke(@params);
            return retVal;
        }

        internal static void HookFindDetachedDevice()
        {
            if (!HookedList.Contains("FindDetachedDevice"))
            {
                HookedList.Add("FindDetachedDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindDetachedDevice"),
                    FindDetachedDevice);
            }
        }

        internal static event Delegates.FindDetachedDevice_BeforeArgs _beforeFindDetachedDevice;
        internal static event Delegates.FindDetachedDevice_NormalArgs _afterFindDetachedDevice;

        private static NativeInputDevice FindDetachedDevice(
            Func<NativeInputDeviceManager, InputDeviceInfo, NativeInputDevice> orig, NativeInputDeviceManager self,
            InputDeviceInfo deviceInfo)
        {
            Delegates.Params_FindDetachedDevice @params = new()
            {
                self = self, deviceInfo = deviceInfo
            };
            _beforeFindDetachedDevice?.Invoke(@params);
            self = @params.self;
            deviceInfo = @params.deviceInfo;
            var retVal = orig(self, deviceInfo);
            if (_afterFindDetachedDevice != null) retVal = _afterFindDetachedDevice.Invoke(@params);
            return retVal;
        }

        internal static void HookSystemFindDetachedDevice()
        {
            if (!HookedList.Contains("SystemFindDetachedDevice"))
            {
                HookedList.Add("SystemFindDetachedDevice");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "SystemFindDetachedDevice", false),
                    SystemFindDetachedDevice);
            }
        }

        internal static event Delegates.SystemFindDetachedDevice_BeforeArgs _beforeSystemFindDetachedDevice;
        internal static event Delegates.SystemFindDetachedDevice_NormalArgs _afterSystemFindDetachedDevice;

        private static NativeInputDevice SystemFindDetachedDevice(
            Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> orig,
            InputDeviceInfo deviceInfo, ReadOnlyCollection<NativeInputDevice> detachedDevices)
        {
            Delegates.Params_SystemFindDetachedDevice @params = new()
            {
                deviceInfo = deviceInfo, detachedDevices = detachedDevices
            };
            _beforeSystemFindDetachedDevice?.Invoke(@params);
            deviceInfo = @params.deviceInfo;
            detachedDevices = @params.detachedDevices;
            var retVal = orig(deviceInfo, detachedDevices);
            if (_afterSystemFindDetachedDevice != null) retVal = _afterSystemFindDetachedDevice.Invoke(@params);
            return retVal;
        }

        internal static void HookAddSystemDeviceProfile()
        {
            if (!HookedList.Contains("AddSystemDeviceProfile"))
            {
                HookedList.Add("AddSystemDeviceProfile");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfile"),
                    AddSystemDeviceProfile);
            }
        }

        internal static event Delegates.AddSystemDeviceProfile_BeforeArgs _beforeAddSystemDeviceProfile;
        internal static event Delegates.AddSystemDeviceProfile_NormalArgs _afterAddSystemDeviceProfile;

        private static void AddSystemDeviceProfile(Action<NativeInputDeviceManager, InputDeviceProfile> orig,
            NativeInputDeviceManager self, InputDeviceProfile deviceProfile)
        {
            Delegates.Params_AddSystemDeviceProfile @params = new()
            {
                self = self, deviceProfile = deviceProfile
            };
            _beforeAddSystemDeviceProfile?.Invoke(@params);
            self = @params.self;
            deviceProfile = @params.deviceProfile;
            orig(self, deviceProfile);
            if (_afterAddSystemDeviceProfile != null) _afterAddSystemDeviceProfile.Invoke(@params);
        }

        internal static void HookAddSystemDeviceProfiles()
        {
            if (!HookedList.Contains("AddSystemDeviceProfiles"))
            {
                HookedList.Add("AddSystemDeviceProfiles");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfiles"),
                    AddSystemDeviceProfiles);
            }
        }

        internal static event Delegates.AddSystemDeviceProfiles_BeforeArgs _beforeAddSystemDeviceProfiles;
        internal static event Delegates.AddSystemDeviceProfiles_NormalArgs _afterAddSystemDeviceProfiles;

        private static void AddSystemDeviceProfiles(Action<NativeInputDeviceManager> orig,
            NativeInputDeviceManager self)
        {
            Delegates.Params_AddSystemDeviceProfiles @params = new()
            {
                self = self
            };
            _beforeAddSystemDeviceProfiles?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAddSystemDeviceProfiles != null) _afterAddSystemDeviceProfiles.Invoke(@params);
        }

        internal static void HookCheckPlatformSupport()
        {
            if (!HookedList.Contains("CheckPlatformSupport"))
            {
                HookedList.Add("CheckPlatformSupport");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "CheckPlatformSupport", false),
                    CheckPlatformSupport);
            }
        }

        internal static event Delegates.CheckPlatformSupport_BeforeArgs _beforeCheckPlatformSupport;
        internal static event Delegates.CheckPlatformSupport_NormalArgs _afterCheckPlatformSupport;

        private static bool CheckPlatformSupport(Func<ICollection<string>, bool> orig, ICollection<string> errors)
        {
            Delegates.Params_CheckPlatformSupport @params = new()
            {
                errors = errors
            };
            _beforeCheckPlatformSupport?.Invoke(@params);
            errors = @params.errors;
            var retVal = orig(errors);
            if (_afterCheckPlatformSupport != null) retVal = _afterCheckPlatformSupport.Invoke(@params);
            return retVal;
        }

        internal static void HookEnable()
        {
            if (!HookedList.Contains("Enable"))
            {
                HookedList.Add("Enable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Enable", false), Enable);
            }
        }

        internal static event Delegates.Enable_BeforeArgs _beforeEnable;
        internal static event Delegates.Enable_NormalArgs _afterEnable;

        private static bool Enable(Func<bool> orig)
        {
            _beforeEnable?.Invoke();
            var retVal = orig();
            if (_afterEnable != null) retVal = _afterEnable.Invoke();
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void AddSystemDeviceProfile_BeforeArgs(Params_AddSystemDeviceProfile args);

        public delegate void AddSystemDeviceProfile_NormalArgs(Params_AddSystemDeviceProfile args);

        public delegate void AddSystemDeviceProfiles_BeforeArgs(Params_AddSystemDeviceProfiles args);

        public delegate void AddSystemDeviceProfiles_NormalArgs(Params_AddSystemDeviceProfiles args);

        public delegate void AttachDevice_BeforeArgs(Params_AttachDevice args);

        public delegate void AttachDevice_NormalArgs(Params_AttachDevice args);

        public delegate void CheckPlatformSupport_BeforeArgs(Params_CheckPlatformSupport args);

        public delegate bool CheckPlatformSupport_NormalArgs(Params_CheckPlatformSupport args);

        public delegate void Destroy_BeforeArgs(Params_Destroy args);

        public delegate void Destroy_NormalArgs(Params_Destroy args);

        public delegate void DetachDevice_BeforeArgs(Params_DetachDevice args);

        public delegate void DetachDevice_NormalArgs(Params_DetachDevice args);

        public delegate void DetectDevice_BeforeArgs(Params_DetectDevice args);

        public delegate void DetectDevice_NormalArgs(Params_DetectDevice args);

        public delegate void Enable_BeforeArgs();

        public delegate bool Enable_NormalArgs();

        public delegate void FindAttachedDevice_BeforeArgs(Params_FindAttachedDevice args);

        public delegate NativeInputDevice FindAttachedDevice_NormalArgs(Params_FindAttachedDevice args);

        public delegate void FindDetachedDevice_BeforeArgs(Params_FindDetachedDevice args);

        public delegate NativeInputDevice FindDetachedDevice_NormalArgs(Params_FindDetachedDevice args);

        public delegate void SystemFindDetachedDevice_BeforeArgs(Params_SystemFindDetachedDevice args);

        public delegate NativeInputDevice SystemFindDetachedDevice_NormalArgs(Params_SystemFindDetachedDevice args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Destroy
        {
            public NativeInputDeviceManager self;
        }

        public sealed class Params_Update
        {
            public float deltaTime;
            public NativeInputDeviceManager self;
            public ulong updateTick;
        }

        public sealed class Params_DetectDevice
        {
            public uint deviceHandle;
            public InputDeviceInfo deviceInfo;
            public NativeInputDeviceManager self;
        }

        public sealed class Params_AttachDevice
        {
            public NativeInputDevice device;
            public NativeInputDeviceManager self;
        }

        public sealed class Params_DetachDevice
        {
            public NativeInputDevice device;
            public NativeInputDeviceManager self;
        }

        public sealed class Params_FindAttachedDevice
        {
            public uint deviceHandle;
            public NativeInputDeviceManager self;
        }

        public sealed class Params_FindDetachedDevice
        {
            public InputDeviceInfo deviceInfo;
            public NativeInputDeviceManager self;
        }

        public sealed class Params_SystemFindDetachedDevice
        {
            public ReadOnlyCollection<NativeInputDevice> detachedDevices;
            public InputDeviceInfo deviceInfo;
        }

        public sealed class Params_AddSystemDeviceProfile
        {
            public InputDeviceProfile deviceProfile;
            public NativeInputDeviceManager self;
        }

        public sealed class Params_AddSystemDeviceProfiles
        {
            public NativeInputDeviceManager self;
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
        public static event Delegates.Destroy_BeforeArgs Destroy
        {
            add
            {
                HookHandler._beforeDestroy += value;
                HookHandler.HookDestroy();
            }
            remove => HookHandler._beforeDestroy -= value;
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

        public static event Delegates.DetectDevice_BeforeArgs DetectDevice
        {
            add
            {
                HookHandler._beforeDetectDevice += value;
                HookHandler.HookDetectDevice();
            }
            remove => HookHandler._beforeDetectDevice -= value;
        }

        public static event Delegates.AttachDevice_BeforeArgs AttachDevice
        {
            add
            {
                HookHandler._beforeAttachDevice += value;
                HookHandler.HookAttachDevice();
            }
            remove => HookHandler._beforeAttachDevice -= value;
        }

        public static event Delegates.DetachDevice_BeforeArgs DetachDevice
        {
            add
            {
                HookHandler._beforeDetachDevice += value;
                HookHandler.HookDetachDevice();
            }
            remove => HookHandler._beforeDetachDevice -= value;
        }

        public static event Delegates.FindAttachedDevice_BeforeArgs FindAttachedDevice
        {
            add
            {
                HookHandler._beforeFindAttachedDevice += value;
                HookHandler.HookFindAttachedDevice();
            }
            remove => HookHandler._beforeFindAttachedDevice -= value;
        }

        public static event Delegates.FindDetachedDevice_BeforeArgs FindDetachedDevice
        {
            add
            {
                HookHandler._beforeFindDetachedDevice += value;
                HookHandler.HookFindDetachedDevice();
            }
            remove => HookHandler._beforeFindDetachedDevice -= value;
        }

        public static event Delegates.SystemFindDetachedDevice_BeforeArgs SystemFindDetachedDevice
        {
            add
            {
                HookHandler._beforeSystemFindDetachedDevice += value;
                HookHandler.HookSystemFindDetachedDevice();
            }
            remove => HookHandler._beforeSystemFindDetachedDevice -= value;
        }

        public static event Delegates.AddSystemDeviceProfile_BeforeArgs AddSystemDeviceProfile
        {
            add
            {
                HookHandler._beforeAddSystemDeviceProfile += value;
                HookHandler.HookAddSystemDeviceProfile();
            }
            remove => HookHandler._beforeAddSystemDeviceProfile -= value;
        }

        public static event Delegates.AddSystemDeviceProfiles_BeforeArgs AddSystemDeviceProfiles
        {
            add
            {
                HookHandler._beforeAddSystemDeviceProfiles += value;
                HookHandler.HookAddSystemDeviceProfiles();
            }
            remove => HookHandler._beforeAddSystemDeviceProfiles -= value;
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
        public static event Delegates.Destroy_NormalArgs Destroy
        {
            add
            {
                HookHandler._afterDestroy += value;
                HookHandler.HookDestroy();
            }
            remove => HookHandler._afterDestroy -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.DetectDevice_NormalArgs DetectDevice
        {
            add
            {
                HookHandler._afterDetectDevice += value;
                HookHandler.HookDetectDevice();
            }
            remove => HookHandler._afterDetectDevice -= value;
        }

        public static event Delegates.AttachDevice_NormalArgs AttachDevice
        {
            add
            {
                HookHandler._afterAttachDevice += value;
                HookHandler.HookAttachDevice();
            }
            remove => HookHandler._afterAttachDevice -= value;
        }

        public static event Delegates.DetachDevice_NormalArgs DetachDevice
        {
            add
            {
                HookHandler._afterDetachDevice += value;
                HookHandler.HookDetachDevice();
            }
            remove => HookHandler._afterDetachDevice -= value;
        }

        public static event Delegates.FindAttachedDevice_NormalArgs FindAttachedDevice
        {
            add
            {
                HookHandler._afterFindAttachedDevice += value;
                HookHandler.HookFindAttachedDevice();
            }
            remove => HookHandler._afterFindAttachedDevice -= value;
        }

        public static event Delegates.FindDetachedDevice_NormalArgs FindDetachedDevice
        {
            add
            {
                HookHandler._afterFindDetachedDevice += value;
                HookHandler.HookFindDetachedDevice();
            }
            remove => HookHandler._afterFindDetachedDevice -= value;
        }

        public static event Delegates.SystemFindDetachedDevice_NormalArgs SystemFindDetachedDevice
        {
            add
            {
                HookHandler._afterSystemFindDetachedDevice += value;
                HookHandler.HookSystemFindDetachedDevice();
            }
            remove => HookHandler._afterSystemFindDetachedDevice -= value;
        }

        public static event Delegates.AddSystemDeviceProfile_NormalArgs AddSystemDeviceProfile
        {
            add
            {
                HookHandler._afterAddSystemDeviceProfile += value;
                HookHandler.HookAddSystemDeviceProfile();
            }
            remove => HookHandler._afterAddSystemDeviceProfile -= value;
        }

        public static event Delegates.AddSystemDeviceProfiles_NormalArgs AddSystemDeviceProfiles
        {
            add
            {
                HookHandler._afterAddSystemDeviceProfiles += value;
                HookHandler.HookAddSystemDeviceProfiles();
            }
            remove => HookHandler._afterAddSystemDeviceProfiles -= value;
        }

        public static event Delegates.CheckPlatformSupport_NormalArgs CheckPlatformSupport
        {
            add
            {
                HookHandler._afterCheckPlatformSupport += value;
                HookHandler.HookCheckPlatformSupport();
            }
            remove => HookHandler._afterCheckPlatformSupport -= value;
        }

        public static event Delegates.Enable_NormalArgs Enable
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
        public static event Delegates.Destroy_NormalArgs Destroy
        {
            add => HookEndpointManager.Add<Delegates.Destroy_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Destroy"), value);
            remove => HookEndpointManager.Remove<Delegates.Destroy_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Destroy"), value);
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Update"), value);
        }

        public static event Delegates.DetectDevice_NormalArgs DetectDevice
        {
            add => HookEndpointManager.Add<Delegates.DetectDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetectDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.DetectDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetectDevice"), value);
        }

        public static event Delegates.AttachDevice_NormalArgs AttachDevice
        {
            add => HookEndpointManager.Add<Delegates.AttachDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AttachDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.AttachDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AttachDevice"), value);
        }

        public static event Delegates.DetachDevice_NormalArgs DetachDevice
        {
            add => HookEndpointManager.Add<Delegates.DetachDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetachDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.DetachDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetachDevice"), value);
        }

        public static event Delegates.FindAttachedDevice_NormalArgs FindAttachedDevice
        {
            add => HookEndpointManager.Add<Delegates.FindAttachedDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindAttachedDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.FindAttachedDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindAttachedDevice"), value);
        }

        public static event Delegates.FindDetachedDevice_NormalArgs FindDetachedDevice
        {
            add => HookEndpointManager.Add<Delegates.FindDetachedDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindDetachedDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.FindDetachedDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindDetachedDevice"), value);
        }

        public static event Delegates.SystemFindDetachedDevice_NormalArgs SystemFindDetachedDevice
        {
            add => HookEndpointManager.Add<Delegates.SystemFindDetachedDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "SystemFindDetachedDevice", false),
                value);
            remove => HookEndpointManager.Remove<Delegates.SystemFindDetachedDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "SystemFindDetachedDevice", false),
                value);
        }

        public static event Delegates.AddSystemDeviceProfile_NormalArgs AddSystemDeviceProfile
        {
            add => HookEndpointManager.Add<Delegates.AddSystemDeviceProfile_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfile"), value);
            remove => HookEndpointManager.Remove<Delegates.AddSystemDeviceProfile_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfile"), value);
        }

        public static event Delegates.AddSystemDeviceProfiles_NormalArgs AddSystemDeviceProfiles
        {
            add => HookEndpointManager.Add<Delegates.AddSystemDeviceProfiles_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfiles"), value);
            remove => HookEndpointManager.Remove<Delegates.AddSystemDeviceProfiles_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfiles"), value);
        }

        public static event Delegates.CheckPlatformSupport_NormalArgs CheckPlatformSupport
        {
            add => HookEndpointManager.Add<Delegates.CheckPlatformSupport_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "CheckPlatformSupport", false), value);
            remove => HookEndpointManager.Remove<Delegates.CheckPlatformSupport_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "CheckPlatformSupport", false), value);
        }

        public static event Delegates.Enable_NormalArgs Enable
        {
            add => HookEndpointManager.Add<Delegates.Enable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Enable", false), value);
            remove => HookEndpointManager.Remove<Delegates.Enable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Enable", false), value);
        }
    }
}