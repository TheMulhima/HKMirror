using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for UnityInputDeviceManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnUnityInputDeviceManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(Action<UnityInputDeviceManager, ulong, float> orig, UnityInputDeviceManager self,
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

        internal static void HookQueryJoystickInfo()
        {
            if (!HookedList.Contains("QueryJoystickInfo"))
            {
                HookedList.Add("QueryJoystickInfo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "QueryJoystickInfo"),
                    QueryJoystickInfo);
            }
        }

        internal static event Delegates.QueryJoystickInfo_BeforeArgs _beforeQueryJoystickInfo;
        internal static event Delegates.QueryJoystickInfo_NormalArgs _afterQueryJoystickInfo;

        private static void QueryJoystickInfo(Action<UnityInputDeviceManager> orig, UnityInputDeviceManager self)
        {
            Delegates.Params_QueryJoystickInfo @params = new()
            {
                self = self
            };
            _beforeQueryJoystickInfo?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterQueryJoystickInfo != null) _afterQueryJoystickInfo.Invoke(@params);
        }

        internal static void Hookget_JoystickInfoHasChanged()
        {
            if (!HookedList.Contains("get_JoystickInfoHasChanged"))
            {
                HookedList.Add("get_JoystickInfoHasChanged");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "get_JoystickInfoHasChanged"),
                    get_JoystickInfoHasChanged);
            }
        }

        internal static event Delegates.get_JoystickInfoHasChanged_BeforeArgs _beforeget_JoystickInfoHasChanged;
        internal static event Delegates.get_JoystickInfoHasChanged_NormalArgs _afterget_JoystickInfoHasChanged;

        private static bool get_JoystickInfoHasChanged(Func<UnityInputDeviceManager, bool> orig,
            UnityInputDeviceManager self)
        {
            Delegates.Params_get_JoystickInfoHasChanged @params = new()
            {
                self = self
            };
            _beforeget_JoystickInfoHasChanged?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_JoystickInfoHasChanged != null) retVal = _afterget_JoystickInfoHasChanged.Invoke(@params);
            return retVal;
        }

        internal static void HookAttachDevices()
        {
            if (!HookedList.Contains("AttachDevices"))
            {
                HookedList.Add("AttachDevices");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevices"),
                    AttachDevices);
            }
        }

        internal static event Delegates.AttachDevices_BeforeArgs _beforeAttachDevices;
        internal static event Delegates.AttachDevices_NormalArgs _afterAttachDevices;

        private static void AttachDevices(Action<UnityInputDeviceManager> orig, UnityInputDeviceManager self)
        {
            Delegates.Params_AttachDevices @params = new()
            {
                self = self
            };
            _beforeAttachDevices?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAttachDevices != null) _afterAttachDevices.Invoke(@params);
        }

        internal static void HookDetachDevices()
        {
            if (!HookedList.Contains("DetachDevices"))
            {
                HookedList.Add("DetachDevices");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetachDevices"),
                    DetachDevices);
            }
        }

        internal static event Delegates.DetachDevices_BeforeArgs _beforeDetachDevices;
        internal static event Delegates.DetachDevices_NormalArgs _afterDetachDevices;

        private static void DetachDevices(Action<UnityInputDeviceManager> orig, UnityInputDeviceManager self)
        {
            Delegates.Params_DetachDevices @params = new()
            {
                self = self
            };
            _beforeDetachDevices?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDetachDevices != null) _afterDetachDevices.Invoke(@params);
        }

        internal static void HookReloadDevices()
        {
            if (!HookedList.Contains("ReloadDevices"))
            {
                HookedList.Add("ReloadDevices");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "ReloadDevices"),
                    ReloadDevices);
            }
        }

        internal static event Delegates.ReloadDevices_BeforeArgs _beforeReloadDevices;
        internal static event Delegates.ReloadDevices_NormalArgs _afterReloadDevices;

        private static void ReloadDevices(Action<UnityInputDeviceManager> orig, UnityInputDeviceManager self)
        {
            Delegates.Params_ReloadDevices @params = new()
            {
                self = self
            };
            _beforeReloadDevices?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReloadDevices != null) _afterReloadDevices.Invoke(@params);
        }

        internal static void HookAttachDevice()
        {
            if (!HookedList.Contains("AttachDevice"))
            {
                HookedList.Add("AttachDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevice"), AttachDevice);
            }
        }

        internal static event Delegates.AttachDevice_BeforeArgs _beforeAttachDevice;
        internal static event Delegates.AttachDevice_NormalArgs _afterAttachDevice;

        private static void AttachDevice(Action<UnityInputDeviceManager, UnityInputDevice> orig,
            UnityInputDeviceManager self, UnityInputDevice device)
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

        internal static void HookHasAttachedDeviceWithJoystickId()
        {
            if (!HookedList.Contains("HasAttachedDeviceWithJoystickId"))
            {
                HookedList.Add("HasAttachedDeviceWithJoystickId");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "HasAttachedDeviceWithJoystickId"),
                    HasAttachedDeviceWithJoystickId);
            }
        }

        internal static event Delegates.HasAttachedDeviceWithJoystickId_BeforeArgs
            _beforeHasAttachedDeviceWithJoystickId;

        internal static event Delegates.HasAttachedDeviceWithJoystickId_NormalArgs
            _afterHasAttachedDeviceWithJoystickId;

        private static bool HasAttachedDeviceWithJoystickId(Func<UnityInputDeviceManager, int, bool> orig,
            UnityInputDeviceManager self, int unityJoystickId)
        {
            Delegates.Params_HasAttachedDeviceWithJoystickId @params = new()
            {
                self = self, unityJoystickId = unityJoystickId
            };
            _beforeHasAttachedDeviceWithJoystickId?.Invoke(@params);
            self = @params.self;
            unityJoystickId = @params.unityJoystickId;
            var retVal = orig(self, unityJoystickId);
            if (_afterHasAttachedDeviceWithJoystickId != null)
                retVal = _afterHasAttachedDeviceWithJoystickId.Invoke(@params);
            return retVal;
        }

        internal static void HookDetectJoystickDevice()
        {
            if (!HookedList.Contains("DetectJoystickDevice"))
            {
                HookedList.Add("DetectJoystickDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectJoystickDevice"),
                    DetectJoystickDevice);
            }
        }

        internal static event Delegates.DetectJoystickDevice_BeforeArgs _beforeDetectJoystickDevice;
        internal static event Delegates.DetectJoystickDevice_NormalArgs _afterDetectJoystickDevice;

        private static void DetectJoystickDevice(Action<UnityInputDeviceManager, int, string> orig,
            UnityInputDeviceManager self, int unityJoystickId, string unityJoystickName)
        {
            Delegates.Params_DetectJoystickDevice @params = new()
            {
                self = self, unityJoystickId = unityJoystickId, unityJoystickName = unityJoystickName
            };
            _beforeDetectJoystickDevice?.Invoke(@params);
            self = @params.self;
            unityJoystickId = @params.unityJoystickId;
            unityJoystickName = @params.unityJoystickName;
            orig(self, unityJoystickId, unityJoystickName);
            if (_afterDetectJoystickDevice != null) _afterDetectJoystickDevice.Invoke(@params);
        }

        internal static void HookDetectDevice()
        {
            if (!HookedList.Contains("DetectDevice"))
            {
                HookedList.Add("DetectDevice");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectDevice"), DetectDevice);
            }
        }

        internal static event Delegates.DetectDevice_BeforeArgs _beforeDetectDevice;
        internal static event Delegates.DetectDevice_NormalArgs _afterDetectDevice;

        private static InputDeviceProfile DetectDevice(Func<UnityInputDeviceManager, string, InputDeviceProfile> orig,
            UnityInputDeviceManager self, string unityJoystickName)
        {
            Delegates.Params_DetectDevice @params = new()
            {
                self = self, unityJoystickName = unityJoystickName
            };
            _beforeDetectDevice?.Invoke(@params);
            self = @params.self;
            unityJoystickName = @params.unityJoystickName;
            var retVal = orig(self, unityJoystickName);
            if (_afterDetectDevice != null) retVal = _afterDetectDevice.Invoke(@params);
            return retVal;
        }

        internal static void HookAddSystemDeviceProfile()
        {
            if (!HookedList.Contains("AddSystemDeviceProfile"))
            {
                HookedList.Add("AddSystemDeviceProfile");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfile"),
                    AddSystemDeviceProfile);
            }
        }

        internal static event Delegates.AddSystemDeviceProfile_BeforeArgs _beforeAddSystemDeviceProfile;
        internal static event Delegates.AddSystemDeviceProfile_NormalArgs _afterAddSystemDeviceProfile;

        private static void AddSystemDeviceProfile(Action<UnityInputDeviceManager, InputDeviceProfile> orig,
            UnityInputDeviceManager self, InputDeviceProfile deviceProfile)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfiles"),
                    AddSystemDeviceProfiles);
            }
        }

        internal static event Delegates.AddSystemDeviceProfiles_BeforeArgs _beforeAddSystemDeviceProfiles;
        internal static event Delegates.AddSystemDeviceProfiles_NormalArgs _afterAddSystemDeviceProfiles;

        private static void AddSystemDeviceProfiles(Action<UnityInputDeviceManager> orig, UnityInputDeviceManager self)
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

        public delegate void AttachDevices_BeforeArgs(Params_AttachDevices args);

        public delegate void AttachDevices_NormalArgs(Params_AttachDevices args);

        public delegate void DetachDevices_BeforeArgs(Params_DetachDevices args);

        public delegate void DetachDevices_NormalArgs(Params_DetachDevices args);

        public delegate void DetectDevice_BeforeArgs(Params_DetectDevice args);

        public delegate InputDeviceProfile DetectDevice_NormalArgs(Params_DetectDevice args);

        public delegate void DetectJoystickDevice_BeforeArgs(Params_DetectJoystickDevice args);

        public delegate void DetectJoystickDevice_NormalArgs(Params_DetectJoystickDevice args);

        public delegate void get_JoystickInfoHasChanged_BeforeArgs(Params_get_JoystickInfoHasChanged args);

        public delegate bool get_JoystickInfoHasChanged_NormalArgs(Params_get_JoystickInfoHasChanged args);

        public delegate void HasAttachedDeviceWithJoystickId_BeforeArgs(Params_HasAttachedDeviceWithJoystickId args);

        public delegate bool HasAttachedDeviceWithJoystickId_NormalArgs(Params_HasAttachedDeviceWithJoystickId args);

        public delegate void QueryJoystickInfo_BeforeArgs(Params_QueryJoystickInfo args);

        public delegate void QueryJoystickInfo_NormalArgs(Params_QueryJoystickInfo args);

        public delegate void ReloadDevices_BeforeArgs(Params_ReloadDevices args);

        public delegate void ReloadDevices_NormalArgs(Params_ReloadDevices args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Update
        {
            public float deltaTime;
            public UnityInputDeviceManager self;
            public ulong updateTick;
        }

        public sealed class Params_QueryJoystickInfo
        {
            public UnityInputDeviceManager self;
        }

        public sealed class Params_get_JoystickInfoHasChanged
        {
            public UnityInputDeviceManager self;
        }

        public sealed class Params_AttachDevices
        {
            public UnityInputDeviceManager self;
        }

        public sealed class Params_DetachDevices
        {
            public UnityInputDeviceManager self;
        }

        public sealed class Params_ReloadDevices
        {
            public UnityInputDeviceManager self;
        }

        public sealed class Params_AttachDevice
        {
            public UnityInputDevice device;
            public UnityInputDeviceManager self;
        }

        public sealed class Params_HasAttachedDeviceWithJoystickId
        {
            public UnityInputDeviceManager self;
            public int unityJoystickId;
        }

        public sealed class Params_DetectJoystickDevice
        {
            public UnityInputDeviceManager self;
            public int unityJoystickId;
            public string unityJoystickName;
        }

        public sealed class Params_DetectDevice
        {
            public UnityInputDeviceManager self;
            public string unityJoystickName;
        }

        public sealed class Params_AddSystemDeviceProfile
        {
            public InputDeviceProfile deviceProfile;
            public UnityInputDeviceManager self;
        }

        public sealed class Params_AddSystemDeviceProfiles
        {
            public UnityInputDeviceManager self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.QueryJoystickInfo_BeforeArgs QueryJoystickInfo
        {
            add
            {
                HookHandler._beforeQueryJoystickInfo += value;
                HookHandler.HookQueryJoystickInfo();
            }
            remove => HookHandler._beforeQueryJoystickInfo -= value;
        }

        public static event Delegates.get_JoystickInfoHasChanged_BeforeArgs get_JoystickInfoHasChanged
        {
            add
            {
                HookHandler._beforeget_JoystickInfoHasChanged += value;
                HookHandler.Hookget_JoystickInfoHasChanged();
            }
            remove => HookHandler._beforeget_JoystickInfoHasChanged -= value;
        }

        public static event Delegates.AttachDevices_BeforeArgs AttachDevices
        {
            add
            {
                HookHandler._beforeAttachDevices += value;
                HookHandler.HookAttachDevices();
            }
            remove => HookHandler._beforeAttachDevices -= value;
        }

        public static event Delegates.DetachDevices_BeforeArgs DetachDevices
        {
            add
            {
                HookHandler._beforeDetachDevices += value;
                HookHandler.HookDetachDevices();
            }
            remove => HookHandler._beforeDetachDevices -= value;
        }

        public static event Delegates.ReloadDevices_BeforeArgs ReloadDevices
        {
            add
            {
                HookHandler._beforeReloadDevices += value;
                HookHandler.HookReloadDevices();
            }
            remove => HookHandler._beforeReloadDevices -= value;
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

        public static event Delegates.HasAttachedDeviceWithJoystickId_BeforeArgs HasAttachedDeviceWithJoystickId
        {
            add
            {
                HookHandler._beforeHasAttachedDeviceWithJoystickId += value;
                HookHandler.HookHasAttachedDeviceWithJoystickId();
            }
            remove => HookHandler._beforeHasAttachedDeviceWithJoystickId -= value;
        }

        public static event Delegates.DetectJoystickDevice_BeforeArgs DetectJoystickDevice
        {
            add
            {
                HookHandler._beforeDetectJoystickDevice += value;
                HookHandler.HookDetectJoystickDevice();
            }
            remove => HookHandler._beforeDetectJoystickDevice -= value;
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
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.QueryJoystickInfo_NormalArgs QueryJoystickInfo
        {
            add
            {
                HookHandler._afterQueryJoystickInfo += value;
                HookHandler.HookQueryJoystickInfo();
            }
            remove => HookHandler._afterQueryJoystickInfo -= value;
        }

        public static event Delegates.get_JoystickInfoHasChanged_NormalArgs get_JoystickInfoHasChanged
        {
            add
            {
                HookHandler._afterget_JoystickInfoHasChanged += value;
                HookHandler.Hookget_JoystickInfoHasChanged();
            }
            remove => HookHandler._afterget_JoystickInfoHasChanged -= value;
        }

        public static event Delegates.AttachDevices_NormalArgs AttachDevices
        {
            add
            {
                HookHandler._afterAttachDevices += value;
                HookHandler.HookAttachDevices();
            }
            remove => HookHandler._afterAttachDevices -= value;
        }

        public static event Delegates.DetachDevices_NormalArgs DetachDevices
        {
            add
            {
                HookHandler._afterDetachDevices += value;
                HookHandler.HookDetachDevices();
            }
            remove => HookHandler._afterDetachDevices -= value;
        }

        public static event Delegates.ReloadDevices_NormalArgs ReloadDevices
        {
            add
            {
                HookHandler._afterReloadDevices += value;
                HookHandler.HookReloadDevices();
            }
            remove => HookHandler._afterReloadDevices -= value;
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

        public static event Delegates.HasAttachedDeviceWithJoystickId_NormalArgs HasAttachedDeviceWithJoystickId
        {
            add
            {
                HookHandler._afterHasAttachedDeviceWithJoystickId += value;
                HookHandler.HookHasAttachedDeviceWithJoystickId();
            }
            remove => HookHandler._afterHasAttachedDeviceWithJoystickId -= value;
        }

        public static event Delegates.DetectJoystickDevice_NormalArgs DetectJoystickDevice
        {
            add
            {
                HookHandler._afterDetectJoystickDevice += value;
                HookHandler.HookDetectJoystickDevice();
            }
            remove => HookHandler._afterDetectJoystickDevice -= value;
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Update_NormalArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "Update"), value);
        }

        public static event Delegates.QueryJoystickInfo_NormalArgs QueryJoystickInfo
        {
            add => HookEndpointManager.Add<Delegates.QueryJoystickInfo_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "QueryJoystickInfo"), value);
            remove => HookEndpointManager.Remove<Delegates.QueryJoystickInfo_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "QueryJoystickInfo"), value);
        }

        public static event Delegates.get_JoystickInfoHasChanged_NormalArgs get_JoystickInfoHasChanged
        {
            add => HookEndpointManager.Add<Delegates.get_JoystickInfoHasChanged_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "get_JoystickInfoHasChanged"), value);
            remove => HookEndpointManager.Remove<Delegates.get_JoystickInfoHasChanged_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "get_JoystickInfoHasChanged"), value);
        }

        public static event Delegates.AttachDevices_NormalArgs AttachDevices
        {
            add => HookEndpointManager.Add<Delegates.AttachDevices_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevices"), value);
            remove => HookEndpointManager.Remove<Delegates.AttachDevices_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevices"), value);
        }

        public static event Delegates.DetachDevices_NormalArgs DetachDevices
        {
            add => HookEndpointManager.Add<Delegates.DetachDevices_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetachDevices"), value);
            remove => HookEndpointManager.Remove<Delegates.DetachDevices_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetachDevices"), value);
        }

        public static event Delegates.ReloadDevices_NormalArgs ReloadDevices
        {
            add => HookEndpointManager.Add<Delegates.ReloadDevices_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "ReloadDevices"), value);
            remove => HookEndpointManager.Remove<Delegates.ReloadDevices_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "ReloadDevices"), value);
        }

        public static event Delegates.AttachDevice_NormalArgs AttachDevice
        {
            add => HookEndpointManager.Add<Delegates.AttachDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.AttachDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevice"), value);
        }

        public static event Delegates.HasAttachedDeviceWithJoystickId_NormalArgs HasAttachedDeviceWithJoystickId
        {
            add => HookEndpointManager.Add<Delegates.HasAttachedDeviceWithJoystickId_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "HasAttachedDeviceWithJoystickId"),
                value);
            remove => HookEndpointManager.Remove<Delegates.HasAttachedDeviceWithJoystickId_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "HasAttachedDeviceWithJoystickId"),
                value);
        }

        public static event Delegates.DetectJoystickDevice_NormalArgs DetectJoystickDevice
        {
            add => HookEndpointManager.Add<Delegates.DetectJoystickDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectJoystickDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.DetectJoystickDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectJoystickDevice"), value);
        }

        public static event Delegates.DetectDevice_NormalArgs DetectDevice
        {
            add => HookEndpointManager.Add<Delegates.DetectDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectDevice"), value);
            remove => HookEndpointManager.Remove<Delegates.DetectDevice_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectDevice"), value);
        }

        public static event Delegates.AddSystemDeviceProfile_NormalArgs AddSystemDeviceProfile
        {
            add => HookEndpointManager.Add<Delegates.AddSystemDeviceProfile_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfile"), value);
            remove => HookEndpointManager.Remove<Delegates.AddSystemDeviceProfile_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfile"), value);
        }

        public static event Delegates.AddSystemDeviceProfiles_NormalArgs AddSystemDeviceProfiles
        {
            add => HookEndpointManager.Add<Delegates.AddSystemDeviceProfiles_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfiles"), value);
            remove => HookEndpointManager.Remove<Delegates.AddSystemDeviceProfiles_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfiles"), value);
        }
    }
}