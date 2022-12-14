using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ScaleTo class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnScaleTo
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<ScaleTo> orig, ScaleTo self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<ScaleTo> orig, ScaleTo self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<ScaleTo> orig, ScaleTo self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdateScaling()
        {
            if (!HookedList.Contains("UpdateScaling"))
            {
                HookedList.Add("UpdateScaling");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "UpdateScaling"), UpdateScaling);
            }
        }

        internal static event Delegates.UpdateScaling_BeforeArgs _beforeUpdateScaling;
        internal static event Delegates.UpdateScaling_AfterArgs _afterUpdateScaling;

        private static void UpdateScaling(Action<ScaleTo> orig, ScaleTo self)
        {
            Delegates.Params_UpdateScaling @params = new()
            {
                self = self
            };
            if (_beforeUpdateScaling != null)
                foreach (Delegates.UpdateScaling_BeforeArgs toInvoke in _beforeUpdateScaling.GetInvocationList())
                    try
                    {
                        _beforeUpdateScaling?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateScaling != null)
                foreach (Delegates.UpdateScaling_AfterArgs toInvoke in _afterUpdateScaling.GetInvocationList())
                    try
                    {
                        _afterUpdateScaling.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetCurved()
        {
            if (!HookedList.Contains("GetCurved"))
            {
                HookedList.Add("GetCurved");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "GetCurved", false), GetCurved);
            }
        }

        internal static event Delegates.GetCurved_BeforeArgs _beforeGetCurved;
        internal static event Delegates.GetCurved_AfterArgs _afterGetCurved;

        private static float GetCurved(Func<float, ScaleToCurves, float> orig, float val, ScaleToCurves curve)
        {
            Delegates.Params_GetCurved @params = new()
            {
                val = val, curve = curve
            };
            if (_beforeGetCurved != null)
                foreach (Delegates.GetCurved_BeforeArgs toInvoke in _beforeGetCurved.GetInvocationList())
                    try
                    {
                        _beforeGetCurved?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            val = @params.val;
            curve = @params.curve;
            var retVal = orig(val, curve);
            if (_afterGetCurved != null)
                foreach (Delegates.GetCurved_AfterArgs toInvoke in _afterGetCurved.GetInvocationList())
                    try
                    {
                        retVal = _afterGetCurved.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookLinear()
        {
            if (!HookedList.Contains("Linear"))
            {
                HookedList.Add("Linear");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Linear", false), Linear);
            }
        }

        internal static event Delegates.Linear_BeforeArgs _beforeLinear;
        internal static event Delegates.Linear_AfterArgs _afterLinear;

        private static float Linear(Func<float, float> orig, float val)
        {
            Delegates.Params_Linear @params = new()
            {
                val = val
            };
            if (_beforeLinear != null)
                foreach (Delegates.Linear_BeforeArgs toInvoke in _beforeLinear.GetInvocationList())
                    try
                    {
                        _beforeLinear?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            val = @params.val;
            var retVal = orig(val);
            if (_afterLinear != null)
                foreach (Delegates.Linear_AfterArgs toInvoke in _afterLinear.GetInvocationList())
                    try
                    {
                        retVal = _afterLinear.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookQuadraticOut()
        {
            if (!HookedList.Contains("QuadraticOut"))
            {
                HookedList.Add("QuadraticOut");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "QuadraticOut", false), QuadraticOut);
            }
        }

        internal static event Delegates.QuadraticOut_BeforeArgs _beforeQuadraticOut;
        internal static event Delegates.QuadraticOut_AfterArgs _afterQuadraticOut;

        private static float QuadraticOut(Func<float, float> orig, float val)
        {
            Delegates.Params_QuadraticOut @params = new()
            {
                val = val
            };
            if (_beforeQuadraticOut != null)
                foreach (Delegates.QuadraticOut_BeforeArgs toInvoke in _beforeQuadraticOut.GetInvocationList())
                    try
                    {
                        _beforeQuadraticOut?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            val = @params.val;
            var retVal = orig(val);
            if (_afterQuadraticOut != null)
                foreach (Delegates.QuadraticOut_AfterArgs toInvoke in _afterQuadraticOut.GetInvocationList())
                    try
                    {
                        retVal = _afterQuadraticOut.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookSinusoidalOut()
        {
            if (!HookedList.Contains("SinusoidalOut"))
            {
                HookedList.Add("SinusoidalOut");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "SinusoidalOut", false), SinusoidalOut);
            }
        }

        internal static event Delegates.SinusoidalOut_BeforeArgs _beforeSinusoidalOut;
        internal static event Delegates.SinusoidalOut_AfterArgs _afterSinusoidalOut;

        private static float SinusoidalOut(Func<float, float> orig, float val)
        {
            Delegates.Params_SinusoidalOut @params = new()
            {
                val = val
            };
            if (_beforeSinusoidalOut != null)
                foreach (Delegates.SinusoidalOut_BeforeArgs toInvoke in _beforeSinusoidalOut.GetInvocationList())
                    try
                    {
                        _beforeSinusoidalOut?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            val = @params.val;
            var retVal = orig(val);
            if (_afterSinusoidalOut != null)
                foreach (Delegates.SinusoidalOut_AfterArgs toInvoke in _afterSinusoidalOut.GetInvocationList())
                    try
                    {
                        retVal = _afterSinusoidalOut.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate float GetCurved_AfterArgs(Params_GetCurved args, float ret);

        public delegate void GetCurved_BeforeArgs(Params_GetCurved args);

        public delegate float GetCurved_WithArgs(Func<float, ScaleToCurves, float> orig, float val,
            ScaleToCurves curve);

        public delegate float Linear_AfterArgs(Params_Linear args, float ret);

        public delegate void Linear_BeforeArgs(Params_Linear args);

        public delegate float Linear_WithArgs(Func<float, float> orig, float val);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<ScaleTo> orig, ScaleTo self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<ScaleTo> orig, ScaleTo self);

        public delegate float QuadraticOut_AfterArgs(Params_QuadraticOut args, float ret);

        public delegate void QuadraticOut_BeforeArgs(Params_QuadraticOut args);

        public delegate float QuadraticOut_WithArgs(Func<float, float> orig, float val);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<ScaleTo> orig, ScaleTo self);

        public delegate float SinusoidalOut_AfterArgs(Params_SinusoidalOut args, float ret);

        public delegate void SinusoidalOut_BeforeArgs(Params_SinusoidalOut args);

        public delegate float SinusoidalOut_WithArgs(Func<float, float> orig, float val);

        public delegate void UpdateScaling_AfterArgs(Params_UpdateScaling args);

        public delegate void UpdateScaling_BeforeArgs(Params_UpdateScaling args);

        public delegate void UpdateScaling_WithArgs(Action<ScaleTo> orig, ScaleTo self);

        public sealed class Params_Reset
        {
            public ScaleTo self;
        }

        public sealed class Params_OnEnter
        {
            public ScaleTo self;
        }

        public sealed class Params_OnUpdate
        {
            public ScaleTo self;
        }

        public sealed class Params_UpdateScaling
        {
            public ScaleTo self;
        }

        public sealed class Params_GetCurved
        {
            public ScaleToCurves curve;
            public float val;
        }

        public sealed class Params_Linear
        {
            public float val;
        }

        public sealed class Params_QuadraticOut
        {
            public float val;
        }

        public sealed class Params_SinusoidalOut
        {
            public float val;
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

        public static event Delegates.UpdateScaling_BeforeArgs UpdateScaling
        {
            add
            {
                HookHandler._beforeUpdateScaling += value;
                HookHandler.HookUpdateScaling();
            }
            remove => HookHandler._beforeUpdateScaling -= value;
        }

        public static event Delegates.GetCurved_BeforeArgs GetCurved
        {
            add
            {
                HookHandler._beforeGetCurved += value;
                HookHandler.HookGetCurved();
            }
            remove => HookHandler._beforeGetCurved -= value;
        }

        public static event Delegates.Linear_BeforeArgs Linear
        {
            add
            {
                HookHandler._beforeLinear += value;
                HookHandler.HookLinear();
            }
            remove => HookHandler._beforeLinear -= value;
        }

        public static event Delegates.QuadraticOut_BeforeArgs QuadraticOut
        {
            add
            {
                HookHandler._beforeQuadraticOut += value;
                HookHandler.HookQuadraticOut();
            }
            remove => HookHandler._beforeQuadraticOut -= value;
        }

        public static event Delegates.SinusoidalOut_BeforeArgs SinusoidalOut
        {
            add
            {
                HookHandler._beforeSinusoidalOut += value;
                HookHandler.HookSinusoidalOut();
            }
            remove => HookHandler._beforeSinusoidalOut -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.UpdateScaling_AfterArgs UpdateScaling
        {
            add
            {
                HookHandler._afterUpdateScaling += value;
                HookHandler.HookUpdateScaling();
            }
            remove => HookHandler._afterUpdateScaling -= value;
        }

        public static event Delegates.GetCurved_AfterArgs GetCurved
        {
            add
            {
                HookHandler._afterGetCurved += value;
                HookHandler.HookGetCurved();
            }
            remove => HookHandler._afterGetCurved -= value;
        }

        public static event Delegates.Linear_AfterArgs Linear
        {
            add
            {
                HookHandler._afterLinear += value;
                HookHandler.HookLinear();
            }
            remove => HookHandler._afterLinear -= value;
        }

        public static event Delegates.QuadraticOut_AfterArgs QuadraticOut
        {
            add
            {
                HookHandler._afterQuadraticOut += value;
                HookHandler.HookQuadraticOut();
            }
            remove => HookHandler._afterQuadraticOut -= value;
        }

        public static event Delegates.SinusoidalOut_AfterArgs SinusoidalOut
        {
            add
            {
                HookHandler._afterSinusoidalOut += value;
                HookHandler.HookSinusoidalOut();
            }
            remove => HookHandler._afterSinusoidalOut -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnUpdate"), value);
        }

        public static event Delegates.UpdateScaling_WithArgs UpdateScaling
        {
            add => HookEndpointManager.Add<Delegates.UpdateScaling_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "UpdateScaling"), value);
            remove => HookEndpointManager.Remove<Delegates.UpdateScaling_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "UpdateScaling"), value);
        }

        public static event Delegates.GetCurved_WithArgs GetCurved
        {
            add => HookEndpointManager.Add<Delegates.GetCurved_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "GetCurved", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetCurved_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "GetCurved", false), value);
        }

        public static event Delegates.Linear_WithArgs Linear
        {
            add => HookEndpointManager.Add<Delegates.Linear_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Linear", false), value);
            remove => HookEndpointManager.Remove<Delegates.Linear_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Linear", false), value);
        }

        public static event Delegates.QuadraticOut_WithArgs QuadraticOut
        {
            add => HookEndpointManager.Add<Delegates.QuadraticOut_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "QuadraticOut", false), value);
            remove => HookEndpointManager.Remove<Delegates.QuadraticOut_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "QuadraticOut", false), value);
        }

        public static event Delegates.SinusoidalOut_WithArgs SinusoidalOut
        {
            add => HookEndpointManager.Add<Delegates.SinusoidalOut_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "SinusoidalOut", false), value);
            remove => HookEndpointManager.Remove<Delegates.SinusoidalOut_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "SinusoidalOut", false), value);
        }
    }
}