namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RandomRotation.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRandomRotation
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RandomRotation.Start += value;
        remove => IL.RandomRotation.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.RandomRotation.OnEnable += value;
        remove => IL.RandomRotation.OnEnable -= value;
    }

    public static event ILContext.Manipulator RandomRotate
    {
        add => IL.RandomRotation.RandomRotate += value;
        remove => IL.RandomRotation.RandomRotate -= value;
    }
}