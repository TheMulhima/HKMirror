using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIManager
{
    public static event ILContext.Manipulator get_Instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_Instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_Instance", false), value);
    }

    public static event ILContext.Manipulator get_Instance__NoCreate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_Instance__NoCreate", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_Instance__NoCreate", false), value);
    }

    public static event ILContext.Manipulator get_UICamera
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_UICamera"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_UICamera"),
            value);
    }

    public static event ILContext.Manipulator set_UICamera
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "set_UICamera"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "set_UICamera"),
            value);
    }

    public static event ILContext.Manipulator GetUICameraForControl
    {
        add => IL.tk2dUIManager.GetUICameraForControl += value;
        remove => IL.tk2dUIManager.GetUICameraForControl -= value;
    }

    public static event ILContext.Manipulator RegisterCamera
    {
        add => IL.tk2dUIManager.RegisterCamera += value;
        remove => IL.tk2dUIManager.RegisterCamera -= value;
    }

    public static event ILContext.Manipulator UnregisterCamera
    {
        add => IL.tk2dUIManager.UnregisterCamera += value;
        remove => IL.tk2dUIManager.UnregisterCamera -= value;
    }

    public static event ILContext.Manipulator get_InputEnabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_InputEnabled"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_InputEnabled"), value);
    }

    public static event ILContext.Manipulator set_InputEnabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "set_InputEnabled"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "set_InputEnabled"), value);
    }

    public static event ILContext.Manipulator get_PressedUIItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_PressedUIItem"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_PressedUIItem"), value);
    }

    public static event ILContext.Manipulator get_PressedUIItems
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_PressedUIItems"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_PressedUIItems"), value);
    }

    public static event ILContext.Manipulator get_UseMultiTouch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_UseMultiTouch"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "get_UseMultiTouch"), value);
    }

    public static event ILContext.Manipulator set_UseMultiTouch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "set_UseMultiTouch"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIManager), "set_UseMultiTouch"), value);
    }

    public static event ILContext.Manipulator SortCameras
    {
        add => IL.tk2dUIManager.SortCameras += value;
        remove => IL.tk2dUIManager.SortCameras -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUIManager.Awake += value;
        remove => IL.tk2dUIManager.Awake -= value;
    }

    public static event ILContext.Manipulator HookUpLegacyCamera
    {
        add => IL.tk2dUIManager.HookUpLegacyCamera += value;
        remove => IL.tk2dUIManager.HookUpLegacyCamera -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIManager.Start += value;
        remove => IL.tk2dUIManager.Start -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.tk2dUIManager.Setup += value;
        remove => IL.tk2dUIManager.Setup -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.tk2dUIManager.Update += value;
        remove => IL.tk2dUIManager.Update -= value;
    }

    public static event ILContext.Manipulator CheckInputs
    {
        add => IL.tk2dUIManager.CheckInputs += value;
        remove => IL.tk2dUIManager.CheckInputs -= value;
    }

    public static event ILContext.Manipulator CheckMultiTouchInputs
    {
        add => IL.tk2dUIManager.CheckMultiTouchInputs += value;
        remove => IL.tk2dUIManager.CheckMultiTouchInputs -= value;
    }

    public static event ILContext.Manipulator RaycastForUIItem
    {
        add => IL.tk2dUIManager.RaycastForUIItem += value;
        remove => IL.tk2dUIManager.RaycastForUIItem -= value;
    }

    public static event ILContext.Manipulator OverrideClearAllChildrenPresses
    {
        add => IL.tk2dUIManager.OverrideClearAllChildrenPresses += value;
        remove => IL.tk2dUIManager.OverrideClearAllChildrenPresses -= value;
    }
}