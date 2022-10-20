namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeactivateAfterDelay.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeactivateAfterDelay
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.DeactivateAfterDelay.Awake += value;
        remove => IL.DeactivateAfterDelay.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DeactivateAfterDelay.OnEnable += value;
        remove => IL.DeactivateAfterDelay.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DeactivateAfterDelay.Update += value;
        remove => IL.DeactivateAfterDelay.Update -= value;
    }
}