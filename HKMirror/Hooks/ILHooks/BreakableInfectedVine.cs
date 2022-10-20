namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BreakableInfectedVine.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBreakableInfectedVine
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BreakableInfectedVine.Awake += value;
        remove => IL.BreakableInfectedVine.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BreakableInfectedVine.Start += value;
        remove => IL.BreakableInfectedVine.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BreakableInfectedVine.OnTriggerEnter2D += value;
        remove => IL.BreakableInfectedVine.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator SpawnSpatters
    {
        add => IL.BreakableInfectedVine.SpawnSpatters += value;
        remove => IL.BreakableInfectedVine.SpawnSpatters -= value;
    }
}