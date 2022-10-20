namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SoftLandEffect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSoftLandEffect
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SoftLandEffect.OnEnable += value;
        remove => IL.SoftLandEffect.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SoftLandEffect.Update += value;
        remove => IL.SoftLandEffect.Update -= value;
    }
}