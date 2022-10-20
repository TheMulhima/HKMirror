namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SaveProfileMPSlots.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSaveProfileMPSlots
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SaveProfileMPSlots.Awake += value;
        remove => IL.SaveProfileMPSlots.Awake -= value;
    }

    public static event ILContext.Manipulator showMPSlots
    {
        add => IL.SaveProfileMPSlots.showMPSlots += value;
        remove => IL.SaveProfileMPSlots.showMPSlots -= value;
    }
}