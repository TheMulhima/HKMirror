using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using Touch = InControl.Touch;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Touch class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTouch
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Touch), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<Touch> orig, Touch self)
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

        internal static void Hookget_normalizedPressure()
        {
            if (!HookedList.Contains("get_normalizedPressure"))
            {
                HookedList.Add("get_normalizedPressure");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_normalizedPressure"),
                    get_normalizedPressure);
            }
        }

        internal static event Delegates.get_normalizedPressure_BeforeArgs _beforeget_normalizedPressure;
        internal static event Delegates.get_normalizedPressure_NormalArgs _afterget_normalizedPressure;

        private static float get_normalizedPressure(Func<Touch, float> orig, Touch self)
        {
            Delegates.Params_get_normalizedPressure @params = new()
            {
                self = self
            };
            _beforeget_normalizedPressure?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_normalizedPressure != null) retVal = _afterget_normalizedPressure.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_NormalizedPressure()
        {
            if (!HookedList.Contains("get_NormalizedPressure"))
            {
                HookedList.Add("get_NormalizedPressure");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_NormalizedPressure"),
                    get_NormalizedPressure);
            }
        }

        internal static event Delegates.get_NormalizedPressure_BeforeArgs _beforeget_NormalizedPressure;
        internal static event Delegates.get_NormalizedPressure_NormalArgs _afterget_NormalizedPressure;

        private static float get_NormalizedPressure(Func<Touch, float> orig, Touch self)
        {
            Delegates.Params_get_NormalizedPressure @params = new()
            {
                self = self
            };
            _beforeget_NormalizedPressure?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_NormalizedPressure != null) retVal = _afterget_NormalizedPressure.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_IsMouse()
        {
            if (!HookedList.Contains("get_IsMouse"))
            {
                HookedList.Add("get_IsMouse");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_IsMouse"), get_IsMouse);
            }
        }

        internal static event Delegates.get_IsMouse_BeforeArgs _beforeget_IsMouse;
        internal static event Delegates.get_IsMouse_NormalArgs _afterget_IsMouse;

        private static bool get_IsMouse(Func<Touch, bool> orig, Touch self)
        {
            Delegates.Params_get_IsMouse @params = new()
            {
                self = self
            };
            _beforeget_IsMouse?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsMouse != null) retVal = _afterget_IsMouse.Invoke(@params);
            return retVal;
        }

        internal static void HookSetWithTouchData()
        {
            if (!HookedList.Contains("SetWithTouchData"))
            {
                HookedList.Add("SetWithTouchData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithTouchData"), SetWithTouchData);
            }
        }

        internal static event Delegates.SetWithTouchData_BeforeArgs _beforeSetWithTouchData;
        internal static event Delegates.SetWithTouchData_NormalArgs _afterSetWithTouchData;

        private static void SetWithTouchData(Action<Touch, UnityEngine.Touch, ulong, float> orig, Touch self,
            UnityEngine.Touch touch, ulong updateTick, float deltaTime)
        {
            Delegates.Params_SetWithTouchData @params = new()
            {
                self = self, touch = touch, updateTick = updateTick, deltaTime = deltaTime
            };
            _beforeSetWithTouchData?.Invoke(@params);
            self = @params.self;
            touch = @params.touch;
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            orig(self, touch, updateTick, deltaTime);
            if (_afterSetWithTouchData != null) _afterSetWithTouchData.Invoke(@params);
        }

        internal static void HookSetWithMouseData()
        {
            if (!HookedList.Contains("SetWithMouseData"))
            {
                HookedList.Add("SetWithMouseData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithMouseData"), SetWithMouseData);
            }
        }

        internal static event Delegates.SetWithMouseData_BeforeArgs _beforeSetWithMouseData;
        internal static event Delegates.SetWithMouseData_NormalArgs _afterSetWithMouseData;

        private static bool SetWithMouseData(Func<Touch, int, ulong, float, bool> orig, Touch self, int button,
            ulong updateTick, float deltaTime)
        {
            Delegates.Params_SetWithMouseData @params = new()
            {
                self = self, button = button, updateTick = updateTick, deltaTime = deltaTime
            };
            _beforeSetWithMouseData?.Invoke(@params);
            self = @params.self;
            button = @params.button;
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            var retVal = orig(self, button, updateTick, deltaTime);
            if (_afterSetWithMouseData != null) retVal = _afterSetWithMouseData.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_IsMouse_BeforeArgs(Params_get_IsMouse args);

        public delegate bool get_IsMouse_NormalArgs(Params_get_IsMouse args);

        public delegate void get_normalizedPressure_BeforeArgs(Params_get_normalizedPressure args);

        public delegate void get_NormalizedPressure_BeforeArgs(Params_get_NormalizedPressure args);

        public delegate float get_normalizedPressure_NormalArgs(Params_get_normalizedPressure args);

        public delegate float get_NormalizedPressure_NormalArgs(Params_get_NormalizedPressure args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public delegate void SetWithMouseData_BeforeArgs(Params_SetWithMouseData args);

        public delegate bool SetWithMouseData_NormalArgs(Params_SetWithMouseData args);

        public delegate void SetWithTouchData_BeforeArgs(Params_SetWithTouchData args);

        public delegate void SetWithTouchData_NormalArgs(Params_SetWithTouchData args);

        public sealed class Params_Reset
        {
            public Touch self;
        }

        public sealed class Params_get_normalizedPressure
        {
            public Touch self;
        }

        public sealed class Params_get_NormalizedPressure
        {
            public Touch self;
        }

        public sealed class Params_get_IsMouse
        {
            public Touch self;
        }

        public sealed class Params_SetWithTouchData
        {
            public float deltaTime;
            public Touch self;
            public UnityEngine.Touch touch;
            public ulong updateTick;
        }

        public sealed class Params_SetWithMouseData
        {
            public int button;
            public float deltaTime;
            public Touch self;
            public ulong updateTick;
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

        public static event Delegates.get_normalizedPressure_BeforeArgs get_normalizedPressure
        {
            add
            {
                HookHandler._beforeget_normalizedPressure += value;
                HookHandler.Hookget_normalizedPressure();
            }
            remove => HookHandler._beforeget_normalizedPressure -= value;
        }

        public static event Delegates.get_NormalizedPressure_BeforeArgs get_NormalizedPressure
        {
            add
            {
                HookHandler._beforeget_NormalizedPressure += value;
                HookHandler.Hookget_NormalizedPressure();
            }
            remove => HookHandler._beforeget_NormalizedPressure -= value;
        }

        public static event Delegates.get_IsMouse_BeforeArgs get_IsMouse
        {
            add
            {
                HookHandler._beforeget_IsMouse += value;
                HookHandler.Hookget_IsMouse();
            }
            remove => HookHandler._beforeget_IsMouse -= value;
        }

        public static event Delegates.SetWithTouchData_BeforeArgs SetWithTouchData
        {
            add
            {
                HookHandler._beforeSetWithTouchData += value;
                HookHandler.HookSetWithTouchData();
            }
            remove => HookHandler._beforeSetWithTouchData -= value;
        }

        public static event Delegates.SetWithMouseData_BeforeArgs SetWithMouseData
        {
            add
            {
                HookHandler._beforeSetWithMouseData += value;
                HookHandler.HookSetWithMouseData();
            }
            remove => HookHandler._beforeSetWithMouseData -= value;
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

        public static event Delegates.get_normalizedPressure_NormalArgs get_normalizedPressure
        {
            add
            {
                HookHandler._afterget_normalizedPressure += value;
                HookHandler.Hookget_normalizedPressure();
            }
            remove => HookHandler._afterget_normalizedPressure -= value;
        }

        public static event Delegates.get_NormalizedPressure_NormalArgs get_NormalizedPressure
        {
            add
            {
                HookHandler._afterget_NormalizedPressure += value;
                HookHandler.Hookget_NormalizedPressure();
            }
            remove => HookHandler._afterget_NormalizedPressure -= value;
        }

        public static event Delegates.get_IsMouse_NormalArgs get_IsMouse
        {
            add
            {
                HookHandler._afterget_IsMouse += value;
                HookHandler.Hookget_IsMouse();
            }
            remove => HookHandler._afterget_IsMouse -= value;
        }

        public static event Delegates.SetWithTouchData_NormalArgs SetWithTouchData
        {
            add
            {
                HookHandler._afterSetWithTouchData += value;
                HookHandler.HookSetWithTouchData();
            }
            remove => HookHandler._afterSetWithTouchData -= value;
        }

        public static event Delegates.SetWithMouseData_NormalArgs SetWithMouseData
        {
            add
            {
                HookHandler._afterSetWithMouseData += value;
                HookHandler.HookSetWithMouseData();
            }
            remove => HookHandler._afterSetWithMouseData -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(Touch), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "Reset"), value);
        }

        public static event Delegates.get_normalizedPressure_NormalArgs get_normalizedPressure
        {
            add => HookEndpointManager.Add<Delegates.get_normalizedPressure_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "get_normalizedPressure"), value);
            remove => HookEndpointManager.Remove<Delegates.get_normalizedPressure_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "get_normalizedPressure"), value);
        }

        public static event Delegates.get_NormalizedPressure_NormalArgs get_NormalizedPressure
        {
            add => HookEndpointManager.Add<Delegates.get_NormalizedPressure_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "get_NormalizedPressure"), value);
            remove => HookEndpointManager.Remove<Delegates.get_NormalizedPressure_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "get_NormalizedPressure"), value);
        }

        public static event Delegates.get_IsMouse_NormalArgs get_IsMouse
        {
            add => HookEndpointManager.Add<Delegates.get_IsMouse_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "get_IsMouse"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsMouse_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "get_IsMouse"), value);
        }

        public static event Delegates.SetWithTouchData_NormalArgs SetWithTouchData
        {
            add => HookEndpointManager.Add<Delegates.SetWithTouchData_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithTouchData"), value);
            remove => HookEndpointManager.Remove<Delegates.SetWithTouchData_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithTouchData"), value);
        }

        public static event Delegates.SetWithMouseData_NormalArgs SetWithMouseData
        {
            add => HookEndpointManager.Add<Delegates.SetWithMouseData_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithMouseData"), value);
            remove => HookEndpointManager.Remove<Delegates.SetWithMouseData_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithMouseData"), value);
        }
    }
}