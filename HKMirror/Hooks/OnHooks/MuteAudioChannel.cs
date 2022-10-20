using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MuteAudioChannel class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMuteAudioChannel
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Volume()
        {
            if (!HookedList.Contains("get_Volume"))
            {
                HookedList.Add("get_Volume");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "get_Volume"), get_Volume);
            }
        }

        internal static event Delegates.get_Volume_BeforeArgs _beforeget_Volume;
        internal static event Delegates.get_Volume_NormalArgs _afterget_Volume;

        private static float get_Volume(Func<MuteAudioChannel, float> orig, MuteAudioChannel self)
        {
            Delegates.Params_get_Volume @params = new()
            {
                self = self
            };
            _beforeget_Volume?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Volume != null) retVal = _afterget_Volume.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_Volume()
        {
            if (!HookedList.Contains("set_Volume"))
            {
                HookedList.Add("set_Volume");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "set_Volume"), set_Volume);
            }
        }

        internal static event Delegates.set_Volume_BeforeArgs _beforeset_Volume;
        internal static event Delegates.set_Volume_NormalArgs _afterset_Volume;

        private static void set_Volume(Action<MuteAudioChannel, float> orig, MuteAudioChannel self, float value)
        {
            Delegates.Params_set_Volume @params = new()
            {
                self = self, value = value
            };
            _beforeset_Volume?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Volume != null) _afterset_Volume.Invoke(@params);
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.MuteAudioChannel.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(On.MuteAudioChannel.orig_OnEnable orig, MuteAudioChannel self)
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
                On.MuteAudioChannel.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.MuteAudioChannel.orig_OnDisable orig, MuteAudioChannel self)
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

        internal static void HookLinearToDecibel()
        {
            if (!HookedList.Contains("LinearToDecibel"))
            {
                HookedList.Add("LinearToDecibel");
                On.MuteAudioChannel.LinearToDecibel += LinearToDecibel;
            }
        }

        internal static event Delegates.LinearToDecibel_BeforeArgs _beforeLinearToDecibel;
        internal static event Delegates.LinearToDecibel_NormalArgs _afterLinearToDecibel;

        private static float LinearToDecibel(On.MuteAudioChannel.orig_LinearToDecibel orig, MuteAudioChannel self,
            float linear)
        {
            Delegates.Params_LinearToDecibel @params = new()
            {
                self = self, linear = linear
            };
            _beforeLinearToDecibel?.Invoke(@params);
            self = @params.self;
            linear = @params.linear;
            var retVal = orig(self, linear);
            if (_afterLinearToDecibel != null) retVal = _afterLinearToDecibel.Invoke(@params);
            return retVal;
        }

        internal static void HookDecibelToLinear()
        {
            if (!HookedList.Contains("DecibelToLinear"))
            {
                HookedList.Add("DecibelToLinear");
                On.MuteAudioChannel.DecibelToLinear += DecibelToLinear;
            }
        }

        internal static event Delegates.DecibelToLinear_BeforeArgs _beforeDecibelToLinear;
        internal static event Delegates.DecibelToLinear_NormalArgs _afterDecibelToLinear;

        private static float DecibelToLinear(On.MuteAudioChannel.orig_DecibelToLinear orig, MuteAudioChannel self,
            float dB)
        {
            Delegates.Params_DecibelToLinear @params = new()
            {
                self = self, dB = dB
            };
            _beforeDecibelToLinear?.Invoke(@params);
            self = @params.self;
            dB = @params.dB;
            var retVal = orig(self, dB);
            if (_afterDecibelToLinear != null) retVal = _afterDecibelToLinear.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DecibelToLinear_BeforeArgs(Params_DecibelToLinear args);

        public delegate float DecibelToLinear_NormalArgs(Params_DecibelToLinear args);

        public delegate void get_Volume_BeforeArgs(Params_get_Volume args);

        public delegate float get_Volume_NormalArgs(Params_get_Volume args);

        public delegate void LinearToDecibel_BeforeArgs(Params_LinearToDecibel args);

        public delegate float LinearToDecibel_NormalArgs(Params_LinearToDecibel args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void set_Volume_BeforeArgs(Params_set_Volume args);

        public delegate void set_Volume_NormalArgs(Params_set_Volume args);

        public sealed class Params_get_Volume
        {
            public MuteAudioChannel self;
        }

        public sealed class Params_set_Volume
        {
            public MuteAudioChannel self;
            public float value;
        }

        public sealed class Params_OnEnable
        {
            public MuteAudioChannel self;
        }

        public sealed class Params_OnDisable
        {
            public MuteAudioChannel self;
        }

        public sealed class Params_LinearToDecibel
        {
            public float linear;
            public MuteAudioChannel self;
        }

        public sealed class Params_DecibelToLinear
        {
            public float dB;
            public MuteAudioChannel self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Volume_BeforeArgs get_Volume
        {
            add
            {
                HookHandler._beforeget_Volume += value;
                HookHandler.Hookget_Volume();
            }
            remove => HookHandler._beforeget_Volume -= value;
        }

        public static event Delegates.set_Volume_BeforeArgs set_Volume
        {
            add
            {
                HookHandler._beforeset_Volume += value;
                HookHandler.Hookset_Volume();
            }
            remove => HookHandler._beforeset_Volume -= value;
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

        public static event Delegates.LinearToDecibel_BeforeArgs LinearToDecibel
        {
            add
            {
                HookHandler._beforeLinearToDecibel += value;
                HookHandler.HookLinearToDecibel();
            }
            remove => HookHandler._beforeLinearToDecibel -= value;
        }

        public static event Delegates.DecibelToLinear_BeforeArgs DecibelToLinear
        {
            add
            {
                HookHandler._beforeDecibelToLinear += value;
                HookHandler.HookDecibelToLinear();
            }
            remove => HookHandler._beforeDecibelToLinear -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Volume_NormalArgs get_Volume
        {
            add
            {
                HookHandler._afterget_Volume += value;
                HookHandler.Hookget_Volume();
            }
            remove => HookHandler._afterget_Volume -= value;
        }

        public static event Delegates.set_Volume_NormalArgs set_Volume
        {
            add
            {
                HookHandler._afterset_Volume += value;
                HookHandler.Hookset_Volume();
            }
            remove => HookHandler._afterset_Volume -= value;
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

        public static event Delegates.LinearToDecibel_NormalArgs LinearToDecibel
        {
            add
            {
                HookHandler._afterLinearToDecibel += value;
                HookHandler.HookLinearToDecibel();
            }
            remove => HookHandler._afterLinearToDecibel -= value;
        }

        public static event Delegates.DecibelToLinear_NormalArgs DecibelToLinear
        {
            add
            {
                HookHandler._afterDecibelToLinear += value;
                HookHandler.HookDecibelToLinear();
            }
            remove => HookHandler._afterDecibelToLinear -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Volume_NormalArgs get_Volume
        {
            add => HookEndpointManager.Add<Delegates.get_Volume_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "get_Volume"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Volume_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "get_Volume"), value);
        }

        public static event Delegates.set_Volume_NormalArgs set_Volume
        {
            add => HookEndpointManager.Add<Delegates.set_Volume_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "set_Volume"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Volume_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "set_Volume"), value);
        }

        public static event On.MuteAudioChannel.hook_OnEnable OnEnable
        {
            add => On.MuteAudioChannel.OnEnable += value;
            remove => On.MuteAudioChannel.OnEnable -= value;
        }

        public static event On.MuteAudioChannel.hook_OnDisable OnDisable
        {
            add => On.MuteAudioChannel.OnDisable += value;
            remove => On.MuteAudioChannel.OnDisable -= value;
        }

        public static event On.MuteAudioChannel.hook_LinearToDecibel LinearToDecibel
        {
            add => On.MuteAudioChannel.LinearToDecibel += value;
            remove => On.MuteAudioChannel.LinearToDecibel -= value;
        }

        public static event On.MuteAudioChannel.hook_DecibelToLinear DecibelToLinear
        {
            add => On.MuteAudioChannel.DecibelToLinear += value;
            remove => On.MuteAudioChannel.DecibelToLinear -= value;
        }
    }
}