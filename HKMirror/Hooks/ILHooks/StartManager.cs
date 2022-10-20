using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StartManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStartManager
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.StartManager.Awake += value;
        remove => IL.StartManager.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GetControllerSpriteForPlatform
    {
        add => IL.StartManager.GetControllerSpriteForPlatform += value;
        remove => IL.StartManager.GetControllerSpriteForPlatform -= value;
    }

    public static event ILContext.Manipulator SwitchToMenuScene
    {
        add => IL.StartManager.SwitchToMenuScene += value;
        remove => IL.StartManager.SwitchToMenuScene -= value;
    }

    public static event ILContext.Manipulator SetLanguage
    {
        add => IL.StartManager.SetLanguage += value;
        remove => IL.StartManager.SetLanguage -= value;
    }

    public static event ILContext.Manipulator FadeIn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "FadeIn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "FadeIn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeOut
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "FadeOut").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "FadeOut").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator CheckIsLanguageSet
    {
        add => IL.StartManager.CheckIsLanguageSet += value;
        remove => IL.StartManager.CheckIsLanguageSet -= value;
    }

    public static event ILContext.Manipulator ConfirmLanguage
    {
        add => IL.StartManager.ConfirmLanguage += value;
        remove => IL.StartManager.ConfirmLanguage -= value;
    }

    public static event ILContext.Manipulator CancelLanguage
    {
        add => IL.StartManager.CancelLanguage += value;
        remove => IL.StartManager.CancelLanguage -= value;
    }

    public static event ILContext.Manipulator ShowLanguageSelect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "ShowLanguageSelect").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "ShowLanguageSelect").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LanguageSettingDone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "LanguageSettingDone").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "LanguageSettingDone").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator orig_Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "orig_Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StartManager), "orig_Start").GetStateMachineTarget(), value);
    }
}