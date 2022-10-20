namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GGGetBossDoorCompletion.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGGGetBossDoorCompletion
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GGGetBossDoorCompletion.Reset += value;
        remove => IL.GGGetBossDoorCompletion.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GGGetBossDoorCompletion.OnEnter += value;
        remove => IL.GGGetBossDoorCompletion.OnEnter -= value;
    }
}