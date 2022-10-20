using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SmoothFlyTo.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSmoothFlyTo
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "Reset"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "Awake"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "OnPreprocess"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "OnPreprocess"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "OnFixedUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "OnFixedUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoChase
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "DoChase"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SmoothFlyTo), "DoChase"), value);
    }
}