using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AddComponent class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAddComponent
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddComponent), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<AddComponent> orig, AddComponent self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddComponent), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<AddComponent> orig, AddComponent self)
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddComponent), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_NormalArgs _afterOnExit;

        private static void OnExit(Action<AddComponent> orig, AddComponent self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            _beforeOnExit?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnExit != null) _afterOnExit.Invoke(@params);
        }

        internal static void HookDoAddComponent()
        {
            if (!HookedList.Contains("DoAddComponent"))
            {
                HookedList.Add("DoAddComponent");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddComponent), "DoAddComponent"), DoAddComponent);
            }
        }

        internal static event Delegates.DoAddComponent_BeforeArgs _beforeDoAddComponent;
        internal static event Delegates.DoAddComponent_NormalArgs _afterDoAddComponent;

        private static void DoAddComponent(Action<AddComponent> orig, AddComponent self)
        {
            Delegates.Params_DoAddComponent @params = new()
            {
                self = self
            };
            _beforeDoAddComponent?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoAddComponent != null) _afterDoAddComponent.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoAddComponent_BeforeArgs(Params_DoAddComponent args);

        public delegate void DoAddComponent_NormalArgs(Params_DoAddComponent args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_NormalArgs(Params_OnExit args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public AddComponent self;
        }

        public sealed class Params_OnEnter
        {
            public AddComponent self;
        }

        public sealed class Params_OnExit
        {
            public AddComponent self;
        }

        public sealed class Params_DoAddComponent
        {
            public AddComponent self;
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

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }

        public static event Delegates.DoAddComponent_BeforeArgs DoAddComponent
        {
            add
            {
                HookHandler._beforeDoAddComponent += value;
                HookHandler.HookDoAddComponent();
            }
            remove => HookHandler._beforeDoAddComponent -= value;
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

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }

        public static event Delegates.DoAddComponent_NormalArgs DoAddComponent
        {
            add
            {
                HookHandler._afterDoAddComponent += value;
                HookHandler.HookDoAddComponent();
            }
            remove => HookHandler._afterDoAddComponent -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "OnEnter"), value);
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "OnExit"), value);
        }

        public static event Delegates.DoAddComponent_NormalArgs DoAddComponent
        {
            add => HookEndpointManager.Add<Delegates.DoAddComponent_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "DoAddComponent"), value);
            remove => HookEndpointManager.Remove<Delegates.DoAddComponent_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddComponent), "DoAddComponent"), value);
        }
    }
}