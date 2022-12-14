using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Tk2dSpriteSetIdRandom class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dSpriteSetIdRandom
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hook_getSprite()
        {
            if (!HookedList.Contains("_getSprite"))
            {
                HookedList.Add("_getSprite");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "_getSprite"), _getSprite);
            }
        }

        internal static event Delegates._getSprite_BeforeArgs _before_getSprite;
        internal static event Delegates._getSprite_AfterArgs _after_getSprite;

        private static void _getSprite(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self)
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

        internal static void HookDoSetSpriteID()
        {
            if (!HookedList.Contains("DoSetSpriteID"))
            {
                HookedList.Add("DoSetSpriteID");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "DoSetSpriteID"), DoSetSpriteID);
            }
        }

        internal static event Delegates.DoSetSpriteID_BeforeArgs _beforeDoSetSpriteID;
        internal static event Delegates.DoSetSpriteID_AfterArgs _afterDoSetSpriteID;

        private static void DoSetSpriteID(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self)
        {
            Delegates.Params_DoSetSpriteID @params = new()
            {
                self = self
            };
            if (_beforeDoSetSpriteID != null)
                foreach (Delegates.DoSetSpriteID_BeforeArgs toInvoke in _beforeDoSetSpriteID.GetInvocationList())
                    try
                    {
                        _beforeDoSetSpriteID?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetSpriteID != null)
                foreach (Delegates.DoSetSpriteID_AfterArgs toInvoke in _afterDoSetSpriteID.GetInvocationList())
                    try
                    {
                        _afterDoSetSpriteID.Invoke(@params);
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

        public delegate void _getSprite_WithArgs(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self);

        public delegate void DoSetSpriteID_AfterArgs(Params_DoSetSpriteID args);

        public delegate void DoSetSpriteID_BeforeArgs(Params_DoSetSpriteID args);

        public delegate void DoSetSpriteID_WithArgs(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<Tk2dSpriteSetIdRandom> orig, Tk2dSpriteSetIdRandom self);

        public sealed class Params__getSprite
        {
            public Tk2dSpriteSetIdRandom self;
        }

        public sealed class Params_Reset
        {
            public Tk2dSpriteSetIdRandom self;
        }

        public sealed class Params_OnEnter
        {
            public Tk2dSpriteSetIdRandom self;
        }

        public sealed class Params_DoSetSpriteID
        {
            public Tk2dSpriteSetIdRandom self;
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

        public static event Delegates.DoSetSpriteID_BeforeArgs DoSetSpriteID
        {
            add
            {
                HookHandler._beforeDoSetSpriteID += value;
                HookHandler.HookDoSetSpriteID();
            }
            remove => HookHandler._beforeDoSetSpriteID -= value;
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

        public static event Delegates.DoSetSpriteID_AfterArgs DoSetSpriteID
        {
            add
            {
                HookHandler._afterDoSetSpriteID += value;
                HookHandler.HookDoSetSpriteID();
            }
            remove => HookHandler._afterDoSetSpriteID -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "_getSprite"), value);
            remove => HookEndpointManager.Remove<Delegates._getSprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "_getSprite"), value);
        }

        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "OnEnter"), value);
        }

        public static event Delegates.DoSetSpriteID_WithArgs DoSetSpriteID
        {
            add => HookEndpointManager.Add<Delegates.DoSetSpriteID_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "DoSetSpriteID"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetSpriteID_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetIdRandom), "DoSetSpriteID"), value);
        }
    }
}