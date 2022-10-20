namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FlamePin.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFlamePin
{
    public static event ILContext.Manipulator Start
    {
        add => IL.FlamePin.Start += value;
        remove => IL.FlamePin.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.FlamePin.OnEnable += value;
        remove => IL.FlamePin.OnEnable -= value;
    }
}