using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorLockUIIcon.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorLockUIIcon
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossDoorLockUIIcon.Awake += value;
        remove => IL.BossDoorLockUIIcon.Awake -= value;
    }

    public static event ILContext.Manipulator SetUnlocked
    {
        add => IL.BossDoorLockUIIcon.SetUnlocked += value;
        remove => IL.BossDoorLockUIIcon.SetUnlocked -= value;
    }

    public static event ILContext.Manipulator PlayAnimWithDelay
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUIIcon), "PlayAnimWithDelay").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUIIcon), "PlayAnimWithDelay").GetStateMachineTarget(),
            value);
    }
}