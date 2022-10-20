namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RandomRotationRange.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRandomRotationRange
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RandomRotationRange.Start += value;
        remove => IL.RandomRotationRange.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.RandomRotationRange.OnEnable += value;
        remove => IL.RandomRotationRange.OnEnable -= value;
    }

    public static event ILContext.Manipulator RandomRotate
    {
        add => IL.RandomRotationRange.RandomRotate += value;
        remove => IL.RandomRotationRange.RandomRotate -= value;
    }
}