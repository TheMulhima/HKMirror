using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorChallengeCompleteUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorChallengeCompleteUI
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BossDoorChallengeCompleteUI.Start += value;
        remove => IL.BossDoorChallengeCompleteUI.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.BossDoorChallengeCompleteUI.Update += value;
        remove => IL.BossDoorChallengeCompleteUI.Update -= value;
    }

    public static event ILContext.Manipulator ShowAchievements
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI), "ShowAchievements")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI), "ShowAchievements")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Sequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI), "Sequence").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI), "Sequence").GetStateMachineTarget(),
            value);
    }
}