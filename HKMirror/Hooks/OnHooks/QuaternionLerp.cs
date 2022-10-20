using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for QuaternionLerp class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnQuaternionLerp
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<QuaternionLerp> orig, QuaternionLerp self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<QuaternionLerp> orig, QuaternionLerp self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<QuaternionLerp> orig, QuaternionLerp self)
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

        internal static void HookOnLateUpdate()
        {
            if (!HookedList.Contains("OnLateUpdate"))
            {
                HookedList.Add("OnLateUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnLateUpdate"), OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_NormalArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<QuaternionLerp> orig, QuaternionLerp self)
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

        internal static void HookOnFixedUpdate()
        {
            if (!HookedList.Contains("OnFixedUpdate"))
            {
                HookedList.Add("OnFixedUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_NormalArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<QuaternionLerp> orig, QuaternionLerp self)
        {
            Delegates.Params_OnFixedUpdate @params = new()
            {
                self = self
            };
            _beforeOnFixedUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnFixedUpdate != null) _afterOnFixedUpdate.Invoke(@params);
        }

        internal static void HookDoQuatLerp()
        {
            if (!HookedList.Contains("DoQuatLerp"))
            {
                HookedList.Add("DoQuatLerp");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "DoQuatLerp"), DoQuatLerp);
            }
        }

        internal static event Delegates.DoQuatLerp_BeforeArgs _beforeDoQuatLerp;
        internal static event Delegates.DoQuatLerp_NormalArgs _afterDoQuatLerp;

        private static void DoQuatLerp(Action<QuaternionLerp> orig, QuaternionLerp self)
        {
            Delegates.Params_DoQuatLerp @params = new()
            {
                self = self
            };
            _beforeDoQuatLerp?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoQuatLerp != null) _afterDoQuatLerp.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoQuatLerp_BeforeArgs(Params_DoQuatLerp args);

        public delegate void DoQuatLerp_NormalArgs(Params_DoQuatLerp args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_NormalArgs(Params_OnFixedUpdate args);

        public delegate void OnLateUpdate_BeforeArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_NormalArgs(Params_OnLateUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public QuaternionLerp self;
        }

        public sealed class Params_OnEnter
        {
            public QuaternionLerp self;
        }

        public sealed class Params_OnUpdate
        {
            public QuaternionLerp self;
        }

        public sealed class Params_OnLateUpdate
        {
            public QuaternionLerp self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public QuaternionLerp self;
        }

        public sealed class Params_DoQuatLerp
        {
            public QuaternionLerp self;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
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

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.DoQuatLerp_BeforeArgs DoQuatLerp
        {
            add
            {
                HookHandler._beforeDoQuatLerp += value;
                HookHandler.HookDoQuatLerp();
            }
            remove => HookHandler._beforeDoQuatLerp -= value;
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

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
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

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add
            {
                HookHandler._afterOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._afterOnFixedUpdate -= value;
        }

        public static event Delegates.DoQuatLerp_NormalArgs DoQuatLerp
        {
            add
            {
                HookHandler._afterDoQuatLerp += value;
                HookHandler.HookDoQuatLerp();
            }
            remove => HookHandler._afterDoQuatLerp -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnUpdate"), value);
        }

        public static event Delegates.OnLateUpdate_NormalArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnLateUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnLateUpdate"), value);
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoQuatLerp_NormalArgs DoQuatLerp
        {
            add => HookEndpointManager.Add<Delegates.DoQuatLerp_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "DoQuatLerp"), value);
            remove => HookEndpointManager.Remove<Delegates.DoQuatLerp_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionLerp), "DoQuatLerp"), value);
        }
    }
}