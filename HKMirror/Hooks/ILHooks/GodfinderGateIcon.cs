namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GodfinderGateIcon,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGodfinderGateIcon
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GodfinderGateIcon.Reset += value;
        remove => IL.GodfinderGateIcon.Reset -= value;
    }

    public static event ILContext.Manipulator OnValidate
    {
        add => IL.GodfinderGateIcon.OnValidate += value;
        remove => IL.GodfinderGateIcon.OnValidate -= value;
    }

    public static event ILContext.Manipulator SetIcon
    {
        add => IL.GodfinderGateIcon.SetIcon += value;
        remove => IL.GodfinderGateIcon.SetIcon -= value;
    }

    public static event ILContext.Manipulator Evaluate
    {
        add => IL.GodfinderGateIcon.Evaluate += value;
        remove => IL.GodfinderGateIcon.Evaluate -= value;
    }
}