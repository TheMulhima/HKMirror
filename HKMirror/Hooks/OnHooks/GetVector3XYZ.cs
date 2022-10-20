using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetVector3XYZ class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetVector3XYZ
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<GetVector3XYZ> orig, GetVector3XYZ self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<GetVector3XYZ> orig, GetVector3XYZ self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<GetVector3XYZ> orig, GetVector3XYZ self)
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

        internal static void HookDoGetVector3XYZ()
        {
            if (!HookedList.Contains("DoGetVector3XYZ"))
            {
                HookedList.Add("DoGetVector3XYZ");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "DoGetVector3XYZ"), DoGetVector3XYZ);
            }
        }

        internal static event Delegates.DoGetVector3XYZ_BeforeArgs _beforeDoGetVector3XYZ;
        internal static event Delegates.DoGetVector3XYZ_NormalArgs _afterDoGetVector3XYZ;

        private static void DoGetVector3XYZ(Action<GetVector3XYZ> orig, GetVector3XYZ self)
        {
            Delegates.Params_DoGetVector3XYZ @params = new()
            {
                self = self
            };
            _beforeDoGetVector3XYZ?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoGetVector3XYZ != null) _afterDoGetVector3XYZ.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoGetVector3XYZ_BeforeArgs(Params_DoGetVector3XYZ args);

        public delegate void DoGetVector3XYZ_NormalArgs(Params_DoGetVector3XYZ args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public GetVector3XYZ self;
        }

        public sealed class Params_OnEnter
        {
            public GetVector3XYZ self;
        }

        public sealed class Params_OnUpdate
        {
            public GetVector3XYZ self;
        }

        public sealed class Params_DoGetVector3XYZ
        {
            public GetVector3XYZ self;
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

        public static event Delegates.DoGetVector3XYZ_BeforeArgs DoGetVector3XYZ
        {
            add
            {
                HookHandler._beforeDoGetVector3XYZ += value;
                HookHandler.HookDoGetVector3XYZ();
            }
            remove => HookHandler._beforeDoGetVector3XYZ -= value;
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

        public static event Delegates.DoGetVector3XYZ_NormalArgs DoGetVector3XYZ
        {
            add
            {
                HookHandler._afterDoGetVector3XYZ += value;
                HookHandler.HookDoGetVector3XYZ();
            }
            remove => HookHandler._afterDoGetVector3XYZ -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "OnUpdate"), value);
        }

        public static event Delegates.DoGetVector3XYZ_NormalArgs DoGetVector3XYZ
        {
            add => HookEndpointManager.Add<Delegates.DoGetVector3XYZ_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "DoGetVector3XYZ"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetVector3XYZ_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetVector3XYZ), "DoGetVector3XYZ"), value);
        }
    }
}