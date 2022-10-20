namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SaveSlotOverrides.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSaveSlotOverrides
{
    public static event ILContext.Manipulator OnValidate
    {
        add => IL.SaveSlotOverrides.OnValidate += value;
        remove => IL.SaveSlotOverrides.OnValidate -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.SaveSlotOverrides.Awake += value;
        remove => IL.SaveSlotOverrides.Awake -= value;
    }
}