namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RemoteDisable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRemoteDisable
{
    public static event ILContext.Manipulator RemoteDisableObject
    {
        add => IL.RemoteDisable.RemoteDisableObject += value;
        remove => IL.RemoteDisable.RemoteDisableObject -= value;
    }
}