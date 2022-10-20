using MonoMod.RuntimeDetour.HookGen;
using XInputDotNetPure;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GamePad.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGamePad
{
    public static event ILContext.Manipulator GetState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamePad), "GetState", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamePad), "GetState", false),
            value);
    }

    public static event ILContext.Manipulator SetVibration
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamePad), "SetVibration", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamePad), "SetVibration", false),
            value);
    }
}