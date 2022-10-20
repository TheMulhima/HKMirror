namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RespawnTrigger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRespawnTrigger
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.RespawnTrigger.Awake += value;
        remove => IL.RespawnTrigger.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.RespawnTrigger.Start += value;
        remove => IL.RespawnTrigger.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.RespawnTrigger.OnTriggerEnter2D += value;
        remove => IL.RespawnTrigger.OnTriggerEnter2D -= value;
    }
}