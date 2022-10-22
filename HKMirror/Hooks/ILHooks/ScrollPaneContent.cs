using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ScrollPaneContent,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILScrollPaneContent
{
    public static event ILContext.Manipulator
        AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
        {
            add => HookEndpointManager.Modify(
                ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false), value);
            remove => HookEndpointManager.Unmodify(
                ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false), value);
        }

    public static event ILContext.Manipulator
        AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
        {
            add => HookEndpointManager.Modify(
                ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false), value);
            remove => HookEndpointManager.Unmodify(
                ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false), value);
        }

    public static event ILContext.Manipulator AddScrollbar
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollbar", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollbar", false), value);
    }
}