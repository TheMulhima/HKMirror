using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrubBGControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrubBGControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GrubBGControl.Awake += value;
        remove => IL.GrubBGControl.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GrubBGControl.Start += value;
        remove => IL.GrubBGControl.Start -= value;
    }

    public static event ILContext.Manipulator Idle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GrubBGControl), "Idle").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GrubBGControl), "Idle").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Wave
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GrubBGControl), "Wave").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GrubBGControl), "Wave").GetStateMachineTarget(), value);
    }
}