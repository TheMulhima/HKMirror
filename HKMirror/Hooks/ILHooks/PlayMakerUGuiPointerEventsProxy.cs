namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUGuiPointerEventsProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUGuiPointerEventsProxy
{
    public static event ILContext.Manipulator OnPointerClick
    {
        add => IL.PlayMakerUGuiPointerEventsProxy.OnPointerClick += value;
        remove => IL.PlayMakerUGuiPointerEventsProxy.OnPointerClick -= value;
    }

    public static event ILContext.Manipulator OnPointerDown
    {
        add => IL.PlayMakerUGuiPointerEventsProxy.OnPointerDown += value;
        remove => IL.PlayMakerUGuiPointerEventsProxy.OnPointerDown -= value;
    }

    public static event ILContext.Manipulator OnPointerEnter
    {
        add => IL.PlayMakerUGuiPointerEventsProxy.OnPointerEnter += value;
        remove => IL.PlayMakerUGuiPointerEventsProxy.OnPointerEnter -= value;
    }

    public static event ILContext.Manipulator OnPointerExit
    {
        add => IL.PlayMakerUGuiPointerEventsProxy.OnPointerExit += value;
        remove => IL.PlayMakerUGuiPointerEventsProxy.OnPointerExit -= value;
    }

    public static event ILContext.Manipulator OnPointerUp
    {
        add => IL.PlayMakerUGuiPointerEventsProxy.OnPointerUp += value;
        remove => IL.PlayMakerUGuiPointerEventsProxy.OnPointerUp -= value;
    }
}