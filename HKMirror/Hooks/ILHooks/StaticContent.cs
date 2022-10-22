using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StaticContent,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStaticContent
{
    public static event ILContext.Manipulator AddStaticPanel
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddStaticPanel", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddStaticPanel", false), value);
    }

    public static event ILContext.Manipulator AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false), value);
    }

    public static event ILContext.Manipulator AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false), value);
    }

    public static event ILContext.Manipulator AddImagePanel_ContentArea_string_RelVector2_Sprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false), value);
    }

    public static event ILContext.Manipulator AddImagePanel_ContentArea_string_RelVector2_Sprite_Image
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false), value);
    }

    public static event ILContext.Manipulator AddWrappedItem_ContentArea_string_ContentArea
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
    }

    public static event ILContext.Manipulator AddWrappedItem_ContentArea_string_ContentArea_GameObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
    }
}