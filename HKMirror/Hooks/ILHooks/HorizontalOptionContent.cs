using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HorizontalOptionContent,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHorizontalOptionContent
{
    public static event ILContext.Manipulator AddHorizontalOption_ContentArea_string_HorizontalOptionConfig
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HorizontalOptionContent), "AddHorizontalOption", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HorizontalOptionContent), "AddHorizontalOption", false), value);
    }

    public static event ILContext.Manipulator
        AddHorizontalOption_ContentArea_string_HorizontalOptionConfig_MenuOptionHorizontal
        {
            add => HookEndpointManager.Modify(
                ReflectionHelper.GetMethodInfo(typeof(HorizontalOptionContent), "AddHorizontalOption", false), value);
            remove => HookEndpointManager.Unmodify(
                ReflectionHelper.GetMethodInfo(typeof(HorizontalOptionContent), "AddHorizontalOption", false), value);
        }
}