namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BreakableObject.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBreakableObject
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BreakableObject.Awake += value;
        remove => IL.BreakableObject.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BreakableObject.Start += value;
        remove => IL.BreakableObject.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BreakableObject.OnTriggerEnter2D += value;
        remove => IL.BreakableObject.OnTriggerEnter2D -= value;
    }
}