using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetBoxColliderTrigger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetBoxColliderTrigger
{
    public static event ILContext.Manipulator Reset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetBoxColliderTrigger), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetBoxColliderTrigger), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetBoxColliderTrigger), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetBoxColliderTrigger), "OnEnter"),
            value);
    }
}