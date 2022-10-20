namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VisibilityControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVisibilityControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.VisibilityControl.Awake += value;
        remove => IL.VisibilityControl.Awake -= value;
    }

    public static event ILContext.Manipulator Reveal
    {
        add => IL.VisibilityControl.Reveal += value;
        remove => IL.VisibilityControl.Reveal -= value;
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.VisibilityControl.Hide += value;
        remove => IL.VisibilityControl.Hide -= value;
    }
}