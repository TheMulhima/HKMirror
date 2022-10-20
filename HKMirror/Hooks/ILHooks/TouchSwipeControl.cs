using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchSwipeControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchSwipeControl
{
    public static event ILContext.Manipulator CreateControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "CreateControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "CreateControl"), value);
    }

    public static event ILContext.Manipulator DestroyControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "DestroyControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "DestroyControl"), value);
    }

    public static event ILContext.Manipulator ConfigureControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "ConfigureControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "ConfigureControl"), value);
    }

    public static event ILContext.Manipulator DrawGizmos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "DrawGizmos"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "DrawGizmos"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "Update"),
            value);
    }

    public static event ILContext.Manipulator SubmitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "SubmitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "SubmitControlState"), value);
    }

    public static event ILContext.Manipulator CommitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "CommitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "CommitControlState"), value);
    }

    public static event ILContext.Manipulator TouchBegan
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "TouchBegan"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "TouchBegan"),
            value);
    }

    public static event ILContext.Manipulator TouchMoved
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "TouchMoved"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "TouchMoved"),
            value);
    }

    public static event ILContext.Manipulator TouchEnded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "TouchEnded"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "TouchEnded"),
            value);
    }

    public static event ILContext.Manipulator get_ActiveArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "get_ActiveArea"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "get_ActiveArea"), value);
    }

    public static event ILContext.Manipulator set_ActiveArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "set_ActiveArea"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "set_ActiveArea"), value);
    }

    public static event ILContext.Manipulator get_AreaUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "get_AreaUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "get_AreaUnitType"), value);
    }

    public static event ILContext.Manipulator set_AreaUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "set_AreaUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSwipeControl), "set_AreaUnitType"), value);
    }
}