namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WalkArea.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWalkArea
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.WalkArea.Awake += value;
        remove => IL.WalkArea.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.WalkArea.Start += value;
        remove => IL.WalkArea.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.WalkArea.OnTriggerEnter2D += value;
        remove => IL.WalkArea.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.WalkArea.OnTriggerStay2D += value;
        remove => IL.WalkArea.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.WalkArea.OnTriggerExit2D += value;
        remove => IL.WalkArea.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator Deactivate
    {
        add => IL.WalkArea.Deactivate += value;
        remove => IL.WalkArea.Deactivate -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.WalkArea.OnDisable += value;
        remove => IL.WalkArea.OnDisable -= value;
    }
}