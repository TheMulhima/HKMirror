namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeactivateGameObjectPerBuildType.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeactivateGameObjectPerBuildType
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DeactivateGameObjectPerBuildType.OnEnable += value;
        remove => IL.DeactivateGameObjectPerBuildType.OnEnable -= value;
    }
}