using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CutsceneHelper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCutsceneHelper
{
    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CutsceneHelper), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CutsceneHelper), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LoadNextScene
    {
        add => IL.CutsceneHelper.LoadNextScene += value;
        remove => IL.CutsceneHelper.LoadNextScene -= value;
    }

    public static event ILContext.Manipulator SkipCutscene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CutsceneHelper), "SkipCutscene").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CutsceneHelper), "SkipCutscene").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UnlockSkip
    {
        add => IL.CutsceneHelper.UnlockSkip += value;
        remove => IL.CutsceneHelper.UnlockSkip -= value;
    }

    public static event ILContext.Manipulator DoSceneLoad
    {
        add => IL.CutsceneHelper.DoSceneLoad += value;
        remove => IL.CutsceneHelper.DoSceneLoad -= value;
    }
}