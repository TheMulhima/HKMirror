using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Vector3AddXYZ class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnVector3AddXYZ
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<Vector3AddXYZ> orig, Vector3AddXYZ self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<Vector3AddXYZ> orig, Vector3AddXYZ self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<Vector3AddXYZ> orig, Vector3AddXYZ self)
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

        internal static void HookDoVector3AddXYZ()
        {
            if (!HookedList.Contains("DoVector3AddXYZ"))
            {
                HookedList.Add("DoVector3AddXYZ");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "DoVector3AddXYZ"), DoVector3AddXYZ);
            }
        }

        internal static event Delegates.DoVector3AddXYZ_BeforeArgs _beforeDoVector3AddXYZ;
        internal static event Delegates.DoVector3AddXYZ_NormalArgs _afterDoVector3AddXYZ;

        private static void DoVector3AddXYZ(Action<Vector3AddXYZ> orig, Vector3AddXYZ self)
        {
            Delegates.Params_DoVector3AddXYZ @params = new()
            {
                self = self
            };
            _beforeDoVector3AddXYZ?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoVector3AddXYZ != null) _afterDoVector3AddXYZ.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoVector3AddXYZ_BeforeArgs(Params_DoVector3AddXYZ args);

        public delegate void DoVector3AddXYZ_NormalArgs(Params_DoVector3AddXYZ args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public Vector3AddXYZ self;
        }

        public sealed class Params_OnEnter
        {
            public Vector3AddXYZ self;
        }

        public sealed class Params_OnUpdate
        {
            public Vector3AddXYZ self;
        }

        public sealed class Params_DoVector3AddXYZ
        {
            public Vector3AddXYZ self;
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

        public static event Delegates.DoVector3AddXYZ_BeforeArgs DoVector3AddXYZ
        {
            add
            {
                HookHandler._beforeDoVector3AddXYZ += value;
                HookHandler.HookDoVector3AddXYZ();
            }
            remove => HookHandler._beforeDoVector3AddXYZ -= value;
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

        public static event Delegates.DoVector3AddXYZ_NormalArgs DoVector3AddXYZ
        {
            add
            {
                HookHandler._afterDoVector3AddXYZ += value;
                HookHandler.HookDoVector3AddXYZ();
            }
            remove => HookHandler._afterDoVector3AddXYZ -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "OnUpdate"), value);
        }

        public static event Delegates.DoVector3AddXYZ_NormalArgs DoVector3AddXYZ
        {
            add => HookEndpointManager.Add<Delegates.DoVector3AddXYZ_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "DoVector3AddXYZ"), value);
            remove => HookEndpointManager.Remove<Delegates.DoVector3AddXYZ_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3AddXYZ), "DoVector3AddXYZ"), value);
        }
    }
}