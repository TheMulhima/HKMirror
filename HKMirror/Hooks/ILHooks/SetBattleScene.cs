namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetBattleScene.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetBattleScene
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetBattleScene.Reset += value;
        remove => IL.SetBattleScene.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetBattleScene.OnEnter += value;
        remove => IL.SetBattleScene.OnEnter -= value;
    }
}