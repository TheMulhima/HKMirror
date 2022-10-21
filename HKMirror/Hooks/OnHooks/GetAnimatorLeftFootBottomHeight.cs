using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for GetAnimatorLeftFootBottomHeight class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetAnimatorLeftFootBottomHeight
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(
                    ReflectionHelper.GetMethodInfo(
                        typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight), "Reset", true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self)
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
                    ReflectionHelper.GetMethodInfo(
                        typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight), "OnEnter", true),
                    OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self)
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

        internal static void HookOnLateUpdate()
        {
            if (!HookedList.Contains("OnLateUpdate"))
            {
                HookedList.Add("OnLateUpdate");
                new Hook(
                    ReflectionHelper.GetMethodInfo(
                        typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight), "OnLateUpdate", true),
                    OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_AfterArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self)
        {
            Delegates.Params_OnLateUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnLateUpdate != null)
            {
                foreach (Delegates.OnLateUpdate_BeforeArgs toInvoke in _beforeOnLateUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeOnLateUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnLateUpdate != null)
            {
                foreach (Delegates.OnLateUpdate_AfterArgs toInvoke in _afterOnLateUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterOnLateUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hook_getLeftFootBottonHeight()
        {
            if (!HookedList.Contains("_getLeftFootBottonHeight"))
            {
                HookedList.Add("_getLeftFootBottonHeight");
                new Hook(
                    ReflectionHelper.GetMethodInfo(
                        typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                        "_getLeftFootBottonHeight", true), _getLeftFootBottonHeight);
            }
        }

        internal static event Delegates._getLeftFootBottonHeight_BeforeArgs _before_getLeftFootBottonHeight;
        internal static event Delegates._getLeftFootBottonHeight_AfterArgs _after_getLeftFootBottonHeight;

        private static void _getLeftFootBottonHeight(
            Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self)
        {
            Delegates.Params__getLeftFootBottonHeight @params = new()
            {
                self = self
            };
            if (_before_getLeftFootBottonHeight != null)
            {
                foreach (Delegates._getLeftFootBottonHeight_BeforeArgs toInvoke in _before_getLeftFootBottonHeight
                             .GetInvocationList())
                {
                    try
                    {
                        _before_getLeftFootBottonHeight?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_after_getLeftFootBottonHeight != null)
            {
                foreach (Delegates._getLeftFootBottonHeight_AfterArgs toInvoke in _after_getLeftFootBottonHeight
                             .GetInvocationList())
                {
                    try
                    {
                        _after_getLeftFootBottonHeight.Invoke(@params);
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
        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(
            Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self);

        public sealed class Params_OnLateUpdate
        {
            public HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self;
        }

        public delegate void OnLateUpdate_BeforeArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_AfterArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_WithArgs(
            Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self);

        public sealed class Params__getLeftFootBottonHeight
        {
            public HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self;
        }

        public delegate void _getLeftFootBottonHeight_BeforeArgs(Params__getLeftFootBottonHeight args);

        public delegate void _getLeftFootBottonHeight_AfterArgs(Params__getLeftFootBottonHeight args);

        public delegate void _getLeftFootBottonHeight_WithArgs(
            Action<HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight> orig,
            HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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

        public static event Delegates.OnLateUpdate_BeforeArgs OnLateUpdate
        {
            add
            {
                HookHandler._beforeOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._beforeOnLateUpdate -= value;
        }

        public static event Delegates._getLeftFootBottonHeight_BeforeArgs _getLeftFootBottonHeight
        {
            add
            {
                HookHandler._before_getLeftFootBottonHeight += value;
                HookHandler.Hook_getLeftFootBottonHeight();
            }
            remove => HookHandler._before_getLeftFootBottonHeight -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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

        public static event Delegates.OnLateUpdate_AfterArgs OnLateUpdate
        {
            add
            {
                HookHandler._afterOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._afterOnLateUpdate -= value;
        }

        public static event Delegates._getLeftFootBottonHeight_AfterArgs _getLeftFootBottonHeight
        {
            add
            {
                HookHandler._after_getLeftFootBottonHeight += value;
                HookHandler.Hook_getLeftFootBottonHeight();
            }
            remove => HookHandler._after_getLeftFootBottonHeight -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "Reset", true), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "Reset", true), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "OnEnter", true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "OnEnter", true), value);
        }

        public static event Delegates.OnLateUpdate_WithArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "OnLateUpdate", true), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "OnLateUpdate", true), value);
        }

        public static event Delegates._getLeftFootBottonHeight_WithArgs _getLeftFootBottonHeight
        {
            add => HookEndpointManager.Add<Delegates._getLeftFootBottonHeight_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "_getLeftFootBottonHeight", true), value);
            remove => HookEndpointManager.Remove<Delegates._getLeftFootBottonHeight_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLeftFootBottomHeight),
                    "_getLeftFootBottonHeight", true), value);
        }
    }
}