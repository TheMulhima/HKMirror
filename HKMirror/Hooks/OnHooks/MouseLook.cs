using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MouseLook class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMouseLook
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MouseLook), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<MouseLook> orig, MouseLook self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MouseLook), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<MouseLook> orig, MouseLook self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MouseLook), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<MouseLook> orig, MouseLook self)
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

        internal static void HookDoMouseLook()
        {
            if (!HookedList.Contains("DoMouseLook"))
            {
                HookedList.Add("DoMouseLook");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MouseLook), "DoMouseLook"), DoMouseLook);
            }
        }

        internal static event Delegates.DoMouseLook_BeforeArgs _beforeDoMouseLook;
        internal static event Delegates.DoMouseLook_AfterArgs _afterDoMouseLook;

        private static void DoMouseLook(Action<MouseLook> orig, MouseLook self)
        {
            Delegates.Params_DoMouseLook @params = new()
            {
                self = self
            };
            if (_beforeDoMouseLook != null)
                foreach (Delegates.DoMouseLook_BeforeArgs toInvoke in _beforeDoMouseLook.GetInvocationList())
                    try
                    {
                        _beforeDoMouseLook?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoMouseLook != null)
                foreach (Delegates.DoMouseLook_AfterArgs toInvoke in _afterDoMouseLook.GetInvocationList())
                    try
                    {
                        _afterDoMouseLook.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetXRotation()
        {
            if (!HookedList.Contains("GetXRotation"))
            {
                HookedList.Add("GetXRotation");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MouseLook), "GetXRotation"), GetXRotation);
            }
        }

        internal static event Delegates.GetXRotation_BeforeArgs _beforeGetXRotation;
        internal static event Delegates.GetXRotation_AfterArgs _afterGetXRotation;

        private static float GetXRotation(Func<MouseLook, float> orig, MouseLook self)
        {
            Delegates.Params_GetXRotation @params = new()
            {
                self = self
            };
            if (_beforeGetXRotation != null)
                foreach (Delegates.GetXRotation_BeforeArgs toInvoke in _beforeGetXRotation.GetInvocationList())
                    try
                    {
                        _beforeGetXRotation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetXRotation != null)
                foreach (Delegates.GetXRotation_AfterArgs toInvoke in _afterGetXRotation.GetInvocationList())
                    try
                    {
                        retVal = _afterGetXRotation.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetYRotation()
        {
            if (!HookedList.Contains("GetYRotation"))
            {
                HookedList.Add("GetYRotation");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MouseLook), "GetYRotation"), GetYRotation);
            }
        }

        internal static event Delegates.GetYRotation_BeforeArgs _beforeGetYRotation;
        internal static event Delegates.GetYRotation_AfterArgs _afterGetYRotation;

        private static float GetYRotation(Func<MouseLook, float> orig, MouseLook self)
        {
            Delegates.Params_GetYRotation @params = new()
            {
                self = self
            };
            if (_beforeGetYRotation != null)
                foreach (Delegates.GetYRotation_BeforeArgs toInvoke in _beforeGetYRotation.GetInvocationList())
                    try
                    {
                        _beforeGetYRotation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetYRotation != null)
                foreach (Delegates.GetYRotation_AfterArgs toInvoke in _afterGetYRotation.GetInvocationList())
                    try
                    {
                        retVal = _afterGetYRotation.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookClampAngle()
        {
            if (!HookedList.Contains("ClampAngle"))
            {
                HookedList.Add("ClampAngle");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MouseLook), "ClampAngle", false), ClampAngle);
            }
        }

        internal static event Delegates.ClampAngle_BeforeArgs _beforeClampAngle;
        internal static event Delegates.ClampAngle_AfterArgs _afterClampAngle;

        private static float ClampAngle(Func<float, FsmFloat, FsmFloat, float> orig, float angle, FsmFloat min,
            FsmFloat max)
        {
            Delegates.Params_ClampAngle @params = new()
            {
                angle = angle, min = min, max = max
            };
            if (_beforeClampAngle != null)
                foreach (Delegates.ClampAngle_BeforeArgs toInvoke in _beforeClampAngle.GetInvocationList())
                    try
                    {
                        _beforeClampAngle?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            angle = @params.angle;
            min = @params.min;
            max = @params.max;
            var retVal = orig(angle, min, max);
            if (_afterClampAngle != null)
                foreach (Delegates.ClampAngle_AfterArgs toInvoke in _afterClampAngle.GetInvocationList())
                    try
                    {
                        retVal = _afterClampAngle.Invoke(@params, retVal);
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
        public delegate float ClampAngle_AfterArgs(Params_ClampAngle args, float ret);

        public delegate void ClampAngle_BeforeArgs(Params_ClampAngle args);

        public delegate float ClampAngle_WithArgs(Func<float, FsmFloat, FsmFloat, float> orig, float angle,
            FsmFloat min, FsmFloat max);

        public delegate void DoMouseLook_AfterArgs(Params_DoMouseLook args);

        public delegate void DoMouseLook_BeforeArgs(Params_DoMouseLook args);

        public delegate void DoMouseLook_WithArgs(Action<MouseLook> orig, MouseLook self);

        public delegate float GetXRotation_AfterArgs(Params_GetXRotation args, float ret);

        public delegate void GetXRotation_BeforeArgs(Params_GetXRotation args);

        public delegate float GetXRotation_WithArgs(Func<MouseLook, float> orig, MouseLook self);

        public delegate float GetYRotation_AfterArgs(Params_GetYRotation args, float ret);

        public delegate void GetYRotation_BeforeArgs(Params_GetYRotation args);

        public delegate float GetYRotation_WithArgs(Func<MouseLook, float> orig, MouseLook self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<MouseLook> orig, MouseLook self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<MouseLook> orig, MouseLook self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<MouseLook> orig, MouseLook self);

        public sealed class Params_Reset
        {
            public MouseLook self;
        }

        public sealed class Params_OnEnter
        {
            public MouseLook self;
        }

        public sealed class Params_OnUpdate
        {
            public MouseLook self;
        }

        public sealed class Params_DoMouseLook
        {
            public MouseLook self;
        }

        public sealed class Params_GetXRotation
        {
            public MouseLook self;
        }

        public sealed class Params_GetYRotation
        {
            public MouseLook self;
        }

        public sealed class Params_ClampAngle
        {
            public float angle;
            public FsmFloat max;
            public FsmFloat min;
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

        public static event Delegates.DoMouseLook_BeforeArgs DoMouseLook
        {
            add
            {
                HookHandler._beforeDoMouseLook += value;
                HookHandler.HookDoMouseLook();
            }
            remove => HookHandler._beforeDoMouseLook -= value;
        }

        public static event Delegates.GetXRotation_BeforeArgs GetXRotation
        {
            add
            {
                HookHandler._beforeGetXRotation += value;
                HookHandler.HookGetXRotation();
            }
            remove => HookHandler._beforeGetXRotation -= value;
        }

        public static event Delegates.GetYRotation_BeforeArgs GetYRotation
        {
            add
            {
                HookHandler._beforeGetYRotation += value;
                HookHandler.HookGetYRotation();
            }
            remove => HookHandler._beforeGetYRotation -= value;
        }

        public static event Delegates.ClampAngle_BeforeArgs ClampAngle
        {
            add
            {
                HookHandler._beforeClampAngle += value;
                HookHandler.HookClampAngle();
            }
            remove => HookHandler._beforeClampAngle -= value;
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

        public static event Delegates.DoMouseLook_AfterArgs DoMouseLook
        {
            add
            {
                HookHandler._afterDoMouseLook += value;
                HookHandler.HookDoMouseLook();
            }
            remove => HookHandler._afterDoMouseLook -= value;
        }

        public static event Delegates.GetXRotation_AfterArgs GetXRotation
        {
            add
            {
                HookHandler._afterGetXRotation += value;
                HookHandler.HookGetXRotation();
            }
            remove => HookHandler._afterGetXRotation -= value;
        }

        public static event Delegates.GetYRotation_AfterArgs GetYRotation
        {
            add
            {
                HookHandler._afterGetYRotation += value;
                HookHandler.HookGetYRotation();
            }
            remove => HookHandler._afterGetYRotation -= value;
        }

        public static event Delegates.ClampAngle_AfterArgs ClampAngle
        {
            add
            {
                HookHandler._afterClampAngle += value;
                HookHandler.HookClampAngle();
            }
            remove => HookHandler._afterClampAngle -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "OnUpdate"), value);
        }

        public static event Delegates.DoMouseLook_WithArgs DoMouseLook
        {
            add => HookEndpointManager.Add<Delegates.DoMouseLook_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "DoMouseLook"), value);
            remove => HookEndpointManager.Remove<Delegates.DoMouseLook_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "DoMouseLook"), value);
        }

        public static event Delegates.GetXRotation_WithArgs GetXRotation
        {
            add => HookEndpointManager.Add<Delegates.GetXRotation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "GetXRotation"), value);
            remove => HookEndpointManager.Remove<Delegates.GetXRotation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "GetXRotation"), value);
        }

        public static event Delegates.GetYRotation_WithArgs GetYRotation
        {
            add => HookEndpointManager.Add<Delegates.GetYRotation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "GetYRotation"), value);
            remove => HookEndpointManager.Remove<Delegates.GetYRotation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "GetYRotation"), value);
        }

        public static event Delegates.ClampAngle_WithArgs ClampAngle
        {
            add => HookEndpointManager.Add<Delegates.ClampAngle_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "ClampAngle", false), value);
            remove => HookEndpointManager.Remove<Delegates.ClampAngle_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MouseLook), "ClampAngle", false), value);
        }
    }
}