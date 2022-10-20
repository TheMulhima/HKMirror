using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CameraLockArea.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCameraLockArea
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CameraLockArea.Awake += value;
        remove => IL.CameraLockArea.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CameraLockArea), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CameraLockArea), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator IsInApplicableGameState
    {
        add => IL.CameraLockArea.IsInApplicableGameState += value;
        remove => IL.CameraLockArea.IsInApplicableGameState -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.CameraLockArea.OnTriggerEnter2D += value;
        remove => IL.CameraLockArea.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.CameraLockArea.OnTriggerStay2D += value;
        remove => IL.CameraLockArea.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.CameraLockArea.OnTriggerExit2D += value;
        remove => IL.CameraLockArea.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.CameraLockArea.OnDisable += value;
        remove => IL.CameraLockArea.OnDisable -= value;
    }

    public static event ILContext.Manipulator ValidateBounds
    {
        add => IL.CameraLockArea.ValidateBounds += value;
        remove => IL.CameraLockArea.ValidateBounds -= value;
    }

    public static event ILContext.Manipulator SetXMin
    {
        add => IL.CameraLockArea.SetXMin += value;
        remove => IL.CameraLockArea.SetXMin -= value;
    }

    public static event ILContext.Manipulator SetXMax
    {
        add => IL.CameraLockArea.SetXMax += value;
        remove => IL.CameraLockArea.SetXMax -= value;
    }

    public static event ILContext.Manipulator orig_Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CameraLockArea), "orig_Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CameraLockArea), "orig_Start").GetStateMachineTarget(), value);
    }
}