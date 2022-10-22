using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUtils_Extensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUtils_Extensions
{
    public static event ILContext.Manipulator IndexOf_ArrayList_Object
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "IndexOf", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "IndexOf", false), value);
    }

    public static event ILContext.Manipulator IndexOf_ArrayList_Object_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "IndexOf", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "IndexOf", false), value);
    }

    public static event ILContext.Manipulator IndexOf_ArrayList_Object_int_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "IndexOf", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "IndexOf", false), value);
    }

    public static event ILContext.Manipulator LastIndexOf_ArrayList_Object
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "LastIndexOf", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "LastIndexOf", false), value);
    }

    public static event ILContext.Manipulator LastIndexOf_ArrayList_Object_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "LastIndexOf", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "LastIndexOf", false), value);
    }

    public static event ILContext.Manipulator LastIndexOf_ArrayList_Object_int_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "LastIndexOf", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayMakerUtils_Extensions), "LastIndexOf", false), value);
    }
}