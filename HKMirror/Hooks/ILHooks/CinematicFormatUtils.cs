namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CinematicFormatUtils,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCinematicFormatUtils
{
    public static event ILContext.Manipulator GetExtension
    {
        add => IL.CinematicFormatUtils.GetExtension += value;
        remove => IL.CinematicFormatUtils.GetExtension -= value;
    }
}