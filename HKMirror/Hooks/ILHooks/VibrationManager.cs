using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VibrationManager,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVibrationManager
{
    public static event ILContext.Manipulator get_IsMuted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationManager), "get_IsMuted", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationManager), "get_IsMuted", false), value);
    }

    public static event ILContext.Manipulator set_IsMuted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationManager), "set_IsMuted", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationManager), "set_IsMuted", false), value);
    }

    public static event ILContext.Manipulator GetMixer
    {
        add => IL.VibrationManager.GetMixer += value;
        remove => IL.VibrationManager.GetMixer -= value;
    }

    public static event ILContext.Manipulator PlayVibrationClipOneShot
    {
        add => IL.VibrationManager.PlayVibrationClipOneShot += value;
        remove => IL.VibrationManager.PlayVibrationClipOneShot -= value;
    }

    public static event ILContext.Manipulator StopAllVibration
    {
        add => IL.VibrationManager.StopAllVibration += value;
        remove => IL.VibrationManager.StopAllVibration -= value;
    }

    public static event ILContext.Manipulator StopAllVibrationsWithTag
    {
        add => IL.VibrationManager.StopAllVibrationsWithTag += value;
        remove => IL.VibrationManager.StopAllVibrationsWithTag -= value;
    }
}