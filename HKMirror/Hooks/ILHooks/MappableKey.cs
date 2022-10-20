using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MappableKey.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMappableKey
{
    public static event ILContext.Manipulator Start
    {
        add => IL.MappableKey.Start += value;
        remove => IL.MappableKey.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MappableKey.OnEnable += value;
        remove => IL.MappableKey.OnEnable -= value;
    }

    public static event ILContext.Manipulator GetBinding
    {
        add => IL.MappableKey.GetBinding += value;
        remove => IL.MappableKey.GetBinding -= value;
    }

    public static event ILContext.Manipulator ListenForNewButton
    {
        add => IL.MappableKey.ListenForNewButton += value;
        remove => IL.MappableKey.ListenForNewButton -= value;
    }

    public static event ILContext.Manipulator ShowCurrentBinding
    {
        add => IL.MappableKey.ShowCurrentBinding += value;
        remove => IL.MappableKey.ShowCurrentBinding -= value;
    }

    public static event ILContext.Manipulator AbortRebind
    {
        add => IL.MappableKey.AbortRebind += value;
        remove => IL.MappableKey.AbortRebind -= value;
    }

    public static event ILContext.Manipulator StopActionListening
    {
        add => IL.MappableKey.StopActionListening += value;
        remove => IL.MappableKey.StopActionListening -= value;
    }

    public static event ILContext.Manipulator OnBindingFound
    {
        add => IL.MappableKey.OnBindingFound += value;
        remove => IL.MappableKey.OnBindingFound -= value;
    }

    public static event ILContext.Manipulator OnBindingAdded
    {
        add => IL.MappableKey.OnBindingAdded += value;
        remove => IL.MappableKey.OnBindingAdded -= value;
    }

    public static event ILContext.Manipulator OnBindingRejected
    {
        add => IL.MappableKey.OnBindingRejected += value;
        remove => IL.MappableKey.OnBindingRejected -= value;
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => IL.MappableKey.OnSubmit += value;
        remove => IL.MappableKey.OnSubmit -= value;
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => IL.MappableKey.OnPointerClick += value;
        remove => IL.MappableKey.OnPointerClick -= value;
    }

    public static event ILContext.Manipulator OnCancel
    {
        add => IL.MappableKey.OnCancel += value;
        remove => IL.MappableKey.OnCancel -= value;
    }

    public static event ILContext.Manipulator StopListeningForNewKey
    {
        add => IL.MappableKey.StopListeningForNewKey += value;
        remove => IL.MappableKey.StopListeningForNewKey -= value;
    }

    public static event ILContext.Manipulator SetupUnmappableKeys
    {
        add => IL.MappableKey.SetupUnmappableKeys += value;
        remove => IL.MappableKey.SetupUnmappableKeys -= value;
    }

    public static event ILContext.Manipulator SetupBindingListenOptions
    {
        add => IL.MappableKey.SetupBindingListenOptions += value;
        remove => IL.MappableKey.SetupBindingListenOptions -= value;
    }

    public static event ILContext.Manipulator SetupRefs
    {
        add => IL.MappableKey.SetupRefs += value;
        remove => IL.MappableKey.SetupRefs -= value;
    }

    public static event ILContext.Manipulator InitCustomActions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "InitCustomActions"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "InitCustomActions"),
            value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "OnDestroy"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "OnDestroy"), value);
    }

    public static event ILContext.Manipulator orig_GetBinding
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "orig_GetBinding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "orig_GetBinding"),
            value);
    }

    public static event ILContext.Manipulator orig_SetupBindingListenOptions
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MappableKey), "orig_SetupBindingListenOptions"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MappableKey), "orig_SetupBindingListenOptions"), value);
    }

    public static event ILContext.Manipulator orig_SetupRefs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "orig_SetupRefs"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MappableKey), "orig_SetupRefs"),
            value);
    }
}