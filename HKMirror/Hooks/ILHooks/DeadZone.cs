using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeadZone,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeadZone
{
    public static event ILContext.Manipulator SeparateNotNormalized
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DeadZone), "SeparateNotNormalized", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeadZone), "SeparateNotNormalized", false), value);
    }

    public static event ILContext.Manipulator Separate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Separate", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Separate", false),
            value);
    }

    public static event ILContext.Manipulator Circular
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Circular", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Circular", false),
            value);
    }
}