namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSequenceBindingsDisplay.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSequenceBindingsDisplay
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BossSequenceBindingsDisplay.Start += value;
        remove => IL.BossSequenceBindingsDisplay.Start -= value;
    }

    public static event ILContext.Manipulator CountBindings
    {
        add => IL.BossSequenceBindingsDisplay.CountBindings += value;
        remove => IL.BossSequenceBindingsDisplay.CountBindings -= value;
    }

    public static event ILContext.Manipulator CountCompletedBindings
    {
        add => IL.BossSequenceBindingsDisplay.CountCompletedBindings += value;
        remove => IL.BossSequenceBindingsDisplay.CountCompletedBindings -= value;
    }

    public static event ILContext.Manipulator CountTotalBindings
    {
        add => IL.BossSequenceBindingsDisplay.CountTotalBindings += value;
        remove => IL.BossSequenceBindingsDisplay.CountTotalBindings -= value;
    }
}