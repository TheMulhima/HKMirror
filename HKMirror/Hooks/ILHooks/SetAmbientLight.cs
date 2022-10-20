using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetAmbientLight.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetAmbientLight
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoSetAmbientColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "DoSetAmbientColor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SetAmbientLight), "DoSetAmbientColor"), value);
    }
}