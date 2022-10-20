namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GodfinderGateIconManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGodfinderGateIconManager
{
    public static event ILContext.Manipulator OnValidate
    {
        add => IL.GodfinderGateIconManager.OnValidate += value;
        remove => IL.GodfinderGateIconManager.OnValidate -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GodfinderGateIconManager.OnEnable += value;
        remove => IL.GodfinderGateIconManager.OnEnable -= value;
    }

    public static event ILContext.Manipulator DoLayout
    {
        add => IL.GodfinderGateIconManager.DoLayout += value;
        remove => IL.GodfinderGateIconManager.DoLayout -= value;
    }
}