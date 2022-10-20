namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ConnectControllerPanel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILConnectControllerPanel
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ConnectControllerPanel.Start += value;
        remove => IL.ConnectControllerPanel.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ConnectControllerPanel.Update += value;
        remove => IL.ConnectControllerPanel.Update -= value;
    }

    public static event ILContext.Manipulator UpdateContent
    {
        add => IL.ConnectControllerPanel.UpdateContent += value;
        remove => IL.ConnectControllerPanel.UpdateContent -= value;
    }
}