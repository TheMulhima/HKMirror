namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetRecoilFreeze.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetRecoilFreeze
{
    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetRecoilFreeze.OnEnter += value;
        remove => IL.SetRecoilFreeze.OnEnter -= value;
    }
}