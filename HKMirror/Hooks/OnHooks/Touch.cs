using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for Touch class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTouch
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "Reset", true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<InControl.Touch> orig, InControl.Touch self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_normalizedPressure()
        {
            if (!HookedList.Contains("get_normalizedPressure"))
            {
                HookedList.Add("get_normalizedPressure");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_normalizedPressure", true),
                    get_normalizedPressure);
            }
        }

        internal static event Delegates.get_normalizedPressure_BeforeArgs _beforeget_normalizedPressure;
        internal static event Delegates.get_normalizedPressure_AfterArgs _afterget_normalizedPressure;

        private static float get_normalizedPressure(Func<InControl.Touch, float> orig, InControl.Touch self)
        {
            Delegates.Params_get_normalizedPressure @params = new()
            {
                self = self
            };
            if (_beforeget_normalizedPressure != null)
            {
                foreach (Delegates.get_normalizedPressure_BeforeArgs toInvoke in _beforeget_normalizedPressure
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_normalizedPressure?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_normalizedPressure != null)
            {
                foreach (Delegates.get_normalizedPressure_AfterArgs toInvoke in _afterget_normalizedPressure
                             .GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_normalizedPressure.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_NormalizedPressure()
        {
            if (!HookedList.Contains("get_NormalizedPressure"))
            {
                HookedList.Add("get_NormalizedPressure");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_NormalizedPressure", true),
                    get_NormalizedPressure);
            }
        }

        internal static event Delegates.get_NormalizedPressure_BeforeArgs _beforeget_NormalizedPressure;
        internal static event Delegates.get_NormalizedPressure_AfterArgs _afterget_NormalizedPressure;

        private static float get_NormalizedPressure(Func<InControl.Touch, float> orig, InControl.Touch self)
        {
            Delegates.Params_get_NormalizedPressure @params = new()
            {
                self = self
            };
            if (_beforeget_NormalizedPressure != null)
            {
                foreach (Delegates.get_NormalizedPressure_BeforeArgs toInvoke in _beforeget_NormalizedPressure
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_NormalizedPressure?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_NormalizedPressure != null)
            {
                foreach (Delegates.get_NormalizedPressure_AfterArgs toInvoke in _afterget_NormalizedPressure
                             .GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_NormalizedPressure.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_IsMouse()
        {
            if (!HookedList.Contains("get_IsMouse"))
            {
                HookedList.Add("get_IsMouse");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_IsMouse", true), get_IsMouse);
            }
        }

        internal static event Delegates.get_IsMouse_BeforeArgs _beforeget_IsMouse;
        internal static event Delegates.get_IsMouse_AfterArgs _afterget_IsMouse;

        private static bool get_IsMouse(Func<InControl.Touch, bool> orig, InControl.Touch self)
        {
            Delegates.Params_get_IsMouse @params = new()
            {
                self = self
            };
            if (_beforeget_IsMouse != null)
            {
                foreach (Delegates.get_IsMouse_BeforeArgs toInvoke in _beforeget_IsMouse.GetInvocationList())
                {
                    try
                    {
                        _beforeget_IsMouse?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsMouse != null)
            {
                foreach (Delegates.get_IsMouse_AfterArgs toInvoke in _afterget_IsMouse.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_IsMouse.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookSetWithTouchData()
        {
            if (!HookedList.Contains("SetWithTouchData"))
            {
                HookedList.Add("SetWithTouchData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "SetWithTouchData", true),
                    SetWithTouchData);
            }
        }

        internal static event Delegates.SetWithTouchData_BeforeArgs _beforeSetWithTouchData;
        internal static event Delegates.SetWithTouchData_AfterArgs _afterSetWithTouchData;

        private static void SetWithTouchData(Action<InControl.Touch, UnityEngine.Touch, ulong, float> orig,
            InControl.Touch self, UnityEngine.Touch touch, ulong updateTick, float deltaTime)
        {
            Delegates.Params_SetWithTouchData @params = new()
            {
                self = self, touch = touch, updateTick = updateTick, deltaTime = deltaTime
            };
            if (_beforeSetWithTouchData != null)
            {
                foreach (Delegates.SetWithTouchData_BeforeArgs toInvoke in _beforeSetWithTouchData.GetInvocationList())
                {
                    try
                    {
                        _beforeSetWithTouchData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            touch = @params.touch;
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            orig(self, touch, updateTick, deltaTime);
            if (_afterSetWithTouchData != null)
            {
                foreach (Delegates.SetWithTouchData_AfterArgs toInvoke in _afterSetWithTouchData.GetInvocationList())
                {
                    try
                    {
                        _afterSetWithTouchData.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSetWithMouseData()
        {
            if (!HookedList.Contains("SetWithMouseData"))
            {
                HookedList.Add("SetWithMouseData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "SetWithMouseData", true),
                    SetWithMouseData);
            }
        }

        internal static event Delegates.SetWithMouseData_BeforeArgs _beforeSetWithMouseData;
        internal static event Delegates.SetWithMouseData_AfterArgs _afterSetWithMouseData;

        private static bool SetWithMouseData(Func<InControl.Touch, int, ulong, float, bool> orig, InControl.Touch self,
            int button, ulong updateTick, float deltaTime)
        {
            Delegates.Params_SetWithMouseData @params = new()
            {
                self = self, button = button, updateTick = updateTick, deltaTime = deltaTime
            };
            if (_beforeSetWithMouseData != null)
            {
                foreach (Delegates.SetWithMouseData_BeforeArgs toInvoke in _beforeSetWithMouseData.GetInvocationList())
                {
                    try
                    {
                        _beforeSetWithMouseData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            button = @params.button;
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            var retVal = orig(self, button, updateTick, deltaTime);
            if (_afterSetWithMouseData != null)
            {
                foreach (Delegates.SetWithMouseData_AfterArgs toInvoke in _afterSetWithMouseData.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterSetWithMouseData.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Reset
        {
            public InControl.Touch self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<InControl.Touch> orig, InControl.Touch self);

        public sealed class Params_get_normalizedPressure
        {
            public InControl.Touch self;
        }

        public delegate void get_normalizedPressure_BeforeArgs(Params_get_normalizedPressure args);

        public delegate float get_normalizedPressure_AfterArgs(Params_get_normalizedPressure args, float ret);

        public delegate float get_normalizedPressure_WithArgs(Func<InControl.Touch, float> orig, InControl.Touch self);

        public sealed class Params_get_NormalizedPressure
        {
            public InControl.Touch self;
        }

        public delegate void get_NormalizedPressure_BeforeArgs(Params_get_NormalizedPressure args);

        public delegate float get_NormalizedPressure_AfterArgs(Params_get_NormalizedPressure args, float ret);

        public delegate float get_NormalizedPressure_WithArgs(Func<InControl.Touch, float> orig, InControl.Touch self);

        public sealed class Params_get_IsMouse
        {
            public InControl.Touch self;
        }

        public delegate void get_IsMouse_BeforeArgs(Params_get_IsMouse args);

        public delegate bool get_IsMouse_AfterArgs(Params_get_IsMouse args, bool ret);

        public delegate bool get_IsMouse_WithArgs(Func<InControl.Touch, bool> orig, InControl.Touch self);

        public sealed class Params_SetWithTouchData
        {
            public InControl.Touch self;
            public UnityEngine.Touch touch;
            public ulong updateTick;
            public float deltaTime;
        }

        public delegate void SetWithTouchData_BeforeArgs(Params_SetWithTouchData args);

        public delegate void SetWithTouchData_AfterArgs(Params_SetWithTouchData args);

        public delegate void SetWithTouchData_WithArgs(Action<InControl.Touch, UnityEngine.Touch, ulong, float> orig,
            InControl.Touch self, UnityEngine.Touch touch, ulong updateTick, float deltaTime);

        public sealed class Params_SetWithMouseData
        {
            public InControl.Touch self;
            public int button;
            public ulong updateTick;
            public float deltaTime;
        }

        public delegate void SetWithMouseData_BeforeArgs(Params_SetWithMouseData args);

        public delegate bool SetWithMouseData_AfterArgs(Params_SetWithMouseData args, bool ret);

        public delegate bool SetWithMouseData_WithArgs(Func<InControl.Touch, int, ulong, float, bool> orig,
            InControl.Touch self, int button, ulong updateTick, float deltaTime);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.get_normalizedPressure_AfterArgs get_normalizedPressure
        {
            add
            {
                HookHandler._afterget_normalizedPressure += value;
                HookHandler.Hookget_normalizedPressure();
            }
            remove => HookHandler._afterget_normalizedPressure -= value;
        }

        public static event Delegates.get_NormalizedPressure_AfterArgs get_NormalizedPressure
        {
            add
            {
                HookHandler._afterget_NormalizedPressure += value;
                HookHandler.Hookget_NormalizedPressure();
            }
            remove => HookHandler._afterget_NormalizedPressure -= value;
        }

        public static event Delegates.get_IsMouse_AfterArgs get_IsMouse
        {
            add
            {
                HookHandler._afterget_IsMouse += value;
                HookHandler.Hookget_IsMouse();
            }
            remove => HookHandler._afterget_IsMouse -= value;
        }

        public static event Delegates.SetWithTouchData_AfterArgs SetWithTouchData
        {
            add
            {
                HookHandler._afterSetWithTouchData += value;
                HookHandler.HookSetWithTouchData();
            }
            remove => HookHandler._afterSetWithTouchData -= value;
        }

        public static event Delegates.SetWithMouseData_AfterArgs SetWithMouseData
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
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "Reset", true), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "Reset", true), value);
        }

        public static event Delegates.get_normalizedPressure_WithArgs get_normalizedPressure
        {
            add => HookEndpointManager.Add<Delegates.get_normalizedPressure_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_normalizedPressure", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_normalizedPressure_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_normalizedPressure", true), value);
        }

        public static event Delegates.get_NormalizedPressure_WithArgs get_NormalizedPressure
        {
            add => HookEndpointManager.Add<Delegates.get_NormalizedPressure_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_NormalizedPressure", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_NormalizedPressure_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_NormalizedPressure", true), value);
        }

        public static event Delegates.get_IsMouse_WithArgs get_IsMouse
        {
            add => HookEndpointManager.Add<Delegates.get_IsMouse_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_IsMouse", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsMouse_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "get_IsMouse", true), value);
        }

        public static event Delegates.SetWithTouchData_WithArgs SetWithTouchData
        {
            add => HookEndpointManager.Add<Delegates.SetWithTouchData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "SetWithTouchData", true), value);
            remove => HookEndpointManager.Remove<Delegates.SetWithTouchData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "SetWithTouchData", true), value);
        }

        public static event Delegates.SetWithMouseData_WithArgs SetWithMouseData
        {
            add => HookEndpointManager.Add<Delegates.SetWithMouseData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "SetWithMouseData", true), value);
            remove => HookEndpointManager.Remove<Delegates.SetWithMouseData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Touch), "SetWithMouseData", true), value);
        }
    }
}