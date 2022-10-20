namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PlatformVibrationHelper class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlatformVibrationHelper
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookDestroy()
        {
            if (!HookedList.Contains("Destroy"))
            {
                HookedList.Add("Destroy");
                On.PlatformVibrationHelper.Destroy += Destroy;
            }
        }

        internal static event Delegates.Destroy_BeforeArgs _beforeDestroy;
        internal static event Delegates.Destroy_NormalArgs _afterDestroy;

        private static void Destroy(On.PlatformVibrationHelper.orig_Destroy orig, PlatformVibrationHelper self)
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

        internal static void HookUpdateVibration()
        {
            if (!HookedList.Contains("UpdateVibration"))
            {
                HookedList.Add("UpdateVibration");
                On.PlatformVibrationHelper.UpdateVibration += UpdateVibration;
            }
        }

        internal static event Delegates.UpdateVibration_BeforeArgs _beforeUpdateVibration;
        internal static event Delegates.UpdateVibration_NormalArgs _afterUpdateVibration;

        private static void UpdateVibration(On.PlatformVibrationHelper.orig_UpdateVibration orig,
            PlatformVibrationHelper self)
        {
            Delegates.Params_UpdateVibration @params = new()
            {
                self = self
            };
            _beforeUpdateVibration?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdateVibration != null) _afterUpdateVibration.Invoke(@params);
        }

        internal static void HookGetMixer()
        {
            if (!HookedList.Contains("GetMixer"))
            {
                HookedList.Add("GetMixer");
                On.PlatformVibrationHelper.GetMixer += GetMixer;
            }
        }

        internal static event Delegates.GetMixer_BeforeArgs _beforeGetMixer;
        internal static event Delegates.GetMixer_NormalArgs _afterGetMixer;

        private static VibrationMixer GetMixer(On.PlatformVibrationHelper.orig_GetMixer orig,
            PlatformVibrationHelper self)
        {
            Delegates.Params_GetMixer @params = new()
            {
                self = self
            };
            _beforeGetMixer?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetMixer != null) retVal = _afterGetMixer.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Destroy_BeforeArgs(Params_Destroy args);

        public delegate void Destroy_NormalArgs(Params_Destroy args);

        public delegate void GetMixer_BeforeArgs(Params_GetMixer args);

        public delegate VibrationMixer GetMixer_NormalArgs(Params_GetMixer args);

        public delegate void UpdateVibration_BeforeArgs(Params_UpdateVibration args);

        public delegate void UpdateVibration_NormalArgs(Params_UpdateVibration args);

        public sealed class Params_Destroy
        {
            public PlatformVibrationHelper self;
        }

        public sealed class Params_UpdateVibration
        {
            public PlatformVibrationHelper self;
        }

        public sealed class Params_GetMixer
        {
            public PlatformVibrationHelper self;
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

        public static event Delegates.UpdateVibration_BeforeArgs UpdateVibration
        {
            add
            {
                HookHandler._beforeUpdateVibration += value;
                HookHandler.HookUpdateVibration();
            }
            remove => HookHandler._beforeUpdateVibration -= value;
        }

        public static event Delegates.GetMixer_BeforeArgs GetMixer
        {
            add
            {
                HookHandler._beforeGetMixer += value;
                HookHandler.HookGetMixer();
            }
            remove => HookHandler._beforeGetMixer -= value;
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

        public static event Delegates.UpdateVibration_NormalArgs UpdateVibration
        {
            add
            {
                HookHandler._afterUpdateVibration += value;
                HookHandler.HookUpdateVibration();
            }
            remove => HookHandler._afterUpdateVibration -= value;
        }

        public static event Delegates.GetMixer_NormalArgs GetMixer
        {
            add
            {
                HookHandler._afterGetMixer += value;
                HookHandler.HookGetMixer();
            }
            remove => HookHandler._afterGetMixer -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PlatformVibrationHelper.hook_Destroy Destroy
        {
            add => On.PlatformVibrationHelper.Destroy += value;
            remove => On.PlatformVibrationHelper.Destroy -= value;
        }

        public static event On.PlatformVibrationHelper.hook_UpdateVibration UpdateVibration
        {
            add => On.PlatformVibrationHelper.UpdateVibration += value;
            remove => On.PlatformVibrationHelper.UpdateVibration -= value;
        }

        public static event On.PlatformVibrationHelper.hook_GetMixer GetMixer
        {
            add => On.PlatformVibrationHelper.GetMixer += value;
            remove => On.PlatformVibrationHelper.GetMixer -= value;
        }
    }
}