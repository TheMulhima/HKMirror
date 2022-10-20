namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUGuiDragEventsProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUGuiDragEventsProxy
{
    public static event ILContext.Manipulator OnBeginDrag
    {
        add => IL.PlayMakerUGuiDragEventsProxy.OnBeginDrag += value;
        remove => IL.PlayMakerUGuiDragEventsProxy.OnBeginDrag -= value;
    }

    public static event ILContext.Manipulator OnDrag
    {
        add => IL.PlayMakerUGuiDragEventsProxy.OnDrag += value;
        remove => IL.PlayMakerUGuiDragEventsProxy.OnDrag -= value;
    }

    public static event ILContext.Manipulator OnEndDrag
    {
        add => IL.PlayMakerUGuiDragEventsProxy.OnEndDrag += value;
        remove => IL.PlayMakerUGuiDragEventsProxy.OnEndDrag -= value;
    }
}