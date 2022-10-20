using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayerActionSetConverter.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayerActionSetConverter
{
    public static event ILContext.Manipulator CanConvert
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerActionSetConverter), "CanConvert"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerActionSetConverter), "CanConvert"), value);
    }

    public static event ILContext.Manipulator ReadJson
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerActionSetConverter), "ReadJson"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerActionSetConverter), "ReadJson"), value);
    }

    public static event ILContext.Manipulator WriteJson
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerActionSetConverter), "WriteJson"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerActionSetConverter), "WriteJson"), value);
    }
}