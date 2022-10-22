using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputDeviceStyleExtensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputDeviceStyleExtensions
{
    public static event ILContext.Manipulator LeftCommandControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "LeftCommandControl", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "LeftCommandControl", false), value);
    }

    public static event ILContext.Manipulator RightCommandControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "RightCommandControl", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "RightCommandControl", false), value);
    }
}