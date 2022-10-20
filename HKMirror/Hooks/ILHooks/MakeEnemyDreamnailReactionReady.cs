namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MakeEnemyDreamnailReactionReady.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMakeEnemyDreamnailReactionReady
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.MakeEnemyDreamnailReactionReady.Reset += value;
        remove => IL.MakeEnemyDreamnailReactionReady.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.MakeEnemyDreamnailReactionReady.OnEnter += value;
        remove => IL.MakeEnemyDreamnailReactionReady.OnEnter -= value;
    }
}