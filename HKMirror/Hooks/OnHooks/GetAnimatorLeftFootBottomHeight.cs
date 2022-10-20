using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetAnimatorLeftFootBottomHeight class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetAnimatorLeftFootBottomHeight
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<GetAnimatorLeftFootBottomHeight> orig, GetAnimatorLeftFootBottomHeight self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<GetAnimatorLeftFootBottomHeight> orig, GetAnimatorLeftFootBottomHeight self)
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

        internal static void HookOnLateUpdate()
        {
            if (!HookedList.Contains("OnLateUpdate"))
            {
                HookedList.Add("OnLateUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "OnLateUpdate"),
                    OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_NormalArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<GetAnimatorLeftFootBottomHeight> orig,
            GetAnimatorLeftFootBottomHeight self)
        {
            Delegates.Params_OnLateUpdate @params = new()
            {
                self = self
            };
            _beforeOnLateUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnLateUpdate != null) _afterOnLateUpdate.Invoke(@params);
        }

        internal static void Hook_getLeftFootBottonHeight()
        {
            if (!HookedList.Contains("_getLeftFootBottonHeight"))
            {
                HookedList.Add("_getLeftFootBottonHeight");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "_getLeftFootBottonHeight"),
                    _getLeftFootBottonHeight);
            }
        }

        internal static event Delegates._getLeftFootBottonHeight_BeforeArgs _before_getLeftFootBottonHeight;
        internal static event Delegates._getLeftFootBottonHeight_NormalArgs _after_getLeftFootBottonHeight;

        private static void _getLeftFootBottonHeight(Action<GetAnimatorLeftFootBottomHeight> orig,
            GetAnimatorLeftFootBottomHeight self)
        {
            Delegates.Params__getLeftFootBottonHeight @params = new()
            {
                self = self
            };
            _before_getLeftFootBottonHeight?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_after_getLeftFootBottonHeight != null) _after_getLeftFootBottonHeight.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void _getLeftFootBottonHeight_BeforeArgs(Params__getLeftFootBottonHeight args);

        public delegate void _getLeftFootBottonHeight_NormalArgs(Params__getLeftFootBottonHeight args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnLateUpdate_BeforeArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_NormalArgs(Params_OnLateUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public GetAnimatorLeftFootBottomHeight self;
        }

        public sealed class Params_OnEnter
        {
            public GetAnimatorLeftFootBottomHeight self;
        }

        public sealed class Params_OnLateUpdate
        {
            public GetAnimatorLeftFootBottomHeight self;
        }

        public sealed class Params__getLeftFootBottonHeight
        {
            public GetAnimatorLeftFootBottomHeight self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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

        public static event Delegates.OnLateUpdate_NormalArgs OnLateUpdate
        {
            add
            {
                HookHandler._afterOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._afterOnLateUpdate -= value;
        }

        public static event Delegates._getLeftFootBottonHeight_NormalArgs _getLeftFootBottonHeight
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
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "OnEnter"), value);
        }

        public static event Delegates.OnLateUpdate_NormalArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "OnLateUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "OnLateUpdate"), value);
        }

        public static event Delegates._getLeftFootBottonHeight_NormalArgs _getLeftFootBottonHeight
        {
            add => HookEndpointManager.Add<Delegates._getLeftFootBottonHeight_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "_getLeftFootBottonHeight"),
                value);
            remove => HookEndpointManager.Remove<Delegates._getLeftFootBottonHeight_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorLeftFootBottomHeight), "_getLeftFootBottonHeight"),
                value);
        }
    }
}