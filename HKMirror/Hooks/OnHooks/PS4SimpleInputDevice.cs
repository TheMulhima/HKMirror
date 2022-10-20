using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PS4SimpleInputDevice class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPS4SimpleInputDevice
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(Action<PS4SimpleInputDevice, ulong, float> orig, PS4SimpleInputDevice self,
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

        internal static void HookGetNativeVibrationValue()
        {
            if (!HookedList.Contains("GetNativeVibrationValue"))
            {
                HookedList.Add("GetNativeVibrationValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "GetNativeVibrationValue", false),
                    GetNativeVibrationValue);
            }
        }

        internal static event Delegates.GetNativeVibrationValue_BeforeArgs _beforeGetNativeVibrationValue;
        internal static event Delegates.GetNativeVibrationValue_NormalArgs _afterGetNativeVibrationValue;

        private static int GetNativeVibrationValue(Func<float, int> orig, float strength)
        {
            Delegates.Params_GetNativeVibrationValue @params = new()
            {
                strength = strength
            };
            _beforeGetNativeVibrationValue?.Invoke(@params);
            strength = @params.strength;
            var retVal = orig(strength);
            if (_afterGetNativeVibrationValue != null) retVal = _afterGetNativeVibrationValue.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_IsConnected()
        {
            if (!HookedList.Contains("get_IsConnected"))
            {
                HookedList.Add("get_IsConnected");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "get_IsConnected"),
                    get_IsConnected);
            }
        }

        internal static event Delegates.get_IsConnected_BeforeArgs _beforeget_IsConnected;
        internal static event Delegates.get_IsConnected_NormalArgs _afterget_IsConnected;

        private static bool get_IsConnected(Func<PS4SimpleInputDevice, bool> orig, PS4SimpleInputDevice self)
        {
            Delegates.Params_get_IsConnected @params = new()
            {
                self = self
            };
            _beforeget_IsConnected?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsConnected != null) retVal = _afterget_IsConnected.Invoke(@params);
            return retVal;
        }

        internal static void HookGetVibrationMixer()
        {
            if (!HookedList.Contains("GetVibrationMixer"))
            {
                HookedList.Add("GetVibrationMixer");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "GetVibrationMixer"),
                    GetVibrationMixer);
            }
        }

        internal static event Delegates.GetVibrationMixer_BeforeArgs _beforeGetVibrationMixer;
        internal static event Delegates.GetVibrationMixer_NormalArgs _afterGetVibrationMixer;

        private static VibrationMixer GetVibrationMixer(Func<PS4SimpleInputDevice, VibrationMixer> orig,
            PS4SimpleInputDevice self)
        {
            Delegates.Params_GetVibrationMixer @params = new()
            {
                self = self
            };
            _beforeGetVibrationMixer?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetVibrationMixer != null) retVal = _afterGetVibrationMixer.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_IsConnected_BeforeArgs(Params_get_IsConnected args);

        public delegate bool get_IsConnected_NormalArgs(Params_get_IsConnected args);

        public delegate void GetNativeVibrationValue_BeforeArgs(Params_GetNativeVibrationValue args);

        public delegate int GetNativeVibrationValue_NormalArgs(Params_GetNativeVibrationValue args);

        public delegate void GetVibrationMixer_BeforeArgs(Params_GetVibrationMixer args);

        public delegate VibrationMixer GetVibrationMixer_NormalArgs(Params_GetVibrationMixer args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Update
        {
            public float deltaTime;
            public PS4SimpleInputDevice self;
            public ulong updateTick;
        }

        public sealed class Params_GetNativeVibrationValue
        {
            public float strength;
        }

        public sealed class Params_get_IsConnected
        {
            public PS4SimpleInputDevice self;
        }

        public sealed class Params_GetVibrationMixer
        {
            public PS4SimpleInputDevice self;
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

        public static event Delegates.GetNativeVibrationValue_BeforeArgs GetNativeVibrationValue
        {
            add
            {
                HookHandler._beforeGetNativeVibrationValue += value;
                HookHandler.HookGetNativeVibrationValue();
            }
            remove => HookHandler._beforeGetNativeVibrationValue -= value;
        }

        public static event Delegates.get_IsConnected_BeforeArgs get_IsConnected
        {
            add
            {
                HookHandler._beforeget_IsConnected += value;
                HookHandler.Hookget_IsConnected();
            }
            remove => HookHandler._beforeget_IsConnected -= value;
        }

        public static event Delegates.GetVibrationMixer_BeforeArgs GetVibrationMixer
        {
            add
            {
                HookHandler._beforeGetVibrationMixer += value;
                HookHandler.HookGetVibrationMixer();
            }
            remove => HookHandler._beforeGetVibrationMixer -= value;
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

        public static event Delegates.GetNativeVibrationValue_NormalArgs GetNativeVibrationValue
        {
            add
            {
                HookHandler._afterGetNativeVibrationValue += value;
                HookHandler.HookGetNativeVibrationValue();
            }
            remove => HookHandler._afterGetNativeVibrationValue -= value;
        }

        public static event Delegates.get_IsConnected_NormalArgs get_IsConnected
        {
            add
            {
                HookHandler._afterget_IsConnected += value;
                HookHandler.Hookget_IsConnected();
            }
            remove => HookHandler._afterget_IsConnected -= value;
        }

        public static event Delegates.GetVibrationMixer_NormalArgs GetVibrationMixer
        {
            add
            {
                HookHandler._afterGetVibrationMixer += value;
                HookHandler.HookGetVibrationMixer();
            }
            remove => HookHandler._afterGetVibrationMixer -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "Update"), value);
        }

        public static event Delegates.GetNativeVibrationValue_NormalArgs GetNativeVibrationValue
        {
            add => HookEndpointManager.Add<Delegates.GetNativeVibrationValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "GetNativeVibrationValue", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetNativeVibrationValue_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "GetNativeVibrationValue", false), value);
        }

        public static event Delegates.get_IsConnected_NormalArgs get_IsConnected
        {
            add => HookEndpointManager.Add<Delegates.get_IsConnected_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "get_IsConnected"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsConnected_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "get_IsConnected"), value);
        }

        public static event Delegates.GetVibrationMixer_NormalArgs GetVibrationMixer
        {
            add => HookEndpointManager.Add<Delegates.GetVibrationMixer_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice),
                    "VibrationManager.IVibrationMixerProvider.GetVibrationMixer"), value);
            remove => HookEndpointManager.Remove<Delegates.GetVibrationMixer_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice),
                    "VibrationManager.IVibrationMixerProvider.GetVibrationMixer"), value);
        }
    }
}