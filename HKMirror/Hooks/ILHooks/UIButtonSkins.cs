using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UIButtonSkins.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUIButtonSkins
{
    public static event ILContext.Manipulator get_listeningKey
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "get_listeningKey"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "get_listeningKey"), value);
    }

    public static event ILContext.Manipulator set_listeningKey
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "set_listeningKey"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "set_listeningKey"), value);
    }

    public static event ILContext.Manipulator get_listeningButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "get_listeningButton"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "get_listeningButton"), value);
    }

    public static event ILContext.Manipulator set_listeningButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "set_listeningButton"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "set_listeningButton"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.UIButtonSkins.Start += value;
        remove => IL.UIButtonSkins.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.UIButtonSkins.OnEnable += value;
        remove => IL.UIButtonSkins.OnEnable -= value;
    }

    public static event ILContext.Manipulator GetButtonSkinFor_PlayerAction
    {
        add => IL.UIButtonSkins.GetButtonSkinFor_PlayerAction += value;
        remove => IL.UIButtonSkins.GetButtonSkinFor_PlayerAction -= value;
    }

    public static event ILContext.Manipulator GetKeyboardSkinFor
    {
        add => IL.UIButtonSkins.GetKeyboardSkinFor += value;
        remove => IL.UIButtonSkins.GetKeyboardSkinFor -= value;
    }

    public static event ILContext.Manipulator GetControllerButtonSkinFor
    {
        add => IL.UIButtonSkins.GetControllerButtonSkinFor += value;
        remove => IL.UIButtonSkins.GetControllerButtonSkinFor -= value;
    }

    public static event ILContext.Manipulator GetButtonSkinFor_HeroActionButton
    {
        add => IL.UIButtonSkins.GetButtonSkinFor_HeroActionButton += value;
        remove => IL.UIButtonSkins.GetButtonSkinFor_HeroActionButton -= value;
    }

    public static event ILContext.Manipulator ShowCurrentKeyboardMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "ShowCurrentKeyboardMappings")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "ShowCurrentKeyboardMappings")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ShowCurrentButtonMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "ShowCurrentButtonMappings").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "ShowCurrentButtonMappings").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator RefreshKeyMappings
    {
        add => IL.UIButtonSkins.RefreshKeyMappings += value;
        remove => IL.UIButtonSkins.RefreshKeyMappings -= value;
    }

    public static event ILContext.Manipulator RefreshButtonMappings
    {
        add => IL.UIButtonSkins.RefreshButtonMappings += value;
        remove => IL.UIButtonSkins.RefreshButtonMappings -= value;
    }

    public static event ILContext.Manipulator ListeningForKeyRebind
    {
        add => IL.UIButtonSkins.ListeningForKeyRebind += value;
        remove => IL.UIButtonSkins.ListeningForKeyRebind -= value;
    }

    public static event ILContext.Manipulator ListeningForButtonRebind
    {
        add => IL.UIButtonSkins.ListeningForButtonRebind += value;
        remove => IL.UIButtonSkins.ListeningForButtonRebind -= value;
    }

    public static event ILContext.Manipulator FinishedListeningForKey
    {
        add => IL.UIButtonSkins.FinishedListeningForKey += value;
        remove => IL.UIButtonSkins.FinishedListeningForKey -= value;
    }

    public static event ILContext.Manipulator FinishedListeningForButton
    {
        add => IL.UIButtonSkins.FinishedListeningForButton += value;
        remove => IL.UIButtonSkins.FinishedListeningForButton -= value;
    }

    public static event ILContext.Manipulator GetButtonSkinFor_InputControlType
    {
        add => IL.UIButtonSkins.GetButtonSkinFor_InputControlType += value;
        remove => IL.UIButtonSkins.GetButtonSkinFor_InputControlType -= value;
    }

    public static event ILContext.Manipulator GetButtonSkinFor_string
    {
        add => IL.UIButtonSkins.GetButtonSkinFor_string += value;
        remove => IL.UIButtonSkins.GetButtonSkinFor_string -= value;
    }

    public static event ILContext.Manipulator SetupRefs
    {
        add => IL.UIButtonSkins.SetupRefs += value;
        remove => IL.UIButtonSkins.SetupRefs -= value;
    }

    public static event ILContext.Manipulator AddMappableKey
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "AddMappableKey"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "AddMappableKey"),
            value);
    }

    public static event ILContext.Manipulator RemoveMappableKey
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "RemoveMappableKey"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "RemoveMappableKey"), value);
    }

    public static event ILContext.Manipulator AddMappableControllerButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "AddMappableControllerButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "AddMappableControllerButton"), value);
    }

    public static event ILContext.Manipulator RemoveMappableControllerButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "RemoveMappableControllerButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "RemoveMappableControllerButton"), value);
    }

    public static event ILContext.Manipulator orig_RefreshKeyMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_RefreshKeyMappings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_RefreshKeyMappings"), value);
    }

    public static event ILContext.Manipulator orig_ShowCurrentKeyboardMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_ShowCurrentKeyboardMappings")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_ShowCurrentKeyboardMappings")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator orig_RefreshButtonMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_RefreshButtonMappings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_RefreshButtonMappings"), value);
    }

    public static event ILContext.Manipulator orig_ShowCurrentButtonMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_ShowCurrentButtonMappings")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_ShowCurrentButtonMappings")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator orig_GetButtonSkinFor
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_GetButtonSkinFor"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_GetButtonSkinFor"), value);
    }

    public static event ILContext.Manipulator orig_SetupRefs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_SetupRefs"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIButtonSkins), "orig_SetupRefs"),
            value);
    }
}