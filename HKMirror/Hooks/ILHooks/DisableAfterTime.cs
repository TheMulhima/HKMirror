namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DisableAfterTime.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDisableAfterTime
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DisableAfterTime.OnEnable += value;
        remove => IL.DisableAfterTime.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DisableAfterTime.Update += value;
        remove => IL.DisableAfterTime.Update -= value;
    }
}