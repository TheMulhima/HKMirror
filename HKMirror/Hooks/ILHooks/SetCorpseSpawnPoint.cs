namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetCorpseSpawnPoint.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetCorpseSpawnPoint
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetCorpseSpawnPoint.Reset += value;
        remove => IL.SetCorpseSpawnPoint.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetCorpseSpawnPoint.OnEnter += value;
        remove => IL.SetCorpseSpawnPoint.OnEnter -= value;
    }
}