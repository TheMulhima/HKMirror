using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CapturePoseAsAnimationClip.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCapturePoseAsAnimationClip
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "OnEnter"), value);
    }

    public static event ILContext.Manipulator DoCaptureAnimationClip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "DoCaptureAnimationClip"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "DoCaptureAnimationClip"), value);
    }

    public static event ILContext.Manipulator CaptureTransform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureTransform"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureTransform"), value);
    }

    public static event ILContext.Manipulator CapturePosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CapturePosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CapturePosition"), value);
    }

    public static event ILContext.Manipulator CaptureRotation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureRotation"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureRotation"), value);
    }

    public static event ILContext.Manipulator CaptureScale
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureScale"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "CaptureScale"), value);
    }

    public static event ILContext.Manipulator SetConstantCurve
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "SetConstantCurve"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CapturePoseAsAnimationClip), "SetConstantCurve"), value);
    }
}