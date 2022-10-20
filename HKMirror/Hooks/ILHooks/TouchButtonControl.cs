using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchButtonControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchButtonControl
{
    public static event ILContext.Manipulator CreateControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "CreateControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "CreateControl"), value);
    }

    public static event ILContext.Manipulator DestroyControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "DestroyControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "DestroyControl"), value);
    }

    public static event ILContext.Manipulator ConfigureControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "ConfigureControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "ConfigureControl"), value);
    }

    public static event ILContext.Manipulator DrawGizmos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "DrawGizmos"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "DrawGizmos"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "Update"),
            value);
    }

    public static event ILContext.Manipulator SubmitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "SubmitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "SubmitControlState"), value);
    }

    public static event ILContext.Manipulator CommitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "CommitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "CommitControlState"), value);
    }

    public static event ILContext.Manipulator TouchBegan
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "TouchBegan"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "TouchBegan"),
            value);
    }

    public static event ILContext.Manipulator TouchMoved
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "TouchMoved"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "TouchMoved"),
            value);
    }

    public static event ILContext.Manipulator TouchEnded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "TouchEnded"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "TouchEnded"),
            value);
    }

    public static event ILContext.Manipulator get_ButtonState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_ButtonState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_ButtonState"), value);
    }

    public static event ILContext.Manipulator set_ButtonState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_ButtonState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_ButtonState"), value);
    }

    public static event ILContext.Manipulator get_ButtonPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_ButtonPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_ButtonPosition"), value);
    }

    public static event ILContext.Manipulator set_ButtonPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_ButtonPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_ButtonPosition"), value);
    }

    public static event ILContext.Manipulator get_Anchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_Anchor"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_Anchor"),
            value);
    }

    public static event ILContext.Manipulator set_Anchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_Anchor"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_Anchor"),
            value);
    }

    public static event ILContext.Manipulator get_Offset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_Offset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_Offset"),
            value);
    }

    public static event ILContext.Manipulator set_Offset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_Offset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_Offset"),
            value);
    }

    public static event ILContext.Manipulator get_OffsetUnitType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_OffsetUnitType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "get_OffsetUnitType"), value);
    }

    public static event ILContext.Manipulator set_OffsetUnitType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_OffsetUnitType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchButtonControl), "set_OffsetUnitType"), value);
    }
}