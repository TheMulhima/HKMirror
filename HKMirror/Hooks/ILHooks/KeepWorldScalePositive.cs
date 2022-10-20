namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeepWorldScalePositive.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeepWorldScalePositive
{
    public static event ILContext.Manipulator Update
    {
        add => IL.KeepWorldScalePositive.Update += value;
        remove => IL.KeepWorldScalePositive.Update -= value;
    }
}