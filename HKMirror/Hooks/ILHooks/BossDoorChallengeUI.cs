using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorChallengeUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorChallengeUI
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossDoorChallengeUI.Awake += value;
        remove => IL.BossDoorChallengeUI.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossDoorChallengeUI.Start += value;
        remove => IL.BossDoorChallengeUI.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.BossDoorChallengeUI.OnEnable += value;
        remove => IL.BossDoorChallengeUI.OnEnable -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.BossDoorChallengeUI.Setup += value;
        remove => IL.BossDoorChallengeUI.Setup -= value;
    }

    public static event ILContext.Manipulator UpdateAllButtons
    {
        add => IL.BossDoorChallengeUI.UpdateAllButtons += value;
        remove => IL.BossDoorChallengeUI.UpdateAllButtons -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.BossDoorChallengeUI.Show += value;
        remove => IL.BossDoorChallengeUI.Show -= value;
    }

    public static event ILContext.Manipulator ShowSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUI), "ShowSequence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUI), "ShowSequence").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.BossDoorChallengeUI.Hide += value;
        remove => IL.BossDoorChallengeUI.Hide -= value;
    }

    public static event ILContext.Manipulator HideSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUI), "HideSequence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUI), "HideSequence").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Begin
    {
        add => IL.BossDoorChallengeUI.Begin += value;
        remove => IL.BossDoorChallengeUI.Begin -= value;
    }
}