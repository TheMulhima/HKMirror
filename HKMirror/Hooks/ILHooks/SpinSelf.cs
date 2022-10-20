namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpinSelf.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpinSelf
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SpinSelf.Start += value;
        remove => IL.SpinSelf.Start -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.SpinSelf.FixedUpdate += value;
        remove => IL.SpinSelf.FixedUpdate -= value;
    }
}