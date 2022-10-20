using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetNextLineCast2d.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetNextLineCast2d
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator DoGetNextCollider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "DoGetNextCollider"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "DoGetNextCollider"), value);
    }

    public static event ILContext.Manipulator GetLineCastAll
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "GetLineCastAll"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GetNextLineCast2d), "GetLineCastAll"), value);
    }
}