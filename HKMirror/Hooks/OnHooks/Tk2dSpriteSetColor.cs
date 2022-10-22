using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Tk2dSpriteSetColor class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dSpriteSetColor
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hook_getSprite()
        {
            if (!HookedList.Contains("_getSprite"))
            {
                HookedList.Add("_getSprite");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "_getSprite"), _getSprite);
            }
        }

        internal static event Delegates._getSprite_BeforeArgs _before_getSprite;
        internal static event Delegates._getSprite_AfterArgs _after_getSprite;

        private static void _getSprite(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self)
        {
            Delegates.Params__getSprite @params = new()
            {
                self = self
            };
            if (_before_getSprite != null)
                foreach (Delegates._getSprite_BeforeArgs toInvoke in _before_getSprite.GetInvocationList())
                    try
                    {
                        _before_getSprite?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_after_getSprite != null)
                foreach (Delegates._getSprite_AfterArgs toInvoke in _after_getSprite.GetInvocationList())
                    try
                    {
                        _after_getSprite.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoSetSpriteColor()
        {
            if (!HookedList.Contains("DoSetSpriteColor"))
            {
                HookedList.Add("DoSetSpriteColor");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "DoSetSpriteColor"),
                    DoSetSpriteColor);
            }
        }

        internal static event Delegates.DoSetSpriteColor_BeforeArgs _beforeDoSetSpriteColor;
        internal static event Delegates.DoSetSpriteColor_AfterArgs _afterDoSetSpriteColor;

        private static void DoSetSpriteColor(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self)
        {
            Delegates.Params_DoSetSpriteColor @params = new()
            {
                self = self
            };
            if (_beforeDoSetSpriteColor != null)
                foreach (Delegates.DoSetSpriteColor_BeforeArgs toInvoke in _beforeDoSetSpriteColor.GetInvocationList())
                    try
                    {
                        _beforeDoSetSpriteColor?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetSpriteColor != null)
                foreach (Delegates.DoSetSpriteColor_AfterArgs toInvoke in _afterDoSetSpriteColor.GetInvocationList())
                    try
                    {
                        _afterDoSetSpriteColor.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void _getSprite_AfterArgs(Params__getSprite args);

        public delegate void _getSprite_BeforeArgs(Params__getSprite args);

        public delegate void _getSprite_WithArgs(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self);

        public delegate void DoSetSpriteColor_AfterArgs(Params_DoSetSpriteColor args);

        public delegate void DoSetSpriteColor_BeforeArgs(Params_DoSetSpriteColor args);

        public delegate void DoSetSpriteColor_WithArgs(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<Tk2dSpriteSetColor> orig, Tk2dSpriteSetColor self);

        public sealed class Params__getSprite
        {
            public Tk2dSpriteSetColor self;
        }

        public sealed class Params_Reset
        {
            public Tk2dSpriteSetColor self;
        }

        public sealed class Params_OnEnter
        {
            public Tk2dSpriteSetColor self;
        }

        public sealed class Params_OnUpdate
        {
            public Tk2dSpriteSetColor self;
        }

        public sealed class Params_DoSetSpriteColor
        {
            public Tk2dSpriteSetColor self;
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

        public static event Delegates.DoSetSpriteColor_BeforeArgs DoSetSpriteColor
        {
            add
            {
                HookHandler._beforeDoSetSpriteColor += value;
                HookHandler.HookDoSetSpriteColor();
            }
            remove => HookHandler._beforeDoSetSpriteColor -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates._getSprite_AfterArgs _getSprite
        {
            add
            {
                HookHandler._after_getSprite += value;
                HookHandler.Hook_getSprite();
            }
            remove => HookHandler._after_getSprite -= value;
        }

        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoSetSpriteColor_AfterArgs DoSetSpriteColor
        {
            add
            {
                HookHandler._afterDoSetSpriteColor += value;
                HookHandler.HookDoSetSpriteColor();
            }
            remove => HookHandler._afterDoSetSpriteColor -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates._getSprite_WithArgs _getSprite
        {
            add => HookEndpointManager.Add<Delegates._getSprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "_getSprite"), value);
            remove => HookEndpointManager.Remove<Delegates._getSprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "_getSprite"), value);
        }

        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnUpdate"), value);
        }

        public static event Delegates.DoSetSpriteColor_WithArgs DoSetSpriteColor
        {
            add => HookEndpointManager.Add<Delegates.DoSetSpriteColor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "DoSetSpriteColor"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetSpriteColor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "DoSetSpriteColor"), value);
        }
    }
}