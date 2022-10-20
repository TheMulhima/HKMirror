using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchStickControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchStickControl
{
    public static event ILContext.Manipulator CreateControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "CreateControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "CreateControl"), value);
    }

    public static event ILContext.Manipulator DestroyControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "DestroyControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "DestroyControl"), value);
    }

    public static event ILContext.Manipulator ConfigureControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "ConfigureControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "ConfigureControl"), value);
    }

    public static event ILContext.Manipulator DrawGizmos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "DrawGizmos"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "DrawGizmos"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "Update"),
            value);
    }

    public static event ILContext.Manipulator SubmitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "SubmitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "SubmitControlState"), value);
    }

    public static event ILContext.Manipulator CommitControlState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "CommitControlState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "CommitControlState"), value);
    }

    public static event ILContext.Manipulator TouchBegan
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "TouchBegan"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "TouchBegan"),
            value);
    }

    public static event ILContext.Manipulator TouchMoved
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "TouchMoved"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "TouchMoved"),
            value);
    }

    public static event ILContext.Manipulator TouchEnded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "TouchEnded"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "TouchEnded"),
            value);
    }

    public static event ILContext.Manipulator get_IsActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_IsActive"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_IsActive"), value);
    }

    public static event ILContext.Manipulator get_IsNotActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_IsNotActive"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_IsNotActive"), value);
    }

    public static event ILContext.Manipulator get_RingPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_RingPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_RingPosition"), value);
    }

    public static event ILContext.Manipulator set_RingPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_RingPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_RingPosition"), value);
    }

    public static event ILContext.Manipulator get_KnobPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_KnobPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_KnobPosition"), value);
    }

    public static event ILContext.Manipulator set_KnobPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_KnobPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_KnobPosition"), value);
    }

    public static event ILContext.Manipulator get_Anchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_Anchor"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_Anchor"),
            value);
    }

    public static event ILContext.Manipulator set_Anchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_Anchor"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_Anchor"),
            value);
    }

    public static event ILContext.Manipulator get_Offset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_Offset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_Offset"),
            value);
    }

    public static event ILContext.Manipulator set_Offset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_Offset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_Offset"),
            value);
    }

    public static event ILContext.Manipulator get_OffsetUnitType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_OffsetUnitType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_OffsetUnitType"), value);
    }

    public static event ILContext.Manipulator set_OffsetUnitType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_OffsetUnitType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_OffsetUnitType"), value);
    }

    public static event ILContext.Manipulator get_ActiveArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_ActiveArea"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_ActiveArea"), value);
    }

    public static event ILContext.Manipulator set_ActiveArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_ActiveArea"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_ActiveArea"), value);
    }

    public static event ILContext.Manipulator get_AreaUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_AreaUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "get_AreaUnitType"), value);
    }

    public static event ILContext.Manipulator set_AreaUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_AreaUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchStickControl), "set_AreaUnitType"), value);
    }
}