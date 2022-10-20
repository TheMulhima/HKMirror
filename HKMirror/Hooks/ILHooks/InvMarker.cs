namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InvMarker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInvMarker
{
    public static event ILContext.Manipulator OnDisable
    {
        add => IL.InvMarker.OnDisable += value;
        remove => IL.InvMarker.OnDisable -= value;
    }
}