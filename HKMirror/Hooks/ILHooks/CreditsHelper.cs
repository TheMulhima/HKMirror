namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CreditsHelper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCreditsHelper
{
    public static event ILContext.Manipulator Start
    {
        add => IL.CreditsHelper.Start += value;
        remove => IL.CreditsHelper.Start -= value;
    }

    public static event ILContext.Manipulator BeginCredits
    {
        add => IL.CreditsHelper.BeginCredits += value;
        remove => IL.CreditsHelper.BeginCredits -= value;
    }

    public static event ILContext.Manipulator ShouldStopHere
    {
        add => IL.CreditsHelper.ShouldStopHere += value;
        remove => IL.CreditsHelper.ShouldStopHere -= value;
    }
}