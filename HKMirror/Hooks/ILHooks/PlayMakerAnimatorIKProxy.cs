namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerAnimatorIKProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerAnimatorIKProxy
{
    public static event ILContext.Manipulator OnAnimatorIK
    {
        add => IL.PlayMakerAnimatorIKProxy.OnAnimatorIK += value;
        remove => IL.PlayMakerAnimatorIKProxy.OnAnimatorIK -= value;
    }
}