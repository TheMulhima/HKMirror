namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BrummFlamePin.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBrummFlamePin
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BrummFlamePin.Start += value;
        remove => IL.BrummFlamePin.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.BrummFlamePin.OnEnable += value;
        remove => IL.BrummFlamePin.OnEnable -= value;
    }
}