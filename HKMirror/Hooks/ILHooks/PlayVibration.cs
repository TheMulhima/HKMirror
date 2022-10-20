namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayVibration.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayVibration
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.PlayVibration.Reset += value;
        remove => IL.PlayVibration.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.PlayVibration.OnEnter += value;
        remove => IL.PlayVibration.OnEnter -= value;
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.PlayVibration.Play += value;
        remove => IL.PlayVibration.Play -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.PlayVibration.OnUpdate += value;
        remove => IL.PlayVibration.OnUpdate -= value;
    }

    public static event ILContext.Manipulator EnqueueNextLoop
    {
        add => IL.PlayVibration.EnqueueNextLoop += value;
        remove => IL.PlayVibration.EnqueueNextLoop -= value;
    }
}