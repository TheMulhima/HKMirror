namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckGGBossLevel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckGGBossLevel
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckGGBossLevel.Reset += value;
        remove => IL.CheckGGBossLevel.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckGGBossLevel.OnEnter += value;
        remove => IL.CheckGGBossLevel.OnEnter -= value;
    }
}