using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for QuaternionInverse class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnQuaternionInverse
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<QuaternionInverse> orig, QuaternionInverse self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<QuaternionInverse> orig, QuaternionInverse self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<QuaternionInverse> orig, QuaternionInverse self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnLateUpdate"), OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_NormalArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<QuaternionInverse> orig, QuaternionInverse self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_NormalArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<QuaternionInverse> orig, QuaternionInverse self)
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

        internal static void HookDoQuatInverse()
        {
            if (!HookedList.Contains("DoQuatInverse"))
            {
                HookedList.Add("DoQuatInverse");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "DoQuatInverse"), DoQuatInverse);
            }
        }

        internal static event Delegates.DoQuatInverse_BeforeArgs _beforeDoQuatInverse;
        internal static event Delegates.DoQuatInverse_NormalArgs _afterDoQuatInverse;

        private static void DoQuatInverse(Action<QuaternionInverse> orig, QuaternionInverse self)
        {
            Delegates.Params_DoQuatInverse @params = new()
            {
                self = self
            };
            _beforeDoQuatInverse?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoQuatInverse != null) _afterDoQuatInverse.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoQuatInverse_BeforeArgs(Params_DoQuatInverse args);

        public delegate void DoQuatInverse_NormalArgs(Params_DoQuatInverse args);

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
            public QuaternionInverse self;
        }

        public sealed class Params_OnEnter
        {
            public QuaternionInverse self;
        }

        public sealed class Params_OnUpdate
        {
            public QuaternionInverse self;
        }

        public sealed class Params_OnLateUpdate
        {
            public QuaternionInverse self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public QuaternionInverse self;
        }

        public sealed class Params_DoQuatInverse
        {
            public QuaternionInverse self;
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

        public static event Delegates.DoQuatInverse_BeforeArgs DoQuatInverse
        {
            add
            {
                HookHandler._beforeDoQuatInverse += value;
                HookHandler.HookDoQuatInverse();
            }
            remove => HookHandler._beforeDoQuatInverse -= value;
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

        public static event Delegates.DoQuatInverse_NormalArgs DoQuatInverse
        {
            add
            {
                HookHandler._afterDoQuatInverse += value;
                HookHandler.HookDoQuatInverse();
            }
            remove => HookHandler._afterDoQuatInverse -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnUpdate"), value);
        }

        public static event Delegates.OnLateUpdate_NormalArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnLateUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnLateUpdate"), value);
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoQuatInverse_NormalArgs DoQuatInverse
        {
            add => HookEndpointManager.Add<Delegates.DoQuatInverse_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "DoQuatInverse"), value);
            remove => HookEndpointManager.Remove<Delegates.DoQuatInverse_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(QuaternionInverse), "DoQuatInverse"), value);
        }
    }
}