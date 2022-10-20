namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WaveEffectControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWaveEffectControl
{
    public static event ILContext.Manipulator Start
    {
        add => IL.WaveEffectControl.Start += value;
        remove => IL.WaveEffectControl.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.WaveEffectControl.OnEnable += value;
        remove => IL.WaveEffectControl.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.WaveEffectControl.Update += value;
        remove => IL.WaveEffectControl.Update -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.WaveEffectControl.FixedUpdate += value;
        remove => IL.WaveEffectControl.FixedUpdate -= value;
    }
}