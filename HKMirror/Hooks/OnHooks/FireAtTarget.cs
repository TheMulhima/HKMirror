using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for FireAtTarget class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFireAtTarget
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<FireAtTarget> orig, FireAtTarget self)
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

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "Awake"), Awake);
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(Action<FireAtTarget> orig, FireAtTarget self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_NormalArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<FireAtTarget> orig, FireAtTarget self)
        {
            Delegates.Params_OnPreprocess @params = new()
            {
                self = self
            };
            _beforeOnPreprocess?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnPreprocess != null) _afterOnPreprocess.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<FireAtTarget> orig, FireAtTarget self)
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

        internal static void HookOnFixedUpdate()
        {
            if (!HookedList.Contains("OnFixedUpdate"))
            {
                HookedList.Add("OnFixedUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_NormalArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<FireAtTarget> orig, FireAtTarget self)
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

        internal static void HookDoSetVelocity()
        {
            if (!HookedList.Contains("DoSetVelocity"))
            {
                HookedList.Add("DoSetVelocity");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "DoSetVelocity"), DoSetVelocity);
            }
        }

        internal static event Delegates.DoSetVelocity_BeforeArgs _beforeDoSetVelocity;
        internal static event Delegates.DoSetVelocity_NormalArgs _afterDoSetVelocity;

        private static void DoSetVelocity(Action<FireAtTarget> orig, FireAtTarget self)
        {
            Delegates.Params_DoSetVelocity @params = new()
            {
                self = self
            };
            _beforeDoSetVelocity?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSetVelocity != null) _afterDoSetVelocity.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void DoSetVelocity_BeforeArgs(Params_DoSetVelocity args);

        public delegate void DoSetVelocity_NormalArgs(Params_DoSetVelocity args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_NormalArgs(Params_OnFixedUpdate args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_NormalArgs(Params_OnPreprocess args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public FireAtTarget self;
        }

        public sealed class Params_Awake
        {
            public FireAtTarget self;
        }

        public sealed class Params_OnPreprocess
        {
            public FireAtTarget self;
        }

        public sealed class Params_OnEnter
        {
            public FireAtTarget self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public FireAtTarget self;
        }

        public sealed class Params_DoSetVelocity
        {
            public FireAtTarget self;
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

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.OnPreprocess_BeforeArgs OnPreprocess
        {
            add
            {
                HookHandler._beforeOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._beforeOnPreprocess -= value;
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

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.DoSetVelocity_BeforeArgs DoSetVelocity
        {
            add
            {
                HookHandler._beforeDoSetVelocity += value;
                HookHandler.HookDoSetVelocity();
            }
            remove => HookHandler._beforeDoSetVelocity -= value;
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

        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add
            {
                HookHandler._afterOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._afterOnPreprocess -= value;
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

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add
            {
                HookHandler._afterOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._afterOnFixedUpdate -= value;
        }

        public static event Delegates.DoSetVelocity_NormalArgs DoSetVelocity
        {
            add
            {
                HookHandler._afterDoSetVelocity += value;
                HookHandler.HookDoSetVelocity();
            }
            remove => HookHandler._afterDoSetVelocity -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "Reset"), value);
        }

        public static event Delegates.Awake_NormalArgs Awake
        {
            add => HookEndpointManager.Add<Delegates.Awake_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "Awake"), value);
            remove => HookEndpointManager.Remove<Delegates.Awake_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "Awake"), value);
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnPreprocess"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnEnter"), value);
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoSetVelocity_NormalArgs DoSetVelocity
        {
            add => HookEndpointManager.Add<Delegates.DoSetVelocity_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "DoSetVelocity"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetVelocity_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FireAtTarget), "DoSetVelocity"), value);
        }
    }
}