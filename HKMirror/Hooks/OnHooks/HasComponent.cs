using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for HasComponent class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHasComponent
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HasComponent), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<HasComponent> orig, HasComponent self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<HasComponent> orig, HasComponent self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<HasComponent> orig, HasComponent self)
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_NormalArgs _afterOnExit;

        private static void OnExit(Action<HasComponent> orig, HasComponent self)
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

        internal static void HookDoHasComponent()
        {
            if (!HookedList.Contains("DoHasComponent"))
            {
                HookedList.Add("DoHasComponent");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HasComponent), "DoHasComponent"), DoHasComponent);
            }
        }

        internal static event Delegates.DoHasComponent_BeforeArgs _beforeDoHasComponent;
        internal static event Delegates.DoHasComponent_NormalArgs _afterDoHasComponent;

        private static void DoHasComponent(Action<HasComponent, GameObject> orig, HasComponent self, GameObject go)
        {
            Delegates.Params_DoHasComponent @params = new()
            {
                self = self, go = go
            };
            _beforeDoHasComponent?.Invoke(@params);
            self = @params.self;
            go = @params.go;
            orig(self, go);
            if (_afterDoHasComponent != null) _afterDoHasComponent.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoHasComponent_BeforeArgs(Params_DoHasComponent args);

        public delegate void DoHasComponent_NormalArgs(Params_DoHasComponent args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_NormalArgs(Params_OnExit args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public HasComponent self;
        }

        public sealed class Params_OnEnter
        {
            public HasComponent self;
        }

        public sealed class Params_OnUpdate
        {
            public HasComponent self;
        }

        public sealed class Params_OnExit
        {
            public HasComponent self;
        }

        public sealed class Params_DoHasComponent
        {
            public GameObject go;
            public HasComponent self;
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

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }

        public static event Delegates.DoHasComponent_BeforeArgs DoHasComponent
        {
            add
            {
                HookHandler._beforeDoHasComponent += value;
                HookHandler.HookDoHasComponent();
            }
            remove => HookHandler._beforeDoHasComponent -= value;
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

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }

        public static event Delegates.DoHasComponent_NormalArgs DoHasComponent
        {
            add
            {
                HookHandler._afterDoHasComponent += value;
                HookHandler.HookDoHasComponent();
            }
            remove => HookHandler._afterDoHasComponent -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnUpdate"), value);
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "OnExit"), value);
        }

        public static event Delegates.DoHasComponent_NormalArgs DoHasComponent
        {
            add => HookEndpointManager.Add<Delegates.DoHasComponent_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "DoHasComponent"), value);
            remove => HookEndpointManager.Remove<Delegates.DoHasComponent_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HasComponent), "DoHasComponent"), value);
        }
    }
}