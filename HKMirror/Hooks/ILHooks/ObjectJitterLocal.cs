using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ObjectJitterLocal.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILObjectJitterLocal
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnPreprocess"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnPreprocess"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnFixedUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnFixedUpdate"), value);
    }

    public static event ILContext.Manipulator DoTranslate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "DoTranslate"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "DoTranslate"),
            value);
    }
}