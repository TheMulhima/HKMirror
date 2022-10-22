using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GamepadVibrationMixer class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGamepadVibrationMixer
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsPaused()
        {
            if (!HookedList.Contains("get_IsPaused"))
            {
                HookedList.Add("get_IsPaused");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_IsPaused"), get_IsPaused);
            }
        }

        internal static event Delegates.get_IsPaused_BeforeArgs _beforeget_IsPaused;
        internal static event Delegates.get_IsPaused_AfterArgs _afterget_IsPaused;

        private static bool get_IsPaused(Func<GamepadVibrationMixer, bool> orig, GamepadVibrationMixer self)
        {
            Delegates.Params_get_IsPaused @params = new()
            {
                self = self
            };
            if (_beforeget_IsPaused != null)
                foreach (Delegates.get_IsPaused_BeforeArgs toInvoke in _beforeget_IsPaused.GetInvocationList())
                    try
                    {
                        _beforeget_IsPaused?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsPaused != null)
                foreach (Delegates.get_IsPaused_AfterArgs toInvoke in _afterget_IsPaused.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsPaused.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookset_IsPaused()
        {
            if (!HookedList.Contains("set_IsPaused"))
            {
                HookedList.Add("set_IsPaused");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "set_IsPaused"), set_IsPaused);
            }
        }

        internal static event Delegates.set_IsPaused_BeforeArgs _beforeset_IsPaused;
        internal static event Delegates.set_IsPaused_AfterArgs _afterset_IsPaused;

        private static void set_IsPaused(Action<GamepadVibrationMixer, bool> orig, GamepadVibrationMixer self,
            bool value)
        {
            Delegates.Params_set_IsPaused @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_IsPaused != null)
                foreach (Delegates.set_IsPaused_BeforeArgs toInvoke in _beforeset_IsPaused.GetInvocationList())
                    try
                    {
                        _beforeset_IsPaused?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_IsPaused != null)
                foreach (Delegates.set_IsPaused_AfterArgs toInvoke in _afterset_IsPaused.GetInvocationList())
                    try
                    {
                        _afterset_IsPaused.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void Hookget_PlayingEmissionCount()
        {
            if (!HookedList.Contains("get_PlayingEmissionCount"))
            {
                HookedList.Add("get_PlayingEmissionCount");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_PlayingEmissionCount"),
                    get_PlayingEmissionCount);
            }
        }

        internal static event Delegates.get_PlayingEmissionCount_BeforeArgs _beforeget_PlayingEmissionCount;
        internal static event Delegates.get_PlayingEmissionCount_AfterArgs _afterget_PlayingEmissionCount;

        private static int get_PlayingEmissionCount(Func<GamepadVibrationMixer, int> orig, GamepadVibrationMixer self)
        {
            Delegates.Params_get_PlayingEmissionCount @params = new()
            {
                self = self
            };
            if (_beforeget_PlayingEmissionCount != null)
                foreach (Delegates.get_PlayingEmissionCount_BeforeArgs toInvoke in _beforeget_PlayingEmissionCount
                             .GetInvocationList())
                    try
                    {
                        _beforeget_PlayingEmissionCount?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_PlayingEmissionCount != null)
                foreach (Delegates.get_PlayingEmissionCount_AfterArgs toInvoke in _afterget_PlayingEmissionCount
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_PlayingEmissionCount.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetPlayingEmission()
        {
            if (!HookedList.Contains("GetPlayingEmission"))
            {
                HookedList.Add("GetPlayingEmission");
                On.GamepadVibrationMixer.GetPlayingEmission += GetPlayingEmission;
            }
        }

        internal static event Delegates.GetPlayingEmission_BeforeArgs _beforeGetPlayingEmission;
        internal static event Delegates.GetPlayingEmission_AfterArgs _afterGetPlayingEmission;

        private static VibrationEmission GetPlayingEmission(On.GamepadVibrationMixer.orig_GetPlayingEmission orig,
            GamepadVibrationMixer self, int playingEmissionIndex)
        {
            Delegates.Params_GetPlayingEmission @params = new()
            {
                self = self, playingEmissionIndex = playingEmissionIndex
            };
            if (_beforeGetPlayingEmission != null)
                foreach (Delegates.GetPlayingEmission_BeforeArgs toInvoke in
                         _beforeGetPlayingEmission.GetInvocationList())
                    try
                    {
                        _beforeGetPlayingEmission?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            playingEmissionIndex = @params.playingEmissionIndex;
            var retVal = orig(self, playingEmissionIndex);
            if (_afterGetPlayingEmission != null)
                foreach (Delegates.GetPlayingEmission_AfterArgs toInvoke in
                         _afterGetPlayingEmission.GetInvocationList())
                    try
                    {
                        retVal = _afterGetPlayingEmission.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookPlayEmission()
        {
            if (!HookedList.Contains("PlayEmission"))
            {
                HookedList.Add("PlayEmission");
                On.GamepadVibrationMixer.PlayEmission += PlayEmission;
            }
        }

        internal static event Delegates.PlayEmission_BeforeArgs _beforePlayEmission;
        internal static event Delegates.PlayEmission_AfterArgs _afterPlayEmission;

        private static VibrationEmission PlayEmission(On.GamepadVibrationMixer.orig_PlayEmission orig,
            GamepadVibrationMixer self, VibrationData vibrationData, VibrationTarget vibrationTarget, bool isLooping,
            string tag)
        {
            Delegates.Params_PlayEmission @params = new()
            {
                self = self, vibrationData = vibrationData, vibrationTarget = vibrationTarget, isLooping = isLooping,
                tag = tag
            };
            if (_beforePlayEmission != null)
                foreach (Delegates.PlayEmission_BeforeArgs toInvoke in _beforePlayEmission.GetInvocationList())
                    try
                    {
                        _beforePlayEmission?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            vibrationData = @params.vibrationData;
            vibrationTarget = @params.vibrationTarget;
            isLooping = @params.isLooping;
            tag = @params.tag;
            var retVal = orig(self, vibrationData, vibrationTarget, isLooping, tag);
            if (_afterPlayEmission != null)
                foreach (Delegates.PlayEmission_AfterArgs toInvoke in _afterPlayEmission.GetInvocationList())
                    try
                    {
                        retVal = _afterPlayEmission.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookStopAllEmissions()
        {
            if (!HookedList.Contains("StopAllEmissions"))
            {
                HookedList.Add("StopAllEmissions");
                On.GamepadVibrationMixer.StopAllEmissions += StopAllEmissions;
            }
        }

        internal static event Delegates.StopAllEmissions_BeforeArgs _beforeStopAllEmissions;
        internal static event Delegates.StopAllEmissions_AfterArgs _afterStopAllEmissions;

        private static void StopAllEmissions(On.GamepadVibrationMixer.orig_StopAllEmissions orig,
            GamepadVibrationMixer self)
        {
            Delegates.Params_StopAllEmissions @params = new()
            {
                self = self
            };
            if (_beforeStopAllEmissions != null)
                foreach (Delegates.StopAllEmissions_BeforeArgs toInvoke in _beforeStopAllEmissions.GetInvocationList())
                    try
                    {
                        _beforeStopAllEmissions?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStopAllEmissions != null)
                foreach (Delegates.StopAllEmissions_AfterArgs toInvoke in _afterStopAllEmissions.GetInvocationList())
                    try
                    {
                        _afterStopAllEmissions.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStopAllEmissionsWithTag()
        {
            if (!HookedList.Contains("StopAllEmissionsWithTag"))
            {
                HookedList.Add("StopAllEmissionsWithTag");
                On.GamepadVibrationMixer.StopAllEmissionsWithTag += StopAllEmissionsWithTag;
            }
        }

        internal static event Delegates.StopAllEmissionsWithTag_BeforeArgs _beforeStopAllEmissionsWithTag;
        internal static event Delegates.StopAllEmissionsWithTag_AfterArgs _afterStopAllEmissionsWithTag;

        private static void StopAllEmissionsWithTag(On.GamepadVibrationMixer.orig_StopAllEmissionsWithTag orig,
            GamepadVibrationMixer self, string tag)
        {
            Delegates.Params_StopAllEmissionsWithTag @params = new()
            {
                self = self, tag = tag
            };
            if (_beforeStopAllEmissionsWithTag != null)
                foreach (Delegates.StopAllEmissionsWithTag_BeforeArgs toInvoke in _beforeStopAllEmissionsWithTag
                             .GetInvocationList())
                    try
                    {
                        _beforeStopAllEmissionsWithTag?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            tag = @params.tag;
            orig(self, tag);
            if (_afterStopAllEmissionsWithTag != null)
                foreach (Delegates.StopAllEmissionsWithTag_AfterArgs toInvoke in _afterStopAllEmissionsWithTag
                             .GetInvocationList())
                    try
                    {
                        _afterStopAllEmissionsWithTag.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.GamepadVibrationMixer.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.GamepadVibrationMixer.orig_Update orig, GamepadVibrationMixer self,
            float deltaTime)
        {
            Delegates.Params_Update @params = new()
            {
                self = self, deltaTime = deltaTime
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
            deltaTime = @params.deltaTime;
            orig(self, deltaTime);
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

        internal static void HookAdjustForPlatform()
        {
            if (!HookedList.Contains("AdjustForPlatform"))
            {
                HookedList.Add("AdjustForPlatform");
                On.GamepadVibrationMixer.AdjustForPlatform += AdjustForPlatform;
            }
        }

        internal static event Delegates.AdjustForPlatform_BeforeArgs _beforeAdjustForPlatform;
        internal static event Delegates.AdjustForPlatform_AfterArgs _afterAdjustForPlatform;

        private static float AdjustForPlatform(On.GamepadVibrationMixer.orig_AdjustForPlatform orig,
            GamepadVibrationMixer self, float val)
        {
            Delegates.Params_AdjustForPlatform @params = new()
            {
                self = self, val = val
            };
            if (_beforeAdjustForPlatform != null)
                foreach (Delegates.AdjustForPlatform_BeforeArgs toInvoke in
                         _beforeAdjustForPlatform.GetInvocationList())
                    try
                    {
                        _beforeAdjustForPlatform?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            val = @params.val;
            var retVal = orig(self, val);
            if (_afterAdjustForPlatform != null)
                foreach (Delegates.AdjustForPlatform_AfterArgs toInvoke in _afterAdjustForPlatform.GetInvocationList())
                    try
                    {
                        retVal = _afterAdjustForPlatform.Invoke(@params, retVal);
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
        public delegate float AdjustForPlatform_AfterArgs(Params_AdjustForPlatform args, float ret);

        public delegate void AdjustForPlatform_BeforeArgs(Params_AdjustForPlatform args);

        public delegate float AdjustForPlatform_WithArgs(Func<GamepadVibrationMixer, float, float> orig,
            GamepadVibrationMixer self, float val);

        public delegate bool get_IsPaused_AfterArgs(Params_get_IsPaused args, bool ret);

        public delegate void get_IsPaused_BeforeArgs(Params_get_IsPaused args);

        public delegate bool get_IsPaused_WithArgs(Func<GamepadVibrationMixer, bool> orig, GamepadVibrationMixer self);

        public delegate int get_PlayingEmissionCount_AfterArgs(Params_get_PlayingEmissionCount args, int ret);

        public delegate void get_PlayingEmissionCount_BeforeArgs(Params_get_PlayingEmissionCount args);

        public delegate int get_PlayingEmissionCount_WithArgs(Func<GamepadVibrationMixer, int> orig,
            GamepadVibrationMixer self);

        public delegate VibrationEmission GetPlayingEmission_AfterArgs(Params_GetPlayingEmission args,
            VibrationEmission ret);

        public delegate void GetPlayingEmission_BeforeArgs(Params_GetPlayingEmission args);

        public delegate VibrationEmission GetPlayingEmission_WithArgs(
            Func<GamepadVibrationMixer, int, VibrationEmission> orig, GamepadVibrationMixer self,
            int playingEmissionIndex);

        public delegate VibrationEmission PlayEmission_AfterArgs(Params_PlayEmission args, VibrationEmission ret);

        public delegate void PlayEmission_BeforeArgs(Params_PlayEmission args);

        public delegate VibrationEmission PlayEmission_WithArgs(
            Func<GamepadVibrationMixer, VibrationData, VibrationTarget, bool, string, VibrationEmission> orig,
            GamepadVibrationMixer self, VibrationData vibrationData, VibrationTarget vibrationTarget, bool isLooping,
            string tag);

        public delegate void set_IsPaused_AfterArgs(Params_set_IsPaused args);

        public delegate void set_IsPaused_BeforeArgs(Params_set_IsPaused args);

        public delegate void set_IsPaused_WithArgs(Action<GamepadVibrationMixer, bool> orig, GamepadVibrationMixer self,
            bool value);

        public delegate void StopAllEmissions_AfterArgs(Params_StopAllEmissions args);

        public delegate void StopAllEmissions_BeforeArgs(Params_StopAllEmissions args);

        public delegate void StopAllEmissions_WithArgs(Action<GamepadVibrationMixer> orig, GamepadVibrationMixer self);

        public delegate void StopAllEmissionsWithTag_AfterArgs(Params_StopAllEmissionsWithTag args);

        public delegate void StopAllEmissionsWithTag_BeforeArgs(Params_StopAllEmissionsWithTag args);

        public delegate void StopAllEmissionsWithTag_WithArgs(Action<GamepadVibrationMixer, string> orig,
            GamepadVibrationMixer self, string tag);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<GamepadVibrationMixer, float> orig, GamepadVibrationMixer self,
            float deltaTime);

        public sealed class Params_get_IsPaused
        {
            public GamepadVibrationMixer self;
        }

        public sealed class Params_set_IsPaused
        {
            public GamepadVibrationMixer self;
            public bool value;
        }

        public sealed class Params_get_PlayingEmissionCount
        {
            public GamepadVibrationMixer self;
        }

        public sealed class Params_GetPlayingEmission
        {
            public int playingEmissionIndex;
            public GamepadVibrationMixer self;
        }

        public sealed class Params_PlayEmission
        {
            public bool isLooping;
            public GamepadVibrationMixer self;
            public string tag;
            public VibrationData vibrationData;
            public VibrationTarget vibrationTarget;
        }

        public sealed class Params_StopAllEmissions
        {
            public GamepadVibrationMixer self;
        }

        public sealed class Params_StopAllEmissionsWithTag
        {
            public GamepadVibrationMixer self;
            public string tag;
        }

        public sealed class Params_Update
        {
            public float deltaTime;
            public GamepadVibrationMixer self;
        }

        public sealed class Params_AdjustForPlatform
        {
            public GamepadVibrationMixer self;
            public float val;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsPaused_BeforeArgs get_IsPaused
        {
            add
            {
                HookHandler._beforeget_IsPaused += value;
                HookHandler.Hookget_IsPaused();
            }
            remove => HookHandler._beforeget_IsPaused -= value;
        }

        public static event Delegates.set_IsPaused_BeforeArgs set_IsPaused
        {
            add
            {
                HookHandler._beforeset_IsPaused += value;
                HookHandler.Hookset_IsPaused();
            }
            remove => HookHandler._beforeset_IsPaused -= value;
        }

        public static event Delegates.get_PlayingEmissionCount_BeforeArgs get_PlayingEmissionCount
        {
            add
            {
                HookHandler._beforeget_PlayingEmissionCount += value;
                HookHandler.Hookget_PlayingEmissionCount();
            }
            remove => HookHandler._beforeget_PlayingEmissionCount -= value;
        }

        public static event Delegates.GetPlayingEmission_BeforeArgs GetPlayingEmission
        {
            add
            {
                HookHandler._beforeGetPlayingEmission += value;
                HookHandler.HookGetPlayingEmission();
            }
            remove => HookHandler._beforeGetPlayingEmission -= value;
        }

        public static event Delegates.PlayEmission_BeforeArgs PlayEmission
        {
            add
            {
                HookHandler._beforePlayEmission += value;
                HookHandler.HookPlayEmission();
            }
            remove => HookHandler._beforePlayEmission -= value;
        }

        public static event Delegates.StopAllEmissions_BeforeArgs StopAllEmissions
        {
            add
            {
                HookHandler._beforeStopAllEmissions += value;
                HookHandler.HookStopAllEmissions();
            }
            remove => HookHandler._beforeStopAllEmissions -= value;
        }

        public static event Delegates.StopAllEmissionsWithTag_BeforeArgs StopAllEmissionsWithTag
        {
            add
            {
                HookHandler._beforeStopAllEmissionsWithTag += value;
                HookHandler.HookStopAllEmissionsWithTag();
            }
            remove => HookHandler._beforeStopAllEmissionsWithTag -= value;
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

        public static event Delegates.AdjustForPlatform_BeforeArgs AdjustForPlatform
        {
            add
            {
                HookHandler._beforeAdjustForPlatform += value;
                HookHandler.HookAdjustForPlatform();
            }
            remove => HookHandler._beforeAdjustForPlatform -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsPaused_AfterArgs get_IsPaused
        {
            add
            {
                HookHandler._afterget_IsPaused += value;
                HookHandler.Hookget_IsPaused();
            }
            remove => HookHandler._afterget_IsPaused -= value;
        }

        public static event Delegates.set_IsPaused_AfterArgs set_IsPaused
        {
            add
            {
                HookHandler._afterset_IsPaused += value;
                HookHandler.Hookset_IsPaused();
            }
            remove => HookHandler._afterset_IsPaused -= value;
        }

        public static event Delegates.get_PlayingEmissionCount_AfterArgs get_PlayingEmissionCount
        {
            add
            {
                HookHandler._afterget_PlayingEmissionCount += value;
                HookHandler.Hookget_PlayingEmissionCount();
            }
            remove => HookHandler._afterget_PlayingEmissionCount -= value;
        }

        public static event Delegates.GetPlayingEmission_AfterArgs GetPlayingEmission
        {
            add
            {
                HookHandler._afterGetPlayingEmission += value;
                HookHandler.HookGetPlayingEmission();
            }
            remove => HookHandler._afterGetPlayingEmission -= value;
        }

        public static event Delegates.PlayEmission_AfterArgs PlayEmission
        {
            add
            {
                HookHandler._afterPlayEmission += value;
                HookHandler.HookPlayEmission();
            }
            remove => HookHandler._afterPlayEmission -= value;
        }

        public static event Delegates.StopAllEmissions_AfterArgs StopAllEmissions
        {
            add
            {
                HookHandler._afterStopAllEmissions += value;
                HookHandler.HookStopAllEmissions();
            }
            remove => HookHandler._afterStopAllEmissions -= value;
        }

        public static event Delegates.StopAllEmissionsWithTag_AfterArgs StopAllEmissionsWithTag
        {
            add
            {
                HookHandler._afterStopAllEmissionsWithTag += value;
                HookHandler.HookStopAllEmissionsWithTag();
            }
            remove => HookHandler._afterStopAllEmissionsWithTag -= value;
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

        public static event Delegates.AdjustForPlatform_AfterArgs AdjustForPlatform
        {
            add
            {
                HookHandler._afterAdjustForPlatform += value;
                HookHandler.HookAdjustForPlatform();
            }
            remove => HookHandler._afterAdjustForPlatform -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsPaused_WithArgs get_IsPaused
        {
            add => HookEndpointManager.Add<Delegates.get_IsPaused_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_IsPaused"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsPaused_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_IsPaused"), value);
        }

        public static event Delegates.set_IsPaused_WithArgs set_IsPaused
        {
            add => HookEndpointManager.Add<Delegates.set_IsPaused_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "set_IsPaused"), value);
            remove => HookEndpointManager.Remove<Delegates.set_IsPaused_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "set_IsPaused"), value);
        }

        public static event Delegates.get_PlayingEmissionCount_WithArgs get_PlayingEmissionCount
        {
            add => HookEndpointManager.Add<Delegates.get_PlayingEmissionCount_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_PlayingEmissionCount"), value);
            remove => HookEndpointManager.Remove<Delegates.get_PlayingEmissionCount_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_PlayingEmissionCount"), value);
        }

        public static event On.GamepadVibrationMixer.hook_GetPlayingEmission GetPlayingEmission
        {
            add => On.GamepadVibrationMixer.GetPlayingEmission += value;
            remove => On.GamepadVibrationMixer.GetPlayingEmission -= value;
        }

        public static event On.GamepadVibrationMixer.hook_PlayEmission PlayEmission
        {
            add => On.GamepadVibrationMixer.PlayEmission += value;
            remove => On.GamepadVibrationMixer.PlayEmission -= value;
        }

        public static event On.GamepadVibrationMixer.hook_StopAllEmissions StopAllEmissions
        {
            add => On.GamepadVibrationMixer.StopAllEmissions += value;
            remove => On.GamepadVibrationMixer.StopAllEmissions -= value;
        }

        public static event On.GamepadVibrationMixer.hook_StopAllEmissionsWithTag StopAllEmissionsWithTag
        {
            add => On.GamepadVibrationMixer.StopAllEmissionsWithTag += value;
            remove => On.GamepadVibrationMixer.StopAllEmissionsWithTag -= value;
        }

        public static event On.GamepadVibrationMixer.hook_Update Update
        {
            add => On.GamepadVibrationMixer.Update += value;
            remove => On.GamepadVibrationMixer.Update -= value;
        }

        public static event On.GamepadVibrationMixer.hook_AdjustForPlatform AdjustForPlatform
        {
            add => On.GamepadVibrationMixer.AdjustForPlatform += value;
            remove => On.GamepadVibrationMixer.AdjustForPlatform -= value;
        }
    }
}