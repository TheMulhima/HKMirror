namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AnimSpeedLerp.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAnimSpeedLerp
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.AnimSpeedLerp.Reset += value;
        remove => IL.AnimSpeedLerp.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.AnimSpeedLerp.OnEnter += value;
        remove => IL.AnimSpeedLerp.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.AnimSpeedLerp.OnUpdate += value;
        remove => IL.AnimSpeedLerp.OnUpdate -= value;
    }

    public static event ILContext.Manipulator OnExit
    {
        add => IL.AnimSpeedLerp.OnExit += value;
        remove => IL.AnimSpeedLerp.OnExit -= value;
    }
}