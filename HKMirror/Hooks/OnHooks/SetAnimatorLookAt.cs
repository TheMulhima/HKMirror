using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetAnimatorLookAt class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetAnimatorLookAt
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<SetAnimatorLookAt> orig, SetAnimatorLookAt self)
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

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_NormalArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<SetAnimatorLookAt> orig, SetAnimatorLookAt self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<SetAnimatorLookAt> orig, SetAnimatorLookAt self)
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

        internal static void HookDoAnimatorIK()
        {
            if (!HookedList.Contains("DoAnimatorIK"))
            {
                HookedList.Add("DoAnimatorIK");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "DoAnimatorIK"), DoAnimatorIK);
            }
        }

        internal static event Delegates.DoAnimatorIK_BeforeArgs _beforeDoAnimatorIK;
        internal static event Delegates.DoAnimatorIK_NormalArgs _afterDoAnimatorIK;

        private static void DoAnimatorIK(Action<SetAnimatorLookAt, int> orig, SetAnimatorLookAt self, int layerIndex)
        {
            Delegates.Params_DoAnimatorIK @params = new()
            {
                self = self, layerIndex = layerIndex
            };
            _beforeDoAnimatorIK?.Invoke(@params);
            self = @params.self;
            layerIndex = @params.layerIndex;
            orig(self, layerIndex);
            if (_afterDoAnimatorIK != null) _afterDoAnimatorIK.Invoke(@params);
        }

        internal static void HookDoSetLookAt()
        {
            if (!HookedList.Contains("DoSetLookAt"))
            {
                HookedList.Add("DoSetLookAt");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "DoSetLookAt"), DoSetLookAt);
            }
        }

        internal static event Delegates.DoSetLookAt_BeforeArgs _beforeDoSetLookAt;
        internal static event Delegates.DoSetLookAt_NormalArgs _afterDoSetLookAt;

        private static void DoSetLookAt(Action<SetAnimatorLookAt> orig, SetAnimatorLookAt self)
        {
            Delegates.Params_DoSetLookAt @params = new()
            {
                self = self
            };
            _beforeDoSetLookAt?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSetLookAt != null) _afterDoSetLookAt.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoAnimatorIK_BeforeArgs(Params_DoAnimatorIK args);

        public delegate void DoAnimatorIK_NormalArgs(Params_DoAnimatorIK args);

        public delegate void DoSetLookAt_BeforeArgs(Params_DoSetLookAt args);

        public delegate void DoSetLookAt_NormalArgs(Params_DoSetLookAt args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_NormalArgs(Params_OnPreprocess args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public SetAnimatorLookAt self;
        }

        public sealed class Params_OnPreprocess
        {
            public SetAnimatorLookAt self;
        }

        public sealed class Params_OnEnter
        {
            public SetAnimatorLookAt self;
        }

        public sealed class Params_DoAnimatorIK
        {
            public int layerIndex;
            public SetAnimatorLookAt self;
        }

        public sealed class Params_DoSetLookAt
        {
            public SetAnimatorLookAt self;
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

        public static event Delegates.DoAnimatorIK_BeforeArgs DoAnimatorIK
        {
            add
            {
                HookHandler._beforeDoAnimatorIK += value;
                HookHandler.HookDoAnimatorIK();
            }
            remove => HookHandler._beforeDoAnimatorIK -= value;
        }

        public static event Delegates.DoSetLookAt_BeforeArgs DoSetLookAt
        {
            add
            {
                HookHandler._beforeDoSetLookAt += value;
                HookHandler.HookDoSetLookAt();
            }
            remove => HookHandler._beforeDoSetLookAt -= value;
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

        public static event Delegates.DoAnimatorIK_NormalArgs DoAnimatorIK
        {
            add
            {
                HookHandler._afterDoAnimatorIK += value;
                HookHandler.HookDoAnimatorIK();
            }
            remove => HookHandler._afterDoAnimatorIK -= value;
        }

        public static event Delegates.DoSetLookAt_NormalArgs DoSetLookAt
        {
            add
            {
                HookHandler._afterDoSetLookAt += value;
                HookHandler.HookDoSetLookAt();
            }
            remove => HookHandler._afterDoSetLookAt -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "Reset"), value);
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "OnPreprocess"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "OnEnter"), value);
        }

        public static event Delegates.DoAnimatorIK_NormalArgs DoAnimatorIK
        {
            add => HookEndpointManager.Add<Delegates.DoAnimatorIK_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "DoAnimatorIK"), value);
            remove => HookEndpointManager.Remove<Delegates.DoAnimatorIK_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "DoAnimatorIK"), value);
        }

        public static event Delegates.DoSetLookAt_NormalArgs DoSetLookAt
        {
            add => HookEndpointManager.Add<Delegates.DoSetLookAt_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "DoSetLookAt"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetLookAt_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetAnimatorLookAt), "DoSetLookAt"), value);
        }
    }
}