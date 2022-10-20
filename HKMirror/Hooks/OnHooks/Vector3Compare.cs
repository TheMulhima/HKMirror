using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Vector3Compare class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnVector3Compare
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<Vector3Compare> orig, Vector3Compare self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<Vector3Compare> orig, Vector3Compare self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<Vector3Compare> orig, Vector3Compare self)
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

        internal static void HookDoCompare()
        {
            if (!HookedList.Contains("DoCompare"))
            {
                HookedList.Add("DoCompare");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "DoCompare"), DoCompare);
            }
        }

        internal static event Delegates.DoCompare_BeforeArgs _beforeDoCompare;
        internal static event Delegates.DoCompare_NormalArgs _afterDoCompare;

        private static void DoCompare(Action<Vector3Compare> orig, Vector3Compare self)
        {
            Delegates.Params_DoCompare @params = new()
            {
                self = self
            };
            _beforeDoCompare?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoCompare != null) _afterDoCompare.Invoke(@params);
        }

        internal static void HookErrorCheck()
        {
            if (!HookedList.Contains("ErrorCheck"))
            {
                HookedList.Add("ErrorCheck");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "ErrorCheck"), ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_NormalArgs _afterErrorCheck;

        private static string ErrorCheck(Func<Vector3Compare, string> orig, Vector3Compare self)
        {
            Delegates.Params_ErrorCheck @params = new()
            {
                self = self
            };
            _beforeErrorCheck?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterErrorCheck != null) retVal = _afterErrorCheck.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoCompare_BeforeArgs(Params_DoCompare args);

        public delegate void DoCompare_NormalArgs(Params_DoCompare args);

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_NormalArgs(Params_ErrorCheck args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public Vector3Compare self;
        }

        public sealed class Params_OnEnter
        {
            public Vector3Compare self;
        }

        public sealed class Params_OnUpdate
        {
            public Vector3Compare self;
        }

        public sealed class Params_DoCompare
        {
            public Vector3Compare self;
        }

        public sealed class Params_ErrorCheck
        {
            public Vector3Compare self;
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

        public static event Delegates.DoCompare_BeforeArgs DoCompare
        {
            add
            {
                HookHandler._beforeDoCompare += value;
                HookHandler.HookDoCompare();
            }
            remove => HookHandler._beforeDoCompare -= value;
        }

        public static event Delegates.ErrorCheck_BeforeArgs ErrorCheck
        {
            add
            {
                HookHandler._beforeErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._beforeErrorCheck -= value;
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

        public static event Delegates.DoCompare_NormalArgs DoCompare
        {
            add
            {
                HookHandler._afterDoCompare += value;
                HookHandler.HookDoCompare();
            }
            remove => HookHandler._afterDoCompare -= value;
        }

        public static event Delegates.ErrorCheck_NormalArgs ErrorCheck
        {
            add
            {
                HookHandler._afterErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._afterErrorCheck -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "OnUpdate"), value);
        }

        public static event Delegates.DoCompare_NormalArgs DoCompare
        {
            add => HookEndpointManager.Add<Delegates.DoCompare_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "DoCompare"), value);
            remove => HookEndpointManager.Remove<Delegates.DoCompare_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "DoCompare"), value);
        }

        public static event Delegates.ErrorCheck_NormalArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "ErrorCheck"), value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector3Compare), "ErrorCheck"), value);
        }
    }
}