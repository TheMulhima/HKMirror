namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpinSelfSimple.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpinSelfSimple
{
    public static event ILContext.Manipulator Update
    {
        add => IL.SpinSelfSimple.Update += value;
        remove => IL.SpinSelfSimple.Update -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpinSelfSimple.OnEnable += value;
        remove => IL.SpinSelfSimple.OnEnable -= value;
    }

    public static event ILContext.Manipulator DoSpin
    {
        add => IL.SpinSelfSimple.DoSpin += value;
        remove => IL.SpinSelfSimple.DoSpin -= value;
    }
}