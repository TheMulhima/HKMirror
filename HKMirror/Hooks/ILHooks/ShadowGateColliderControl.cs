namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShadowGateColliderControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShadowGateColliderControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ShadowGateColliderControl.Awake += value;
        remove => IL.ShadowGateColliderControl.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ShadowGateColliderControl.Start += value;
        remove => IL.ShadowGateColliderControl.Start -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.ShadowGateColliderControl.OnDestroy += value;
        remove => IL.ShadowGateColliderControl.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.ShadowGateColliderControl.Setup += value;
        remove => IL.ShadowGateColliderControl.Setup -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.ShadowGateColliderControl.FixedUpdate += value;
        remove => IL.ShadowGateColliderControl.FixedUpdate -= value;
    }
}