using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CapturePoseAsAnimationClip class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCapturePoseAsAnimationClip
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<CapturePoseAsAnimationClip> orig, CapturePoseAsAnimationClip self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<CapturePoseAsAnimationClip> orig, CapturePoseAsAnimationClip self)
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

        internal static void HookDoCaptureAnimationClip()
        {
            if (!HookedList.Contains("DoCaptureAnimationClip"))
            {
                HookedList.Add("DoCaptureAnimationClip");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "DoCaptureAnimationClip"),
                    DoCaptureAnimationClip);
            }
        }

        internal static event Delegates.DoCaptureAnimationClip_BeforeArgs _beforeDoCaptureAnimationClip;
        internal static event Delegates.DoCaptureAnimationClip_AfterArgs _afterDoCaptureAnimationClip;

        private static void DoCaptureAnimationClip(Action<CapturePoseAsAnimationClip> orig,
            CapturePoseAsAnimationClip self)
        {
            Delegates.Params_DoCaptureAnimationClip @params = new()
            {
                self = self
            };
            if (_beforeDoCaptureAnimationClip != null)
                foreach (Delegates.DoCaptureAnimationClip_BeforeArgs toInvoke in _beforeDoCaptureAnimationClip
                             .GetInvocationList())
                    try
                    {
                        _beforeDoCaptureAnimationClip?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoCaptureAnimationClip != null)
                foreach (Delegates.DoCaptureAnimationClip_AfterArgs toInvoke in _afterDoCaptureAnimationClip
                             .GetInvocationList())
                    try
                    {
                        _afterDoCaptureAnimationClip.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCaptureTransform()
        {
            if (!HookedList.Contains("CaptureTransform"))
            {
                HookedList.Add("CaptureTransform");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureTransform"),
                    CaptureTransform);
            }
        }

        internal static event Delegates.CaptureTransform_BeforeArgs _beforeCaptureTransform;
        internal static event Delegates.CaptureTransform_AfterArgs _afterCaptureTransform;

        private static void CaptureTransform(Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig,
            CapturePoseAsAnimationClip self, Transform transform, string path, AnimationClip clip)
        {
            Delegates.Params_CaptureTransform @params = new()
            {
                self = self, transform = transform, path = path, clip = clip
            };
            if (_beforeCaptureTransform != null)
                foreach (Delegates.CaptureTransform_BeforeArgs toInvoke in _beforeCaptureTransform.GetInvocationList())
                    try
                    {
                        _beforeCaptureTransform?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            transform = @params.transform;
            path = @params.path;
            clip = @params.clip;
            orig(self, transform, path, clip);
            if (_afterCaptureTransform != null)
                foreach (Delegates.CaptureTransform_AfterArgs toInvoke in _afterCaptureTransform.GetInvocationList())
                    try
                    {
                        _afterCaptureTransform.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCapturePosition()
        {
            if (!HookedList.Contains("CapturePosition"))
            {
                HookedList.Add("CapturePosition");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CapturePosition"),
                    CapturePosition);
            }
        }

        internal static event Delegates.CapturePosition_BeforeArgs _beforeCapturePosition;
        internal static event Delegates.CapturePosition_AfterArgs _afterCapturePosition;

        private static void CapturePosition(Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig,
            CapturePoseAsAnimationClip self, Transform transform, string path, AnimationClip clip)
        {
            Delegates.Params_CapturePosition @params = new()
            {
                self = self, transform = transform, path = path, clip = clip
            };
            if (_beforeCapturePosition != null)
                foreach (Delegates.CapturePosition_BeforeArgs toInvoke in _beforeCapturePosition.GetInvocationList())
                    try
                    {
                        _beforeCapturePosition?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            transform = @params.transform;
            path = @params.path;
            clip = @params.clip;
            orig(self, transform, path, clip);
            if (_afterCapturePosition != null)
                foreach (Delegates.CapturePosition_AfterArgs toInvoke in _afterCapturePosition.GetInvocationList())
                    try
                    {
                        _afterCapturePosition.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCaptureRotation()
        {
            if (!HookedList.Contains("CaptureRotation"))
            {
                HookedList.Add("CaptureRotation");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureRotation"),
                    CaptureRotation);
            }
        }

        internal static event Delegates.CaptureRotation_BeforeArgs _beforeCaptureRotation;
        internal static event Delegates.CaptureRotation_AfterArgs _afterCaptureRotation;

        private static void CaptureRotation(Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig,
            CapturePoseAsAnimationClip self, Transform transform, string path, AnimationClip clip)
        {
            Delegates.Params_CaptureRotation @params = new()
            {
                self = self, transform = transform, path = path, clip = clip
            };
            if (_beforeCaptureRotation != null)
                foreach (Delegates.CaptureRotation_BeforeArgs toInvoke in _beforeCaptureRotation.GetInvocationList())
                    try
                    {
                        _beforeCaptureRotation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            transform = @params.transform;
            path = @params.path;
            clip = @params.clip;
            orig(self, transform, path, clip);
            if (_afterCaptureRotation != null)
                foreach (Delegates.CaptureRotation_AfterArgs toInvoke in _afterCaptureRotation.GetInvocationList())
                    try
                    {
                        _afterCaptureRotation.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCaptureScale()
        {
            if (!HookedList.Contains("CaptureScale"))
            {
                HookedList.Add("CaptureScale");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureScale"),
                    CaptureScale);
            }
        }

        internal static event Delegates.CaptureScale_BeforeArgs _beforeCaptureScale;
        internal static event Delegates.CaptureScale_AfterArgs _afterCaptureScale;

        private static void CaptureScale(Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig,
            CapturePoseAsAnimationClip self, Transform transform, string path, AnimationClip clip)
        {
            Delegates.Params_CaptureScale @params = new()
            {
                self = self, transform = transform, path = path, clip = clip
            };
            if (_beforeCaptureScale != null)
                foreach (Delegates.CaptureScale_BeforeArgs toInvoke in _beforeCaptureScale.GetInvocationList())
                    try
                    {
                        _beforeCaptureScale?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            transform = @params.transform;
            path = @params.path;
            clip = @params.clip;
            orig(self, transform, path, clip);
            if (_afterCaptureScale != null)
                foreach (Delegates.CaptureScale_AfterArgs toInvoke in _afterCaptureScale.GetInvocationList())
                    try
                    {
                        _afterCaptureScale.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetConstantCurve()
        {
            if (!HookedList.Contains("SetConstantCurve"))
            {
                HookedList.Add("SetConstantCurve");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "SetConstantCurve"),
                    SetConstantCurve);
            }
        }

        internal static event Delegates.SetConstantCurve_BeforeArgs _beforeSetConstantCurve;
        internal static event Delegates.SetConstantCurve_AfterArgs _afterSetConstantCurve;

        private static void SetConstantCurve(
            Action<CapturePoseAsAnimationClip, AnimationClip, string, string, float> orig,
            CapturePoseAsAnimationClip self, AnimationClip clip, string childPath, string propertyPath, float value)
        {
            Delegates.Params_SetConstantCurve @params = new()
            {
                self = self, clip = clip, childPath = childPath, propertyPath = propertyPath, value = value
            };
            if (_beforeSetConstantCurve != null)
                foreach (Delegates.SetConstantCurve_BeforeArgs toInvoke in _beforeSetConstantCurve.GetInvocationList())
                    try
                    {
                        _beforeSetConstantCurve?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            clip = @params.clip;
            childPath = @params.childPath;
            propertyPath = @params.propertyPath;
            value = @params.value;
            orig(self, clip, childPath, propertyPath, value);
            if (_afterSetConstantCurve != null)
                foreach (Delegates.SetConstantCurve_AfterArgs toInvoke in _afterSetConstantCurve.GetInvocationList())
                    try
                    {
                        _afterSetConstantCurve.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CapturePosition_AfterArgs(Params_CapturePosition args);

        public delegate void CapturePosition_BeforeArgs(Params_CapturePosition args);

        public delegate void CapturePosition_WithArgs(
            Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig, CapturePoseAsAnimationClip self,
            Transform transform, string path, AnimationClip clip);

        public delegate void CaptureRotation_AfterArgs(Params_CaptureRotation args);

        public delegate void CaptureRotation_BeforeArgs(Params_CaptureRotation args);

        public delegate void CaptureRotation_WithArgs(
            Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig, CapturePoseAsAnimationClip self,
            Transform transform, string path, AnimationClip clip);

        public delegate void CaptureScale_AfterArgs(Params_CaptureScale args);

        public delegate void CaptureScale_BeforeArgs(Params_CaptureScale args);

        public delegate void CaptureScale_WithArgs(
            Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig, CapturePoseAsAnimationClip self,
            Transform transform, string path, AnimationClip clip);

        public delegate void CaptureTransform_AfterArgs(Params_CaptureTransform args);

        public delegate void CaptureTransform_BeforeArgs(Params_CaptureTransform args);

        public delegate void CaptureTransform_WithArgs(
            Action<CapturePoseAsAnimationClip, Transform, string, AnimationClip> orig, CapturePoseAsAnimationClip self,
            Transform transform, string path, AnimationClip clip);

        public delegate void DoCaptureAnimationClip_AfterArgs(Params_DoCaptureAnimationClip args);

        public delegate void DoCaptureAnimationClip_BeforeArgs(Params_DoCaptureAnimationClip args);

        public delegate void DoCaptureAnimationClip_WithArgs(Action<CapturePoseAsAnimationClip> orig,
            CapturePoseAsAnimationClip self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<CapturePoseAsAnimationClip> orig, CapturePoseAsAnimationClip self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<CapturePoseAsAnimationClip> orig, CapturePoseAsAnimationClip self);

        public delegate void SetConstantCurve_AfterArgs(Params_SetConstantCurve args);

        public delegate void SetConstantCurve_BeforeArgs(Params_SetConstantCurve args);

        public delegate void SetConstantCurve_WithArgs(
            Action<CapturePoseAsAnimationClip, AnimationClip, string, string, float> orig,
            CapturePoseAsAnimationClip self, AnimationClip clip, string childPath, string propertyPath, float value);

        public sealed class Params_Reset
        {
            public CapturePoseAsAnimationClip self;
        }

        public sealed class Params_OnEnter
        {
            public CapturePoseAsAnimationClip self;
        }

        public sealed class Params_DoCaptureAnimationClip
        {
            public CapturePoseAsAnimationClip self;
        }

        public sealed class Params_CaptureTransform
        {
            public AnimationClip clip;
            public string path;
            public CapturePoseAsAnimationClip self;
            public Transform transform;
        }

        public sealed class Params_CapturePosition
        {
            public AnimationClip clip;
            public string path;
            public CapturePoseAsAnimationClip self;
            public Transform transform;
        }

        public sealed class Params_CaptureRotation
        {
            public AnimationClip clip;
            public string path;
            public CapturePoseAsAnimationClip self;
            public Transform transform;
        }

        public sealed class Params_CaptureScale
        {
            public AnimationClip clip;
            public string path;
            public CapturePoseAsAnimationClip self;
            public Transform transform;
        }

        public sealed class Params_SetConstantCurve
        {
            public string childPath;
            public AnimationClip clip;
            public string propertyPath;
            public CapturePoseAsAnimationClip self;
            public float value;
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

        public static event Delegates.DoCaptureAnimationClip_BeforeArgs DoCaptureAnimationClip
        {
            add
            {
                HookHandler._beforeDoCaptureAnimationClip += value;
                HookHandler.HookDoCaptureAnimationClip();
            }
            remove => HookHandler._beforeDoCaptureAnimationClip -= value;
        }

        public static event Delegates.CaptureTransform_BeforeArgs CaptureTransform
        {
            add
            {
                HookHandler._beforeCaptureTransform += value;
                HookHandler.HookCaptureTransform();
            }
            remove => HookHandler._beforeCaptureTransform -= value;
        }

        public static event Delegates.CapturePosition_BeforeArgs CapturePosition
        {
            add
            {
                HookHandler._beforeCapturePosition += value;
                HookHandler.HookCapturePosition();
            }
            remove => HookHandler._beforeCapturePosition -= value;
        }

        public static event Delegates.CaptureRotation_BeforeArgs CaptureRotation
        {
            add
            {
                HookHandler._beforeCaptureRotation += value;
                HookHandler.HookCaptureRotation();
            }
            remove => HookHandler._beforeCaptureRotation -= value;
        }

        public static event Delegates.CaptureScale_BeforeArgs CaptureScale
        {
            add
            {
                HookHandler._beforeCaptureScale += value;
                HookHandler.HookCaptureScale();
            }
            remove => HookHandler._beforeCaptureScale -= value;
        }

        public static event Delegates.SetConstantCurve_BeforeArgs SetConstantCurve
        {
            add
            {
                HookHandler._beforeSetConstantCurve += value;
                HookHandler.HookSetConstantCurve();
            }
            remove => HookHandler._beforeSetConstantCurve -= value;
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

        public static event Delegates.DoCaptureAnimationClip_AfterArgs DoCaptureAnimationClip
        {
            add
            {
                HookHandler._afterDoCaptureAnimationClip += value;
                HookHandler.HookDoCaptureAnimationClip();
            }
            remove => HookHandler._afterDoCaptureAnimationClip -= value;
        }

        public static event Delegates.CaptureTransform_AfterArgs CaptureTransform
        {
            add
            {
                HookHandler._afterCaptureTransform += value;
                HookHandler.HookCaptureTransform();
            }
            remove => HookHandler._afterCaptureTransform -= value;
        }

        public static event Delegates.CapturePosition_AfterArgs CapturePosition
        {
            add
            {
                HookHandler._afterCapturePosition += value;
                HookHandler.HookCapturePosition();
            }
            remove => HookHandler._afterCapturePosition -= value;
        }

        public static event Delegates.CaptureRotation_AfterArgs CaptureRotation
        {
            add
            {
                HookHandler._afterCaptureRotation += value;
                HookHandler.HookCaptureRotation();
            }
            remove => HookHandler._afterCaptureRotation -= value;
        }

        public static event Delegates.CaptureScale_AfterArgs CaptureScale
        {
            add
            {
                HookHandler._afterCaptureScale += value;
                HookHandler.HookCaptureScale();
            }
            remove => HookHandler._afterCaptureScale -= value;
        }

        public static event Delegates.SetConstantCurve_AfterArgs SetConstantCurve
        {
            add
            {
                HookHandler._afterSetConstantCurve += value;
                HookHandler.HookSetConstantCurve();
            }
            remove => HookHandler._afterSetConstantCurve -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "OnEnter"), value);
        }

        public static event Delegates.DoCaptureAnimationClip_WithArgs DoCaptureAnimationClip
        {
            add => HookEndpointManager.Add<Delegates.DoCaptureAnimationClip_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "DoCaptureAnimationClip"), value);
            remove => HookEndpointManager.Remove<Delegates.DoCaptureAnimationClip_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "DoCaptureAnimationClip"), value);
        }

        public static event Delegates.CaptureTransform_WithArgs CaptureTransform
        {
            add => HookEndpointManager.Add<Delegates.CaptureTransform_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureTransform"), value);
            remove => HookEndpointManager.Remove<Delegates.CaptureTransform_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureTransform"), value);
        }

        public static event Delegates.CapturePosition_WithArgs CapturePosition
        {
            add => HookEndpointManager.Add<Delegates.CapturePosition_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CapturePosition"), value);
            remove => HookEndpointManager.Remove<Delegates.CapturePosition_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CapturePosition"), value);
        }

        public static event Delegates.CaptureRotation_WithArgs CaptureRotation
        {
            add => HookEndpointManager.Add<Delegates.CaptureRotation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureRotation"), value);
            remove => HookEndpointManager.Remove<Delegates.CaptureRotation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureRotation"), value);
        }

        public static event Delegates.CaptureScale_WithArgs CaptureScale
        {
            add => HookEndpointManager.Add<Delegates.CaptureScale_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureScale"), value);
            remove => HookEndpointManager.Remove<Delegates.CaptureScale_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureScale"), value);
        }

        public static event Delegates.SetConstantCurve_WithArgs SetConstantCurve
        {
            add => HookEndpointManager.Add<Delegates.SetConstantCurve_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "SetConstantCurve"), value);
            remove => HookEndpointManager.Remove<Delegates.SetConstantCurve_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "SetConstantCurve"), value);
        }
    }
}