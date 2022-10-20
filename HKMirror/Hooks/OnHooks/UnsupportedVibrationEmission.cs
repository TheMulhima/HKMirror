using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for UnsupportedVibrationEmission class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnUnsupportedVibrationEmission
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Target()
        {
            if (!HookedList.Contains("get_Target"))
            {
                HookedList.Add("get_Target");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_Target"),
                    get_Target);
            }
        }

        internal static event Delegates.get_Target_BeforeArgs _beforeget_Target;
        internal static event Delegates.get_Target_NormalArgs _afterget_Target;

        private static VibrationTarget get_Target(Func<UnsupportedVibrationEmission, VibrationTarget> orig,
            UnsupportedVibrationEmission self)
        {
            Delegates.Params_get_Target @params = new()
            {
                self = self
            };
            _beforeget_Target?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Target != null) retVal = _afterget_Target.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_Target()
        {
            if (!HookedList.Contains("set_Target"))
            {
                HookedList.Add("set_Target");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_Target"),
                    set_Target);
            }
        }

        internal static event Delegates.set_Target_BeforeArgs _beforeset_Target;
        internal static event Delegates.set_Target_NormalArgs _afterset_Target;

        private static void set_Target(Action<UnsupportedVibrationEmission, VibrationTarget> orig,
            UnsupportedVibrationEmission self, VibrationTarget value)
        {
            Delegates.Params_set_Target @params = new()
            {
                self = self, value = value
            };
            _beforeset_Target?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Target != null) _afterset_Target.Invoke(@params);
        }

        internal static void Hookget_IsLooping()
        {
            if (!HookedList.Contains("get_IsLooping"))
            {
                HookedList.Add("get_IsLooping");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_IsLooping"),
                    get_IsLooping);
            }
        }

        internal static event Delegates.get_IsLooping_BeforeArgs _beforeget_IsLooping;
        internal static event Delegates.get_IsLooping_NormalArgs _afterget_IsLooping;

        private static bool get_IsLooping(Func<UnsupportedVibrationEmission, bool> orig,
            UnsupportedVibrationEmission self)
        {
            Delegates.Params_get_IsLooping @params = new()
            {
                self = self
            };
            _beforeget_IsLooping?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsLooping != null) retVal = _afterget_IsLooping.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_IsLooping()
        {
            if (!HookedList.Contains("set_IsLooping"))
            {
                HookedList.Add("set_IsLooping");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_IsLooping"),
                    set_IsLooping);
            }
        }

        internal static event Delegates.set_IsLooping_BeforeArgs _beforeset_IsLooping;
        internal static event Delegates.set_IsLooping_NormalArgs _afterset_IsLooping;

        private static void set_IsLooping(Action<UnsupportedVibrationEmission, bool> orig,
            UnsupportedVibrationEmission self, bool value)
        {
            Delegates.Params_set_IsLooping @params = new()
            {
                self = self, value = value
            };
            _beforeset_IsLooping?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_IsLooping != null) _afterset_IsLooping.Invoke(@params);
        }

        internal static void Hookget_IsPlaying()
        {
            if (!HookedList.Contains("get_IsPlaying"))
            {
                HookedList.Add("get_IsPlaying");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_IsPlaying"),
                    get_IsPlaying);
            }
        }

        internal static event Delegates.get_IsPlaying_BeforeArgs _beforeget_IsPlaying;
        internal static event Delegates.get_IsPlaying_NormalArgs _afterget_IsPlaying;

        private static bool get_IsPlaying(Func<UnsupportedVibrationEmission, bool> orig,
            UnsupportedVibrationEmission self)
        {
            Delegates.Params_get_IsPlaying @params = new()
            {
                self = self
            };
            _beforeget_IsPlaying?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsPlaying != null) retVal = _afterget_IsPlaying.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_Tag()
        {
            if (!HookedList.Contains("get_Tag"))
            {
                HookedList.Add("get_Tag");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_Tag"), get_Tag);
            }
        }

        internal static event Delegates.get_Tag_BeforeArgs _beforeget_Tag;
        internal static event Delegates.get_Tag_NormalArgs _afterget_Tag;

        private static string get_Tag(Func<UnsupportedVibrationEmission, string> orig,
            UnsupportedVibrationEmission self)
        {
            Delegates.Params_get_Tag @params = new()
            {
                self = self
            };
            _beforeget_Tag?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Tag != null) retVal = _afterget_Tag.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_Tag()
        {
            if (!HookedList.Contains("set_Tag"))
            {
                HookedList.Add("set_Tag");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_Tag"), set_Tag);
            }
        }

        internal static event Delegates.set_Tag_BeforeArgs _beforeset_Tag;
        internal static event Delegates.set_Tag_NormalArgs _afterset_Tag;

        private static void set_Tag(Action<UnsupportedVibrationEmission, string> orig,
            UnsupportedVibrationEmission self, string value)
        {
            Delegates.Params_set_Tag @params = new()
            {
                self = self, value = value
            };
            _beforeset_Tag?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Tag != null) _afterset_Tag.Invoke(@params);
        }

        internal static void HookStop()
        {
            if (!HookedList.Contains("Stop"))
            {
                HookedList.Add("Stop");
                On.UnsupportedVibrationEmission.Stop += Stop;
            }
        }

        internal static event Delegates.Stop_BeforeArgs _beforeStop;
        internal static event Delegates.Stop_NormalArgs _afterStop;

        private static void Stop(On.UnsupportedVibrationEmission.orig_Stop orig, UnsupportedVibrationEmission self)
        {
            Delegates.Params_Stop @params = new()
            {
                self = self
            };
            _beforeStop?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStop != null) _afterStop.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_IsLooping_BeforeArgs(Params_get_IsLooping args);

        public delegate bool get_IsLooping_NormalArgs(Params_get_IsLooping args);

        public delegate void get_IsPlaying_BeforeArgs(Params_get_IsPlaying args);

        public delegate bool get_IsPlaying_NormalArgs(Params_get_IsPlaying args);

        public delegate void get_Tag_BeforeArgs(Params_get_Tag args);

        public delegate string get_Tag_NormalArgs(Params_get_Tag args);

        public delegate void get_Target_BeforeArgs(Params_get_Target args);

        public delegate VibrationTarget get_Target_NormalArgs(Params_get_Target args);

        public delegate void set_IsLooping_BeforeArgs(Params_set_IsLooping args);

        public delegate void set_IsLooping_NormalArgs(Params_set_IsLooping args);

        public delegate void set_Tag_BeforeArgs(Params_set_Tag args);

        public delegate void set_Tag_NormalArgs(Params_set_Tag args);

        public delegate void set_Target_BeforeArgs(Params_set_Target args);

        public delegate void set_Target_NormalArgs(Params_set_Target args);

        public delegate void Stop_BeforeArgs(Params_Stop args);

        public delegate void Stop_NormalArgs(Params_Stop args);

        public sealed class Params_get_Target
        {
            public UnsupportedVibrationEmission self;
        }

        public sealed class Params_set_Target
        {
            public UnsupportedVibrationEmission self;
            public VibrationTarget value;
        }

        public sealed class Params_get_IsLooping
        {
            public UnsupportedVibrationEmission self;
        }

        public sealed class Params_set_IsLooping
        {
            public UnsupportedVibrationEmission self;
            public bool value;
        }

        public sealed class Params_get_IsPlaying
        {
            public UnsupportedVibrationEmission self;
        }

        public sealed class Params_get_Tag
        {
            public UnsupportedVibrationEmission self;
        }

        public sealed class Params_set_Tag
        {
            public UnsupportedVibrationEmission self;
            public string value;
        }

        public sealed class Params_Stop
        {
            public UnsupportedVibrationEmission self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Target_BeforeArgs get_Target
        {
            add
            {
                HookHandler._beforeget_Target += value;
                HookHandler.Hookget_Target();
            }
            remove => HookHandler._beforeget_Target -= value;
        }

        public static event Delegates.set_Target_BeforeArgs set_Target
        {
            add
            {
                HookHandler._beforeset_Target += value;
                HookHandler.Hookset_Target();
            }
            remove => HookHandler._beforeset_Target -= value;
        }

        public static event Delegates.get_IsLooping_BeforeArgs get_IsLooping
        {
            add
            {
                HookHandler._beforeget_IsLooping += value;
                HookHandler.Hookget_IsLooping();
            }
            remove => HookHandler._beforeget_IsLooping -= value;
        }

        public static event Delegates.set_IsLooping_BeforeArgs set_IsLooping
        {
            add
            {
                HookHandler._beforeset_IsLooping += value;
                HookHandler.Hookset_IsLooping();
            }
            remove => HookHandler._beforeset_IsLooping -= value;
        }

        public static event Delegates.get_IsPlaying_BeforeArgs get_IsPlaying
        {
            add
            {
                HookHandler._beforeget_IsPlaying += value;
                HookHandler.Hookget_IsPlaying();
            }
            remove => HookHandler._beforeget_IsPlaying -= value;
        }

        public static event Delegates.get_Tag_BeforeArgs get_Tag
        {
            add
            {
                HookHandler._beforeget_Tag += value;
                HookHandler.Hookget_Tag();
            }
            remove => HookHandler._beforeget_Tag -= value;
        }

        public static event Delegates.set_Tag_BeforeArgs set_Tag
        {
            add
            {
                HookHandler._beforeset_Tag += value;
                HookHandler.Hookset_Tag();
            }
            remove => HookHandler._beforeset_Tag -= value;
        }

        public static event Delegates.Stop_BeforeArgs Stop
        {
            add
            {
                HookHandler._beforeStop += value;
                HookHandler.HookStop();
            }
            remove => HookHandler._beforeStop -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Target_NormalArgs get_Target
        {
            add
            {
                HookHandler._afterget_Target += value;
                HookHandler.Hookget_Target();
            }
            remove => HookHandler._afterget_Target -= value;
        }

        public static event Delegates.set_Target_NormalArgs set_Target
        {
            add
            {
                HookHandler._afterset_Target += value;
                HookHandler.Hookset_Target();
            }
            remove => HookHandler._afterset_Target -= value;
        }

        public static event Delegates.get_IsLooping_NormalArgs get_IsLooping
        {
            add
            {
                HookHandler._afterget_IsLooping += value;
                HookHandler.Hookget_IsLooping();
            }
            remove => HookHandler._afterget_IsLooping -= value;
        }

        public static event Delegates.set_IsLooping_NormalArgs set_IsLooping
        {
            add
            {
                HookHandler._afterset_IsLooping += value;
                HookHandler.Hookset_IsLooping();
            }
            remove => HookHandler._afterset_IsLooping -= value;
        }

        public static event Delegates.get_IsPlaying_NormalArgs get_IsPlaying
        {
            add
            {
                HookHandler._afterget_IsPlaying += value;
                HookHandler.Hookget_IsPlaying();
            }
            remove => HookHandler._afterget_IsPlaying -= value;
        }

        public static event Delegates.get_Tag_NormalArgs get_Tag
        {
            add
            {
                HookHandler._afterget_Tag += value;
                HookHandler.Hookget_Tag();
            }
            remove => HookHandler._afterget_Tag -= value;
        }

        public static event Delegates.set_Tag_NormalArgs set_Tag
        {
            add
            {
                HookHandler._afterset_Tag += value;
                HookHandler.Hookset_Tag();
            }
            remove => HookHandler._afterset_Tag -= value;
        }

        public static event Delegates.Stop_NormalArgs Stop
        {
            add
            {
                HookHandler._afterStop += value;
                HookHandler.HookStop();
            }
            remove => HookHandler._afterStop -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Target_NormalArgs get_Target
        {
            add => HookEndpointManager.Add<Delegates.get_Target_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_Target"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Target_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_Target"), value);
        }

        public static event Delegates.set_Target_NormalArgs set_Target
        {
            add => HookEndpointManager.Add<Delegates.set_Target_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_Target"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Target_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_Target"), value);
        }

        public static event Delegates.get_IsLooping_NormalArgs get_IsLooping
        {
            add => HookEndpointManager.Add<Delegates.get_IsLooping_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_IsLooping"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsLooping_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_IsLooping"), value);
        }

        public static event Delegates.set_IsLooping_NormalArgs set_IsLooping
        {
            add => HookEndpointManager.Add<Delegates.set_IsLooping_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_IsLooping"), value);
            remove => HookEndpointManager.Remove<Delegates.set_IsLooping_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_IsLooping"), value);
        }

        public static event Delegates.get_IsPlaying_NormalArgs get_IsPlaying
        {
            add => HookEndpointManager.Add<Delegates.get_IsPlaying_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_IsPlaying"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsPlaying_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_IsPlaying"), value);
        }

        public static event Delegates.get_Tag_NormalArgs get_Tag
        {
            add => HookEndpointManager.Add<Delegates.get_Tag_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_Tag"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Tag_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "get_Tag"), value);
        }

        public static event Delegates.set_Tag_NormalArgs set_Tag
        {
            add => HookEndpointManager.Add<Delegates.set_Tag_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_Tag"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Tag_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnsupportedVibrationEmission), "set_Tag"), value);
        }

        public static event On.UnsupportedVibrationEmission.hook_Stop Stop
        {
            add => On.UnsupportedVibrationEmission.Stop += value;
            remove => On.UnsupportedVibrationEmission.Stop -= value;
        }
    }
}