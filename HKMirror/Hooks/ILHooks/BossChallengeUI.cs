using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossChallengeUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossChallengeUI
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossChallengeUI.Awake += value;
        remove => IL.BossChallengeUI.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossChallengeUI.Start += value;
        remove => IL.BossChallengeUI.Start -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.BossChallengeUI.Setup += value;
        remove => IL.BossChallengeUI.Setup -= value;
    }

    public static event ILContext.Manipulator ShowUnlockEffect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossChallengeUI), "ShowUnlockEffect").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossChallengeUI), "ShowUnlockEffect").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetFirstSelected
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossChallengeUI), "SetFirstSelected").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossChallengeUI), "SetFirstSelected").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.BossChallengeUI.Hide += value;
        remove => IL.BossChallengeUI.Hide -= value;
    }

    public static event ILContext.Manipulator Hide_bool
    {
        add => IL.BossChallengeUI.Hide_bool += value;
        remove => IL.BossChallengeUI.Hide_bool -= value;
    }

    public static event ILContext.Manipulator HideAnim
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossChallengeUI), "HideAnim").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossChallengeUI), "HideAnim").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LoadBoss_int
    {
        add => IL.BossChallengeUI.LoadBoss_int += value;
        remove => IL.BossChallengeUI.LoadBoss_int -= value;
    }

    public static event ILContext.Manipulator LoadBoss_int_bool
    {
        add => IL.BossChallengeUI.LoadBoss_int_bool += value;
        remove => IL.BossChallengeUI.LoadBoss_int_bool -= value;
    }

    public static event ILContext.Manipulator RecordLastSelected
    {
        add => IL.BossChallengeUI.RecordLastSelected += value;
        remove => IL.BossChallengeUI.RecordLastSelected -= value;
    }
}