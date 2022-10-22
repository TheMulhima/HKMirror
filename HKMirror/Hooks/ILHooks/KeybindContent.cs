using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeybindContent,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeybindContent
{
    public static event ILContext.Manipulator AddKeybind_ContentArea_string_PlayerAction_KeybindConfig
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeybindContent), "AddKeybind", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindContent), "AddKeybind", false), value);
    }

    public static event ILContext.Manipulator AddKeybind_ContentArea_string_PlayerAction_KeybindConfig_MappableKey
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeybindContent), "AddKeybind", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindContent), "AddKeybind", false), value);
    }

    public static event ILContext.Manipulator AddButtonBind
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindContent), "AddButtonBind", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindContent), "AddButtonBind", false), value);
    }
}