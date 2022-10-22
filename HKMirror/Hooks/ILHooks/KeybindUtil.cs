using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeybindUtil,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeybindUtil
{
    public static event ILContext.Manipulator ParseBinding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseBinding", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseBinding", false), value);
    }

    public static event ILContext.Manipulator GetControllerButtonBinding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "GetControllerButtonBinding", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "GetControllerButtonBinding", false), value);
    }

    public static event ILContext.Manipulator AddInputControlType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "AddInputControlType", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "AddInputControlType", false), value);
    }

    public static event ILContext.Manipulator ParseInputControlTypeBinding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseInputControlTypeBinding", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseInputControlTypeBinding", false), value);
    }
}