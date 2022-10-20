namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PerBuildTypeOnEnableResponse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPerBuildTypeOnEnableResponse
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PerBuildTypeOnEnableResponse.OnEnable += value;
        remove => IL.PerBuildTypeOnEnableResponse.OnEnable -= value;
    }

    public static event ILContext.Manipulator DoEvent
    {
        add => IL.PerBuildTypeOnEnableResponse.DoEvent += value;
        remove => IL.PerBuildTypeOnEnableResponse.DoEvent -= value;
    }
}