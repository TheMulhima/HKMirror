using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Vector3Converter.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVector3Converter
{
    public static event ILContext.Manipulator ReadJson
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Vector3Converter), "ReadJson"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Vector3Converter), "ReadJson"),
            value);
    }

    public static event ILContext.Manipulator WriteJson
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Vector3Converter), "WriteJson"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Vector3Converter), "WriteJson"),
            value);
    }
}