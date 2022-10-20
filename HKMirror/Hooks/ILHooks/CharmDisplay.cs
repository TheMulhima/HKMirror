namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CharmDisplay.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCharmDisplay
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CharmDisplay.Reset += value;
        remove => IL.CharmDisplay.Reset -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.CharmDisplay.Start += value;
        remove => IL.CharmDisplay.Start -= value;
    }

    public static event ILContext.Manipulator Check
    {
        add => IL.CharmDisplay.Check += value;
        remove => IL.CharmDisplay.Check -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.CharmDisplay.FixedUpdate += value;
        remove => IL.CharmDisplay.FixedUpdate -= value;
    }
}