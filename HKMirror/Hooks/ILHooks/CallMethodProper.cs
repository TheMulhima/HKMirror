using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CallMethodProper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCallMethodProper
{
    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethodProper), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethodProper), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator DoMethodCall
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethodProper), "DoMethodCall"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethodProper), "DoMethodCall"),
            value);
    }

    public static event ILContext.Manipulator DoCache
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethodProper), "DoCache"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethodProper), "DoCache"),
            value);
    }
}