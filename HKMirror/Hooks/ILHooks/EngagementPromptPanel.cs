namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EngagementPromptPanel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEngagementPromptPanel
{
    public static event ILContext.Manipulator Start
    {
        add => IL.EngagementPromptPanel.Start += value;
        remove => IL.EngagementPromptPanel.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EngagementPromptPanel.Update += value;
        remove => IL.EngagementPromptPanel.Update -= value;
    }

    public static event ILContext.Manipulator UpdateContent
    {
        add => IL.EngagementPromptPanel.UpdateContent += value;
        remove => IL.EngagementPromptPanel.UpdateContent -= value;
    }
}