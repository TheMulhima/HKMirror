using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorTargetLock.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorTargetLock
{
    public static event ILContext.Manipulator get_IsUnlocked
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "get_IsUnlocked"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "get_IsUnlocked"), value);
    }

    public static event ILContext.Manipulator set_IsUnlocked
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "set_IsUnlocked"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "set_IsUnlocked"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.BossDoorTargetLock.Awake += value;
        remove => IL.BossDoorTargetLock.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossDoorTargetLock.Start += value;
        remove => IL.BossDoorTargetLock.Start -= value;
    }

    public static event ILContext.Manipulator UnlockSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "UnlockSequence").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock), "UnlockSequence").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator StartRoarLock
    {
        add => IL.BossDoorTargetLock.StartRoarLock += value;
        remove => IL.BossDoorTargetLock.StartRoarLock -= value;
    }

    public static event ILContext.Manipulator StopRoarLock
    {
        add => IL.BossDoorTargetLock.StopRoarLock += value;
        remove => IL.BossDoorTargetLock.StopRoarLock -= value;
    }
}