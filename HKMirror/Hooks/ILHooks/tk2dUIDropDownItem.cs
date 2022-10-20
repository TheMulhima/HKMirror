using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIDropDownItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIDropDownItem
{
    public static event ILContext.Manipulator get_Index
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_Index"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_Index"),
            value);
    }

    public static event ILContext.Manipulator set_Index
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_Index"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_Index"),
            value);
    }

    public static event ILContext.Manipulator get_LabelText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_LabelText"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_LabelText"), value);
    }

    public static event ILContext.Manipulator set_LabelText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_LabelText"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_LabelText"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIDropDownItem.OnEnable += value;
        remove => IL.tk2dUIDropDownItem.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIDropDownItem.OnDisable += value;
        remove => IL.tk2dUIDropDownItem.OnDisable -= value;
    }

    public static event ILContext.Manipulator ItemSelected
    {
        add => IL.tk2dUIDropDownItem.ItemSelected += value;
        remove => IL.tk2dUIDropDownItem.ItemSelected -= value;
    }
}