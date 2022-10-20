using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetAnimatorIsLayerInTransition class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetAnimatorIsLayerInTransition
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<GetAnimatorIsLayerInTransition> orig, GetAnimatorIsLayerInTransition self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<GetAnimatorIsLayerInTransition> orig, GetAnimatorIsLayerInTransition self)
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

        internal static void HookOnActionUpdate()
        {
            if (!HookedList.Contains("OnActionUpdate"))
            {
                HookedList.Add("OnActionUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "OnActionUpdate"),
                    OnActionUpdate);
            }
        }

        internal static event Delegates.OnActionUpdate_BeforeArgs _beforeOnActionUpdate;
        internal static event Delegates.OnActionUpdate_NormalArgs _afterOnActionUpdate;

        private static void OnActionUpdate(Action<GetAnimatorIsLayerInTransition> orig,
            GetAnimatorIsLayerInTransition self)
        {
            Delegates.Params_OnActionUpdate @params = new()
            {
                self = self
            };
            _beforeOnActionUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnActionUpdate != null) _afterOnActionUpdate.Invoke(@params);
        }

        internal static void HookDoCheckIsInTransition()
        {
            if (!HookedList.Contains("DoCheckIsInTransition"))
            {
                HookedList.Add("DoCheckIsInTransition");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "DoCheckIsInTransition"),
                    DoCheckIsInTransition);
            }
        }

        internal static event Delegates.DoCheckIsInTransition_BeforeArgs _beforeDoCheckIsInTransition;
        internal static event Delegates.DoCheckIsInTransition_NormalArgs _afterDoCheckIsInTransition;

        private static void DoCheckIsInTransition(Action<GetAnimatorIsLayerInTransition> orig,
            GetAnimatorIsLayerInTransition self)
        {
            Delegates.Params_DoCheckIsInTransition @params = new()
            {
                self = self
            };
            _beforeDoCheckIsInTransition?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoCheckIsInTransition != null) _afterDoCheckIsInTransition.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoCheckIsInTransition_BeforeArgs(Params_DoCheckIsInTransition args);

        public delegate void DoCheckIsInTransition_NormalArgs(Params_DoCheckIsInTransition args);

        public delegate void OnActionUpdate_BeforeArgs(Params_OnActionUpdate args);

        public delegate void OnActionUpdate_NormalArgs(Params_OnActionUpdate args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public GetAnimatorIsLayerInTransition self;
        }

        public sealed class Params_OnEnter
        {
            public GetAnimatorIsLayerInTransition self;
        }

        public sealed class Params_OnActionUpdate
        {
            public GetAnimatorIsLayerInTransition self;
        }

        public sealed class Params_DoCheckIsInTransition
        {
            public GetAnimatorIsLayerInTransition self;
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

        public static event Delegates.OnActionUpdate_BeforeArgs OnActionUpdate
        {
            add
            {
                HookHandler._beforeOnActionUpdate += value;
                HookHandler.HookOnActionUpdate();
            }
            remove => HookHandler._beforeOnActionUpdate -= value;
        }

        public static event Delegates.DoCheckIsInTransition_BeforeArgs DoCheckIsInTransition
        {
            add
            {
                HookHandler._beforeDoCheckIsInTransition += value;
                HookHandler.HookDoCheckIsInTransition();
            }
            remove => HookHandler._beforeDoCheckIsInTransition -= value;
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

        public static event Delegates.OnActionUpdate_NormalArgs OnActionUpdate
        {
            add
            {
                HookHandler._afterOnActionUpdate += value;
                HookHandler.HookOnActionUpdate();
            }
            remove => HookHandler._afterOnActionUpdate -= value;
        }

        public static event Delegates.DoCheckIsInTransition_NormalArgs DoCheckIsInTransition
        {
            add
            {
                HookHandler._afterDoCheckIsInTransition += value;
                HookHandler.HookDoCheckIsInTransition();
            }
            remove => HookHandler._afterDoCheckIsInTransition -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "OnEnter"), value);
        }

        public static event Delegates.OnActionUpdate_NormalArgs OnActionUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnActionUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "OnActionUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnActionUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "OnActionUpdate"), value);
        }

        public static event Delegates.DoCheckIsInTransition_NormalArgs DoCheckIsInTransition
        {
            add => HookEndpointManager.Add<Delegates.DoCheckIsInTransition_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "DoCheckIsInTransition"), value);
            remove => HookEndpointManager.Remove<Delegates.DoCheckIsInTransition_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAnimatorIsLayerInTransition), "DoCheckIsInTransition"), value);
        }
    }
}