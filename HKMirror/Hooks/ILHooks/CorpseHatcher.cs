namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CorpseHatcher.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpseHatcher
{
    public static event ILContext.Manipulator Smash
    {
        add => IL.CorpseHatcher.Smash += value;
        remove => IL.CorpseHatcher.Smash -= value;
    }
}