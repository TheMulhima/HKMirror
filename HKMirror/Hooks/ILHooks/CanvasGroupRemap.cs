namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CanvasGroupRemap.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCanvasGroupRemap
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CanvasGroupRemap.Awake += value;
        remove => IL.CanvasGroupRemap.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CanvasGroupRemap.Update += value;
        remove => IL.CanvasGroupRemap.Update -= value;
    }

    public static event ILContext.Manipulator Sync
    {
        add => IL.CanvasGroupRemap.Sync += value;
        remove => IL.CanvasGroupRemap.Sync -= value;
    }
}