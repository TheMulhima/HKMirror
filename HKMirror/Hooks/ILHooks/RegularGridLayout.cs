using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RegularGridLayout.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRegularGridLayout
{
    public static event ILContext.Manipulator get_ItemAdvance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_ItemAdvance"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_ItemAdvance"), value);
    }

    public static event ILContext.Manipulator set_ItemAdvance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_ItemAdvance"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_ItemAdvance"), value);
    }

    public static event ILContext.Manipulator get_Start
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Start"),
            value);
    }

    public static event ILContext.Manipulator set_Start
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Start"),
            value);
    }

    public static event ILContext.Manipulator get_Columns
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Columns"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Columns"),
            value);
    }

    public static event ILContext.Manipulator set_Columns
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Columns"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Columns"),
            value);
    }

    public static event ILContext.Manipulator get_Index
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Index"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Index"),
            value);
    }

    public static event ILContext.Manipulator set_Index
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Index"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Index"),
            value);
    }

    public static event ILContext.Manipulator get_IndexPos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_IndexPos"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_IndexPos"), value);
    }

    public static event ILContext.Manipulator CreateVerticalLayout
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "CreateVerticalLayout", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "CreateVerticalLayout", false), value);
    }

    public static event ILContext.Manipulator ModifyNext
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ModifyNext"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ModifyNext"),
            value);
    }

    public static event ILContext.Manipulator ChangeColumns
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ChangeColumns"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ChangeColumns"), value);
    }
}