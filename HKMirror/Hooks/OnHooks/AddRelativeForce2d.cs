using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AddRelativeForce2d class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAddRelativeForce2d
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<AddRelativeForce2d> orig, AddRelativeForce2d self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_NormalArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<AddRelativeForce2d> orig, AddRelativeForce2d self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<AddRelativeForce2d> orig, AddRelativeForce2d self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_NormalArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<AddRelativeForce2d> orig, AddRelativeForce2d self)
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

        internal static void HookDoAddRelativeForce()
        {
            if (!HookedList.Contains("DoAddRelativeForce"))
            {
                HookedList.Add("DoAddRelativeForce");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "DoAddRelativeForce"),
                    DoAddRelativeForce);
            }
        }

        internal static event Delegates.DoAddRelativeForce_BeforeArgs _beforeDoAddRelativeForce;
        internal static event Delegates.DoAddRelativeForce_NormalArgs _afterDoAddRelativeForce;

        private static void DoAddRelativeForce(Action<AddRelativeForce2d> orig, AddRelativeForce2d self)
        {
            Delegates.Params_DoAddRelativeForce @params = new()
            {
                self = self
            };
            _beforeDoAddRelativeForce?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoAddRelativeForce != null) _afterDoAddRelativeForce.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoAddRelativeForce_BeforeArgs(Params_DoAddRelativeForce args);

        public delegate void DoAddRelativeForce_NormalArgs(Params_DoAddRelativeForce args);

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
            public AddRelativeForce2d self;
        }

        public sealed class Params_OnPreprocess
        {
            public AddRelativeForce2d self;
        }

        public sealed class Params_OnEnter
        {
            public AddRelativeForce2d self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public AddRelativeForce2d self;
        }

        public sealed class Params_DoAddRelativeForce
        {
            public AddRelativeForce2d self;
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

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.DoAddRelativeForce_BeforeArgs DoAddRelativeForce
        {
            add
            {
                HookHandler._beforeDoAddRelativeForce += value;
                HookHandler.HookDoAddRelativeForce();
            }
            remove => HookHandler._beforeDoAddRelativeForce -= value;
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

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add
            {
                HookHandler._afterOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._afterOnFixedUpdate -= value;
        }

        public static event Delegates.DoAddRelativeForce_NormalArgs DoAddRelativeForce
        {
            add
            {
                HookHandler._afterDoAddRelativeForce += value;
                HookHandler.HookDoAddRelativeForce();
            }
            remove => HookHandler._afterDoAddRelativeForce -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "Reset"), value);
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnPreprocess"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnEnter"), value);
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoAddRelativeForce_NormalArgs DoAddRelativeForce
        {
            add => HookEndpointManager.Add<Delegates.DoAddRelativeForce_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "DoAddRelativeForce"), value);
            remove => HookEndpointManager.Remove<Delegates.DoAddRelativeForce_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddRelativeForce2d), "DoAddRelativeForce"), value);
        }
    }
}