using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMPro_EventManager,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMPro_EventManager
{
    public static event ILContext.Manipulator ON_PRE_RENDER_OBJECT_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_PRE_RENDER_OBJECT_CHANGED", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_PRE_RENDER_OBJECT_CHANGED", false), value);
    }

    public static event ILContext.Manipulator ON_MATERIAL_PROPERTY_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_MATERIAL_PROPERTY_CHANGED", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_MATERIAL_PROPERTY_CHANGED", false), value);
    }

    public static event ILContext.Manipulator ON_FONT_PROPERTY_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_FONT_PROPERTY_CHANGED", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_FONT_PROPERTY_CHANGED", false), value);
    }

    public static event ILContext.Manipulator ON_SPRITE_ASSET_PROPERTY_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_SPRITE_ASSET_PROPERTY_CHANGED", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_SPRITE_ASSET_PROPERTY_CHANGED", false),
            value);
    }

    public static event ILContext.Manipulator ON_TEXTMESHPRO_PROPERTY_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXTMESHPRO_PROPERTY_CHANGED", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXTMESHPRO_PROPERTY_CHANGED", false),
            value);
    }

    public static event ILContext.Manipulator ON_DRAG_AND_DROP_MATERIAL_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_DRAG_AND_DROP_MATERIAL_CHANGED", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_DRAG_AND_DROP_MATERIAL_CHANGED", false),
            value);
    }

    public static event ILContext.Manipulator ON_TEXT_STYLE_PROPERTY_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXT_STYLE_PROPERTY_CHANGED", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXT_STYLE_PROPERTY_CHANGED", false), value);
    }

    public static event ILContext.Manipulator ON_COLOR_GRAIDENT_PROPERTY_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_COLOR_GRAIDENT_PROPERTY_CHANGED", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_COLOR_GRAIDENT_PROPERTY_CHANGED", false),
            value);
    }

    public static event ILContext.Manipulator ON_TEXT_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXT_CHANGED", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXT_CHANGED", false), value);
    }

    public static event ILContext.Manipulator ON_TMP_SETTINGS_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TMP_SETTINGS_CHANGED", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TMP_SETTINGS_CHANGED", false), value);
    }

    public static event ILContext.Manipulator ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED", false),
            value);
    }

    public static event ILContext.Manipulator ON_COMPUTE_DT_EVENT
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_COMPUTE_DT_EVENT", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_EventManager), "ON_COMPUTE_DT_EVENT", false), value);
    }
}