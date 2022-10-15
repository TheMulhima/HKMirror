using GUIBlendModes;
using HutongGames.PlayMaker.Ecosystem.Utils;
using InControl.Internal;
using InControl.NativeDeviceProfiles;
using InControl.UnityDeviceProfiles;
using Language;
using Microsoft.Xbox;
using Modding.Delegates;
using Modding.Menu;
using Modding.Menu.Components;
using Modding.Patches;
using MonoMod;
using SecPlayerPrefs;
using TeamCherry;
using tk2dRuntime.TileMap;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;
using UnityStandardAssets.ImageEffects;
using Bounds = HutongGames.PlayMaker.Actions.Bounds;
using Logger = InControl.Logger;
using Mask = ToJ.Mask;
using Random = System.Random;
using Touch = InControl.Touch;

namespace HKMirror.InstanceClasses;

public static class InstanceClassWrapperCreator
{
    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataR Reflect(PlayerData instance)
    {
        return new PlayerDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameManagerR Reflect(GameManager instance)
    {
        return new GameManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroControllerR
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroControllerR Reflect(HeroController instance)
    {
        return new HeroControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIManagerR
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIManagerR Reflect(UIManager instance)
    {
        return new UIManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of System.Random
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomR Reflect(Random instance)
    {
        return new RandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AccelerateVelocity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AccelerateVelocityR Reflect(AccelerateVelocity instance)
    {
        return new AccelerateVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Achievement
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementR Reflect(Achievement instance)
    {
        return new AchievementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementHandlerR Reflect(AchievementHandler instance)
    {
        return new AchievementHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementIDMap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementIDMapR Reflect(AchievementIDMap instance)
    {
        return new AchievementIDMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementListener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementListenerR Reflect(AchievementListener instance)
    {
        return new AchievementListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementPopup
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementPopupR Reflect(AchievementPopup instance)
    {
        return new AchievementPopupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementPopupHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementPopupHandlerR Reflect(AchievementPopupHandler instance)
    {
        return new AchievementPopupHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementRecord
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementRecordR Reflect(AchievementRecord instance)
    {
        return new AchievementRecordR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementRecordFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementRecordFloatR Reflect(AchievementRecordFloat instance)
    {
        return new AchievementRecordFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementRecordInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementRecordIntR Reflect(AchievementRecordInt instance)
    {
        return new AchievementRecordIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementsList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementsListR Reflect(AchievementsList instance)
    {
        return new AchievementsListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AcidCorpseSplash
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AcidCorpseSplashR Reflect(AcidCorpseSplash instance)
    {
        return new AcidCorpseSplashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActionButtonIcon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActionButtonIconR Reflect(ActionButtonIcon instance)
    {
        return new ActionButtonIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActionQueue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActionQueueR Reflect(ActionQueue instance)
    {
        return new ActionQueueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateAllChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateAllChildrenR Reflect(ActivateAllChildren instance)
    {
        return new ActivateAllChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateChildrenOnContact
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateChildrenOnContactR Reflect(ActivateChildrenOnContact instance)
    {
        return new ActivateChildrenOnContactR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateGameObjectR Reflect(ActivateGameObject instance)
    {
        return new ActivateGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateIfPlayerdataTrue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateIfPlayerdataTrueR Reflect(ActivateIfPlayerdataTrue instance)
    {
        return new ActivateIfPlayerdataTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivatePerLanguage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivatePerLanguageR Reflect(ActivatePerLanguage instance)
    {
        return new ActivatePerLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateTrailRenderer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateTrailRendererR Reflect(ActivateTrailRenderer instance)
    {
        return new ActivateTrailRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActiveRecycler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActiveRecyclerR Reflect(ActiveRecycler instance)
    {
        return new ActiveRecyclerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActiveRegion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActiveRegionR Reflect(ActiveRegion instance)
    {
        return new ActiveRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddAnimationClip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddAnimationClipR Reflect(AddAnimationClip instance)
    {
        return new AddAnimationClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddComponent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddComponentR Reflect(AddComponent instance)
    {
        return new AddComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddEventRegister
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddEventRegisterR Reflect(AddEventRegister instance)
    {
        return new AddEventRegisterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddExplosionForce
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddExplosionForceR Reflect(AddExplosionForce instance)
    {
        return new AddExplosionForceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForceR Reflect(AddForce instance)
    {
        return new AddForceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForce2dR Reflect(AddForce2d instance)
    {
        return new AddForce2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce2dAsAngle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForce2dAsAngleR Reflect(AddForce2dAsAngle instance)
    {
        return new AddForce2dAsAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce2dV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForce2dV2R Reflect(AddForce2dV2 instance)
    {
        return new AddForce2dV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddHP
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddHPR Reflect(AddHP instance)
    {
        return new AddHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddMixingTransform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddMixingTransformR Reflect(AddMixingTransform instance)
    {
        return new AddMixingTransformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddRelativeForce2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddRelativeForce2dR Reflect(AddRelativeForce2d instance)
    {
        return new AddRelativeForce2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddScript
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddScriptR Reflect(AddScript instance)
    {
        return new AddScriptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddTorque
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddTorqueR Reflect(AddTorque instance)
    {
        return new AddTorqueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddTorque2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddTorque2dR Reflect(AddTorque2d instance)
    {
        return new AddTorque2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddTrackTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddTrackTriggerR Reflect(AddTrackTrigger instance)
    {
        return new AddTrackTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AfterglowXbox360WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AfterglowXbox360WindowsNativeProfileR Reflect(AfterglowXbox360WindowsNativeProfile instance)
    {
        return new AfterglowXbox360WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AfterTakeDamageHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AfterTakeDamageHandlerR Reflect(AfterTakeDamageHandler instance)
    {
        return new AfterTakeDamageHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloControllerMacNativeProfileR Reflect(AirFloControllerMacNativeProfile instance)
    {
        return new AirFloControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloPS3WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloPS3WindowsNativeProfileR Reflect(AirFloPS3WindowsNativeProfile instance)
    {
        return new AirFloPS3WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloWiredPS3MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloWiredPS3MacUnityProfileR Reflect(AirFloWiredPS3MacUnityProfile instance)
    {
        return new AirFloWiredPS3MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloWiredPS3WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloWiredPS3WindowsUnityProfileR Reflect(AirFloWiredPS3WindowsUnityProfile instance)
    {
        return new AirFloWiredPS3WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AlertRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AlertRangeR Reflect(AlertRange instance)
    {
        return new AlertRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AmazonFireTVRemoteUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AmazonFireTVRemoteUnityProfileR Reflect(AmazonFireTVRemoteUnityProfile instance)
    {
        return new AmazonFireTVRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AmazonFireTVUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AmazonFireTVUnityProfileR Reflect(AmazonFireTVUnityProfile instance)
    {
        return new AmazonFireTVUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVAmazonUnityProfileR Reflect(AndroidTVAmazonUnityProfile instance)
    {
        return new AndroidTVAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVMiBoxRemoteUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVMiBoxRemoteUnityProfileR Reflect(AndroidTVMiBoxRemoteUnityProfile instance)
    {
        return new AndroidTVMiBoxRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVRemoteUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVRemoteUnityProfileR Reflect(AndroidTVRemoteUnityProfile instance)
    {
        return new AndroidTVRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVUnityProfileR Reflect(AndroidTVUnityProfile instance)
    {
        return new AndroidTVUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateColorR Reflect(AnimateColor instance)
    {
        return new AnimateColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateFloatR Reflect(AnimateFloat instance)
    {
        return new AnimateFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateFloatV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateFloatV2R Reflect(AnimateFloatV2 instance)
    {
        return new AnimateFloatV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateRectR Reflect(AnimateRect instance)
    {
        return new AnimateRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateVector3R Reflect(AnimateVector3 instance)
    {
        return new AnimateVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimationSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimationSettingsR Reflect(AnimationSettings instance)
    {
        return new AnimationSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorCrossFade
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorCrossFadeR Reflect(AnimatorCrossFade instance)
    {
        return new AnimatorCrossFadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorFollow
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorFollowR Reflect(AnimatorFollow instance)
    {
        return new AnimatorFollowR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorInterruptMatchTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorInterruptMatchTargetR Reflect(AnimatorInterruptMatchTarget instance)
    {
        return new AnimatorInterruptMatchTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorMatchTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorMatchTargetR Reflect(AnimatorMatchTarget instance)
    {
        return new AnimatorMatchTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorPlay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorPlayR Reflect(AnimatorPlay instance)
    {
        return new AnimatorPlayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorPlayStateWait
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorPlayStateWaitR Reflect(AnimatorPlayStateWait instance)
    {
        return new AnimatorPlayStateWaitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorSequenceR Reflect(AnimatorSequence instance)
    {
        return new AnimatorSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStartPlayback
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStartPlaybackR Reflect(AnimatorStartPlayback instance)
    {
        return new AnimatorStartPlaybackR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStartRecording
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStartRecordingR Reflect(AnimatorStartRecording instance)
    {
        return new AnimatorStartRecordingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStopPlayback
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStopPlaybackR Reflect(AnimatorStopPlayback instance)
    {
        return new AnimatorStopPlaybackR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStopRecording
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStopRecordingR Reflect(AnimatorStopRecording instance)
    {
        return new AnimatorStopRecordingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimSpeedLerp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimSpeedLerpR Reflect(AnimSpeedLerp instance)
    {
        return new AnimSpeedLerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnyKey
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnyKeyR Reflect(AnyKey instance)
    {
        return new AnyKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleMFiExtendedGamepadNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleMFiExtendedGamepadNativeProfileR Reflect(AppleMFiExtendedGamepadNativeProfile instance)
    {
        return new AppleMFiExtendedGamepadNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleMFiMicroGamepadNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleMFiMicroGamepadNativeProfileR Reflect(AppleMFiMicroGamepadNativeProfile instance)
    {
        return new AppleMFiMicroGamepadNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleMFiUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleMFiUnityProfileR Reflect(AppleMFiUnityProfile instance)
    {
        return new AppleMFiUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleTVRemoteUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleTVRemoteUnityProfileR Reflect(AppleTVRemoteUnityProfile instance)
    {
        return new AppleTVRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     AppleTVWirelessControllerUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleTVWirelessControllerUnityProfileR Reflect(AppleTVWirelessControllerUnityProfile instance)
    {
        return new AppleTVWirelessControllerUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ApplicationQuit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ApplicationQuitR Reflect(ApplicationQuit instance)
    {
        return new ApplicationQuitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ApplicationRunInBackground
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ApplicationRunInBackgroundR Reflect(ApplicationRunInBackground instance)
    {
        return new ApplicationRunInBackgroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ApplyMusicCue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ApplyMusicCueR Reflect(ApplyMusicCue instance)
    {
        return new ApplyMusicCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArdwiinoControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArdwiinoControllerMacNativeProfileR Reflect(ArdwiinoControllerMacNativeProfile instance)
    {
        return new ArdwiinoControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AreaBackground
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AreaBackgroundR Reflect(AreaBackground instance)
    {
        return new AreaBackgroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AreaTitle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AreaTitleR Reflect(AreaTitle instance)
    {
        return new AreaTitleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AreaTitleController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AreaTitleControllerR Reflect(AreaTitleController instance)
    {
        return new AreaTitleControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayAddR Reflect(ArrayAdd instance)
    {
        return new ArrayAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayAddRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayAddRangeR Reflect(ArrayAddRange instance)
    {
        return new ArrayAddRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayClear
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayClearR Reflect(ArrayClear instance)
    {
        return new ArrayClearR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayCompareR Reflect(ArrayCompare instance)
    {
        return new ArrayCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayContains
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayContainsR Reflect(ArrayContains instance)
    {
        return new ArrayContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayDeleteAt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayDeleteAtR Reflect(ArrayDeleteAt instance)
    {
        return new ArrayDeleteAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayForEach
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayForEachR Reflect(ArrayForEach instance)
    {
        return new ArrayForEachR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayForEnumAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayForEnumAttributeR Reflect(ArrayForEnumAttribute instance)
    {
        return new ArrayForEnumAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayGet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayGetR Reflect(ArrayGet instance)
    {
        return new ArrayGetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayGetNext
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayGetNextR Reflect(ArrayGetNext instance)
    {
        return new ArrayGetNextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayGetRandom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayGetRandomR Reflect(ArrayGetRandom instance)
    {
        return new ArrayGetRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayLength
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayLengthR Reflect(ArrayLength instance)
    {
        return new ArrayLengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListAddR Reflect(ArrayListAdd instance)
    {
        return new ArrayListAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListAddRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListAddRangeR Reflect(ArrayListAddRange instance)
    {
        return new ArrayListAddRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListClear
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListClearR Reflect(ArrayListClear instance)
    {
        return new ArrayListClearR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListConcat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListConcatR Reflect(ArrayListConcat instance)
    {
        return new ArrayListConcatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListContains
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListContainsR Reflect(ArrayListContains instance)
    {
        return new ArrayListContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListContainsGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListContainsGameObjectR Reflect(ArrayListContainsGameObject instance)
    {
        return new ArrayListContainsGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListCopyTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListCopyToR Reflect(ArrayListCopyTo instance)
    {
        return new ArrayListCopyToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListCountR Reflect(ArrayListCount instance)
    {
        return new ArrayListCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListCreate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListCreateR Reflect(ArrayListCreate instance)
    {
        return new ArrayListCreateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListExists
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListExistsR Reflect(ArrayListExists instance)
    {
        return new ArrayListExistsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListFindGameObjectsByTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListFindGameObjectsByTagR Reflect(ArrayListFindGameObjectsByTag instance)
    {
        return new ArrayListFindGameObjectsByTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetR Reflect(ArrayListGet instance)
    {
        return new ArrayListGetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetAverageValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetAverageValueR Reflect(ArrayListGetAverageValue instance)
    {
        return new ArrayListGetAverageValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetClosestGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetClosestGameObjectR Reflect(ArrayListGetClosestGameObject instance)
    {
        return new ArrayListGetClosestGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetClosestGameObjectInSight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetClosestGameObjectInSightR Reflect(ArrayListGetClosestGameObjectInSight instance)
    {
        return new ArrayListGetClosestGameObjectInSightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetFarthestGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetFarthestGameObjectR Reflect(ArrayListGetFarthestGameObject instance)
    {
        return new ArrayListGetFarthestGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ArrayListGetFarthestGameObjectInSight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetFarthestGameObjectInSightR Reflect(ArrayListGetFarthestGameObjectInSight instance)
    {
        return new ArrayListGetFarthestGameObjectInSightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ArrayListGetGameobjectMaxFsmFloatIndex
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetGameobjectMaxFsmFloatIndexR Reflect(ArrayListGetGameobjectMaxFsmFloatIndex instance)
    {
        return new ArrayListGetGameobjectMaxFsmFloatIndexR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetMaxValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetMaxValueR Reflect(ArrayListGetMaxValue instance)
    {
        return new ArrayListGetMaxValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetMinValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetMinValueR Reflect(ArrayListGetMinValue instance)
    {
        return new ArrayListGetMinValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetNearestFloatValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetNearestFloatValueR Reflect(ArrayListGetNearestFloatValue instance)
    {
        return new ArrayListGetNearestFloatValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetNext
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetNextR Reflect(ArrayListGetNext instance)
    {
        return new ArrayListGetNextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetPrevious
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetPreviousR Reflect(ArrayListGetPrevious instance)
    {
        return new ArrayListGetPreviousR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetRandom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetRandomR Reflect(ArrayListGetRandom instance)
    {
        return new ArrayListGetRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetRelative
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetRelativeR Reflect(ArrayListGetRelative instance)
    {
        return new ArrayListGetRelativeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetScreenResolutions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetScreenResolutionsR Reflect(ArrayListGetScreenResolutions instance)
    {
        return new ArrayListGetScreenResolutionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetVertexColors
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetVertexColorsR Reflect(ArrayListGetVertexColors instance)
    {
        return new ArrayListGetVertexColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetVertexPositions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetVertexPositionsR Reflect(ArrayListGetVertexPositions instance)
    {
        return new ArrayListGetVertexPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListIndexOf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListIndexOfR Reflect(ArrayListIndexOf instance)
    {
        return new ArrayListIndexOfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListInsert
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListInsertR Reflect(ArrayListInsert instance)
    {
        return new ArrayListInsertR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListIsEmpty
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListIsEmptyR Reflect(ArrayListIsEmpty instance)
    {
        return new ArrayListIsEmptyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListLastIndexOf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListLastIndexOfR Reflect(ArrayListLastIndexOf instance)
    {
        return new ArrayListLastIndexOfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRemove
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRemoveR Reflect(ArrayListRemove instance)
    {
        return new ArrayListRemoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRemoveAt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRemoveAtR Reflect(ArrayListRemoveAt instance)
    {
        return new ArrayListRemoveAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRemoveRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRemoveRangeR Reflect(ArrayListRemoveRange instance)
    {
        return new ArrayListRemoveRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListResetValues
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListResetValuesR Reflect(ArrayListResetValues instance)
    {
        return new ArrayListResetValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListReverse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListReverseR Reflect(ArrayListReverse instance)
    {
        return new ArrayListReverseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRevertToSnapShot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRevertToSnapShotR Reflect(ArrayListRevertToSnapShot instance)
    {
        return new ArrayListRevertToSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSendEventToGameObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSendEventToGameObjectsR Reflect(ArrayListSendEventToGameObjects instance)
    {
        return new ArrayListSendEventToGameObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSetR Reflect(ArrayListSet instance)
    {
        return new ArrayListSetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSetVertexColors
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSetVertexColorsR Reflect(ArrayListSetVertexColors instance)
    {
        return new ArrayListSetVertexColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSetVertexPositions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSetVertexPositionsR Reflect(ArrayListSetVertexPositions instance)
    {
        return new ArrayListSetVertexPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListShuffle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListShuffleR Reflect(ArrayListShuffle instance)
    {
        return new ArrayListShuffleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSort
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSortR Reflect(ArrayListSort instance)
    {
        return new ArrayListSortR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSwapItems
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSwapItemsR Reflect(ArrayListSwapItems instance)
    {
        return new ArrayListSwapItemsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListTakeSnapShot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListTakeSnapShotR Reflect(ArrayListTakeSnapShot instance)
    {
        return new ArrayListTakeSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayResize
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayResizeR Reflect(ArrayResize instance)
    {
        return new ArrayResizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayReverse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayReverseR Reflect(ArrayReverse instance)
    {
        return new ArrayReverseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArraySet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArraySetR Reflect(ArraySet instance)
    {
        return new ArraySetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayShuffle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayShuffleR Reflect(ArrayShuffle instance)
    {
        return new ArrayShuffleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArraySort
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArraySortR Reflect(ArraySort instance)
    {
        return new ArraySortR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayTransferValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayTransferValueR Reflect(ArrayTransferValue instance)
    {
        return new ArrayTransferValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AssetNamePickerAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AssetNamePickerAttributeR Reflect(AssetNamePickerAttribute instance)
    {
        return new AssetNamePickerAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AtmosCue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AtmosCueR Reflect(AtmosCue instance)
    {
        return new AtmosCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AtPlayControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AtPlayControllerMacNativeProfileR Reflect(AtPlayControllerMacNativeProfile instance)
    {
        return new AtPlayControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioLoopMaster
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioLoopMasterR Reflect(AudioLoopMaster instance)
    {
        return new AudioLoopMasterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioManagerR Reflect(AudioManager instance)
    {
        return new AudioManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioMute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioMuteR Reflect(AudioMute instance)
    {
        return new AudioMuteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPause
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPauseR Reflect(AudioPause instance)
    {
        return new AudioPauseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayR Reflect(AudioPlay instance)
    {
        return new AudioPlayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayerOneShot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayerOneShotR Reflect(AudioPlayerOneShot instance)
    {
        return new AudioPlayerOneShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayerOneShotSingle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayerOneShotSingleR Reflect(AudioPlayerOneShotSingle instance)
    {
        return new AudioPlayerOneShotSingleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayInState
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayInStateR Reflect(AudioPlayInState instance)
    {
        return new AudioPlayInStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayRandom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayRandomR Reflect(AudioPlayRandom instance)
    {
        return new AudioPlayRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayRandomSingle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayRandomSingleR Reflect(AudioPlayRandomSingle instance)
    {
        return new AudioPlayRandomSingleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlaySimple
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlaySimpleR Reflect(AudioPlaySimple instance)
    {
        return new AudioPlaySimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayV2R Reflect(AudioPlayV2 instance)
    {
        return new AudioPlayV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioSourcePitchRandomizer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioSourcePitchRandomizerR Reflect(AudioSourcePitchRandomizer instance)
    {
        return new AudioSourcePitchRandomizerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioStop
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioStopR Reflect(AudioStop instance)
    {
        return new AudioStopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoLocalizeTextUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoLocalizeTextUIR Reflect(AutoLocalizeTextUI instance)
    {
        return new AutoLocalizeTextUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoRecycleSelf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoRecycleSelfR Reflect(AutoRecycleSelf instance)
    {
        return new AutoRecycleSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoSelector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoSelectorR Reflect(AutoSelector instance)
    {
        return new AutoSelectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoZSorter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoZSorterR Reflect(AutoZSorter instance)
    {
        return new AutoZSorterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AxisEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AxisEventR Reflect(AxisEvent instance)
    {
        return new AxisEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BasicSpriteAnimator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BasicSpriteAnimatorR Reflect(BasicSpriteAnimator instance)
    {
        return new BasicSpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BatarangControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BatarangControllerMacNativeProfileR Reflect(BatarangControllerMacNativeProfile instance)
    {
        return new BatarangControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeatControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeatControlR Reflect(BeatControl instance)
    {
        return new BeatControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeboncoolDA015CAAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeboncoolDA015CAAndroidUnityProfileR Reflect(BeboncoolDA015CAAndroidUnityProfile instance)
    {
        return new BeboncoolDA015CAAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeginRecoil
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeginRecoilR Reflect(BeginRecoil instance)
    {
        return new BeginRecoilR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeginSceneTransition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeginSceneTransitionR Reflect(BeginSceneTransition instance)
    {
        return new BeginSceneTransitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BehaviourListAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BehaviourListAddR Reflect(BehaviourListAdd instance)
    {
        return new BehaviourListAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BehaviourListRemove
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BehaviourListRemoveR Reflect(BehaviourListRemove instance)
    {
        return new BehaviourListRemoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetaEndPrompt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetaEndPromptR Reflect(BetaEndPrompt instance)
    {
        return new BetaEndPromptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetaGateChanger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetaGateChangerR Reflect(BetaGateChanger instance)
    {
        return new BetaGateChangerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BETAOPControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BETAOPControllerMacNativeProfileR Reflect(BETAOPControllerMacNativeProfile instance)
    {
        return new BETAOPControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetopBTP2175sWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetopBTP2175sWindowsUnityProfileR Reflect(BetopBTP2175sWindowsUnityProfile instance)
    {
        return new BetopBTP2175sWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetopBTPAX1TAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetopBTPAX1TAndroidUnityProfileR Reflect(BetopBTPAX1TAndroidUnityProfile instance)
    {
        return new BetopBTPAX1TAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetopBTPGenericAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetopBTPGenericAndroidUnityProfileR Reflect(BetopBTPGenericAndroidUnityProfile instance)
    {
        return new BetopBTPGenericAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigBenControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigBenControllerMacNativeProfileR Reflect(BigBenControllerMacNativeProfile instance)
    {
        return new BigBenControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigBouncer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigBouncerR Reflect(BigBouncer instance)
    {
        return new BigBouncerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigCentipede
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigCentipedeR Reflect(BigCentipede instance)
    {
        return new BigCentipedeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigCentipedeSection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigCentipedeSectionR Reflect(BigCentipedeSection instance)
    {
        return new BigCentipedeSectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BindingListenOptions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BindingListenOptionsR Reflect(BindingListenOptions instance)
    {
        return new BindingListenOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlendAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlendAnimationR Reflect(BlendAnimation instance)
    {
        return new BlendAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Blink
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlinkR Reflect(Blink instance)
    {
        return new BlinkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlurControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlurControlR Reflect(BlurControl instance)
    {
        return new BlurControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlurManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlurManagerR Reflect(BlurManager instance)
    {
        return new BlurManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlurPlane
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlurPlaneR Reflect(BlurPlane instance)
    {
        return new BlurPlaneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolAllTrue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolAllTrueR Reflect(BoolAllTrue instance)
    {
        return new BoolAllTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolAnyTrue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolAnyTrueR Reflect(BoolAnyTrue instance)
    {
        return new BoolAnyTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolChanged
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolChangedR Reflect(BoolChanged instance)
    {
        return new BoolChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolFlip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolFlipR Reflect(BoolFlip instance)
    {
        return new BoolFlipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolFlipEveryFrame
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolFlipEveryFrameR Reflect(BoolFlipEveryFrame instance)
    {
        return new BoolFlipEveryFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolNoneTrue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolNoneTrueR Reflect(BoolNoneTrue instance)
    {
        return new BoolNoneTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolOperator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolOperatorR Reflect(BoolOperator instance)
    {
        return new BoolOperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolTest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolTestR Reflect(BoolTest instance)
    {
        return new BoolTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolTestMulti
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolTestMultiR Reflect(BoolTestMulti instance)
    {
        return new BoolTestMultiR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossChallengeUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossChallengeUIR Reflect(BossChallengeUI instance)
    {
        return new BossChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorCage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorCageR Reflect(BossDoorCage instance)
    {
        return new BossDoorCageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorChallengeCompleteUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorChallengeCompleteUIR Reflect(BossDoorChallengeCompleteUI instance)
    {
        return new BossDoorChallengeCompleteUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorChallengeUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorChallengeUIR Reflect(BossDoorChallengeUI instance)
    {
        return new BossDoorChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorChallengeUIBindingButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorChallengeUIBindingButtonR Reflect(BossDoorChallengeUIBindingButton instance)
    {
        return new BossDoorChallengeUIBindingButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorCompletionStates
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorCompletionStatesR Reflect(BossDoorCompletionStates instance)
    {
        return new BossDoorCompletionStatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorLockUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorLockUIR Reflect(BossDoorLockUI instance)
    {
        return new BossDoorLockUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorLockUIIcon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorLockUIIconR Reflect(BossDoorLockUIIcon instance)
    {
        return new BossDoorLockUIIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorTargetLock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorTargetLockR Reflect(BossDoorTargetLock instance)
    {
        return new BossDoorTargetLockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSceneR Reflect(BossScene instance)
    {
        return new BossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSceneController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSceneControllerR Reflect(BossSceneController instance)
    {
        return new BossSceneControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceR Reflect(BossSequence instance)
    {
        return new BossSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequenceBindingsDisplay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceBindingsDisplayR Reflect(BossSequenceBindingsDisplay instance)
    {
        return new BossSequenceBindingsDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequenceBindingsDoor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceBindingsDoorR Reflect(BossSequenceBindingsDoor instance)
    {
        return new BossSequenceBindingsDoorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequenceDoor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceDoorR Reflect(BossSequenceDoor instance)
    {
        return new BossSequenceDoorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueR Reflect(BossStatue instance)
    {
        return new BossStatueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueCompletionStates
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueCompletionStatesR Reflect(BossStatueCompletionStates instance)
    {
        return new BossStatueCompletionStatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueDreamToggle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueDreamToggleR Reflect(BossStatueDreamToggle instance)
    {
        return new BossStatueDreamToggleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueExtraFlashEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueExtraFlashEffectR Reflect(BossStatueExtraFlashEffect instance)
    {
        return new BossStatueExtraFlashEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueFlashEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueFlashEffectR Reflect(BossStatueFlashEffect instance)
    {
        return new BossStatueFlashEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueLever
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueLeverR Reflect(BossStatueLever instance)
    {
        return new BossStatueLeverR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueLoadManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueLoadManagerR Reflect(BossStatueLoadManager instance)
    {
        return new BossStatueLoadManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueSetUnlockIndicator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueSetUnlockIndicatorR Reflect(BossStatueSetUnlockIndicator instance)
    {
        return new BossStatueSetUnlockIndicatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueTrophyPlaque
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueTrophyPlaqueR Reflect(BossStatueTrophyPlaque instance)
    {
        return new BossStatueTrophyPlaqueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSummaryBoard
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSummaryBoardR Reflect(BossSummaryBoard instance)
    {
        return new BossSummaryBoardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSummaryUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSummaryUIR Reflect(BossSummaryUI instance)
    {
        return new BossSummaryUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BounceShroom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BounceShroomR Reflect(BounceShroom instance)
    {
        return new BounceShroomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Bounds
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoundsR Reflect(Bounds instance)
    {
        return new BoundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoundsBoxCollider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoundsBoxColliderR Reflect(BoundsBoxCollider instance)
    {
        return new BoundsBoxColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoxColliderOffset
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoxColliderOffsetR Reflect(BoxColliderOffset instance)
    {
        return new BoxColliderOffsetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Breakable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableR Reflect(Breakable instance)
    {
        return new BreakableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableInfectedVine
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableInfectedVineR Reflect(BreakableInfectedVine instance)
    {
        return new BreakableInfectedVineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableObjectR Reflect(BreakableObject instance)
    {
        return new BreakableObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakablePole
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakablePoleR Reflect(BreakablePole instance)
    {
        return new BreakablePoleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakablePoleSimple
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakablePoleSimpleR Reflect(BreakablePoleSimple instance)
    {
        return new BreakablePoleSimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakablePoleTopLand
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakablePoleTopLandR Reflect(BreakablePoleTopLand instance)
    {
        return new BreakablePoleTopLandR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableWithExternalDebris
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableWithExternalDebrisR Reflect(BreakableWithExternalDebris instance)
    {
        return new BreakableWithExternalDebrisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BridgeLever
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BridgeLeverR Reflect(BridgeLever instance)
    {
        return new BridgeLeverR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BridgeSection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BridgeSectionR Reflect(BridgeSection instance)
    {
        return new BridgeSectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrightnessEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrightnessEffectR Reflect(BrightnessEffect instance)
    {
        return new BrightnessEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrightnessSetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrightnessSettingR Reflect(BrightnessSetting instance)
    {
        return new BrightnessSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BroadcastEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BroadcastEventR Reflect(BroadcastEvent instance)
    {
        return new BroadcastEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrokenVesselGlob
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrokenVesselGlobR Reflect(BrokenVesselGlob instance)
    {
        return new BrokenVesselGlobR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrookNeoGeoConverterMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrookNeoGeoConverterMacNativeProfileR Reflect(BrookNeoGeoConverterMacNativeProfile instance)
    {
        return new BrookNeoGeoConverterMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrookPS2ConverterMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrookPS2ConverterMacNativeProfileR Reflect(BrookPS2ConverterMacNativeProfile instance)
    {
        return new BrookPS2ConverterMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrummFlamePin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrummFlamePinR Reflect(BrummFlamePin instance)
    {
        return new BrummFlamePinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BTC938AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BTC938AndroidUnityProfileR Reflect(BTC938AndroidUnityProfile instance)
    {
        return new BTC938AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicAmazonUnityProfileR Reflect(BuffaloClassicAmazonUnityProfile instance)
    {
        return new BuffaloClassicAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicMacNativeProfileR Reflect(BuffaloClassicMacNativeProfile instance)
    {
        return new BuffaloClassicMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicMacUnityProfileR Reflect(BuffaloClassicMacUnityProfile instance)
    {
        return new BuffaloClassicMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicWindowsNativeProfileR Reflect(BuffaloClassicWindowsNativeProfile instance)
    {
        return new BuffaloClassicWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicWindowsUnityProfileR Reflect(BuffaloClassicWindowsUnityProfile instance)
    {
        return new BuffaloClassicWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuildEquippedCharms
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuildEquippedCharmsR Reflect(BuildEquippedCharms instance)
    {
        return new BuildEquippedCharmsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuildMetadata
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuildMetadataR Reflect(BuildMetadata instance)
    {
        return new BuildMetadataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuildString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuildStringR Reflect(BuildString instance)
    {
        return new BuildStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Bullet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BulletR Reflect(Bullet instance)
    {
        return new BulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ButtonSkin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ButtonSkinR Reflect(ButtonSkin instance)
    {
        return new ButtonSkinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CallMethod
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CallMethodR Reflect(CallMethod instance)
    {
        return new CallMethodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CallMethodProper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CallMethodProperR Reflect(CallMethodProper instance)
    {
        return new CallMethodProperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CallStaticMethod
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CallStaticMethodR Reflect(CallStaticMethod instance)
    {
        return new CallStaticMethodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraControlAnimationEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraControlAnimationEventsR Reflect(CameraControlAnimationEvents instance)
    {
        return new CameraControlAnimationEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraControllerR Reflect(CameraController instance)
    {
        return new CameraControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFade
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeR Reflect(CameraFade instance)
    {
        return new CameraFadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFadeIn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeInR Reflect(CameraFadeIn instance)
    {
        return new CameraFadeInR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFadeInWithDelay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeInWithDelayR Reflect(CameraFadeInWithDelay instance)
    {
        return new CameraFadeInWithDelayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFadeOut
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeOutR Reflect(CameraFadeOut instance)
    {
        return new CameraFadeOutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFreezeInPlace
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFreezeInPlaceR Reflect(CameraFreezeInPlace instance)
    {
        return new CameraFreezeInPlaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraLockArea
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraLockAreaR Reflect(CameraLockArea instance)
    {
        return new CameraLockAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraRepositionToHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraRepositionToHeroR Reflect(CameraRepositionToHero instance)
    {
        return new CameraRepositionToHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraShake
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraShakeR Reflect(CameraShake instance)
    {
        return new CameraShakeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraTargetR Reflect(CameraTarget instance)
    {
        return new CameraTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CancelWalkerTurn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CancelWalkerTurnR Reflect(CancelWalkerTurn instance)
    {
        return new CancelWalkerTurnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CanvasGroupRemap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CanvasGroupRemapR Reflect(CanvasGroupRemap instance)
    {
        return new CanvasGroupRemapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CaptureAnimationEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CaptureAnimationEventR Reflect(CaptureAnimationEvent instance)
    {
        return new CaptureAnimationEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CaptureMouseEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CaptureMouseEventsR Reflect(CaptureMouseEvents instance)
    {
        return new CaptureMouseEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CapturePoseAsAnimationClip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CapturePoseAsAnimationClipR Reflect(CapturePoseAsAnimationClip instance)
    {
        return new CapturePoseAsAnimationClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChainedNavGraph
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChainedNavGraphR Reflect(ChainedNavGraph instance)
    {
        return new ChainedNavGraphR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChainSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChainSequenceR Reflect(ChainSequence instance)
    {
        return new ChainSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChangeFontByLanguage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChangeFontByLanguageR Reflect(ChangeFontByLanguage instance)
    {
        return new ChangeFontByLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmDisplay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmDisplayR Reflect(CharmDisplay instance)
    {
        return new CharmDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmIconList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmIconListR Reflect(CharmIconList instance)
    {
        return new CharmIconListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmItemR Reflect(CharmItem instance)
    {
        return new CharmItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmUpdateHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmUpdateHandlerR Reflect(CharmUpdateHandler instance)
    {
        return new CharmUpdateHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmVibrations
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmVibrationsR Reflect(CharmVibrations instance)
    {
        return new CharmVibrationsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectR Reflect(ChaseObject instance)
    {
        return new ChaseObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObjectGround
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectGroundR Reflect(ChaseObjectGround instance)
    {
        return new ChaseObjectGroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObjectV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectV2R Reflect(ChaseObjectV2 instance)
    {
        return new ChaseObjectV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObjectVertical
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectVerticalR Reflect(ChaseObjectVertical instance)
    {
        return new ChaseObjectVerticalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheatManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheatManagerR Reflect(CheatManager instance)
    {
        return new CheatManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckAlertRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckAlertRangeR Reflect(CheckAlertRange instance)
    {
        return new CheckAlertRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckAlertRangeByName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckAlertRangeByNameR Reflect(CheckAlertRangeByName instance)
    {
        return new CheckAlertRangeByNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCanDreamWarpInScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCanDreamWarpInSceneR Reflect(CheckCanDreamWarpInScene instance)
    {
        return new CheckCanDreamWarpInSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCanSeeHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCanSeeHeroR Reflect(CheckCanSeeHero instance)
    {
        return new CheckCanSeeHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCollisionSide
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCollisionSideR Reflect(CheckCollisionSide instance)
    {
        return new CheckCollisionSideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCollisionSideEnter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCollisionSideEnterR Reflect(CheckCollisionSideEnter instance)
    {
        return new CheckCollisionSideEnterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCurrentMapZone
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCurrentMapZoneR Reflect(CheckCurrentMapZone instance)
    {
        return new CheckCurrentMapZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckGameState
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckGameStateR Reflect(CheckGameState instance)
    {
        return new CheckGameStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckGGBossLevel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckGGBossLevelR Reflect(CheckGGBossLevel instance)
    {
        return new CheckGGBossLevelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckInvincibility
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckInvincibilityR Reflect(CheckInvincibility instance)
    {
        return new CheckInvincibilityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckIsChineseBuild
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckIsChineseBuildR Reflect(CheckIsChineseBuild instance)
    {
        return new CheckIsChineseBuildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckpointSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckpointSpriteR Reflect(CheckpointSprite instance)
    {
        return new CheckpointSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckSceneName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckSceneNameR Reflect(CheckSceneName instance)
    {
        return new CheckSceneNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckSendEventLimit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckSendEventLimitR Reflect(CheckSendEventLimit instance)
    {
        return new CheckSendEventLimitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckStaticBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckStaticBoolR Reflect(CheckStaticBool instance)
    {
        return new CheckStaticBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckTargetDirection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckTargetDirectionR Reflect(CheckTargetDirection instance)
    {
        return new CheckTargetDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckTrackTriggerCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckTrackTriggerCountR Reflect(CheckTrackTriggerCount instance)
    {
        return new CheckTrackTriggerCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicPlayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicPlayerR Reflect(CinematicPlayer instance)
    {
        return new CinematicPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicSequenceR Reflect(CinematicSequence instance)
    {
        return new CinematicSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicSkipPopup
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicSkipPopupR Reflect(CinematicSkipPopup instance)
    {
        return new CinematicSkipPopupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicVideoPlayerConfig
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicVideoPlayerConfigR Reflect(CinematicVideoPlayerConfig instance)
    {
        return new CinematicVideoPlayerConfigR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicVideoReference
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicVideoReferenceR Reflect(CinematicVideoReference instance)
    {
        return new CinematicVideoReferenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CleanScenePrefabs
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CleanScenePrefabsR Reflect(CleanScenePrefabs instance)
    {
        return new CleanScenePrefabsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ClearSaveButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ClearSaveButtonR Reflect(ClearSaveButton instance)
    {
        return new ClearSaveButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Climber
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ClimberR Reflect(Climber instance)
    {
        return new ClimberR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CloseMarkerMenu
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CloseMarkerMenuR Reflect(CloseMarkerMenu instance)
    {
        return new CloseMarkerMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CodeProfiler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CodeProfilerR Reflect(CodeProfiler instance)
    {
        return new CodeProfilerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CodeWriter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CodeWriterR Reflect(CodeWriter instance)
    {
        return new CodeWriterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Collision2dEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Collision2dEventR Reflect(Collision2dEvent instance)
    {
        return new Collision2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Collision2dEventLayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Collision2dEventLayerR Reflect(Collision2dEventLayer instance)
    {
        return new Collision2dEventLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CollisionEnterEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CollisionEnterEventR Reflect(CollisionEnterEvent instance)
    {
        return new CollisionEnterEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CollisionEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CollisionEventR Reflect(CollisionEvent instance)
    {
        return new CollisionEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorChannel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorChannelR Reflect(ColorChannel instance)
    {
        return new ColorChannelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorChunk
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorChunkR Reflect(ColorChunk instance)
    {
        return new ColorChunkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorCurvesManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorCurvesManagerR Reflect(ColorCurvesManager instance)
    {
        return new ColorCurvesManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorFader
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorFaderR Reflect(ColorFader instance)
    {
        return new ColorFaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorInterpolate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorInterpolateR Reflect(ColorInterpolate instance)
    {
        return new ColorInterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorRamp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorRampR Reflect(ColorRamp instance)
    {
        return new ColorRampR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColourPainter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColourPainterR Reflect(ColourPainter instance)
    {
        return new ColourPainterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Comment
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CommentR Reflect(Comment instance)
    {
        return new CommentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CompareDistance2D
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CompareDistance2DR Reflect(CompareDistance2D instance)
    {
        return new CompareDistance2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CompareNames
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CompareNamesR Reflect(CompareNames instance)
    {
        return new CompareNamesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Compute_DT_EventArgs
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Compute_DT_EventArgsR Reflect(Compute_DT_EventArgs instance)
    {
        return new Compute_DT_EventArgsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConnectControllerPanel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConnectControllerPanelR Reflect(ConnectControllerPanel instance)
    {
        return new ConnectControllerPanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConstrainMovement
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConstrainMovementR Reflect(ConstrainMovement instance)
    {
        return new ConstrainMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConstrainPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConstrainPositionR Reflect(ConstrainPosition instance)
    {
        return new ConstrainPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ContentArea
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ContentAreaR Reflect(ContentArea instance)
    {
        return new ContentAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ContentPackDetailsUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ContentPackDetailsUIR Reflect(ContentPackDetailsUI instance)
    {
        return new ContentPackDetailsUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerButtonLabel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerButtonLabelR Reflect(ControllerButtonLabel instance)
    {
        return new ControllerButtonLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerButtonPositions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerButtonPositionsR Reflect(ControllerButtonPositions instance)
    {
        return new ControllerButtonPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerDetect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerDetectR Reflect(ControllerDetect instance)
    {
        return new ControllerDetectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerImage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerImageR Reflect(ControllerImage instance)
    {
        return new ControllerImageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerIsGrounded
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerIsGroundedR Reflect(ControllerIsGrounded instance)
    {
        return new ControllerIsGroundedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerMapping
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerMappingR Reflect(ControllerMapping instance)
    {
        return new ControllerMappingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerMove
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerMoveR Reflect(ControllerMove instance)
    {
        return new ControllerMoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerProfileButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerProfileButtonR Reflect(ControllerProfileButton instance)
    {
        return new ControllerProfileButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerProfileButtons
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerProfileButtonsR Reflect(ControllerProfileButtons instance)
    {
        return new ControllerProfileButtonsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerSettingsR Reflect(ControllerSettings instance)
    {
        return new ControllerSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerSimpleMove
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerSimpleMoveR Reflect(ControllerSimpleMove instance)
    {
        return new ControllerSimpleMoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToColorR Reflect(ConvertBoolToColor instance)
    {
        return new ConvertBoolToColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToFloatR Reflect(ConvertBoolToFloat instance)
    {
        return new ConvertBoolToFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToIntR Reflect(ConvertBoolToInt instance)
    {
        return new ConvertBoolToIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToStringR Reflect(ConvertBoolToString instance)
    {
        return new ConvertBoolToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertEnumToString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertEnumToStringR Reflect(ConvertEnumToString instance)
    {
        return new ConvertEnumToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertFloatToInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertFloatToIntR Reflect(ConvertFloatToInt instance)
    {
        return new ConvertFloatToIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertFloatToString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertFloatToStringR Reflect(ConvertFloatToString instance)
    {
        return new ConvertFloatToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertIntToFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertIntToFloatR Reflect(ConvertIntToFloat instance)
    {
        return new ConvertIntToFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertIntToString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertIntToStringR Reflect(ConvertIntToString instance)
    {
        return new ConvertIntToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertMaterialToObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertMaterialToObjectR Reflect(ConvertMaterialToObject instance)
    {
        return new ConvertMaterialToObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertSecondsToString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertSecondsToStringR Reflect(ConvertSecondsToString instance)
    {
        return new ConvertSecondsToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertStringToInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertStringToIntR Reflect(ConvertStringToInt instance)
    {
        return new ConvertStringToIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorBelt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorBeltR Reflect(ConveyorBelt instance)
    {
        return new ConveyorBeltR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorMovement
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorMovementR Reflect(ConveyorMovement instance)
    {
        return new ConveyorMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorMovementHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorMovementHeroR Reflect(ConveyorMovementHero instance)
    {
        return new ConveyorMovementHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorSpeedZone
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorSpeedZoneR Reflect(ConveyorSpeedZone instance)
    {
        return new ConveyorSpeedZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorZone
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorZoneR Reflect(ConveyorZone instance)
    {
        return new ConveyorZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CopyParentSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CopyParentSpriteR Reflect(CopyParentSprite instance)
    {
        return new CopyParentSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CoreLoop
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CoreLoopR Reflect(CoreLoop instance)
    {
        return new CoreLoopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CoroutineQueue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CoroutineQueueR Reflect(CoroutineQueue instance)
    {
        return new CoroutineQueueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Corpse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseR Reflect(Corpse instance)
    {
        return new CorpseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseBitEnd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseBitEndR Reflect(CorpseBitEnd instance)
    {
        return new CorpseBitEndR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseChunker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseChunkerR Reflect(CorpseChunker instance)
    {
        return new CorpseChunkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseDeathStun
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseDeathStunR Reflect(CorpseDeathStun instance)
    {
        return new CorpseDeathStunR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseDeathStunChunker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseDeathStunChunkerR Reflect(CorpseDeathStunChunker instance)
    {
        return new CorpseDeathStunChunkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseFungusExplode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseFungusExplodeR Reflect(CorpseFungusExplode instance)
    {
        return new CorpseFungusExplodeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseGoopExplode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseGoopExplodeR Reflect(CorpseGoopExplode instance)
    {
        return new CorpseGoopExplodeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseHatcher
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseHatcherR Reflect(CorpseHatcher instance)
    {
        return new CorpseHatcherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseSpineBurst
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseSpineBurstR Reflect(CorpseSpineBurst instance)
    {
        return new CorpseSpineBurstR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseZomHive
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseZomHiveR Reflect(CorpseZomHive instance)
    {
        return new CorpseZomHiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Crawler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CrawlerR Reflect(Crawler instance)
    {
        return new CrawlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateEmptyObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateEmptyObjectR Reflect(CreateEmptyObject instance)
    {
        return new CreateEmptyObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateGameObjectPool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateGameObjectPoolR Reflect(CreateGameObjectPool instance)
    {
        return new CreateGameObjectPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateObjectR Reflect(CreateObject instance)
    {
        return new CreateObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreatePool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreatePoolR Reflect(CreatePool instance)
    {
        return new CreatePoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreatePoolObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreatePoolObjectsR Reflect(CreatePoolObjects instance)
    {
        return new CreatePoolObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateUIMsgGetItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateUIMsgGetItemR Reflect(CreateUIMsgGetItem instance)
    {
        return new CreateUIMsgGetItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreditsHelper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreditsHelperR Reflect(CreditsHelper instance)
    {
        return new CreditsHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CrystalPieceSize
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CrystalPieceSizeR Reflect(CrystalPieceSize instance)
    {
        return new CrystalPieceSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CursorHighlight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CursorHighlightR Reflect(CursorHighlight instance)
    {
        return new CursorHighlightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveColorR Reflect(CurveColor instance)
    {
        return new CurveColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveFloatR Reflect(CurveFloat instance)
    {
        return new CurveFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveRectR Reflect(CurveRect instance)
    {
        return new CurveRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveVector3R Reflect(CurveVector3 instance)
    {
        return new CurveVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CustomActionTest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CustomActionTestR Reflect(CustomActionTest instance)
    {
        return new CustomActionTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CutsceneHelper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CutsceneHelperR Reflect(CutsceneHelper instance)
    {
        return new CutsceneHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CutToCamera
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CutToCameraR Reflect(CutToCamera instance)
    {
        return new CutToCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CycloneDust
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CycloneDustR Reflect(CycloneDust instance)
    {
        return new CycloneDustR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DamageEffectTicker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageEffectTickerR Reflect(DamageEffectTicker instance)
    {
        return new DamageEffectTickerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DamageEnemies
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageEnemiesR Reflect(DamageEnemies instance)
    {
        return new DamageEnemiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DamageHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageHeroR Reflect(DamageHero instance)
    {
        return new DamageHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DashEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DashEffectR Reflect(DashEffect instance)
    {
        return new DashEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateAfter2dtkAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateAfter2dtkAnimationR Reflect(DeactivateAfter2dtkAnimation instance)
    {
        return new DeactivateAfter2dtkAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateAfterDelay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateAfterDelayR Reflect(DeactivateAfterDelay instance)
    {
        return new DeactivateAfterDelayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateGameObjectPerBuildType
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateGameObjectPerBuildTypeR Reflect(DeactivateGameObjectPerBuildType instance)
    {
        return new DeactivateGameObjectPerBuildTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateIfPlayerdataFalse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateIfPlayerdataFalseR Reflect(DeactivateIfPlayerdataFalse instance)
    {
        return new DeactivateIfPlayerdataFalseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateIfPlayerdataFalseDelayed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateIfPlayerdataFalseDelayedR Reflect(DeactivateIfPlayerdataFalseDelayed instance)
    {
        return new DeactivateIfPlayerdataFalseDelayedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateIfPlayerdataTrue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateIfPlayerdataTrueR Reflect(DeactivateIfPlayerdataTrue instance)
    {
        return new DeactivateIfPlayerdataTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateInDarknessWithoutLantern
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateInDarknessWithoutLanternR Reflect(DeactivateInDarknessWithoutLantern instance)
    {
        return new DeactivateInDarknessWithoutLanternR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeadZoneFunc
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeadZoneFuncR Reflect(DeadZoneFunc instance)
    {
        return new DeadZoneFuncR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebrisParticle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebrisParticleR Reflect(DebrisParticle instance)
    {
        return new DebrisParticleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebrisPiece
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebrisPieceR Reflect(DebrisPiece instance)
    {
        return new DebrisPieceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugBoolR Reflect(DebugBool instance)
    {
        return new DebugBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugDrawShape
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugDrawShapeR Reflect(DebugDrawShape instance)
    {
        return new DebugDrawShapeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugEnum
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugEnumR Reflect(DebugEnum instance)
    {
        return new DebugEnumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugFloatR Reflect(DebugFloat instance)
    {
        return new DebugFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugFsmVariable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugFsmVariableR Reflect(DebugFsmVariable instance)
    {
        return new DebugFsmVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugGameObjectR Reflect(DebugGameObject instance)
    {
        return new DebugGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugIntR Reflect(DebugInt instance)
    {
        return new DebugIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugLog
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugLogR Reflect(DebugLog instance)
    {
        return new DebugLogR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugLogConsole
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugLogConsoleR Reflect(DebugLogConsole instance)
    {
        return new DebugLogConsoleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugLogDeprecatedEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugLogDeprecatedEventR Reflect(DebugLogDeprecatedEvent instance)
    {
        return new DebugLogDeprecatedEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugObjectR Reflect(DebugObject instance)
    {
        return new DebugObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugVector2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugVector2R Reflect(DebugVector2 instance)
    {
        return new DebugVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugVector3R Reflect(DebugVector3 instance)
    {
        return new DebugVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Decelerate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecelerateR Reflect(Decelerate instance)
    {
        return new DecelerateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DecelerateV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecelerateV2R Reflect(DecelerateV2 instance)
    {
        return new DecelerateV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DecelerateXY
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecelerateXYR Reflect(DecelerateXY instance)
    {
        return new DecelerateXYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DecrementPlayerDataInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecrementPlayerDataIntR Reflect(DecrementPlayerDataInt instance)
    {
        return new DecrementPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeprecatedPrefab
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeprecatedPrefabR Reflect(DeprecatedPrefab instance)
    {
        return new DeprecatedPrefabR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DesktopCinematicVideoPlayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DesktopCinematicVideoPlayerR Reflect(DesktopCinematicVideoPlayer instance)
    {
        return new DesktopCinematicVideoPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DesktopPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DesktopPlatformR Reflect(DesktopPlatform instance)
    {
        return new DesktopPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyAllChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyAllChildrenR Reflect(DestroyAllChildren instance)
    {
        return new DestroyAllChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyArrayList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyArrayListR Reflect(DestroyArrayList instance)
    {
        return new DestroyArrayListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyComponent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyComponentR Reflect(DestroyComponent instance)
    {
        return new DestroyComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyEnemyBullet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyEnemyBulletR Reflect(DestroyEnemyBullet instance)
    {
        return new DestroyEnemyBulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyHashTable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyHashTableR Reflect(DestroyHashTable instance)
    {
        return new DestroyHashTableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyObjectR Reflect(DestroyObject instance)
    {
        return new DestroyObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyObjectsR Reflect(DestroyObjects instance)
    {
        return new DestroyObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyOutOfBounds
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyOutOfBoundsR Reflect(DestroyOutOfBounds instance)
    {
        return new DestroyOutOfBoundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyPersonalPools
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyPersonalPoolsR Reflect(DestroyPersonalPools instance)
    {
        return new DestroyPersonalPoolsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroySelf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroySelfR Reflect(DestroySelf instance)
    {
        return new DestroySelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestructibleProp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestructiblePropR Reflect(DestructibleProp instance)
    {
        return new DestructiblePropR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DetachChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DetachChildrenR Reflect(DetachChildren instance)
    {
        return new DetachChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DetectCollisonDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DetectCollisonDownR Reflect(DetectCollisonDown instance)
    {
        return new DetectCollisonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceBindingSource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceBindingSourceR Reflect(DeviceBindingSource instance)
    {
        return new DeviceBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceBindingSourceListener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceBindingSourceListenerR Reflect(DeviceBindingSourceListener instance)
    {
        return new DeviceBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceOrientationEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceOrientationEventR Reflect(DeviceOrientationEvent instance)
    {
        return new DeviceOrientationEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceShakeEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceShakeEventR Reflect(DeviceShakeEvent instance)
    {
        return new DeviceShakeEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceVibrate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceVibrateR Reflect(DeviceVibrate instance)
    {
        return new DeviceVibrateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DialogueBox
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DialogueBoxR Reflect(DialogueBox instance)
    {
        return new DialogueBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisableAfterTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisableAfterTimeR Reflect(DisableAfterTime instance)
    {
        return new DisableAfterTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisableIfZPos
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisableIfZPosR Reflect(DisableIfZPos instance)
    {
        return new DisableIfZPosR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisplayCurrentLanguage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisplayCurrentLanguageR Reflect(DisplayCurrentLanguage instance)
    {
        return new DisplayCurrentLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisplayItemAmount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisplayItemAmountR Reflect(DisplayItemAmount instance)
    {
        return new DisplayItemAmountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisplayOnWorldMapOnly
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisplayOnWorldMapOnlyR Reflect(DisplayOnWorldMapOnly instance)
    {
        return new DisplayOnWorldMapOnlyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceBetweenPoints
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceBetweenPointsR Reflect(DistanceBetweenPoints instance)
    {
        return new DistanceBetweenPointsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceBetweenPoints2D
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceBetweenPoints2DR Reflect(DistanceBetweenPoints2D instance)
    {
        return new DistanceBetweenPoints2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceFly
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceFlyR Reflect(DistanceFly instance)
    {
        return new DistanceFlyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceFlySmooth
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceFlySmoothR Reflect(DistanceFlySmooth instance)
    {
        return new DistanceFlySmoothR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceFlyV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceFlyV2R Reflect(DistanceFlyV2 instance)
    {
        return new DistanceFlyV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceWalk
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceWalkR Reflect(DistanceWalk instance)
    {
        return new DistanceWalkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DontClinkGates
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DontClinkGatesR Reflect(DontClinkGates instance)
    {
        return new DontClinkGatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DontDestroyOnLoad
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DontDestroyOnLoadR Reflect(DontDestroyOnLoad instance)
    {
        return new DontDestroyOnLoadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     DragonRiseArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DragonRiseArcadeStickMacNativeProfileR Reflect(DragonRiseArcadeStickMacNativeProfile instance)
    {
        return new DragonRiseArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawDebugLine
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawDebugLineR Reflect(DrawDebugLine instance)
    {
        return new DrawDebugLineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawDebugRay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawDebugRayR Reflect(DrawDebugRay instance)
    {
        return new DrawDebugRayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawFullscreenColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawFullscreenColorR Reflect(DrawFullscreenColor instance)
    {
        return new DrawFullscreenColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawStateLabel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawStateLabelR Reflect(DrawStateLabel instance)
    {
        return new DrawStateLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawTexture
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawTextureR Reflect(DrawTexture instance)
    {
        return new DrawTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DreamPlant
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DreamPlantR Reflect(DreamPlant instance)
    {
        return new DreamPlantR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DreamPlantOrb
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DreamPlantOrbR Reflect(DreamPlantOrb instance)
    {
        return new DreamPlantOrbR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DreamPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DreamPlatformR Reflect(DreamPlatform instance)
    {
        return new DreamPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Drip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DripR Reflect(Drip instance)
    {
        return new DripR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Dripper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DripperR Reflect(Dripper instance)
    {
        return new DripperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DroidBoxPS3AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DroidBoxPS3AndroidUnityProfileR Reflect(DroidBoxPS3AndroidUnityProfile instance)
    {
        return new DroidBoxPS3AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DroidBoxXboxAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DroidBoxXboxAndroidUnityProfileR Reflect(DroidBoxXboxAndroidUnityProfile instance)
    {
        return new DroidBoxXboxAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DropCrystal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DropCrystalR Reflect(DropCrystal instance)
    {
        return new DropCrystalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DropPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DropPlatformR Reflect(DropPlatform instance)
    {
        return new DropPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DualShock4MFiNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DualShock4MFiNativeProfileR Reflect(DualShock4MFiNativeProfile instance)
    {
        return new DualShock4MFiNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DustyPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DustyPlatformR Reflect(DustyPlatform instance)
    {
        return new DustyPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseColorR Reflect(EaseColor instance)
    {
        return new EaseColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseFloatR Reflect(EaseFloat instance)
    {
        return new EaseFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseRectR Reflect(EaseRect instance)
    {
        return new EaseRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseVector3R Reflect(EaseVector3 instance)
    {
        return new EaseVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EASportsControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EASportsControllerMacNativeProfileR Reflect(EASportsControllerMacNativeProfile instance)
    {
        return new EASportsControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EasySmxEsm9101AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EasySmxEsm9101AndroidUnityProfileR Reflect(EasySmxEsm9101AndroidUnityProfile instance)
    {
        return new EasySmxEsm9101AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoFC30ProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoFC30ProAndroidUnityProfileR Reflect(EightBitdoFC30ProAndroidUnityProfile instance)
    {
        return new EightBitdoFC30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoGenericAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoGenericAndroidUnityProfileR Reflect(EightBitdoGenericAndroidUnityProfile instance)
    {
        return new EightBitdoGenericAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoN30Pro2AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoN30Pro2AndroidUnityProfileR Reflect(EightBitdoN30Pro2AndroidUnityProfile instance)
    {
        return new EightBitdoN30Pro2AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProAndroidUnityProfileR Reflect(EightBitdoNES30ProAndroidUnityProfile instance)
    {
        return new EightBitdoNES30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoNES30ProBTMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProBTMacNativeProfileR Reflect(EightBitdoNES30ProBTMacNativeProfile instance)
    {
        return new EightBitdoNES30ProBTMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoNES30ProMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProMacUnityProfileR Reflect(EightBitdoNES30ProMacUnityProfile instance)
    {
        return new EightBitdoNES30ProMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProUSBMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProUSBMacNativeProfileR Reflect(EightBitdoNES30ProUSBMacNativeProfile instance)
    {
        return new EightBitdoNES30ProUSBMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProWindowsNativeProfileR Reflect(EightBitdoNES30ProWindowsNativeProfile instance)
    {
        return new EightBitdoNES30ProWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProWindowsUnityProfileR Reflect(EightBitdoNES30ProWindowsUnityProfile instance)
    {
        return new EightBitdoNES30ProWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSF30ProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSF30ProAndroidUnityProfileR Reflect(EightBitdoSF30ProAndroidUnityProfile instance)
    {
        return new EightBitdoSF30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoSF30ProWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSF30ProWindowsNativeProfileR Reflect(EightBitdoSF30ProWindowsNativeProfile instance)
    {
        return new EightBitdoSF30ProWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30AndroidUnityProfileR Reflect(EightBitdoSFC30AndroidUnityProfile instance)
    {
        return new EightBitdoSFC30AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30MacNativeProfileR Reflect(EightBitdoSFC30MacNativeProfile instance)
    {
        return new EightBitdoSFC30MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30MacUnityProfileR Reflect(EightBitdoSFC30MacUnityProfile instance)
    {
        return new EightBitdoSFC30MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30WindowsNativeProfileR Reflect(EightBitdoSFC30WindowsNativeProfile instance)
    {
        return new EightBitdoSFC30WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30WindowsUnityProfileR Reflect(EightBitdoSFC30WindowsUnityProfile instance)
    {
        return new EightBitdoSFC30WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSN30ProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSN30ProAndroidUnityProfileR Reflect(EightBitdoSN30ProAndroidUnityProfile instance)
    {
        return new EightBitdoSN30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30AndroidUnityProfileR Reflect(EightBitdoSNES30AndroidUnityProfile instance)
    {
        return new EightBitdoSNES30AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30MacNativeProfileR Reflect(EightBitdoSNES30MacNativeProfile instance)
    {
        return new EightBitdoSNES30MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30MacUnityProfileR Reflect(EightBitdoSNES30MacUnityProfile instance)
    {
        return new EightBitdoSNES30MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30WindowsNativeProfileR Reflect(EightBitdoSNES30WindowsNativeProfile instance)
    {
        return new EightBitdoSNES30WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30WindowsUnityProfileR Reflect(EightBitdoSNES30WindowsUnityProfile instance)
    {
        return new EightBitdoSNES30WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ElecomControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ElecomControllerMacNativeProfileR Reflect(ElecomControllerMacNativeProfile instance)
    {
        return new ElecomControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableAnimationR Reflect(EnableAnimation instance)
    {
        return new EnableAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableBehaviour
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableBehaviourR Reflect(EnableBehaviour instance)
    {
        return new EnableBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableFog
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableFogR Reflect(EnableFog instance)
    {
        return new EnableFogR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableFSM
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableFSMR Reflect(EnableFSM instance)
    {
        return new EnableFSMR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableGUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableGUIR Reflect(EnableGUI instance)
    {
        return new EnableGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EndBeta
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EndBetaR Reflect(EndBeta instance)
    {
        return new EndBetaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EndBossSceneTimer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EndBossSceneTimerR Reflect(EndBossSceneTimer instance)
    {
        return new EndBossSceneTimerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EndGGBossScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EndGGBossSceneR Reflect(EndGGBossScene instance)
    {
        return new EndGGBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyBullet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyBulletR Reflect(EnemyBullet instance)
    {
        return new EnemyBulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsR Reflect(EnemyDeathEffects instance)
    {
        return new EnemyDeathEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsBlackKnight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsBlackKnightR Reflect(EnemyDeathEffectsBlackKnight instance)
    {
        return new EnemyDeathEffectsBlackKnightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsBubble
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsBubbleR Reflect(EnemyDeathEffectsBubble instance)
    {
        return new EnemyDeathEffectsBubbleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsDung
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsDungR Reflect(EnemyDeathEffectsDung instance)
    {
        return new EnemyDeathEffectsDungR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsNoEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsNoEffectR Reflect(EnemyDeathEffectsNoEffect instance)
    {
        return new EnemyDeathEffectsNoEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsUninfected
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsUninfectedR Reflect(EnemyDeathEffectsUninfected instance)
    {
        return new EnemyDeathEffectsUninfectedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDreamnailReaction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDreamnailReactionR Reflect(EnemyDreamnailReaction instance)
    {
        return new EnemyDreamnailReactionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsArmoured
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsArmouredR Reflect(EnemyHitEffectsArmoured instance)
    {
        return new EnemyHitEffectsArmouredR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsBlackKnight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsBlackKnightR Reflect(EnemyHitEffectsBlackKnight instance)
    {
        return new EnemyHitEffectsBlackKnightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsGhost
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsGhostR Reflect(EnemyHitEffectsGhost instance)
    {
        return new EnemyHitEffectsGhostR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsShade
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsShadeR Reflect(EnemyHitEffectsShade instance)
    {
        return new EnemyHitEffectsShadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsUninfected
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsUninfectedR Reflect(EnemyHitEffectsUninfected instance)
    {
        return new EnemyHitEffectsUninfectedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyKillEventListener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyKillEventListenerR Reflect(EnemyKillEventListener instance)
    {
        return new EnemyKillEventListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyPusher
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyPusherR Reflect(EnemyPusher instance)
    {
        return new EnemyPusherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyPusherIgnore
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyPusherIgnoreR Reflect(EnemyPusherIgnore instance)
    {
        return new EnemyPusherIgnoreR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemySpawner
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemySpawnerR Reflect(EnemySpawner instance)
    {
        return new EnemySpawnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyWakeRegion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyWakeRegionR Reflect(EnemyWakeRegion instance)
    {
        return new EnemyWakeRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EngagedUserPanel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EngagedUserPanelR Reflect(EngagedUserPanel instance)
    {
        return new EngagedUserPanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EngagementPromptPanel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EngagementPromptPanelR Reflect(EngagementPromptPanel instance)
    {
        return new EngagementPromptPanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnumCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnumCompareR Reflect(EnumCompare instance)
    {
        return new EnumCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnumeratorLayout
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnumeratorLayoutR Reflect(EnumeratorLayout instance)
    {
        return new EnumeratorLayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnumSwitch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnumSwitchR Reflect(EnumSwitch instance)
    {
        return new EnumSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnviroRegion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnviroRegionR Reflect(EnviroRegion instance)
    {
        return new EnviroRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ErrorEventArgs
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ErrorEventArgsR Reflect(ErrorEventArgs instance)
    {
        return new ErrorEventArgsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EventRegister
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EventRegisterR Reflect(EventRegister instance)
    {
        return new EventRegisterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EventTargetVariable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EventTargetVariableR Reflect(EventTargetVariable instance)
    {
        return new EventTargetVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExecutionerXMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExecutionerXMacUnityProfileR Reflect(ExecutionerXMacUnityProfile instance)
    {
        return new ExecutionerXMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExecutionerXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExecutionerXWindowsUnityProfileR Reflect(ExecutionerXWindowsUnityProfile instance)
    {
        return new ExecutionerXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Explosion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExplosionR Reflect(HutongGames.PlayMaker.Actions.Explosion instance)
    {
        return new ExplosionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExtraDamageable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExtraDamageableR Reflect(ExtraDamageable instance)
    {
        return new ExtraDamageableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExtraDamageableProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExtraDamageableProxyR Reflect(ExtraDamageableProxy instance)
    {
        return new ExtraDamageableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceAngle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceAngleR Reflect(FaceAngle instance)
    {
        return new FaceAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceAngleSimple
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceAngleSimpleR Reflect(FaceAngleSimple instance)
    {
        return new FaceAngleSimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceAngleV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceAngleV2R Reflect(FaceAngleV2 instance)
    {
        return new FaceAngleV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceDirection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceDirectionR Reflect(FaceDirection instance)
    {
        return new FaceDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceInfoR Reflect(FaceInfo instance)
    {
        return new FaceInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceObjectR Reflect(FaceObject instance)
    {
        return new FaceObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeAudio
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeAudioR Reflect(FadeAudio instance)
    {
        return new FadeAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeColorFader
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeColorFaderR Reflect(FadeColorFader instance)
    {
        return new FadeColorFaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeGroup
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeGroupR Reflect(FadeGroup instance)
    {
        return new FadeGroupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeGroupDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeGroupDownR Reflect(FadeGroupDown instance)
    {
        return new FadeGroupDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeGroupUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeGroupUpR Reflect(FadeGroupUp instance)
    {
        return new FadeGroupUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeSequenceR Reflect(FadeSequence instance)
    {
        return new FadeSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FakeBat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FakeBatR Reflect(FakeBat instance)
    {
        return new FakeBatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FastAction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FastActionR Reflect(FastAction instance)
    {
        return new FastActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FastNoise
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FastNoiseR Reflect(FastNoise instance)
    {
        return new FastNoiseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindAlertRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindAlertRangeR Reflect(FindAlertRange instance)
    {
        return new FindAlertRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindArrayList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindArrayListR Reflect(FindArrayList instance)
    {
        return new FindArrayListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindChild
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindChildR Reflect(FindChild instance)
    {
        return new FindChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindClosest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindClosestR Reflect(FindClosest instance)
    {
        return new FindClosestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindGameObjectR Reflect(FindGameObject instance)
    {
        return new FindGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FinishFSM
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FinishFSMR Reflect(FinishFSM instance)
    {
        return new FinishFSMR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FinishingRigidBody
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FinishingRigidBodyR Reflect(FinishingRigidBody instance)
    {
        return new FinishingRigidBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FireAtTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FireAtTargetR Reflect(FireAtTarget instance)
    {
        return new FireAtTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FireGrimmBall
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FireGrimmBallR Reflect(FireGrimmBall instance)
    {
        return new FireGrimmBallR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FixVerticalAlign
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FixVerticalAlignR Reflect(FixVerticalAlign instance)
    {
        return new FixVerticalAlignR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FixXBG301AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FixXBG301AndroidUnityProfileR Reflect(FixXBG301AndroidUnityProfile instance)
    {
        return new FixXBG301AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlamePin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlamePinR Reflect(FlamePin instance)
    {
        return new FlamePinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlareAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlareAndroidUnityProfileR Reflect(FlareAndroidUnityProfile instance)
    {
        return new FlareAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlarePlayAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlarePlayAndroidUnityProfileR Reflect(FlarePlayAndroidUnityProfile instance)
    {
        return new FlarePlayAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlashMaterialGroup
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlashMaterialGroupR Reflect(FlashMaterialGroup instance)
    {
        return new FlashMaterialGroupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Flicker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlickerR Reflect(Flicker instance)
    {
        return new FlickerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingFlashingGeo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingFlashingGeoR Reflect(FlingFlashingGeo instance)
    {
        return new FlingFlashingGeoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectR Reflect(FlingObject instance)
    {
        return new FlingObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsR Reflect(FlingObjects instance)
    {
        return new FlingObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjectsFromGlobalPool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsFromGlobalPoolR Reflect(FlingObjectsFromGlobalPool instance)
    {
        return new FlingObjectsFromGlobalPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjectsFromGlobalPoolTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsFromGlobalPoolTimeR Reflect(FlingObjectsFromGlobalPoolTime instance)
    {
        return new FlingObjectsFromGlobalPoolTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjectsFromGlobalPoolVel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsFromGlobalPoolVelR Reflect(FlingObjectsFromGlobalPoolVel instance)
    {
        return new FlingObjectsFromGlobalPoolVelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlipPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlipPlatformR Reflect(FlipPlatform instance)
    {
        return new FlipPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlipScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlipScaleR Reflect(FlipScale instance)
    {
        return new FlipScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAbs
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAbsR Reflect(FloatAbs instance)
    {
        return new FloatAbsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAddR Reflect(FloatAdd instance)
    {
        return new FloatAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAddMultiple
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAddMultipleR Reflect(FloatAddMultiple instance)
    {
        return new FloatAddMultipleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAddV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAddV2R Reflect(FloatAddV2 instance)
    {
        return new FloatAddV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatChanged
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatChangedR Reflect(FloatChanged instance)
    {
        return new FloatChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatClamp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatClampR Reflect(FloatClamp instance)
    {
        return new FloatClampR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatCompareR Reflect(FloatCompare instance)
    {
        return new FloatCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatDivide
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatDivideR Reflect(FloatDivide instance)
    {
        return new FloatDivideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatDivideV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatDivideV2R Reflect(FloatDivideV2 instance)
    {
        return new FloatDivideV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatInRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatInRangeR Reflect(FloatInRange instance)
    {
        return new FloatInRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatInterpolate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatInterpolateR Reflect(FloatInterpolate instance)
    {
        return new FloatInterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatMultiply
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatMultiplyR Reflect(FloatMultiply instance)
    {
        return new FloatMultiplyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatMultiplyV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatMultiplyV2R Reflect(FloatMultiplyV2 instance)
    {
        return new FloatMultiplyV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatOperator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatOperatorR Reflect(FloatOperator instance)
    {
        return new FloatOperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSignTest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSignTestR Reflect(FloatSignTest instance)
    {
        return new FloatSignTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSquareRoot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSquareRootR Reflect(FloatSquareRoot instance)
    {
        return new FloatSquareRootR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSubtract
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSubtractR Reflect(FloatSubtract instance)
    {
        return new FloatSubtractR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSwitch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSwitchR Reflect(FloatSwitch instance)
    {
        return new FloatSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatTestToBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatTestToBoolR Reflect(FloatTestToBool instance)
    {
        return new FloatTestToBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForceCameraAspect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForceCameraAspectR Reflect(ForceCameraAspect instance)
    {
        return new ForceCameraAspectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForceCameraAspectLite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForceCameraAspectLiteR Reflect(ForceCameraAspectLite instance)
    {
        return new ForceCameraAspectLiteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FormatString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FormatStringR Reflect(FormatString instance)
    {
        return new FormatStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForwardAllEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForwardAllEventsR Reflect(ForwardAllEvents instance)
    {
        return new ForwardAllEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForwardEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForwardEventR Reflect(ForwardEvent instance)
    {
        return new ForwardEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FSMActivator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FSMActivatorR Reflect(FSMActivator instance)
    {
        return new FSMActivatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmArraySet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmArraySetR Reflect(FsmArraySet instance)
    {
        return new FsmArraySetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmEventOptions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmEventOptionsR Reflect(FsmEventOptions instance)
    {
        return new FsmEventOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmStateSwitch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmStateSwitchR Reflect(FsmStateSwitch instance)
    {
        return new FsmStateSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmStateTest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmStateTestR Reflect(FsmStateTest instance)
    {
        return new FsmStateTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     FusionXboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FusionXboxOneControllerMacNativeProfileR Reflect(FusionXboxOneControllerMacNativeProfile instance)
    {
        return new FusionXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCameras
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCamerasR Reflect(GameCameras instance)
    {
        return new GameCamerasR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCameraTextureDisplay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCameraTextureDisplayR Reflect(GameCameraTextureDisplay instance)
    {
        return new GameCameraTextureDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCompletionScreen
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCompletionScreenR Reflect(GameCompletionScreen instance)
    {
        return new GameCompletionScreenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameConfig
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameConfigR Reflect(GameConfig instance)
    {
        return new GameConfigR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCoreUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCoreUnityProfileR Reflect(GameCoreUnityProfile instance)
    {
        return new GameCoreUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeMayflashWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeMayflashWindowsNativeProfileR Reflect(GameCubeMayflashWindowsNativeProfile instance)
    {
        return new GameCubeMayflashWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeMayflashWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeMayflashWindowsUnityProfileR Reflect(GameCubeMayflashWindowsUnityProfile instance)
    {
        return new GameCubeMayflashWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeWindowsNativeProfileR Reflect(GameCubeWindowsNativeProfile instance)
    {
        return new GameCubeWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeWindowsUnityProfileR Reflect(GameCubeWindowsUnityProfile instance)
    {
        return new GameCubeWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameMap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameMapR Reflect(GameMap instance)
    {
        return new GameMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameMenuOptions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameMenuOptionsR Reflect(GameMenuOptions instance)
    {
        return new GameMenuOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectChanged
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectChangedR Reflect(GameObjectChanged instance)
    {
        return new GameObjectChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectCompareR Reflect(GameObjectCompare instance)
    {
        return new GameObjectCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectCompareTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectCompareTagR Reflect(GameObjectCompareTag instance)
    {
        return new GameObjectCompareTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectExists
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectExistsR Reflect(GameObjectExists instance)
    {
        return new GameObjectExistsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectHasChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectHasChildrenR Reflect(GameObjectHasChildren instance)
    {
        return new GameObjectHasChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectIsChildOf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectIsChildOfR Reflect(GameObjectIsChildOf instance)
    {
        return new GameObjectIsChildOfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectIsNull
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectIsNullR Reflect(GameObjectIsNull instance)
    {
        return new GameObjectIsNullR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectIsVisible
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectIsVisibleR Reflect(GameObjectIsVisible instance)
    {
        return new GameObjectIsVisibleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectTagSwitch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectTagSwitchR Reflect(GameObjectTagSwitch instance)
    {
        return new GameObjectTagSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GamepadVibration
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GamepadVibrationR Reflect(GamepadVibration instance)
    {
        return new GamepadVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GamepadVibrationMixer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GamepadVibrationMixerR Reflect(GamepadVibrationMixer instance)
    {
        return new GamepadVibrationMixerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSaveLoadedArgs
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSaveLoadedArgsR Reflect(GameSaveLoadedArgs instance)
    {
        return new GameSaveLoadedArgsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSettingsR Reflect(GameSettings instance)
    {
        return new GameSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSirG3sAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSirG3sAndroidUnityProfileR Reflect(GameSirG3sAndroidUnityProfile instance)
    {
        return new GameSirG3sAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSirG3wAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSirG3wAndroidUnityProfileR Reflect(GameSirG3wAndroidUnityProfile instance)
    {
        return new GameSirG3wAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSirG4sAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSirG4sAndroidUnityProfileR Reflect(GameSirG4sAndroidUnityProfile instance)
    {
        return new GameSirG4sAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameStickLinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameStickLinuxUnityProfileR Reflect(GameStickLinuxUnityProfile instance)
    {
        return new GameStickLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameStickUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameStickUnityProfileR Reflect(GameStickUnityProfile instance)
    {
        return new GameStickUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameStopControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameStopControllerMacNativeProfileR Reflect(GameStopControllerMacNativeProfile instance)
    {
        return new GameStopControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameVersionData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameVersionDataR Reflect(GameVersionData instance)
    {
        return new GameVersionDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GateSetAudio
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GateSetAudioR Reflect(GateSetAudio instance)
    {
        return new GateSetAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GateSnap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GateSnapR Reflect(GateSnap instance)
    {
        return new GateSnapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GCManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GCManagerR Reflect(GCManager instance)
    {
        return new GCManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenerateJournalNewDot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenerateJournalNewDotR Reflect(GenerateJournalNewDot instance)
    {
        return new GenerateJournalNewDotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeneratePortraitFrame
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeneratePortraitFrameR Reflect(GeneratePortraitFrame instance)
    {
        return new GeneratePortraitFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenericAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenericAndroidUnityProfileR Reflect(GenericAndroidUnityProfile instance)
    {
        return new GenericAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenericBlackBerryUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenericBlackBerryUnityProfileR Reflect(GenericBlackBerryUnityProfile instance)
    {
        return new GenericBlackBerryUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenericLinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenericLinuxUnityProfileR Reflect(GenericLinuxUnityProfile instance)
    {
        return new GenericLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoControlR Reflect(GeoControl instance)
    {
        return new GeoControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoCounter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoCounterR Reflect(GeoCounter instance)
    {
        return new GeoCounterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoRock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoRockR Reflect(GeoRock instance)
    {
        return new GeoRockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoRockData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoRockDataR Reflect(GeoRockData instance)
    {
        return new GeoRockDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetACosine
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetACosineR Reflect(GetACosine instance)
    {
        return new GetACosineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAngleBetweenPoints
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAngleBetweenPointsR Reflect(GetAngleBetweenPoints instance)
    {
        return new GetAngleBetweenPointsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAngleToTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAngleToTargetR Reflect(GetAngleToTarget instance)
    {
        return new GetAngleToTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAngleToTarget2D
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAngleToTarget2DR Reflect(GetAngleToTarget2D instance)
    {
        return new GetAngleToTarget2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorApplyRootMotion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorApplyRootMotionR Reflect(GetAnimatorApplyRootMotion instance)
    {
        return new GetAnimatorApplyRootMotionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorBody
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorBodyR Reflect(GetAnimatorBody instance)
    {
        return new GetAnimatorBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorBoneGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorBoneGameObjectR Reflect(GetAnimatorBoneGameObject instance)
    {
        return new GetAnimatorBoneGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorBoolR Reflect(GetAnimatorBool instance)
    {
        return new GetAnimatorBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCullingMode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCullingModeR Reflect(GetAnimatorCullingMode instance)
    {
        return new GetAnimatorCullingModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentStateInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentStateInfoR Reflect(GetAnimatorCurrentStateInfo instance)
    {
        return new GetAnimatorCurrentStateInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentStateInfoIsName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentStateInfoIsNameR Reflect(GetAnimatorCurrentStateInfoIsName instance)
    {
        return new GetAnimatorCurrentStateInfoIsNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentStateInfoIsTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentStateInfoIsTagR Reflect(GetAnimatorCurrentStateInfoIsTag instance)
    {
        return new GetAnimatorCurrentStateInfoIsTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentTransitionInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentTransitionInfoR Reflect(GetAnimatorCurrentTransitionInfo instance)
    {
        return new GetAnimatorCurrentTransitionInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GetAnimatorCurrentTransitionInfoIsName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentTransitionInfoIsNameR Reflect(GetAnimatorCurrentTransitionInfoIsName instance)
    {
        return new GetAnimatorCurrentTransitionInfoIsNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GetAnimatorCurrentTransitionInfoIsUserName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentTransitionInfoIsUserNameR Reflect(
        GetAnimatorCurrentTransitionInfoIsUserName instance)
    {
        return new GetAnimatorCurrentTransitionInfoIsUserNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorDelta
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorDeltaR Reflect(GetAnimatorDelta instance)
    {
        return new GetAnimatorDeltaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorFeetPivotActive
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorFeetPivotActiveR Reflect(GetAnimatorFeetPivotActive instance)
    {
        return new GetAnimatorFeetPivotActiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorFloatR Reflect(GetAnimatorFloat instance)
    {
        return new GetAnimatorFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorGravityWeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorGravityWeightR Reflect(GetAnimatorGravityWeight instance)
    {
        return new GetAnimatorGravityWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorHumanScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorHumanScaleR Reflect(GetAnimatorHumanScale instance)
    {
        return new GetAnimatorHumanScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIKGoal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIKGoalR Reflect(GetAnimatorIKGoal instance)
    {
        return new GetAnimatorIKGoalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIntR Reflect(GetAnimatorInt instance)
    {
        return new GetAnimatorIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsControlled
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsControlledR Reflect(GetAnimatorIsControlled instance)
    {
        return new GetAnimatorIsControlledR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsHuman
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsHumanR Reflect(GetAnimatorIsHuman instance)
    {
        return new GetAnimatorIsHumanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsLayerInTransition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsLayerInTransitionR Reflect(GetAnimatorIsLayerInTransition instance)
    {
        return new GetAnimatorIsLayerInTransitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsMatchingTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsMatchingTargetR Reflect(GetAnimatorIsMatchingTarget instance)
    {
        return new GetAnimatorIsMatchingTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GetAnimatorIsParameterControlledByCurve
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsParameterControlledByCurveR Reflect(GetAnimatorIsParameterControlledByCurve instance)
    {
        return new GetAnimatorIsParameterControlledByCurveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayerCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayerCountR Reflect(GetAnimatorLayerCount instance)
    {
        return new GetAnimatorLayerCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayerName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayerNameR Reflect(GetAnimatorLayerName instance)
    {
        return new GetAnimatorLayerNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayersAffectMassCenter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayersAffectMassCenterR Reflect(GetAnimatorLayersAffectMassCenter instance)
    {
        return new GetAnimatorLayersAffectMassCenterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayerWeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayerWeightR Reflect(GetAnimatorLayerWeight instance)
    {
        return new GetAnimatorLayerWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLeftFootBottomHeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLeftFootBottomHeightR Reflect(GetAnimatorLeftFootBottomHeight instance)
    {
        return new GetAnimatorLeftFootBottomHeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorNextStateInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorNextStateInfoR Reflect(GetAnimatorNextStateInfo instance)
    {
        return new GetAnimatorNextStateInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorPivot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorPivotR Reflect(GetAnimatorPivot instance)
    {
        return new GetAnimatorPivotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorPlayBackSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorPlayBackSpeedR Reflect(GetAnimatorPlayBackSpeed instance)
    {
        return new GetAnimatorPlayBackSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorPlayBackTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorPlayBackTimeR Reflect(GetAnimatorPlayBackTime instance)
    {
        return new GetAnimatorPlayBackTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorRightFootBottomHeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorRightFootBottomHeightR Reflect(GetAnimatorRightFootBottomHeight instance)
    {
        return new GetAnimatorRightFootBottomHeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorRoot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorRootR Reflect(GetAnimatorRoot instance)
    {
        return new GetAnimatorRootR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorSpeedR Reflect(GetAnimatorSpeed instance)
    {
        return new GetAnimatorSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorTargetR Reflect(GetAnimatorTarget instance)
    {
        return new GetAnimatorTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetASine
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetASineR Reflect(GetASine instance)
    {
        return new GetASineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtanR Reflect(GetAtan instance)
    {
        return new GetAtanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtan2R Reflect(GetAtan2 instance)
    {
        return new GetAtan2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan2FromVector2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtan2FromVector2R Reflect(GetAtan2FromVector2 instance)
    {
        return new GetAtan2FromVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan2FromVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtan2FromVector3R Reflect(GetAtan2FromVector3 instance)
    {
        return new GetAtan2FromVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAudioVolume
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAudioVolumeR Reflect(GetAudioVolume instance)
    {
        return new GetAudioVolumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAxis
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAxisR Reflect(GetAxis instance)
    {
        return new GetAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAxisVector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAxisVectorR Reflect(GetAxisVector instance)
    {
        return new GetAxisVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetBoolProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetBoolProxyR Reflect(GetBoolProxy instance)
    {
        return new GetBoolProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetButtonR Reflect(GetButton instance)
    {
        return new GetButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetButtonDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetButtonDownR Reflect(GetButtonDown instance)
    {
        return new GetButtonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetButtonUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetButtonUpR Reflect(GetButtonUp instance)
    {
        return new GetButtonUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCameraPixelDimensions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCameraPixelDimensionsR Reflect(GetCameraPixelDimensions instance)
    {
        return new GetCameraPixelDimensionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCanSeeHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCanSeeHeroR Reflect(GetCanSeeHero instance)
    {
        return new GetCanSeeHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCharmNum
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCharmNumR Reflect(GetCharmNum instance)
    {
        return new GetCharmNumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCharmNumString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCharmNumStringR Reflect(GetCharmNumString instance)
    {
        return new GetCharmNumStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCharmString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCharmStringR Reflect(GetCharmString instance)
    {
        return new GetCharmStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetChild
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetChildR Reflect(GetChild instance)
    {
        return new GetChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetChildCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetChildCountR Reflect(GetChildCount instance)
    {
        return new GetChildCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetChildNum
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetChildNumR Reflect(GetChildNum instance)
    {
        return new GetChildNumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetColliderRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetColliderRangeR Reflect(GetColliderRange instance)
    {
        return new GetColliderRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCollision2dInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCollision2dInfoR Reflect(GetCollision2dInfo instance)
    {
        return new GetCollision2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCollisionInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCollisionInfoR Reflect(GetCollisionInfo instance)
    {
        return new GetCollisionInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetColorRGBA
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetColorRGBAR Reflect(GetColorRGBA instance)
    {
        return new GetColorRGBAR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetComponent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetComponentR Reflect(GetComponent instance)
    {
        return new GetComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetConstantsValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetConstantsValueR Reflect(GetConstantsValue instance)
    {
        return new GetConstantsValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetControllerCollisionFlags
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetControllerCollisionFlagsR Reflect(GetControllerCollisionFlags instance)
    {
        return new GetControllerCollisionFlagsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetControllerHitInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetControllerHitInfoR Reflect(GetControllerHitInfo instance)
    {
        return new GetControllerHitInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCosine
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCosineR Reflect(GetCosine instance)
    {
        return new GetCosineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentLanguageAsString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentLanguageAsStringR Reflect(GetCurrentLanguageAsString instance)
    {
        return new GetCurrentLanguageAsStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentMusicCue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentMusicCueR Reflect(GetCurrentMusicCue instance)
    {
        return new GetCurrentMusicCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentMusicCueName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentMusicCueNameR Reflect(GetCurrentMusicCueName instance)
    {
        return new GetCurrentMusicCueNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentResolution
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentResolutionR Reflect(GetCurrentResolution instance)
    {
        return new GetCurrentResolutionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetDeviceAcceleration
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetDeviceAccelerationR Reflect(GetDeviceAcceleration instance)
    {
        return new GetDeviceAccelerationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetDeviceRoll
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetDeviceRollR Reflect(GetDeviceRoll instance)
    {
        return new GetDeviceRollR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetDistance
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetDistanceR Reflect(GetDistance instance)
    {
        return new GetDistanceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetEventInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetEventInfoR Reflect(GetEventInfo instance)
    {
        return new GetEventInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetEventProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetEventPropertiesR Reflect(GetEventProperties instance)
    {
        return new GetEventPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetEventSender
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetEventSenderR Reflect(GetEventSender instance)
    {
        return new GetEventSenderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFloatProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFloatProxyR Reflect(GetFloatProxy instance)
    {
        return new GetFloatProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmArray
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmArrayR Reflect(GetFsmArray instance)
    {
        return new GetFsmArrayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmArrayItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmArrayItemR Reflect(GetFsmArrayItem instance)
    {
        return new GetFsmArrayItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmBoolR Reflect(GetFsmBool instance)
    {
        return new GetFsmBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmColorR Reflect(GetFsmColor instance)
    {
        return new GetFsmColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmEnum
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmEnumR Reflect(GetFsmEnum instance)
    {
        return new GetFsmEnumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmFloatR Reflect(GetFsmFloat instance)
    {
        return new GetFsmFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmGameObjectR Reflect(GetFsmGameObject instance)
    {
        return new GetFsmGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmIntR Reflect(GetFsmInt instance)
    {
        return new GetFsmIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmMaterial
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmMaterialR Reflect(GetFsmMaterial instance)
    {
        return new GetFsmMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmObjectR Reflect(GetFsmObject instance)
    {
        return new GetFsmObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmQuaternion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmQuaternionR Reflect(GetFsmQuaternion instance)
    {
        return new GetFsmQuaternionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmRectR Reflect(GetFsmRect instance)
    {
        return new GetFsmRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmState
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmStateR Reflect(GetFsmState instance)
    {
        return new GetFsmStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmStringR Reflect(GetFsmString instance)
    {
        return new GetFsmStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmTexture
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmTextureR Reflect(GetFsmTexture instance)
    {
        return new GetFsmTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVariable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVariableR Reflect(GetFsmVariable instance)
    {
        return new GetFsmVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVariables
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVariablesR Reflect(GetFsmVariables instance)
    {
        return new GetFsmVariablesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVector2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVector2R Reflect(GetFsmVector2 instance)
    {
        return new GetFsmVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVector3R Reflect(GetFsmVector3 instance)
    {
        return new GetFsmVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetGrandparent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetGrandparentR Reflect(GetGrandparent instance)
    {
        return new GetGrandparentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetHeroR Reflect(GetHero instance)
    {
        return new GetHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetHP
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetHPR Reflect(GetHP instance)
    {
        return new GetHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetHPEveryFrame
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetHPEveryFrameR Reflect(GetHPEveryFrame instance)
    {
        return new GetHPEveryFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputAxis
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputAxisR Reflect(GetInControlDeviceInputAxis instance)
    {
        return new GetInControlDeviceInputAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputAxisVector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputAxisVectorR Reflect(GetInControlDeviceInputAxisVector instance)
    {
        return new GetInControlDeviceInputAxisVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputButtonR Reflect(GetInControlDeviceInputButton instance)
    {
        return new GetInControlDeviceInputButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputButtonDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputButtonDownR Reflect(GetInControlDeviceInputButtonDown instance)
    {
        return new GetInControlDeviceInputButtonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputButtonUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputButtonUpR Reflect(GetInControlDeviceInputButtonUp instance)
    {
        return new GetInControlDeviceInputButtonUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetIntProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetIntProxyR Reflect(GetIntProxy instance)
    {
        return new GetIntProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetIPhoneSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetIPhoneSettingsR Reflect(GetIPhoneSettings instance)
    {
        return new GetIPhoneSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetIsDead
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetIsDeadR Reflect(GetIsDead instance)
    {
        return new GetIsDeadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetJointBreak2dInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetJointBreak2dInfoR Reflect(GetJointBreak2dInfo instance)
    {
        return new GetJointBreak2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetJointBreakInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetJointBreakInfoR Reflect(GetJointBreakInfo instance)
    {
        return new GetJointBreakInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetKey
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetKeyR Reflect(GetKey instance)
    {
        return new GetKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetKeyDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetKeyDownR Reflect(GetKeyDown instance)
    {
        return new GetKeyDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetKeyUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetKeyUpR Reflect(GetKeyUp instance)
    {
        return new GetKeyUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLanguageString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLanguageStringR Reflect(GetLanguageString instance)
    {
        return new GetLanguageStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLanguageStringProcessed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLanguageStringProcessedR Reflect(GetLanguageStringProcessed instance)
    {
        return new GetLanguageStringProcessedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLastEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLastEventR Reflect(GetLastEvent instance)
    {
        return new GetLastEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLastPointerDataInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLastPointerDataInfoR Reflect(GetLastPointerDataInfo instance)
    {
        return new GetLastPointerDataInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLayerR Reflect(GetLayer instance)
    {
        return new GetLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLocationInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLocationInfoR Reflect(GetLocationInfo instance)
    {
        return new GetLocationInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMainCamera
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMainCameraR Reflect(GetMainCamera instance)
    {
        return new GetMainCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMass
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMassR Reflect(GetMass instance)
    {
        return new GetMassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMass2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMass2dR Reflect(GetMass2d instance)
    {
        return new GetMass2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMaterial
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMaterialR Reflect(GetMaterial instance)
    {
        return new GetMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMaterialColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMaterialColorR Reflect(GetMaterialColor instance)
    {
        return new GetMaterialColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMaterialTexture
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMaterialTextureR Reflect(GetMaterialTexture instance)
    {
        return new GetMaterialTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMeshRendererBounds
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMeshRendererBoundsR Reflect(GetMeshRendererBounds instance)
    {
        return new GetMeshRendererBoundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMidPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMidPointR Reflect(GetMidPoint instance)
    {
        return new GetMidPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseButtonR Reflect(GetMouseButton instance)
    {
        return new GetMouseButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseButtonDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseButtonDownR Reflect(GetMouseButtonDown instance)
    {
        return new GetMouseButtonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseButtonUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseButtonUpR Reflect(GetMouseButtonUp instance)
    {
        return new GetMouseButtonUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseX
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseXR Reflect(GetMouseX instance)
    {
        return new GetMouseXR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseY
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseYR Reflect(GetMouseY instance)
    {
        return new GetMouseYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNailDamage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNailDamageR Reflect(GetNailDamage instance)
    {
        return new GetNailDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNameR Reflect(GetName instance)
    {
        return new GetNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNamedParent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNamedParentR Reflect(GetNamedParent instance)
    {
        return new GetNamedParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextChild
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextChildR Reflect(GetNextChild instance)
    {
        return new GetNextChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextLineCast2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextLineCast2dR Reflect(GetNextLineCast2d instance)
    {
        return new GetNextLineCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextOverlapArea2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextOverlapArea2dR Reflect(GetNextOverlapArea2d instance)
    {
        return new GetNextOverlapArea2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextOverlapCircle2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextOverlapCircle2dR Reflect(GetNextOverlapCircle2d instance)
    {
        return new GetNextOverlapCircle2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextOverlapPoint2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextOverlapPoint2dR Reflect(GetNextOverlapPoint2d instance)
    {
        return new GetNextOverlapPoint2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextPreSpawnedGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextPreSpawnedGameObjectR Reflect(GetNextPreSpawnedGameObject instance)
    {
        return new GetNextPreSpawnedGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextRayCast2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextRayCast2dR Reflect(GetNextRayCast2d instance)
    {
        return new GetNextRayCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetOwner
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetOwnerR Reflect(GetOwner instance)
    {
        return new GetOwnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetParent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetParentR Reflect(GetParent instance)
    {
        return new GetParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetParticleCollisionInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetParticleCollisionInfoR Reflect(GetParticleCollisionInfo instance)
    {
        return new GetParticleCollisionInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPersistentBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPersistentBoolR Reflect(GetPersistentBool instance)
    {
        return new GetPersistentBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPersistentBoolFromSaveData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPersistentBoolFromSaveDataR Reflect(GetPersistentBoolFromSaveData instance)
    {
        return new GetPersistentBoolFromSaveDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataBoolR Reflect(GetPlayerDataBool instance)
    {
        return new GetPlayerDataBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataFloatR Reflect(GetPlayerDataFloat instance)
    {
        return new GetPlayerDataFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataIntR Reflect(GetPlayerDataInt instance)
    {
        return new GetPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataStringR Reflect(GetPlayerDataString instance)
    {
        return new GetPlayerDataStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataVector3R Reflect(GetPlayerDataVector3 instance)
    {
        return new GetPlayerDataVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPositionR Reflect(GetPosition instance)
    {
        return new GetPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPosition2D
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPosition2DR Reflect(GetPosition2D instance)
    {
        return new GetPosition2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPreInstantiatedGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPreInstantiatedGameObjectR Reflect(GetPreInstantiatedGameObject instance)
    {
        return new GetPreInstantiatedGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPreviousStateName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPreviousStateNameR Reflect(GetPreviousStateName instance)
    {
        return new GetPreviousStateNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetProperty
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPropertyR Reflect(GetProperty instance)
    {
        return new GetPropertyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionEulerAngles
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionEulerAnglesR Reflect(GetQuaternionEulerAngles instance)
    {
        return new GetQuaternionEulerAnglesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionFromRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionFromRotationR Reflect(GetQuaternionFromRotation instance)
    {
        return new GetQuaternionFromRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionMultipliedByQuaternion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionMultipliedByQuaternionR Reflect(GetQuaternionMultipliedByQuaternion instance)
    {
        return new GetQuaternionMultipliedByQuaternionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionMultipliedByVector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionMultipliedByVectorR Reflect(GetQuaternionMultipliedByVector instance)
    {
        return new GetQuaternionMultipliedByVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRandomChild
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRandomChildR Reflect(GetRandomChild instance)
    {
        return new GetRandomChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRandomObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRandomObjectR Reflect(GetRandomObject instance)
    {
        return new GetRandomObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRaycastAllInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRaycastAllInfoR Reflect(GetRaycastAllInfo instance)
    {
        return new GetRaycastAllInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRayCastHit2dInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRayCastHit2dInfoR Reflect(GetRayCastHit2dInfo instance)
    {
        return new GetRayCastHit2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRaycastHitInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRaycastHitInfoR Reflect(GetRaycastHitInfo instance)
    {
        return new GetRaycastHitInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRectFields
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRectFieldsR Reflect(GetRectFields instance)
    {
        return new GetRectFieldsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRespawningHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRespawningHeroR Reflect(GetRespawningHero instance)
    {
        return new GetRespawningHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRoot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRootR Reflect(GetRoot instance)
    {
        return new GetRootR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRotationR Reflect(GetRotation instance)
    {
        return new GetRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetScaleR Reflect(GetScale instance)
    {
        return new GetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetScreenHeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetScreenHeightR Reflect(GetScreenHeight instance)
    {
        return new GetScreenHeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetScreenWidth
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetScreenWidthR Reflect(GetScreenWidth instance)
    {
        return new GetScreenWidthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSine
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSineR Reflect(GetSine instance)
    {
        return new GetSineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSpeedR Reflect(GetSpeed instance)
    {
        return new GetSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSpeed2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSpeed2dR Reflect(GetSpeed2d instance)
    {
        return new GetSpeed2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSpriteRendererSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSpriteRendererSpriteR Reflect(GetSpriteRendererSprite instance)
    {
        return new GetSpriteRendererSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStaticVariable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStaticVariableR Reflect(GetStaticVariable instance)
    {
        return new GetStaticVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringLeft
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringLeftR Reflect(GetStringLeft instance)
    {
        return new GetStringLeftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringLength
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringLengthR Reflect(GetStringLength instance)
    {
        return new GetStringLengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringProxyR Reflect(GetStringProxy instance)
    {
        return new GetStringProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringRight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringRightR Reflect(GetStringRight instance)
    {
        return new GetStringRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSubstring
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSubstringR Reflect(GetSubstring instance)
    {
        return new GetSubstringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSystemDateTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSystemDateTimeR Reflect(GetSystemDateTime instance)
    {
        return new GetSystemDateTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTagR Reflect(GetTag instance)
    {
        return new GetTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTagCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTagCountR Reflect(GetTagCount instance)
    {
        return new GetTagCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTan
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTanR Reflect(GetTan instance)
    {
        return new GetTanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTimeInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTimeInfoR Reflect(GetTimeInfo instance)
    {
        return new GetTimeInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTMProLeftVertex
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTMProLeftVertexR Reflect(GetTMProLeftVertex instance)
    {
        return new GetTMProLeftVertexR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTouchCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTouchCountR Reflect(GetTouchCount instance)
    {
        return new GetTouchCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTouchInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTouchInfoR Reflect(GetTouchInfo instance)
    {
        return new GetTouchInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTransform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTransformR Reflect(GetTransform instance)
    {
        return new GetTransformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTrigger2dInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTrigger2dInfoR Reflect(GetTrigger2dInfo instance)
    {
        return new GetTrigger2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTriggerInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTriggerInfoR Reflect(GetTriggerInfo instance)
    {
        return new GetTriggerInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVariableProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVariableProxyR Reflect(GetVariableProxy instance)
    {
        return new GetVariableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVector2XY
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVector2XYR Reflect(GetVector2XY instance)
    {
        return new GetVector2XYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVector3Proxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVector3ProxyR Reflect(GetVector3Proxy instance)
    {
        return new GetVector3ProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVector3XYZ
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVector3XYZR Reflect(GetVector3XYZ instance)
    {
        return new GetVector3XYZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVectorLength
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVectorLengthR Reflect(GetVectorLength instance)
    {
        return new GetVectorLengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVelocity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVelocityR Reflect(GetVelocity instance)
    {
        return new GetVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVelocity2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVelocity2dR Reflect(GetVelocity2d instance)
    {
        return new GetVelocity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVelocityAsAngle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVelocityAsAngleR Reflect(GetVelocityAsAngle instance)
    {
        return new GetVelocityAsAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVertexCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVertexCountR Reflect(GetVertexCount instance)
    {
        return new GetVertexCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVertexPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVertexPositionR Reflect(GetVertexPosition instance)
    {
        return new GetVertexPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetXDistance
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetXDistanceR Reflect(GetXDistance instance)
    {
        return new GetXDistanceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetYDistance
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetYDistanceR Reflect(GetYDistance instance)
    {
        return new GetYDistanceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBossSceneUnlocked
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBossSceneUnlockedR Reflect(GGCheckBossSceneUnlocked instance)
    {
        return new GGCheckBossSceneUnlockedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBossSequenceList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBossSequenceListR Reflect(GGCheckBossSequenceList instance)
    {
        return new GGCheckBossSequenceListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundCharms
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundCharmsR Reflect(GGCheckBoundCharms instance)
    {
        return new GGCheckBoundCharmsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundHeart
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundHeartR Reflect(GGCheckBoundHeart instance)
    {
        return new GGCheckBoundHeartR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundNail
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundNailR Reflect(GGCheckBoundNail instance)
    {
        return new GGCheckBoundNailR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundSoul
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundSoulR Reflect(GGCheckBoundSoul instance)
    {
        return new GGCheckBoundSoulR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfBossScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfBossSceneR Reflect(GGCheckIfBossScene instance)
    {
        return new GGCheckIfBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfBossSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfBossSequenceR Reflect(GGCheckIfBossSequence instance)
    {
        return new GGCheckIfBossSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfBossSequenceCompleted
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfBossSequenceCompletedR Reflect(GGCheckIfBossSequenceCompleted instance)
    {
        return new GGCheckIfBossSequenceCompletedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfFirstBossScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfFirstBossSceneR Reflect(GGCheckIfFirstBossScene instance)
    {
        return new GGCheckIfFirstBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfLastBossScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfLastBossSceneR Reflect(GGCheckIfLastBossScene instance)
    {
        return new GGCheckIfLastBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIsBossRushMode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIsBossRushModeR Reflect(GGCheckIsBossRushMode instance)
    {
        return new GGCheckIsBossRushModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCountCompletedBossDoors
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCountCompletedBossDoorsR Reflect(GGCountCompletedBossDoors instance)
    {
        return new GGCountCompletedBossDoorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGGetBossDoorCompletion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGGetBossDoorCompletionR Reflect(GGGetBossDoorCompletion instance)
    {
        return new GGGetBossDoorCompletionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGGetCompletedBindings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGGetCompletedBindingsR Reflect(GGGetCompletedBindings instance)
    {
        return new GGGetCompletedBindingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGGetTotalBindings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGGetTotalBindingsR Reflect(GGGetTotalBindings instance)
    {
        return new GGGetTotalBindingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGResetBossSequenceController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGResetBossSequenceControllerR Reflect(GGResetBossSequenceController instance)
    {
        return new GGResetBossSequenceControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGWaitForBossSceneTransitionIn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGWaitForBossSceneTransitionInR Reflect(GGWaitForBossSceneTransitionIn instance)
    {
        return new GGWaitForBossSceneTransitionInR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GhostMovement
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GhostMovementR Reflect(GhostMovement instance)
    {
        return new GhostMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlobalPrefabDefaults
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlobalPrefabDefaultsR Reflect(GlobalPrefabDefaults instance)
    {
        return new GlobalPrefabDefaultsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlobControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlobControlR Reflect(GlobControl instance)
    {
        return new GlobControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlowResponse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlowResponseR Reflect(GlowResponse instance)
    {
        return new GlowResponseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlowResponseEnd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlowResponseEndR Reflect(GlowResponseEnd instance)
    {
        return new GlowResponseEndR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Glyph2D
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Glyph2DR Reflect(Glyph2D instance)
    {
        return new Glyph2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderGateIcon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderGateIconR Reflect(GodfinderGateIcon instance)
    {
        return new GodfinderGateIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderGateIconManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderGateIconManagerR Reflect(GodfinderGateIconManager instance)
    {
        return new GodfinderGateIconManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderIcon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderIconR Reflect(GodfinderIcon instance)
    {
        return new GodfinderIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderInvIcon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderInvIconR Reflect(GodfinderInvIcon instance)
    {
        return new GodfinderInvIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaMacNativeProfileR Reflect(GoogleStadiaMacNativeProfile instance)
    {
        return new GoogleStadiaMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaMacUnityProfileR Reflect(GoogleStadiaMacUnityProfile instance)
    {
        return new GoogleStadiaMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaUnityProfileR Reflect(GoogleStadiaUnityProfile instance)
    {
        return new GoogleStadiaUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaWindowsNativeProfileR Reflect(GoogleStadiaWindowsNativeProfile instance)
    {
        return new GoogleStadiaWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaWindowsUnityProfileR Reflect(GoogleStadiaWindowsUnityProfile instance)
    {
        return new GoogleStadiaWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GotoPreviousState
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GotoPreviousStateR Reflect(GotoPreviousState instance)
    {
        return new GotoPreviousStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeMarker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeMarkerR Reflect(GradeMarker instance)
    {
        return new GradeMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeOverride
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeOverrideR Reflect(GradeOverride instance)
    {
        return new GradeOverrideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeTriggerR Reflect(GradeTrigger instance)
    {
        return new GradeTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeZone
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeZoneR Reflect(GradeZone instance)
    {
        return new GradeZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Grass
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassR Reflect(Grass instance)
    {
        return new GrassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassBehaviour
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassBehaviourR Reflect(GrassBehaviour instance)
    {
        return new GrassBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassCut
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassCutR Reflect(GrassCut instance)
    {
        return new GrassCutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassSpriteBehaviour
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassSpriteBehaviourR Reflect(GrassSpriteBehaviour instance)
    {
        return new GrassSpriteBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassWind
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassWindR Reflect(GrassWind instance)
    {
        return new GrassWindR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GreenThrottleAtlasAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GreenThrottleAtlasAndroidUnityProfileR Reflect(GreenThrottleAtlasAndroidUnityProfile instance)
    {
        return new GreenThrottleAtlasAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GridNavGraph
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GridNavGraphR Reflect(GridNavGraph instance)
    {
        return new GridNavGraphR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrimmballControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrimmballControlR Reflect(GrimmballControl instance)
    {
        return new GrimmballControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrimmChildFly
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrimmChildFlyR Reflect(GrimmChildFly instance)
    {
        return new GrimmChildFlyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrimmEnemyRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrimmEnemyRangeR Reflect(GrimmEnemyRange instance)
    {
        return new GrimmEnemyRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrubBGControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrubBGControlR Reflect(GrubBGControl instance)
    {
        return new GrubBGControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrubPin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrubPinR Reflect(GrubPin instance)
    {
        return new GrubPinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIBox
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIBoxR Reflect(GUIBox instance)
    {
        return new GUIBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIButtonR Reflect(GUIButton instance)
    {
        return new GUIButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIHorizontalSlider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIHorizontalSliderR Reflect(GUIHorizontalSlider instance)
    {
        return new GUIHorizontalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILabel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILabelR Reflect(GUILabel instance)
    {
        return new GUILabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginArea
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginAreaR Reflect(GUILayoutBeginArea instance)
    {
        return new GUILayoutBeginAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginAreaFollowObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginAreaFollowObjectR Reflect(GUILayoutBeginAreaFollowObject instance)
    {
        return new GUILayoutBeginAreaFollowObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginCentered
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginCenteredR Reflect(GUILayoutBeginCentered instance)
    {
        return new GUILayoutBeginCenteredR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginHorizontal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginHorizontalR Reflect(GUILayoutBeginHorizontal instance)
    {
        return new GUILayoutBeginHorizontalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginScrollView
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginScrollViewR Reflect(GUILayoutBeginScrollView instance)
    {
        return new GUILayoutBeginScrollViewR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginVertical
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginVerticalR Reflect(GUILayoutBeginVertical instance)
    {
        return new GUILayoutBeginVerticalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBox
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBoxR Reflect(GUILayoutBox instance)
    {
        return new GUILayoutBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutButtonR Reflect(GUILayoutButton instance)
    {
        return new GUILayoutButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutConfirmPasswordField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutConfirmPasswordFieldR Reflect(GUILayoutConfirmPasswordField instance)
    {
        return new GUILayoutConfirmPasswordFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEmailField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEmailFieldR Reflect(GUILayoutEmailField instance)
    {
        return new GUILayoutEmailFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndArea
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndAreaR Reflect(GUILayoutEndArea instance)
    {
        return new GUILayoutEndAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndCentered
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndCenteredR Reflect(GUILayoutEndCentered instance)
    {
        return new GUILayoutEndCenteredR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndHorizontal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndHorizontalR Reflect(GUILayoutEndHorizontal instance)
    {
        return new GUILayoutEndHorizontalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndScrollView
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndScrollViewR Reflect(GUILayoutEndScrollView instance)
    {
        return new GUILayoutEndScrollViewR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndVertical
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndVerticalR Reflect(GUILayoutEndVertical instance)
    {
        return new GUILayoutEndVerticalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutFlexibleSpace
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutFlexibleSpaceR Reflect(GUILayoutFlexibleSpace instance)
    {
        return new GUILayoutFlexibleSpaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutFloatField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutFloatFieldR Reflect(GUILayoutFloatField instance)
    {
        return new GUILayoutFloatFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutFloatLabel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutFloatLabelR Reflect(GUILayoutFloatLabel instance)
    {
        return new GUILayoutFloatLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutHorizontalSlider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutHorizontalSliderR Reflect(GUILayoutHorizontalSlider instance)
    {
        return new GUILayoutHorizontalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutIntField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutIntFieldR Reflect(GUILayoutIntField instance)
    {
        return new GUILayoutIntFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutIntLabel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutIntLabelR Reflect(GUILayoutIntLabel instance)
    {
        return new GUILayoutIntLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutLabel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutLabelR Reflect(GUILayoutLabel instance)
    {
        return new GUILayoutLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutPasswordField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutPasswordFieldR Reflect(GUILayoutPasswordField instance)
    {
        return new GUILayoutPasswordFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutRepeatButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutRepeatButtonR Reflect(GUILayoutRepeatButton instance)
    {
        return new GUILayoutRepeatButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutSpace
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutSpaceR Reflect(GUILayoutSpace instance)
    {
        return new GUILayoutSpaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutTextField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutTextFieldR Reflect(GUILayoutTextField instance)
    {
        return new GUILayoutTextFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutTextLabel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutTextLabelR Reflect(GUILayoutTextLabel instance)
    {
        return new GUILayoutTextLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutToggle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutToggleR Reflect(GUILayoutToggle instance)
    {
        return new GUILayoutToggleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutToolbar
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutToolbarR Reflect(GUILayoutToolbar instance)
    {
        return new GUILayoutToolbarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutVerticalSlider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutVerticalSliderR Reflect(GUILayoutVerticalSlider instance)
    {
        return new GUILayoutVerticalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GuitarHeroControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GuitarHeroControllerMacNativeProfileR Reflect(GuitarHeroControllerMacNativeProfile instance)
    {
        return new GuitarHeroControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUITooltip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUITooltipR Reflect(GUITooltip instance)
    {
        return new GUITooltipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIVerticalSlider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIVerticalSliderR Reflect(GUIVerticalSlider instance)
    {
        return new GUIVerticalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HamaBlackForceWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HamaBlackForceWindowsUnityProfileR Reflect(HamaBlackForceWindowsUnityProfile instance)
    {
        return new HamaBlackForceWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HardLandEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HardLandEffectR Reflect(HardLandEffect instance)
    {
        return new HardLandEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HarmonixDrumKitMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HarmonixDrumKitMacNativeProfileR Reflect(HarmonixDrumKitMacNativeProfile instance)
    {
        return new HarmonixDrumKitMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HarmonixGuitarMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HarmonixGuitarMacNativeProfileR Reflect(HarmonixGuitarMacNativeProfile instance)
    {
        return new HarmonixGuitarMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HarmonixKeyboardMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HarmonixKeyboardMacNativeProfileR Reflect(HarmonixKeyboardMacNativeProfile instance)
    {
        return new HarmonixKeyboardMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HasComponent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HasComponentR Reflect(HasComponent instance)
    {
        return new HasComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableAddR Reflect(HashTableAdd instance)
    {
        return new HashTableAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableAddMany
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableAddManyR Reflect(HashTableAddMany instance)
    {
        return new HashTableAddManyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableClear
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableClearR Reflect(HashTableClear instance)
    {
        return new HashTableClearR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableConcat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableConcatR Reflect(HashTableConcat instance)
    {
        return new HashTableConcatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableContains
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableContainsR Reflect(HashTableContains instance)
    {
        return new HashTableContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableContainsKey
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableContainsKeyR Reflect(HashTableContainsKey instance)
    {
        return new HashTableContainsKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableContainsValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableContainsValueR Reflect(HashTableContainsValue instance)
    {
        return new HashTableContainsValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableCount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableCountR Reflect(HashTableCount instance)
    {
        return new HashTableCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableCreate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableCreateR Reflect(HashTableCreate instance)
    {
        return new HashTableCreateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableEditKey
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableEditKeyR Reflect(HashTableEditKey instance)
    {
        return new HashTableEditKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableExists
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableExistsR Reflect(HashTableExists instance)
    {
        return new HashTableExistsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetR Reflect(HashTableGet instance)
    {
        return new HashTableGetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGetKeyFromValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetKeyFromValueR Reflect(HashTableGetKeyFromValue instance)
    {
        return new HashTableGetKeyFromValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGetMany
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetManyR Reflect(HashTableGetMany instance)
    {
        return new HashTableGetManyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGetNext
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetNextR Reflect(HashTableGetNext instance)
    {
        return new HashTableGetNextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableIsEmpty
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableIsEmptyR Reflect(HashTableIsEmpty instance)
    {
        return new HashTableIsEmptyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableKeys
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableKeysR Reflect(HashTableKeys instance)
    {
        return new HashTableKeysR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableRemove
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableRemoveR Reflect(HashTableRemove instance)
    {
        return new HashTableRemoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableRevertSnapShot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableRevertSnapShotR Reflect(HashTableRevertSnapShot instance)
    {
        return new HashTableRevertSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableSet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableSetR Reflect(HashTableSet instance)
    {
        return new HashTableSetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableSetMany
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableSetManyR Reflect(HashTableSetMany instance)
    {
        return new HashTableSetManyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableSortKeysfromValues
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableSortKeysfromValuesR Reflect(HashTableSortKeysfromValues instance)
    {
        return new HashTableSortKeysfromValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableTakeSnapShot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableTakeSnapShotR Reflect(HashTableTakeSnapShot instance)
    {
        return new HashTableTakeSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableValues
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableValuesR Reflect(HashTableValues instance)
    {
        return new HashTableValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HavitHVG95WLinuxProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HavitHVG95WLinuxProfileR Reflect(HavitHVG95WLinuxProfile instance)
    {
        return new HavitHVG95WLinuxProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HazardRespawnMarker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HazardRespawnMarkerR Reflect(HazardRespawnMarker instance)
    {
        return new HazardRespawnMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HazardRespawnTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HazardRespawnTriggerR Reflect(HazardRespawnTrigger instance)
    {
        return new HazardRespawnTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HealthCocoon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HealthCocoonR Reflect(HealthCocoon instance)
    {
        return new HealthCocoonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HealthManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HealthManagerR Reflect(HealthManager instance)
    {
        return new HealthManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroActions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroActionsR Reflect(HeroActions instance)
    {
        return new HeroActionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroAnimationController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroAnimationControllerR Reflect(HeroAnimationController instance)
    {
        return new HeroAnimationControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroAudioController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroAudioControllerR Reflect(HeroAudioController instance)
    {
        return new HeroAudioControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroBox
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroBoxR Reflect(HeroBox instance)
    {
        return new HeroBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroControllerStates
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroControllerStatesR Reflect(HeroControllerStates instance)
    {
        return new HeroControllerStatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroDetect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroDetectR Reflect(HeroDetect instance)
    {
        return new HeroDetectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroPlatformStick
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroPlatformStickR Reflect(HeroPlatformStick instance)
    {
        return new HeroPlatformStickR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HexadecimalAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HexadecimalAttributeR Reflect(HexadecimalAttribute instance)
    {
        return new HexadecimalAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HidePromptMarker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HidePromptMarkerR Reflect(HidePromptMarker instance)
    {
        return new HidePromptMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HitInstanceHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HitInstanceHandlerR Reflect(HitInstanceHandler instance)
    {
        return new HitInstanceHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HiveKnightStinger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HiveKnightStingerR Reflect(HiveKnightStinger instance)
    {
        return new HiveKnightStingerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HollowKnightInputModule
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HollowKnightInputModuleR Reflect(HollowKnightInputModule instance)
    {
        return new HollowKnightInputModuleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoneyBeeControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoneyBeeControllerMacNativeProfileR Reflect(HoneyBeeControllerMacNativeProfile instance)
    {
        return new HoneyBeeControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriBlueSoloControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriBlueSoloControllerMacNativeProfileR Reflect(HoriBlueSoloControllerMacNativeProfile instance)
    {
        return new HoriBlueSoloControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriControllerMacNativeProfileR Reflect(HoriControllerMacNativeProfile instance)
    {
        return new HoriControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriDOA4ArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriDOA4ArcadeStickMacNativeProfileR Reflect(HoriDOA4ArcadeStickMacNativeProfile instance)
    {
        return new HoriDOA4ArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriEdgeFightingStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriEdgeFightingStickMacNativeProfileR Reflect(HoriEdgeFightingStickMacNativeProfile instance)
    {
        return new HoriEdgeFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriEX2ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriEX2ControllerMacNativeProfileR Reflect(HoriEX2ControllerMacNativeProfile instance)
    {
        return new HoriEX2ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HORIFightingCommanderControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HORIFightingCommanderControllerMacNativeProfileR Reflect(
        HORIFightingCommanderControllerMacNativeProfile instance)
    {
        return new HORIFightingCommanderControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriFightingCommanderMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightingCommanderMacNativeProfileR Reflect(HoriFightingCommanderMacNativeProfile instance)
    {
        return new HoriFightingCommanderMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriFightingEdgeArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightingEdgeArcadeStickMacNativeProfileR Reflect(
        HoriFightingEdgeArcadeStickMacNativeProfile instance)
    {
        return new HoriFightingEdgeArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriFightingStickEX2MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightingStickEX2MacNativeProfileR Reflect(HoriFightingStickEX2MacNativeProfile instance)
    {
        return new HoriFightingStickEX2MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriFightingStickMiniMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightingStickMiniMacNativeProfileR Reflect(HoriFightingStickMiniMacNativeProfile instance)
    {
        return new HoriFightingStickMiniMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriFightingStickVXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightingStickVXMacNativeProfileR Reflect(HoriFightingStickVXMacNativeProfile instance)
    {
        return new HoriFightingStickVXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightStickMacNativeProfileR Reflect(HoriFightStickMacNativeProfile instance)
    {
        return new HoriFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriPadEXTurboControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriPadEXTurboControllerMacNativeProfileR
        Reflect(HoriPadEXTurboControllerMacNativeProfile instance)
    {
        return new HoriPadEXTurboControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriPadUltimateMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriPadUltimateMacNativeProfileR Reflect(HoriPadUltimateMacNativeProfile instance)
    {
        return new HoriPadUltimateMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRAPNFightingStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRAPNFightingStickMacNativeProfileR Reflect(HoriRAPNFightingStickMacNativeProfile instance)
    {
        return new HoriRAPNFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriRealArcadeProEXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProEXMacNativeProfileR Reflect(HoriRealArcadeProEXMacNativeProfile instance)
    {
        return new HoriRealArcadeProEXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProEXPremiumVLXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProEXPremiumVLXMacNativeProfileR Reflect(
        HoriRealArcadeProEXPremiumVLXMacNativeProfile instance)
    {
        return new HoriRealArcadeProEXPremiumVLXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProEXSEMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProEXSEMacNativeProfileR Reflect(HoriRealArcadeProEXSEMacNativeProfile instance)
    {
        return new HoriRealArcadeProEXSEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProHayabusaMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProHayabusaMacNativeProfileR
        Reflect(HoriRealArcadeProHayabusaMacNativeProfile instance)
    {
        return new HoriRealArcadeProHayabusaMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriRealArcadeProIVMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProIVMacNativeProfileR Reflect(HoriRealArcadeProIVMacNativeProfile instance)
    {
        return new HoriRealArcadeProIVMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProVHayabusaMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProVHayabusaMacNativeProfileR Reflect(
        HoriRealArcadeProVHayabusaMacNativeProfile instance)
    {
        return new HoriRealArcadeProVHayabusaMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProVKaiFightingStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProVKaiFightingStickMacNativeProfileR Reflect(
        HoriRealArcadeProVKaiFightingStickMacNativeProfile instance)
    {
        return new HoriRealArcadeProVKaiFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriRealArcadeProVXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProVXMacNativeProfileR Reflect(HoriRealArcadeProVXMacNativeProfile instance)
    {
        return new HoriRealArcadeProVXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProVXSAMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProVXSAMacNativeProfileR Reflect(HoriRealArcadeProVXSAMacNativeProfile instance)
    {
        return new HoriRealArcadeProVXSAMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriXbox360GemPadExMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriXbox360GemPadExMacNativeProfileR Reflect(HoriXbox360GemPadExMacNativeProfile instance)
    {
        return new HoriXbox360GemPadExMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HUDCamera
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HUDCameraR Reflect(HUDCamera instance)
    {
        return new HUDCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HyperkinX91MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HyperkinX91MacNativeProfileR Reflect(HyperkinX91MacNativeProfile instance)
    {
        return new HyperkinX91MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzz
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzR Reflect(IdleBuzz instance)
    {
        return new IdleBuzzR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzzing
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzingR Reflect(IdleBuzzing instance)
    {
        return new IdleBuzzingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzzV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzV2R Reflect(IdleBuzzV2 instance)
    {
        return new IdleBuzzV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzzV3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzV3R Reflect(IdleBuzzV3 instance)
    {
        return new IdleBuzzV3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IgnoreHeroCollision
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IgnoreHeroCollisionR Reflect(IgnoreHeroCollision instance)
    {
        return new IgnoreHeroCollisionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InControlException
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InControlExceptionR Reflect(InControlException instance)
    {
        return new InControlExceptionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InControlInputModule
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InControlInputModuleR Reflect(InControlInputModule instance)
    {
        return new InControlInputModuleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InControlManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InControlManagerR Reflect(InControlManager instance)
    {
        return new InControlManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IncrementPlayerDataInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IncrementPlayerDataIntR Reflect(IncrementPlayerDataInt instance)
    {
        return new IncrementPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IncrementRenderQueue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IncrementRenderQueueR Reflect(IncrementRenderQueue instance)
    {
        return new IncrementRenderQueueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InfectedBurstLarge
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InfectedBurstLargeR Reflect(InfectedBurstLarge instance)
    {
        return new InfectedBurstLargeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InfectedBurstSmall
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InfectedBurstSmallR Reflect(InfectedBurstSmall instance)
    {
        return new InfectedBurstSmallR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InfectedEnemyEffects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InfectedEnemyEffectsR Reflect(InfectedEnemyEffects instance)
    {
        return new InfectedEnemyEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InGameConsoleSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InGameConsoleSettingsR Reflect(InGameConsoleSettings instance)
    {
        return new InGameConsoleSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InGameCutsceneInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InGameCutsceneInfoR Reflect(InGameCutsceneInfo instance)
    {
        return new InGameCutsceneInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of INIParser
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static INIParserR Reflect(INIParser instance)
    {
        return new INIParserR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InjusticeFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InjusticeFightStickMacNativeProfileR Reflect(InjusticeFightStickMacNativeProfile instance)
    {
        return new InjusticeFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InlineGraphic
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InlineGraphicR Reflect(InlineGraphic instance)
    {
        return new InlineGraphicR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InlineGraphicManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InlineGraphicManagerR Reflect(InlineGraphicManager instance)
    {
        return new InlineGraphicManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputControlR Reflect(InputControl instance)
    {
        return new InputControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputControlMapping
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputControlMappingR Reflect(InputControlMapping instance)
    {
        return new InputControlMappingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputDevice
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputDeviceR Reflect(InputDevice instance)
    {
        return new InputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputDeviceProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputDeviceProfileR Reflect(InputDeviceProfile instance)
    {
        return new InputDeviceProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputHandlerR Reflect(InputHandler instance)
    {
        return new InputHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputModuleActionAdaptor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputModuleActionAdaptorR Reflect(InputModuleActionAdaptor instance)
    {
        return new InputModuleActionAdaptorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputModuleBinder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputModuleBinderR Reflect(InputModuleBinder instance)
    {
        return new InputModuleBinderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InstaDeath
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InstaDeathR Reflect(InstaDeath instance)
    {
        return new InstaDeathR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntAddR Reflect(IntAdd instance)
    {
        return new IntAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntAddV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntAddV2R Reflect(IntAddV2 instance)
    {
        return new IntAddV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntChanged
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntChangedR Reflect(IntChanged instance)
    {
        return new IntChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntClamp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntClampR Reflect(IntClamp instance)
    {
        return new IntClampR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntCompareR Reflect(IntCompare instance)
    {
        return new IntCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntCompareToBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntCompareToBoolR Reflect(IntCompareToBool instance)
    {
        return new IntCompareToBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntOperator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntOperatorR Reflect(IntOperator instance)
    {
        return new IntOperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntSwitch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntSwitchR Reflect(IntSwitch instance)
    {
        return new IntSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntTestToBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntTestToBoolR Reflect(IntTestToBool instance)
    {
        return new IntTestToBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvAnimateUpAndDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvAnimateUpAndDownR Reflect(InvAnimateUpAndDown instance)
    {
        return new InvAnimateUpAndDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvCharmBackboard
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvCharmBackboardR Reflect(InvCharmBackboard instance)
    {
        return new InvCharmBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InventoryArrowContainer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InventoryArrowContainerR Reflect(InventoryArrowContainer instance)
    {
        return new InventoryArrowContainerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InverseTransformDirection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InverseTransformDirectionR Reflect(InverseTransformDirection instance)
    {
        return new InverseTransformDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InverseTransformPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InverseTransformPointR Reflect(InverseTransformPoint instance)
    {
        return new InverseTransformPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvItemDisplay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvItemDisplayR Reflect(InvItemDisplay instance)
    {
        return new InvItemDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvMarker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvMarkerR Reflect(InvMarker instance)
    {
        return new InvMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvMarkerCollide
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvMarkerCollideR Reflect(InvMarkerCollide instance)
    {
        return new InvMarkerCollideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvNailArtBackboard
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvNailArtBackboardR Reflect(InvNailArtBackboard instance)
    {
        return new InvNailArtBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvNailSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvNailSpriteR Reflect(InvNailSprite instance)
    {
        return new InvNailSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvokeMethod
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvokeMethodR Reflect(InvokeMethod instance)
    {
        return new InvokeMethodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvRelicBackboard
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvRelicBackboardR Reflect(InvRelicBackboard instance)
    {
        return new InvRelicBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvulnerablePulse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvulnerablePulseR Reflect(InvulnerablePulse instance)
    {
        return new InvulnerablePulseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvVesselFragments
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvVesselFragmentsR Reflect(InvVesselFragments instance)
    {
        return new InvVesselFragmentsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IonDrumRockerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IonDrumRockerMacNativeProfileR Reflect(IonDrumRockerMacNativeProfile instance)
    {
        return new IonDrumRockerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9021AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9021AndroidUnityProfileR Reflect(IpegaPG9021AndroidUnityProfile instance)
    {
        return new IpegaPG9021AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9023AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9023AndroidUnityProfileR Reflect(IpegaPG9023AndroidUnityProfile instance)
    {
        return new IpegaPG9023AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9025AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9025AndroidUnityProfileR Reflect(IpegaPG9025AndroidUnityProfile instance)
    {
        return new IpegaPG9025AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9037AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9037AndroidUnityProfileR Reflect(IpegaPG9037AndroidUnityProfile instance)
    {
        return new IpegaPG9037AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9055AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9055AndroidUnityProfileR Reflect(IpegaPG9055AndroidUnityProfile instance)
    {
        return new IpegaPG9055AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9068AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9068AndroidUnityProfileR Reflect(IpegaPG9068AndroidUnityProfile instance)
    {
        return new IpegaPG9068AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsFixedAngle2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsFixedAngle2dR Reflect(IsFixedAngle2d instance)
    {
        return new IsFixedAngle2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsKinematic
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsKinematicR Reflect(IsKinematic instance)
    {
        return new IsKinematicR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsKinematic2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsKinematic2dR Reflect(IsKinematic2d instance)
    {
        return new IsKinematic2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsPointerOverUiObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsPointerOverUiObjectR Reflect(IsPointerOverUiObject instance)
    {
        return new IsPointerOverUiObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsSleeping
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsSleepingR Reflect(IsSleeping instance)
    {
        return new IsSleepingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsSleeping2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsSleeping2dR Reflect(IsSleeping2d instance)
    {
        return new IsSleeping2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTween
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenR Reflect(iTween instance)
    {
        return new iTweenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenFadeTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenFadeToR Reflect(iTweenFadeTo instance)
    {
        return new iTweenFadeToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenFSMEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenFSMEventsR Reflect(iTweenFSMEvents instance)
    {
        return new iTweenFSMEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenLookFrom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenLookFromR Reflect(iTweenLookFrom instance)
    {
        return new iTweenLookFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenLookTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenLookToR Reflect(iTweenLookTo instance)
    {
        return new iTweenLookToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenLookUpdate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenLookUpdateR Reflect(iTweenLookUpdate instance)
    {
        return new iTweenLookUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveAddR Reflect(iTweenMoveAdd instance)
    {
        return new iTweenMoveAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveBy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveByR Reflect(iTweenMoveBy instance)
    {
        return new iTweenMoveByR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveFrom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveFromR Reflect(iTweenMoveFrom instance)
    {
        return new iTweenMoveFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveToR Reflect(iTweenMoveTo instance)
    {
        return new iTweenMoveToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveUpdate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveUpdateR Reflect(iTweenMoveUpdate instance)
    {
        return new iTweenMoveUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPause
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPauseR Reflect(iTweenPause instance)
    {
        return new iTweenPauseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPunchPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPunchPositionR Reflect(iTweenPunchPosition instance)
    {
        return new iTweenPunchPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPunchRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPunchRotationR Reflect(iTweenPunchRotation instance)
    {
        return new iTweenPunchRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPunchScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPunchScaleR Reflect(iTweenPunchScale instance)
    {
        return new iTweenPunchScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenResume
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenResumeR Reflect(iTweenResume instance)
    {
        return new iTweenResumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateAddR Reflect(iTweenRotateAdd instance)
    {
        return new iTweenRotateAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateBy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateByR Reflect(iTweenRotateBy instance)
    {
        return new iTweenRotateByR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateFrom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateFromR Reflect(iTweenRotateFrom instance)
    {
        return new iTweenRotateFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateToR Reflect(iTweenRotateTo instance)
    {
        return new iTweenRotateToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateUpdate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateUpdateR Reflect(iTweenRotateUpdate instance)
    {
        return new iTweenRotateUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleAddR Reflect(iTweenScaleAdd instance)
    {
        return new iTweenScaleAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleBy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleByR Reflect(iTweenScaleBy instance)
    {
        return new iTweenScaleByR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleFrom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleFromR Reflect(iTweenScaleFrom instance)
    {
        return new iTweenScaleFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleToR Reflect(iTweenScaleTo instance)
    {
        return new iTweenScaleToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleUpdate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleUpdateR Reflect(iTweenScaleUpdate instance)
    {
        return new iTweenScaleUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenShakePosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenShakePositionR Reflect(iTweenShakePosition instance)
    {
        return new iTweenShakePositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenShakeRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenShakeRotationR Reflect(iTweenShakeRotation instance)
    {
        return new iTweenShakeRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenShakeScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenShakeScaleR Reflect(iTweenShakeScale instance)
    {
        return new iTweenShakeScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenStop
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenStopR Reflect(iTweenStop instance)
    {
        return new iTweenStopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JellyEgg
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JellyEggR Reflect(JellyEgg instance)
    {
        return new JellyEggR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JournalEntryStats
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JournalEntryStatsR Reflect(JournalEntryStats instance)
    {
        return new JournalEntryStatsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JournalList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JournalListR Reflect(JournalList instance)
    {
        return new JournalListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JournalListOld
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JournalListOldR Reflect(JournalListOld instance)
    {
        return new JournalListOldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     JoytekXbox360ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JoytekXbox360ControllerMacNativeProfileR Reflect(JoytekXbox360ControllerMacNativeProfile instance)
    {
        return new JoytekXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JumpEffects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JumpEffectsR Reflect(JumpEffects instance)
    {
        return new JumpEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepFloatPositive
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepFloatPositiveR Reflect(KeepFloatPositive instance)
    {
        return new KeepFloatPositiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepInScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepInSceneR Reflect(KeepInScene instance)
    {
        return new KeepInSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepRotationR Reflect(KeepRotation instance)
    {
        return new KeepRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepWorldPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepWorldPositionR Reflect(KeepWorldPosition instance)
    {
        return new KeepWorldPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepWorldScalePositive
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepWorldScalePositiveR Reflect(KeepWorldScalePositive instance)
    {
        return new KeepWorldScalePositiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepWorldScalePositiveLate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepWorldScalePositiveLateR Reflect(KeepWorldScalePositiveLate instance)
    {
        return new KeepWorldScalePositiveLateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KerningPair
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KerningPairR Reflect(KerningPair instance)
    {
        return new KerningPairR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KerningTable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KerningTableR Reflect(KerningTable instance)
    {
        return new KerningTableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeyBindingSource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeyBindingSourceR Reflect(KeyBindingSource instance)
    {
        return new KeyBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeyBindingSourceListener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeyBindingSourceListenerR Reflect(KeyBindingSourceListener instance)
    {
        return new KeyBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeyboardButtonSkins
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeyboardButtonSkinsR Reflect(KeyboardButtonSkins instance)
    {
        return new KeyboardButtonSkinsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KillDelayedEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KillDelayedEventsR Reflect(KillDelayedEvents instance)
    {
        return new KillDelayedEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KillOnContact
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KillOnContactR Reflect(KillOnContact instance)
    {
        return new KillOnContactR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KiwitataNESWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KiwitataNESWindowsNativeProfileR Reflect(KiwitataNESWindowsNativeProfile instance)
    {
        return new KiwitataNESWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KnightHatchling
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KnightHatchlingR Reflect(KnightHatchling instance)
    {
        return new KnightHatchlingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KonamiDancePadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KonamiDancePadMacNativeProfileR Reflect(KonamiDancePadMacNativeProfile instance)
    {
        return new KonamiDancePadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LanguageGetProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LanguageGetProxyR Reflect(LanguageGetProxy instance)
    {
        return new LanguageGetProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Layer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LayerR Reflect(Layer instance)
    {
        return new LayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LayerInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LayerInfoR Reflect(LayerInfo instance)
    {
        return new LayerInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LayerSprites
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LayerSpritesR Reflect(LayerSprites instance)
    {
        return new LayerSpritesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LensCAAndDistortion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LensCAAndDistortionR Reflect(LensCAAndDistortion instance)
    {
        return new LensCAAndDistortionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LerpTk2dSpriteColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LerpTk2dSpriteColorR Reflect(LerpTk2dSpriteColor instance)
    {
        return new LerpTk2dSpriteColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LevelUpBlackHawkWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LevelUpBlackHawkWindowsUnityProfileR Reflect(LevelUpBlackHawkWindowsUnityProfile instance)
    {
        return new LevelUpBlackHawkWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LiftChain
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LiftChainR Reflect(LiftChain instance)
    {
        return new LiftChainR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LiftPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LiftPlatformR Reflect(LiftPlatform instance)
    {
        return new LiftPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LightBlur
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LightBlurR Reflect(LightBlur instance)
    {
        return new LightBlurR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LightBlurredBackground
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LightBlurredBackgroundR Reflect(LightBlurredBackground instance)
    {
        return new LightBlurredBackgroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LimitBehaviour
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LimitBehaviourR Reflect(LimitBehaviour instance)
    {
        return new LimitBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LimitSendEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LimitSendEventsR Reflect(LimitSendEvents instance)
    {
        return new LimitSendEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LineCast2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LineCast2dR Reflect(LineCast2d instance)
    {
        return new LineCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LineOfSightDetector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LineOfSightDetectorR Reflect(LineOfSightDetector instance)
    {
        return new LineOfSightDetectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LinkRendererState
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LinkRendererStateR Reflect(LinkRendererState instance)
    {
        return new LinkRendererStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForAttack
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForAttackR Reflect(ListenForAttack instance)
    {
        return new ListenForAttackR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForBackdash
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForBackdashR Reflect(ListenForBackdash instance)
    {
        return new ListenForBackdashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForCast
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForCastR Reflect(ListenForCast instance)
    {
        return new ListenForCastR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForDash
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForDashR Reflect(ListenForDash instance)
    {
        return new ListenForDashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForDownR Reflect(ListenForDown instance)
    {
        return new ListenForDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForDreamNail
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForDreamNailR Reflect(ListenForDreamNail instance)
    {
        return new ListenForDreamNailR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForInventory
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForInventoryR Reflect(ListenForInventory instance)
    {
        return new ListenForInventoryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForJump
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForJumpR Reflect(ListenForJump instance)
    {
        return new ListenForJumpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForLeft
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForLeftR Reflect(ListenForLeft instance)
    {
        return new ListenForLeftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForMenuActions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForMenuActionsR Reflect(ListenForMenuActions instance)
    {
        return new ListenForMenuActionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForMenuCancel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForMenuCancelR Reflect(ListenForMenuCancel instance)
    {
        return new ListenForMenuCancelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForMenuSubmit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForMenuSubmitR Reflect(ListenForMenuSubmit instance)
    {
        return new ListenForMenuSubmitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForPaneLeft
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForPaneLeftR Reflect(ListenForPaneLeft instance)
    {
        return new ListenForPaneLeftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForPaneRight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForPaneRightR Reflect(ListenForPaneRight instance)
    {
        return new ListenForPaneRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForQuickCast
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForQuickCastR Reflect(ListenForQuickCast instance)
    {
        return new ListenForQuickCastR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForQuickMap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForQuickMapR Reflect(ListenForQuickMap instance)
    {
        return new ListenForQuickMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForRight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForRightR Reflect(ListenForRight instance)
    {
        return new ListenForRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForRsDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForRsDownR Reflect(ListenForRsDown instance)
    {
        return new ListenForRsDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForRsUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForRsUpR Reflect(ListenForRsUp instance)
    {
        return new ListenForRsUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForSuperdash
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForSuperdashR Reflect(ListenForSuperdash instance)
    {
        return new ListenForSuperdashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForUpR Reflect(ListenForUp instance)
    {
        return new ListenForUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadingCanvas
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadingCanvasR Reflect(LoadingCanvas instance)
    {
        return new LoadingCanvasR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadingPulse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadingPulseR Reflect(LoadingPulse instance)
    {
        return new LoadingPulseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadingSpinner
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadingSpinnerR Reflect(LoadingSpinner instance)
    {
        return new LoadingSpinnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadLevel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadLevelR Reflect(LoadLevel instance)
    {
        return new LoadLevelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadLevelNum
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadLevelNumR Reflect(LoadLevelNum instance)
    {
        return new LoadLevelNumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocaliseSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocaliseSpriteR Reflect(LocaliseSprite instance)
    {
        return new LocaliseSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocalizationSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocalizationSettingsR Reflect(LocalizationSettings instance)
    {
        return new LocalizationSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocalizedAsset
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocalizedAssetR Reflect(LocalizedAsset instance)
    {
        return new LocalizedAssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocalizedTextMesh
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocalizedTextMeshR Reflect(LocalizedTextMesh instance)
    {
        return new LocalizedTextMeshR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Logger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoggerR Reflect(Logger instance)
    {
        return new LoggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechChillStreamControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechChillStreamControllerMacNativeProfileR Reflect(
        LogitechChillStreamControllerMacNativeProfile instance)
    {
        return new LogitechChillStreamControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechControllerMacNativeProfileR Reflect(LogitechControllerMacNativeProfile instance)
    {
        return new LogitechControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechDriveFXRacingWheelMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechDriveFXRacingWheelMacNativeProfileR Reflect(
        LogitechDriveFXRacingWheelMacNativeProfile instance)
    {
        return new LogitechDriveFXRacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF310ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ControllerMacNativeProfileR Reflect(LogitechF310ControllerMacNativeProfile instance)
    {
        return new LogitechF310ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310LinuxUnityProfileR Reflect(LogitechF310LinuxUnityProfile instance)
    {
        return new LogitechF310LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeDMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeDMacNativeProfileR Reflect(LogitechF310ModeDMacNativeProfile instance)
    {
        return new LogitechF310ModeDMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeDMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeDMacUnityProfileR Reflect(LogitechF310ModeDMacUnityProfile instance)
    {
        return new LogitechF310ModeDMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF310ModeDWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeDWindowsNativeProfileR Reflect(LogitechF310ModeDWindowsNativeProfile instance)
    {
        return new LogitechF310ModeDWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeDWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeDWindowsUnityProfileR Reflect(LogitechF310ModeDWindowsUnityProfile instance)
    {
        return new LogitechF310ModeDWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeXMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeXMacUnityProfileR Reflect(LogitechF310ModeXMacUnityProfile instance)
    {
        return new LogitechF310ModeXMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF310ModeXWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeXWindowsNativeProfileR Reflect(LogitechF310ModeXWindowsNativeProfile instance)
    {
        return new LogitechF310ModeXWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeXWindowsUnityProfileR Reflect(LogitechF310ModeXWindowsUnityProfile instance)
    {
        return new LogitechF310ModeXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF510ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ControllerMacNativeProfileR Reflect(LogitechF510ControllerMacNativeProfile instance)
    {
        return new LogitechF510ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510LinuxUnityProfileR Reflect(LogitechF510LinuxUnityProfile instance)
    {
        return new LogitechF510LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeDMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeDMacNativeProfileR Reflect(LogitechF510ModeDMacNativeProfile instance)
    {
        return new LogitechF510ModeDMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeDMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeDMacUnityProfileR Reflect(LogitechF510ModeDMacUnityProfile instance)
    {
        return new LogitechF510ModeDMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF510ModeDWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeDWindowsNativeProfileR Reflect(LogitechF510ModeDWindowsNativeProfile instance)
    {
        return new LogitechF510ModeDWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeDWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeDWindowsUnityProfileR Reflect(LogitechF510ModeDWindowsUnityProfile instance)
    {
        return new LogitechF510ModeDWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeXMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeXMacUnityProfileR Reflect(LogitechF510ModeXMacUnityProfile instance)
    {
        return new LogitechF510ModeXMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF510ModeXWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeXWindowsNativeProfileR Reflect(LogitechF510ModeXWindowsNativeProfile instance)
    {
        return new LogitechF510ModeXWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeXWindowsUnityProfileR Reflect(LogitechF510ModeXWindowsUnityProfile instance)
    {
        return new LogitechF510ModeXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF710ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ControllerMacNativeProfileR Reflect(LogitechF710ControllerMacNativeProfile instance)
    {
        return new LogitechF710ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710LinuxUnityProfileR Reflect(LogitechF710LinuxUnityProfile instance)
    {
        return new LogitechF710LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710MacUnityProfileR Reflect(LogitechF710MacUnityProfile instance)
    {
        return new LogitechF710MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710ModeDMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeDMacNativeProfileR Reflect(LogitechF710ModeDMacNativeProfile instance)
    {
        return new LogitechF710ModeDMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF710ModeDWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeDWindowsNativeProfileR Reflect(LogitechF710ModeDWindowsNativeProfile instance)
    {
        return new LogitechF710ModeDWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710ModeDWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeDWindowsUnityProfileR Reflect(LogitechF710ModeDWindowsUnityProfile instance)
    {
        return new LogitechF710ModeDWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF710ModeXWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeXWindowsNativeProfileR Reflect(LogitechF710ModeXWindowsNativeProfile instance)
    {
        return new LogitechF710ModeXWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710ModeXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeXWindowsUnityProfileR Reflect(LogitechF710ModeXWindowsUnityProfile instance)
    {
        return new LogitechF710ModeXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechG920RacingWheelMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechG920RacingWheelMacNativeProfileR Reflect(LogitechG920RacingWheelMacNativeProfile instance)
    {
        return new LogitechG920RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechModeDAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechModeDAmazonUnityProfileR Reflect(LogitechModeDAmazonUnityProfile instance)
    {
        return new LogitechModeDAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechModeXAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechModeXAmazonUnityProfileR Reflect(LogitechModeXAmazonUnityProfile instance)
    {
        return new LogitechModeXAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechThunderpadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechThunderpadMacNativeProfileR Reflect(LogitechThunderpadMacNativeProfile instance)
    {
        return new LogitechThunderpadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechWingManWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechWingManWindowsUnityProfileR Reflect(LogitechWingManWindowsUnityProfile instance)
    {
        return new LogitechWingManWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogoLanguage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogoLanguageR Reflect(LogoLanguage instance)
    {
        return new LogoLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAnimNPC
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAnimNPCR Reflect(LookAnimNPC instance)
    {
        return new LookAnimNPCR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAtR Reflect(LookAt instance)
    {
        return new LookAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAt2dR Reflect(LookAt2d instance)
    {
        return new LookAt2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt2dGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAt2dGameObjectR Reflect(LookAt2dGameObject instance)
    {
        return new LookAt2dGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt2dGameObjectSmooth
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAt2dGameObjectSmoothR Reflect(LookAt2dGameObjectSmooth instance)
    {
        return new LookAt2dGameObjectSmoothR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzArcadeStickMacNativeProfileR Reflect(MadCatzArcadeStickMacNativeProfile instance)
    {
        return new MadCatzArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzBeatPadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzBeatPadMacNativeProfileR Reflect(MadCatzBeatPadMacNativeProfile instance)
    {
        return new MadCatzBeatPadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzBrawlStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzBrawlStickMacNativeProfileR Reflect(MadCatzBrawlStickMacNativeProfile instance)
    {
        return new MadCatzBrawlStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzCODControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzCODControllerMacNativeProfileR Reflect(MadCatzCODControllerMacNativeProfile instance)
    {
        return new MadCatzCODControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzControllerMacNativeProfileR Reflect(MadCatzControllerMacNativeProfile instance)
    {
        return new MadCatzControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzCTRLRAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzCTRLRAmazonUnityProfileR Reflect(MadCatzCTRLRAmazonUnityProfile instance)
    {
        return new MadCatzCTRLRAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzCTRLRAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzCTRLRAndroidUnityProfileR Reflect(MadCatzCTRLRAndroidUnityProfile instance)
    {
        return new MadCatzCTRLRAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzFightPadControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFightPadControllerMacNativeProfileR
        Reflect(MadCatzFightPadControllerMacNativeProfile instance)
    {
        return new MadCatzFightPadControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzFightPadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFightPadMacNativeProfileR Reflect(MadCatzFightPadMacNativeProfile instance)
    {
        return new MadCatzFightPadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzFightStickTE2MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFightStickTE2MacNativeProfileR Reflect(MadCatzFightStickTE2MacNativeProfile instance)
    {
        return new MadCatzFightStickTE2MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzFightStickTESPlusMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFightStickTESPlusMacNativeProfileR
        Reflect(MadCatzFightStickTESPlusMacNativeProfile instance)
    {
        return new MadCatzFightStickTESPlusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzFPSProMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFPSProMacNativeProfileR Reflect(MadCatzFPSProMacNativeProfile instance)
    {
        return new MadCatzFPSProMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzGhostReconFightingStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzGhostReconFightingStickMacNativeProfileR Reflect(
        MadCatzGhostReconFightingStickMacNativeProfile instance)
    {
        return new MadCatzGhostReconFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzInnoControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzInnoControllerMacNativeProfileR Reflect(MadCatzInnoControllerMacNativeProfile instance)
    {
        return new MadCatzInnoControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzMC2ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMC2ControllerMacNativeProfileR Reflect(MadCatzMC2ControllerMacNativeProfile instance)
    {
        return new MadCatzMC2ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMC2RacingWheelMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMC2RacingWheelMacNativeProfileR Reflect(MadCatzMC2RacingWheelMacNativeProfile instance)
    {
        return new MadCatzMC2RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMicroConControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMicroConControllerMacNativeProfileR
        Reflect(MadCatzMicroConControllerMacNativeProfile instance)
    {
        return new MadCatzMicroConControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMicroControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMicroControllerMacNativeProfileR Reflect(MadCatzMicroControllerMacNativeProfile instance)
    {
        return new MadCatzMicroControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzMicroCTRLRAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMicroCTRLRAmazonUnityProfileR Reflect(MadCatzMicroCTRLRAmazonUnityProfile instance)
    {
        return new MadCatzMicroCTRLRAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMLGFightStickTEMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMLGFightStickTEMacNativeProfileR Reflect(MadCatzMLGFightStickTEMacNativeProfile instance)
    {
        return new MadCatzMLGFightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzNeoFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzNeoFightStickMacNativeProfileR Reflect(MadCatzNeoFightStickMacNativeProfile instance)
    {
        return new MadCatzNeoFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzPortableDrumMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzPortableDrumMacNativeProfileR Reflect(MadCatzPortableDrumMacNativeProfile instance)
    {
        return new MadCatzPortableDrumMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzProControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzProControllerMacNativeProfileR Reflect(MadCatzProControllerMacNativeProfile instance)
    {
        return new MadCatzProControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzSaitekAV8R02MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSaitekAV8R02MacNativeProfileR Reflect(MadCatzSaitekAV8R02MacNativeProfile instance)
    {
        return new MadCatzSaitekAV8R02MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSF4FightStickRound2TEMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSF4FightStickRound2TEMacNativeProfileR Reflect(
        MadCatzSF4FightStickRound2TEMacNativeProfile instance)
    {
        return new MadCatzSF4FightStickRound2TEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSF4FightStickSEMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSF4FightStickSEMacNativeProfileR Reflect(MadCatzSF4FightStickSEMacNativeProfile instance)
    {
        return new MadCatzSF4FightStickSEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSF4FightStickTEMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSF4FightStickTEMacNativeProfileR Reflect(MadCatzSF4FightStickTEMacNativeProfile instance)
    {
        return new MadCatzSF4FightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSoulCaliberFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSoulCaliberFightStickMacNativeProfileR Reflect(
        MadCatzSoulCaliberFightStickMacNativeProfile instance)
    {
        return new MadCatzSoulCaliberFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSSF4ChunLiFightStickTEMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSSF4ChunLiFightStickTEMacNativeProfileR Reflect(
        MadCatzSSF4ChunLiFightStickTEMacNativeProfile instance)
    {
        return new MadCatzSSF4ChunLiFightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSSF4FightStickTEMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSSF4FightStickTEMacNativeProfileR Reflect(MadCatzSSF4FightStickTEMacNativeProfile instance)
    {
        return new MadCatzSSF4FightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MainMenuOptions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MainMenuOptionsR Reflect(MainMenuOptions instance)
    {
        return new MainMenuOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MakeEnemyDreamnailReactionReady
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MakeEnemyDreamnailReactionReadyR Reflect(MakeEnemyDreamnailReactionReady instance)
    {
        return new MakeEnemyDreamnailReactionReadyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MakeSkippable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MakeSkippableR Reflect(MakeSkippable instance)
    {
        return new MakeSkippableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapAreas
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapAreasR Reflect(MapAreas instance)
    {
        return new MapAreasR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapMarkerButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapMarkerButtonR Reflect(MapMarkerButton instance)
    {
        return new MapMarkerButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapMarkerMenu
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapMarkerMenuR Reflect(MapMarkerMenu instance)
    {
        return new MapMarkerMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapNextAreaDisplay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapNextAreaDisplayR Reflect(MapNextAreaDisplay instance)
    {
        return new MapNextAreaDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MappableControllerButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MappableControllerButtonR Reflect(MappableControllerButton instance)
    {
        return new MappableControllerButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MappableKey
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MappableKeyR Reflect(MappableKey instance)
    {
        return new MappableKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapStartPan
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapStartPanR Reflect(MapStartPan instance)
    {
        return new MapStartPanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapStopPan
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapStopPanR Reflect(MapStopPan instance)
    {
        return new MapStopPanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Mask
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MaskR Reflect(Mask instance)
    {
        return new MaskR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MaskByYPos
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MaskByYPosR Reflect(MaskByYPos instance)
    {
        return new MaskByYPosR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MatCatzControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MatCatzControllerMacNativeProfileR Reflect(MatCatzControllerMacNativeProfile instance)
    {
        return new MatCatzControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MatchMasterTimeSample
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MatchMasterTimeSampleR Reflect(MatchMasterTimeSample instance)
    {
        return new MatchMasterTimeSampleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MaterialReferenceManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MaterialReferenceManagerR Reflect(MaterialReferenceManager instance)
    {
        return new MaterialReferenceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MaxFireBlaze5WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MaxFireBlaze5WindowsUnityProfileR Reflect(MaxFireBlaze5WindowsUnityProfile instance)
    {
        return new MaxFireBlaze5WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MayflashMagicNSMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MayflashMagicNSMacNativeProfileR Reflect(MayflashMagicNSMacNativeProfile instance)
    {
        return new MayflashMagicNSMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of McbazelAdapterMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static McbazelAdapterMacNativeProfileR Reflect(McbazelAdapterMacNativeProfile instance)
    {
        return new McbazelAdapterMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MegaJellyZap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MegaJellyZapR Reflect(MegaJellyZap instance)
    {
        return new MegaJellyZapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAchievement
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAchievementR Reflect(MenuAchievement instance)
    {
        return new MenuAchievementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAchievementsList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAchievementsListR Reflect(MenuAchievementsList instance)
    {
        return new MenuAchievementsListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAudioController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAudioControllerR Reflect(MenuAudioController instance)
    {
        return new MenuAudioControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAudioSlider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAudioSliderR Reflect(MenuAudioSlider instance)
    {
        return new MenuAudioSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuBuilder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuBuilderR Reflect(MenuBuilder instance)
    {
        return new MenuBuilderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonR Reflect(MenuButton instance)
    {
        return new MenuButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonAchievementListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonAchievementListConditionR Reflect(MenuButtonAchievementListCondition instance)
    {
        return new MenuButtonAchievementListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonChineseListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonChineseListConditionR Reflect(MenuButtonChineseListCondition instance)
    {
        return new MenuButtonChineseListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonControllerListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonControllerListConditionR Reflect(MenuButtonControllerListCondition instance)
    {
        return new MenuButtonControllerListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonGraphicsListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonGraphicsListConditionR Reflect(MenuButtonGraphicsListCondition instance)
    {
        return new MenuButtonGraphicsListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonIcon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonIconR Reflect(MenuButtonIcon instance)
    {
        return new MenuButtonIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonKeyboardListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonKeyboardListConditionR Reflect(MenuButtonKeyboardListCondition instance)
    {
        return new MenuButtonKeyboardListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonListR Reflect(MenuButtonList instance)
    {
        return new MenuButtonListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonListPlatformCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonListPlatformConditionR Reflect(MenuButtonListPlatformCondition instance)
    {
        return new MenuButtonListPlatformConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonNativeInputListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonNativeInputListConditionR Reflect(MenuButtonNativeInputListCondition instance)
    {
        return new MenuButtonNativeInputListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonQuitListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonQuitListConditionR Reflect(MenuButtonQuitListCondition instance)
    {
        return new MenuButtonQuitListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonSwitchUserListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonSwitchUserListConditionR Reflect(MenuButtonSwitchUserListCondition instance)
    {
        return new MenuButtonSwitchUserListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuDisplaySetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuDisplaySettingR Reflect(MenuDisplaySetting instance)
    {
        return new MenuDisplaySettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuFrameCapSetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuFrameCapSettingR Reflect(MenuFrameCapSetting instance)
    {
        return new MenuFrameCapSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuLanguageSetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuLanguageSettingR Reflect(MenuLanguageSetting instance)
    {
        return new MenuLanguageSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuOptionHorizontal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuOptionHorizontalR Reflect(MenuOptionHorizontal instance)
    {
        return new MenuOptionHorizontalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuPreventDeselect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuPreventDeselectR Reflect(MenuPreventDeselect instance)
    {
        return new MenuPreventDeselectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuResolutionSetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuResolutionSettingR Reflect(MenuResolutionSetting instance)
    {
        return new MenuResolutionSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuResources
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuResourcesR Reflect(MenuResources instance)
    {
        return new MenuResourcesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuScreen
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuScreenR Reflect(MenuScreen instance)
    {
        return new MenuScreenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuScroller
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuScrollerR Reflect(MenuScroller instance)
    {
        return new MenuScrollerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuSelectable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuSelectableR Reflect(MenuSelectable instance)
    {
        return new MenuSelectableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuSetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuSettingR Reflect(MenuSetting instance)
    {
        return new MenuSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyles
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStylesR Reflect(MenuStyles instance)
    {
        return new MenuStylesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleSetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleSettingR Reflect(MenuStyleSetting instance)
    {
        return new MenuStyleSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleTitle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleTitleR Reflect(MenuStyleTitle instance)
    {
        return new MenuStyleTitleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleUnlock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleUnlockR Reflect(MenuStyleUnlock instance)
    {
        return new MenuStyleUnlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleUnlockAction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleUnlockActionR Reflect(MenuStyleUnlockAction instance)
    {
        return new MenuStyleUnlockActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MeshSortingOrder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MeshSortingOrderR Reflect(MeshSortingOrder instance)
    {
        return new MeshSortingOrderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftAdaptiveControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MicrosoftAdaptiveControllerMacNativeProfileR Reflect(
        MicrosoftAdaptiveControllerMacNativeProfile instance)
    {
        return new MicrosoftAdaptiveControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXbox360ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MicrosoftXbox360ControllerMacNativeProfileR Reflect(
        MicrosoftXbox360ControllerMacNativeProfile instance)
    {
        return new MicrosoftXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXboxControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MicrosoftXboxControllerMacNativeProfileR Reflect(MicrosoftXboxControllerMacNativeProfile instance)
    {
        return new MicrosoftXboxControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MicrosoftXboxOneControllerMacNativeProfileR Reflect(
        MicrosoftXboxOneControllerMacNativeProfile instance)
    {
        return new MicrosoftXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXboxOneEliteControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MicrosoftXboxOneEliteControllerMacNativeProfileR Reflect(
        MicrosoftXboxOneEliteControllerMacNativeProfile instance)
    {
        return new MicrosoftXboxOneEliteControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MKKlassikFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MKKlassikFightStickMacNativeProfileR Reflect(MKKlassikFightStickMacNativeProfile instance)
    {
        return new MKKlassikFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MLGControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MLGControllerMacNativeProfileR Reflect(MLGControllerMacNativeProfile instance)
    {
        return new MLGControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModalDialog
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModalDialogR Reflect(ModalDialog instance)
    {
        return new ModalDialogR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModHooks
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModHooksR Reflect(ModHooks instance)
    {
        return new ModHooksR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModHooksGlobalSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModHooksGlobalSettingsR Reflect(ModHooksGlobalSettings instance)
    {
        return new ModHooksGlobalSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModVersionDraw
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModVersionDrawR Reflect(ModVersionDraw instance)
    {
        return new ModVersionDrawR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaHeroPowerAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaHeroPowerAndroidUnityProfileR Reflect(MogaHeroPowerAndroidUnityProfile instance)
    {
        return new MogaHeroPowerAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProAndroidUnityProfileR Reflect(MogaProAndroidUnityProfile instance)
    {
        return new MogaProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProLinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProLinuxUnityProfileR Reflect(MogaProLinuxUnityProfile instance)
    {
        return new MogaProLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProMacUnityProfileR Reflect(MogaProMacUnityProfile instance)
    {
        return new MogaProMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProPowerAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProPowerAndroidUnityProfileR Reflect(MogaProPowerAndroidUnityProfile instance)
    {
        return new MogaProPowerAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProWindowsUnityProfileR Reflect(MogaProWindowsUnityProfile instance)
    {
        return new MogaProWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MonoModAdded
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MonoModAddedR Reflect(MonoModAdded instance)
    {
        return new MonoModAddedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MonoModOriginal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MonoModOriginalR Reflect(MonoModOriginal instance)
    {
        return new MonoModOriginalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MonoModOriginalName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MonoModOriginalNameR Reflect(MonoModOriginalName instance)
    {
        return new MonoModOriginalNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseBindingSource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseBindingSourceR Reflect(MouseBindingSource instance)
    {
        return new MouseBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseBindingSourceListener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseBindingSourceListenerR Reflect(MouseBindingSourceListener instance)
    {
        return new MouseBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseLook
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseLookR Reflect(MouseLook instance)
    {
        return new MouseLookR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseLook2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseLook2R Reflect(MouseLook2 instance)
    {
        return new MouseLook2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePick
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePickR Reflect(MousePick instance)
    {
        return new MousePickR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePick2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePick2dR Reflect(MousePick2d instance)
    {
        return new MousePick2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePick2dEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePick2dEventR Reflect(MousePick2dEvent instance)
    {
        return new MousePick2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePickEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePickEventR Reflect(MousePickEvent instance)
    {
        return new MousePickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MoveLiftChain
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MoveLiftChainR Reflect(MoveLiftChain instance)
    {
        return new MoveLiftChainR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MoveObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MoveObjectR Reflect(MoveObject instance)
    {
        return new MoveObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MoveTowards
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MoveTowardsR Reflect(MoveTowards instance)
    {
        return new MoveTowardsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MusicCue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MusicCueR Reflect(MusicCue instance)
    {
        return new MusicCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MusicRegion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MusicRegionR Reflect(MusicRegion instance)
    {
        return new MusicRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MuteAudioChannel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MuteAudioChannelR Reflect(MuteAudioChannel instance)
    {
        return new MuteAudioChannelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MVCTEStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MVCTEStickMacNativeProfileR Reflect(MVCTEStickMacNativeProfile instance)
    {
        return new MVCTEStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MyGuid
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MyGuidR Reflect(MyGuid instance)
    {
        return new MyGuidR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NaconGC100XFControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NaconGC100XFControllerMacNativeProfileR Reflect(NaconGC100XFControllerMacNativeProfile instance)
    {
        return new NaconGC100XFControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NailSlash
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NailSlashR Reflect(NailSlash instance)
    {
        return new NailSlashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NatecGenesisP44WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NatecGenesisP44WindowsUnityProfileR Reflect(NatecGenesisP44WindowsUnityProfile instance)
    {
        return new NatecGenesisP44WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDevice
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceR Reflect(NativeInputDevice instance)
    {
        return new NativeInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDeviceManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceManagerR Reflect(NativeInputDeviceManager instance)
    {
        return new NativeInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDeviceProfileAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceProfileAttributeR Reflect(NativeInputDeviceProfileAttribute instance)
    {
        return new NativeInputDeviceProfileAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDeviceProfileList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceProfileListR Reflect(NativeInputDeviceProfileList instance)
    {
        return new NativeInputDeviceProfileListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputModuleManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputModuleManagerR Reflect(NativeInputModuleManager instance)
    {
        return new NativeInputModuleManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NavMeshAgentAnimatorSynchronizer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NavMeshAgentAnimatorSynchronizerR Reflect(NavMeshAgentAnimatorSynchronizer instance)
    {
        return new NavMeshAgentAnimatorSynchronizerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NewBehaviourScript
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NewBehaviourScriptR Reflect(NewBehaviourScript instance)
    {
        return new NewBehaviourScriptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NextFrameEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NextFrameEventR Reflect(NextFrameEvent instance)
    {
        return new NextFrameEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NextSceneOnInput
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NextSceneOnInputR Reflect(NextSceneOnInput instance)
    {
        return new NextSceneOnInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerAndroidUnityProfileR Reflect(NexusPlayerAndroidUnityProfile instance)
    {
        return new NexusPlayerAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerMacUnityProfileR Reflect(NexusPlayerMacUnityProfile instance)
    {
        return new NexusPlayerMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerRemoteAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerRemoteAndroidUnityProfileR Reflect(NexusPlayerRemoteAndroidUnityProfile instance)
    {
        return new NexusPlayerRemoteAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerWindowsUnityProfileR Reflect(NexusPlayerWindowsUnityProfile instance)
    {
        return new NexusPlayerWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NintendoSwitchProMacChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NintendoSwitchProMacChromeUnityProfileR Reflect(NintendoSwitchProMacChromeUnityProfile instance)
    {
        return new NintendoSwitchProMacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NintendoSwitchProMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NintendoSwitchProMacNativeProfileR Reflect(NintendoSwitchProMacNativeProfile instance)
    {
        return new NintendoSwitchProMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NintendoSwitchProWindowsChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NintendoSwitchProWindowsChromeUnityProfileR Reflect(
        NintendoSwitchProWindowsChromeUnityProfile instance)
    {
        return new NintendoSwitchProWindowsChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NintendoSwitchProWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NintendoSwitchProWindowsNativeProfileR Reflect(NintendoSwitchProWindowsNativeProfile instance)
    {
        return new NintendoSwitchProWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NoHardLanding
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NoHardLandingR Reflect(NoHardLanding instance)
    {
        return new NoHardLandingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NonBouncer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NonBouncerR Reflect(NonBouncer instance)
    {
        return new NonBouncerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NonSlider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NonSliderR Reflect(NonSlider instance)
    {
        return new NonSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NonThunker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NonThunkerR Reflect(NonThunker instance)
    {
        return new NonThunkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShield2016AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShield2016AndroidUnityProfileR Reflect(NVidiaShield2016AndroidUnityProfile instance)
    {
        return new NVidiaShield2016AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShield2017AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShield2017AndroidUnityProfileR Reflect(NVidiaShield2017AndroidUnityProfile instance)
    {
        return new NVidiaShield2017AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NVidiaShield2017NVidiaShieldUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShield2017NVidiaShieldUnityProfileR
        Reflect(NVidiaShield2017NVidiaShieldUnityProfile instance)
    {
        return new NVidiaShield2017NVidiaShieldUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NvidiaShieldRemoteAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NvidiaShieldRemoteAndroidUnityProfileR Reflect(NvidiaShieldRemoteAndroidUnityProfile instance)
    {
        return new NvidiaShieldRemoteAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindows10UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindows10UnityProfileR Reflect(NVidiaShieldWindows10UnityProfile instance)
    {
        return new NVidiaShieldWindows10UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindows81UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindows81UnityProfileR Reflect(NVidiaShieldWindows81UnityProfile instance)
    {
        return new NVidiaShieldWindows81UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindowsNativeProfileR Reflect(NVidiaShieldWindowsNativeProfile instance)
    {
        return new NVidiaShieldWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindowsUnityProfileR Reflect(NVidiaShieldWindowsUnityProfile instance)
    {
        return new NVidiaShieldWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NykoPlayPadProAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NykoPlayPadProAmazonUnityProfileR Reflect(NykoPlayPadProAmazonUnityProfile instance)
    {
        return new NykoPlayPadProAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectBounce
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectBounceR Reflect(ObjectBounce instance)
    {
        return new ObjectBounceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectCompareR Reflect(ObjectCompare instance)
    {
        return new ObjectCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectJitter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectJitterR Reflect(ObjectJitter instance)
    {
        return new ObjectJitterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectJitterLocal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectJitterLocalR Reflect(ObjectJitterLocal instance)
    {
        return new ObjectJitterLocalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectPool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectPoolR Reflect(ObjectPool instance)
    {
        return new ObjectPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OneAxisInputControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OneAxisInputControlR Reflect(OneAxisInputControl instance)
    {
        return new OneAxisInputControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OnEnableEnemyHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OnEnableEnemyHandlerR Reflect(OnEnableEnemyHandler instance)
    {
        return new OnEnableEnemyHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OnReceiveDeathEventHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OnReceiveDeathEventHandlerR Reflect(OnReceiveDeathEventHandler instance)
    {
        return new OnReceiveDeathEventHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OnScreenDebugInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OnScreenDebugInfoR Reflect(OnScreenDebugInfo instance)
    {
        return new OnScreenDebugInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OpeningGameplayCredits
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OpeningGameplayCreditsR Reflect(OpeningGameplayCredits instance)
    {
        return new OpeningGameplayCreditsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OpeningSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OpeningSequenceR Reflect(OpeningSequence instance)
    {
        return new OpeningSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OpenMarkerMenu
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OpenMarkerMenuR Reflect(OpenMarkerMenu instance)
    {
        return new OpenMarkerMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OptionalTypeHasNoValueException
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OptionalTypeHasNoValueExceptionR Reflect(OptionalTypeHasNoValueException instance)
    {
        return new OptionalTypeHasNoValueExceptionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaAmazonUnityProfileR Reflect(OuyaAmazonUnityProfile instance)
    {
        return new OuyaAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaEverywhereDevice
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaEverywhereDeviceR Reflect(OuyaEverywhereDevice instance)
    {
        return new OuyaEverywhereDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaEverywhereDeviceManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaEverywhereDeviceManagerR Reflect(OuyaEverywhereDeviceManager instance)
    {
        return new OuyaEverywhereDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaLinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaLinuxUnityProfileR Reflect(OuyaLinuxUnityProfile instance)
    {
        return new OuyaLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OUYAWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OUYAWindowsNativeProfileR Reflect(OUYAWindowsNativeProfile instance)
    {
        return new OUYAWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaWindowsUnityProfileR Reflect(OuyaWindowsUnityProfile instance)
    {
        return new OuyaWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OverscanSetting
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OverscanSettingR Reflect(OverscanSetting instance)
    {
        return new OverscanSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Owner
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OwnerR Reflect(Owner instance)
    {
        return new OwnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PaintBullet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PaintBulletR Reflect(PaintBullet instance)
    {
        return new PaintBulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PaintSplat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PaintSplatR Reflect(PaintSplat instance)
    {
        return new PaintSplatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParallaxSorter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParallaxSorterR Reflect(ParallaxSorter instance)
    {
        return new ParallaxSorterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemAutoDestroy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemAutoDestroyR Reflect(ParticleSystemAutoDestroy instance)
    {
        return new ParticleSystemAutoDestroyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemAutoDisable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemAutoDisableR Reflect(ParticleSystemAutoDisable instance)
    {
        return new ParticleSystemAutoDisableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemAutoRecycle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemAutoRecycleR Reflect(ParticleSystemAutoRecycle instance)
    {
        return new ParticleSystemAutoRecycleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemCollisionLagFix
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemCollisionLagFixR Reflect(ParticleSystemCollisionLagFix instance)
    {
        return new ParticleSystemCollisionLagFixR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PauseMenuButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PauseMenuButtonR Reflect(PauseMenuButton instance)
    {
        return new PauseMenuButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PCTWINSHOCKWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PCTWINSHOCKWindowsNativeProfileR Reflect(PCTWINSHOCKWindowsNativeProfile instance)
    {
        return new PCTWINSHOCKWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPAfterglowControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPAfterglowControllerMacNativeProfileR Reflect(PDPAfterglowControllerMacNativeProfile instance)
    {
        return new PDPAfterglowControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPAfterglowPrismaticControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPAfterglowPrismaticControllerMacNativeProfileR Reflect(
        PDPAfterglowPrismaticControllerMacNativeProfile instance)
    {
        return new PDPAfterglowPrismaticControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPBattlefieldXBoxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPBattlefieldXBoxOneControllerMacNativeProfileR Reflect(
        PDPBattlefieldXBoxOneControllerMacNativeProfile instance)
    {
        return new PDPBattlefieldXBoxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPMarvelControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPMarvelControllerMacNativeProfileR Reflect(PDPMarvelControllerMacNativeProfile instance)
    {
        return new PDPMarvelControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPMetallicsLEControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPMetallicsLEControllerMacNativeProfileR
        Reflect(PDPMetallicsLEControllerMacNativeProfile instance)
    {
        return new PDPMetallicsLEControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPTitanfall2XboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPTitanfall2XboxOneControllerMacNativeProfileR Reflect(
        PDPTitanfall2XboxOneControllerMacNativeProfile instance)
    {
        return new PDPTitanfall2XboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPTronControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPTronControllerMacNativeProfileR Reflect(PDPTronControllerMacNativeProfile instance)
    {
        return new PDPTronControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPVersusControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPVersusControllerMacNativeProfileR Reflect(PDPVersusControllerMacNativeProfile instance)
    {
        return new PDPVersusControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPXbox360ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPXbox360ControllerMacNativeProfileR Reflect(PDPXbox360ControllerMacNativeProfile instance)
    {
        return new PDPXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPXboxOneArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPXboxOneArcadeStickMacNativeProfileR Reflect(PDPXboxOneArcadeStickMacNativeProfile instance)
    {
        return new PDPXboxOneArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPXboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPXboxOneControllerMacNativeProfileR Reflect(PDPXboxOneControllerMacNativeProfile instance)
    {
        return new PDPXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PerBuildTypeOnEnableResponse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PerBuildTypeOnEnableResponseR Reflect(PerBuildTypeOnEnableResponse instance)
    {
        return new PerBuildTypeOnEnableResponseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PerformanceHUD
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PerformanceHUDR Reflect(PerformanceHUD instance)
    {
        return new PerformanceHUDR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PermadeathUnlock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PermadeathUnlockR Reflect(PermadeathUnlock instance)
    {
        return new PermadeathUnlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PerSecond
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PerSecondR Reflect(PerSecond instance)
    {
        return new PerSecondR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentBoolData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentBoolDataR Reflect(PersistentBoolData instance)
    {
        return new PersistentBoolDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentBoolItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentBoolItemR Reflect(PersistentBoolItem instance)
    {
        return new PersistentBoolItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentIntData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentIntDataR Reflect(PersistentIntData instance)
    {
        return new PersistentIntDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentIntItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentIntItemR Reflect(PersistentIntItem instance)
    {
        return new PersistentIntItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersonalObjectPool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersonalObjectPoolR Reflect(PersonalObjectPool instance)
    {
        return new PersonalObjectPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlanarRealtimeReflection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlanarRealtimeReflectionR Reflect(PlanarRealtimeReflection instance)
    {
        return new PlanarRealtimeReflectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlatformSpecificLocalisation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlatformSpecificLocalisationR Reflect(PlatformSpecificLocalisation instance)
    {
        return new PlatformSpecificLocalisationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlatformSpecificSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlatformSpecificSpriteR Reflect(PlatformSpecificSprite instance)
    {
        return new PlatformSpecificSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlatformVibrationHelper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlatformVibrationHelperR Reflect(PlatformVibrationHelper instance)
    {
        return new PlatformVibrationHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayAnimationR Reflect(PlayAnimation instance)
    {
        return new PlayAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayAudioAndRecycle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayAudioAndRecycleR Reflect(PlayAudioAndRecycle instance)
    {
        return new PlayAudioAndRecycleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayAudioEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayAudioEventR Reflect(PlayAudioEvent instance)
    {
        return new PlayAudioEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerAchievements
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerAchievementsR Reflect(PlayerAchievements instance)
    {
        return new PlayerAchievementsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerAction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerActionR Reflect(PlayerAction instance)
    {
        return new PlayerActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerActionSetConverter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerActionSetConverterR Reflect(PlayerActionSetConverter instance)
    {
        return new PlayerActionSetConverterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataBoolAllTrue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataBoolAllTrueR Reflect(PlayerDataBoolAllTrue instance)
    {
        return new PlayerDataBoolAllTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataBoolTest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataBoolTestR Reflect(PlayerDataBoolTest instance)
    {
        return new PlayerDataBoolTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataBoolTrueAndFalse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataBoolTrueAndFalseR Reflect(PlayerDataBoolTrueAndFalse instance)
    {
        return new PlayerDataBoolTrueAndFalseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataIntAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataIntAddR Reflect(PlayerDataIntAdd instance)
    {
        return new PlayerDataIntAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerOneAxisAction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerOneAxisActionR Reflect(PlayerOneAxisAction instance)
    {
        return new PlayerOneAxisActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsDeleteAll
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsDeleteAllR Reflect(PlayerPrefsDeleteAll instance)
    {
        return new PlayerPrefsDeleteAllR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsDeleteKey
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsDeleteKeyR Reflect(PlayerPrefsDeleteKey instance)
    {
        return new PlayerPrefsDeleteKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsGetFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsGetFloatR Reflect(PlayerPrefsGetFloat instance)
    {
        return new PlayerPrefsGetFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsGetInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsGetIntR Reflect(PlayerPrefsGetInt instance)
    {
        return new PlayerPrefsGetIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsGetString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsGetStringR Reflect(PlayerPrefsGetString instance)
    {
        return new PlayerPrefsGetStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsHasKey
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsHasKeyR Reflect(PlayerPrefsHasKey instance)
    {
        return new PlayerPrefsHasKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSetFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSetFloatR Reflect(PlayerPrefsSetFloat instance)
    {
        return new PlayerPrefsSetFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSetInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSetIntR Reflect(PlayerPrefsSetInt instance)
    {
        return new PlayerPrefsSetIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSetString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSetStringR Reflect(PlayerPrefsSetString instance)
    {
        return new PlayerPrefsSetStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSharedData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSharedDataR Reflect(PlayerPrefsSharedData instance)
    {
        return new PlayerPrefsSharedDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerTwoAxisAction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerTwoAxisActionR Reflect(PlayerTwoAxisAction instance)
    {
        return new PlayerTwoAxisActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayFromRandomFrame
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayFromRandomFrameR Reflect(PlayFromRandomFrame instance)
    {
        return new PlayFromRandomFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayFromRandomFrameMecanim
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayFromRandomFrameMecanimR Reflect(PlayFromRandomFrameMecanim instance)
    {
        return new PlayFromRandomFrameMecanimR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayHitEffects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayHitEffectsR Reflect(PlayHitEffects instance)
    {
        return new PlayHitEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerAnimatorIKProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerAnimatorIKProxyR Reflect(PlayMakerAnimatorIKProxy instance)
    {
        return new PlayMakerAnimatorIKProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerAnimatorMoveProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerAnimatorMoveProxyR Reflect(PlayMakerAnimatorMoveProxy instance)
    {
        return new PlayMakerAnimatorMoveProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayMakerAnimatorStateSynchronization
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerAnimatorStateSynchronizationR Reflect(PlayMakerAnimatorStateSynchronization instance)
    {
        return new PlayMakerAnimatorStateSynchronizationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerArrayListProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerArrayListProxyR Reflect(PlayMakerArrayListProxy instance)
    {
        return new PlayMakerArrayListProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerEventR Reflect(PlayMakerEvent instance)
    {
        return new PlayMakerEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerEventTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerEventTargetR Reflect(PlayMakerEventTarget instance)
    {
        return new PlayMakerEventTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerHashTableProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerHashTableProxyR Reflect(PlayMakerHashTableProxy instance)
    {
        return new PlayMakerHashTableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayMakerUGuiCanvasRaycastFilterEventsProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiCanvasRaycastFilterEventsProxyR Reflect(
        PlayMakerUGuiCanvasRaycastFilterEventsProxy instance)
    {
        return new PlayMakerUGuiCanvasRaycastFilterEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiComponentProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiComponentProxyR Reflect(PlayMakerUGuiComponentProxy instance)
    {
        return new PlayMakerUGuiComponentProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiDragEventsProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiDragEventsProxyR Reflect(PlayMakerUGuiDragEventsProxy instance)
    {
        return new PlayMakerUGuiDragEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiDropEventsProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiDropEventsProxyR Reflect(PlayMakerUGuiDropEventsProxy instance)
    {
        return new PlayMakerUGuiDropEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiPointerEventsProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiPointerEventsProxyR Reflect(PlayMakerUGuiPointerEventsProxy instance)
    {
        return new PlayMakerUGuiPointerEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiSceneProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiSceneProxyR Reflect(PlayMakerUGuiSceneProxy instance)
    {
        return new PlayMakerUGuiSceneProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUnity2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUnity2dR Reflect(PlayMakerUnity2d instance)
    {
        return new PlayMakerUnity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUnity2DProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUnity2DProxyR Reflect(PlayMakerUnity2DProxy instance)
    {
        return new PlayMakerUnity2DProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUtils
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUtilsR Reflect(PlayMakerUtils instance)
    {
        return new PlayMakerUtilsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleEffects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleEffectsR Reflect(PlayParticleEffects instance)
    {
        return new PlayParticleEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleEmitter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleEmitterR Reflect(PlayParticleEmitter instance)
    {
        return new PlayParticleEmitterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleEmitterInState
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleEmitterInStateR Reflect(PlayParticleEmitterInState instance)
    {
        return new PlayParticleEmitterInStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleOnEntry
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleOnEntryR Reflect(PlayParticleOnEntry instance)
    {
        return new PlayParticleOnEntryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayRandomAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayRandomAnimationR Reflect(PlayRandomAnimation instance)
    {
        return new PlayRandomAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayRandomSound
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayRandomSoundR Reflect(PlayRandomSound instance)
    {
        return new PlayRandomSoundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlaySound
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlaySoundR Reflect(PlaySound instance)
    {
        return new PlaySoundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation2LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation2LinuxUnityProfileR Reflect(PlayStation2LinuxUnityProfile instance)
    {
        return new PlayStation2LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation2WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation2WindowsUnityProfileR Reflect(PlayStation2WindowsUnityProfile instance)
    {
        return new PlayStation2WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3AndroidUnityProfileR Reflect(PlayStation3AndroidUnityProfile instance)
    {
        return new PlayStation3AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3BWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3BWindowsUnityProfileR Reflect(PlayStation3BWindowsUnityProfile instance)
    {
        return new PlayStation3BWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3LinuxUnityProfileR Reflect(PlayStation3LinuxUnityProfile instance)
    {
        return new PlayStation3LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3MacNativeProfileR Reflect(PlayStation3MacNativeProfile instance)
    {
        return new PlayStation3MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3MacUnityProfileR Reflect(PlayStation3MacUnityProfile instance)
    {
        return new PlayStation3MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayStation3ShenghicWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3ShenghicWindowsUnityProfileR Reflect(PlayStation3ShenghicWindowsUnityProfile instance)
    {
        return new PlayStation3ShenghicWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3WindowsUnityProfileR Reflect(PlayStation3WindowsUnityProfile instance)
    {
        return new PlayStation3WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4AmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4AmazonUnityProfileR Reflect(PlayStation4AmazonUnityProfile instance)
    {
        return new PlayStation4AmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4AndroidUnityProfileR Reflect(PlayStation4AndroidUnityProfile instance)
    {
        return new PlayStation4AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4LinuxUnityProfileR Reflect(PlayStation4LinuxUnityProfile instance)
    {
        return new PlayStation4LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacBluetoothUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacBluetoothUnityProfileR Reflect(PlayStation4MacBluetoothUnityProfile instance)
    {
        return new PlayStation4MacBluetoothUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacChromeUnityProfileR Reflect(PlayStation4MacChromeUnityProfile instance)
    {
        return new PlayStation4MacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacFirefoxUnityProfileR Reflect(PlayStation4MacFirefoxUnityProfile instance)
    {
        return new PlayStation4MacFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacNativeProfileR Reflect(PlayStation4MacNativeProfile instance)
    {
        return new PlayStation4MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacUSBUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacUSBUnityProfileR Reflect(PlayStation4MacUSBUnityProfile instance)
    {
        return new PlayStation4MacUSBUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4SteamLinkMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4SteamLinkMacUnityProfileR Reflect(PlayStation4SteamLinkMacUnityProfile instance)
    {
        return new PlayStation4SteamLinkMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4UnityProfileR Reflect(PlayStation4UnityProfile instance)
    {
        return new PlayStation4UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayStation4WindowsChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4WindowsChromeUnityProfileR Reflect(PlayStation4WindowsChromeUnityProfile instance)
    {
        return new PlayStation4WindowsChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayStation4WindowsFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4WindowsFirefoxUnityProfileR Reflect(PlayStation4WindowsFirefoxUnityProfile instance)
    {
        return new PlayStation4WindowsFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4WindowsNativeProfileR Reflect(PlayStation4WindowsNativeProfile instance)
    {
        return new PlayStation4WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4WindowsUnityProfileR Reflect(PlayStation4WindowsUnityProfile instance)
    {
        return new PlayStation4WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation5MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation5MacNativeProfileR Reflect(PlayStation5MacNativeProfile instance)
    {
        return new PlayStation5MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation5UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation5UnityProfileR Reflect(PlayStation5UnityProfile instance)
    {
        return new PlayStation5UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation5WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation5WindowsNativeProfileR Reflect(PlayStation5WindowsNativeProfile instance)
    {
        return new PlayStation5WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStationVitaPSMUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStationVitaPSMUnityProfileR Reflect(PlayStationVitaPSMUnityProfile instance)
    {
        return new PlayStationVitaPSMUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayVibration
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayVibrationR Reflect(PlayVibration instance)
    {
        return new PlayVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PositionShadeMarkerPerDoor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PositionShadeMarkerPerDoorR Reflect(PositionShadeMarkerPerDoor instance)
    {
        return new PositionShadeMarkerPerDoorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerAAirflowControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerAAirflowControllerMacNativeProfileR Reflect(PowerAAirflowControllerMacNativeProfile instance)
    {
        return new PowerAAirflowControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     POWERAFUS1ONTournamentControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static POWERAFUS1ONTournamentControllerMacNativeProfileR Reflect(
        POWERAFUS1ONTournamentControllerMacNativeProfile instance)
    {
        return new POWERAFUS1ONTournamentControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PowerAMiniControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerAMiniControllerMacNativeProfileR Reflect(PowerAMiniControllerMacNativeProfile instance)
    {
        return new PowerAMiniControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerAMiniProExControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerAMiniProExControllerMacNativeProfileR
        Reflect(PowerAMiniProExControllerMacNativeProfile instance)
    {
        return new PowerAMiniProExControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerAMiniXboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerAMiniXboxOneControllerMacNativeProfileR Reflect(
        PowerAMiniXboxOneControllerMacNativeProfile instance)
    {
        return new PowerAMiniXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PowerANintendoSwitchMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerANintendoSwitchMacNativeProfileR Reflect(PowerANintendoSwitchMacNativeProfile instance)
    {
        return new PowerANintendoSwitchMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerASpectraIlluminatedControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerASpectraIlluminatedControllerMacNativeProfileR Reflect(
        PowerASpectraIlluminatedControllerMacNativeProfile instance)
    {
        return new PowerASpectraIlluminatedControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreBuildTK2DSprites
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreBuildTK2DSpritesR Reflect(PreBuildTK2DSprites instance)
    {
        return new PreBuildTK2DSpritesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PrefabSwapper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PrefabSwapperR Reflect(PrefabSwapper instance)
    {
        return new PrefabSwapperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreInstantiateGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreInstantiateGameObjectR Reflect(PreInstantiateGameObject instance)
    {
        return new PreInstantiateGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreloadVibration
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreloadVibrationR Reflect(PreloadVibration instance)
    {
        return new PreloadVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreMenuInputModuleActionAdaptor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreMenuInputModuleActionAdaptorR Reflect(PreMenuInputModuleActionAdaptor instance)
    {
        return new PreMenuInputModuleActionAdaptorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreselectOption
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreselectOptionR Reflect(PreselectOption instance)
    {
        return new PreselectOptionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreserveAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreserveAttributeR Reflect(PreserveAttribute instance)
    {
        return new PreserveAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreSpawnCorpse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreSpawnCorpseR Reflect(PreSpawnCorpse instance)
    {
        return new PreSpawnCorpseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreSpawnGameObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreSpawnGameObjectsR Reflect(PreSpawnGameObjects instance)
    {
        return new PreSpawnGameObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreventInvincibleEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreventInvincibleEffectR Reflect(PreventInvincibleEffect instance)
    {
        return new PreventInvincibleEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Probability
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProbabilityR Reflect(Probability instance)
    {
        return new ProbabilityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ProEXXbox360ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProEXXbox360ControllerMacNativeProfileR Reflect(ProEXXbox360ControllerMacNativeProfile instance)
    {
        return new ProEXXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ProEXXboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProEXXboxOneControllerMacNativeProfileR Reflect(ProEXXboxOneControllerMacNativeProfile instance)
    {
        return new ProEXXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ProgressSaveMessagePanel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProgressSaveMessagePanelR Reflect(ProgressSaveMessagePanel instance)
    {
        return new ProgressSaveMessagePanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ProjectileSquash
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProjectileSquashR Reflect(ProjectileSquash instance)
    {
        return new ProjectileSquashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ProjectLocationToMap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProjectLocationToMapR Reflect(ProjectLocationToMap instance)
    {
        return new ProjectLocationToMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PromptMarker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PromptMarkerR Reflect(PromptMarker instance)
    {
        return new PromptMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PS4SimpleInputDevice
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PS4SimpleInputDeviceR Reflect(PS4SimpleInputDevice instance)
    {
        return new PS4SimpleInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PS4SimpleInputDeviceManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PS4SimpleInputDeviceManagerR Reflect(PS4SimpleInputDeviceManager instance)
    {
        return new PS4SimpleInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PushableRubble
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PushableRubbleR Reflect(PushableRubble instance)
    {
        return new PushableRubbleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QanbaFightStickPlusMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QanbaFightStickPlusMacNativeProfileR Reflect(QanbaFightStickPlusMacNativeProfile instance)
    {
        return new QanbaFightStickPlusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionAngleAxis
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionAngleAxisR Reflect(QuaternionAngleAxis instance)
    {
        return new QuaternionAngleAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionCompareR Reflect(QuaternionCompare instance)
    {
        return new QuaternionCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionEuler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionEulerR Reflect(QuaternionEuler instance)
    {
        return new QuaternionEulerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionInverse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionInverseR Reflect(QuaternionInverse instance)
    {
        return new QuaternionInverseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionLerp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionLerpR Reflect(QuaternionLerp instance)
    {
        return new QuaternionLerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionLookRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionLookRotationR Reflect(QuaternionLookRotation instance)
    {
        return new QuaternionLookRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionLowPassFilter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionLowPassFilterR Reflect(QuaternionLowPassFilter instance)
    {
        return new QuaternionLowPassFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionRotateTowards
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionRotateTowardsR Reflect(QuaternionRotateTowards instance)
    {
        return new QuaternionRotateTowardsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionSlerp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionSlerpR Reflect(QuaternionSlerp instance)
    {
        return new QuaternionSlerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuitToMenu
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuitToMenuR Reflect(QuitToMenu instance)
    {
        return new QuitToMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RadialLayoutUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RadialLayoutUIR Reflect(RadialLayoutUI instance)
    {
        return new RadialLayoutUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomAudioClipTable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomAudioClipTableR Reflect(RandomAudioClipTable instance)
    {
        return new RandomAudioClipTableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomAudioStart
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomAudioStartR Reflect(RandomAudioStart instance)
    {
        return new RandomAudioStartR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomBoolR Reflect(RandomBool instance)
    {
        return new RandomBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomEventR Reflect(RandomEvent instance)
    {
        return new RandomEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFloatR Reflect(RandomFloat instance)
    {
        return new RandomFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFloatEither
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFloatEitherR Reflect(RandomFloatEither instance)
    {
        return new RandomFloatEitherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFloatV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFloatV2R Reflect(RandomFloatV2 instance)
    {
        return new RandomFloatV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFrame
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFrameR Reflect(RandomFrame instance)
    {
        return new RandomFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomIntR Reflect(RandomInt instance)
    {
        return new RandomIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomlyFlipFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomlyFlipFloatR Reflect(RandomlyFlipFloat instance)
    {
        return new RandomlyFlipFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomRotationR Reflect(RandomRotation instance)
    {
        return new RandomRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomRotationRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomRotationRangeR Reflect(RandomRotationRange instance)
    {
        return new RandomRotationRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomScaleR Reflect(RandomScale instance)
    {
        return new RandomScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomWait
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomWaitR Reflect(RandomWait instance)
    {
        return new RandomWaitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Raycast
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RaycastR Reflect(Raycast instance)
    {
        return new RaycastR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RayCast2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RayCast2dR Reflect(RayCast2d instance)
    {
        return new RayCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RayCast2dV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RayCast2dV2R Reflect(RayCast2dV2 instance)
    {
        return new RayCast2dV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RaycastAll
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RaycastAllR Reflect(RaycastAll instance)
    {
        return new RaycastAllR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerAtroxArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerAtroxArcadeStickMacNativeProfileR Reflect(RazerAtroxArcadeStickMacNativeProfile instance)
    {
        return new RazerAtroxArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerOnzaControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerOnzaControllerMacNativeProfileR Reflect(RazerOnzaControllerMacNativeProfile instance)
    {
        return new RazerOnzaControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerOnzaTEControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerOnzaTEControllerMacNativeProfileR Reflect(RazerOnzaTEControllerMacNativeProfile instance)
    {
        return new RazerOnzaTEControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerSabertoothEliteControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerSabertoothEliteControllerMacNativeProfileR Reflect(
        RazerSabertoothEliteControllerMacNativeProfile instance)
    {
        return new RazerSabertoothEliteControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerServalForgeTVUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerServalForgeTVUnityProfileR Reflect(RazerServalForgeTVUnityProfile instance)
    {
        return new RazerServalForgeTVUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerServalMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerServalMacUnityProfileR Reflect(RazerServalMacUnityProfile instance)
    {
        return new RazerServalMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerServalWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerServalWindowsNativeProfileR Reflect(RazerServalWindowsNativeProfile instance)
    {
        return new RazerServalWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerStrikeControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerStrikeControllerMacNativeProfileR Reflect(RazerStrikeControllerMacNativeProfile instance)
    {
        return new RazerStrikeControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerWildcatControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerWildcatControllerMacNativeProfileR Reflect(RazerWildcatControllerMacNativeProfile instance)
    {
        return new RazerWildcatControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerWolverineUltimateControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerWolverineUltimateControllerMacNativeProfileR Reflect(
        RazerWolverineUltimateControllerMacNativeProfile instance)
    {
        return new RazerWolverineUltimateControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RealtimeReflections
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RealtimeReflectionsR Reflect(RealtimeReflections instance)
    {
        return new RealtimeReflectionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReceivedDamage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReceivedDamageR Reflect(ReceivedDamage instance)
    {
        return new ReceivedDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReceivedDamageStay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReceivedDamageStayR Reflect(ReceivedDamageStay instance)
    {
        return new ReceivedDamageStayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Recoil
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecoilR Reflect(Recoil instance)
    {
        return new RecoilR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RecordKillForJournalHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecordKillForJournalHandlerR Reflect(RecordKillForJournalHandler instance)
    {
        return new RecordKillForJournalHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectContains
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectContainsR Reflect(RectContains instance)
    {
        return new RectContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectOverlaps
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectOverlapsR Reflect(RectOverlaps instance)
    {
        return new RectOverlapsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformFlipLayoutAxis
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformFlipLayoutAxisR Reflect(RectTransformFlipLayoutAxis instance)
    {
        return new RectTransformFlipLayoutAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetAnchoredPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetAnchoredPositionR Reflect(RectTransformGetAnchoredPosition instance)
    {
        return new RectTransformGetAnchoredPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetAnchorMax
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetAnchorMaxR Reflect(RectTransformGetAnchorMax instance)
    {
        return new RectTransformGetAnchorMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetAnchorMin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetAnchorMinR Reflect(RectTransformGetAnchorMin instance)
    {
        return new RectTransformGetAnchorMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetLocalPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetLocalPositionR Reflect(RectTransformGetLocalPosition instance)
    {
        return new RectTransformGetLocalPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetLocalRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetLocalRotationR Reflect(RectTransformGetLocalRotation instance)
    {
        return new RectTransformGetLocalRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetOffsetMax
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetOffsetMaxR Reflect(RectTransformGetOffsetMax instance)
    {
        return new RectTransformGetOffsetMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetOffsetMin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetOffsetMinR Reflect(RectTransformGetOffsetMin instance)
    {
        return new RectTransformGetOffsetMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetPivot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetPivotR Reflect(RectTransformGetPivot instance)
    {
        return new RectTransformGetPivotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetRectR Reflect(RectTransformGetRect instance)
    {
        return new RectTransformGetRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetScaleR Reflect(RectTransformGetScale instance)
    {
        return new RectTransformGetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetSizeDelta
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetSizeDeltaR Reflect(RectTransformGetSizeDelta instance)
    {
        return new RectTransformGetSizeDeltaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformPixelAdjustPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformPixelAdjustPointR Reflect(RectTransformPixelAdjustPoint instance)
    {
        return new RectTransformPixelAdjustPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformPixelAdjustRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformPixelAdjustRectR Reflect(RectTransformPixelAdjustRect instance)
    {
        return new RectTransformPixelAdjustRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchoredPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchoredPositionR Reflect(RectTransformSetAnchoredPosition instance)
    {
        return new RectTransformSetAnchoredPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchorMax
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchorMaxR Reflect(RectTransformSetAnchorMax instance)
    {
        return new RectTransformSetAnchorMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchorMin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchorMinR Reflect(RectTransformSetAnchorMin instance)
    {
        return new RectTransformSetAnchorMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchorRectPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchorRectPositionR Reflect(RectTransformSetAnchorRectPosition instance)
    {
        return new RectTransformSetAnchorRectPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetLocalPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetLocalPositionR Reflect(RectTransformSetLocalPosition instance)
    {
        return new RectTransformSetLocalPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetLocalRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetLocalRotationR Reflect(RectTransformSetLocalRotation instance)
    {
        return new RectTransformSetLocalRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetOffsetMax
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetOffsetMaxR Reflect(RectTransformSetOffsetMax instance)
    {
        return new RectTransformSetOffsetMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetOffsetMin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetOffsetMinR Reflect(RectTransformSetOffsetMin instance)
    {
        return new RectTransformSetOffsetMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetPivot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetPivotR Reflect(RectTransformSetPivot instance)
    {
        return new RectTransformSetPivotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetSizeDelta
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetSizeDeltaR Reflect(RectTransformSetSizeDelta instance)
    {
        return new RectTransformSetSizeDeltaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformWorldToScreenPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformWorldToScreenPointR Reflect(RectTransformWorldToScreenPoint instance)
    {
        return new RectTransformWorldToScreenPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RecycleAfter2dtkAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecycleAfter2dtkAnimationR Reflect(RecycleAfter2dtkAnimation instance)
    {
        return new RecycleAfter2dtkAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RecycleSelf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecycleSelfR Reflect(RecycleSelf instance)
    {
        return new RecycleSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RedOctaneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RedOctaneControllerMacNativeProfileR Reflect(RedOctaneControllerMacNativeProfile instance)
    {
        return new RedOctaneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RedOctaneGuitarMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RedOctaneGuitarMacNativeProfileR Reflect(RedOctaneGuitarMacNativeProfile instance)
    {
        return new RedOctaneGuitarMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RedSamuraiAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RedSamuraiAndroidUnityProfileR Reflect(RedSamuraiAndroidUnityProfile instance)
    {
        return new RedSamuraiAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReduceParticleEffects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReduceParticleEffectsR Reflect(ReduceParticleEffects instance)
    {
        return new ReduceParticleEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of References
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReferencesR Reflect(References instance)
    {
        return new ReferencesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReflectAngle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReflectAngleR Reflect(ReflectAngle instance)
    {
        return new ReflectAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RegionDebugger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RegionDebuggerR Reflect(RegionDebugger instance)
    {
        return new RegionDebuggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RegionSetAudio
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RegionSetAudioR Reflect(RegionSetAudio instance)
    {
        return new RegionSetAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RegularGridLayout
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RegularGridLayoutR Reflect(RegularGridLayout instance)
    {
        return new RegularGridLayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemapTK2DSpriteAnimator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemapTK2DSpriteAnimatorR Reflect(RemapTK2DSpriteAnimator instance)
    {
        return new RemapTK2DSpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoteDisable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoteDisableR Reflect(RemoteDisable instance)
    {
        return new RemoteDisableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoteDisableChild
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoteDisableChildR Reflect(RemoteDisableChild instance)
    {
        return new RemoteDisableChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoveAllComponents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoveAllComponentsR Reflect(RemoveAllComponents instance)
    {
        return new RemoveAllComponentsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoveMethodCall
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoveMethodCallR Reflect(RemoveMethodCall instance)
    {
        return new RemoveMethodCallR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoveMixingTransform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoveMixingTransformR Reflect(RemoveMixingTransform instance)
    {
        return new RemoveMixingTransformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReplaceTextLineBreaks
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReplaceTextLineBreaksR Reflect(ReplaceTextLineBreaks instance)
    {
        return new ReplaceTextLineBreaksR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RequestFadeSceneIn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RequestFadeSceneInR Reflect(RequestFadeSceneIn instance)
    {
        return new RequestFadeSceneInR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ResetGUIMatrix
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ResetGUIMatrixR Reflect(ResetGUIMatrix instance)
    {
        return new ResetGUIMatrixR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ResetInputAxes
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ResetInputAxesR Reflect(ResetInputAxes instance)
    {
        return new ResetInputAxesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ResolutionCountdownTimer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ResolutionCountdownTimerR Reflect(ResolutionCountdownTimer instance)
    {
        return new ResolutionCountdownTimerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RespawnMarker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RespawnMarkerR Reflect(RespawnMarker instance)
    {
        return new RespawnMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RespawnTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RespawnTriggerR Reflect(RespawnTrigger instance)
    {
        return new RespawnTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestartLevel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestartLevelR Reflect(RestartLevel instance)
    {
        return new RestartLevelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestBench
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestBenchR Reflect(RestBench instance)
    {
        return new RestBenchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestBenchTilt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestBenchTiltR Reflect(RestBenchTilt instance)
    {
        return new RestBenchTiltR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestoreGameObjectPositions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestoreGameObjectPositionsR Reflect(RestoreGameObjectPositions instance)
    {
        return new RestoreGameObjectPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RewindAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RewindAnimationR Reflect(RewindAnimation instance)
    {
        return new RewindAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RockBandDrumsMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockBandDrumsMacNativeProfileR Reflect(RockBandDrumsMacNativeProfile instance)
    {
        return new RockBandDrumsMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RockBandGuitarMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockBandGuitarMacNativeProfileR Reflect(RockBandGuitarMacNativeProfile instance)
    {
        return new RockBandGuitarMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RockCandyControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockCandyControllerMacNativeProfileR Reflect(RockCandyControllerMacNativeProfile instance)
    {
        return new RockCandyControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RockCandyPS3ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockCandyPS3ControllerMacNativeProfileR Reflect(RockCandyPS3ControllerMacNativeProfile instance)
    {
        return new RockCandyPS3ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RockCandyXbox360ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockCandyXbox360ControllerMacNativeProfileR Reflect(
        RockCandyXbox360ControllerMacNativeProfile instance)
    {
        return new RockCandyXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RockCandyXboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockCandyXboxOneControllerMacNativeProfileR Reflect(
        RockCandyXboxOneControllerMacNativeProfile instance)
    {
        return new RockCandyXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Roof
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RoofR Reflect(Roof instance)
    {
        return new RoofR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Rotate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotateR Reflect(Rotate instance)
    {
        return new RotateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RotateGUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotateGUIR Reflect(RotateGUI instance)
    {
        return new RotateGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RotateTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotateToR Reflect(RotateTo instance)
    {
        return new RotateToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RotationController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotationControllerR Reflect(RotationController instance)
    {
        return new RotationControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RoughMapRoom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RoughMapRoomR Reflect(RoughMapRoom instance)
    {
        return new RoughMapRoomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RuinsLift
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RuinsLiftR Reflect(RuinsLift instance)
    {
        return new RuinsLiftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RunAway
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RunAwayR Reflect(RunAway instance)
    {
        return new RunAwayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RunFSM
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RunFSMR Reflect(RunFSM instance)
    {
        return new RunFSMR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RunGarbageCollector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RunGarbageCollectorR Reflect(RunGarbageCollector instance)
    {
        return new RunGarbageCollectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaitekAviatorWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaitekAviatorWindowsUnityProfileR Reflect(SaitekAviatorWindowsUnityProfile instance)
    {
        return new SaitekAviatorWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SaitekXbox360ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaitekXbox360ControllerMacNativeProfileR Reflect(SaitekXbox360ControllerMacNativeProfile instance)
    {
        return new SaitekXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SampleCurve
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SampleCurveR Reflect(SampleCurve instance)
    {
        return new SampleCurveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SamsungGP20AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SamsungGP20AndroidUnityProfileR Reflect(SamsungGP20AndroidUnityProfile instance)
    {
        return new SamsungGP20AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveConfig
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveConfigR Reflect(SaveConfig instance)
    {
        return new SaveConfigR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveGameData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveGameDataR Reflect(SaveGameData instance)
    {
        return new SaveGameDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveProfileHealthBar
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveProfileHealthBarR Reflect(SaveProfileHealthBar instance)
    {
        return new SaveProfileHealthBarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveProfileMPSlots
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveProfileMPSlotsR Reflect(SaveProfileMPSlots instance)
    {
        return new SaveProfileMPSlotsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveSlotBackgrounds
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveSlotBackgroundsR Reflect(SaveSlotBackgrounds instance)
    {
        return new SaveSlotBackgroundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveSlotButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveSlotButtonR Reflect(SaveSlotButton instance)
    {
        return new SaveSlotButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveSlotOverrides
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveSlotOverridesR Reflect(SaveSlotOverrides instance)
    {
        return new SaveSlotOverridesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveStats
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveStatsR Reflect(SaveStats instance)
    {
        return new SaveStatsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScaleGUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScaleGUIR Reflect(ScaleGUI instance)
    {
        return new ScaleGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScaleTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScaleTimeR Reflect(ScaleTime instance)
    {
        return new ScaleTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScaleTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScaleToR Reflect(ScaleTo instance)
    {
        return new ScaleToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneAdditiveLoadConditional
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneAdditiveLoadConditionalR Reflect(SceneAdditiveLoadConditional instance)
    {
        return new SceneAdditiveLoadConditionalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneColorManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneColorManagerR Reflect(SceneColorManager instance)
    {
        return new SceneColorManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneDataR Reflect(SceneData instance)
    {
        return new SceneDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneDefaultSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneDefaultSettingsR Reflect(SceneDefaultSettings instance)
    {
        return new SceneDefaultSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneImporter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneImporterR Reflect(SceneImporter instance)
    {
        return new SceneImporterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneLoad
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneLoadR Reflect(SceneLoad instance)
    {
        return new SceneLoadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneManagerR Reflect(SceneManager instance)
    {
        return new SceneManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneManagerSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneManagerSettingsR Reflect(SceneManagerSettings instance)
    {
        return new SceneManagerSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneParticles
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneParticlesR Reflect(SceneParticles instance)
    {
        return new SceneParticlesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneParticlesController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneParticlesControllerR Reflect(SceneParticlesController instance)
    {
        return new SceneParticlesControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScenePreloader
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScenePreloaderR Reflect(ScenePreloader instance)
    {
        return new ScenePreloaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneryTriggerCircle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneryTriggerCircleR Reflect(SceneryTriggerCircle instance)
    {
        return new SceneryTriggerCircleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenPick
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenPickR Reflect(ScreenPick instance)
    {
        return new ScreenPickR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenPick2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenPick2dR Reflect(ScreenPick2d instance)
    {
        return new ScreenPick2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenSetResolution
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenSetResolutionR Reflect(ScreenSetResolution instance)
    {
        return new ScreenSetResolutionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenToWorldPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenToWorldPointR Reflect(ScreenToWorldPoint instance)
    {
        return new ScreenToWorldPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScrollBarHandle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScrollBarHandleR Reflect(ScrollBarHandle instance)
    {
        return new ScrollBarHandleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScrollPaneSelector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScrollPaneSelectorR Reflect(ScrollPaneSelector instance)
    {
        return new ScrollPaneSelectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScuttlerControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScuttlerControlR Reflect(ScuttlerControl instance)
    {
        return new ScuttlerControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SecurePlayerPrefs
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SecurePlayerPrefsR Reflect(SecurePlayerPrefs instance)
    {
        return new SecurePlayerPrefsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SecurePlayerPrefsDemo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SecurePlayerPrefsDemoR Reflect(SecurePlayerPrefsDemo instance)
    {
        return new SecurePlayerPrefsDemoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SecureplayerPrefsDemoClass
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SecureplayerPrefsDemoClassR Reflect(SecureplayerPrefsDemoClass instance)
    {
        return new SecureplayerPrefsDemoClassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectCharmBackboard
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectCharmBackboardR Reflect(SelectCharmBackboard instance)
    {
        return new SelectCharmBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomColorR Reflect(SelectRandomColor instance)
    {
        return new SelectRandomColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomGameObjectR Reflect(SelectRandomGameObject instance)
    {
        return new SelectRandomGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomStringR Reflect(SelectRandomString instance)
    {
        return new SelectRandomStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomVector3R Reflect(SelectRandomVector3 instance)
    {
        return new SelectRandomVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendDeathEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendDeathEventR Reflect(SendDeathEvent instance)
    {
        return new SendDeathEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendDreamImpact
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendDreamImpactR Reflect(SendDreamImpact instance)
    {
        return new SendDreamImpactR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEnemyMessage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEnemyMessageR Reflect(SendEnemyMessage instance)
    {
        return new SendEnemyMessageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEnemyMessageTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEnemyMessageTriggerR Reflect(SendEnemyMessageTrigger instance)
    {
        return new SendEnemyMessageTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventR Reflect(SendEvent instance)
    {
        return new SendEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventByName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventByNameR Reflect(SendEventByName instance)
    {
        return new SendEventByNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventByNameV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventByNameV2R Reflect(SendEventByNameV2 instance)
    {
        return new SendEventByNameV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventByScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventByScaleR Reflect(SendEventByScale instance)
    {
        return new SendEventByScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventToFsm
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventToFsmR Reflect(SendEventToFsm instance)
    {
        return new SendEventToFsmR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventToGameObjectOptimized
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventToGameObjectOptimizedR Reflect(SendEventToGameObjectOptimized instance)
    {
        return new SendEventToGameObjectOptimizedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventToRegister
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventToRegisterR Reflect(SendEventToRegister instance)
    {
        return new SendEventToRegisterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendExtraDamage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendExtraDamageR Reflect(SendExtraDamage instance)
    {
        return new SendExtraDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendFSMEventOnEntry
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendFSMEventOnEntryR Reflect(SendFSMEventOnEntry instance)
    {
        return new SendFSMEventOnEntryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendHealthManagerDeathEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendHealthManagerDeathEventR Reflect(SendHealthManagerDeathEvent instance)
    {
        return new SendHealthManagerDeathEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendMessage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendMessageR Reflect(SendMessage instance)
    {
        return new SendMessageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendMessageByTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendMessageByTagR Reflect(SendMessageByTag instance)
    {
        return new SendMessageByTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendMessageV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendMessageV2R Reflect(SendMessageV2 instance)
    {
        return new SendMessageV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendPlaymakerEventOnEnable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendPlaymakerEventOnEnableR Reflect(SendPlaymakerEventOnEnable instance)
    {
        return new SendPlaymakerEventOnEnableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendRandomEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendRandomEventR Reflect(SendRandomEvent instance)
    {
        return new SendRandomEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendRandomEventV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendRandomEventV2R Reflect(SendRandomEventV2 instance)
    {
        return new SendRandomEventV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendRandomEventV3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendRandomEventV3R Reflect(SendRandomEventV3 instance)
    {
        return new SendRandomEventV3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendTrigger2DEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendTrigger2DEventR Reflect(SendTrigger2DEvent instance)
    {
        return new SendTrigger2DEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendTrigger2DEventByName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendTrigger2DEventByNameR Reflect(SendTrigger2DEventByName instance)
    {
        return new SendTrigger2DEventByNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SequenceEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SequenceEventR Reflect(SequenceEvent instance)
    {
        return new SequenceEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAllFsmGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAllFsmGameObjectR Reflect(SetAllFsmGameObject instance)
    {
        return new SetAllFsmGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAmbientLight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAmbientLightR Reflect(SetAmbientLight instance)
    {
        return new SetAmbientLightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAngleToVelocity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAngleToVelocityR Reflect(SetAngleToVelocity instance)
    {
        return new SetAngleToVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAngularVelocity2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAngularVelocity2dR Reflect(SetAngularVelocity2d instance)
    {
        return new SetAngularVelocity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimationSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimationSpeedR Reflect(SetAnimationSpeed instance)
    {
        return new SetAnimationSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimationTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimationTimeR Reflect(SetAnimationTime instance)
    {
        return new SetAnimationTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimationWeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimationWeightR Reflect(SetAnimationWeight instance)
    {
        return new SetAnimationWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorR Reflect(SetAnimator instance)
    {
        return new SetAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorApplyRootMotion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorApplyRootMotionR Reflect(SetAnimatorApplyRootMotion instance)
    {
        return new SetAnimatorApplyRootMotionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorBody
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorBodyR Reflect(SetAnimatorBody instance)
    {
        return new SetAnimatorBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorBoolR Reflect(SetAnimatorBool instance)
    {
        return new SetAnimatorBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorCullingMode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorCullingModeR Reflect(SetAnimatorCullingMode instance)
    {
        return new SetAnimatorCullingModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorFeetPivotActive
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorFeetPivotActiveR Reflect(SetAnimatorFeetPivotActive instance)
    {
        return new SetAnimatorFeetPivotActiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorFloatR Reflect(SetAnimatorFloat instance)
    {
        return new SetAnimatorFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorIKGoal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorIKGoalR Reflect(SetAnimatorIKGoal instance)
    {
        return new SetAnimatorIKGoalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorIntR Reflect(SetAnimatorInt instance)
    {
        return new SetAnimatorIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorLayersAffectMassCenter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorLayersAffectMassCenterR Reflect(SetAnimatorLayersAffectMassCenter instance)
    {
        return new SetAnimatorLayersAffectMassCenterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorLayerWeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorLayerWeightR Reflect(SetAnimatorLayerWeight instance)
    {
        return new SetAnimatorLayerWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorLookAt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorLookAtR Reflect(SetAnimatorLookAt instance)
    {
        return new SetAnimatorLookAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorPlayBackSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorPlayBackSpeedR Reflect(SetAnimatorPlayBackSpeed instance)
    {
        return new SetAnimatorPlayBackSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorPlayBackTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorPlayBackTimeR Reflect(SetAnimatorPlayBackTime instance)
    {
        return new SetAnimatorPlayBackTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorSpeedR Reflect(SetAnimatorSpeed instance)
    {
        return new SetAnimatorSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorStabilizeFeet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorStabilizeFeetR Reflect(SetAnimatorStabilizeFeet instance)
    {
        return new SetAnimatorStabilizeFeetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorTargetR Reflect(SetAnimatorTarget instance)
    {
        return new SetAnimatorTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorTriggerR Reflect(SetAnimatorTrigger instance)
    {
        return new SetAnimatorTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioClip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioClipR Reflect(SetAudioClip instance)
    {
        return new SetAudioClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioLoop
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioLoopR Reflect(SetAudioLoop instance)
    {
        return new SetAudioLoopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioPitch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioPitchR Reflect(SetAudioPitch instance)
    {
        return new SetAudioPitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioSource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioSourceR Reflect(SetAudioSource instance)
    {
        return new SetAudioSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioVolume
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioVolumeR Reflect(SetAudioVolume instance)
    {
        return new SetAudioVolumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBackgroundColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBackgroundColorR Reflect(SetBackgroundColor instance)
    {
        return new SetBackgroundColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBattleScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBattleSceneR Reflect(SetBattleScene instance)
    {
        return new SetBattleSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBlurDepth
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBlurDepthR Reflect(SetBlurDepth instance)
    {
        return new SetBlurDepthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoolProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoolProxyR Reflect(SetBoolProxy instance)
    {
        return new SetBoolProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoolValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoolValueR Reflect(SetBoolValue instance)
    {
        return new SetBoolValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoxCollider2DSize
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoxCollider2DSizeR Reflect(SetBoxCollider2DSize instance)
    {
        return new SetBoxCollider2DSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoxCollider2DSizeVector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoxCollider2DSizeVectorR Reflect(SetBoxCollider2DSizeVector instance)
    {
        return new SetBoxCollider2DSizeVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoxColliderTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoxColliderTriggerR Reflect(SetBoxColliderTrigger instance)
    {
        return new SetBoxColliderTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCameraCullingMask
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCameraCullingMaskR Reflect(SetCameraCullingMask instance)
    {
        return new SetCameraCullingMaskR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCameraFOV
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCameraFOVR Reflect(SetCameraFOV instance)
    {
        return new SetCameraFOVR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCircleCollider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCircleColliderR Reflect(SetCircleCollider instance)
    {
        return new SetCircleColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCircleColliderRadius
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCircleColliderRadiusR Reflect(SetCircleColliderRadius instance)
    {
        return new SetCircleColliderRadiusR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCollider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetColliderR Reflect(SetCollider instance)
    {
        return new SetColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCollider2dIsTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCollider2dIsTriggerR Reflect(SetCollider2dIsTrigger instance)
    {
        return new SetCollider2dIsTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetColorRGBA
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetColorRGBAR Reflect(SetColorRGBA instance)
    {
        return new SetColorRGBAR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetColorValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetColorValueR Reflect(SetColorValue instance)
    {
        return new SetColorValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCorpseSpawnPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCorpseSpawnPointR Reflect(SetCorpseSpawnPoint instance)
    {
        return new SetCorpseSpawnPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDamageHeroAmount
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDamageHeroAmountR Reflect(SetDamageHeroAmount instance)
    {
        return new SetDamageHeroAmountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDamageOverride
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDamageOverrideR Reflect(SetDamageOverride instance)
    {
        return new SetDamageOverrideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDrag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDragR Reflect(SetDrag instance)
    {
        return new SetDragR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDreamNailConvo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDreamNailConvoR Reflect(SetDreamNailConvo instance)
    {
        return new SetDreamNailConvoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEffectOrigin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEffectOriginR Reflect(SetEffectOrigin instance)
    {
        return new SetEffectOriginR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEnumValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEnumValueR Reflect(SetEnumValue instance)
    {
        return new SetEnumValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEventData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEventDataR Reflect(SetEventData instance)
    {
        return new SetEventDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEventProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEventPropertiesR Reflect(SetEventProperties instance)
    {
        return new SetEventPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEventTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEventTargetR Reflect(SetEventTarget instance)
    {
        return new SetEventTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetExtrapolate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetExtrapolateR Reflect(SetExtrapolate instance)
    {
        return new SetExtrapolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFlareStrength
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFlareStrengthR Reflect(SetFlareStrength instance)
    {
        return new SetFlareStrengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatProxyR Reflect(SetFloatProxy instance)
    {
        return new SetFloatProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatToHighest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatToHighestR Reflect(SetFloatToHighest instance)
    {
        return new SetFloatToHighestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatToSmallest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatToSmallestR Reflect(SetFloatToSmallest instance)
    {
        return new SetFloatToSmallestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatValueR Reflect(SetFloatValue instance)
    {
        return new SetFloatValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatValueV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatValueV2R Reflect(SetFloatValueV2 instance)
    {
        return new SetFloatValueV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFogColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFogColorR Reflect(SetFogColor instance)
    {
        return new SetFogColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFogDensity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFogDensityR Reflect(SetFogDensity instance)
    {
        return new SetFogDensityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmArray
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmArrayR Reflect(SetFsmArray instance)
    {
        return new SetFsmArrayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmArrayItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmArrayItemR Reflect(SetFsmArrayItem instance)
    {
        return new SetFsmArrayItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmBoolR Reflect(SetFsmBool instance)
    {
        return new SetFsmBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmColorR Reflect(SetFsmColor instance)
    {
        return new SetFsmColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmEnum
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmEnumR Reflect(SetFsmEnum instance)
    {
        return new SetFsmEnumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmFloatR Reflect(SetFsmFloat instance)
    {
        return new SetFsmFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmGameObjectR Reflect(SetFsmGameObject instance)
    {
        return new SetFsmGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmIntR Reflect(SetFsmInt instance)
    {
        return new SetFsmIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmMaterial
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmMaterialR Reflect(SetFsmMaterial instance)
    {
        return new SetFsmMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmObjectR Reflect(SetFsmObject instance)
    {
        return new SetFsmObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmQuaternion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmQuaternionR Reflect(SetFsmQuaternion instance)
    {
        return new SetFsmQuaternionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmRectR Reflect(SetFsmRect instance)
    {
        return new SetFsmRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmStringR Reflect(SetFsmString instance)
    {
        return new SetFsmStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmStringReturn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmStringReturnR Reflect(SetFsmStringReturn instance)
    {
        return new SetFsmStringReturnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmTexture
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmTextureR Reflect(SetFsmTexture instance)
    {
        return new SetFsmTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmVariable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmVariableR Reflect(SetFsmVariable instance)
    {
        return new SetFsmVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmVector2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmVector2R Reflect(SetFsmVector2 instance)
    {
        return new SetFsmVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmVector3R Reflect(SetFsmVector3 instance)
    {
        return new SetFsmVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGameObjectR Reflect(SetGameObject instance)
    {
        return new SetGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGameObjectSelf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGameObjectSelfR Reflect(SetGameObjectSelf instance)
    {
        return new SetGameObjectSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGameVolume
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGameVolumeR Reflect(SetGameVolume instance)
    {
        return new SetGameVolumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGeoDrop
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGeoDropR Reflect(SetGeoDrop instance)
    {
        return new SetGeoDropR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGravity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGravityR Reflect(SetGravity instance)
    {
        return new SetGravityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGravity2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGravity2dR Reflect(SetGravity2d instance)
    {
        return new SetGravity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGravity2dScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGravity2dScaleR Reflect(SetGravity2dScale instance)
    {
        return new SetGravity2dScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIAlpha
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIAlphaR Reflect(SetGUIAlpha instance)
    {
        return new SetGUIAlphaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIBackgroundColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIBackgroundColorR Reflect(SetGUIBackgroundColor instance)
    {
        return new SetGUIBackgroundColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIColorR Reflect(SetGUIColor instance)
    {
        return new SetGUIColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIContentColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIContentColorR Reflect(SetGUIContentColor instance)
    {
        return new SetGUIContentColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIDepth
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIDepthR Reflect(SetGUIDepth instance)
    {
        return new SetGUIDepthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUISkin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUISkinR Reflect(SetGUISkin instance)
    {
        return new SetGUISkinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHaloStrength
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHaloStrengthR Reflect(SetHaloStrength instance)
    {
        return new SetHaloStrengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHealthManagerReset
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHealthManagerResetR Reflect(SetHealthManagerReset instance)
    {
        return new SetHealthManagerResetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHingeJoint2dProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHingeJoint2dPropertiesR Reflect(SetHingeJoint2dProperties instance)
    {
        return new SetHingeJoint2dPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHP
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHPR Reflect(SetHP instance)
    {
        return new SetHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetInterpolate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetInterpolateR Reflect(SetInterpolate instance)
    {
        return new SetInterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetInterpolateNone
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetInterpolateNoneR Reflect(SetInterpolateNone instance)
    {
        return new SetInterpolateNoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntFromFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntFromFloatR Reflect(SetIntFromFloat instance)
    {
        return new SetIntFromFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntProxyR Reflect(SetIntProxy instance)
    {
        return new SetIntProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntToSmallest
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntToSmallestR Reflect(SetIntToSmallest instance)
    {
        return new SetIntToSmallestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntValueR Reflect(SetIntValue instance)
    {
        return new SetIntValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetInvincible
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetInvincibleR Reflect(SetInvincible instance)
    {
        return new SetInvincibleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsDead
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsDeadR Reflect(SetIsDead instance)
    {
        return new SetIsDeadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsFixedAngle2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsFixedAngle2dR Reflect(SetIsFixedAngle2d instance)
    {
        return new SetIsFixedAngle2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsKinematic
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsKinematicR Reflect(SetIsKinematic instance)
    {
        return new SetIsKinematicR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsKinematic2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsKinematic2dR Reflect(SetIsKinematic2d instance)
    {
        return new SetIsKinematic2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetJointConnectedBody
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetJointConnectedBodyR Reflect(SetJointConnectedBody instance)
    {
        return new SetJointConnectedBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLayerR Reflect(SetLayer instance)
    {
        return new SetLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightColorR Reflect(SetLightColor instance)
    {
        return new SetLightColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightCookie
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightCookieR Reflect(SetLightCookie instance)
    {
        return new SetLightCookieR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightFlare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightFlareR Reflect(SetLightFlare instance)
    {
        return new SetLightFlareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightIntensity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightIntensityR Reflect(SetLightIntensity instance)
    {
        return new SetLightIntensityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightRange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightRangeR Reflect(SetLightRange instance)
    {
        return new SetLightRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightSpotAngle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightSpotAngleR Reflect(SetLightSpotAngle instance)
    {
        return new SetLightSpotAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightType
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightTypeR Reflect(SetLightType instance)
    {
        return new SetLightTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMainCamera
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMainCameraR Reflect(SetMainCamera instance)
    {
        return new SetMainCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMass
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMassR Reflect(SetMass instance)
    {
        return new SetMassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMass2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMass2dR Reflect(SetMass2d instance)
    {
        return new SetMass2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterial
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialR Reflect(SetMaterial instance)
    {
        return new SetMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterialColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialColorR Reflect(SetMaterialColor instance)
    {
        return new SetMaterialColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterialFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialFloatR Reflect(SetMaterialFloat instance)
    {
        return new SetMaterialFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterialTexture
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialTextureR Reflect(SetMaterialTexture instance)
    {
        return new SetMaterialTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMenuButtonIconAction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMenuButtonIconActionR Reflect(SetMenuButtonIconAction instance)
    {
        return new SetMenuButtonIconActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMeshRenderer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMeshRendererR Reflect(SetMeshRenderer instance)
    {
        return new SetMeshRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMeshRendererChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMeshRendererChildrenR Reflect(SetMeshRendererChildren instance)
    {
        return new SetMeshRendererChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMouseCursor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMouseCursorR Reflect(SetMouseCursor instance)
    {
        return new SetMouseCursorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetNameR Reflect(SetName instance)
    {
        return new SetNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetObjectValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetObjectValueR Reflect(SetObjectValue instance)
    {
        return new SetObjectValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParentR Reflect(SetParent instance)
    {
        return new SetParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleEmission
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleEmissionR Reflect(SetParticleEmission instance)
    {
        return new SetParticleEmissionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleEmissionRate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleEmissionRateR Reflect(SetParticleEmissionRate instance)
    {
        return new SetParticleEmissionRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleEmissionSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleEmissionSpeedR Reflect(SetParticleEmissionSpeed instance)
    {
        return new SetParticleEmissionSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleScaleR Reflect(SetParticleScale instance)
    {
        return new SetParticleScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataBoolR Reflect(SetPlayerDataBool instance)
    {
        return new SetPlayerDataBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataFloat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataFloatR Reflect(SetPlayerDataFloat instance)
    {
        return new SetPlayerDataFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataInt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataIntR Reflect(SetPlayerDataInt instance)
    {
        return new SetPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataString
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataStringR Reflect(SetPlayerDataString instance)
    {
        return new SetPlayerDataStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataVector3
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataVector3R Reflect(SetPlayerDataVector3 instance)
    {
        return new SetPlayerDataVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPolygonCollider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPolygonColliderR Reflect(SetPolygonCollider instance)
    {
        return new SetPolygonColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPosIfPlayerdataBool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPosIfPlayerdataBoolR Reflect(SetPosIfPlayerdataBool instance)
    {
        return new SetPosIfPlayerdataBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPositionR Reflect(SetPosition instance)
    {
        return new SetPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPositionToObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPositionToObjectR Reflect(SetPositionToObject instance)
    {
        return new SetPositionToObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetProperty
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPropertyR Reflect(SetProperty instance)
    {
        return new SetPropertyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRandomMaterial
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRandomMaterialR Reflect(SetRandomMaterial instance)
    {
        return new SetRandomMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRandomRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRandomRotationR Reflect(SetRandomRotation instance)
    {
        return new SetRandomRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRandomSpriteId
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRandomSpriteIdR Reflect(SetRandomSpriteId instance)
    {
        return new SetRandomSpriteIdR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRecoilFreeze
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRecoilFreezeR Reflect(SetRecoilFreeze instance)
    {
        return new SetRecoilFreezeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRecoilSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRecoilSpeedR Reflect(SetRecoilSpeed instance)
    {
        return new SetRecoilSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRectFields
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRectFieldsR Reflect(SetRectFields instance)
    {
        return new SetRectFieldsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRectValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRectValueR Reflect(SetRectValue instance)
    {
        return new SetRectValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRespawningHero
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRespawningHeroR Reflect(SetRespawningHero instance)
    {
        return new SetRespawningHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRigidbodySimulated2D
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRigidbodySimulated2DR Reflect(SetRigidbodySimulated2D instance)
    {
        return new SetRigidbodySimulated2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRotationR Reflect(SetRotation instance)
    {
        return new SetRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetScaleR Reflect(SetScale instance)
    {
        return new SetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSceneAudio
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSceneAudioR Reflect(SetSceneAudio instance)
    {
        return new SetSceneAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSendKilledToObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSendKilledToObjectR Reflect(SetSendKilledToObject instance)
    {
        return new SetSendKilledToObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetShadowStrength
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetShadowStrengthR Reflect(SetShadowStrength instance)
    {
        return new SetShadowStrengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSkybox
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSkyboxR Reflect(SetSkybox instance)
    {
        return new SetSkyboxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpawnJarContents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpawnJarContentsR Reflect(SetSpawnJarContents instance)
    {
        return new SetSpawnJarContentsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpecialDeath
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpecialDeathR Reflect(SetSpecialDeath instance)
    {
        return new SetSpecialDeathR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRenderer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererR Reflect(SetSpriteRenderer instance)
    {
        return new SetSpriteRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRendererByColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererByColorR Reflect(SetSpriteRendererByColor instance)
    {
        return new SetSpriteRendererByColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRendererOrder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererOrderR Reflect(SetSpriteRendererOrder instance)
    {
        return new SetSpriteRendererOrderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRendererSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererSpriteR Reflect(SetSpriteRendererSprite instance)
    {
        return new SetSpriteRendererSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetStaticVariable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetStaticVariableR Reflect(SetStaticVariable instance)
    {
        return new SetStaticVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetStringProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetStringProxyR Reflect(SetStringProxy instance)
    {
        return new SetStringProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetStringValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetStringValueR Reflect(SetStringValue instance)
    {
        return new SetStringValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTagR Reflect(SetTag instance)
    {
        return new SetTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTagsOnChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTagsOnChildrenR Reflect(SetTagsOnChildren instance)
    {
        return new SetTagsOnChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProAlignment
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProAlignmentR Reflect(SetTextMeshProAlignment instance)
    {
        return new SetTextMeshProAlignmentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProColorR Reflect(SetTextMeshProColor instance)
    {
        return new SetTextMeshProColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProGameText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProGameTextR Reflect(SetTextMeshProGameText instance)
    {
        return new SetTextMeshProGameTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProTextR Reflect(SetTextMeshProText instance)
    {
        return new SetTextMeshProTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshTextR Reflect(SetTextMeshText instance)
    {
        return new SetTextMeshTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextureOffset
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextureOffsetR Reflect(SetTextureOffset instance)
    {
        return new SetTextureOffsetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextureScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextureScaleR Reflect(SetTextureScale instance)
    {
        return new SetTextureScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTrailRenderer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTrailRendererR Reflect(SetTrailRenderer instance)
    {
        return new SetTrailRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTransformParent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTransformParentR Reflect(SetTransformParent instance)
    {
        return new SetTransformParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVariableProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVariableProxyR Reflect(SetVariableProxy instance)
    {
        return new SetVariableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector2XY
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector2XYR Reflect(SetVector2XY instance)
    {
        return new SetVector2XYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector3Proxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector3ProxyR Reflect(SetVector3Proxy instance)
    {
        return new SetVector3ProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector3Value
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector3ValueR Reflect(SetVector3Value instance)
    {
        return new SetVector3ValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector3XYZ
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector3XYZR Reflect(SetVector3XYZ instance)
    {
        return new SetVector3XYZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocityR Reflect(SetVelocity instance)
    {
        return new SetVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocity2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocity2dR Reflect(SetVelocity2d instance)
    {
        return new SetVelocity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocity2dIfFalse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocity2dIfFalseR Reflect(SetVelocity2dIfFalse instance)
    {
        return new SetVelocity2dIfFalseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocityAsAngle
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocityAsAngleR Reflect(SetVelocityAsAngle instance)
    {
        return new SetVelocityAsAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVersionNumber
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVersionNumberR Reflect(SetVersionNumber instance)
    {
        return new SetVersionNumberR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVisibility
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVisibilityR Reflect(SetVisibility instance)
    {
        return new SetVisibilityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWalkerFacing
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWalkerFacingR Reflect(SetWalkerFacing instance)
    {
        return new SetWalkerFacingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWalkerSpeed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWalkerSpeedR Reflect(SetWalkerSpeed instance)
    {
        return new SetWalkerSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWalkerStartInactive
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWalkerStartInactiveR Reflect(SetWalkerStartInactive instance)
    {
        return new SetWalkerStartInactiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWheelJoint2dProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWheelJoint2dPropertiesR Reflect(SetWheelJoint2dProperties instance)
    {
        return new SetWheelJoint2dPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetZ
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetZR Reflect(SetZ instance)
    {
        return new SetZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetZRandom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetZRandomR Reflect(SetZRandom instance)
    {
        return new SetZRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShadowGateColliderControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShadowGateColliderControlR Reflect(ShadowGateColliderControl instance)
    {
        return new ShadowGateColliderControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShakeAllGrass
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShakeAllGrassR Reflect(ShakeAllGrass instance)
    {
        return new ShakeAllGrassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShakePosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShakePositionR Reflect(ShakePosition instance)
    {
        return new ShakePositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShakePositionV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShakePositionV2R Reflect(ShakePositionV2 instance)
    {
        return new ShakePositionV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShineAnimSequence
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShineAnimSequenceR Reflect(ShineAnimSequence instance)
    {
        return new ShineAnimSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShopItemStats
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShopItemStatsR Reflect(ShopItemStats instance)
    {
        return new ShopItemStatsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShopMenuStock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShopMenuStockR Reflect(ShopMenuStock instance)
    {
        return new ShopMenuStockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShouldSerializeContractResolver
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShouldSerializeContractResolverR Reflect(ShouldSerializeContractResolver instance)
    {
        return new ShouldSerializeContractResolverR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossChallengeUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossChallengeUIR Reflect(ShowBossChallengeUI instance)
    {
        return new ShowBossChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossDoorChallengeUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossDoorChallengeUIR Reflect(ShowBossDoorChallengeUI instance)
    {
        return new ShowBossDoorChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossDoorLockedUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossDoorLockedUIR Reflect(ShowBossDoorLockedUI instance)
    {
        return new ShowBossDoorLockedUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossSummaryUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossSummaryUIR Reflect(ShowBossSummaryUI instance)
    {
        return new ShowBossSummaryUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowGodfinderIcon
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowGodfinderIconR Reflect(ShowGodfinderIcon instance)
    {
        return new ShowGodfinderIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowGodfinderIconQueued
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowGodfinderIconQueuedR Reflect(ShowGodfinderIconQueued instance)
    {
        return new ShowGodfinderIconQueuedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowOptions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowOptionsR Reflect(ShowOptions instance)
    {
        return new ShowOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowPromptMarker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowPromptMarkerR Reflect(ShowPromptMarker instance)
    {
        return new ShowPromptMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleFadeOut
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleFadeOutR Reflect(SimpleFadeOut instance)
    {
        return new SimpleFadeOutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleLogger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleLoggerR Reflect(SimpleLogger instance)
    {
        return new SimpleLoggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleRock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleRockR Reflect(SimpleRock instance)
    {
        return new SimpleRockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleSpriteFade
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleSpriteFadeR Reflect(SimpleSpriteFade instance)
    {
        return new SimpleSpriteFadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SingleContentLayout
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SingleContentLayoutR Reflect(SingleContentLayout instance)
    {
        return new SingleContentLayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SlashHitHandler
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SlashHitHandlerR Reflect(SlashHitHandler instance)
    {
        return new SlashHitHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Sleep
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SleepR Reflect(Sleep instance)
    {
        return new SleepR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Sleep2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Sleep2dR Reflect(Sleep2d instance)
    {
        return new Sleep2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SlopePlat
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SlopePlatR Reflect(SlopePlat instance)
    {
        return new SlopePlatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothFlyTo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothFlyToR Reflect(SmoothFlyTo instance)
    {
        return new SmoothFlyToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothFollowAction
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothFollowActionR Reflect(SmoothFollowAction instance)
    {
        return new SmoothFollowActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothFollowTarget2D
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothFollowTarget2DR Reflect(SmoothFollowTarget2D instance)
    {
        return new SmoothFollowTarget2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothLookAt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothLookAtR Reflect(SmoothLookAt instance)
    {
        return new SmoothLookAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothLookAt2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothLookAt2dR Reflect(SmoothLookAt2d instance)
    {
        return new SmoothLookAt2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothLookAtDirection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothLookAtDirectionR Reflect(SmoothLookAtDirection instance)
    {
        return new SmoothLookAtDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SnapshotOnActivation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SnapshotOnActivationR Reflect(SnapshotOnActivation instance)
    {
        return new SnapshotOnActivationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SnapToGround
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SnapToGroundR Reflect(SnapToGround instance)
    {
        return new SnapToGroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SoftLandEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SoftLandEffectR Reflect(SoftLandEffect instance)
    {
        return new SoftLandEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SoftMaskScript
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SoftMaskScriptR Reflect(SoftMaskScript instance)
    {
        return new SoftMaskScriptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SoulOrb
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SoulOrbR Reflect(SoulOrb instance)
    {
        return new SoulOrbR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpatterHoney
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpatterHoneyR Reflect(SpatterHoney instance)
    {
        return new SpatterHoneyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpatterOrange
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpatterOrangeR Reflect(SpatterOrange instance)
    {
        return new SpatterOrangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnableAudioSource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnableAudioSourceR Reflect(SpawnableAudioSource instance)
    {
        return new SpawnableAudioSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnBlood
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnBloodR Reflect(SpawnBlood instance)
    {
        return new SpawnBloodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnBloodTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnBloodTimeR Reflect(SpawnBloodTime instance)
    {
        return new SpawnBloodTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnFromPool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnFromPoolR Reflect(SpawnFromPool instance)
    {
        return new SpawnFromPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnFromPoolV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnFromPoolV2R Reflect(SpawnFromPoolV2 instance)
    {
        return new SpawnFromPoolV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnJarControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnJarControlR Reflect(SpawnJarControl instance)
    {
        return new SpawnJarControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnObjectFromGlobalPool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnObjectFromGlobalPoolR Reflect(SpawnObjectFromGlobalPool instance)
    {
        return new SpawnObjectFromGlobalPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnObjectFromGlobalPoolOverTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnObjectFromGlobalPoolOverTimeR Reflect(SpawnObjectFromGlobalPoolOverTime instance)
    {
        return new SpawnObjectFromGlobalPoolOverTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnObjectFromGlobalPoolOverTimeV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnObjectFromGlobalPoolOverTimeV2R Reflect(SpawnObjectFromGlobalPoolOverTimeV2 instance)
    {
        return new SpawnObjectFromGlobalPoolOverTimeV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsR Reflect(SpawnRandomObjects instance)
    {
        return new SpawnRandomObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsOverTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsOverTimeR Reflect(SpawnRandomObjectsOverTime instance)
    {
        return new SpawnRandomObjectsOverTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsOverTimeV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsOverTimeV2R Reflect(SpawnRandomObjectsOverTimeV2 instance)
    {
        return new SpawnRandomObjectsOverTimeV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsV2R Reflect(SpawnRandomObjectsV2 instance)
    {
        return new SpawnRandomObjectsV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsVelocity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsVelocityR Reflect(SpawnRandomObjectsVelocity instance)
    {
        return new SpawnRandomObjectsVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnStagMenu
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnStagMenuR Reflect(SpawnStagMenu instance)
    {
        return new SpawnStagMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpeedlinkStrikeMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpeedlinkStrikeMacUnityProfileR Reflect(SpeedlinkStrikeMacUnityProfile instance)
    {
        return new SpeedlinkStrikeMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpeedlinkStrikeWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpeedlinkStrikeWindowsUnityProfileR Reflect(SpeedlinkStrikeWindowsUnityProfile instance)
    {
        return new SpeedlinkStrikeWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpellFluke
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpellFlukeR Reflect(SpellFluke instance)
    {
        return new SpellFlukeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpellGetOrb
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpellGetOrbR Reflect(SpellGetOrb instance)
    {
        return new SpellGetOrbR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpinSelf
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpinSelfR Reflect(SpinSelf instance)
    {
        return new SpinSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpinSelfSimple
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpinSelfSimpleR Reflect(SpinSelfSimple instance)
    {
        return new SpinSelfSimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SplashAnimator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SplashAnimatorR Reflect(SplashAnimator instance)
    {
        return new SplashAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SplitTextToArrayList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SplitTextToArrayListR Reflect(SplitTextToArrayList instance)
    {
        return new SplitTextToArrayListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteChannel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteChannelR Reflect(SpriteChannel instance)
    {
        return new SpriteChannelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteChunk
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteChunkR Reflect(SpriteChunk instance)
    {
        return new SpriteChunkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteFadeMaterial
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteFadeMaterialR Reflect(SpriteFadeMaterial instance)
    {
        return new SpriteFadeMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteFadePulse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteFadePulseR Reflect(SpriteFadePulse instance)
    {
        return new SpriteFadePulseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteFlash
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteFlashR Reflect(SpriteFlash instance)
    {
        return new SpriteFlashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteTweenColorNeutral
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteTweenColorNeutralR Reflect(SpriteTweenColorNeutral instance)
    {
        return new SpriteTweenColorNeutralR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StagTravel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StagTravelR Reflect(StagTravel instance)
    {
        return new StagTravelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StalactiteControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StalactiteControlR Reflect(StalactiteControl instance)
    {
        return new StalactiteControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StandaloneLoadingSpinner
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StandaloneLoadingSpinnerR Reflect(StandaloneLoadingSpinner instance)
    {
        return new StandaloneLoadingSpinnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartAudioPlayerAfterHeroInPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartAudioPlayerAfterHeroInPositionR Reflect(StartAudioPlayerAfterHeroInPosition instance)
    {
        return new StartAudioPlayerAfterHeroInPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartCoroutine
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartCoroutineR Reflect(StartCoroutine instance)
    {
        return new StartCoroutineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartGameEventTrigger
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartGameEventTriggerR Reflect(StartGameEventTrigger instance)
    {
        return new StartGameEventTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartLocationServiceUpdates
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartLocationServiceUpdatesR Reflect(StartLocationServiceUpdates instance)
    {
        return new StartLocationServiceUpdatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartManagerR Reflect(StartManager instance)
    {
        return new StartManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartWalker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartWalkerR Reflect(StartWalker instance)
    {
        return new StartWalkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteamManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteamManagerR Reflect(SteamManager instance)
    {
        return new SteamManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteamOnlineSubsystem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteamOnlineSubsystemR Reflect(SteamOnlineSubsystem instance)
    {
        return new SteamOnlineSubsystemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteamWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteamWindowsNativeProfileR Reflect(SteamWindowsNativeProfile instance)
    {
        return new SteamWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeAndroidUnityProfileR Reflect(SteelSeriesFreeAndroidUnityProfile instance)
    {
        return new SteelSeriesFreeAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeLinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeLinuxUnityProfileR Reflect(SteelSeriesFreeLinuxUnityProfile instance)
    {
        return new SteelSeriesFreeLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeMacUnityProfileR Reflect(SteelSeriesFreeMacUnityProfile instance)
    {
        return new SteelSeriesFreeMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeWindowsUnityProfileR Reflect(SteelSeriesFreeWindowsUnityProfile instance)
    {
        return new SteelSeriesFreeWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelseriesNimbusMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelseriesNimbusMacNativeProfileR Reflect(SteelseriesNimbusMacNativeProfile instance)
    {
        return new SteelseriesNimbusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SteelseriesNimbusPlusMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelseriesNimbusPlusMacNativeProfileR Reflect(SteelseriesNimbusPlusMacNativeProfile instance)
    {
        return new SteelseriesNimbusPlusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SteelSeriesStratusXLAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesStratusXLAndroidUnityProfileR Reflect(SteelSeriesStratusXLAndroidUnityProfile instance)
    {
        return new SteelSeriesStratusXLAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SteelSeriesStratusXLWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesStratusXLWindowsUnityProfileR Reflect(SteelSeriesStratusXLWindowsUnityProfile instance)
    {
        return new SteelSeriesStratusXLWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteepSlope
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteepSlopeR Reflect(SteepSlope instance)
    {
        return new SteepSlopeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopAnimationR Reflect(StopAnimation instance)
    {
        return new StopAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopAnimatorsAtPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopAnimatorsAtPointR Reflect(StopAnimatorsAtPoint instance)
    {
        return new StopAnimatorsAtPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopLiftChain
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopLiftChainR Reflect(StopLiftChain instance)
    {
        return new StopLiftChainR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopLocationServiceUpdates
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopLocationServiceUpdatesR Reflect(StopLocationServiceUpdates instance)
    {
        return new StopLocationServiceUpdatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopParticleEmitter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopParticleEmitterR Reflect(StopParticleEmitter instance)
    {
        return new StopParticleEmitterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopParticleEmittersInChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopParticleEmittersInChildrenR Reflect(StopParticleEmittersInChildren instance)
    {
        return new StopParticleEmittersInChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopVibration
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopVibrationR Reflect(StopVibration instance)
    {
        return new StopVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopWalker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopWalkerR Reflect(StopWalker instance)
    {
        return new StopWalkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringChanged
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringChangedR Reflect(StringChanged instance)
    {
        return new StringChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringCompare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringCompareR Reflect(StringCompare instance)
    {
        return new StringCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringContains
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringContainsR Reflect(StringContains instance)
    {
        return new StringContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringEncrypt
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringEncryptR Reflect(StringEncrypt instance)
    {
        return new StringEncryptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringJoin
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringJoinR Reflect(StringJoin instance)
    {
        return new StringJoinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringReplace
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringReplaceR Reflect(StringReplace instance)
    {
        return new StringReplaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringSplit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringSplitR Reflect(StringSplit instance)
    {
        return new StringSplitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringSwitch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringSwitchR Reflect(StringSwitch instance)
    {
        return new StringSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SubtractHP
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SubtractHPR Reflect(SubtractHP instance)
    {
        return new SubtractHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwipeGestureEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwipeGestureEventR Reflect(SwipeGestureEvent instance)
    {
        return new SwipeGestureEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwitchOnPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwitchOnPlatformR Reflect(SwitchOnPlatform instance)
    {
        return new SwitchOnPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwitchSimpleInputDevice
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwitchSimpleInputDeviceR Reflect(SwitchSimpleInputDevice instance)
    {
        return new SwitchSimpleInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwitchSimpleInputDeviceManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwitchSimpleInputDeviceManagerR Reflect(SwitchSimpleInputDeviceManager instance)
    {
        return new SwitchSimpleInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeDamage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeDamageR Reflect(TakeDamage instance)
    {
        return new TakeDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeDamageProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeDamageProxyR Reflect(TakeDamageProxy instance)
    {
        return new TakeDamageProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeHealthProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeHealthProxyR Reflect(TakeHealthProxy instance)
    {
        return new TakeHealthProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeScreenshot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeScreenshotR Reflect(TakeScreenshot instance)
    {
        return new TakeScreenshotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TestInputManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TestInputManagerR Reflect(TestInputManager instance)
    {
        return new TestInputManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextContainer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextContainerR Reflect(TextContainer instance)
    {
        return new TextContainerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshOrderingLayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshOrderingLayerR Reflect(TextMeshOrderingLayer instance)
    {
        return new TextMeshOrderingLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshPro
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshProR Reflect(TextMeshPro instance)
    {
        return new TextMeshProR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshProUGUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshProUGUIR Reflect(TextMeshProUGUI instance)
    {
        return new TextMeshProUGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshSharpener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshSharpenerR Reflect(TextMeshSharpener instance)
    {
        return new TextMeshSharpenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Throbber
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrobberR Reflect(Throbber instance)
    {
        return new ThrobberR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustMasterFerrari430RacingWheelMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustMasterFerrari430RacingWheelMacNativeProfileR Reflect(
        ThrustMasterFerrari430RacingWheelMacNativeProfile instance)
    {
        return new ThrustMasterFerrari430RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustmasterFerrari458RacingWheelMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustmasterFerrari458RacingWheelMacNativeProfileR Reflect(
        ThrustmasterFerrari458RacingWheelMacNativeProfile instance)
    {
        return new ThrustmasterFerrari458RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustMasterFerrari458SpiderRacingWheelMacNativeProfileR Reflect(
        ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile instance)
    {
        return new ThrustMasterFerrari458SpiderRacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustmasterGPXControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustmasterGPXControllerMacNativeProfileR
        Reflect(ThrustmasterGPXControllerMacNativeProfile instance)
    {
        return new ThrustmasterGPXControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ThrustmasterTMXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustmasterTMXMacNativeProfileR Reflect(ThrustmasterTMXMacNativeProfile instance)
    {
        return new ThrustmasterTMXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ThrustmasterTXGIPMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustmasterTXGIPMacNativeProfileR Reflect(ThrustmasterTXGIPMacNativeProfile instance)
    {
        return new ThrustmasterTXGIPMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TileInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TileInfoR Reflect(TileInfo instance)
    {
        return new TileInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TimeLimitCheck
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TimeLimitCheckR Reflect(TimeLimitCheck instance)
    {
        return new TimeLimitCheckR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TimeLimitSet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TimeLimitSetR Reflect(TimeLimitSet instance)
    {
        return new TimeLimitSetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TimeScaleIndependentUpdate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TimeScaleIndependentUpdateR Reflect(TimeScaleIndependentUpdate instance)
    {
        return new TimeScaleIndependentUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TinkEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TinkEffectR Reflect(TinkEffect instance)
    {
        return new TinkEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TitleLogo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TitleLogoR Reflect(TitleLogo instance)
    {
        return new TitleLogoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dAnimatedSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dAnimatedSpriteR Reflect(tk2dAnimatedSprite instance)
    {
        return new tk2dAnimatedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dAssetPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dAssetPlatformR Reflect(tk2dAssetPlatform instance)
    {
        return new tk2dAssetPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dBatchedSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dBatchedSpriteR Reflect(tk2dBatchedSprite instance)
    {
        return new tk2dBatchedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dButtonR Reflect(tk2dButton instance)
    {
        return new tk2dButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCamera
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraR Reflect(tk2dCamera instance)
    {
        return new tk2dCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCameraAnchor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraAnchorR Reflect(tk2dCameraAnchor instance)
    {
        return new tk2dCameraAnchorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCameraResolutionOverride
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraResolutionOverrideR Reflect(tk2dCameraResolutionOverride instance)
    {
        return new tk2dCameraResolutionOverrideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCameraSettings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraSettingsR Reflect(tk2dCameraSettings instance)
    {
        return new tk2dCameraSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dClippedSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dClippedSpriteR Reflect(tk2dClippedSprite instance)
    {
        return new tk2dClippedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCollider2DData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCollider2DDataR Reflect(tk2dCollider2DData instance)
    {
        return new tk2dCollider2DDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dEditorSpriteDataUnloader
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dEditorSpriteDataUnloaderR Reflect(tk2dEditorSpriteDataUnloader instance)
    {
        return new tk2dEditorSpriteDataUnloaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFont
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontR Reflect(tk2dFont instance)
    {
        return new tk2dFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFontChar
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontCharR Reflect(tk2dFontChar instance)
    {
        return new tk2dFontCharR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFontData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontDataR Reflect(tk2dFontData instance)
    {
        return new tk2dFontDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFontKerning
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontKerningR Reflect(tk2dFontKerning instance)
    {
        return new tk2dFontKerningR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dIsPlaying
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dIsPlayingR Reflect(Tk2dIsPlaying instance)
    {
        return new Tk2dIsPlayingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dLinkedSpriteCollection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dLinkedSpriteCollectionR Reflect(tk2dLinkedSpriteCollection instance)
    {
        return new tk2dLinkedSpriteCollectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPauseAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPauseAnimationR Reflect(Tk2dPauseAnimation instance)
    {
        return new Tk2dPauseAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dPixelPerfectHelper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dPixelPerfectHelperR Reflect(tk2dPixelPerfectHelper instance)
    {
        return new tk2dPixelPerfectHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayAnimationR Reflect(Tk2dPlayAnimation instance)
    {
        return new Tk2dPlayAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayAnimationV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayAnimationV2R Reflect(Tk2dPlayAnimationV2 instance)
    {
        return new Tk2dPlayAnimationV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayAnimationWithEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayAnimationWithEventsR Reflect(Tk2dPlayAnimationWithEvents instance)
    {
        return new Tk2dPlayAnimationWithEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayFrame
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayFrameR Reflect(Tk2dPlayFrame instance)
    {
        return new Tk2dPlayFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dResource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dResourceR Reflect(tk2dResource instance)
    {
        return new tk2dResourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dResourceTocEntry
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dResourceTocEntryR Reflect(tk2dResourceTocEntry instance)
    {
        return new tk2dResourceTocEntryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dResumeAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dResumeAnimationR Reflect(Tk2dResumeAnimation instance)
    {
        return new Tk2dResumeAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSetAnimationFrameRate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSetAnimationFrameRateR Reflect(Tk2dSetAnimationFrameRate instance)
    {
        return new Tk2dSetAnimationFrameRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSlicedSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSlicedSpriteR Reflect(tk2dSlicedSprite instance)
    {
        return new tk2dSlicedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteR Reflect(tk2dSprite instance)
    {
        return new tk2dSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimationR Reflect(tk2dSpriteAnimation instance)
    {
        return new tk2dSpriteAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimationClip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimationClipR Reflect(tk2dSpriteAnimationClip instance)
    {
        return new tk2dSpriteAnimationClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimationFrame
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimationFrameR Reflect(tk2dSpriteAnimationFrame instance)
    {
        return new tk2dSpriteAnimationFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimatorR Reflect(tk2dSpriteAnimator instance)
    {
        return new tk2dSpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAttachPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAttachPointR Reflect(tk2dSpriteAttachPoint instance)
    {
        return new tk2dSpriteAttachPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionR Reflect(tk2dSpriteCollection instance)
    {
        return new tk2dSpriteCollectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionDataR Reflect(tk2dSpriteCollectionData instance)
    {
        return new tk2dSpriteCollectionDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionDefault
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionDefaultR Reflect(tk2dSpriteCollectionDefault instance)
    {
        return new tk2dSpriteCollectionDefaultR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionDefinition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionDefinitionR Reflect(tk2dSpriteCollectionDefinition instance)
    {
        return new tk2dSpriteCollectionDefinitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionFont
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionFontR Reflect(tk2dSpriteCollectionFont instance)
    {
        return new tk2dSpriteCollectionFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionPlatformR Reflect(tk2dSpriteCollectionPlatform instance)
    {
        return new tk2dSpriteCollectionPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionSize
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionSizeR Reflect(tk2dSpriteCollectionSize instance)
    {
        return new tk2dSpriteCollectionSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteColliderDefinition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteColliderDefinitionR Reflect(tk2dSpriteColliderDefinition instance)
    {
        return new tk2dSpriteColliderDefinitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteColliderIsland
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteColliderIslandR Reflect(tk2dSpriteColliderIsland instance)
    {
        return new tk2dSpriteColliderIslandR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteDefinition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteDefinitionR Reflect(tk2dSpriteDefinition instance)
    {
        return new tk2dSpriteDefinitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteFromTexture
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteFromTextureR Reflect(tk2dSpriteFromTexture instance)
    {
        return new tk2dSpriteFromTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetColorR Reflect(Tk2dSpriteGetColor instance)
    {
        return new Tk2dSpriteGetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetId
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetIdR Reflect(Tk2dSpriteGetId instance)
    {
        return new Tk2dSpriteGetIdR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetPixelPerfect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetPixelPerfectR Reflect(Tk2dSpriteGetPixelPerfect instance)
    {
        return new Tk2dSpriteGetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetScaleR Reflect(Tk2dSpriteGetScale instance)
    {
        return new Tk2dSpriteGetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteMakePixelPerfect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteMakePixelPerfectR Reflect(Tk2dSpriteMakePixelPerfect instance)
    {
        return new Tk2dSpriteMakePixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetColorR Reflect(Tk2dSpriteSetColor instance)
    {
        return new Tk2dSpriteSetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetId
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetIdR Reflect(Tk2dSpriteSetId instance)
    {
        return new Tk2dSpriteSetIdR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetIdRandom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetIdRandomR Reflect(Tk2dSpriteSetIdRandom instance)
    {
        return new Tk2dSpriteSetIdRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetPixelPerfect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetPixelPerfectR Reflect(Tk2dSpriteSetPixelPerfect instance)
    {
        return new Tk2dSpriteSetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetScaleR Reflect(Tk2dSpriteSetScale instance)
    {
        return new Tk2dSpriteSetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteSheetSource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteSheetSourceR Reflect(tk2dSpriteSheetSource instance)
    {
        return new tk2dSpriteSheetSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteTweenColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteTweenColorR Reflect(Tk2dSpriteTweenColor instance)
    {
        return new Tk2dSpriteTweenColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dStaticSpriteBatcher
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dStaticSpriteBatcherR Reflect(tk2dStaticSpriteBatcher instance)
    {
        return new tk2dStaticSpriteBatcherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dStopAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dStopAnimationR Reflect(Tk2dStopAnimation instance)
    {
        return new Tk2dStopAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSystem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSystemR Reflect(tk2dSystem instance)
    {
        return new tk2dSystemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTextMesh
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTextMeshR Reflect(tk2dTextMesh instance)
    {
        return new tk2dTextMeshR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshCommit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshCommitR Reflect(Tk2dTextMeshCommit instance)
    {
        return new Tk2dTextMeshCommitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTextMeshData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTextMeshDataR Reflect(tk2dTextMeshData instance)
    {
        return new tk2dTextMeshDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetAnchor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetAnchorR Reflect(Tk2dTextMeshGetAnchor instance)
    {
        return new Tk2dTextMeshGetAnchorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetColors
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetColorsR Reflect(Tk2dTextMeshGetColors instance)
    {
        return new Tk2dTextMeshGetColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetFont
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetFontR Reflect(Tk2dTextMeshGetFont instance)
    {
        return new Tk2dTextMeshGetFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetInlineStyling
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetInlineStylingR Reflect(Tk2dTextMeshGetInlineStyling instance)
    {
        return new Tk2dTextMeshGetInlineStylingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     Tk2dTextMeshGetInlineStylingIsAvailable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetInlineStylingIsAvailableR Reflect(Tk2dTextMeshGetInlineStylingIsAvailable instance)
    {
        return new Tk2dTextMeshGetInlineStylingIsAvailableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetMaxChars
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetMaxCharsR Reflect(Tk2dTextMeshGetMaxChars instance)
    {
        return new Tk2dTextMeshGetMaxCharsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetNumDrawnCharacters
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetNumDrawnCharactersR Reflect(Tk2dTextMeshGetNumDrawnCharacters instance)
    {
        return new Tk2dTextMeshGetNumDrawnCharactersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetPixelPerfect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetPixelPerfectR Reflect(Tk2dTextMeshGetPixelPerfect instance)
    {
        return new Tk2dTextMeshGetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetPropertiesR Reflect(Tk2dTextMeshGetProperties instance)
    {
        return new Tk2dTextMeshGetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetScaleR Reflect(Tk2dTextMeshGetScale instance)
    {
        return new Tk2dTextMeshGetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetTextR Reflect(Tk2dTextMeshGetText instance)
    {
        return new Tk2dTextMeshGetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetTextureGradient
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetTextureGradientR Reflect(Tk2dTextMeshGetTextureGradient instance)
    {
        return new Tk2dTextMeshGetTextureGradientR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshMakePixelPerfect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshMakePixelPerfectR Reflect(Tk2dTextMeshMakePixelPerfect instance)
    {
        return new Tk2dTextMeshMakePixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetAnchor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetAnchorR Reflect(Tk2dTextMeshSetAnchor instance)
    {
        return new Tk2dTextMeshSetAnchorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetColors
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetColorsR Reflect(Tk2dTextMeshSetColors instance)
    {
        return new Tk2dTextMeshSetColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetFont
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetFontR Reflect(Tk2dTextMeshSetFont instance)
    {
        return new Tk2dTextMeshSetFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetInlineStyling
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetInlineStylingR Reflect(Tk2dTextMeshSetInlineStyling instance)
    {
        return new Tk2dTextMeshSetInlineStylingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetMaxChars
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetMaxCharsR Reflect(Tk2dTextMeshSetMaxChars instance)
    {
        return new Tk2dTextMeshSetMaxCharsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetPixelPerfect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetPixelPerfectR Reflect(Tk2dTextMeshSetPixelPerfect instance)
    {
        return new Tk2dTextMeshSetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetPropertiesR Reflect(Tk2dTextMeshSetProperties instance)
    {
        return new Tk2dTextMeshSetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetScale
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetScaleR Reflect(Tk2dTextMeshSetScale instance)
    {
        return new Tk2dTextMeshSetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetTextR Reflect(Tk2dTextMeshSetText instance)
    {
        return new Tk2dTextMeshSetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetTextureGradient
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetTextureGradientR Reflect(Tk2dTextMeshSetTextureGradient instance)
    {
        return new Tk2dTextMeshSetTextureGradientR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTiledSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTiledSpriteR Reflect(tk2dTiledSprite instance)
    {
        return new tk2dTiledSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTileMap
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTileMapR Reflect(tk2dTileMap instance)
    {
        return new tk2dTileMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTileMapData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTileMapDataR Reflect(tk2dTileMapData instance)
    {
        return new tk2dTileMapDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIAudioManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIAudioManagerR Reflect(tk2dUIAudioManager instance)
    {
        return new tk2dUIAudioManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUICamera
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUICameraR Reflect(tk2dUICamera instance)
    {
        return new tk2dUICameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIDragItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIDragItemR Reflect(tk2dUIDragItem instance)
    {
        return new tk2dUIDragItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIDropDownItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIDropDownItemR Reflect(tk2dUIDropDownItem instance)
    {
        return new tk2dUIDropDownItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIDropDownMenu
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIDropDownMenuR Reflect(tk2dUIDropDownMenu instance)
    {
        return new tk2dUIDropDownMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIHoverItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIHoverItemR Reflect(tk2dUIHoverItem instance)
    {
        return new tk2dUIHoverItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIItemR Reflect(tk2dUIItem instance)
    {
        return new tk2dUIItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUILayout
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUILayoutR Reflect(tk2dUILayout instance)
    {
        return new tk2dUILayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUILayoutContainerSizer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUILayoutContainerSizerR Reflect(tk2dUILayoutContainerSizer instance)
    {
        return new tk2dUILayoutContainerSizerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUILayoutItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUILayoutItemR Reflect(tk2dUILayoutItem instance)
    {
        return new tk2dUILayoutItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIManagerR Reflect(tk2dUIManager instance)
    {
        return new tk2dUIManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIMask
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIMaskR Reflect(tk2dUIMask instance)
    {
        return new tk2dUIMaskR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIMultiStateToggleButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIMultiStateToggleButtonR Reflect(tk2dUIMultiStateToggleButton instance)
    {
        return new tk2dUIMultiStateToggleButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIProgressBar
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIProgressBarR Reflect(tk2dUIProgressBar instance)
    {
        return new tk2dUIProgressBarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIScrollableArea
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIScrollableAreaR Reflect(tk2dUIScrollableArea instance)
    {
        return new tk2dUIScrollableAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIScrollbar
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIScrollbarR Reflect(tk2dUIScrollbar instance)
    {
        return new tk2dUIScrollbarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUISoundItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUISoundItemR Reflect(tk2dUISoundItem instance)
    {
        return new tk2dUISoundItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUISpriteAnimator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUISpriteAnimatorR Reflect(tk2dUISpriteAnimator instance)
    {
        return new tk2dUISpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUITextInput
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUITextInputR Reflect(tk2dUITextInput instance)
    {
        return new tk2dUITextInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIToggleButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIToggleButtonR Reflect(tk2dUIToggleButton instance)
    {
        return new tk2dUIToggleButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIToggleButtonGroup
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIToggleButtonGroupR Reflect(tk2dUIToggleButtonGroup instance)
    {
        return new tk2dUIToggleButtonGroupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIToggleControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIToggleControlR Reflect(tk2dUIToggleControl instance)
    {
        return new tk2dUIToggleControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUITweenItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUITweenItemR Reflect(tk2dUITweenItem instance)
    {
        return new tk2dUITweenItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIUpDownButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIUpDownButtonR Reflect(tk2dUIUpDownButton instance)
    {
        return new tk2dUIUpDownButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIUpDownHoverButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIUpDownHoverButtonR Reflect(tk2dUIUpDownHoverButton instance)
    {
        return new tk2dUIUpDownHoverButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUpdateManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUpdateManagerR Reflect(tk2dUpdateManager instance)
    {
        return new tk2dUpdateManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dWatchAnimationEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dWatchAnimationEventsR Reflect(Tk2dWatchAnimationEvents instance)
    {
        return new Tk2dWatchAnimationEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Asset
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_AssetR Reflect(TMP_Asset instance)
    {
        return new TMP_AssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_ColorGradient
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_ColorGradientR Reflect(TMP_ColorGradient instance)
    {
        return new TMP_ColorGradientR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Dropdown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_DropdownR Reflect(TMP_Dropdown instance)
    {
        return new TMP_DropdownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_FontAsset
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_FontAssetR Reflect(TMP_FontAsset instance)
    {
        return new TMP_FontAssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Glyph
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_GlyphR Reflect(TMP_Glyph instance)
    {
        return new TMP_GlyphR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_InputField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_InputFieldR Reflect(TMP_InputField instance)
    {
        return new TMP_InputFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Settings
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SettingsR Reflect(TMP_Settings instance)
    {
        return new TMP_SettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Sprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SpriteR Reflect(TMP_Sprite instance)
    {
        return new TMP_SpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_SpriteAsset
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SpriteAssetR Reflect(TMP_SpriteAsset instance)
    {
        return new TMP_SpriteAssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Style
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_StyleR Reflect(TMP_Style instance)
    {
        return new TMP_StyleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_StyleSheet
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_StyleSheetR Reflect(TMP_StyleSheet instance)
    {
        return new TMP_StyleSheetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_SubMesh
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SubMeshR Reflect(TMP_SubMesh instance)
    {
        return new TMP_SubMeshR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_SubMeshUI
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SubMeshUIR Reflect(TMP_SubMeshUI instance)
    {
        return new TMP_SubMeshUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Text
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_TextR Reflect(TMP_Text instance)
    {
        return new TMP_TextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_TextElement
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_TextElementR Reflect(TMP_TextElement instance)
    {
        return new TMP_TextElementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_TextInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_TextInfoR Reflect(TMP_TextInfo instance)
    {
        return new TMP_TextInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_UpdateManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_UpdateManagerR Reflect(TMP_UpdateManager instance)
    {
        return new TMP_UpdateManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_UpdateRegistry
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_UpdateRegistryR Reflect(TMP_UpdateRegistry instance)
    {
        return new TMP_UpdateRegistryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Touch
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchR Reflect(Touch instance)
    {
        return new TouchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchButtonControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchButtonControlR Reflect(TouchButtonControl instance)
    {
        return new TouchButtonControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchEventR Reflect(TouchEvent instance)
    {
        return new TouchEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchInputDevice
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchInputDeviceR Reflect(TouchInputDevice instance)
    {
        return new TouchInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchManagerR Reflect(TouchManager instance)
    {
        return new TouchManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchObject2dEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchObject2dEventR Reflect(TouchObject2dEvent instance)
    {
        return new TouchObject2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchObjectEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchObjectEventR Reflect(TouchObjectEvent instance)
    {
        return new TouchObjectEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchPool
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchPoolR Reflect(TouchPool instance)
    {
        return new TouchPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchShake
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchShakeR Reflect(TouchShake instance)
    {
        return new TouchShakeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchSpriteR Reflect(TouchSprite instance)
    {
        return new TouchSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchStickControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchStickControlR Reflect(TouchStickControl instance)
    {
        return new TouchStickControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchSwipeControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchSwipeControlR Reflect(TouchSwipeControl instance)
    {
        return new TouchSwipeControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchTrackControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchTrackControlR Reflect(TouchTrackControl instance)
    {
        return new TouchTrackControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TownGrass
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TownGrassR Reflect(TownGrass instance)
    {
        return new TownGrassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackMouseMovement
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackMouseMovementR Reflect(TrackMouseMovement instance)
    {
        return new TrackMouseMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackSpawnedEnemies
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackSpawnedEnemiesR Reflect(TrackSpawnedEnemies instance)
    {
        return new TrackSpawnedEnemiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackSpawnedEnemiesAdd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackSpawnedEnemiesAddR Reflect(TrackSpawnedEnemiesAdd instance)
    {
        return new TrackSpawnedEnemiesAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackSpawnedEnemiesGetInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackSpawnedEnemiesGetInfoR Reflect(TrackSpawnedEnemiesGetInfo instance)
    {
        return new TrackSpawnedEnemiesGetInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackTriggerObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackTriggerObjectsR Reflect(TrackTriggerObjects instance)
    {
        return new TrackTriggerObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransformDirection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransformDirectionR Reflect(TransformDirection instance)
    {
        return new TransformDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransformInputToWorldSpace
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransformInputToWorldSpaceR Reflect(TransformInputToWorldSpace instance)
    {
        return new TransformInputToWorldSpaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransformPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransformPointR Reflect(TransformPoint instance)
    {
        return new TransformPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransitionPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransitionPointR Reflect(TransitionPoint instance)
    {
        return new TransitionPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransitionToAudioSnapshot
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransitionToAudioSnapshotR Reflect(TransitionToAudioSnapshot instance)
    {
        return new TransitionToAudioSnapshotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Translate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TranslateR Reflect(Translate instance)
    {
        return new TranslateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TranslateContinuous
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TranslateContinuousR Reflect(TranslateContinuous instance)
    {
        return new TranslateContinuousR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TranslateV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TranslateV2R Reflect(TranslateV2 instance)
    {
        return new TranslateV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Trigger2dEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Trigger2dEventR Reflect(Trigger2dEvent instance)
    {
        return new Trigger2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Trigger2dEventLayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Trigger2dEventLayerR Reflect(Trigger2dEventLayer instance)
    {
        return new Trigger2dEventLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Trigger2dEventToParent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Trigger2dEventToParentR Reflect(Trigger2dEventToParent instance)
    {
        return new Trigger2dEventToParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerActivateComponent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerActivateComponentR Reflect(TriggerActivateComponent instance)
    {
        return new TriggerActivateComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerActivateGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerActivateGameObjectR Reflect(TriggerActivateGameObject instance)
    {
        return new TriggerActivateGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEnterEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEnterEventR Reflect(TriggerEnterEvent instance)
    {
        return new TriggerEnterEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEnterEventSubscribe
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEnterEventSubscribeR Reflect(TriggerEnterEventSubscribe instance)
    {
        return new TriggerEnterEventSubscribeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEnterSendMessage
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEnterSendMessageR Reflect(TriggerEnterSendMessage instance)
    {
        return new TriggerEnterSendMessageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEventR Reflect(TriggerEvent instance)
    {
        return new TriggerEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     TrustPredatorJoystickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrustPredatorJoystickMacNativeProfileR Reflect(TrustPredatorJoystickMacNativeProfile instance)
    {
        return new TrustPredatorJoystickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TSZPelicanControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TSZPelicanControllerMacNativeProfileR Reflect(TSZPelicanControllerMacNativeProfile instance)
    {
        return new TSZPelicanControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Turret
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TurretR Reflect(Turret instance)
    {
        return new TurretR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TutorialEntryPauser
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TutorialEntryPauserR Reflect(TutorialEntryPauser instance)
    {
        return new TutorialEntryPauserR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TwoAxisInputControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TwoAxisInputControlR Reflect(TwoAxisInputControl instance)
    {
        return new TwoAxisInputControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiButtonOnClickEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiButtonOnClickEventR Reflect(uGuiButtonOnClickEvent instance)
    {
        return new uGuiButtonOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiCanvasEnableRaycastFilter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiCanvasEnableRaycastFilterR Reflect(uGuiCanvasEnableRaycastFilter instance)
    {
        return new uGuiCanvasEnableRaycastFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGetColorBlock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGetColorBlockR Reflect(uGuiGetColorBlock instance)
    {
        return new uGuiGetColorBlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGetIsInteractable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGetIsInteractableR Reflect(uGuiGetIsInteractable instance)
    {
        return new uGuiGetIsInteractableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGraphicGetColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGraphicGetColorR Reflect(uGuiGraphicGetColor instance)
    {
        return new uGuiGraphicGetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGraphicSetColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGraphicSetColorR Reflect(uGuiGraphicSetColor instance)
    {
        return new uGuiGraphicSetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiImageGetSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiImageGetSpriteR Reflect(uGuiImageGetSprite instance)
    {
        return new uGuiImageGetSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiImageSetSprite
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiImageSetSpriteR Reflect(uGuiImageSetSprite instance)
    {
        return new uGuiImageSetSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldActivate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldActivateR Reflect(uGuiInputFieldActivate instance)
    {
        return new uGuiInputFieldActivateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldDeactivate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldDeactivateR Reflect(uGuiInputFieldDeactivate instance)
    {
        return new uGuiInputFieldDeactivateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetCaretBlinkRate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetCaretBlinkRateR Reflect(uGuiInputFieldGetCaretBlinkRate instance)
    {
        return new uGuiInputFieldGetCaretBlinkRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetCharacterLimit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetCharacterLimitR Reflect(uGuiInputFieldGetCharacterLimit instance)
    {
        return new uGuiInputFieldGetCharacterLimitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetHideMobileInput
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetHideMobileInputR Reflect(uGuiInputFieldGetHideMobileInput instance)
    {
        return new uGuiInputFieldGetHideMobileInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetPlaceHolder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetPlaceHolderR Reflect(uGuiInputFieldGetPlaceHolder instance)
    {
        return new uGuiInputFieldGetPlaceHolderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetSelectionColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetSelectionColorR Reflect(uGuiInputFieldGetSelectionColor instance)
    {
        return new uGuiInputFieldGetSelectionColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetTextR Reflect(uGuiInputFieldGetText instance)
    {
        return new uGuiInputFieldGetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldMoveCaretToTextEnd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldMoveCaretToTextEndR Reflect(uGuiInputFieldMoveCaretToTextEnd instance)
    {
        return new uGuiInputFieldMoveCaretToTextEndR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldMoveCaretToTextStart
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldMoveCaretToTextStartR Reflect(uGuiInputFieldMoveCaretToTextStart instance)
    {
        return new uGuiInputFieldMoveCaretToTextStartR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldOnEndEditEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldOnEndEditEventR Reflect(uGuiInputFieldOnEndEditEvent instance)
    {
        return new uGuiInputFieldOnEndEditEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldOnValueChangeEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldOnValueChangeEventR Reflect(uGuiInputFieldOnValueChangeEvent instance)
    {
        return new uGuiInputFieldOnValueChangeEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldRebuild
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldRebuildR Reflect(uGuiInputFieldRebuild instance)
    {
        return new uGuiInputFieldRebuildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldScreenToLocal
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldScreenToLocalR Reflect(uGuiInputFieldScreenToLocal instance)
    {
        return new uGuiInputFieldScreenToLocalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetAsterixChar
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetAsterixCharR Reflect(uGuiInputFieldSetAsterixChar instance)
    {
        return new uGuiInputFieldSetAsterixCharR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputfieldSetCaretBlinkRate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputfieldSetCaretBlinkRateR Reflect(uGuiInputfieldSetCaretBlinkRate instance)
    {
        return new uGuiInputfieldSetCaretBlinkRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetCharacterLimit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetCharacterLimitR Reflect(uGuiInputFieldSetCharacterLimit instance)
    {
        return new uGuiInputFieldSetCharacterLimitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetHideMobileInput
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetHideMobileInputR Reflect(uGuiInputFieldSetHideMobileInput instance)
    {
        return new uGuiInputFieldSetHideMobileInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetPlaceHolder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetPlaceHolderR Reflect(uGuiInputFieldSetPlaceHolder instance)
    {
        return new uGuiInputFieldSetPlaceHolderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetSelectionColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetSelectionColorR Reflect(uGuiInputFieldSetSelectionColor instance)
    {
        return new uGuiInputFieldSetSelectionColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetTextR Reflect(uGuiInputFieldSetText instance)
    {
        return new uGuiInputFieldSetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiLayoutElementGetValues
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiLayoutElementGetValuesR Reflect(uGuiLayoutElementGetValues instance)
    {
        return new uGuiLayoutElementGetValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiLayoutElementSetValues
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiLayoutElementSetValuesR Reflect(uGuiLayoutElementSetValues instance)
    {
        return new uGuiLayoutElementSetValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationExplicitGetProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationExplicitGetPropertiesR Reflect(uGuiNavigationExplicitGetProperties instance)
    {
        return new uGuiNavigationExplicitGetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationExplicitSetProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationExplicitSetPropertiesR Reflect(uGuiNavigationExplicitSetProperties instance)
    {
        return new uGuiNavigationExplicitSetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationGetMode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationGetModeR Reflect(uGuiNavigationGetMode instance)
    {
        return new uGuiNavigationGetModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationSetMode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationSetModeR Reflect(uGuiNavigationSetMode instance)
    {
        return new uGuiNavigationSetModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiRawImageSetTexture
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiRawImageSetTextureR Reflect(uGuiRawImageSetTexture instance)
    {
        return new uGuiRawImageSetTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarGetValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarGetValueR Reflect(uGuiScrollbarGetValue instance)
    {
        return new uGuiScrollbarGetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarOnClickEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarOnClickEventR Reflect(uGuiScrollbarOnClickEvent instance)
    {
        return new uGuiScrollbarOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetDirection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetDirectionR Reflect(uGuiScrollbarSetDirection instance)
    {
        return new uGuiScrollbarSetDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetNumberOfSteps
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetNumberOfStepsR Reflect(uGuiScrollbarSetNumberOfSteps instance)
    {
        return new uGuiScrollbarSetNumberOfStepsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetSize
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetSizeR Reflect(uGuiScrollbarSetSize instance)
    {
        return new uGuiScrollbarSetSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetValueR Reflect(uGuiScrollbarSetValue instance)
    {
        return new uGuiScrollbarSetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetAnimationTriggers
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetAnimationTriggersR Reflect(uGuiSetAnimationTriggers instance)
    {
        return new uGuiSetAnimationTriggersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetButtonNormalColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetButtonNormalColorR Reflect(uGuiSetButtonNormalColor instance)
    {
        return new uGuiSetButtonNormalColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetColorBlock
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetColorBlockR Reflect(uGuiSetColorBlock instance)
    {
        return new uGuiSetColorBlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetIsInteractable
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetIsInteractableR Reflect(uGuiSetIsInteractable instance)
    {
        return new uGuiSetIsInteractableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetMinMax
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetMinMaxR Reflect(uGuiSliderGetMinMax instance)
    {
        return new uGuiSliderGetMinMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetNormalizedValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetNormalizedValueR Reflect(uGuiSliderGetNormalizedValue instance)
    {
        return new uGuiSliderGetNormalizedValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetValueR Reflect(uGuiSliderGetValue instance)
    {
        return new uGuiSliderGetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetWholeNumbers
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetWholeNumbersR Reflect(uGuiSliderGetWholeNumbers instance)
    {
        return new uGuiSliderGetWholeNumbersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderOnClickEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderOnClickEventR Reflect(uGuiSliderOnClickEvent instance)
    {
        return new uGuiSliderOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetDirection
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetDirectionR Reflect(uGuiSliderSetDirection instance)
    {
        return new uGuiSliderSetDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetIsOn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetIsOnR Reflect(uGuiSliderSetIsOn instance)
    {
        return new uGuiSliderSetIsOnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetMinMax
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetMinMaxR Reflect(uGuiSliderSetMinMax instance)
    {
        return new uGuiSliderSetMinMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetNormalizedValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetNormalizedValueR Reflect(uGuiSliderSetNormalizedValue instance)
    {
        return new uGuiSliderSetNormalizedValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetValueR Reflect(uGuiSliderSetValue instance)
    {
        return new uGuiSliderSetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetWholeNumbers
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetWholeNumbersR Reflect(uGuiSliderSetWholeNumbers instance)
    {
        return new uGuiSliderSetWholeNumbersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTextGetText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTextGetTextR Reflect(uGuiTextGetText instance)
    {
        return new uGuiTextGetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTextSetText
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTextSetTextR Reflect(uGuiTextSetText instance)
    {
        return new uGuiTextSetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiToggleGetIsOn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiToggleGetIsOnR Reflect(uGuiToggleGetIsOn instance)
    {
        return new uGuiToggleGetIsOnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiToggleOnClickEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiToggleOnClickEventR Reflect(uGuiToggleOnClickEvent instance)
    {
        return new uGuiToggleOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTransitionGetType
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTransitionGetTypeR Reflect(uGuiTransitionGetType instance)
    {
        return new uGuiTransitionGetTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTransitionSetType
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTransitionSetTypeR Reflect(uGuiTransitionSetType instance)
    {
        return new uGuiTransitionSetTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIAnimationEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIAnimationEventsR Reflect(UIAnimationEvents instance)
    {
        return new UIAnimationEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIBlendMode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIBlendModeR Reflect(UIBlendMode instance)
    {
        return new UIBlendModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIButtonSkins
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIButtonSkinsR Reflect(UIButtonSkins instance)
    {
        return new UIButtonSkinsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIWindowBase
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIWindowBaseR Reflect(UIWindowBase instance)
    {
        return new UIWindowBaseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnboldIfCJK
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnboldIfCJKR Reflect(UnboldIfCJK instance)
    {
        return new UnboldIfCJKR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDevice
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceR Reflect(UnityInputDevice instance)
    {
        return new UnityInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDeviceManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceManagerR Reflect(UnityInputDeviceManager instance)
    {
        return new UnityInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDeviceProfileAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceProfileAttributeR Reflect(UnityInputDeviceProfileAttribute instance)
    {
        return new UnityInputDeviceProfileAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDeviceProfileList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceProfileListR Reflect(UnityInputDeviceProfileList instance)
    {
        return new UnityInputDeviceProfileListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityKeyboardProvider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityKeyboardProviderR Reflect(UnityKeyboardProvider instance)
    {
        return new UnityKeyboardProviderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityMouseProvider
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityMouseProviderR Reflect(UnityMouseProvider instance)
    {
        return new UnityMouseProviderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnknownDeviceBindingSource
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnknownDeviceBindingSourceR Reflect(UnknownDeviceBindingSource instance)
    {
        return new UnknownDeviceBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnknownDeviceBindingSourceListener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnknownDeviceBindingSourceListenerR Reflect(UnknownDeviceBindingSourceListener instance)
    {
        return new UnknownDeviceBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnlockGGMode
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnlockGGModeR Reflect(UnlockGGMode instance)
    {
        return new UnlockGGModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnsupportedVibrationEmission
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnsupportedVibrationEmissionR Reflect(UnsupportedVibrationEmission instance)
    {
        return new UnsupportedVibrationEmissionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UpdateHelper
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UpdateHelperR Reflect(UpdateHelper instance)
    {
        return new UpdateHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UpdateTextWithSliderValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UpdateTextWithSliderValueR Reflect(UpdateTextWithSliderValue instance)
    {
        return new UpdateTextWithSliderValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UseGravity
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UseGravityR Reflect(UseGravity instance)
    {
        return new UseGravityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UseGUILayout
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UseGUILayoutR Reflect(UseGUILayout instance)
    {
        return new UseGUILayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ValveStreamingWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ValveStreamingWindowsUnityProfileR Reflect(ValveStreamingWindowsUnityProfile instance)
    {
        return new ValveStreamingWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector2Converter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector2ConverterR Reflect(Vector2Converter instance)
    {
        return new Vector2ConverterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector2Multiply
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector2MultiplyR Reflect(Vector2Multiply instance)
    {
        return new Vector2MultiplyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Add
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3AddR Reflect(Vector3Add instance)
    {
        return new Vector3AddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3AddXYZ
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3AddXYZR Reflect(Vector3AddXYZ instance)
    {
        return new Vector3AddXYZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3ClampMagnitude
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3ClampMagnitudeR Reflect(Vector3ClampMagnitude instance)
    {
        return new Vector3ClampMagnitudeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Compare
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3CompareR Reflect(Vector3Compare instance)
    {
        return new Vector3CompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Converter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3ConverterR Reflect(Vector3Converter instance)
    {
        return new Vector3ConverterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3HighPassFilter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3HighPassFilterR Reflect(Vector3HighPassFilter instance)
    {
        return new Vector3HighPassFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Interpolate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3InterpolateR Reflect(Vector3Interpolate instance)
    {
        return new Vector3InterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Invert
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3InvertR Reflect(Vector3Invert instance)
    {
        return new Vector3InvertR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Lerp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3LerpR Reflect(Vector3Lerp instance)
    {
        return new Vector3LerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3LowPassFilter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3LowPassFilterR Reflect(Vector3LowPassFilter instance)
    {
        return new Vector3LowPassFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Multiply
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3MultiplyR Reflect(Vector3Multiply instance)
    {
        return new Vector3MultiplyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Normalize
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3NormalizeR Reflect(Vector3Normalize instance)
    {
        return new Vector3NormalizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Operator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3OperatorR Reflect(Vector3Operator instance)
    {
        return new Vector3OperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3PerSecond
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3PerSecondR Reflect(Vector3PerSecond instance)
    {
        return new Vector3PerSecondR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3RotateTowards
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3RotateTowardsR Reflect(Vector3RotateTowards instance)
    {
        return new Vector3RotateTowardsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Subtract
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3SubtractR Reflect(Vector3Subtract instance)
    {
        return new Vector3SubtractR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationEffect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationEffectR Reflect(VibrationEffect instance)
    {
        return new VibrationEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerR Reflect(VibrationPlayer instance)
    {
        return new VibrationPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayerPlay
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerPlayR Reflect(VibrationPlayerPlay instance)
    {
        return new VibrationPlayerPlayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayerSetMotors
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerSetMotorsR Reflect(VibrationPlayerSetMotors instance)
    {
        return new VibrationPlayerSetMotorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayerStop
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerStopR Reflect(VibrationPlayerStop instance)
    {
        return new VibrationPlayerStopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VideoMenuOptions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VideoMenuOptionsR Reflect(VideoMenuOptions instance)
    {
        return new VideoMenuOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VinePlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VinePlatformR Reflect(VinePlatform instance)
    {
        return new VinePlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VinePlatformCut
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VinePlatformCutR Reflect(VinePlatformCut instance)
    {
        return new VinePlatformCutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VisibilityControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VisibilityControlR Reflect(VisibilityControl instance)
    {
        return new VisibilityControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Wait
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitR Reflect(Wait instance)
    {
        return new WaitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForBossLoad
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForBossLoadR Reflect(WaitForBossLoad instance)
    {
        return new WaitForBossLoadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForFinishedEnteringScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForFinishedEnteringSceneR Reflect(WaitForFinishedEnteringScene instance)
    {
        return new WaitForFinishedEnteringSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForHeroInPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForHeroInPositionR Reflect(WaitForHeroInPosition instance)
    {
        return new WaitForHeroInPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForSceneLoadFinish
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForSceneLoadFinishR Reflect(WaitForSceneLoadFinish instance)
    {
        return new WaitForSceneLoadFinishR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitRandom
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitRandomR Reflect(WaitRandom instance)
    {
        return new WaitRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeAllRigidBodies
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeAllRigidBodiesR Reflect(WakeAllRigidBodies instance)
    {
        return new WakeAllRigidBodiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeAllRigidBodies2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeAllRigidBodies2dR Reflect(WakeAllRigidBodies2d instance)
    {
        return new WakeAllRigidBodies2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeUpR Reflect(WakeUp instance)
    {
        return new WakeUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeUp2d
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeUp2dR Reflect(WakeUp2d instance)
    {
        return new WakeUp2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WalkArea
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkAreaR Reflect(WalkArea instance)
    {
        return new WalkAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Walker
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkerR Reflect(Walker instance)
    {
        return new WalkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WalkLeftRight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkLeftRightR Reflect(WalkLeftRight instance)
    {
        return new WalkLeftRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WalkSlope
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkSlopeR Reflect(WalkSlope instance)
    {
        return new WalkSlopeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WasHere
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WasHereR Reflect(WasHere instance)
    {
        return new WasHereR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaterDrip
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaterDripR Reflect(WaterDrip instance)
    {
        return new WaterDripR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaveEffectControl
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaveEffectControlR Reflect(WaveEffectControl instance)
    {
        return new WaveEffectControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WeaverlingEnemyList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WeaverlingEnemyListR Reflect(WeaverlingEnemyList instance)
    {
        return new WeaverlingEnemyListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WeightedItem
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WeightedItemR Reflect(WeightedItem instance)
    {
        return new WeightedItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WorldInfoR Reflect(WorldInfo instance)
    {
        return new WorldInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldItems
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WorldItemsR Reflect(WorldItems instance)
    {
        return new WorldItemsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldToScreenPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WorldToScreenPointR Reflect(WorldToScreenPoint instance)
    {
        return new WorldToScreenPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XB1CinematicVideoPlayer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XB1CinematicVideoPlayerR Reflect(XB1CinematicVideoPlayer instance)
    {
        return new XB1CinematicVideoPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360AmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360AmazonUnityProfileR Reflect(Xbox360AmazonUnityProfile instance)
    {
        return new Xbox360AmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360AndroidUnityProfileR Reflect(Xbox360AndroidUnityProfile instance)
    {
        return new Xbox360AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360DriverMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360DriverMacNativeProfileR Reflect(Xbox360DriverMacNativeProfile instance)
    {
        return new Xbox360DriverMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360LinuxUnityProfileR Reflect(Xbox360LinuxUnityProfile instance)
    {
        return new Xbox360LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacChromeUnityProfileR Reflect(Xbox360MacChromeUnityProfile instance)
    {
        return new Xbox360MacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacFirefoxUnityProfileR Reflect(Xbox360MacFirefoxUnityProfile instance)
    {
        return new Xbox360MacFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacSafariUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacSafariUnityProfileR Reflect(Xbox360MacSafariUnityProfile instance)
    {
        return new Xbox360MacSafariUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacUnityProfileR Reflect(Xbox360MacUnityProfile instance)
    {
        return new Xbox360MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     Xbox360MortalKombatFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MortalKombatFightStickMacNativeProfileR Reflect(
        Xbox360MortalKombatFightStickMacNativeProfile instance)
    {
        return new Xbox360MortalKombatFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     Xbox360ProEXControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360ProEXControllerMacNativeProfileR Reflect(Xbox360ProEXControllerMacNativeProfile instance)
    {
        return new Xbox360ProEXControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360RockCandyAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360RockCandyAndroidUnityProfileR Reflect(Xbox360RockCandyAndroidUnityProfile instance)
    {
        return new Xbox360RockCandyAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360WindowsUnityProfileR Reflect(Xbox360WindowsUnityProfile instance)
    {
        return new Xbox360WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360WiredWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360WiredWindowsNativeProfileR Reflect(Xbox360WiredWindowsNativeProfile instance)
    {
        return new Xbox360WiredWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360WirelessWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360WirelessWindowsNativeProfileR Reflect(Xbox360WirelessWindowsNativeProfile instance)
    {
        return new Xbox360WirelessWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneBluetoothAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneBluetoothAndroidUnityProfileR Reflect(XboxOneBluetoothAndroidUnityProfile instance)
    {
        return new XboxOneBluetoothAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneDriverMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneDriverMacNativeProfileR Reflect(XboxOneDriverMacNativeProfile instance)
    {
        return new XboxOneDriverMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneEliteWindows10AENativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneEliteWindows10AENativeProfileR Reflect(XboxOneEliteWindows10AENativeProfile instance)
    {
        return new XboxOneEliteWindows10AENativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneEliteWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneEliteWindowsNativeProfileR Reflect(XboxOneEliteWindowsNativeProfile instance)
    {
        return new XboxOneEliteWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacChromeUnityProfileR Reflect(XboxOneMacChromeUnityProfile instance)
    {
        return new XboxOneMacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacFirefoxUnityProfileR Reflect(XboxOneMacFirefoxUnityProfile instance)
    {
        return new XboxOneMacFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacSafariUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacSafariUnityProfileR Reflect(XboxOneMacSafariUnityProfile instance)
    {
        return new XboxOneMacSafariUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacUnityProfileR Reflect(XboxOneMacUnityProfile instance)
    {
        return new XboxOneMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMFiNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMFiNativeProfileR Reflect(XboxOneMFiNativeProfile instance)
    {
        return new XboxOneMFiNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneSBluetoothMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneSBluetoothMacNativeProfileR Reflect(XboxOneSBluetoothMacNativeProfile instance)
    {
        return new XboxOneSBluetoothMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneSMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneSMacNativeProfileR Reflect(XboxOneSMacNativeProfile instance)
    {
        return new XboxOneSMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneUnityProfileR Reflect(XboxOneUnityProfile instance)
    {
        return new XboxOneUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10AENativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10AENativeProfileR Reflect(XboxOneWindows10AENativeProfile instance)
    {
        return new XboxOneWindows10AENativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10AEUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10AEUnityProfileR Reflect(XboxOneWindows10AEUnityProfile instance)
    {
        return new XboxOneWindows10AEUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10NativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10NativeProfileR Reflect(XboxOneWindows10NativeProfile instance)
    {
        return new XboxOneWindows10NativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10UnityProfileR Reflect(XboxOneWindows10UnityProfile instance)
    {
        return new XboxOneWindows10UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindowsNativeProfileR Reflect(XboxOneWindowsNativeProfile instance)
    {
        return new XboxOneWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindowsUnityProfileR Reflect(XboxOneWindowsUnityProfile instance)
    {
        return new XboxOneWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     XboxOneWirelessAdapterWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWirelessAdapterWindowsNativeProfileR Reflect(
        XboxOneWirelessAdapterWindowsNativeProfile instance)
    {
        return new XboxOneWirelessAdapterWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxSdk
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxSdkR Reflect(XboxSdk instance)
    {
        return new XboxSdkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XiamoiWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XiamoiWindowsUnityProfileR Reflect(XiamoiWindowsUnityProfile instance)
    {
        return new XiamoiWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XiaomiMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XiaomiMacUnityProfileR Reflect(XiaomiMacUnityProfile instance)
    {
        return new XiaomiMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XInputWindowsChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XInputWindowsChromeUnityProfileR Reflect(XInputWindowsChromeUnityProfile instance)
    {
        return new XInputWindowsChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XInputWindowsFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XInputWindowsFirefoxUnityProfileR Reflect(XInputWindowsFirefoxUnityProfile instance)
    {
        return new XInputWindowsFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XInputWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XInputWindowsNativeProfileR Reflect(XInputWindowsNativeProfile instance)
    {
        return new XInputWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_MacNativeProfileR Reflect(XTR55_G2_MacNativeProfile instance)
    {
        return new XTR55_G2_MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_MacUnityProfileR Reflect(XTR55_G2_MacUnityProfile instance)
    {
        return new XTR55_G2_MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_WindowsNativeProfileR Reflect(XTR55_G2_WindowsNativeProfile instance)
    {
        return new XTR55_G2_WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_WindowsUnityProfileR Reflect(XTR55_G2_WindowsUnityProfile instance)
    {
        return new XTR55_G2_WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_MacNativeProfileR Reflect(XTR_G2_MacNativeProfile instance)
    {
        return new XTR_G2_MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_MacUnityProfileR Reflect(XTR_G2_MacUnityProfile instance)
    {
        return new XTR_G2_MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_WindowsNativeProfileR Reflect(XTR_G2_WindowsNativeProfile instance)
    {
        return new XTR_G2_WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_WindowsUnityProfileR Reflect(XTR_G2_WindowsUnityProfile instance)
    {
        return new XTR_G2_WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ZeroAlphaOnStart
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ZeroAlphaOnStartR Reflect(ZeroAlphaOnStart instance)
    {
        return new ZeroAlphaOnStartR(instance);
    }
}