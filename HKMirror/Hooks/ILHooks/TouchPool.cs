using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchPool.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchPool
{
    public static event ILContext.Manipulator FindOrCreateTouch
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FindOrCreateTouch"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FindOrCreateTouch"),
            value);
    }

    public static event ILContext.Manipulator FindTouch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FindTouch"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FindTouch"), value);
    }

    public static event ILContext.Manipulator NewTouch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "NewTouch"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "NewTouch"), value);
    }

    public static event ILContext.Manipulator FreeTouch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FreeTouch"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FreeTouch"), value);
    }

    public static event ILContext.Manipulator FreeEndedTouches
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FreeEndedTouches"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchPool), "FreeEndedTouches"),
            value);
    }
}