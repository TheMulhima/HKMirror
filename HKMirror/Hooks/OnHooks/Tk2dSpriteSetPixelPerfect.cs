using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Tk2dSpriteSetPixelPerfect class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dSpriteSetPixelPerfect
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hook_getSprite()
        {
            if (!HookedList.Contains("_getSprite"))
            {
                HookedList.Add("_getSprite");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "_getSprite"), _getSprite);
            }
        }

        internal static event Delegates._getSprite_BeforeArgs _before_getSprite;
        internal static event Delegates._getSprite_NormalArgs _after_getSprite;

        private static void _getSprite(Action<Tk2dSpriteSetPixelPerfect> orig, Tk2dSpriteSetPixelPerfect self)
        {
            Delegates.Params__getSprite @params = new()
            {
                self = self
            };
            _before_getSprite?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_after_getSprite != null) _after_getSprite.Invoke(@params);
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<Tk2dSpriteSetPixelPerfect> orig, Tk2dSpriteSetPixelPerfect self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<Tk2dSpriteSetPixelPerfect> orig, Tk2dSpriteSetPixelPerfect self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            _beforeOnEnter?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnter != null) _afterOnEnter.Invoke(@params);
        }

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<Tk2dSpriteSetPixelPerfect> orig, Tk2dSpriteSetPixelPerfect self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            _beforeOnUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null) _afterOnUpdate.Invoke(@params);
        }

        internal static void HookDoSetSpritePixelPerfect()
        {
            if (!HookedList.Contains("DoSetSpritePixelPerfect"))
            {
                HookedList.Add("DoSetSpritePixelPerfect");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "DoSetSpritePixelPerfect"),
                    DoSetSpritePixelPerfect);
            }
        }

        internal static event Delegates.DoSetSpritePixelPerfect_BeforeArgs _beforeDoSetSpritePixelPerfect;
        internal static event Delegates.DoSetSpritePixelPerfect_NormalArgs _afterDoSetSpritePixelPerfect;

        private static void DoSetSpritePixelPerfect(Action<Tk2dSpriteSetPixelPerfect> orig,
            Tk2dSpriteSetPixelPerfect self)
        {
            Delegates.Params_DoSetSpritePixelPerfect @params = new()
            {
                self = self
            };
            _beforeDoSetSpritePixelPerfect?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSetSpritePixelPerfect != null) _afterDoSetSpritePixelPerfect.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void _getSprite_BeforeArgs(Params__getSprite args);

        public delegate void _getSprite_NormalArgs(Params__getSprite args);

        public delegate void DoSetSpritePixelPerfect_BeforeArgs(Params_DoSetSpritePixelPerfect args);

        public delegate void DoSetSpritePixelPerfect_NormalArgs(Params_DoSetSpritePixelPerfect args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params__getSprite
        {
            public Tk2dSpriteSetPixelPerfect self;
        }

        public sealed class Params_Reset
        {
            public Tk2dSpriteSetPixelPerfect self;
        }

        public sealed class Params_OnEnter
        {
            public Tk2dSpriteSetPixelPerfect self;
        }

        public sealed class Params_OnUpdate
        {
            public Tk2dSpriteSetPixelPerfect self;
        }

        public sealed class Params_DoSetSpritePixelPerfect
        {
            public Tk2dSpriteSetPixelPerfect self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates._getSprite_BeforeArgs _getSprite
        {
            add
            {
                HookHandler._before_getSprite += value;
                HookHandler.Hook_getSprite();
            }
            remove => HookHandler._before_getSprite -= value;
        }

        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoSetSpritePixelPerfect_BeforeArgs DoSetSpritePixelPerfect
        {
            add
            {
                HookHandler._beforeDoSetSpritePixelPerfect += value;
                HookHandler.HookDoSetSpritePixelPerfect();
            }
            remove => HookHandler._beforeDoSetSpritePixelPerfect -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates._getSprite_NormalArgs _getSprite
        {
            add
            {
                HookHandler._after_getSprite += value;
                HookHandler.Hook_getSprite();
            }
            remove => HookHandler._after_getSprite -= value;
        }

        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoSetSpritePixelPerfect_NormalArgs DoSetSpritePixelPerfect
        {
            add
            {
                HookHandler._afterDoSetSpritePixelPerfect += value;
                HookHandler.HookDoSetSpritePixelPerfect();
            }
            remove => HookHandler._afterDoSetSpritePixelPerfect -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates._getSprite_NormalArgs _getSprite
        {
            add => HookEndpointManager.Add<Delegates._getSprite_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "_getSprite"), value);
            remove => HookEndpointManager.Remove<Delegates._getSprite_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "_getSprite"), value);
        }

        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnUpdate"), value);
        }

        public static event Delegates.DoSetSpritePixelPerfect_NormalArgs DoSetSpritePixelPerfect
        {
            add => HookEndpointManager.Add<Delegates.DoSetSpritePixelPerfect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "DoSetSpritePixelPerfect"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetSpritePixelPerfect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "DoSetSpritePixelPerfect"), value);
        }
    }
}