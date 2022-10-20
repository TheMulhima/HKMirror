namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EngagedUserPanel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEngagedUserPanel
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EngagedUserPanel.Awake += value;
        remove => IL.EngagedUserPanel.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.EngagedUserPanel.OnDestroy += value;
        remove => IL.EngagedUserPanel.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.EngagedUserPanel.Start += value;
        remove => IL.EngagedUserPanel.Start -= value;
    }

    public static event ILContext.Manipulator UpdateContent
    {
        add => IL.EngagedUserPanel.UpdateContent += value;
        remove => IL.EngagedUserPanel.UpdateContent -= value;
    }
}