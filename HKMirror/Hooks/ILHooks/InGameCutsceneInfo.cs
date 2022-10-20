using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InGameCutsceneInfo.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInGameCutsceneInfo
{
    public static event ILContext.Manipulator get_IsInCutscene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_IsInCutscene", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_IsInCutscene", false), value);
    }

    public static event ILContext.Manipulator get_CameraPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_CameraPosition", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InGameCutsceneInfo), "get_CameraPosition", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.InGameCutsceneInfo.Awake += value;
        remove => IL.InGameCutsceneInfo.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.InGameCutsceneInfo.OnDestroy += value;
        remove => IL.InGameCutsceneInfo.OnDestroy -= value;
    }
}