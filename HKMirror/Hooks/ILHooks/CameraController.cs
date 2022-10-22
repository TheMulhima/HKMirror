using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CameraController,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCameraController
{
    public static event ILContext.Manipulator GameInit
    {
        add => IL.CameraController.GameInit += value;
        remove => IL.CameraController.GameInit -= value;
    }

    public static event ILContext.Manipulator SceneInit
    {
        add => IL.CameraController.SceneInit += value;
        remove => IL.CameraController.SceneInit -= value;
    }

    public static event ILContext.Manipulator ApplyEffectConfiguration
    {
        add => IL.CameraController.ApplyEffectConfiguration += value;
        remove => IL.CameraController.ApplyEffectConfiguration -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.CameraController.LateUpdate += value;
        remove => IL.CameraController.LateUpdate -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.CameraController.OnDisable += value;
        remove => IL.CameraController.OnDisable -= value;
    }

    public static event ILContext.Manipulator FreezeInPlace
    {
        add => IL.CameraController.FreezeInPlace += value;
        remove => IL.CameraController.FreezeInPlace -= value;
    }

    public static event ILContext.Manipulator FadeOut
    {
        add => IL.CameraController.FadeOut += value;
        remove => IL.CameraController.FadeOut -= value;
    }

    public static event ILContext.Manipulator FadeSceneIn
    {
        add => IL.CameraController.FadeSceneIn += value;
        remove => IL.CameraController.FadeSceneIn -= value;
    }

    public static event ILContext.Manipulator LockToArea
    {
        add => IL.CameraController.LockToArea += value;
        remove => IL.CameraController.LockToArea -= value;
    }

    public static event ILContext.Manipulator ReleaseLock
    {
        add => IL.CameraController.ReleaseLock += value;
        remove => IL.CameraController.ReleaseLock -= value;
    }

    public static event ILContext.Manipulator ResetStartTimer
    {
        add => IL.CameraController.ResetStartTimer += value;
        remove => IL.CameraController.ResetStartTimer -= value;
    }

    public static event ILContext.Manipulator SnapTo
    {
        add => IL.CameraController.SnapTo += value;
        remove => IL.CameraController.SnapTo -= value;
    }

    public static event ILContext.Manipulator UpdateTargetDestinationDelta
    {
        add => IL.CameraController.UpdateTargetDestinationDelta += value;
        remove => IL.CameraController.UpdateTargetDestinationDelta -= value;
    }

    public static event ILContext.Manipulator SetMode
    {
        add => IL.CameraController.SetMode += value;
        remove => IL.CameraController.SetMode -= value;
    }

    public static event ILContext.Manipulator KeepWithinSceneBounds_Vector3
    {
        add => IL.CameraController.KeepWithinSceneBounds_Vector3 += value;
        remove => IL.CameraController.KeepWithinSceneBounds_Vector3 -= value;
    }

    public static event ILContext.Manipulator KeepWithinSceneBounds_Vector2
    {
        add => IL.CameraController.KeepWithinSceneBounds_Vector2 += value;
        remove => IL.CameraController.KeepWithinSceneBounds_Vector2 -= value;
    }

    public static event ILContext.Manipulator IsAtSceneBounds
    {
        add => IL.CameraController.IsAtSceneBounds += value;
        remove => IL.CameraController.IsAtSceneBounds -= value;
    }

    public static event ILContext.Manipulator IsAtHorizontalSceneBounds
    {
        add => IL.CameraController.IsAtHorizontalSceneBounds += value;
        remove => IL.CameraController.IsAtHorizontalSceneBounds -= value;
    }

    public static event ILContext.Manipulator IsTouchingSides
    {
        add => IL.CameraController.IsTouchingSides += value;
        remove => IL.CameraController.IsTouchingSides -= value;
    }

    public static event ILContext.Manipulator KeepWithinLockBounds
    {
        add => IL.CameraController.KeepWithinLockBounds += value;
        remove => IL.CameraController.KeepWithinLockBounds -= value;
    }

    public static event ILContext.Manipulator GetTilemapInfo
    {
        add => IL.CameraController.GetTilemapInfo += value;
        remove => IL.CameraController.GetTilemapInfo -= value;
    }

    public static event ILContext.Manipulator PositionToHero
    {
        add => IL.CameraController.PositionToHero += value;
        remove => IL.CameraController.PositionToHero -= value;
    }

    public static event ILContext.Manipulator DoPositionToHero
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CameraController), "DoPositionToHero").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CameraController), "DoPositionToHero").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator PositionToHeroFacing
    {
        add => IL.CameraController.PositionToHeroFacing += value;
        remove => IL.CameraController.PositionToHeroFacing -= value;
    }

    public static event ILContext.Manipulator PositionToHeroFacing_Vector2_bool
    {
        add => IL.CameraController.PositionToHeroFacing_Vector2_bool += value;
        remove => IL.CameraController.PositionToHeroFacing_Vector2_bool -= value;
    }

    public static event ILContext.Manipulator GetPositionToHeroFacing
    {
        add => IL.CameraController.GetPositionToHeroFacing += value;
        remove => IL.CameraController.GetPositionToHeroFacing -= value;
    }

    public static event ILContext.Manipulator FadeInFailSafe
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CameraController), "FadeInFailSafe").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CameraController), "FadeInFailSafe").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StopFailSafe
    {
        add => IL.CameraController.StopFailSafe += value;
        remove => IL.CameraController.StopFailSafe -= value;
    }

    public static event ILContext.Manipulator OnLevelUnload
    {
        add => IL.CameraController.OnLevelUnload += value;
        remove => IL.CameraController.OnLevelUnload -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.CameraController.OnDestroy += value;
        remove => IL.CameraController.OnDestroy -= value;
    }
}