using InControl.UnityDeviceProfiles;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EightBitdoSNES30AndroidUnityProfile.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEightBitdoSNES30AndroidUnityProfile
{
    public static event ILContext.Manipulator Define
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(EightBitdoSNES30AndroidUnityProfile), "Define"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(EightBitdoSNES30AndroidUnityProfile), "Define"), value);
    }
}