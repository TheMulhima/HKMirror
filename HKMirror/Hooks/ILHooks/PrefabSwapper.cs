namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PrefabSwapper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPrefabSwapper
{
    public static event ILContext.Manipulator contains
    {
        add => IL.PrefabSwapper.contains += value;
        remove => IL.PrefabSwapper.contains -= value;
    }
}