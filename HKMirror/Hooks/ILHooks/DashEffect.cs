namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DashEffect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDashEffect
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DashEffect.OnEnable += value;
        remove => IL.DashEffect.OnEnable -= value;
    }

    public static event ILContext.Manipulator PlayDashPuff
    {
        add => IL.DashEffect.PlayDashPuff += value;
        remove => IL.DashEffect.PlayDashPuff -= value;
    }

    public static event ILContext.Manipulator PlayDust
    {
        add => IL.DashEffect.PlayDust += value;
        remove => IL.DashEffect.PlayDust -= value;
    }

    public static event ILContext.Manipulator PlayGrass
    {
        add => IL.DashEffect.PlayGrass += value;
        remove => IL.DashEffect.PlayGrass -= value;
    }

    public static event ILContext.Manipulator PlayBone
    {
        add => IL.DashEffect.PlayBone += value;
        remove => IL.DashEffect.PlayBone -= value;
    }

    public static event ILContext.Manipulator PlaySpaEffects
    {
        add => IL.DashEffect.PlaySpaEffects += value;
        remove => IL.DashEffect.PlaySpaEffects -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DashEffect.Update += value;
        remove => IL.DashEffect.Update -= value;
    }
}