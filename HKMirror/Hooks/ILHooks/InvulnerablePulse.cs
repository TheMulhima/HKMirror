namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InvulnerablePulse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInvulnerablePulse
{
    public static event ILContext.Manipulator Start
    {
        add => IL.InvulnerablePulse.Start += value;
        remove => IL.InvulnerablePulse.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.InvulnerablePulse.Update += value;
        remove => IL.InvulnerablePulse.Update -= value;
    }

    public static event ILContext.Manipulator startInvulnerablePulse
    {
        add => IL.InvulnerablePulse.startInvulnerablePulse += value;
        remove => IL.InvulnerablePulse.startInvulnerablePulse -= value;
    }

    public static event ILContext.Manipulator stopInvulnerablePulse
    {
        add => IL.InvulnerablePulse.stopInvulnerablePulse += value;
        remove => IL.InvulnerablePulse.stopInvulnerablePulse -= value;
    }

    public static event ILContext.Manipulator updateSpriteColor
    {
        add => IL.InvulnerablePulse.updateSpriteColor += value;
        remove => IL.InvulnerablePulse.updateSpriteColor -= value;
    }
}