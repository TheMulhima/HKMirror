namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PreventInvincibleEffect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPreventInvincibleEffect
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.PreventInvincibleEffect.Reset += value;
        remove => IL.PreventInvincibleEffect.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.PreventInvincibleEffect.OnEnter += value;
        remove => IL.PreventInvincibleEffect.OnEnter -= value;
    }
}