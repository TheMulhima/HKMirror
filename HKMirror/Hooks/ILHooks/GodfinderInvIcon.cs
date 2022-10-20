namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GodfinderInvIcon.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGodfinderInvIcon
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GodfinderInvIcon.Awake += value;
        remove => IL.GodfinderInvIcon.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GodfinderInvIcon.OnEnable += value;
        remove => IL.GodfinderInvIcon.OnEnable -= value;
    }
}