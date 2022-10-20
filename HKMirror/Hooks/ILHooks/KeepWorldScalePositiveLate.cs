namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeepWorldScalePositiveLate.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeepWorldScalePositiveLate
{
    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.KeepWorldScalePositiveLate.LateUpdate += value;
        remove => IL.KeepWorldScalePositiveLate.LateUpdate -= value;
    }
}