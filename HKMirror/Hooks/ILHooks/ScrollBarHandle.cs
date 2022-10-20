namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ScrollBarHandle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILScrollBarHandle
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ScrollBarHandle.Awake += value;
        remove => IL.ScrollBarHandle.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ScrollBarHandle.Start += value;
        remove => IL.ScrollBarHandle.Start -= value;
    }

    public static event ILContext.Manipulator UpdatePosition
    {
        add => IL.ScrollBarHandle.UpdatePosition += value;
        remove => IL.ScrollBarHandle.UpdatePosition -= value;
    }
}