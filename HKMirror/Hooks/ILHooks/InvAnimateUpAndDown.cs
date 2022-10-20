namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InvAnimateUpAndDown.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInvAnimateUpAndDown
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.InvAnimateUpAndDown.Awake += value;
        remove => IL.InvAnimateUpAndDown.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.InvAnimateUpAndDown.Update += value;
        remove => IL.InvAnimateUpAndDown.Update -= value;
    }

    public static event ILContext.Manipulator AnimateUp
    {
        add => IL.InvAnimateUpAndDown.AnimateUp += value;
        remove => IL.InvAnimateUpAndDown.AnimateUp -= value;
    }

    public static event ILContext.Manipulator AnimateDown
    {
        add => IL.InvAnimateUpAndDown.AnimateDown += value;
        remove => IL.InvAnimateUpAndDown.AnimateDown -= value;
    }

    public static event ILContext.Manipulator ReplayUpAnim
    {
        add => IL.InvAnimateUpAndDown.ReplayUpAnim += value;
        remove => IL.InvAnimateUpAndDown.ReplayUpAnim -= value;
    }
}