namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PreSpawnCorpse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPreSpawnCorpse
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.PreSpawnCorpse.Reset += value;
        remove => IL.PreSpawnCorpse.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.PreSpawnCorpse.OnEnter += value;
        remove => IL.PreSpawnCorpse.OnEnter -= value;
    }
}