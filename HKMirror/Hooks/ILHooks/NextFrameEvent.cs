using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for NextFrameEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILNextFrameEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NextFrameEvent), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NextFrameEvent), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NextFrameEvent), "OnEnter"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NextFrameEvent), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NextFrameEvent), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NextFrameEvent), "OnUpdate"),
            value);
    }
}