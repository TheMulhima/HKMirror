using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for iTween.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILiTween
{
    public static event ILContext.Manipulator Init
    {
        add => IL.iTween.Init += value;
        remove => IL.iTween.Init -= value;
    }

    public static event ILContext.Manipulator CameraFadeFrom_float_float
    {
        add => IL.iTween.CameraFadeFrom_float_float += value;
        remove => IL.iTween.CameraFadeFrom_float_float -= value;
    }

    public static event ILContext.Manipulator CameraFadeFrom_Hashtable
    {
        add => IL.iTween.CameraFadeFrom_Hashtable += value;
        remove => IL.iTween.CameraFadeFrom_Hashtable -= value;
    }

    public static event ILContext.Manipulator CameraFadeTo_float_float
    {
        add => IL.iTween.CameraFadeTo_float_float += value;
        remove => IL.iTween.CameraFadeTo_float_float -= value;
    }

    public static event ILContext.Manipulator CameraFadeTo_Hashtable
    {
        add => IL.iTween.CameraFadeTo_Hashtable += value;
        remove => IL.iTween.CameraFadeTo_Hashtable -= value;
    }

    public static event ILContext.Manipulator ValueTo
    {
        add => IL.iTween.ValueTo += value;
        remove => IL.iTween.ValueTo -= value;
    }

    public static event ILContext.Manipulator FadeFrom_GameObject_float_float
    {
        add => IL.iTween.FadeFrom_GameObject_float_float += value;
        remove => IL.iTween.FadeFrom_GameObject_float_float -= value;
    }

    public static event ILContext.Manipulator FadeFrom_GameObject_Hashtable
    {
        add => IL.iTween.FadeFrom_GameObject_Hashtable += value;
        remove => IL.iTween.FadeFrom_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator FadeTo_GameObject_float_float
    {
        add => IL.iTween.FadeTo_GameObject_float_float += value;
        remove => IL.iTween.FadeTo_GameObject_float_float -= value;
    }

    public static event ILContext.Manipulator FadeTo_GameObject_Hashtable
    {
        add => IL.iTween.FadeTo_GameObject_Hashtable += value;
        remove => IL.iTween.FadeTo_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ColorFrom_GameObject_Color_float
    {
        add => IL.iTween.ColorFrom_GameObject_Color_float += value;
        remove => IL.iTween.ColorFrom_GameObject_Color_float -= value;
    }

    public static event ILContext.Manipulator ColorFrom_GameObject_Hashtable
    {
        add => IL.iTween.ColorFrom_GameObject_Hashtable += value;
        remove => IL.iTween.ColorFrom_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ColorTo_GameObject_Color_float
    {
        add => IL.iTween.ColorTo_GameObject_Color_float += value;
        remove => IL.iTween.ColorTo_GameObject_Color_float -= value;
    }

    public static event ILContext.Manipulator ColorTo_GameObject_Hashtable
    {
        add => IL.iTween.ColorTo_GameObject_Hashtable += value;
        remove => IL.iTween.ColorTo_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator AudioFrom_GameObject_float_float_float
    {
        add => IL.iTween.AudioFrom_GameObject_float_float_float += value;
        remove => IL.iTween.AudioFrom_GameObject_float_float_float -= value;
    }

    public static event ILContext.Manipulator AudioFrom_GameObject_Hashtable
    {
        add => IL.iTween.AudioFrom_GameObject_Hashtable += value;
        remove => IL.iTween.AudioFrom_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator AudioTo_GameObject_float_float_float
    {
        add => IL.iTween.AudioTo_GameObject_float_float_float += value;
        remove => IL.iTween.AudioTo_GameObject_float_float_float -= value;
    }

    public static event ILContext.Manipulator AudioTo_GameObject_Hashtable
    {
        add => IL.iTween.AudioTo_GameObject_Hashtable += value;
        remove => IL.iTween.AudioTo_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator Stab_GameObject_AudioClip_float
    {
        add => IL.iTween.Stab_GameObject_AudioClip_float += value;
        remove => IL.iTween.Stab_GameObject_AudioClip_float -= value;
    }

    public static event ILContext.Manipulator Stab_GameObject_Hashtable
    {
        add => IL.iTween.Stab_GameObject_Hashtable += value;
        remove => IL.iTween.Stab_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator LookFrom_GameObject_Vector3_float
    {
        add => IL.iTween.LookFrom_GameObject_Vector3_float += value;
        remove => IL.iTween.LookFrom_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator LookFrom_GameObject_Hashtable
    {
        add => IL.iTween.LookFrom_GameObject_Hashtable += value;
        remove => IL.iTween.LookFrom_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator LookTo_GameObject_Vector3_float
    {
        add => IL.iTween.LookTo_GameObject_Vector3_float += value;
        remove => IL.iTween.LookTo_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator LookTo_GameObject_Hashtable
    {
        add => IL.iTween.LookTo_GameObject_Hashtable += value;
        remove => IL.iTween.LookTo_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator MoveTo_GameObject_Vector3_float
    {
        add => IL.iTween.MoveTo_GameObject_Vector3_float += value;
        remove => IL.iTween.MoveTo_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator MoveTo_GameObject_Hashtable
    {
        add => IL.iTween.MoveTo_GameObject_Hashtable += value;
        remove => IL.iTween.MoveTo_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator MoveFrom_GameObject_Vector3_float
    {
        add => IL.iTween.MoveFrom_GameObject_Vector3_float += value;
        remove => IL.iTween.MoveFrom_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator MoveFrom_GameObject_Hashtable
    {
        add => IL.iTween.MoveFrom_GameObject_Hashtable += value;
        remove => IL.iTween.MoveFrom_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator MoveAdd_GameObject_Vector3_float
    {
        add => IL.iTween.MoveAdd_GameObject_Vector3_float += value;
        remove => IL.iTween.MoveAdd_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator MoveAdd_GameObject_Hashtable
    {
        add => IL.iTween.MoveAdd_GameObject_Hashtable += value;
        remove => IL.iTween.MoveAdd_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator MoveBy_GameObject_Vector3_float
    {
        add => IL.iTween.MoveBy_GameObject_Vector3_float += value;
        remove => IL.iTween.MoveBy_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator MoveBy_GameObject_Hashtable
    {
        add => IL.iTween.MoveBy_GameObject_Hashtable += value;
        remove => IL.iTween.MoveBy_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ScaleTo_GameObject_Vector3_float
    {
        add => IL.iTween.ScaleTo_GameObject_Vector3_float += value;
        remove => IL.iTween.ScaleTo_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ScaleTo_GameObject_Hashtable
    {
        add => IL.iTween.ScaleTo_GameObject_Hashtable += value;
        remove => IL.iTween.ScaleTo_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ScaleFrom_GameObject_Vector3_float
    {
        add => IL.iTween.ScaleFrom_GameObject_Vector3_float += value;
        remove => IL.iTween.ScaleFrom_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ScaleFrom_GameObject_Hashtable
    {
        add => IL.iTween.ScaleFrom_GameObject_Hashtable += value;
        remove => IL.iTween.ScaleFrom_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ScaleAdd_GameObject_Vector3_float
    {
        add => IL.iTween.ScaleAdd_GameObject_Vector3_float += value;
        remove => IL.iTween.ScaleAdd_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ScaleAdd_GameObject_Hashtable
    {
        add => IL.iTween.ScaleAdd_GameObject_Hashtable += value;
        remove => IL.iTween.ScaleAdd_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ScaleBy_GameObject_Vector3_float
    {
        add => IL.iTween.ScaleBy_GameObject_Vector3_float += value;
        remove => IL.iTween.ScaleBy_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ScaleBy_GameObject_Hashtable
    {
        add => IL.iTween.ScaleBy_GameObject_Hashtable += value;
        remove => IL.iTween.ScaleBy_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator RotateTo_GameObject_Vector3_float
    {
        add => IL.iTween.RotateTo_GameObject_Vector3_float += value;
        remove => IL.iTween.RotateTo_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator RotateTo_GameObject_Hashtable
    {
        add => IL.iTween.RotateTo_GameObject_Hashtable += value;
        remove => IL.iTween.RotateTo_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator RotateFrom_GameObject_Vector3_float
    {
        add => IL.iTween.RotateFrom_GameObject_Vector3_float += value;
        remove => IL.iTween.RotateFrom_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator RotateFrom_GameObject_Hashtable
    {
        add => IL.iTween.RotateFrom_GameObject_Hashtable += value;
        remove => IL.iTween.RotateFrom_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator RotateAdd_GameObject_Vector3_float
    {
        add => IL.iTween.RotateAdd_GameObject_Vector3_float += value;
        remove => IL.iTween.RotateAdd_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator RotateAdd_GameObject_Hashtable
    {
        add => IL.iTween.RotateAdd_GameObject_Hashtable += value;
        remove => IL.iTween.RotateAdd_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator RotateBy_GameObject_Vector3_float
    {
        add => IL.iTween.RotateBy_GameObject_Vector3_float += value;
        remove => IL.iTween.RotateBy_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator RotateBy_GameObject_Hashtable
    {
        add => IL.iTween.RotateBy_GameObject_Hashtable += value;
        remove => IL.iTween.RotateBy_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ShakePosition_GameObject_Vector3_float
    {
        add => IL.iTween.ShakePosition_GameObject_Vector3_float += value;
        remove => IL.iTween.ShakePosition_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ShakePosition_GameObject_Hashtable
    {
        add => IL.iTween.ShakePosition_GameObject_Hashtable += value;
        remove => IL.iTween.ShakePosition_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ShakeScale_GameObject_Vector3_float
    {
        add => IL.iTween.ShakeScale_GameObject_Vector3_float += value;
        remove => IL.iTween.ShakeScale_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ShakeScale_GameObject_Hashtable
    {
        add => IL.iTween.ShakeScale_GameObject_Hashtable += value;
        remove => IL.iTween.ShakeScale_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ShakeRotation_GameObject_Vector3_float
    {
        add => IL.iTween.ShakeRotation_GameObject_Vector3_float += value;
        remove => IL.iTween.ShakeRotation_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ShakeRotation_GameObject_Hashtable
    {
        add => IL.iTween.ShakeRotation_GameObject_Hashtable += value;
        remove => IL.iTween.ShakeRotation_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator PunchPosition_GameObject_Vector3_float
    {
        add => IL.iTween.PunchPosition_GameObject_Vector3_float += value;
        remove => IL.iTween.PunchPosition_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator PunchPosition_GameObject_Hashtable
    {
        add => IL.iTween.PunchPosition_GameObject_Hashtable += value;
        remove => IL.iTween.PunchPosition_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator PunchRotation_GameObject_Vector3_float
    {
        add => IL.iTween.PunchRotation_GameObject_Vector3_float += value;
        remove => IL.iTween.PunchRotation_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator PunchRotation_GameObject_Hashtable
    {
        add => IL.iTween.PunchRotation_GameObject_Hashtable += value;
        remove => IL.iTween.PunchRotation_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator PunchScale_GameObject_Vector3_float
    {
        add => IL.iTween.PunchScale_GameObject_Vector3_float += value;
        remove => IL.iTween.PunchScale_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator PunchScale_GameObject_Hashtable
    {
        add => IL.iTween.PunchScale_GameObject_Hashtable += value;
        remove => IL.iTween.PunchScale_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator GenerateTargets
    {
        add => IL.iTween.GenerateTargets += value;
        remove => IL.iTween.GenerateTargets -= value;
    }

    public static event ILContext.Manipulator GenerateRectTargets
    {
        add => IL.iTween.GenerateRectTargets += value;
        remove => IL.iTween.GenerateRectTargets -= value;
    }

    public static event ILContext.Manipulator GenerateColorTargets
    {
        add => IL.iTween.GenerateColorTargets += value;
        remove => IL.iTween.GenerateColorTargets -= value;
    }

    public static event ILContext.Manipulator GenerateVector3Targets
    {
        add => IL.iTween.GenerateVector3Targets += value;
        remove => IL.iTween.GenerateVector3Targets -= value;
    }

    public static event ILContext.Manipulator GenerateVector2Targets
    {
        add => IL.iTween.GenerateVector2Targets += value;
        remove => IL.iTween.GenerateVector2Targets -= value;
    }

    public static event ILContext.Manipulator GenerateFloatTargets
    {
        add => IL.iTween.GenerateFloatTargets += value;
        remove => IL.iTween.GenerateFloatTargets -= value;
    }

    public static event ILContext.Manipulator GenerateColorToTargets
    {
        add => IL.iTween.GenerateColorToTargets += value;
        remove => IL.iTween.GenerateColorToTargets -= value;
    }

    public static event ILContext.Manipulator GenerateAudioToTargets
    {
        add => IL.iTween.GenerateAudioToTargets += value;
        remove => IL.iTween.GenerateAudioToTargets -= value;
    }

    public static event ILContext.Manipulator GenerateStabTargets
    {
        add => IL.iTween.GenerateStabTargets += value;
        remove => IL.iTween.GenerateStabTargets -= value;
    }

    public static event ILContext.Manipulator GenerateLookToTargets
    {
        add => IL.iTween.GenerateLookToTargets += value;
        remove => IL.iTween.GenerateLookToTargets -= value;
    }

    public static event ILContext.Manipulator GenerateMoveToPathTargets
    {
        add => IL.iTween.GenerateMoveToPathTargets += value;
        remove => IL.iTween.GenerateMoveToPathTargets -= value;
    }

    public static event ILContext.Manipulator GenerateMoveToTargets
    {
        add => IL.iTween.GenerateMoveToTargets += value;
        remove => IL.iTween.GenerateMoveToTargets -= value;
    }

    public static event ILContext.Manipulator GenerateMoveByTargets
    {
        add => IL.iTween.GenerateMoveByTargets += value;
        remove => IL.iTween.GenerateMoveByTargets -= value;
    }

    public static event ILContext.Manipulator GenerateScaleToTargets
    {
        add => IL.iTween.GenerateScaleToTargets += value;
        remove => IL.iTween.GenerateScaleToTargets -= value;
    }

    public static event ILContext.Manipulator GenerateScaleByTargets
    {
        add => IL.iTween.GenerateScaleByTargets += value;
        remove => IL.iTween.GenerateScaleByTargets -= value;
    }

    public static event ILContext.Manipulator GenerateScaleAddTargets
    {
        add => IL.iTween.GenerateScaleAddTargets += value;
        remove => IL.iTween.GenerateScaleAddTargets -= value;
    }

    public static event ILContext.Manipulator GenerateRotateToTargets
    {
        add => IL.iTween.GenerateRotateToTargets += value;
        remove => IL.iTween.GenerateRotateToTargets -= value;
    }

    public static event ILContext.Manipulator GenerateRotateAddTargets
    {
        add => IL.iTween.GenerateRotateAddTargets += value;
        remove => IL.iTween.GenerateRotateAddTargets -= value;
    }

    public static event ILContext.Manipulator GenerateRotateByTargets
    {
        add => IL.iTween.GenerateRotateByTargets += value;
        remove => IL.iTween.GenerateRotateByTargets -= value;
    }

    public static event ILContext.Manipulator GenerateShakePositionTargets
    {
        add => IL.iTween.GenerateShakePositionTargets += value;
        remove => IL.iTween.GenerateShakePositionTargets -= value;
    }

    public static event ILContext.Manipulator GenerateShakeScaleTargets
    {
        add => IL.iTween.GenerateShakeScaleTargets += value;
        remove => IL.iTween.GenerateShakeScaleTargets -= value;
    }

    public static event ILContext.Manipulator GenerateShakeRotationTargets
    {
        add => IL.iTween.GenerateShakeRotationTargets += value;
        remove => IL.iTween.GenerateShakeRotationTargets -= value;
    }

    public static event ILContext.Manipulator GeneratePunchPositionTargets
    {
        add => IL.iTween.GeneratePunchPositionTargets += value;
        remove => IL.iTween.GeneratePunchPositionTargets -= value;
    }

    public static event ILContext.Manipulator GeneratePunchRotationTargets
    {
        add => IL.iTween.GeneratePunchRotationTargets += value;
        remove => IL.iTween.GeneratePunchRotationTargets -= value;
    }

    public static event ILContext.Manipulator GeneratePunchScaleTargets
    {
        add => IL.iTween.GeneratePunchScaleTargets += value;
        remove => IL.iTween.GeneratePunchScaleTargets -= value;
    }

    public static event ILContext.Manipulator ApplyRectTargets
    {
        add => IL.iTween.ApplyRectTargets += value;
        remove => IL.iTween.ApplyRectTargets -= value;
    }

    public static event ILContext.Manipulator ApplyColorTargets
    {
        add => IL.iTween.ApplyColorTargets += value;
        remove => IL.iTween.ApplyColorTargets -= value;
    }

    public static event ILContext.Manipulator ApplyVector3Targets
    {
        add => IL.iTween.ApplyVector3Targets += value;
        remove => IL.iTween.ApplyVector3Targets -= value;
    }

    public static event ILContext.Manipulator ApplyVector2Targets
    {
        add => IL.iTween.ApplyVector2Targets += value;
        remove => IL.iTween.ApplyVector2Targets -= value;
    }

    public static event ILContext.Manipulator ApplyFloatTargets
    {
        add => IL.iTween.ApplyFloatTargets += value;
        remove => IL.iTween.ApplyFloatTargets -= value;
    }

    public static event ILContext.Manipulator ApplyColorToTargets
    {
        add => IL.iTween.ApplyColorToTargets += value;
        remove => IL.iTween.ApplyColorToTargets -= value;
    }

    public static event ILContext.Manipulator ApplyAudioToTargets
    {
        add => IL.iTween.ApplyAudioToTargets += value;
        remove => IL.iTween.ApplyAudioToTargets -= value;
    }

    public static event ILContext.Manipulator ApplyStabTargets
    {
        add => IL.iTween.ApplyStabTargets += value;
        remove => IL.iTween.ApplyStabTargets -= value;
    }

    public static event ILContext.Manipulator ApplyMoveToPathTargets
    {
        add => IL.iTween.ApplyMoveToPathTargets += value;
        remove => IL.iTween.ApplyMoveToPathTargets -= value;
    }

    public static event ILContext.Manipulator ApplyMoveToTargets
    {
        add => IL.iTween.ApplyMoveToTargets += value;
        remove => IL.iTween.ApplyMoveToTargets -= value;
    }

    public static event ILContext.Manipulator ApplyMoveByTargets
    {
        add => IL.iTween.ApplyMoveByTargets += value;
        remove => IL.iTween.ApplyMoveByTargets -= value;
    }

    public static event ILContext.Manipulator ApplyScaleToTargets
    {
        add => IL.iTween.ApplyScaleToTargets += value;
        remove => IL.iTween.ApplyScaleToTargets -= value;
    }

    public static event ILContext.Manipulator ApplyLookToTargets
    {
        add => IL.iTween.ApplyLookToTargets += value;
        remove => IL.iTween.ApplyLookToTargets -= value;
    }

    public static event ILContext.Manipulator ApplyRotateToTargets
    {
        add => IL.iTween.ApplyRotateToTargets += value;
        remove => IL.iTween.ApplyRotateToTargets -= value;
    }

    public static event ILContext.Manipulator ApplyRotateAddTargets
    {
        add => IL.iTween.ApplyRotateAddTargets += value;
        remove => IL.iTween.ApplyRotateAddTargets -= value;
    }

    public static event ILContext.Manipulator ApplyShakePositionTargets
    {
        add => IL.iTween.ApplyShakePositionTargets += value;
        remove => IL.iTween.ApplyShakePositionTargets -= value;
    }

    public static event ILContext.Manipulator ApplyShakeScaleTargets
    {
        add => IL.iTween.ApplyShakeScaleTargets += value;
        remove => IL.iTween.ApplyShakeScaleTargets -= value;
    }

    public static event ILContext.Manipulator ApplyShakeRotationTargets
    {
        add => IL.iTween.ApplyShakeRotationTargets += value;
        remove => IL.iTween.ApplyShakeRotationTargets -= value;
    }

    public static event ILContext.Manipulator ApplyPunchPositionTargets
    {
        add => IL.iTween.ApplyPunchPositionTargets += value;
        remove => IL.iTween.ApplyPunchPositionTargets -= value;
    }

    public static event ILContext.Manipulator ApplyPunchRotationTargets
    {
        add => IL.iTween.ApplyPunchRotationTargets += value;
        remove => IL.iTween.ApplyPunchRotationTargets -= value;
    }

    public static event ILContext.Manipulator ApplyPunchScaleTargets
    {
        add => IL.iTween.ApplyPunchScaleTargets += value;
        remove => IL.iTween.ApplyPunchScaleTargets -= value;
    }

    public static event ILContext.Manipulator TweenDelay
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(iTween), "TweenDelay").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(iTween), "TweenDelay").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator TweenStart
    {
        add => IL.iTween.TweenStart += value;
        remove => IL.iTween.TweenStart -= value;
    }

    public static event ILContext.Manipulator TweenRestart
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(iTween), "TweenRestart").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(iTween), "TweenRestart").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator TweenUpdate
    {
        add => IL.iTween.TweenUpdate += value;
        remove => IL.iTween.TweenUpdate -= value;
    }

    public static event ILContext.Manipulator TweenComplete
    {
        add => IL.iTween.TweenComplete += value;
        remove => IL.iTween.TweenComplete -= value;
    }

    public static event ILContext.Manipulator TweenLoop
    {
        add => IL.iTween.TweenLoop += value;
        remove => IL.iTween.TweenLoop -= value;
    }

    public static event ILContext.Manipulator RectUpdate
    {
        add => IL.iTween.RectUpdate += value;
        remove => IL.iTween.RectUpdate -= value;
    }

    public static event ILContext.Manipulator Vector3Update
    {
        add => IL.iTween.Vector3Update += value;
        remove => IL.iTween.Vector3Update -= value;
    }

    public static event ILContext.Manipulator Vector2Update
    {
        add => IL.iTween.Vector2Update += value;
        remove => IL.iTween.Vector2Update -= value;
    }

    public static event ILContext.Manipulator FloatUpdate
    {
        add => IL.iTween.FloatUpdate += value;
        remove => IL.iTween.FloatUpdate -= value;
    }

    public static event ILContext.Manipulator FadeUpdate_GameObject_Hashtable
    {
        add => IL.iTween.FadeUpdate_GameObject_Hashtable += value;
        remove => IL.iTween.FadeUpdate_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator FadeUpdate_GameObject_float_float
    {
        add => IL.iTween.FadeUpdate_GameObject_float_float += value;
        remove => IL.iTween.FadeUpdate_GameObject_float_float -= value;
    }

    public static event ILContext.Manipulator ColorUpdate_GameObject_Hashtable
    {
        add => IL.iTween.ColorUpdate_GameObject_Hashtable += value;
        remove => IL.iTween.ColorUpdate_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ColorUpdate_GameObject_Color_float
    {
        add => IL.iTween.ColorUpdate_GameObject_Color_float += value;
        remove => IL.iTween.ColorUpdate_GameObject_Color_float -= value;
    }

    public static event ILContext.Manipulator AudioUpdate_GameObject_Hashtable
    {
        add => IL.iTween.AudioUpdate_GameObject_Hashtable += value;
        remove => IL.iTween.AudioUpdate_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator AudioUpdate_GameObject_float_float_float
    {
        add => IL.iTween.AudioUpdate_GameObject_float_float_float += value;
        remove => IL.iTween.AudioUpdate_GameObject_float_float_float -= value;
    }

    public static event ILContext.Manipulator RotateUpdate_GameObject_Hashtable
    {
        add => IL.iTween.RotateUpdate_GameObject_Hashtable += value;
        remove => IL.iTween.RotateUpdate_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator RotateUpdate_GameObject_Vector3_float
    {
        add => IL.iTween.RotateUpdate_GameObject_Vector3_float += value;
        remove => IL.iTween.RotateUpdate_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator ScaleUpdate_GameObject_Hashtable
    {
        add => IL.iTween.ScaleUpdate_GameObject_Hashtable += value;
        remove => IL.iTween.ScaleUpdate_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator ScaleUpdate_GameObject_Vector3_float
    {
        add => IL.iTween.ScaleUpdate_GameObject_Vector3_float += value;
        remove => IL.iTween.ScaleUpdate_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator MoveUpdate_GameObject_Hashtable
    {
        add => IL.iTween.MoveUpdate_GameObject_Hashtable += value;
        remove => IL.iTween.MoveUpdate_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator MoveUpdate_GameObject_Vector3_float
    {
        add => IL.iTween.MoveUpdate_GameObject_Vector3_float += value;
        remove => IL.iTween.MoveUpdate_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator LookUpdate_GameObject_Hashtable
    {
        add => IL.iTween.LookUpdate_GameObject_Hashtable += value;
        remove => IL.iTween.LookUpdate_GameObject_Hashtable -= value;
    }

    public static event ILContext.Manipulator LookUpdate_GameObject_Vector3_float
    {
        add => IL.iTween.LookUpdate_GameObject_Vector3_float += value;
        remove => IL.iTween.LookUpdate_GameObject_Vector3_float -= value;
    }

    public static event ILContext.Manipulator PathLength_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PathLength", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PathLength", false),
            value);
    }

    public static event ILContext.Manipulator CameraTexture
    {
        add => IL.iTween.CameraTexture += value;
        remove => IL.iTween.CameraTexture -= value;
    }

    public static event ILContext.Manipulator PutOnPath_GameObject_Array_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PutOnPath", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PutOnPath", false),
            value);
    }

    public static event ILContext.Manipulator PutOnPath_Transform_Array_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PutOnPath", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PutOnPath", false),
            value);
    }

    public static event ILContext.Manipulator PointOnPath_Array_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PointOnPath", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "PointOnPath", false),
            value);
    }

    public static event ILContext.Manipulator DrawLine_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLine", false), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLine", false), value);
    }

    public static event ILContext.Manipulator DrawLine_Array_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLine", false), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLine", false), value);
    }

    public static event ILContext.Manipulator DrawLineGizmos_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineGizmos", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineGizmos", false),
            value);
    }

    public static event ILContext.Manipulator DrawLineGizmos_Array_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineGizmos", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineGizmos", false),
            value);
    }

    public static event ILContext.Manipulator DrawLineHandles_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineHandles", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineHandles", false),
            value);
    }

    public static event ILContext.Manipulator DrawLineHandles_Array_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineHandles", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawLineHandles", false),
            value);
    }

    public static event ILContext.Manipulator DrawPath_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPath", false), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPath", false), value);
    }

    public static event ILContext.Manipulator DrawPath_Array_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPath", false), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPath", false), value);
    }

    public static event ILContext.Manipulator DrawPathGizmos_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathGizmos", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathGizmos", false),
            value);
    }

    public static event ILContext.Manipulator DrawPathGizmos_Array_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathGizmos", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathGizmos", false),
            value);
    }

    public static event ILContext.Manipulator DrawPathHandles_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathHandles", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathHandles", false),
            value);
    }

    public static event ILContext.Manipulator DrawPathHandles_Array_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathHandles", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTween), "DrawPathHandles", false),
            value);
    }

    public static event ILContext.Manipulator CameraFadeDepth
    {
        add => IL.iTween.CameraFadeDepth += value;
        remove => IL.iTween.CameraFadeDepth -= value;
    }

    public static event ILContext.Manipulator CameraFadeDestroy
    {
        add => IL.iTween.CameraFadeDestroy += value;
        remove => IL.iTween.CameraFadeDestroy -= value;
    }

    public static event ILContext.Manipulator CameraFadeSwap
    {
        add => IL.iTween.CameraFadeSwap += value;
        remove => IL.iTween.CameraFadeSwap -= value;
    }

    public static event ILContext.Manipulator CameraFadeAdd_Texture2D_int
    {
        add => IL.iTween.CameraFadeAdd_Texture2D_int += value;
        remove => IL.iTween.CameraFadeAdd_Texture2D_int -= value;
    }

    public static event ILContext.Manipulator CameraFadeAdd_Texture2D
    {
        add => IL.iTween.CameraFadeAdd_Texture2D += value;
        remove => IL.iTween.CameraFadeAdd_Texture2D -= value;
    }

    public static event ILContext.Manipulator CameraFadeAdd
    {
        add => IL.iTween.CameraFadeAdd += value;
        remove => IL.iTween.CameraFadeAdd -= value;
    }

    public static event ILContext.Manipulator Resume_GameObject
    {
        add => IL.iTween.Resume_GameObject += value;
        remove => IL.iTween.Resume_GameObject -= value;
    }

    public static event ILContext.Manipulator Resume_GameObject_bool
    {
        add => IL.iTween.Resume_GameObject_bool += value;
        remove => IL.iTween.Resume_GameObject_bool -= value;
    }

    public static event ILContext.Manipulator Resume_GameObject_string
    {
        add => IL.iTween.Resume_GameObject_string += value;
        remove => IL.iTween.Resume_GameObject_string -= value;
    }

    public static event ILContext.Manipulator Resume_GameObject_string_bool
    {
        add => IL.iTween.Resume_GameObject_string_bool += value;
        remove => IL.iTween.Resume_GameObject_string_bool -= value;
    }

    public static event ILContext.Manipulator Resume
    {
        add => IL.iTween.Resume += value;
        remove => IL.iTween.Resume -= value;
    }

    public static event ILContext.Manipulator Resume_string
    {
        add => IL.iTween.Resume_string += value;
        remove => IL.iTween.Resume_string -= value;
    }

    public static event ILContext.Manipulator Pause_GameObject
    {
        add => IL.iTween.Pause_GameObject += value;
        remove => IL.iTween.Pause_GameObject -= value;
    }

    public static event ILContext.Manipulator Pause_GameObject_bool
    {
        add => IL.iTween.Pause_GameObject_bool += value;
        remove => IL.iTween.Pause_GameObject_bool -= value;
    }

    public static event ILContext.Manipulator Pause_GameObject_string
    {
        add => IL.iTween.Pause_GameObject_string += value;
        remove => IL.iTween.Pause_GameObject_string -= value;
    }

    public static event ILContext.Manipulator Pause_GameObject_string_bool
    {
        add => IL.iTween.Pause_GameObject_string_bool += value;
        remove => IL.iTween.Pause_GameObject_string_bool -= value;
    }

    public static event ILContext.Manipulator Pause
    {
        add => IL.iTween.Pause += value;
        remove => IL.iTween.Pause -= value;
    }

    public static event ILContext.Manipulator Pause_string
    {
        add => IL.iTween.Pause_string += value;
        remove => IL.iTween.Pause_string -= value;
    }

    public static event ILContext.Manipulator Count
    {
        add => IL.iTween.Count += value;
        remove => IL.iTween.Count -= value;
    }

    public static event ILContext.Manipulator Count_string
    {
        add => IL.iTween.Count_string += value;
        remove => IL.iTween.Count_string -= value;
    }

    public static event ILContext.Manipulator Count_GameObject
    {
        add => IL.iTween.Count_GameObject += value;
        remove => IL.iTween.Count_GameObject -= value;
    }

    public static event ILContext.Manipulator Count_GameObject_string
    {
        add => IL.iTween.Count_GameObject_string += value;
        remove => IL.iTween.Count_GameObject_string -= value;
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.iTween.Stop += value;
        remove => IL.iTween.Stop -= value;
    }

    public static event ILContext.Manipulator Stop_string
    {
        add => IL.iTween.Stop_string += value;
        remove => IL.iTween.Stop_string -= value;
    }

    public static event ILContext.Manipulator StopByName_string
    {
        add => IL.iTween.StopByName_string += value;
        remove => IL.iTween.StopByName_string -= value;
    }

    public static event ILContext.Manipulator Stop_GameObject
    {
        add => IL.iTween.Stop_GameObject += value;
        remove => IL.iTween.Stop_GameObject -= value;
    }

    public static event ILContext.Manipulator Stop_GameObject_bool
    {
        add => IL.iTween.Stop_GameObject_bool += value;
        remove => IL.iTween.Stop_GameObject_bool -= value;
    }

    public static event ILContext.Manipulator Stop_GameObject_string
    {
        add => IL.iTween.Stop_GameObject_string += value;
        remove => IL.iTween.Stop_GameObject_string -= value;
    }

    public static event ILContext.Manipulator StopByName_GameObject_string
    {
        add => IL.iTween.StopByName_GameObject_string += value;
        remove => IL.iTween.StopByName_GameObject_string -= value;
    }

    public static event ILContext.Manipulator Stop_GameObject_string_bool
    {
        add => IL.iTween.Stop_GameObject_string_bool += value;
        remove => IL.iTween.Stop_GameObject_string_bool -= value;
    }

    public static event ILContext.Manipulator StopByName_GameObject_string_bool
    {
        add => IL.iTween.StopByName_GameObject_string_bool += value;
        remove => IL.iTween.StopByName_GameObject_string_bool -= value;
    }

    public static event ILContext.Manipulator Hash
    {
        add => IL.iTween.Hash += value;
        remove => IL.iTween.Hash -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.iTween.Awake += value;
        remove => IL.iTween.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(iTween), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(iTween), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.iTween.Update += value;
        remove => IL.iTween.Update -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.iTween.FixedUpdate += value;
        remove => IL.iTween.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.iTween.LateUpdate += value;
        remove => IL.iTween.LateUpdate -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.iTween.OnEnable += value;
        remove => IL.iTween.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.iTween.OnDisable += value;
        remove => IL.iTween.OnDisable -= value;
    }

    public static event ILContext.Manipulator DrawLineHelper
    {
        add => IL.iTween.DrawLineHelper += value;
        remove => IL.iTween.DrawLineHelper -= value;
    }

    public static event ILContext.Manipulator DrawPathHelper
    {
        add => IL.iTween.DrawPathHelper += value;
        remove => IL.iTween.DrawPathHelper -= value;
    }

    public static event ILContext.Manipulator PathControlPointGenerator
    {
        add => IL.iTween.PathControlPointGenerator += value;
        remove => IL.iTween.PathControlPointGenerator -= value;
    }

    public static event ILContext.Manipulator Interp
    {
        add => IL.iTween.Interp += value;
        remove => IL.iTween.Interp -= value;
    }

    public static event ILContext.Manipulator Launch
    {
        add => IL.iTween.Launch += value;
        remove => IL.iTween.Launch -= value;
    }

    public static event ILContext.Manipulator CleanArgs
    {
        add => IL.iTween.CleanArgs += value;
        remove => IL.iTween.CleanArgs -= value;
    }

    public static event ILContext.Manipulator GenerateID
    {
        add => IL.iTween.GenerateID += value;
        remove => IL.iTween.GenerateID -= value;
    }

    public static event ILContext.Manipulator RetrieveArgs
    {
        add => IL.iTween.RetrieveArgs += value;
        remove => IL.iTween.RetrieveArgs -= value;
    }

    public static event ILContext.Manipulator GetEasingFunction
    {
        add => IL.iTween.GetEasingFunction += value;
        remove => IL.iTween.GetEasingFunction -= value;
    }

    public static event ILContext.Manipulator UpdatePercentage
    {
        add => IL.iTween.UpdatePercentage += value;
        remove => IL.iTween.UpdatePercentage -= value;
    }

    public static event ILContext.Manipulator CallBack
    {
        add => IL.iTween.CallBack += value;
        remove => IL.iTween.CallBack -= value;
    }

    public static event ILContext.Manipulator Dispose
    {
        add => IL.iTween.Dispose += value;
        remove => IL.iTween.Dispose -= value;
    }

    public static event ILContext.Manipulator ConflictCheck
    {
        add => IL.iTween.ConflictCheck += value;
        remove => IL.iTween.ConflictCheck -= value;
    }

    public static event ILContext.Manipulator EnableKinematic
    {
        add => IL.iTween.EnableKinematic += value;
        remove => IL.iTween.EnableKinematic -= value;
    }

    public static event ILContext.Manipulator DisableKinematic
    {
        add => IL.iTween.DisableKinematic += value;
        remove => IL.iTween.DisableKinematic -= value;
    }

    public static event ILContext.Manipulator ResumeDelay
    {
        add => IL.iTween.ResumeDelay += value;
        remove => IL.iTween.ResumeDelay -= value;
    }

    public static event ILContext.Manipulator linear
    {
        add => IL.iTween.linear += value;
        remove => IL.iTween.linear -= value;
    }

    public static event ILContext.Manipulator clerp
    {
        add => IL.iTween.clerp += value;
        remove => IL.iTween.clerp -= value;
    }

    public static event ILContext.Manipulator spring
    {
        add => IL.iTween.spring += value;
        remove => IL.iTween.spring -= value;
    }

    public static event ILContext.Manipulator easeInQuad
    {
        add => IL.iTween.easeInQuad += value;
        remove => IL.iTween.easeInQuad -= value;
    }

    public static event ILContext.Manipulator easeOutQuad
    {
        add => IL.iTween.easeOutQuad += value;
        remove => IL.iTween.easeOutQuad -= value;
    }

    public static event ILContext.Manipulator easeInOutQuad
    {
        add => IL.iTween.easeInOutQuad += value;
        remove => IL.iTween.easeInOutQuad -= value;
    }

    public static event ILContext.Manipulator easeInCubic
    {
        add => IL.iTween.easeInCubic += value;
        remove => IL.iTween.easeInCubic -= value;
    }

    public static event ILContext.Manipulator easeOutCubic
    {
        add => IL.iTween.easeOutCubic += value;
        remove => IL.iTween.easeOutCubic -= value;
    }

    public static event ILContext.Manipulator easeInOutCubic
    {
        add => IL.iTween.easeInOutCubic += value;
        remove => IL.iTween.easeInOutCubic -= value;
    }

    public static event ILContext.Manipulator easeInQuart
    {
        add => IL.iTween.easeInQuart += value;
        remove => IL.iTween.easeInQuart -= value;
    }

    public static event ILContext.Manipulator easeOutQuart
    {
        add => IL.iTween.easeOutQuart += value;
        remove => IL.iTween.easeOutQuart -= value;
    }

    public static event ILContext.Manipulator easeInOutQuart
    {
        add => IL.iTween.easeInOutQuart += value;
        remove => IL.iTween.easeInOutQuart -= value;
    }

    public static event ILContext.Manipulator easeInQuint
    {
        add => IL.iTween.easeInQuint += value;
        remove => IL.iTween.easeInQuint -= value;
    }

    public static event ILContext.Manipulator easeOutQuint
    {
        add => IL.iTween.easeOutQuint += value;
        remove => IL.iTween.easeOutQuint -= value;
    }

    public static event ILContext.Manipulator easeInOutQuint
    {
        add => IL.iTween.easeInOutQuint += value;
        remove => IL.iTween.easeInOutQuint -= value;
    }

    public static event ILContext.Manipulator easeInSine
    {
        add => IL.iTween.easeInSine += value;
        remove => IL.iTween.easeInSine -= value;
    }

    public static event ILContext.Manipulator easeOutSine
    {
        add => IL.iTween.easeOutSine += value;
        remove => IL.iTween.easeOutSine -= value;
    }

    public static event ILContext.Manipulator easeInOutSine
    {
        add => IL.iTween.easeInOutSine += value;
        remove => IL.iTween.easeInOutSine -= value;
    }

    public static event ILContext.Manipulator easeInExpo
    {
        add => IL.iTween.easeInExpo += value;
        remove => IL.iTween.easeInExpo -= value;
    }

    public static event ILContext.Manipulator easeOutExpo
    {
        add => IL.iTween.easeOutExpo += value;
        remove => IL.iTween.easeOutExpo -= value;
    }

    public static event ILContext.Manipulator easeInOutExpo
    {
        add => IL.iTween.easeInOutExpo += value;
        remove => IL.iTween.easeInOutExpo -= value;
    }

    public static event ILContext.Manipulator easeInCirc
    {
        add => IL.iTween.easeInCirc += value;
        remove => IL.iTween.easeInCirc -= value;
    }

    public static event ILContext.Manipulator easeOutCirc
    {
        add => IL.iTween.easeOutCirc += value;
        remove => IL.iTween.easeOutCirc -= value;
    }

    public static event ILContext.Manipulator easeInOutCirc
    {
        add => IL.iTween.easeInOutCirc += value;
        remove => IL.iTween.easeInOutCirc -= value;
    }

    public static event ILContext.Manipulator easeInBounce
    {
        add => IL.iTween.easeInBounce += value;
        remove => IL.iTween.easeInBounce -= value;
    }

    public static event ILContext.Manipulator easeOutBounce
    {
        add => IL.iTween.easeOutBounce += value;
        remove => IL.iTween.easeOutBounce -= value;
    }

    public static event ILContext.Manipulator easeInOutBounce
    {
        add => IL.iTween.easeInOutBounce += value;
        remove => IL.iTween.easeInOutBounce -= value;
    }

    public static event ILContext.Manipulator easeInBack
    {
        add => IL.iTween.easeInBack += value;
        remove => IL.iTween.easeInBack -= value;
    }

    public static event ILContext.Manipulator easeOutBack
    {
        add => IL.iTween.easeOutBack += value;
        remove => IL.iTween.easeOutBack -= value;
    }

    public static event ILContext.Manipulator easeInOutBack
    {
        add => IL.iTween.easeInOutBack += value;
        remove => IL.iTween.easeInOutBack -= value;
    }

    public static event ILContext.Manipulator punch
    {
        add => IL.iTween.punch += value;
        remove => IL.iTween.punch -= value;
    }

    public static event ILContext.Manipulator easeInElastic
    {
        add => IL.iTween.easeInElastic += value;
        remove => IL.iTween.easeInElastic -= value;
    }

    public static event ILContext.Manipulator easeOutElastic
    {
        add => IL.iTween.easeOutElastic += value;
        remove => IL.iTween.easeOutElastic -= value;
    }

    public static event ILContext.Manipulator easeInOutElastic
    {
        add => IL.iTween.easeInOutElastic += value;
        remove => IL.iTween.easeInOutElastic -= value;
    }
}