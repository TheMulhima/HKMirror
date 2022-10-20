using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SteamManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSteamManager
{
    public static event ILContext.Manipulator get_Instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Instance", false), value);
    }

    public static event ILContext.Manipulator get_Initialized
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Initialized", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SteamManager), "get_Initialized", false), value);
    }

    public static event ILContext.Manipulator SteamAPIDebugTextHook
    {
        add => IL.SteamManager.SteamAPIDebugTextHook += value;
        remove => IL.SteamManager.SteamAPIDebugTextHook -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.SteamManager.Awake += value;
        remove => IL.SteamManager.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SteamManager.OnEnable += value;
        remove => IL.SteamManager.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.SteamManager.OnDestroy += value;
        remove => IL.SteamManager.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SteamManager.Update += value;
        remove => IL.SteamManager.Update -= value;
    }
}