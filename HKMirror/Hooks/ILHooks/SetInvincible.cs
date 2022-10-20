namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetInvincible.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetInvincible
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetInvincible.Reset += value;
        remove => IL.SetInvincible.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetInvincible.OnEnter += value;
        remove => IL.SetInvincible.OnEnter -= value;
    }
}