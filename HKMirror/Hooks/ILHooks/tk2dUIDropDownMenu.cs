using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIDropDownMenu.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIDropDownMenu
{
    public static event ILContext.Manipulator get_ItemList
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_ItemList"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_ItemList"), value);
    }

    public static event ILContext.Manipulator set_ItemList
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_ItemList"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_ItemList"), value);
    }

    public static event ILContext.Manipulator get_Index
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_Index"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_Index"),
            value);
    }

    public static event ILContext.Manipulator set_Index
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_Index"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_Index"),
            value);
    }

    public static event ILContext.Manipulator get_SelectedItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_SelectedItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_SelectedItem"), value);
    }

    public static event ILContext.Manipulator get_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator set_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator get_MenuLayoutItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_MenuLayoutItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_MenuLayoutItem"), value);
    }

    public static event ILContext.Manipulator set_MenuLayoutItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_MenuLayoutItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_MenuLayoutItem"), value);
    }

    public static event ILContext.Manipulator get_TemplateLayoutItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_TemplateLayoutItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "get_TemplateLayoutItem"), value);
    }

    public static event ILContext.Manipulator set_TemplateLayoutItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_TemplateLayoutItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownMenu), "set_TemplateLayoutItem"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUIDropDownMenu.Awake += value;
        remove => IL.tk2dUIDropDownMenu.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIDropDownMenu.OnEnable += value;
        remove => IL.tk2dUIDropDownMenu.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIDropDownMenu.OnDisable += value;
        remove => IL.tk2dUIDropDownMenu.OnDisable -= value;
    }

    public static event ILContext.Manipulator UpdateList
    {
        add => IL.tk2dUIDropDownMenu.UpdateList += value;
        remove => IL.tk2dUIDropDownMenu.UpdateList -= value;
    }

    public static event ILContext.Manipulator SetSelectedItem
    {
        add => IL.tk2dUIDropDownMenu.SetSelectedItem += value;
        remove => IL.tk2dUIDropDownMenu.SetSelectedItem -= value;
    }

    public static event ILContext.Manipulator CreateAnotherDropDownItem
    {
        add => IL.tk2dUIDropDownMenu.CreateAnotherDropDownItem += value;
        remove => IL.tk2dUIDropDownMenu.CreateAnotherDropDownItem -= value;
    }

    public static event ILContext.Manipulator ItemSelected
    {
        add => IL.tk2dUIDropDownMenu.ItemSelected += value;
        remove => IL.tk2dUIDropDownMenu.ItemSelected -= value;
    }

    public static event ILContext.Manipulator ExpandButtonPressed
    {
        add => IL.tk2dUIDropDownMenu.ExpandButtonPressed += value;
        remove => IL.tk2dUIDropDownMenu.ExpandButtonPressed -= value;
    }

    public static event ILContext.Manipulator ExpandList
    {
        add => IL.tk2dUIDropDownMenu.ExpandList += value;
        remove => IL.tk2dUIDropDownMenu.ExpandList -= value;
    }

    public static event ILContext.Manipulator CollapseList
    {
        add => IL.tk2dUIDropDownMenu.CollapseList += value;
        remove => IL.tk2dUIDropDownMenu.CollapseList -= value;
    }

    public static event ILContext.Manipulator DropDownItemHoverBtnToggle
    {
        add => IL.tk2dUIDropDownMenu.DropDownItemHoverBtnToggle += value;
        remove => IL.tk2dUIDropDownMenu.DropDownItemHoverBtnToggle -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dUIDropDownMenu.OnDestroy += value;
        remove => IL.tk2dUIDropDownMenu.OnDestroy -= value;
    }
}