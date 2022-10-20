namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LinkRendererState.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLinkRendererState
{
    public static event ILContext.Manipulator Start
    {
        add => IL.LinkRendererState.Start += value;
        remove => IL.LinkRendererState.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LinkRendererState.Update += value;
        remove => IL.LinkRendererState.Update -= value;
    }

    public static event ILContext.Manipulator UpdateLink
    {
        add => IL.LinkRendererState.UpdateLink += value;
        remove => IL.LinkRendererState.UpdateLink -= value;
    }
}