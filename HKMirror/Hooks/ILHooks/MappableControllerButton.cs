using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MappableControllerButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMappableControllerButton
{
    public static event ILContext.Manipulator Start
    {
        add => IL.MappableControllerButton.Start += value;
        remove => IL.MappableControllerButton.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MappableControllerButton.OnEnable += value;
        remove => IL.MappableControllerButton.OnEnable -= value;
    }

    public static event ILContext.Manipulator GetBinding
    {
        add => IL.MappableControllerButton.GetBinding += value;
        remove => IL.MappableControllerButton.GetBinding -= value;
    }

    public static event ILContext.Manipulator ListenForNewButton
    {
        add => IL.MappableControllerButton.ListenForNewButton += value;
        remove => IL.MappableControllerButton.ListenForNewButton -= value;
    }

    public static event ILContext.Manipulator ShowCurrentBinding
    {
        add => IL.MappableControllerButton.ShowCurrentBinding += value;
        remove => IL.MappableControllerButton.ShowCurrentBinding -= value;
    }

    public static event ILContext.Manipulator AbortRebind
    {
        add => IL.MappableControllerButton.AbortRebind += value;
        remove => IL.MappableControllerButton.AbortRebind -= value;
    }

    public static event ILContext.Manipulator StopActionListening
    {
        add => IL.MappableControllerButton.StopActionListening += value;
        remove => IL.MappableControllerButton.StopActionListening -= value;
    }

    public static event ILContext.Manipulator OnBindingFound
    {
        add => IL.MappableControllerButton.OnBindingFound += value;
        remove => IL.MappableControllerButton.OnBindingFound -= value;
    }

    public static event ILContext.Manipulator OnBindingAdded
    {
        add => IL.MappableControllerButton.OnBindingAdded += value;
        remove => IL.MappableControllerButton.OnBindingAdded -= value;
    }

    public static event ILContext.Manipulator OnBindingRejected
    {
        add => IL.MappableControllerButton.OnBindingRejected += value;
        remove => IL.MappableControllerButton.OnBindingRejected -= value;
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => IL.MappableControllerButton.OnSubmit += value;
        remove => IL.MappableControllerButton.OnSubmit -= value;
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => IL.MappableControllerButton.OnPointerClick += value;
        remove => IL.MappableControllerButton.OnPointerClick -= value;
    }

    public static event ILContext.Manipulator OnCancel
    {
        add => IL.MappableControllerButton.OnCancel += value;
        remove => IL.MappableControllerButton.OnCancel -= value;
    }

    public static event ILContext.Manipulator StopListeningForNewButton
    {
        add => IL.MappableControllerButton.StopListeningForNewButton += value;
        remove => IL.MappableControllerButton.StopListeningForNewButton -= value;
    }

    public static event ILContext.Manipulator SetupUnmappableButtons
    {
        add => IL.MappableControllerButton.SetupUnmappableButtons += value;
        remove => IL.MappableControllerButton.SetupUnmappableButtons -= value;
    }

    public static event ILContext.Manipulator SetupBindingListenOptions
    {
        add => IL.MappableControllerButton.SetupBindingListenOptions += value;
        remove => IL.MappableControllerButton.SetupBindingListenOptions -= value;
    }

    public static event ILContext.Manipulator SetupRefs
    {
        add => IL.MappableControllerButton.SetupRefs += value;
        remove => IL.MappableControllerButton.SetupRefs -= value;
    }

    public static event ILContext.Manipulator orig_SetupUnmappableButtons
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_SetupUnmappableButtons"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_SetupUnmappableButtons"), value);
    }

    public static event ILContext.Manipulator InitCustomActions
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "InitCustomActions"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "InitCustomActions"), value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "OnDestroy"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "OnDestroy"), value);
    }

    public static event ILContext.Manipulator GetBindingPublic
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "GetBindingPublic"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "GetBindingPublic"), value);
    }

    public static event ILContext.Manipulator orig_GetBinding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_GetBinding"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_GetBinding"), value);
    }

    public static event ILContext.Manipulator orig_SetupBindingListenOptions
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_SetupBindingListenOptions"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_SetupBindingListenOptions"), value);
    }

    public static event ILContext.Manipulator orig_ShowCurrentBinding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_ShowCurrentBinding"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_ShowCurrentBinding"), value);
    }

    public static event ILContext.Manipulator orig_SetupRefs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_SetupRefs"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableControllerButton), "orig_SetupRefs"), value);
    }
}