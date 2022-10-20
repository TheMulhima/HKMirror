namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SaveSlotBackgrounds.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSaveSlotBackgrounds
{
    public static event ILContext.Manipulator GetBackground_string
    {
        add => IL.SaveSlotBackgrounds.GetBackground_string += value;
        remove => IL.SaveSlotBackgrounds.GetBackground_string -= value;
    }

    public static event ILContext.Manipulator GetBackground_MapZone
    {
        add => IL.SaveSlotBackgrounds.GetBackground_MapZone += value;
        remove => IL.SaveSlotBackgrounds.GetBackground_MapZone -= value;
    }
}