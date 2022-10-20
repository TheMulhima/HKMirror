using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for NativeInputModuleManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILNativeInputModuleManager
{
    public static event ILContext.Manipulator get_IsUsed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputModuleManager), "get_IsUsed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputModuleManager), "get_IsUsed", false), value);
    }

    public static event ILContext.Manipulator set_IsUsed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputModuleManager), "set_IsUsed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputModuleManager), "set_IsUsed", false), value);
    }

    public static event ILContext.Manipulator get_IsRestartRequired
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputModuleManager), "get_IsRestartRequired", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputModuleManager), "get_IsRestartRequired", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.NativeInputModuleManager.Awake += value;
        remove => IL.NativeInputModuleManager.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.NativeInputModuleManager.OnDestroy += value;
        remove => IL.NativeInputModuleManager.OnDestroy -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.NativeInputModuleManager.OnEnable += value;
        remove => IL.NativeInputModuleManager.OnEnable -= value;
    }

    public static event ILContext.Manipulator ChangeIsUsed
    {
        add => IL.NativeInputModuleManager.ChangeIsUsed += value;
        remove => IL.NativeInputModuleManager.ChangeIsUsed -= value;
    }
}