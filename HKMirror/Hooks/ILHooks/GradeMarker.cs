using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GradeMarker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGradeMarker
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GradeMarker.OnEnable += value;
        remove => IL.GradeMarker.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.GradeMarker.OnDisable += value;
        remove => IL.GradeMarker.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GradeMarker.Start += value;
        remove => IL.GradeMarker.Start -= value;
    }

    public static event ILContext.Manipulator OnUnloadingLevel
    {
        add => IL.GradeMarker.OnUnloadingLevel += value;
        remove => IL.GradeMarker.OnUnloadingLevel -= value;
    }

    public static event ILContext.Manipulator SetStartSizeForTrigger
    {
        add => IL.GradeMarker.SetStartSizeForTrigger += value;
        remove => IL.GradeMarker.SetStartSizeForTrigger -= value;
    }

    public static event ILContext.Manipulator Activate
    {
        add => IL.GradeMarker.Activate += value;
        remove => IL.GradeMarker.Activate -= value;
    }

    public static event ILContext.Manipulator Deactivate
    {
        add => IL.GradeMarker.Deactivate += value;
        remove => IL.GradeMarker.Deactivate -= value;
    }

    public static event ILContext.Manipulator ActivateGradual
    {
        add => IL.GradeMarker.ActivateGradual += value;
        remove => IL.GradeMarker.ActivateGradual -= value;
    }

    public static event ILContext.Manipulator DeactivateGradual
    {
        add => IL.GradeMarker.DeactivateGradual += value;
        remove => IL.GradeMarker.DeactivateGradual -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GradeMarker.Update += value;
        remove => IL.GradeMarker.Update -= value;
    }

    public static event ILContext.Manipulator UpdateLow
    {
        add => IL.GradeMarker.UpdateLow += value;
        remove => IL.GradeMarker.UpdateLow -= value;
    }

    public static event ILContext.Manipulator orig_Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Start"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Start"), value);
    }

    public static event ILContext.Manipulator OnStart
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "OnStart").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "OnStart").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator orig_Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Update"),
            value);
    }

    public static event ILContext.Manipulator orig_UpdateLow
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_UpdateLow"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_UpdateLow"),
            value);
    }

    public static event ILContext.Manipulator orig_Deactivate
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Deactivate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GradeMarker), "orig_Deactivate"),
            value);
    }
}