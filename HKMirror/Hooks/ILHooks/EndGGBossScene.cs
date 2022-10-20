namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EndGGBossScene.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEndGGBossScene
{
    public static event ILContext.Manipulator OnEnter
    {
        add => IL.EndGGBossScene.OnEnter += value;
        remove => IL.EndGGBossScene.OnEnter -= value;
    }
}