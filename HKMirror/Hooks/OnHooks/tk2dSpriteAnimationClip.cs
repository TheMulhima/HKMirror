using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dSpriteAnimationClip class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteAnimationClip
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Duration()
        {
            if (!HookedList.Contains("get_Duration"))
            {
                HookedList.Add("get_Duration");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Duration"), get_Duration);
            }
        }

        internal static event Delegates.get_Duration_BeforeArgs _beforeget_Duration;
        internal static event Delegates.get_Duration_NormalArgs _afterget_Duration;

        private static float get_Duration(Func<tk2dSpriteAnimationClip, float> orig, tk2dSpriteAnimationClip self)
        {
            Delegates.Params_get_Duration @params = new()
            {
                self = self
            };
            _beforeget_Duration?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Duration != null) retVal = _afterget_Duration.Invoke(@params);
            return retVal;
        }

        internal static void HookCopyFrom()
        {
            if (!HookedList.Contains("CopyFrom"))
            {
                HookedList.Add("CopyFrom");
                On.tk2dSpriteAnimationClip.CopyFrom += CopyFrom;
            }
        }

        internal static event Delegates.CopyFrom_BeforeArgs _beforeCopyFrom;
        internal static event Delegates.CopyFrom_NormalArgs _afterCopyFrom;

        private static void CopyFrom(On.tk2dSpriteAnimationClip.orig_CopyFrom orig, tk2dSpriteAnimationClip self,
            tk2dSpriteAnimationClip source)
        {
            Delegates.Params_CopyFrom @params = new()
            {
                self = self, source = source
            };
            _beforeCopyFrom?.Invoke(@params);
            self = @params.self;
            source = @params.source;
            orig(self, source);
            if (_afterCopyFrom != null) _afterCopyFrom.Invoke(@params);
        }

        internal static void HookClear()
        {
            if (!HookedList.Contains("Clear"))
            {
                HookedList.Add("Clear");
                On.tk2dSpriteAnimationClip.Clear += Clear;
            }
        }

        internal static event Delegates.Clear_BeforeArgs _beforeClear;
        internal static event Delegates.Clear_NormalArgs _afterClear;

        private static void Clear(On.tk2dSpriteAnimationClip.orig_Clear orig, tk2dSpriteAnimationClip self)
        {
            Delegates.Params_Clear @params = new()
            {
                self = self
            };
            _beforeClear?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterClear != null) _afterClear.Invoke(@params);
        }

        internal static void Hookget_Empty()
        {
            if (!HookedList.Contains("get_Empty"))
            {
                HookedList.Add("get_Empty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Empty"), get_Empty);
            }
        }

        internal static event Delegates.get_Empty_BeforeArgs _beforeget_Empty;
        internal static event Delegates.get_Empty_NormalArgs _afterget_Empty;

        private static bool get_Empty(Func<tk2dSpriteAnimationClip, bool> orig, tk2dSpriteAnimationClip self)
        {
            Delegates.Params_get_Empty @params = new()
            {
                self = self
            };
            _beforeget_Empty?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Empty != null) retVal = _afterget_Empty.Invoke(@params);
            return retVal;
        }

        internal static void HookGetFrame()
        {
            if (!HookedList.Contains("GetFrame"))
            {
                HookedList.Add("GetFrame");
                On.tk2dSpriteAnimationClip.GetFrame += GetFrame;
            }
        }

        internal static event Delegates.GetFrame_BeforeArgs _beforeGetFrame;
        internal static event Delegates.GetFrame_NormalArgs _afterGetFrame;

        private static tk2dSpriteAnimationFrame GetFrame(On.tk2dSpriteAnimationClip.orig_GetFrame orig,
            tk2dSpriteAnimationClip self, int frame)
        {
            Delegates.Params_GetFrame @params = new()
            {
                self = self, frame = frame
            };
            _beforeGetFrame?.Invoke(@params);
            self = @params.self;
            frame = @params.frame;
            var retVal = orig(self, frame);
            if (_afterGetFrame != null) retVal = _afterGetFrame.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Clear_BeforeArgs(Params_Clear args);

        public delegate void Clear_NormalArgs(Params_Clear args);

        public delegate void CopyFrom_BeforeArgs(Params_CopyFrom args);

        public delegate void CopyFrom_NormalArgs(Params_CopyFrom args);

        public delegate void get_Duration_BeforeArgs(Params_get_Duration args);

        public delegate float get_Duration_NormalArgs(Params_get_Duration args);

        public delegate void get_Empty_BeforeArgs(Params_get_Empty args);

        public delegate bool get_Empty_NormalArgs(Params_get_Empty args);

        public delegate void GetFrame_BeforeArgs(Params_GetFrame args);

        public delegate tk2dSpriteAnimationFrame GetFrame_NormalArgs(Params_GetFrame args);

        public sealed class Params_get_Duration
        {
            public tk2dSpriteAnimationClip self;
        }

        public sealed class Params_CopyFrom
        {
            public tk2dSpriteAnimationClip self;
            public tk2dSpriteAnimationClip source;
        }

        public sealed class Params_Clear
        {
            public tk2dSpriteAnimationClip self;
        }

        public sealed class Params_get_Empty
        {
            public tk2dSpriteAnimationClip self;
        }

        public sealed class Params_GetFrame
        {
            public int frame;
            public tk2dSpriteAnimationClip self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Duration_BeforeArgs get_Duration
        {
            add
            {
                HookHandler._beforeget_Duration += value;
                HookHandler.Hookget_Duration();
            }
            remove => HookHandler._beforeget_Duration -= value;
        }

        public static event Delegates.CopyFrom_BeforeArgs CopyFrom
        {
            add
            {
                HookHandler._beforeCopyFrom += value;
                HookHandler.HookCopyFrom();
            }
            remove => HookHandler._beforeCopyFrom -= value;
        }

        public static event Delegates.Clear_BeforeArgs Clear
        {
            add
            {
                HookHandler._beforeClear += value;
                HookHandler.HookClear();
            }
            remove => HookHandler._beforeClear -= value;
        }

        public static event Delegates.get_Empty_BeforeArgs get_Empty
        {
            add
            {
                HookHandler._beforeget_Empty += value;
                HookHandler.Hookget_Empty();
            }
            remove => HookHandler._beforeget_Empty -= value;
        }

        public static event Delegates.GetFrame_BeforeArgs GetFrame
        {
            add
            {
                HookHandler._beforeGetFrame += value;
                HookHandler.HookGetFrame();
            }
            remove => HookHandler._beforeGetFrame -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Duration_NormalArgs get_Duration
        {
            add
            {
                HookHandler._afterget_Duration += value;
                HookHandler.Hookget_Duration();
            }
            remove => HookHandler._afterget_Duration -= value;
        }

        public static event Delegates.CopyFrom_NormalArgs CopyFrom
        {
            add
            {
                HookHandler._afterCopyFrom += value;
                HookHandler.HookCopyFrom();
            }
            remove => HookHandler._afterCopyFrom -= value;
        }

        public static event Delegates.Clear_NormalArgs Clear
        {
            add
            {
                HookHandler._afterClear += value;
                HookHandler.HookClear();
            }
            remove => HookHandler._afterClear -= value;
        }

        public static event Delegates.get_Empty_NormalArgs get_Empty
        {
            add
            {
                HookHandler._afterget_Empty += value;
                HookHandler.Hookget_Empty();
            }
            remove => HookHandler._afterget_Empty -= value;
        }

        public static event Delegates.GetFrame_NormalArgs GetFrame
        {
            add
            {
                HookHandler._afterGetFrame += value;
                HookHandler.HookGetFrame();
            }
            remove => HookHandler._afterGetFrame -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Duration_NormalArgs get_Duration
        {
            add => HookEndpointManager.Add<Delegates.get_Duration_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Duration"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Duration_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Duration"), value);
        }

        public static event On.tk2dSpriteAnimationClip.hook_CopyFrom CopyFrom
        {
            add => On.tk2dSpriteAnimationClip.CopyFrom += value;
            remove => On.tk2dSpriteAnimationClip.CopyFrom -= value;
        }

        public static event On.tk2dSpriteAnimationClip.hook_Clear Clear
        {
            add => On.tk2dSpriteAnimationClip.Clear += value;
            remove => On.tk2dSpriteAnimationClip.Clear -= value;
        }

        public static event Delegates.get_Empty_NormalArgs get_Empty
        {
            add => HookEndpointManager.Add<Delegates.get_Empty_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Empty"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Empty_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Empty"), value);
        }

        public static event On.tk2dSpriteAnimationClip.hook_GetFrame GetFrame
        {
            add => On.tk2dSpriteAnimationClip.GetFrame += value;
            remove => On.tk2dSpriteAnimationClip.GetFrame -= value;
        }
    }
}