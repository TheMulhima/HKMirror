using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for uGuiInputFieldSetCharacterLimit.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILuGuiInputFieldSetCharacterLimit
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "Reset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "DoSetValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "DoSetValue"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldSetCharacterLimit), "OnExit"), value);
    }
}