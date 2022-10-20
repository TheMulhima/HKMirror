namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DestroyOutOfBounds.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDestroyOutOfBounds
{
    public static event ILContext.Manipulator Update
    {
        add => IL.DestroyOutOfBounds.Update += value;
        remove => IL.DestroyOutOfBounds.Update -= value;
    }
}