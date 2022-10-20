using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSequenceDoor.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSequenceDoor
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BossSequenceDoor.Start += value;
        remove => IL.BossSequenceDoor.Start -= value;
    }

    public static event ILContext.Manipulator SaveState
    {
        add => IL.BossSequenceDoor.SaveState += value;
        remove => IL.BossSequenceDoor.SaveState -= value;
    }

    public static event ILContext.Manipulator IsUnlocked
    {
        add => IL.BossSequenceDoor.IsUnlocked += value;
        remove => IL.BossSequenceDoor.IsUnlocked -= value;
    }

    public static event ILContext.Manipulator ShowLockUI
    {
        add => IL.BossSequenceDoor.ShowLockUI += value;
        remove => IL.BossSequenceDoor.ShowLockUI -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BossSequenceDoor.OnTriggerEnter2D += value;
        remove => IL.BossSequenceDoor.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator StartShake
    {
        add => IL.BossSequenceDoor.StartShake += value;
        remove => IL.BossSequenceDoor.StartShake -= value;
    }

    public static event ILContext.Manipulator StopShake
    {
        add => IL.BossSequenceDoor.StopShake += value;
        remove => IL.BossSequenceDoor.StopShake -= value;
    }

    public static event ILContext.Manipulator DoorUnlockSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceDoor), "DoorUnlockSequence").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceDoor), "DoorUnlockSequence").GetStateMachineTarget(),
            value);
    }
}