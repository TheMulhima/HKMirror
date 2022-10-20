using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for uGuiRawImageSetTexture.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILuGuiRawImageSetTexture
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "OnEnter"), value);
    }

    public static event ILContext.Manipulator DoSetValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "DoSetValue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "DoSetValue"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "OnExit"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiRawImageSetTexture), "OnExit"),
            value);
    }
}