namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HazardRespawnTrigger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHazardRespawnTrigger
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.HazardRespawnTrigger.Awake += value;
        remove => IL.HazardRespawnTrigger.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.HazardRespawnTrigger.Start += value;
        remove => IL.HazardRespawnTrigger.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.HazardRespawnTrigger.OnTriggerEnter2D += value;
        remove => IL.HazardRespawnTrigger.OnTriggerEnter2D -= value;
    }
}