namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetRigidbodySimulated2D.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetRigidbodySimulated2D
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetRigidbodySimulated2D.Reset += value;
        remove => IL.SetRigidbodySimulated2D.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetRigidbodySimulated2D.OnEnter += value;
        remove => IL.SetRigidbodySimulated2D.OnEnter -= value;
    }

    public static event ILContext.Manipulator DoSetIsKinematic
    {
        add => IL.SetRigidbodySimulated2D.DoSetIsKinematic += value;
        remove => IL.SetRigidbodySimulated2D.DoSetIsKinematic -= value;
    }
}