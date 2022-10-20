namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetHPEveryFrame.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetHPEveryFrame
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetHPEveryFrame.Reset += value;
        remove => IL.GetHPEveryFrame.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetHPEveryFrame.OnEnter += value;
        remove => IL.GetHPEveryFrame.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.GetHPEveryFrame.OnUpdate += value;
        remove => IL.GetHPEveryFrame.OnUpdate -= value;
    }
}