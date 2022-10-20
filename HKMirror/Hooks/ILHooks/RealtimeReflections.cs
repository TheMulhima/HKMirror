namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RealtimeReflections.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRealtimeReflections
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.RealtimeReflections.OnEnable += value;
        remove => IL.RealtimeReflections.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.RealtimeReflections.Start += value;
        remove => IL.RealtimeReflections.Start -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.RealtimeReflections.LateUpdate += value;
        remove => IL.RealtimeReflections.LateUpdate -= value;
    }

    public static event ILContext.Manipulator UpdateCubemap
    {
        add => IL.RealtimeReflections.UpdateCubemap += value;
        remove => IL.RealtimeReflections.UpdateCubemap -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.RealtimeReflections.OnDisable += value;
        remove => IL.RealtimeReflections.OnDisable -= value;
    }
}