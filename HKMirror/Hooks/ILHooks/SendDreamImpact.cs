namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SendDreamImpact.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSendDreamImpact
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SendDreamImpact.Reset += value;
        remove => IL.SendDreamImpact.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SendDreamImpact.OnEnter += value;
        remove => IL.SendDreamImpact.OnEnter -= value;
    }
}