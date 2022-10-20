namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BeginRecoil.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBeginRecoil
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.BeginRecoil.Reset += value;
        remove => IL.BeginRecoil.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.BeginRecoil.OnEnter += value;
        remove => IL.BeginRecoil.OnEnter -= value;
    }
}