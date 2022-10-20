namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SendExtraDamage.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSendExtraDamage
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SendExtraDamage.Reset += value;
        remove => IL.SendExtraDamage.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SendExtraDamage.OnEnter += value;
        remove => IL.SendExtraDamage.OnEnter -= value;
    }
}