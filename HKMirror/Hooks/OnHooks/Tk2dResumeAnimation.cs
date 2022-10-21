using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for Tk2dResumeAnimation class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dResumeAnimation
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hook_getSprite()
        {
            if (!HookedList.Contains("_getSprite"))
            {
                HookedList.Add("_getSprite");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation),
                        "_getSprite", true), _getSprite);
            }
        }

        internal static event Delegates._getSprite_BeforeArgs _before_getSprite;
        internal static event Delegates._getSprite_AfterArgs _after_getSprite;

        private static void _getSprite(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self)
        {
            Delegates.Params__getSprite @params = new()
            {
                self = self
            };
            if (_before_getSprite != null)
            {
                foreach (Delegates._getSprite_BeforeArgs toInvoke in _before_getSprite.GetInvocationList())
                {
                    try
                    {
                        _before_getSprite?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_after_getSprite != null)
            {
                foreach (Delegates._getSprite_AfterArgs toInvoke in _after_getSprite.GetInvocationList())
                {
                    try
                    {
                        _after_getSprite.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
            {
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
            {
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoResumeAnimation()
        {
            if (!HookedList.Contains("DoResumeAnimation"))
            {
                HookedList.Add("DoResumeAnimation");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation),
                        "DoResumeAnimation", true), DoResumeAnimation);
            }
        }

        internal static event Delegates.DoResumeAnimation_BeforeArgs _beforeDoResumeAnimation;
        internal static event Delegates.DoResumeAnimation_AfterArgs _afterDoResumeAnimation;

        private static void DoResumeAnimation(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self)
        {
            Delegates.Params_DoResumeAnimation @params = new()
            {
                self = self
            };
            if (_beforeDoResumeAnimation != null)
            {
                foreach (Delegates.DoResumeAnimation_BeforeArgs toInvoke in
                         _beforeDoResumeAnimation.GetInvocationList())
                {
                    try
                    {
                        _beforeDoResumeAnimation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoResumeAnimation != null)
            {
                foreach (Delegates.DoResumeAnimation_AfterArgs toInvoke in _afterDoResumeAnimation.GetInvocationList())
                {
                    try
                    {
                        _afterDoResumeAnimation.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params__getSprite
        {
            public HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self;
        }

        public delegate void _getSprite_BeforeArgs(Params__getSprite args);

        public delegate void _getSprite_AfterArgs(Params__getSprite args);

        public delegate void _getSprite_WithArgs(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self);

        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self);

        public sealed class Params_DoResumeAnimation
        {
            public HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self;
        }

        public delegate void DoResumeAnimation_BeforeArgs(Params_DoResumeAnimation args);

        public delegate void DoResumeAnimation_AfterArgs(Params_DoResumeAnimation args);

        public delegate void DoResumeAnimation_WithArgs(Action<HutongGames.PlayMaker.Actions.Tk2dResumeAnimation> orig,
            HutongGames.PlayMaker.Actions.Tk2dResumeAnimation self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.DoResumeAnimation_BeforeArgs DoResumeAnimation
        {
            add
            {
                HookHandler._beforeDoResumeAnimation += value;
                HookHandler.HookDoResumeAnimation();
            }
            remove => HookHandler._beforeDoResumeAnimation -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.DoResumeAnimation_AfterArgs DoResumeAnimation
        {
            add
            {
                HookHandler._afterDoResumeAnimation += value;
                HookHandler.HookDoResumeAnimation();
            }
            remove => HookHandler._afterDoResumeAnimation -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates._getSprite_WithArgs _getSprite
        {
            add => HookEndpointManager.Add<Delegates._getSprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "_getSprite",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates._getSprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "_getSprite",
                    true), value);
        }

        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "Reset",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "Reset",
                    true), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "OnEnter",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation), "OnEnter",
                    true), value);
        }

        public static event Delegates.DoResumeAnimation_WithArgs DoResumeAnimation
        {
            add => HookEndpointManager.Add<Delegates.DoResumeAnimation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation),
                    "DoResumeAnimation", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoResumeAnimation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dResumeAnimation),
                    "DoResumeAnimation", true), value);
        }
    }
}