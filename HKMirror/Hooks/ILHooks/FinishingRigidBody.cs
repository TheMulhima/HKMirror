namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FinishingRigidBody.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFinishingRigidBody
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.FinishingRigidBody.Reset += value;
        remove => IL.FinishingRigidBody.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.FinishingRigidBody.Awake += value;
        remove => IL.FinishingRigidBody.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.FinishingRigidBody.OnEnable += value;
        remove => IL.FinishingRigidBody.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.FinishingRigidBody.Update += value;
        remove => IL.FinishingRigidBody.Update -= value;
    }

    public static event ILContext.Manipulator Conclude
    {
        add => IL.FinishingRigidBody.Conclude += value;
        remove => IL.FinishingRigidBody.Conclude -= value;
    }
}