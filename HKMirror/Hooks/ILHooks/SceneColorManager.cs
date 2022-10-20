using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SceneColorManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneColorManager
{
    public static event ILContext.Manipulator get_markerActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "get_markerActive"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "get_markerActive"), value);
    }

    public static event ILContext.Manipulator set_markerActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "set_markerActive"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "set_markerActive"), value);
    }

    public static event ILContext.Manipulator SetFactor
    {
        add => IL.SceneColorManager.SetFactor += value;
        remove => IL.SceneColorManager.SetFactor -= value;
    }

    public static event ILContext.Manipulator SetSaturationA
    {
        add => IL.SceneColorManager.SetSaturationA += value;
        remove => IL.SceneColorManager.SetSaturationA -= value;
    }

    public static event ILContext.Manipulator SetSaturationB
    {
        add => IL.SceneColorManager.SetSaturationB += value;
        remove => IL.SceneColorManager.SetSaturationB -= value;
    }

    public static event ILContext.Manipulator get_startBufferActive
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "get_startBufferActive"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "get_startBufferActive"), value);
    }

    public static event ILContext.Manipulator set_startBufferActive
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "set_startBufferActive"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "set_startBufferActive"), value);
    }

    public static event ILContext.Manipulator GameInit
    {
        add => IL.SceneColorManager.GameInit += value;
        remove => IL.SceneColorManager.GameInit -= value;
    }

    public static event ILContext.Manipulator SceneInit
    {
        add => IL.SceneColorManager.SceneInit += value;
        remove => IL.SceneColorManager.SceneInit -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SceneColorManager.Update += value;
        remove => IL.SceneColorManager.Update -= value;
    }

    public static event ILContext.Manipulator OnLevelUnload
    {
        add => IL.SceneColorManager.OnLevelUnload += value;
        remove => IL.SceneColorManager.OnLevelUnload -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.SceneColorManager.OnDisable += value;
        remove => IL.SceneColorManager.OnDisable -= value;
    }

    public static event ILContext.Manipulator ForceRefresh
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "ForceRefresh").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneColorManager), "ForceRefresh").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FinishBufferPeriod
    {
        add => IL.SceneColorManager.FinishBufferPeriod += value;
        remove => IL.SceneColorManager.FinishBufferPeriod -= value;
    }

    public static event ILContext.Manipulator MarkerActive
    {
        add => IL.SceneColorManager.MarkerActive += value;
        remove => IL.SceneColorManager.MarkerActive -= value;
    }

    public static event ILContext.Manipulator UpdateScript
    {
        add => IL.SceneColorManager.UpdateScript += value;
        remove => IL.SceneColorManager.UpdateScript -= value;
    }

    public static event ILContext.Manipulator EditorHasChanged
    {
        add => IL.SceneColorManager.EditorHasChanged += value;
        remove => IL.SceneColorManager.EditorHasChanged -= value;
    }

    public static event ILContext.Manipulator PairKeyframes
    {
        add => IL.SceneColorManager.PairKeyframes += value;
        remove => IL.SceneColorManager.PairKeyframes -= value;
    }

    public static event ILContext.Manipulator SimplePairKeyframes
    {
        add => IL.SceneColorManager.SimplePairKeyframes += value;
        remove => IL.SceneColorManager.SimplePairKeyframes -= value;
    }

    public static event ILContext.Manipulator CreatePair
    {
        add => IL.SceneColorManager.CreatePair += value;
        remove => IL.SceneColorManager.CreatePair -= value;
    }

    public static event ILContext.Manipulator CreateCurveFromKeyframes
    {
        add => IL.SceneColorManager.CreateCurveFromKeyframes += value;
        remove => IL.SceneColorManager.CreateCurveFromKeyframes -= value;
    }

    public static event ILContext.Manipulator AverageKeyframe
    {
        add => IL.SceneColorManager.AverageKeyframe += value;
        remove => IL.SceneColorManager.AverageKeyframe -= value;
    }

    public static event ILContext.Manipulator PairCurvesKeyframes
    {
        add => IL.SceneColorManager.PairCurvesKeyframes += value;
        remove => IL.SceneColorManager.PairCurvesKeyframes -= value;
    }

    public static event ILContext.Manipulator UpdateScriptParameters
    {
        add => IL.SceneColorManager.UpdateScriptParameters += value;
        remove => IL.SceneColorManager.UpdateScriptParameters -= value;
    }

    public static event ILContext.Manipulator PairedListsInitiated
    {
        add => IL.SceneColorManager.PairedListsInitiated += value;
        remove => IL.SceneColorManager.PairedListsInitiated -= value;
    }

    public static event ILContext.Manipulator UpdateSceneType
    {
        add => IL.SceneColorManager.UpdateSceneType += value;
        remove => IL.SceneColorManager.UpdateSceneType -= value;
    }
}