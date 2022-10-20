using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuButtonList.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuButtonList
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.MenuButtonList.Awake += value;
        remove => IL.MenuButtonList.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.MenuButtonList.Start += value;
        remove => IL.MenuButtonList.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MenuButtonList.OnEnable += value;
        remove => IL.MenuButtonList.OnEnable -= value;
    }

    public static event ILContext.Manipulator DoSelect
    {
        add => IL.MenuButtonList.DoSelect += value;
        remove => IL.MenuButtonList.DoSelect -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.MenuButtonList.OnDestroy += value;
        remove => IL.MenuButtonList.OnDestroy -= value;
    }

    public static event ILContext.Manipulator SelectDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "SelectDelayed").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "SelectDelayed").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ClearLastSelected
    {
        add => IL.MenuButtonList.ClearLastSelected += value;
        remove => IL.MenuButtonList.ClearLastSelected -= value;
    }

    public static event ILContext.Manipulator ClearAllLastSelected
    {
        add => IL.MenuButtonList.ClearAllLastSelected += value;
        remove => IL.MenuButtonList.ClearAllLastSelected -= value;
    }

    public static event ILContext.Manipulator AddSelectable_Selectable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "AddSelectable"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "AddSelectable"),
            value);
    }

    public static event ILContext.Manipulator AddSelectableEnd
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "AddSelectableEnd"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "AddSelectableEnd"), value);
    }

    public static event ILContext.Manipulator AddSelectable_Selectable_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "AddSelectable"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "AddSelectable"),
            value);
    }

    public static event ILContext.Manipulator ClearSelectables
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "ClearSelectables"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "ClearSelectables"), value);
    }

    public static event ILContext.Manipulator RecalculateNavigation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "RecalculateNavigation"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuButtonList), "RecalculateNavigation"), value);
    }
}