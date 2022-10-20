using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIItem
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUIItem.Awake += value;
        remove => IL.tk2dUIItem.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIItem.Start += value;
        remove => IL.tk2dUIItem.Start -= value;
    }

    public static event ILContext.Manipulator get_IsPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIItem), "get_IsPressed"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIItem), "get_IsPressed"),
            value);
    }

    public static event ILContext.Manipulator get_Touch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIItem), "get_Touch"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIItem), "get_Touch"), value);
    }

    public static event ILContext.Manipulator get_ParentUIItem
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIItem), "get_ParentUIItem"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIItem), "get_ParentUIItem"),
            value);
    }

    public static event ILContext.Manipulator UpdateParent
    {
        add => IL.tk2dUIItem.UpdateParent += value;
        remove => IL.tk2dUIItem.UpdateParent -= value;
    }

    public static event ILContext.Manipulator ManuallySetParent
    {
        add => IL.tk2dUIItem.ManuallySetParent += value;
        remove => IL.tk2dUIItem.ManuallySetParent -= value;
    }

    public static event ILContext.Manipulator RemoveParent
    {
        add => IL.tk2dUIItem.RemoveParent += value;
        remove => IL.tk2dUIItem.RemoveParent -= value;
    }

    public static event ILContext.Manipulator Press_tk2dUITouch
    {
        add => IL.tk2dUIItem.Press_tk2dUITouch += value;
        remove => IL.tk2dUIItem.Press_tk2dUITouch -= value;
    }

    public static event ILContext.Manipulator Press_tk2dUITouch_tk2dUIItem
    {
        add => IL.tk2dUIItem.Press_tk2dUITouch_tk2dUIItem += value;
        remove => IL.tk2dUIItem.Press_tk2dUITouch_tk2dUIItem -= value;
    }

    public static event ILContext.Manipulator UpdateTouch
    {
        add => IL.tk2dUIItem.UpdateTouch += value;
        remove => IL.tk2dUIItem.UpdateTouch -= value;
    }

    public static event ILContext.Manipulator DoSendMessage
    {
        add => IL.tk2dUIItem.DoSendMessage += value;
        remove => IL.tk2dUIItem.DoSendMessage -= value;
    }

    public static event ILContext.Manipulator Release
    {
        add => IL.tk2dUIItem.Release += value;
        remove => IL.tk2dUIItem.Release -= value;
    }

    public static event ILContext.Manipulator CurrentOverUIItem
    {
        add => IL.tk2dUIItem.CurrentOverUIItem += value;
        remove => IL.tk2dUIItem.CurrentOverUIItem -= value;
    }

    public static event ILContext.Manipulator CheckIsUIItemChildOfMe
    {
        add => IL.tk2dUIItem.CheckIsUIItemChildOfMe += value;
        remove => IL.tk2dUIItem.CheckIsUIItemChildOfMe -= value;
    }

    public static event ILContext.Manipulator Exit
    {
        add => IL.tk2dUIItem.Exit += value;
        remove => IL.tk2dUIItem.Exit -= value;
    }

    public static event ILContext.Manipulator HoverOver
    {
        add => IL.tk2dUIItem.HoverOver += value;
        remove => IL.tk2dUIItem.HoverOver -= value;
    }

    public static event ILContext.Manipulator HoverOut
    {
        add => IL.tk2dUIItem.HoverOut += value;
        remove => IL.tk2dUIItem.HoverOut -= value;
    }

    public static event ILContext.Manipulator GetParentUIItem
    {
        add => IL.tk2dUIItem.GetParentUIItem += value;
        remove => IL.tk2dUIItem.GetParentUIItem -= value;
    }

    public static event ILContext.Manipulator SimulateClick
    {
        add => IL.tk2dUIItem.SimulateClick += value;
        remove => IL.tk2dUIItem.SimulateClick -= value;
    }

    public static event ILContext.Manipulator InternalSetIsChildOfAnotherUIItem
    {
        add => IL.tk2dUIItem.InternalSetIsChildOfAnotherUIItem += value;
        remove => IL.tk2dUIItem.InternalSetIsChildOfAnotherUIItem -= value;
    }

    public static event ILContext.Manipulator InternalGetIsChildOfAnotherUIItem
    {
        add => IL.tk2dUIItem.InternalGetIsChildOfAnotherUIItem += value;
        remove => IL.tk2dUIItem.InternalGetIsChildOfAnotherUIItem -= value;
    }
}