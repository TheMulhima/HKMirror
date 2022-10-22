namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueSetUnlockIndicator,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueSetUnlockIndicator
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BossStatueSetUnlockIndicator.Start += value;
        remove => IL.BossStatueSetUnlockIndicator.Start -= value;
    }

    public static event ILContext.Manipulator CheckIfNewBossStatue
    {
        add => IL.BossStatueSetUnlockIndicator.CheckIfNewBossStatue += value;
        remove => IL.BossStatueSetUnlockIndicator.CheckIfNewBossStatue -= value;
    }
}