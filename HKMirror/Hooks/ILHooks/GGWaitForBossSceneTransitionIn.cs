namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GGWaitForBossSceneTransitionIn.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGGWaitForBossSceneTransitionIn
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GGWaitForBossSceneTransitionIn.Reset += value;
        remove => IL.GGWaitForBossSceneTransitionIn.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GGWaitForBossSceneTransitionIn.OnEnter += value;
        remove => IL.GGWaitForBossSceneTransitionIn.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.GGWaitForBossSceneTransitionIn.OnUpdate += value;
        remove => IL.GGWaitForBossSceneTransitionIn.OnUpdate -= value;
    }

    public static event ILContext.Manipulator DoCheck
    {
        add => IL.GGWaitForBossSceneTransitionIn.DoCheck += value;
        remove => IL.GGWaitForBossSceneTransitionIn.DoCheck -= value;
    }
}