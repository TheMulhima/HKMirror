using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WorldToScreenPoint.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWorldToScreenPoint
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoWorldToScreenPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "DoWorldToScreenPoint"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(WorldToScreenPoint), "DoWorldToScreenPoint"), value);
    }
}