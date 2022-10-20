namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GlobalPrefabDefaults.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGlobalPrefabDefaults
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GlobalPrefabDefaults.Awake += value;
        remove => IL.GlobalPrefabDefaults.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GlobalPrefabDefaults.Start += value;
        remove => IL.GlobalPrefabDefaults.Start -= value;
    }

    public static event ILContext.Manipulator SpawnBlood
    {
        add => IL.GlobalPrefabDefaults.SpawnBlood += value;
        remove => IL.GlobalPrefabDefaults.SpawnBlood -= value;
    }
}