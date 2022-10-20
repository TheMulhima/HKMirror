namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ControllerButtonLabel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILControllerButtonLabel
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ControllerButtonLabel.Awake += value;
        remove => IL.ControllerButtonLabel.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ControllerButtonLabel.OnEnable += value;
        remove => IL.ControllerButtonLabel.OnEnable -= value;
    }

    public static event ILContext.Manipulator ShowCurrentBinding
    {
        add => IL.ControllerButtonLabel.ShowCurrentBinding += value;
        remove => IL.ControllerButtonLabel.ShowCurrentBinding -= value;
    }
}