using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchTrackControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchTrackControl
{
    public static event ILContext.Manipulator CreateControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "CreateControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "CreateControl"), value);
    }

    public static event ILContext.Manipulator DestroyControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "DestroyControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "DestroyControl"), value);
    }

    public static event ILContext.Manipulator ConfigureControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "ConfigureControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "ConfigureControl"), value);
    }

    public static event ILContext.Manipulator DrawGizmos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "DrawGizmos"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "DrawGizmos"),
            value);
    }

    public static event ILContext.Manipulator OnValidate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "OnValidate"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "OnValidate"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "Update"),
            value);
    }

    public static event ILContext.Manipulator SubmitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "SubmitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "SubmitControlState"), value);
    }

    public static event ILContext.Manipulator CommitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "CommitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "CommitControlState"), value);
    }

    public static event ILContext.Manipulator TouchBegan
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "TouchBegan"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "TouchBegan"),
            value);
    }

    public static event ILContext.Manipulator TouchMoved
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "TouchMoved"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "TouchMoved"),
            value);
    }

    public static event ILContext.Manipulator TouchEnded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "TouchEnded"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "TouchEnded"),
            value);
    }

    public static event ILContext.Manipulator get_ActiveArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "get_ActiveArea"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "get_ActiveArea"), value);
    }

    public static event ILContext.Manipulator set_ActiveArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "set_ActiveArea"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "set_ActiveArea"), value);
    }

    public static event ILContext.Manipulator get_AreaUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "get_AreaUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "get_AreaUnitType"), value);
    }

    public static event ILContext.Manipulator set_AreaUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "set_AreaUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchTrackControl), "set_AreaUnitType"), value);
    }
}