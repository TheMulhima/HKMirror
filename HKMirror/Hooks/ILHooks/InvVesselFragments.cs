namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InvVesselFragments.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInvVesselFragments
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.InvVesselFragments.OnEnable += value;
        remove => IL.InvVesselFragments.OnEnable -= value;
    }
}