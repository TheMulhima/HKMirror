namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SlopePlat.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSlopePlat
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SlopePlat.Start += value;
        remove => IL.SlopePlat.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SlopePlat.Update += value;
        remove => IL.SlopePlat.Update -= value;
    }
}