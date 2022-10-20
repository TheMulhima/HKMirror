namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CaptureMouseEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCaptureMouseEvents
{
    public static event ILContext.Manipulator OnPointerEnter
    {
        add => IL.CaptureMouseEvents.OnPointerEnter += value;
        remove => IL.CaptureMouseEvents.OnPointerEnter -= value;
    }

    public static event ILContext.Manipulator OnPointerExit
    {
        add => IL.CaptureMouseEvents.OnPointerExit += value;
        remove => IL.CaptureMouseEvents.OnPointerExit -= value;
    }
}