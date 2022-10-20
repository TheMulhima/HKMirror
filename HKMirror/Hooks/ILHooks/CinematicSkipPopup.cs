using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CinematicSkipPopup.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCinematicSkipPopup
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CinematicSkipPopup.Awake += value;
        remove => IL.CinematicSkipPopup.Awake -= value;
    }

    public static event ILContext.Manipulator ShowRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSkipPopup), "ShowRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSkipPopup), "ShowRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.CinematicSkipPopup.Hide += value;
        remove => IL.CinematicSkipPopup.Hide -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CinematicSkipPopup.Update += value;
        remove => IL.CinematicSkipPopup.Update -= value;
    }
}