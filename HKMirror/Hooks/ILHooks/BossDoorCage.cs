using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorCage.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorCage
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossDoorCage.Awake += value;
        remove => IL.BossDoorCage.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossDoorCage.Start += value;
        remove => IL.BossDoorCage.Start -= value;
    }

    public static event ILContext.Manipulator Unlock
    {
        add => IL.BossDoorCage.Unlock += value;
        remove => IL.BossDoorCage.Unlock -= value;
    }

    public static event ILContext.Manipulator UnlockRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorCage), "UnlockRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorCage), "UnlockRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StartShakeLock
    {
        add => IL.BossDoorCage.StartShakeLock += value;
        remove => IL.BossDoorCage.StartShakeLock -= value;
    }

    public static event ILContext.Manipulator StopShakeLock
    {
        add => IL.BossDoorCage.StopShakeLock += value;
        remove => IL.BossDoorCage.StopShakeLock -= value;
    }
}