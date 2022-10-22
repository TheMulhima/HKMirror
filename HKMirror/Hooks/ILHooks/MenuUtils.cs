using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuUtils,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuUtils
{
    public static event ILContext.Manipulator CreateMenuBuilder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuUtils), "CreateMenuBuilder", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuUtils), "CreateMenuBuilder", false), value);
    }

    public static event ILContext.Manipulator CreateMenuBuilderWithBackButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuUtils), "CreateMenuBuilderWithBackButton", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuUtils), "CreateMenuBuilderWithBackButton", false), value);
    }
}