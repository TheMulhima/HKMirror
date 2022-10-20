namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeepRotation.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeepRotation
{
    public static event ILContext.Manipulator Start
    {
        add => IL.KeepRotation.Start += value;
        remove => IL.KeepRotation.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.KeepRotation.Update += value;
        remove => IL.KeepRotation.Update -= value;
    }
}