namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ControllerDetect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILControllerDetect
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ControllerDetect.Awake += value;
        remove => IL.ControllerDetect.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ControllerDetect.OnEnable += value;
        remove => IL.ControllerDetect.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.ControllerDetect.OnDisable += value;
        remove => IL.ControllerDetect.OnDisable -= value;
    }

    public static event ILContext.Manipulator ControllerActivated
    {
        add => IL.ControllerDetect.ControllerActivated += value;
        remove => IL.ControllerDetect.ControllerActivated -= value;
    }

    public static event ILContext.Manipulator ControllerAttached
    {
        add => IL.ControllerDetect.ControllerAttached += value;
        remove => IL.ControllerDetect.ControllerAttached -= value;
    }

    public static event ILContext.Manipulator ControllerDetached
    {
        add => IL.ControllerDetect.ControllerDetached += value;
        remove => IL.ControllerDetect.ControllerDetached -= value;
    }

    public static event ILContext.Manipulator ShowController
    {
        add => IL.ControllerDetect.ShowController += value;
        remove => IL.ControllerDetect.ShowController -= value;
    }

    public static event ILContext.Manipulator HideButtonLabels
    {
        add => IL.ControllerDetect.HideButtonLabels += value;
        remove => IL.ControllerDetect.HideButtonLabels -= value;
    }

    public static event ILContext.Manipulator LookForActiveController
    {
        add => IL.ControllerDetect.LookForActiveController += value;
        remove => IL.ControllerDetect.LookForActiveController -= value;
    }
}