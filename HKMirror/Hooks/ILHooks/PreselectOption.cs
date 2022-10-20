using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PreselectOption.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPreselectOption
{
    public static event ILContext.Manipulator HighlightDefault
    {
        add => IL.PreselectOption.HighlightDefault += value;
        remove => IL.PreselectOption.HighlightDefault -= value;
    }

    public static event ILContext.Manipulator SetDefaultHighlight
    {
        add => IL.PreselectOption.SetDefaultHighlight += value;
        remove => IL.PreselectOption.SetDefaultHighlight -= value;
    }

    public static event ILContext.Manipulator DeselectAll
    {
        add => IL.PreselectOption.DeselectAll += value;
        remove => IL.PreselectOption.DeselectAll -= value;
    }

    public static event ILContext.Manipulator ForceDeselect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PreselectOption), "ForceDeselect").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PreselectOption), "ForceDeselect").GetStateMachineTarget(), value);
    }
}