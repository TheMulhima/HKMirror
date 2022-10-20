namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetRecoilSpeed.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetRecoilSpeed
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetRecoilSpeed.Reset += value;
        remove => IL.SetRecoilSpeed.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetRecoilSpeed.OnEnter += value;
        remove => IL.SetRecoilSpeed.OnEnter -= value;
    }
}