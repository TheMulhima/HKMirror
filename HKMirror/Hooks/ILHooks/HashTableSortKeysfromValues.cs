namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HashTableSortKeysfromValues.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHashTableSortKeysfromValues
{
    public static event ILContext.Manipulator Start
    {
        add => IL.HashTableSortKeysfromValues.Start += value;
        remove => IL.HashTableSortKeysfromValues.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.HashTableSortKeysfromValues.Update += value;
        remove => IL.HashTableSortKeysfromValues.Update -= value;
    }
}