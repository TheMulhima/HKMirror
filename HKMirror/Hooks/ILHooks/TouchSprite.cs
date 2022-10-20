using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchSprite.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchSprite
{
    public static event ILContext.Manipulator get_Dirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Dirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Dirty"), value);
    }

    public static event ILContext.Manipulator set_Dirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Dirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Dirty"), value);
    }

    public static event ILContext.Manipulator get_Ready
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Ready"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Ready"), value);
    }

    public static event ILContext.Manipulator set_Ready
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Ready"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Ready"), value);
    }

    public static event ILContext.Manipulator Create
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Create"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Create"), value);
    }

    public static event ILContext.Manipulator Delete
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Delete"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Delete"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Update"), value);
    }

    public static event ILContext.Manipulator Update_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Update"), value);
    }

    public static event ILContext.Manipulator CreateSpriteGameObject
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "CreateSpriteGameObject"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "CreateSpriteGameObject"), value);
    }

    public static event ILContext.Manipulator CreateSpriteRenderer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "CreateSpriteRenderer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "CreateSpriteRenderer"), value);
    }

    public static event ILContext.Manipulator ScaleSpriteInPixels
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "ScaleSpriteInPixels"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "ScaleSpriteInPixels"), value);
    }

    public static event ILContext.Manipulator ScaleSpriteInPercent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "ScaleSpriteInPercent"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "ScaleSpriteInPercent"), value);
    }

    public static event ILContext.Manipulator Contains_Vector2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Contains"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Contains"), value);
    }

    public static event ILContext.Manipulator Contains_Touch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Contains"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "Contains"), value);
    }

    public static event ILContext.Manipulator DrawGizmos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "DrawGizmos"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "DrawGizmos"), value);
    }

    public static event ILContext.Manipulator get_State
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_State"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_State"), value);
    }

    public static event ILContext.Manipulator set_State
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_State"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_State"), value);
    }

    public static event ILContext.Manipulator get_BusySprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_BusySprite"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_BusySprite"),
            value);
    }

    public static event ILContext.Manipulator set_BusySprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_BusySprite"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_BusySprite"),
            value);
    }

    public static event ILContext.Manipulator get_IdleSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_IdleSprite"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_IdleSprite"),
            value);
    }

    public static event ILContext.Manipulator set_IdleSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_IdleSprite"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_IdleSprite"),
            value);
    }

    public static event ILContext.Manipulator set_Sprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Sprite"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Sprite"), value);
    }

    public static event ILContext.Manipulator get_BusyColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_BusyColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_BusyColor"),
            value);
    }

    public static event ILContext.Manipulator set_BusyColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_BusyColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_BusyColor"),
            value);
    }

    public static event ILContext.Manipulator get_IdleColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_IdleColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_IdleColor"),
            value);
    }

    public static event ILContext.Manipulator set_IdleColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_IdleColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_IdleColor"),
            value);
    }

    public static event ILContext.Manipulator get_Shape
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Shape"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Shape"), value);
    }

    public static event ILContext.Manipulator set_Shape
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Shape"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Shape"), value);
    }

    public static event ILContext.Manipulator get_SizeUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_SizeUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_SizeUnitType"),
            value);
    }

    public static event ILContext.Manipulator set_SizeUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_SizeUnitType"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_SizeUnitType"),
            value);
    }

    public static event ILContext.Manipulator get_Size
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Size"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Size"), value);
    }

    public static event ILContext.Manipulator set_Size
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Size"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Size"), value);
    }

    public static event ILContext.Manipulator get_WorldSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_WorldSize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_WorldSize"),
            value);
    }

    public static event ILContext.Manipulator get_Position
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Position"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "get_Position"),
            value);
    }

    public static event ILContext.Manipulator set_Position
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Position"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchSprite), "set_Position"),
            value);
    }
}