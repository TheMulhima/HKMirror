using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SceneAdditiveLoadConditional.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneAdditiveLoadConditional
{
    public static event ILContext.Manipulator get_SceneNameToLoad
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "get_SceneNameToLoad"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "get_SceneNameToLoad"), value);
    }

    public static event ILContext.Manipulator get_ShouldLoadBoss
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "get_ShouldLoadBoss", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "get_ShouldLoadBoss", false), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SceneAdditiveLoadConditional.OnEnable += value;
        remove => IL.SceneAdditiveLoadConditional.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.SceneAdditiveLoadConditional.OnDisable += value;
        remove => IL.SceneAdditiveLoadConditional.OnDisable -= value;
    }

    public static event ILContext.Manipulator LoadAll
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "LoadAll", false)
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "LoadAll", false)
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LoadRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "LoadRoutine").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneAdditiveLoadConditional), "LoadRoutine").GetStateMachineTarget(),
            value);
    }
}