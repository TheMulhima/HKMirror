using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorChallengeCompleteUI_BindingIcon,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorChallengeCompleteUI_BindingIcon
{
    public static event ILContext.Manipulator SetAlreadyVisible
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "SetAlreadyVisible"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "SetAlreadyVisible"),
            value);
    }

    public static event ILContext.Manipulator DoAppearAnim
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "DoAppearAnim")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "DoAppearAnim")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator DoAllAppearAnim
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "DoAllAppearAnim")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "DoAllAppearAnim")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetAllUnlocked
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "SetAllUnlocked"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeCompleteUI.BindingIcon), "SetAllUnlocked"), value);
    }
}