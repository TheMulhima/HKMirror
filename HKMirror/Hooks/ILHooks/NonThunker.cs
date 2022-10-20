namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for NonThunker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILNonThunker
{
    public static event ILContext.Manipulator SetActive
    {
        add => IL.NonThunker.SetActive += value;
        remove => IL.NonThunker.SetActive -= value;
    }
}