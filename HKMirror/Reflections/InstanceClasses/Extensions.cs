using GUIBlendModes;
using HKMirror.Reflection.InstanceClasses;
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

namespace HKMirror.Reflection;

public static class Extensions
{
    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerData allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataR Reflect(this PlayerData instance)
    {
        return new PlayerDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameManagerRR Reflect(this GameManager instance)
    {
        return new GameManagerRR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroControllerR allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroControllerRR Reflect(this HeroController instance)
    {
        return new HeroControllerRR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIManagerR allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIManagerRR Reflect(this UIManager instance)
    {
        return new UIManagerRR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of System.Random allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomR Reflect(this Random instance)
    {
        return new RandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectPool.StartupPool allowing you
    ///     to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static ObjectPool_StartupPoolR Reflect(this ObjectPool.StartupPool instance)
    {
        return new ObjectPool_StartupPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShineAnimSequence.ShineObject
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static ShineAnimSequence_ShineObjectR Reflect(this ShineAnimSequence.ShineObject instance)
    {
        return new ShineAnimSequence_ShineObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MusicCue.MusicChannelInfo allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static MusicCue_MusicChannelInfoR Reflect(this MusicCue.MusicChannelInfo instance)
    {
        return new MusicCue_MusicChannelInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PerformanceHUD.LoadReport allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static PerformanceHUD_LoadReportR Reflect(this PerformanceHUD.LoadReport instance)
    {
        return new PerformanceHUD_LoadReportR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     BossDoorCompletionStates.CompletionState allowing you to easily get/set fields and call methods without dealing
    ///     withR Reflection.
    /// </summary>
    public static BossDoorCompletionStates_CompletionStateR Reflect(
        this BossDoorCompletionStates.CompletionState instance)
    {
        return new BossDoorCompletionStates_CompletionStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorTargetLock.BossDoorTarget
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static BossDoorTargetLock_BossDoorTargetR Reflect(this BossDoorTargetLock.BossDoorTarget instance)
    {
        return new BossDoorTargetLock_BossDoorTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossScene.BossTest allowing you to
    ///     easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static BossScene_BossTestR Reflect(this BossScene.BossTest instance)
    {
        return new BossScene_BossTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     BossSequenceController.BossSequenceData allowing you to easily get/set fields and call methods without dealing
    ///     withR Reflection.
    /// </summary>
    public static BossSequenceController_BossSequenceDataR Reflect(
        this BossSequenceController.BossSequenceData instance)
    {
        return new BossSequenceController_BossSequenceDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossChallengeUI.ButtonDisplay
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static BossChallengeUI_ButtonDisplayR Reflect(this BossChallengeUI.ButtonDisplay instance)
    {
        return new BossChallengeUI_ButtonDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     BossDoorChallengeCompleteUI.BindingIcon allowing you to easily get/set fields and call methods without dealing
    ///     withR Reflection.
    /// </summary>
    public static BossDoorChallengeCompleteUI_BindingIconR Reflect(
        this BossDoorChallengeCompleteUI.BindingIcon instance)
    {
        return new BossDoorChallengeCompleteUI_BindingIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderInvIcon.BossSceneExtra
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static GodfinderInvIcon_BossSceneExtraR Reflect(this GodfinderInvIcon.BossSceneExtra instance)
    {
        return new GodfinderInvIcon_BossSceneExtraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputModuleBinder.MyActionSet
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static InputModuleBinder_MyActionSetR Reflect(this InputModuleBinder.MyActionSet instance)
    {
        return new InputModuleBinder_MyActionSetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PreMenuInputModuleActionAdaptor.PreMenuInputModuleActions allowing you to easily get/set fields and call methods
    ///     without dealing withR Reflection.
    /// </summary>
    public static PreMenuInputModuleActionAdaptor_PreMenuInputModuleActionsR Reflect(
        this PreMenuInputModuleActionAdaptor.PreMenuInputModuleActions instance)
    {
        return new PreMenuInputModuleActionAdaptor_PreMenuInputModuleActionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WeaverlingEnemyList.GetEnemyTarget
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static WeaverlingEnemyList_GetEnemyTargetR Reflect(this WeaverlingEnemyList.GetEnemyTarget instance)
    {
        return new WeaverlingEnemyList_GetEnemyTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameManager.SceneLoadInfo allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static GameManager_SceneLoadInfoR Reflect(this GameManager.SceneLoadInfo instance)
    {
        return new GameManager_SceneLoadInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementIDMap.AchievementIDPair
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static AchievementIDMap_AchievementIDPairR Reflect(this AchievementIDMap.AchievementIDPair instance)
    {
        return new AchievementIDMap_AchievementIDPairR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GamepadVibrationMixer.GamepadVibrationEmission allowing you to easily get/set fields and call methods without
    ///     dealing withR Reflection.
    /// </summary>
    public static GamepadVibrationMixer_GamepadVibrationEmissionR Reflect(
        this GamepadVibrationMixer.GamepadVibrationEmission instance)
    {
        return new GamepadVibrationMixer_GamepadVibrationEmissionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Probability.ProbabilityGameObject
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static Probability_ProbabilityGameObjectR Reflect(this Probability.ProbabilityGameObject instance)
    {
        return new Probability_ProbabilityGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Breakable.FlingObject allowing you
    ///     to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static Breakable_FlingObjectR Reflect(this Breakable.FlingObject instance)
    {
        return new Breakable_FlingObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableObject.Direction allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static BreakableObject_DirectionR Reflect(this BreakableObject.Direction instance)
    {
        return new BreakableObject_DirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableObject.FlingObject allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static BreakableObject_FlingObjectR Reflect(this BreakableObject.FlingObject instance)
    {
        return new BreakableObject_FlingObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     BreakableWithExternalDebris.WeightedExternalDebrisItem allowing you to easily get/set fields and call methods
    ///     without dealing withR Reflection.
    /// </summary>
    public static BreakableWithExternalDebris_WeightedExternalDebrisItemR Reflect(
        this BreakableWithExternalDebris.WeightedExternalDebrisItem instance)
    {
        return new BreakableWithExternalDebris_WeightedExternalDebrisItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HealthCocoon.FlingPrefab allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static HealthCocoon_FlingPrefabR Reflect(this HealthCocoon.FlingPrefab instance)
    {
        return new HealthCocoon_FlingPrefabR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ContentPackDetailsUI.ContentPackDetails allowing you to easily get/set fields and call methods without dealing
    ///     withR Reflection.
    /// </summary>
    public static ContentPackDetailsUI_ContentPackDetailsR Reflect(
        this ContentPackDetailsUI.ContentPackDetails instance)
    {
        return new ContentPackDetailsUI_ContentPackDetailsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyles.MenuStyle allowing you to
    ///     easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static MenuStyles_MenuStyleR Reflect(this MenuStyles.MenuStyle instance)
    {
        return new MenuStyles_MenuStyleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyles.MenuStyle.CameraCurves
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static MenuStyles_MenuStyle_CameraCurvesR Reflect(this MenuStyles.MenuStyle.CameraCurves instance)
    {
        return new MenuStyles_MenuStyle_CameraCurvesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FSMUtility.CheckFsmStateAction
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static FSMUtility_CheckFsmStateActionR Reflect(this FSMUtility.CheckFsmStateAction instance)
    {
        return new FSMUtility_CheckFsmStateActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FSMUtility.GetIntFsmStateAction
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static FSMUtility_GetIntFsmStateActionR Reflect(this FSMUtility.GetIntFsmStateAction instance)
    {
        return new FSMUtility_GetIntFsmStateActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScenePreloader.SceneLoadOp allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static ScenePreloader_SceneLoadOpR Reflect(this ScenePreloader.SceneLoadOp instance)
    {
        return new ScenePreloader_SceneLoadOpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldInfo.SceneInfo allowing you to
    ///     easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static WorldInfo_SceneInfoR Reflect(this WorldInfo.SceneInfo instance)
    {
        return new WorldInfo_SceneInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldNavigation.SceneItem allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static WorldNavigation_SceneItemR Reflect(this WorldNavigation.SceneItem instance)
    {
        return new WorldNavigation_SceneItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldNavigation.TransitionItem
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static WorldNavigation_TransitionItemR Reflect(this WorldNavigation.TransitionItem instance)
    {
        return new WorldNavigation_TransitionItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTextGeomGen.GeomData allowing
    ///     you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static tk2dTextGeomGen_GeomDataR Reflect(this tk2dTextGeomGen.GeomData instance)
    {
        return new tk2dTextGeomGen_GeomDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     tk2dSpriteCollectionDefinition.ColliderData allowing you to easily get/set fields and call methods without dealing
    ///     withR Reflection.
    /// </summary>
    public static tk2dSpriteCollectionDefinition_ColliderDataR Reflect(
        this tk2dSpriteCollectionDefinition.ColliderData instance)
    {
        return new tk2dSpriteCollectionDefinition_ColliderDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     tk2dSpriteCollection.AttachPointTestSprite allowing you to easily get/set fields and call methods without dealing
    ///     withR Reflection.
    /// </summary>
    public static tk2dSpriteCollection_AttachPointTestSpriteR Reflect(
        this tk2dSpriteCollection.AttachPointTestSprite instance)
    {
        return new tk2dSpriteCollection_AttachPointTestSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteDefinition.AttachPoint
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static tk2dSpriteDefinition_AttachPointR Reflect(this tk2dSpriteDefinition.AttachPoint instance)
    {
        return new tk2dSpriteDefinition_AttachPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTileMap.TilemapPrefabInstance
    ///     allowing you to easily get/set fields and call methods without dealing withR Reflection.
    /// </summary>
    public static tk2dTileMap_TilemapPrefabInstanceR Reflect(this tk2dTileMap.TilemapPrefabInstance instance)
    {
        return new tk2dTileMap_TilemapPrefabInstanceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AccelerateVelocity allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AccelerateVelocityR Reflect(this AccelerateVelocity instance)
    {
        return new AccelerateVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Achievement allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementR Reflect(this Achievement instance)
    {
        return new AchievementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementHandler allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementHandlerR Reflect(this AchievementHandler instance)
    {
        return new AchievementHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementIDMap allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementIDMapR Reflect(this AchievementIDMap instance)
    {
        return new AchievementIDMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementListener allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementListenerR Reflect(this AchievementListener instance)
    {
        return new AchievementListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementPopup allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementPopupR Reflect(this AchievementPopup instance)
    {
        return new AchievementPopupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementPopupHandler allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementPopupHandlerR Reflect(this AchievementPopupHandler instance)
    {
        return new AchievementPopupHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementRecord allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementRecordR Reflect(this AchievementRecord instance)
    {
        return new AchievementRecordR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementRecordFloat allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementRecordFloatR Reflect(this AchievementRecordFloat instance)
    {
        return new AchievementRecordFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementRecordInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementRecordIntR Reflect(this AchievementRecordInt instance)
    {
        return new AchievementRecordIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AchievementsList allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AchievementsListR Reflect(this AchievementsList instance)
    {
        return new AchievementsListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AcidCorpseSplash allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AcidCorpseSplashR Reflect(this AcidCorpseSplash instance)
    {
        return new AcidCorpseSplashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActionButtonIcon allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActionButtonIconR Reflect(this ActionButtonIcon instance)
    {
        return new ActionButtonIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActionQueue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActionQueueR Reflect(this ActionQueue instance)
    {
        return new ActionQueueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateAllChildren allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateAllChildrenR Reflect(this ActivateAllChildren instance)
    {
        return new ActivateAllChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateChildrenOnContact allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateChildrenOnContactR Reflect(this ActivateChildrenOnContact instance)
    {
        return new ActivateChildrenOnContactR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateGameObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateGameObjectR Reflect(this ActivateGameObject instance)
    {
        return new ActivateGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateIfPlayerdataTrue allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateIfPlayerdataTrueR Reflect(this ActivateIfPlayerdataTrue instance)
    {
        return new ActivateIfPlayerdataTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivatePerLanguage allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivatePerLanguageR Reflect(this ActivatePerLanguage instance)
    {
        return new ActivatePerLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActivateTrailRenderer allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActivateTrailRendererR Reflect(this ActivateTrailRenderer instance)
    {
        return new ActivateTrailRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActiveRecycler allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActiveRecyclerR Reflect(this ActiveRecycler instance)
    {
        return new ActiveRecyclerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ActiveRegion allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ActiveRegionR Reflect(this ActiveRegion instance)
    {
        return new ActiveRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddAnimationClip allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddAnimationClipR Reflect(this AddAnimationClip instance)
    {
        return new AddAnimationClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddComponent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddComponentR Reflect(this AddComponent instance)
    {
        return new AddComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddEventRegister allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddEventRegisterR Reflect(this AddEventRegister instance)
    {
        return new AddEventRegisterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddExplosionForce allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddExplosionForceR Reflect(this AddExplosionForce instance)
    {
        return new AddExplosionForceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForceR Reflect(this AddForce instance)
    {
        return new AddForceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForce2dR Reflect(this AddForce2d instance)
    {
        return new AddForce2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce2dAsAngle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForce2dAsAngleR Reflect(this AddForce2dAsAngle instance)
    {
        return new AddForce2dAsAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddForce2dV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddForce2dV2R Reflect(this AddForce2dV2 instance)
    {
        return new AddForce2dV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddHP allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static AddHPR Reflect(this AddHP instance)
    {
        return new AddHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddMixingTransform allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddMixingTransformR Reflect(this AddMixingTransform instance)
    {
        return new AddMixingTransformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddRelativeForce2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddRelativeForce2dR Reflect(this AddRelativeForce2d instance)
    {
        return new AddRelativeForce2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddScript allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddScriptR Reflect(this AddScript instance)
    {
        return new AddScriptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddTorque allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddTorqueR Reflect(this AddTorque instance)
    {
        return new AddTorqueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddTorque2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddTorque2dR Reflect(this AddTorque2d instance)
    {
        return new AddTorque2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AddTrackTrigger allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AddTrackTriggerR Reflect(this AddTrackTrigger instance)
    {
        return new AddTrackTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AfterglowXbox360WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AfterglowXbox360WindowsNativeProfileR Reflect(this AfterglowXbox360WindowsNativeProfile instance)
    {
        return new AfterglowXbox360WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AfterTakeDamageHandler allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AfterTakeDamageHandlerR Reflect(this AfterTakeDamageHandler instance)
    {
        return new AfterTakeDamageHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloControllerMacNativeProfileR Reflect(this AirFloControllerMacNativeProfile instance)
    {
        return new AirFloControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloPS3WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloPS3WindowsNativeProfileR Reflect(this AirFloPS3WindowsNativeProfile instance)
    {
        return new AirFloPS3WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloWiredPS3MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloWiredPS3MacUnityProfileR Reflect(this AirFloWiredPS3MacUnityProfile instance)
    {
        return new AirFloWiredPS3MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AirFloWiredPS3WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AirFloWiredPS3WindowsUnityProfileR Reflect(this AirFloWiredPS3WindowsUnityProfile instance)
    {
        return new AirFloWiredPS3WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AlertRange allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AlertRangeR Reflect(this AlertRange instance)
    {
        return new AlertRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AmazonFireTVRemoteUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AmazonFireTVRemoteUnityProfileR Reflect(this AmazonFireTVRemoteUnityProfile instance)
    {
        return new AmazonFireTVRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AmazonFireTVUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AmazonFireTVUnityProfileR Reflect(this AmazonFireTVUnityProfile instance)
    {
        return new AmazonFireTVUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVAmazonUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVAmazonUnityProfileR Reflect(this AndroidTVAmazonUnityProfile instance)
    {
        return new AndroidTVAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVMiBoxRemoteUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVMiBoxRemoteUnityProfileR Reflect(this AndroidTVMiBoxRemoteUnityProfile instance)
    {
        return new AndroidTVMiBoxRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVRemoteUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVRemoteUnityProfileR Reflect(this AndroidTVRemoteUnityProfile instance)
    {
        return new AndroidTVRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AndroidTVUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AndroidTVUnityProfileR Reflect(this AndroidTVUnityProfile instance)
    {
        return new AndroidTVUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateColorR Reflect(this AnimateColor instance)
    {
        return new AnimateColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateFloat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateFloatR Reflect(this AnimateFloat instance)
    {
        return new AnimateFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateFloatV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateFloatV2R Reflect(this AnimateFloatV2 instance)
    {
        return new AnimateFloatV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateRect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateRectR Reflect(this AnimateRect instance)
    {
        return new AnimateRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimateVector3 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimateVector3R Reflect(this AnimateVector3 instance)
    {
        return new AnimateVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimationSettings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimationSettingsR Reflect(this AnimationSettings instance)
    {
        return new AnimationSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorCrossFade allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorCrossFadeR Reflect(this AnimatorCrossFade instance)
    {
        return new AnimatorCrossFadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorFollow allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorFollowR Reflect(this AnimatorFollow instance)
    {
        return new AnimatorFollowR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorInterruptMatchTarget
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorInterruptMatchTargetR Reflect(this AnimatorInterruptMatchTarget instance)
    {
        return new AnimatorInterruptMatchTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorMatchTarget allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorMatchTargetR Reflect(this AnimatorMatchTarget instance)
    {
        return new AnimatorMatchTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorPlay allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorPlayR Reflect(this AnimatorPlay instance)
    {
        return new AnimatorPlayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorPlayStateWait allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorPlayStateWaitR Reflect(this AnimatorPlayStateWait instance)
    {
        return new AnimatorPlayStateWaitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorSequence allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorSequenceR Reflect(this AnimatorSequence instance)
    {
        return new AnimatorSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStartPlayback allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStartPlaybackR Reflect(this AnimatorStartPlayback instance)
    {
        return new AnimatorStartPlaybackR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStartRecording allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStartRecordingR Reflect(this AnimatorStartRecording instance)
    {
        return new AnimatorStartRecordingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStopPlayback allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStopPlaybackR Reflect(this AnimatorStopPlayback instance)
    {
        return new AnimatorStopPlaybackR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimatorStopRecording allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimatorStopRecordingR Reflect(this AnimatorStopRecording instance)
    {
        return new AnimatorStopRecordingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnimSpeedLerp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnimSpeedLerpR Reflect(this AnimSpeedLerp instance)
    {
        return new AnimSpeedLerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AnyKey allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AnyKeyR Reflect(this AnyKey instance)
    {
        return new AnyKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleMFiExtendedGamepadNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleMFiExtendedGamepadNativeProfileR Reflect(this AppleMFiExtendedGamepadNativeProfile instance)
    {
        return new AppleMFiExtendedGamepadNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleMFiMicroGamepadNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleMFiMicroGamepadNativeProfileR Reflect(this AppleMFiMicroGamepadNativeProfile instance)
    {
        return new AppleMFiMicroGamepadNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleMFiUnityProfile allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleMFiUnityProfileR Reflect(this AppleMFiUnityProfile instance)
    {
        return new AppleMFiUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AppleTVRemoteUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AppleTVRemoteUnityProfileR Reflect(this AppleTVRemoteUnityProfile instance)
    {
        return new AppleTVRemoteUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     AppleTVWirelessControllerUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static AppleTVWirelessControllerUnityProfileR Reflect(this AppleTVWirelessControllerUnityProfile instance)
    {
        return new AppleTVWirelessControllerUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ApplicationQuit allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ApplicationQuitR Reflect(this ApplicationQuit instance)
    {
        return new ApplicationQuitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ApplicationRunInBackground allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ApplicationRunInBackgroundR Reflect(this ApplicationRunInBackground instance)
    {
        return new ApplicationRunInBackgroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ApplyMusicCue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ApplyMusicCueR Reflect(this ApplyMusicCue instance)
    {
        return new ApplyMusicCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArdwiinoControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArdwiinoControllerMacNativeProfileR Reflect(this ArdwiinoControllerMacNativeProfile instance)
    {
        return new ArdwiinoControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AreaBackground allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AreaBackgroundR Reflect(this AreaBackground instance)
    {
        return new AreaBackgroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AreaTitle allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AreaTitleR Reflect(this AreaTitle instance)
    {
        return new AreaTitleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AreaTitleController allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AreaTitleControllerR Reflect(this AreaTitleController instance)
    {
        return new AreaTitleControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayAdd allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayAddR Reflect(this ArrayAdd instance)
    {
        return new ArrayAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayAddRange allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayAddRangeR Reflect(this ArrayAddRange instance)
    {
        return new ArrayAddRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayClear allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayClearR Reflect(this ArrayClear instance)
    {
        return new ArrayClearR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayCompare allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayCompareR Reflect(this ArrayCompare instance)
    {
        return new ArrayCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayContains allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayContainsR Reflect(this ArrayContains instance)
    {
        return new ArrayContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayDeleteAt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayDeleteAtR Reflect(this ArrayDeleteAt instance)
    {
        return new ArrayDeleteAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayForEach allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayForEachR Reflect(this ArrayForEach instance)
    {
        return new ArrayForEachR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayForEnumAttribute allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayForEnumAttributeR Reflect(this ArrayForEnumAttribute instance)
    {
        return new ArrayForEnumAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayGet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayGetR Reflect(this ArrayGet instance)
    {
        return new ArrayGetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayGetNext allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayGetNextR Reflect(this ArrayGetNext instance)
    {
        return new ArrayGetNextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayGetRandom allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayGetRandomR Reflect(this ArrayGetRandom instance)
    {
        return new ArrayGetRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayLength allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayLengthR Reflect(this ArrayLength instance)
    {
        return new ArrayLengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListAdd allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListAddR Reflect(this ArrayListAdd instance)
    {
        return new ArrayListAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListAddRange allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListAddRangeR Reflect(this ArrayListAddRange instance)
    {
        return new ArrayListAddRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListClear allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListClearR Reflect(this ArrayListClear instance)
    {
        return new ArrayListClearR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListConcat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListConcatR Reflect(this ArrayListConcat instance)
    {
        return new ArrayListConcatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListContains allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListContainsR Reflect(this ArrayListContains instance)
    {
        return new ArrayListContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListContainsGameObject allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListContainsGameObjectR Reflect(this ArrayListContainsGameObject instance)
    {
        return new ArrayListContainsGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListCopyTo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListCopyToR Reflect(this ArrayListCopyTo instance)
    {
        return new ArrayListCopyToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListCount allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListCountR Reflect(this ArrayListCount instance)
    {
        return new ArrayListCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListCreate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListCreateR Reflect(this ArrayListCreate instance)
    {
        return new ArrayListCreateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListExists allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListExistsR Reflect(this ArrayListExists instance)
    {
        return new ArrayListExistsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListFindGameObjectsByTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListFindGameObjectsByTagR Reflect(this ArrayListFindGameObjectsByTag instance)
    {
        return new ArrayListFindGameObjectsByTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetR Reflect(this ArrayListGet instance)
    {
        return new ArrayListGetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetAverageValue allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetAverageValueR Reflect(this ArrayListGetAverageValue instance)
    {
        return new ArrayListGetAverageValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetClosestGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetClosestGameObjectR Reflect(this ArrayListGetClosestGameObject instance)
    {
        return new ArrayListGetClosestGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetClosestGameObjectInSight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetClosestGameObjectInSightR Reflect(this ArrayListGetClosestGameObjectInSight instance)
    {
        return new ArrayListGetClosestGameObjectInSightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetFarthestGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetFarthestGameObjectR Reflect(this ArrayListGetFarthestGameObject instance)
    {
        return new ArrayListGetFarthestGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ArrayListGetFarthestGameObjectInSight allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static ArrayListGetFarthestGameObjectInSightR Reflect(this ArrayListGetFarthestGameObjectInSight instance)
    {
        return new ArrayListGetFarthestGameObjectInSightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ArrayListGetGameobjectMaxFsmFloatIndex allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static ArrayListGetGameobjectMaxFsmFloatIndexR Reflect(this ArrayListGetGameobjectMaxFsmFloatIndex instance)
    {
        return new ArrayListGetGameobjectMaxFsmFloatIndexR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetMaxValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetMaxValueR Reflect(this ArrayListGetMaxValue instance)
    {
        return new ArrayListGetMaxValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetMinValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetMinValueR Reflect(this ArrayListGetMinValue instance)
    {
        return new ArrayListGetMinValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetNearestFloatValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetNearestFloatValueR Reflect(this ArrayListGetNearestFloatValue instance)
    {
        return new ArrayListGetNearestFloatValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetNext allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetNextR Reflect(this ArrayListGetNext instance)
    {
        return new ArrayListGetNextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetPrevious allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetPreviousR Reflect(this ArrayListGetPrevious instance)
    {
        return new ArrayListGetPreviousR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetRandom allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetRandomR Reflect(this ArrayListGetRandom instance)
    {
        return new ArrayListGetRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetRelative allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetRelativeR Reflect(this ArrayListGetRelative instance)
    {
        return new ArrayListGetRelativeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetScreenResolutions
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetScreenResolutionsR Reflect(this ArrayListGetScreenResolutions instance)
    {
        return new ArrayListGetScreenResolutionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetVertexColors allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetVertexColorsR Reflect(this ArrayListGetVertexColors instance)
    {
        return new ArrayListGetVertexColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListGetVertexPositions allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListGetVertexPositionsR Reflect(this ArrayListGetVertexPositions instance)
    {
        return new ArrayListGetVertexPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListIndexOf allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListIndexOfR Reflect(this ArrayListIndexOf instance)
    {
        return new ArrayListIndexOfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListInsert allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListInsertR Reflect(this ArrayListInsert instance)
    {
        return new ArrayListInsertR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListIsEmpty allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListIsEmptyR Reflect(this ArrayListIsEmpty instance)
    {
        return new ArrayListIsEmptyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListLastIndexOf allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListLastIndexOfR Reflect(this ArrayListLastIndexOf instance)
    {
        return new ArrayListLastIndexOfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRemove allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRemoveR Reflect(this ArrayListRemove instance)
    {
        return new ArrayListRemoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRemoveAt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRemoveAtR Reflect(this ArrayListRemoveAt instance)
    {
        return new ArrayListRemoveAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRemoveRange allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRemoveRangeR Reflect(this ArrayListRemoveRange instance)
    {
        return new ArrayListRemoveRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListResetValues allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListResetValuesR Reflect(this ArrayListResetValues instance)
    {
        return new ArrayListResetValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListReverse allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListReverseR Reflect(this ArrayListReverse instance)
    {
        return new ArrayListReverseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListRevertToSnapShot allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListRevertToSnapShotR Reflect(this ArrayListRevertToSnapShot instance)
    {
        return new ArrayListRevertToSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSendEventToGameObjects
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSendEventToGameObjectsR Reflect(this ArrayListSendEventToGameObjects instance)
    {
        return new ArrayListSendEventToGameObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSetR Reflect(this ArrayListSet instance)
    {
        return new ArrayListSetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSetVertexColors allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSetVertexColorsR Reflect(this ArrayListSetVertexColors instance)
    {
        return new ArrayListSetVertexColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSetVertexPositions allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSetVertexPositionsR Reflect(this ArrayListSetVertexPositions instance)
    {
        return new ArrayListSetVertexPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListShuffle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListShuffleR Reflect(this ArrayListShuffle instance)
    {
        return new ArrayListShuffleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSort allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSortR Reflect(this ArrayListSort instance)
    {
        return new ArrayListSortR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListSwapItems allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListSwapItemsR Reflect(this ArrayListSwapItems instance)
    {
        return new ArrayListSwapItemsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayListTakeSnapShot allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayListTakeSnapShotR Reflect(this ArrayListTakeSnapShot instance)
    {
        return new ArrayListTakeSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayResize allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayResizeR Reflect(this ArrayResize instance)
    {
        return new ArrayResizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayReverse allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayReverseR Reflect(this ArrayReverse instance)
    {
        return new ArrayReverseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArraySet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArraySetR Reflect(this ArraySet instance)
    {
        return new ArraySetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayShuffle allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayShuffleR Reflect(this ArrayShuffle instance)
    {
        return new ArrayShuffleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArraySort allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArraySortR Reflect(this ArraySort instance)
    {
        return new ArraySortR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ArrayTransferValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ArrayTransferValueR Reflect(this ArrayTransferValue instance)
    {
        return new ArrayTransferValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AssetNamePickerAttribute allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AssetNamePickerAttributeR Reflect(this AssetNamePickerAttribute instance)
    {
        return new AssetNamePickerAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AtmosCue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AtmosCueR Reflect(this AtmosCue instance)
    {
        return new AtmosCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AtPlayControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AtPlayControllerMacNativeProfileR Reflect(this AtPlayControllerMacNativeProfile instance)
    {
        return new AtPlayControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioLoopMaster allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioLoopMasterR Reflect(this AudioLoopMaster instance)
    {
        return new AudioLoopMasterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioManagerR Reflect(this AudioManager instance)
    {
        return new AudioManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioMute allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioMuteR Reflect(this AudioMute instance)
    {
        return new AudioMuteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPause allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPauseR Reflect(this AudioPause instance)
    {
        return new AudioPauseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlay allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayR Reflect(this AudioPlay instance)
    {
        return new AudioPlayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayerOneShot allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayerOneShotR Reflect(this AudioPlayerOneShot instance)
    {
        return new AudioPlayerOneShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayerOneShotSingle allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayerOneShotSingleR Reflect(this AudioPlayerOneShotSingle instance)
    {
        return new AudioPlayerOneShotSingleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayInState allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayInStateR Reflect(this AudioPlayInState instance)
    {
        return new AudioPlayInStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayRandom allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayRandomR Reflect(this AudioPlayRandom instance)
    {
        return new AudioPlayRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayRandomSingle allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayRandomSingleR Reflect(this AudioPlayRandomSingle instance)
    {
        return new AudioPlayRandomSingleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlaySimple allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlaySimpleR Reflect(this AudioPlaySimple instance)
    {
        return new AudioPlaySimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioPlayV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioPlayV2R Reflect(this AudioPlayV2 instance)
    {
        return new AudioPlayV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioSourcePitchRandomizer allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioSourcePitchRandomizerR Reflect(this AudioSourcePitchRandomizer instance)
    {
        return new AudioSourcePitchRandomizerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AudioStop allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AudioStopR Reflect(this AudioStop instance)
    {
        return new AudioStopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoLocalizeTextUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoLocalizeTextUIR Reflect(this AutoLocalizeTextUI instance)
    {
        return new AutoLocalizeTextUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoRecycleSelf allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoRecycleSelfR Reflect(this AutoRecycleSelf instance)
    {
        return new AutoRecycleSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoSelector allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoSelectorR Reflect(this AutoSelector instance)
    {
        return new AutoSelectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AutoZSorter allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AutoZSorterR Reflect(this AutoZSorter instance)
    {
        return new AutoZSorterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of AxisEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static AxisEventR Reflect(this AxisEvent instance)
    {
        return new AxisEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BasicSpriteAnimator allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BasicSpriteAnimatorR Reflect(this BasicSpriteAnimator instance)
    {
        return new BasicSpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BatarangControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BatarangControllerMacNativeProfileR Reflect(this BatarangControllerMacNativeProfile instance)
    {
        return new BatarangControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeatControl allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeatControlR Reflect(this BeatControl instance)
    {
        return new BeatControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeboncoolDA015CAAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeboncoolDA015CAAndroidUnityProfileR Reflect(this BeboncoolDA015CAAndroidUnityProfile instance)
    {
        return new BeboncoolDA015CAAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeginRecoil allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeginRecoilR Reflect(this BeginRecoil instance)
    {
        return new BeginRecoilR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BeginSceneTransition allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BeginSceneTransitionR Reflect(this BeginSceneTransition instance)
    {
        return new BeginSceneTransitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BehaviourListAdd allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BehaviourListAddR Reflect(this BehaviourListAdd instance)
    {
        return new BehaviourListAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BehaviourListRemove allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BehaviourListRemoveR Reflect(this BehaviourListRemove instance)
    {
        return new BehaviourListRemoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetaEndPrompt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetaEndPromptR Reflect(this BetaEndPrompt instance)
    {
        return new BetaEndPromptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetaGateChanger allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetaGateChangerR Reflect(this BetaGateChanger instance)
    {
        return new BetaGateChangerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BETAOPControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BETAOPControllerMacNativeProfileR Reflect(this BETAOPControllerMacNativeProfile instance)
    {
        return new BETAOPControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetopBTP2175sWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetopBTP2175sWindowsUnityProfileR Reflect(this BetopBTP2175sWindowsUnityProfile instance)
    {
        return new BetopBTP2175sWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetopBTPAX1TAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetopBTPAX1TAndroidUnityProfileR Reflect(this BetopBTPAX1TAndroidUnityProfile instance)
    {
        return new BetopBTPAX1TAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BetopBTPGenericAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BetopBTPGenericAndroidUnityProfileR Reflect(this BetopBTPGenericAndroidUnityProfile instance)
    {
        return new BetopBTPGenericAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigBenControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigBenControllerMacNativeProfileR Reflect(this BigBenControllerMacNativeProfile instance)
    {
        return new BigBenControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigBouncer allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigBouncerR Reflect(this BigBouncer instance)
    {
        return new BigBouncerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigCentipede allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigCentipedeR Reflect(this BigCentipede instance)
    {
        return new BigCentipedeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BigCentipedeSection allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BigCentipedeSectionR Reflect(this BigCentipedeSection instance)
    {
        return new BigCentipedeSectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BindingListenOptions allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BindingListenOptionsR Reflect(this BindingListenOptions instance)
    {
        return new BindingListenOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlendAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlendAnimationR Reflect(this BlendAnimation instance)
    {
        return new BlendAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Blink allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static BlinkR Reflect(this Blink instance)
    {
        return new BlinkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlurControl allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlurControlR Reflect(this BlurControl instance)
    {
        return new BlurControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlurManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlurManagerR Reflect(this BlurManager instance)
    {
        return new BlurManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BlurPlane allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BlurPlaneR Reflect(this BlurPlane instance)
    {
        return new BlurPlaneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolAllTrue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolAllTrueR Reflect(this BoolAllTrue instance)
    {
        return new BoolAllTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolAnyTrue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolAnyTrueR Reflect(this BoolAnyTrue instance)
    {
        return new BoolAnyTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolChanged allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolChangedR Reflect(this BoolChanged instance)
    {
        return new BoolChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolFlip allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolFlipR Reflect(this BoolFlip instance)
    {
        return new BoolFlipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolFlipEveryFrame allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolFlipEveryFrameR Reflect(this BoolFlipEveryFrame instance)
    {
        return new BoolFlipEveryFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolNoneTrue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolNoneTrueR Reflect(this BoolNoneTrue instance)
    {
        return new BoolNoneTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolOperator allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolOperatorR Reflect(this BoolOperator instance)
    {
        return new BoolOperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolTest allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolTestR Reflect(this BoolTest instance)
    {
        return new BoolTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoolTestMulti allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoolTestMultiR Reflect(this BoolTestMulti instance)
    {
        return new BoolTestMultiR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossChallengeUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossChallengeUIR Reflect(this BossChallengeUI instance)
    {
        return new BossChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorCage allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorCageR Reflect(this BossDoorCage instance)
    {
        return new BossDoorCageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorChallengeCompleteUI allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorChallengeCompleteUIR Reflect(this BossDoorChallengeCompleteUI instance)
    {
        return new BossDoorChallengeCompleteUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorChallengeUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorChallengeUIR Reflect(this BossDoorChallengeUI instance)
    {
        return new BossDoorChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorChallengeUIBindingButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorChallengeUIBindingButtonR Reflect(this BossDoorChallengeUIBindingButton instance)
    {
        return new BossDoorChallengeUIBindingButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorCompletionStates allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorCompletionStatesR Reflect(this BossDoorCompletionStates instance)
    {
        return new BossDoorCompletionStatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorLockUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorLockUIR Reflect(this BossDoorLockUI instance)
    {
        return new BossDoorLockUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorLockUIIcon allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorLockUIIconR Reflect(this BossDoorLockUIIcon instance)
    {
        return new BossDoorLockUIIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossDoorTargetLock allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossDoorTargetLockR Reflect(this BossDoorTargetLock instance)
    {
        return new BossDoorTargetLockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossScene allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSceneR Reflect(this BossScene instance)
    {
        return new BossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSceneController allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSceneControllerR Reflect(this BossSceneController instance)
    {
        return new BossSceneControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequence allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceR Reflect(this BossSequence instance)
    {
        return new BossSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequenceBindingsDisplay allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceBindingsDisplayR Reflect(this BossSequenceBindingsDisplay instance)
    {
        return new BossSequenceBindingsDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequenceBindingsDoor allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceBindingsDoorR Reflect(this BossSequenceBindingsDoor instance)
    {
        return new BossSequenceBindingsDoorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSequenceDoor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSequenceDoorR Reflect(this BossSequenceDoor instance)
    {
        return new BossSequenceDoorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueR Reflect(this BossStatue instance)
    {
        return new BossStatueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueCompletionStates allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueCompletionStatesR Reflect(this BossStatueCompletionStates instance)
    {
        return new BossStatueCompletionStatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueDreamToggle allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueDreamToggleR Reflect(this BossStatueDreamToggle instance)
    {
        return new BossStatueDreamToggleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueExtraFlashEffect allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueExtraFlashEffectR Reflect(this BossStatueExtraFlashEffect instance)
    {
        return new BossStatueExtraFlashEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueFlashEffect allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueFlashEffectR Reflect(this BossStatueFlashEffect instance)
    {
        return new BossStatueFlashEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueLever allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueLeverR Reflect(this BossStatueLever instance)
    {
        return new BossStatueLeverR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueLoadManager allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueLoadManagerR Reflect(this BossStatueLoadManager instance)
    {
        return new BossStatueLoadManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueSetUnlockIndicator
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueSetUnlockIndicatorR Reflect(this BossStatueSetUnlockIndicator instance)
    {
        return new BossStatueSetUnlockIndicatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossStatueTrophyPlaque allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossStatueTrophyPlaqueR Reflect(this BossStatueTrophyPlaque instance)
    {
        return new BossStatueTrophyPlaqueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSummaryBoard allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSummaryBoardR Reflect(this BossSummaryBoard instance)
    {
        return new BossSummaryBoardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BossSummaryUI allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BossSummaryUIR Reflect(this BossSummaryUI instance)
    {
        return new BossSummaryUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BounceShroom allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BounceShroomR Reflect(this BounceShroom instance)
    {
        return new BounceShroomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Bounds allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoundsR Reflect(this Bounds instance)
    {
        return new BoundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoundsBoxCollider allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoundsBoxColliderR Reflect(this BoundsBoxCollider instance)
    {
        return new BoundsBoxColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BoxColliderOffset allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BoxColliderOffsetR Reflect(this BoxColliderOffset instance)
    {
        return new BoxColliderOffsetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Breakable allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableR Reflect(this Breakable instance)
    {
        return new BreakableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableInfectedVine allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableInfectedVineR Reflect(this BreakableInfectedVine instance)
    {
        return new BreakableInfectedVineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableObjectR Reflect(this BreakableObject instance)
    {
        return new BreakableObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakablePole allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakablePoleR Reflect(this BreakablePole instance)
    {
        return new BreakablePoleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakablePoleSimple allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakablePoleSimpleR Reflect(this BreakablePoleSimple instance)
    {
        return new BreakablePoleSimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakablePoleTopLand allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakablePoleTopLandR Reflect(this BreakablePoleTopLand instance)
    {
        return new BreakablePoleTopLandR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BreakableWithExternalDebris allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BreakableWithExternalDebrisR Reflect(this BreakableWithExternalDebris instance)
    {
        return new BreakableWithExternalDebrisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BridgeLever allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BridgeLeverR Reflect(this BridgeLever instance)
    {
        return new BridgeLeverR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BridgeSection allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BridgeSectionR Reflect(this BridgeSection instance)
    {
        return new BridgeSectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrightnessEffect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrightnessEffectR Reflect(this BrightnessEffect instance)
    {
        return new BrightnessEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrightnessSetting allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrightnessSettingR Reflect(this BrightnessSetting instance)
    {
        return new BrightnessSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BroadcastEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BroadcastEventR Reflect(this BroadcastEvent instance)
    {
        return new BroadcastEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrokenVesselGlob allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrokenVesselGlobR Reflect(this BrokenVesselGlob instance)
    {
        return new BrokenVesselGlobR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrookNeoGeoConverterMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrookNeoGeoConverterMacNativeProfileR Reflect(this BrookNeoGeoConverterMacNativeProfile instance)
    {
        return new BrookNeoGeoConverterMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrookPS2ConverterMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrookPS2ConverterMacNativeProfileR Reflect(this BrookPS2ConverterMacNativeProfile instance)
    {
        return new BrookPS2ConverterMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BrummFlamePin allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BrummFlamePinR Reflect(this BrummFlamePin instance)
    {
        return new BrummFlamePinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BTC938AndroidUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BTC938AndroidUnityProfileR Reflect(this BTC938AndroidUnityProfile instance)
    {
        return new BTC938AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicAmazonUnityProfileR Reflect(this BuffaloClassicAmazonUnityProfile instance)
    {
        return new BuffaloClassicAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicMacNativeProfileR Reflect(this BuffaloClassicMacNativeProfile instance)
    {
        return new BuffaloClassicMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicMacUnityProfileR Reflect(this BuffaloClassicMacUnityProfile instance)
    {
        return new BuffaloClassicMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicWindowsNativeProfileR Reflect(this BuffaloClassicWindowsNativeProfile instance)
    {
        return new BuffaloClassicWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuffaloClassicWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuffaloClassicWindowsUnityProfileR Reflect(this BuffaloClassicWindowsUnityProfile instance)
    {
        return new BuffaloClassicWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuildEquippedCharms allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuildEquippedCharmsR Reflect(this BuildEquippedCharms instance)
    {
        return new BuildEquippedCharmsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuildMetadata allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuildMetadataR Reflect(this BuildMetadata instance)
    {
        return new BuildMetadataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of BuildString allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BuildStringR Reflect(this BuildString instance)
    {
        return new BuildStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Bullet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static BulletR Reflect(this Bullet instance)
    {
        return new BulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ButtonSkin allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ButtonSkinR Reflect(this ButtonSkin instance)
    {
        return new ButtonSkinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CallMethod allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CallMethodR Reflect(this CallMethod instance)
    {
        return new CallMethodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CallMethodProper allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CallMethodProperR Reflect(this CallMethodProper instance)
    {
        return new CallMethodProperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CallStaticMethod allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CallStaticMethodR Reflect(this CallStaticMethod instance)
    {
        return new CallStaticMethodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraControlAnimationEvents
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraControlAnimationEventsR Reflect(this CameraControlAnimationEvents instance)
    {
        return new CameraControlAnimationEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraController allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraControllerR Reflect(this CameraController instance)
    {
        return new CameraControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFade allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeR Reflect(this CameraFade instance)
    {
        return new CameraFadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFadeIn allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeInR Reflect(this CameraFadeIn instance)
    {
        return new CameraFadeInR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFadeInWithDelay allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeInWithDelayR Reflect(this CameraFadeInWithDelay instance)
    {
        return new CameraFadeInWithDelayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFadeOut allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFadeOutR Reflect(this CameraFadeOut instance)
    {
        return new CameraFadeOutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraFreezeInPlace allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraFreezeInPlaceR Reflect(this CameraFreezeInPlace instance)
    {
        return new CameraFreezeInPlaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraLockArea allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraLockAreaR Reflect(this CameraLockArea instance)
    {
        return new CameraLockAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraRepositionToHero allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraRepositionToHeroR Reflect(this CameraRepositionToHero instance)
    {
        return new CameraRepositionToHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraShake allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraShakeR Reflect(this CameraShake instance)
    {
        return new CameraShakeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CameraTarget allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CameraTargetR Reflect(this CameraTarget instance)
    {
        return new CameraTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CancelWalkerTurn allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CancelWalkerTurnR Reflect(this CancelWalkerTurn instance)
    {
        return new CancelWalkerTurnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CanvasGroupRemap allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CanvasGroupRemapR Reflect(this CanvasGroupRemap instance)
    {
        return new CanvasGroupRemapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CaptureAnimationEvent allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CaptureAnimationEventR Reflect(this CaptureAnimationEvent instance)
    {
        return new CaptureAnimationEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CaptureMouseEvents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CaptureMouseEventsR Reflect(this CaptureMouseEvents instance)
    {
        return new CaptureMouseEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CapturePoseAsAnimationClip allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CapturePoseAsAnimationClipR Reflect(this CapturePoseAsAnimationClip instance)
    {
        return new CapturePoseAsAnimationClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChainedNavGraph allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChainedNavGraphR Reflect(this ChainedNavGraph instance)
    {
        return new ChainedNavGraphR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChainSequence allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChainSequenceR Reflect(this ChainSequence instance)
    {
        return new ChainSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChangeFontByLanguage allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChangeFontByLanguageR Reflect(this ChangeFontByLanguage instance)
    {
        return new ChangeFontByLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmDisplay allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmDisplayR Reflect(this CharmDisplay instance)
    {
        return new CharmDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmIconList allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmIconListR Reflect(this CharmIconList instance)
    {
        return new CharmIconListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmItem allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmItemR Reflect(this CharmItem instance)
    {
        return new CharmItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmUpdateHandler allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmUpdateHandlerR Reflect(this CharmUpdateHandler instance)
    {
        return new CharmUpdateHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CharmVibrations allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CharmVibrationsR Reflect(this CharmVibrations instance)
    {
        return new CharmVibrationsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectR Reflect(this ChaseObject instance)
    {
        return new ChaseObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObjectGround allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectGroundR Reflect(this ChaseObjectGround instance)
    {
        return new ChaseObjectGroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObjectV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectV2R Reflect(this ChaseObjectV2 instance)
    {
        return new ChaseObjectV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ChaseObjectVertical allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ChaseObjectVerticalR Reflect(this ChaseObjectVertical instance)
    {
        return new ChaseObjectVerticalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheatManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheatManagerR Reflect(this CheatManager instance)
    {
        return new CheatManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckAlertRange allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckAlertRangeR Reflect(this CheckAlertRange instance)
    {
        return new CheckAlertRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckAlertRangeByName allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckAlertRangeByNameR Reflect(this CheckAlertRangeByName instance)
    {
        return new CheckAlertRangeByNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCanDreamWarpInScene allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCanDreamWarpInSceneR Reflect(this CheckCanDreamWarpInScene instance)
    {
        return new CheckCanDreamWarpInSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCanSeeHero allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCanSeeHeroR Reflect(this CheckCanSeeHero instance)
    {
        return new CheckCanSeeHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCollisionSide allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCollisionSideR Reflect(this CheckCollisionSide instance)
    {
        return new CheckCollisionSideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCollisionSideEnter allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCollisionSideEnterR Reflect(this CheckCollisionSideEnter instance)
    {
        return new CheckCollisionSideEnterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckCurrentMapZone allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckCurrentMapZoneR Reflect(this CheckCurrentMapZone instance)
    {
        return new CheckCurrentMapZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckGameState allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckGameStateR Reflect(this CheckGameState instance)
    {
        return new CheckGameStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckGGBossLevel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckGGBossLevelR Reflect(this CheckGGBossLevel instance)
    {
        return new CheckGGBossLevelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckInvincibility allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckInvincibilityR Reflect(this CheckInvincibility instance)
    {
        return new CheckInvincibilityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckIsChineseBuild allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckIsChineseBuildR Reflect(this CheckIsChineseBuild instance)
    {
        return new CheckIsChineseBuildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckpointSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckpointSpriteR Reflect(this CheckpointSprite instance)
    {
        return new CheckpointSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckSceneName allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckSceneNameR Reflect(this CheckSceneName instance)
    {
        return new CheckSceneNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckSendEventLimit allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckSendEventLimitR Reflect(this CheckSendEventLimit instance)
    {
        return new CheckSendEventLimitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckStaticBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckStaticBoolR Reflect(this CheckStaticBool instance)
    {
        return new CheckStaticBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckTargetDirection allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckTargetDirectionR Reflect(this CheckTargetDirection instance)
    {
        return new CheckTargetDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CheckTrackTriggerCount allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CheckTrackTriggerCountR Reflect(this CheckTrackTriggerCount instance)
    {
        return new CheckTrackTriggerCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicPlayer allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicPlayerR Reflect(this CinematicPlayer instance)
    {
        return new CinematicPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicSequence allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicSequenceR Reflect(this CinematicSequence instance)
    {
        return new CinematicSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicSkipPopup allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicSkipPopupR Reflect(this CinematicSkipPopup instance)
    {
        return new CinematicSkipPopupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicVideoPlayerConfig allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicVideoPlayerConfigR Reflect(this CinematicVideoPlayerConfig instance)
    {
        return new CinematicVideoPlayerConfigR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CinematicVideoReference allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CinematicVideoReferenceR Reflect(this CinematicVideoReference instance)
    {
        return new CinematicVideoReferenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CleanScenePrefabs allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CleanScenePrefabsR Reflect(this CleanScenePrefabs instance)
    {
        return new CleanScenePrefabsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ClearSaveButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ClearSaveButtonR Reflect(this ClearSaveButton instance)
    {
        return new ClearSaveButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Climber allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ClimberR Reflect(this Climber instance)
    {
        return new ClimberR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CloseMarkerMenu allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CloseMarkerMenuR Reflect(this CloseMarkerMenu instance)
    {
        return new CloseMarkerMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CodeProfiler allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CodeProfilerR Reflect(this CodeProfiler instance)
    {
        return new CodeProfilerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CodeWriter allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CodeWriterR Reflect(this CodeWriter instance)
    {
        return new CodeWriterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Collision2dEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Collision2dEventR Reflect(this Collision2dEvent instance)
    {
        return new Collision2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Collision2dEventLayer allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Collision2dEventLayerR Reflect(this Collision2dEventLayer instance)
    {
        return new Collision2dEventLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CollisionEnterEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CollisionEnterEventR Reflect(this CollisionEnterEvent instance)
    {
        return new CollisionEnterEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CollisionEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CollisionEventR Reflect(this CollisionEvent instance)
    {
        return new CollisionEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorChannel allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorChannelR Reflect(this ColorChannel instance)
    {
        return new ColorChannelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorChunk allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorChunkR Reflect(this ColorChunk instance)
    {
        return new ColorChunkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorCurvesManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorCurvesManagerR Reflect(this ColorCurvesManager instance)
    {
        return new ColorCurvesManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorFader allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorFaderR Reflect(this ColorFader instance)
    {
        return new ColorFaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorInterpolate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorInterpolateR Reflect(this ColorInterpolate instance)
    {
        return new ColorInterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColorRamp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColorRampR Reflect(this ColorRamp instance)
    {
        return new ColorRampR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ColourPainter allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ColourPainterR Reflect(this ColourPainter instance)
    {
        return new ColourPainterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Comment allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CommentR Reflect(this Comment instance)
    {
        return new CommentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CompareDistance2D allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CompareDistance2DR Reflect(this CompareDistance2D instance)
    {
        return new CompareDistance2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CompareNames allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CompareNamesR Reflect(this CompareNames instance)
    {
        return new CompareNamesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Compute_DT_EventArgs allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Compute_DT_EventArgsR Reflect(this Compute_DT_EventArgs instance)
    {
        return new Compute_DT_EventArgsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConnectControllerPanel allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConnectControllerPanelR Reflect(this ConnectControllerPanel instance)
    {
        return new ConnectControllerPanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConstrainMovement allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConstrainMovementR Reflect(this ConstrainMovement instance)
    {
        return new ConstrainMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConstrainPosition allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConstrainPositionR Reflect(this ConstrainPosition instance)
    {
        return new ConstrainPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ContentArea allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ContentAreaR Reflect(this ContentArea instance)
    {
        return new ContentAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ContentPackDetailsUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ContentPackDetailsUIR Reflect(this ContentPackDetailsUI instance)
    {
        return new ContentPackDetailsUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerButtonLabel allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerButtonLabelR Reflect(this ControllerButtonLabel instance)
    {
        return new ControllerButtonLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerButtonPositions allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerButtonPositionsR Reflect(this ControllerButtonPositions instance)
    {
        return new ControllerButtonPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerDetect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerDetectR Reflect(this ControllerDetect instance)
    {
        return new ControllerDetectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerImage allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerImageR Reflect(this ControllerImage instance)
    {
        return new ControllerImageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerIsGrounded allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerIsGroundedR Reflect(this ControllerIsGrounded instance)
    {
        return new ControllerIsGroundedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerMapping allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerMappingR Reflect(this ControllerMapping instance)
    {
        return new ControllerMappingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerMove allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerMoveR Reflect(this ControllerMove instance)
    {
        return new ControllerMoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerProfileButton allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerProfileButtonR Reflect(this ControllerProfileButton instance)
    {
        return new ControllerProfileButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerProfileButtons allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerProfileButtonsR Reflect(this ControllerProfileButtons instance)
    {
        return new ControllerProfileButtonsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerSettings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerSettingsR Reflect(this ControllerSettings instance)
    {
        return new ControllerSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ControllerSimpleMove allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ControllerSimpleMoveR Reflect(this ControllerSimpleMove instance)
    {
        return new ControllerSimpleMoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToColorR Reflect(this ConvertBoolToColor instance)
    {
        return new ConvertBoolToColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToFloatR Reflect(this ConvertBoolToFloat instance)
    {
        return new ConvertBoolToFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToIntR Reflect(this ConvertBoolToInt instance)
    {
        return new ConvertBoolToIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertBoolToString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertBoolToStringR Reflect(this ConvertBoolToString instance)
    {
        return new ConvertBoolToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertEnumToString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertEnumToStringR Reflect(this ConvertEnumToString instance)
    {
        return new ConvertEnumToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertFloatToInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertFloatToIntR Reflect(this ConvertFloatToInt instance)
    {
        return new ConvertFloatToIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertFloatToString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertFloatToStringR Reflect(this ConvertFloatToString instance)
    {
        return new ConvertFloatToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertIntToFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertIntToFloatR Reflect(this ConvertIntToFloat instance)
    {
        return new ConvertIntToFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertIntToString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertIntToStringR Reflect(this ConvertIntToString instance)
    {
        return new ConvertIntToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertMaterialToObject allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertMaterialToObjectR Reflect(this ConvertMaterialToObject instance)
    {
        return new ConvertMaterialToObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertSecondsToString allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertSecondsToStringR Reflect(this ConvertSecondsToString instance)
    {
        return new ConvertSecondsToStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConvertStringToInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConvertStringToIntR Reflect(this ConvertStringToInt instance)
    {
        return new ConvertStringToIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorBelt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorBeltR Reflect(this ConveyorBelt instance)
    {
        return new ConveyorBeltR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorMovement allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorMovementR Reflect(this ConveyorMovement instance)
    {
        return new ConveyorMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorMovementHero allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorMovementHeroR Reflect(this ConveyorMovementHero instance)
    {
        return new ConveyorMovementHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorSpeedZone allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorSpeedZoneR Reflect(this ConveyorSpeedZone instance)
    {
        return new ConveyorSpeedZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ConveyorZone allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ConveyorZoneR Reflect(this ConveyorZone instance)
    {
        return new ConveyorZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CopyParentSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CopyParentSpriteR Reflect(this CopyParentSprite instance)
    {
        return new CopyParentSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CoreLoop allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CoreLoopR Reflect(this CoreLoop instance)
    {
        return new CoreLoopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CoroutineQueue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CoroutineQueueR Reflect(this CoroutineQueue instance)
    {
        return new CoroutineQueueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Corpse allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseR Reflect(this Corpse instance)
    {
        return new CorpseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseBitEnd allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseBitEndR Reflect(this CorpseBitEnd instance)
    {
        return new CorpseBitEndR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseChunker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseChunkerR Reflect(this CorpseChunker instance)
    {
        return new CorpseChunkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseDeathStun allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseDeathStunR Reflect(this CorpseDeathStun instance)
    {
        return new CorpseDeathStunR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseDeathStunChunker allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseDeathStunChunkerR Reflect(this CorpseDeathStunChunker instance)
    {
        return new CorpseDeathStunChunkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseFungusExplode allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseFungusExplodeR Reflect(this CorpseFungusExplode instance)
    {
        return new CorpseFungusExplodeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseGoopExplode allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseGoopExplodeR Reflect(this CorpseGoopExplode instance)
    {
        return new CorpseGoopExplodeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseHatcher allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseHatcherR Reflect(this CorpseHatcher instance)
    {
        return new CorpseHatcherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseSpineBurst allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseSpineBurstR Reflect(this CorpseSpineBurst instance)
    {
        return new CorpseSpineBurstR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CorpseZomHive allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CorpseZomHiveR Reflect(this CorpseZomHive instance)
    {
        return new CorpseZomHiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Crawler allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CrawlerR Reflect(this Crawler instance)
    {
        return new CrawlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateEmptyObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateEmptyObjectR Reflect(this CreateEmptyObject instance)
    {
        return new CreateEmptyObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateGameObjectPool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateGameObjectPoolR Reflect(this CreateGameObjectPool instance)
    {
        return new CreateGameObjectPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateObjectR Reflect(this CreateObject instance)
    {
        return new CreateObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreatePool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreatePoolR Reflect(this CreatePool instance)
    {
        return new CreatePoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreatePoolObjects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreatePoolObjectsR Reflect(this CreatePoolObjects instance)
    {
        return new CreatePoolObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreateUIMsgGetItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreateUIMsgGetItemR Reflect(this CreateUIMsgGetItem instance)
    {
        return new CreateUIMsgGetItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CreditsHelper allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CreditsHelperR Reflect(this CreditsHelper instance)
    {
        return new CreditsHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CrystalPieceSize allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CrystalPieceSizeR Reflect(this CrystalPieceSize instance)
    {
        return new CrystalPieceSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CursorHighlight allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CursorHighlightR Reflect(this CursorHighlight instance)
    {
        return new CursorHighlightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveColorR Reflect(this CurveColor instance)
    {
        return new CurveColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveFloat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveFloatR Reflect(this CurveFloat instance)
    {
        return new CurveFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveRect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveRectR Reflect(this CurveRect instance)
    {
        return new CurveRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CurveVector3 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CurveVector3R Reflect(this CurveVector3 instance)
    {
        return new CurveVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CustomActionTest allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CustomActionTestR Reflect(this CustomActionTest instance)
    {
        return new CustomActionTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CutsceneHelper allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CutsceneHelperR Reflect(this CutsceneHelper instance)
    {
        return new CutsceneHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CutToCamera allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CutToCameraR Reflect(this CutToCamera instance)
    {
        return new CutToCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of CycloneDust allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static CycloneDustR Reflect(this CycloneDust instance)
    {
        return new CycloneDustR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DamageEffectTicker allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageEffectTickerR Reflect(this DamageEffectTicker instance)
    {
        return new DamageEffectTickerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DamageEnemies allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageEnemiesR Reflect(this DamageEnemies instance)
    {
        return new DamageEnemiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DamageHero allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DamageHeroR Reflect(this DamageHero instance)
    {
        return new DamageHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DashEffect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DashEffectR Reflect(this DashEffect instance)
    {
        return new DashEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateAfter2dtkAnimation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateAfter2dtkAnimationR Reflect(this DeactivateAfter2dtkAnimation instance)
    {
        return new DeactivateAfter2dtkAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateAfterDelay allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateAfterDelayR Reflect(this DeactivateAfterDelay instance)
    {
        return new DeactivateAfterDelayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateGameObjectPerBuildType
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateGameObjectPerBuildTypeR Reflect(this DeactivateGameObjectPerBuildType instance)
    {
        return new DeactivateGameObjectPerBuildTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateIfPlayerdataFalse allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateIfPlayerdataFalseR Reflect(this DeactivateIfPlayerdataFalse instance)
    {
        return new DeactivateIfPlayerdataFalseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateIfPlayerdataFalseDelayed
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateIfPlayerdataFalseDelayedR Reflect(this DeactivateIfPlayerdataFalseDelayed instance)
    {
        return new DeactivateIfPlayerdataFalseDelayedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateIfPlayerdataTrue allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateIfPlayerdataTrueR Reflect(this DeactivateIfPlayerdataTrue instance)
    {
        return new DeactivateIfPlayerdataTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeactivateInDarknessWithoutLantern
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeactivateInDarknessWithoutLanternR Reflect(this DeactivateInDarknessWithoutLantern instance)
    {
        return new DeactivateInDarknessWithoutLanternR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeadZoneFunc allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeadZoneFuncR Reflect(this DeadZoneFunc instance)
    {
        return new DeadZoneFuncR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebrisParticle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebrisParticleR Reflect(this DebrisParticle instance)
    {
        return new DebrisParticleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebrisPiece allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebrisPieceR Reflect(this DebrisPiece instance)
    {
        return new DebrisPieceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugBool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugBoolR Reflect(this DebugBool instance)
    {
        return new DebugBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugDrawShape allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugDrawShapeR Reflect(this DebugDrawShape instance)
    {
        return new DebugDrawShapeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugEnum allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugEnumR Reflect(this DebugEnum instance)
    {
        return new DebugEnumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugFloat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugFloatR Reflect(this DebugFloat instance)
    {
        return new DebugFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugFsmVariable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugFsmVariableR Reflect(this DebugFsmVariable instance)
    {
        return new DebugFsmVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugGameObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugGameObjectR Reflect(this DebugGameObject instance)
    {
        return new DebugGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugInt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugIntR Reflect(this DebugInt instance)
    {
        return new DebugIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugLog allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugLogR Reflect(this DebugLog instance)
    {
        return new DebugLogR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugLogConsole allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugLogConsoleR Reflect(this DebugLogConsole instance)
    {
        return new DebugLogConsoleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugLogDeprecatedEvent allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugLogDeprecatedEventR Reflect(this DebugLogDeprecatedEvent instance)
    {
        return new DebugLogDeprecatedEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugObjectR Reflect(this DebugObject instance)
    {
        return new DebugObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugVector2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugVector2R Reflect(this DebugVector2 instance)
    {
        return new DebugVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DebugVector3 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DebugVector3R Reflect(this DebugVector3 instance)
    {
        return new DebugVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Decelerate allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecelerateR Reflect(this Decelerate instance)
    {
        return new DecelerateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DecelerateV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecelerateV2R Reflect(this DecelerateV2 instance)
    {
        return new DecelerateV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DecelerateXY allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecelerateXYR Reflect(this DecelerateXY instance)
    {
        return new DecelerateXYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DecrementPlayerDataInt allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DecrementPlayerDataIntR Reflect(this DecrementPlayerDataInt instance)
    {
        return new DecrementPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeprecatedPrefab allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeprecatedPrefabR Reflect(this DeprecatedPrefab instance)
    {
        return new DeprecatedPrefabR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DesktopCinematicVideoPlayer allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DesktopCinematicVideoPlayerR Reflect(this DesktopCinematicVideoPlayer instance)
    {
        return new DesktopCinematicVideoPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DesktopPlatform allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DesktopPlatformR Reflect(this DesktopPlatform instance)
    {
        return new DesktopPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyAllChildren allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyAllChildrenR Reflect(this DestroyAllChildren instance)
    {
        return new DestroyAllChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyArrayList allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyArrayListR Reflect(this DestroyArrayList instance)
    {
        return new DestroyArrayListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyComponent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyComponentR Reflect(this DestroyComponent instance)
    {
        return new DestroyComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyEnemyBullet allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyEnemyBulletR Reflect(this DestroyEnemyBullet instance)
    {
        return new DestroyEnemyBulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyHashTable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyHashTableR Reflect(this DestroyHashTable instance)
    {
        return new DestroyHashTableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyObjectR Reflect(this DestroyObject instance)
    {
        return new DestroyObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyObjects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyObjectsR Reflect(this DestroyObjects instance)
    {
        return new DestroyObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyOutOfBounds allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyOutOfBoundsR Reflect(this DestroyOutOfBounds instance)
    {
        return new DestroyOutOfBoundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroyPersonalPools allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroyPersonalPoolsR Reflect(this DestroyPersonalPools instance)
    {
        return new DestroyPersonalPoolsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestroySelf allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestroySelfR Reflect(this DestroySelf instance)
    {
        return new DestroySelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DestructibleProp allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DestructiblePropR Reflect(this DestructibleProp instance)
    {
        return new DestructiblePropR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DetachChildren allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DetachChildrenR Reflect(this DetachChildren instance)
    {
        return new DetachChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DetectCollisonDown allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DetectCollisonDownR Reflect(this DetectCollisonDown instance)
    {
        return new DetectCollisonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceBindingSource allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceBindingSourceR Reflect(this DeviceBindingSource instance)
    {
        return new DeviceBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceBindingSourceListener allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceBindingSourceListenerR Reflect(this DeviceBindingSourceListener instance)
    {
        return new DeviceBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceOrientationEvent allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceOrientationEventR Reflect(this DeviceOrientationEvent instance)
    {
        return new DeviceOrientationEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceShakeEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceShakeEventR Reflect(this DeviceShakeEvent instance)
    {
        return new DeviceShakeEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DeviceVibrate allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DeviceVibrateR Reflect(this DeviceVibrate instance)
    {
        return new DeviceVibrateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DialogueBox allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DialogueBoxR Reflect(this DialogueBox instance)
    {
        return new DialogueBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisableAfterTime allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisableAfterTimeR Reflect(this DisableAfterTime instance)
    {
        return new DisableAfterTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisableIfZPos allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisableIfZPosR Reflect(this DisableIfZPos instance)
    {
        return new DisableIfZPosR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisplayCurrentLanguage allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisplayCurrentLanguageR Reflect(this DisplayCurrentLanguage instance)
    {
        return new DisplayCurrentLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisplayItemAmount allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisplayItemAmountR Reflect(this DisplayItemAmount instance)
    {
        return new DisplayItemAmountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DisplayOnWorldMapOnly allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DisplayOnWorldMapOnlyR Reflect(this DisplayOnWorldMapOnly instance)
    {
        return new DisplayOnWorldMapOnlyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceBetweenPoints allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceBetweenPointsR Reflect(this DistanceBetweenPoints instance)
    {
        return new DistanceBetweenPointsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceBetweenPoints2D allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceBetweenPoints2DR Reflect(this DistanceBetweenPoints2D instance)
    {
        return new DistanceBetweenPoints2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceFly allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceFlyR Reflect(this DistanceFly instance)
    {
        return new DistanceFlyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceFlySmooth allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceFlySmoothR Reflect(this DistanceFlySmooth instance)
    {
        return new DistanceFlySmoothR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceFlyV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceFlyV2R Reflect(this DistanceFlyV2 instance)
    {
        return new DistanceFlyV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DistanceWalk allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DistanceWalkR Reflect(this DistanceWalk instance)
    {
        return new DistanceWalkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DontClinkGates allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DontClinkGatesR Reflect(this DontClinkGates instance)
    {
        return new DontClinkGatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DontDestroyOnLoad allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DontDestroyOnLoadR Reflect(this DontDestroyOnLoad instance)
    {
        return new DontDestroyOnLoadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     DragonRiseArcadeStickMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static DragonRiseArcadeStickMacNativeProfileR Reflect(this DragonRiseArcadeStickMacNativeProfile instance)
    {
        return new DragonRiseArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawDebugLine allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawDebugLineR Reflect(this DrawDebugLine instance)
    {
        return new DrawDebugLineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawDebugRay allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawDebugRayR Reflect(this DrawDebugRay instance)
    {
        return new DrawDebugRayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawFullscreenColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawFullscreenColorR Reflect(this DrawFullscreenColor instance)
    {
        return new DrawFullscreenColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawStateLabel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawStateLabelR Reflect(this DrawStateLabel instance)
    {
        return new DrawStateLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DrawTexture allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DrawTextureR Reflect(this DrawTexture instance)
    {
        return new DrawTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DreamPlant allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DreamPlantR Reflect(this DreamPlant instance)
    {
        return new DreamPlantR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DreamPlantOrb allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DreamPlantOrbR Reflect(this DreamPlantOrb instance)
    {
        return new DreamPlantOrbR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DreamPlatform allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DreamPlatformR Reflect(this DreamPlatform instance)
    {
        return new DreamPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Drip allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static DripR Reflect(this Drip instance)
    {
        return new DripR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Dripper allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DripperR Reflect(this Dripper instance)
    {
        return new DripperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DroidBoxPS3AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DroidBoxPS3AndroidUnityProfileR Reflect(this DroidBoxPS3AndroidUnityProfile instance)
    {
        return new DroidBoxPS3AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DroidBoxXboxAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DroidBoxXboxAndroidUnityProfileR Reflect(this DroidBoxXboxAndroidUnityProfile instance)
    {
        return new DroidBoxXboxAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DropCrystal allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DropCrystalR Reflect(this DropCrystal instance)
    {
        return new DropCrystalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DropPlatform allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DropPlatformR Reflect(this DropPlatform instance)
    {
        return new DropPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DualShock4MFiNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DualShock4MFiNativeProfileR Reflect(this DualShock4MFiNativeProfile instance)
    {
        return new DualShock4MFiNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of DustyPlatform allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static DustyPlatformR Reflect(this DustyPlatform instance)
    {
        return new DustyPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseColorR Reflect(this EaseColor instance)
    {
        return new EaseColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseFloat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseFloatR Reflect(this EaseFloat instance)
    {
        return new EaseFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseRect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseRectR Reflect(this EaseRect instance)
    {
        return new EaseRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EaseVector3 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EaseVector3R Reflect(this EaseVector3 instance)
    {
        return new EaseVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EASportsControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EASportsControllerMacNativeProfileR Reflect(this EASportsControllerMacNativeProfile instance)
    {
        return new EASportsControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EasySmxEsm9101AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EasySmxEsm9101AndroidUnityProfileR Reflect(this EasySmxEsm9101AndroidUnityProfile instance)
    {
        return new EasySmxEsm9101AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoFC30ProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoFC30ProAndroidUnityProfileR Reflect(this EightBitdoFC30ProAndroidUnityProfile instance)
    {
        return new EightBitdoFC30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoGenericAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoGenericAndroidUnityProfileR Reflect(this EightBitdoGenericAndroidUnityProfile instance)
    {
        return new EightBitdoGenericAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoN30Pro2AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoN30Pro2AndroidUnityProfileR Reflect(this EightBitdoN30Pro2AndroidUnityProfile instance)
    {
        return new EightBitdoN30Pro2AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProAndroidUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static EightBitdoNES30ProAndroidUnityProfileR Reflect(this EightBitdoNES30ProAndroidUnityProfile instance)
    {
        return new EightBitdoNES30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoNES30ProBTMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProBTMacNativeProfileR Reflect(this EightBitdoNES30ProBTMacNativeProfile instance)
    {
        return new EightBitdoNES30ProBTMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoNES30ProMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoNES30ProMacUnityProfileR Reflect(this EightBitdoNES30ProMacUnityProfile instance)
    {
        return new EightBitdoNES30ProMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProUSBMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static EightBitdoNES30ProUSBMacNativeProfileR Reflect(this EightBitdoNES30ProUSBMacNativeProfile instance)
    {
        return new EightBitdoNES30ProUSBMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static EightBitdoNES30ProWindowsNativeProfileR Reflect(this EightBitdoNES30ProWindowsNativeProfile instance)
    {
        return new EightBitdoNES30ProWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoNES30ProWindowsUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static EightBitdoNES30ProWindowsUnityProfileR Reflect(this EightBitdoNES30ProWindowsUnityProfile instance)
    {
        return new EightBitdoNES30ProWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSF30ProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSF30ProAndroidUnityProfileR Reflect(this EightBitdoSF30ProAndroidUnityProfile instance)
    {
        return new EightBitdoSF30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     EightBitdoSF30ProWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static EightBitdoSF30ProWindowsNativeProfileR Reflect(this EightBitdoSF30ProWindowsNativeProfile instance)
    {
        return new EightBitdoSF30ProWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30AndroidUnityProfileR Reflect(this EightBitdoSFC30AndroidUnityProfile instance)
    {
        return new EightBitdoSFC30AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30MacNativeProfileR Reflect(this EightBitdoSFC30MacNativeProfile instance)
    {
        return new EightBitdoSFC30MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30MacUnityProfileR Reflect(this EightBitdoSFC30MacUnityProfile instance)
    {
        return new EightBitdoSFC30MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30WindowsNativeProfileR Reflect(this EightBitdoSFC30WindowsNativeProfile instance)
    {
        return new EightBitdoSFC30WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSFC30WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSFC30WindowsUnityProfileR Reflect(this EightBitdoSFC30WindowsUnityProfile instance)
    {
        return new EightBitdoSFC30WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSN30ProAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSN30ProAndroidUnityProfileR Reflect(this EightBitdoSN30ProAndroidUnityProfile instance)
    {
        return new EightBitdoSN30ProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30AndroidUnityProfileR Reflect(this EightBitdoSNES30AndroidUnityProfile instance)
    {
        return new EightBitdoSNES30AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30MacNativeProfileR Reflect(this EightBitdoSNES30MacNativeProfile instance)
    {
        return new EightBitdoSNES30MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30MacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30MacUnityProfileR Reflect(this EightBitdoSNES30MacUnityProfile instance)
    {
        return new EightBitdoSNES30MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30WindowsNativeProfileR Reflect(this EightBitdoSNES30WindowsNativeProfile instance)
    {
        return new EightBitdoSNES30WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EightBitdoSNES30WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EightBitdoSNES30WindowsUnityProfileR Reflect(this EightBitdoSNES30WindowsUnityProfile instance)
    {
        return new EightBitdoSNES30WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ElecomControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ElecomControllerMacNativeProfileR Reflect(this ElecomControllerMacNativeProfile instance)
    {
        return new ElecomControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableAnimationR Reflect(this EnableAnimation instance)
    {
        return new EnableAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableBehaviour allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableBehaviourR Reflect(this EnableBehaviour instance)
    {
        return new EnableBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableFog allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableFogR Reflect(this EnableFog instance)
    {
        return new EnableFogR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableFSM allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableFSMR Reflect(this EnableFSM instance)
    {
        return new EnableFSMR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnableGUI allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnableGUIR Reflect(this EnableGUI instance)
    {
        return new EnableGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EndBeta allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EndBetaR Reflect(this EndBeta instance)
    {
        return new EndBetaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EndBossSceneTimer allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EndBossSceneTimerR Reflect(this EndBossSceneTimer instance)
    {
        return new EndBossSceneTimerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EndGGBossScene allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EndGGBossSceneR Reflect(this EndGGBossScene instance)
    {
        return new EndGGBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyBullet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyBulletR Reflect(this EnemyBullet instance)
    {
        return new EnemyBulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsR Reflect(this EnemyDeathEffects instance)
    {
        return new EnemyDeathEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsBlackKnight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsBlackKnightR Reflect(this EnemyDeathEffectsBlackKnight instance)
    {
        return new EnemyDeathEffectsBlackKnightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsBubble allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsBubbleR Reflect(this EnemyDeathEffectsBubble instance)
    {
        return new EnemyDeathEffectsBubbleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsDung allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsDungR Reflect(this EnemyDeathEffectsDung instance)
    {
        return new EnemyDeathEffectsDungR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsNoEffect allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsNoEffectR Reflect(this EnemyDeathEffectsNoEffect instance)
    {
        return new EnemyDeathEffectsNoEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDeathEffectsUninfected allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDeathEffectsUninfectedR Reflect(this EnemyDeathEffectsUninfected instance)
    {
        return new EnemyDeathEffectsUninfectedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyDreamnailReaction allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyDreamnailReactionR Reflect(this EnemyDreamnailReaction instance)
    {
        return new EnemyDreamnailReactionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsArmoured allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsArmouredR Reflect(this EnemyHitEffectsArmoured instance)
    {
        return new EnemyHitEffectsArmouredR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsBlackKnight allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsBlackKnightR Reflect(this EnemyHitEffectsBlackKnight instance)
    {
        return new EnemyHitEffectsBlackKnightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsGhost allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsGhostR Reflect(this EnemyHitEffectsGhost instance)
    {
        return new EnemyHitEffectsGhostR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsShade allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsShadeR Reflect(this EnemyHitEffectsShade instance)
    {
        return new EnemyHitEffectsShadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyHitEffectsUninfected allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyHitEffectsUninfectedR Reflect(this EnemyHitEffectsUninfected instance)
    {
        return new EnemyHitEffectsUninfectedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyKillEventListener allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyKillEventListenerR Reflect(this EnemyKillEventListener instance)
    {
        return new EnemyKillEventListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyPusher allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyPusherR Reflect(this EnemyPusher instance)
    {
        return new EnemyPusherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyPusherIgnore allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyPusherIgnoreR Reflect(this EnemyPusherIgnore instance)
    {
        return new EnemyPusherIgnoreR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemySpawner allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemySpawnerR Reflect(this EnemySpawner instance)
    {
        return new EnemySpawnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnemyWakeRegion allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnemyWakeRegionR Reflect(this EnemyWakeRegion instance)
    {
        return new EnemyWakeRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EngagedUserPanel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EngagedUserPanelR Reflect(this EngagedUserPanel instance)
    {
        return new EngagedUserPanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EngagementPromptPanel allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EngagementPromptPanelR Reflect(this EngagementPromptPanel instance)
    {
        return new EngagementPromptPanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnumCompare allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnumCompareR Reflect(this EnumCompare instance)
    {
        return new EnumCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnumeratorLayout allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnumeratorLayoutR Reflect(this EnumeratorLayout instance)
    {
        return new EnumeratorLayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnumSwitch allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnumSwitchR Reflect(this EnumSwitch instance)
    {
        return new EnumSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EnviroRegion allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EnviroRegionR Reflect(this EnviroRegion instance)
    {
        return new EnviroRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ErrorEventArgs allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ErrorEventArgsR Reflect(this ErrorEventArgs instance)
    {
        return new ErrorEventArgsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EventRegister allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EventRegisterR Reflect(this EventRegister instance)
    {
        return new EventRegisterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of EventTargetVariable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static EventTargetVariableR Reflect(this EventTargetVariable instance)
    {
        return new EventTargetVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExecutionerXMacUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExecutionerXMacUnityProfileR Reflect(this ExecutionerXMacUnityProfile instance)
    {
        return new ExecutionerXMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExecutionerXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExecutionerXWindowsUnityProfileR Reflect(this ExecutionerXWindowsUnityProfile instance)
    {
        return new ExecutionerXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Explosion allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExplosionR Reflect(this HutongGames.PlayMaker.Actions.Explosion instance)
    {
        return new ExplosionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExtraDamageable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExtraDamageableR Reflect(this ExtraDamageable instance)
    {
        return new ExtraDamageableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ExtraDamageableProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ExtraDamageableProxyR Reflect(this ExtraDamageableProxy instance)
    {
        return new ExtraDamageableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceAngle allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceAngleR Reflect(this FaceAngle instance)
    {
        return new FaceAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceAngleSimple allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceAngleSimpleR Reflect(this FaceAngleSimple instance)
    {
        return new FaceAngleSimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceAngleV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceAngleV2R Reflect(this FaceAngleV2 instance)
    {
        return new FaceAngleV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceDirection allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceDirectionR Reflect(this FaceDirection instance)
    {
        return new FaceDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceInfoR Reflect(this FaceInfo instance)
    {
        return new FaceInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FaceObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FaceObjectR Reflect(this FaceObject instance)
    {
        return new FaceObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeAudio allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeAudioR Reflect(this FadeAudio instance)
    {
        return new FadeAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeColorFader allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeColorFaderR Reflect(this FadeColorFader instance)
    {
        return new FadeColorFaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeGroup allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeGroupR Reflect(this FadeGroup instance)
    {
        return new FadeGroupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeGroupDown allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeGroupDownR Reflect(this FadeGroupDown instance)
    {
        return new FadeGroupDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeGroupUp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeGroupUpR Reflect(this FadeGroupUp instance)
    {
        return new FadeGroupUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FadeSequence allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FadeSequenceR Reflect(this FadeSequence instance)
    {
        return new FadeSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FakeBat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FakeBatR Reflect(this FakeBat instance)
    {
        return new FakeBatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FastAction allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FastActionR Reflect(this FastAction instance)
    {
        return new FastActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FastNoise allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FastNoiseR Reflect(this FastNoise instance)
    {
        return new FastNoiseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindAlertRange allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindAlertRangeR Reflect(this FindAlertRange instance)
    {
        return new FindAlertRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindArrayList allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindArrayListR Reflect(this FindArrayList instance)
    {
        return new FindArrayListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindChild allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindChildR Reflect(this FindChild instance)
    {
        return new FindChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindClosest allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindClosestR Reflect(this FindClosest instance)
    {
        return new FindClosestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FindGameObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FindGameObjectR Reflect(this FindGameObject instance)
    {
        return new FindGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FinishFSM allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FinishFSMR Reflect(this FinishFSM instance)
    {
        return new FinishFSMR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FinishingRigidBody allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FinishingRigidBodyR Reflect(this FinishingRigidBody instance)
    {
        return new FinishingRigidBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FireAtTarget allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FireAtTargetR Reflect(this FireAtTarget instance)
    {
        return new FireAtTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FireGrimmBall allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FireGrimmBallR Reflect(this FireGrimmBall instance)
    {
        return new FireGrimmBallR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FixVerticalAlign allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FixVerticalAlignR Reflect(this FixVerticalAlign instance)
    {
        return new FixVerticalAlignR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FixXBG301AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FixXBG301AndroidUnityProfileR Reflect(this FixXBG301AndroidUnityProfile instance)
    {
        return new FixXBG301AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlamePin allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlamePinR Reflect(this FlamePin instance)
    {
        return new FlamePinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlareAndroidUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlareAndroidUnityProfileR Reflect(this FlareAndroidUnityProfile instance)
    {
        return new FlareAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlarePlayAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlarePlayAndroidUnityProfileR Reflect(this FlarePlayAndroidUnityProfile instance)
    {
        return new FlarePlayAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlashMaterialGroup allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlashMaterialGroupR Reflect(this FlashMaterialGroup instance)
    {
        return new FlashMaterialGroupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Flicker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlickerR Reflect(this Flicker instance)
    {
        return new FlickerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingFlashingGeo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingFlashingGeoR Reflect(this FlingFlashingGeo instance)
    {
        return new FlingFlashingGeoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectR Reflect(this FlingObject instance)
    {
        return new FlingObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjects allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsR Reflect(this FlingObjects instance)
    {
        return new FlingObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjectsFromGlobalPool allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsFromGlobalPoolR Reflect(this FlingObjectsFromGlobalPool instance)
    {
        return new FlingObjectsFromGlobalPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjectsFromGlobalPoolTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsFromGlobalPoolTimeR Reflect(this FlingObjectsFromGlobalPoolTime instance)
    {
        return new FlingObjectsFromGlobalPoolTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlingObjectsFromGlobalPoolVel
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlingObjectsFromGlobalPoolVelR Reflect(this FlingObjectsFromGlobalPoolVel instance)
    {
        return new FlingObjectsFromGlobalPoolVelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlipPlatform allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlipPlatformR Reflect(this FlipPlatform instance)
    {
        return new FlipPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FlipScale allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FlipScaleR Reflect(this FlipScale instance)
    {
        return new FlipScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAbs allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAbsR Reflect(this FloatAbs instance)
    {
        return new FloatAbsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAdd allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAddR Reflect(this FloatAdd instance)
    {
        return new FloatAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAddMultiple allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAddMultipleR Reflect(this FloatAddMultiple instance)
    {
        return new FloatAddMultipleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatAddV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatAddV2R Reflect(this FloatAddV2 instance)
    {
        return new FloatAddV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatChanged allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatChangedR Reflect(this FloatChanged instance)
    {
        return new FloatChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatClamp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatClampR Reflect(this FloatClamp instance)
    {
        return new FloatClampR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatCompare allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatCompareR Reflect(this FloatCompare instance)
    {
        return new FloatCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatDivide allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatDivideR Reflect(this FloatDivide instance)
    {
        return new FloatDivideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatDivideV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatDivideV2R Reflect(this FloatDivideV2 instance)
    {
        return new FloatDivideV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatInRange allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatInRangeR Reflect(this FloatInRange instance)
    {
        return new FloatInRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatInterpolate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatInterpolateR Reflect(this FloatInterpolate instance)
    {
        return new FloatInterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatMultiply allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatMultiplyR Reflect(this FloatMultiply instance)
    {
        return new FloatMultiplyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatMultiplyV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatMultiplyV2R Reflect(this FloatMultiplyV2 instance)
    {
        return new FloatMultiplyV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatOperator allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatOperatorR Reflect(this FloatOperator instance)
    {
        return new FloatOperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSignTest allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSignTestR Reflect(this FloatSignTest instance)
    {
        return new FloatSignTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSquareRoot allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSquareRootR Reflect(this FloatSquareRoot instance)
    {
        return new FloatSquareRootR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSubtract allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSubtractR Reflect(this FloatSubtract instance)
    {
        return new FloatSubtractR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatSwitch allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatSwitchR Reflect(this FloatSwitch instance)
    {
        return new FloatSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FloatTestToBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FloatTestToBoolR Reflect(this FloatTestToBool instance)
    {
        return new FloatTestToBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForceCameraAspect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForceCameraAspectR Reflect(this ForceCameraAspect instance)
    {
        return new ForceCameraAspectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForceCameraAspectLite allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForceCameraAspectLiteR Reflect(this ForceCameraAspectLite instance)
    {
        return new ForceCameraAspectLiteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FormatString allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FormatStringR Reflect(this FormatString instance)
    {
        return new FormatStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForwardAllEvents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForwardAllEventsR Reflect(this ForwardAllEvents instance)
    {
        return new ForwardAllEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ForwardEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ForwardEventR Reflect(this ForwardEvent instance)
    {
        return new ForwardEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FSMActivator allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FSMActivatorR Reflect(this FSMActivator instance)
    {
        return new FSMActivatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmArraySet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmArraySetR Reflect(this FsmArraySet instance)
    {
        return new FsmArraySetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmEventOptions allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmEventOptionsR Reflect(this FsmEventOptions instance)
    {
        return new FsmEventOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmStateSwitch allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmStateSwitchR Reflect(this FsmStateSwitch instance)
    {
        return new FsmStateSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of FsmStateTest allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static FsmStateTestR Reflect(this FsmStateTest instance)
    {
        return new FsmStateTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     FusionXboxOneControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static FusionXboxOneControllerMacNativeProfileR Reflect(
        this FusionXboxOneControllerMacNativeProfile instance)
    {
        return new FusionXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCameras allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCamerasRR Reflect(this GameCameras instance)
    {
        return new GameCamerasRR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCameraTextureDisplay allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCameraTextureDisplayR Reflect(this GameCameraTextureDisplay instance)
    {
        return new GameCameraTextureDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCompletionScreen allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCompletionScreenR Reflect(this GameCompletionScreen instance)
    {
        return new GameCompletionScreenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameConfig allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameConfigR Reflect(this GameConfig instance)
    {
        return new GameConfigR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCoreUnityProfile allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCoreUnityProfileR Reflect(this GameCoreUnityProfile instance)
    {
        return new GameCoreUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeMayflashWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeMayflashWindowsNativeProfileR Reflect(this GameCubeMayflashWindowsNativeProfile instance)
    {
        return new GameCubeMayflashWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeMayflashWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeMayflashWindowsUnityProfileR Reflect(this GameCubeMayflashWindowsUnityProfile instance)
    {
        return new GameCubeMayflashWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeWindowsNativeProfileR Reflect(this GameCubeWindowsNativeProfile instance)
    {
        return new GameCubeWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameCubeWindowsUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameCubeWindowsUnityProfileR Reflect(this GameCubeWindowsUnityProfile instance)
    {
        return new GameCubeWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameMap allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameMapR Reflect(this GameMap instance)
    {
        return new GameMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameMenuOptions allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameMenuOptionsR Reflect(this GameMenuOptions instance)
    {
        return new GameMenuOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectChanged allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectChangedR Reflect(this GameObjectChanged instance)
    {
        return new GameObjectChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectCompare allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectCompareR Reflect(this GameObjectCompare instance)
    {
        return new GameObjectCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectCompareTag allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectCompareTagR Reflect(this GameObjectCompareTag instance)
    {
        return new GameObjectCompareTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectExists allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectExistsR Reflect(this GameObjectExists instance)
    {
        return new GameObjectExistsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectHasChildren allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectHasChildrenR Reflect(this GameObjectHasChildren instance)
    {
        return new GameObjectHasChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectIsChildOf allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectIsChildOfR Reflect(this GameObjectIsChildOf instance)
    {
        return new GameObjectIsChildOfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectIsNull allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectIsNullR Reflect(this GameObjectIsNull instance)
    {
        return new GameObjectIsNullR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectIsVisible allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectIsVisibleR Reflect(this GameObjectIsVisible instance)
    {
        return new GameObjectIsVisibleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameObjectTagSwitch allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameObjectTagSwitchR Reflect(this GameObjectTagSwitch instance)
    {
        return new GameObjectTagSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GamepadVibration allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GamepadVibrationR Reflect(this GamepadVibration instance)
    {
        return new GamepadVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GamepadVibrationMixer allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GamepadVibrationMixerR Reflect(this GamepadVibrationMixer instance)
    {
        return new GamepadVibrationMixerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSaveLoadedArgs allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSaveLoadedArgsR Reflect(this GameSaveLoadedArgs instance)
    {
        return new GameSaveLoadedArgsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSettings allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSettingsR Reflect(this GameSettings instance)
    {
        return new GameSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSirG3sAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSirG3sAndroidUnityProfileR Reflect(this GameSirG3sAndroidUnityProfile instance)
    {
        return new GameSirG3sAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSirG3wAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSirG3wAndroidUnityProfileR Reflect(this GameSirG3wAndroidUnityProfile instance)
    {
        return new GameSirG3wAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameSirG4sAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameSirG4sAndroidUnityProfileR Reflect(this GameSirG4sAndroidUnityProfile instance)
    {
        return new GameSirG4sAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameStickLinuxUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameStickLinuxUnityProfileR Reflect(this GameStickLinuxUnityProfile instance)
    {
        return new GameStickLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameStickUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameStickUnityProfileR Reflect(this GameStickUnityProfile instance)
    {
        return new GameStickUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameStopControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameStopControllerMacNativeProfileR Reflect(this GameStopControllerMacNativeProfile instance)
    {
        return new GameStopControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GameVersionData allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GameVersionDataR Reflect(this GameVersionData instance)
    {
        return new GameVersionDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GateSetAudio allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GateSetAudioR Reflect(this GateSetAudio instance)
    {
        return new GateSetAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GateSnap allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GateSnapR Reflect(this GateSnap instance)
    {
        return new GateSnapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GCManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GCManagerR Reflect(this GCManager instance)
    {
        return new GCManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenerateJournalNewDot allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenerateJournalNewDotR Reflect(this GenerateJournalNewDot instance)
    {
        return new GenerateJournalNewDotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeneratePortraitFrame allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeneratePortraitFrameR Reflect(this GeneratePortraitFrame instance)
    {
        return new GeneratePortraitFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenericAndroidUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenericAndroidUnityProfileR Reflect(this GenericAndroidUnityProfile instance)
    {
        return new GenericAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenericBlackBerryUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenericBlackBerryUnityProfileR Reflect(this GenericBlackBerryUnityProfile instance)
    {
        return new GenericBlackBerryUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GenericLinuxUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GenericLinuxUnityProfileR Reflect(this GenericLinuxUnityProfile instance)
    {
        return new GenericLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoControl allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoControlR Reflect(this GeoControl instance)
    {
        return new GeoControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoCounter allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoCounterR Reflect(this GeoCounter instance)
    {
        return new GeoCounterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoRock allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoRockR Reflect(this GeoRock instance)
    {
        return new GeoRockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GeoRockData allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GeoRockDataR Reflect(this GeoRockData instance)
    {
        return new GeoRockDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetACosine allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetACosineR Reflect(this GetACosine instance)
    {
        return new GetACosineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAngleBetweenPoints allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAngleBetweenPointsR Reflect(this GetAngleBetweenPoints instance)
    {
        return new GetAngleBetweenPointsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAngleToTarget allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAngleToTargetR Reflect(this GetAngleToTarget instance)
    {
        return new GetAngleToTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAngleToTarget2D allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAngleToTarget2DR Reflect(this GetAngleToTarget2D instance)
    {
        return new GetAngleToTarget2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorApplyRootMotion allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorApplyRootMotionR Reflect(this GetAnimatorApplyRootMotion instance)
    {
        return new GetAnimatorApplyRootMotionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorBody allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorBodyR Reflect(this GetAnimatorBody instance)
    {
        return new GetAnimatorBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorBoneGameObject allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorBoneGameObjectR Reflect(this GetAnimatorBoneGameObject instance)
    {
        return new GetAnimatorBoneGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorBoolR Reflect(this GetAnimatorBool instance)
    {
        return new GetAnimatorBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCullingMode allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCullingModeR Reflect(this GetAnimatorCullingMode instance)
    {
        return new GetAnimatorCullingModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentStateInfo allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentStateInfoR Reflect(this GetAnimatorCurrentStateInfo instance)
    {
        return new GetAnimatorCurrentStateInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentStateInfoIsName
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentStateInfoIsNameR Reflect(this GetAnimatorCurrentStateInfoIsName instance)
    {
        return new GetAnimatorCurrentStateInfoIsNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentStateInfoIsTag
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentStateInfoIsTagR Reflect(this GetAnimatorCurrentStateInfoIsTag instance)
    {
        return new GetAnimatorCurrentStateInfoIsTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorCurrentTransitionInfo
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorCurrentTransitionInfoR Reflect(this GetAnimatorCurrentTransitionInfo instance)
    {
        return new GetAnimatorCurrentTransitionInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GetAnimatorCurrentTransitionInfoIsName allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static GetAnimatorCurrentTransitionInfoIsNameR Reflect(this GetAnimatorCurrentTransitionInfoIsName instance)
    {
        return new GetAnimatorCurrentTransitionInfoIsNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GetAnimatorCurrentTransitionInfoIsUserName allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static GetAnimatorCurrentTransitionInfoIsUserNameR Reflect(this
        GetAnimatorCurrentTransitionInfoIsUserName instance)
    {
        return new GetAnimatorCurrentTransitionInfoIsUserNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorDelta allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorDeltaR Reflect(this GetAnimatorDelta instance)
    {
        return new GetAnimatorDeltaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorFeetPivotActive allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorFeetPivotActiveR Reflect(this GetAnimatorFeetPivotActive instance)
    {
        return new GetAnimatorFeetPivotActiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorFloatR Reflect(this GetAnimatorFloat instance)
    {
        return new GetAnimatorFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorGravityWeight allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorGravityWeightR Reflect(this GetAnimatorGravityWeight instance)
    {
        return new GetAnimatorGravityWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorHumanScale allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorHumanScaleR Reflect(this GetAnimatorHumanScale instance)
    {
        return new GetAnimatorHumanScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIKGoal allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIKGoalR Reflect(this GetAnimatorIKGoal instance)
    {
        return new GetAnimatorIKGoalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIntR Reflect(this GetAnimatorInt instance)
    {
        return new GetAnimatorIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsControlled allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsControlledR Reflect(this GetAnimatorIsControlled instance)
    {
        return new GetAnimatorIsControlledR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsHuman allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsHumanR Reflect(this GetAnimatorIsHuman instance)
    {
        return new GetAnimatorIsHumanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsLayerInTransition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsLayerInTransitionR Reflect(this GetAnimatorIsLayerInTransition instance)
    {
        return new GetAnimatorIsLayerInTransitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorIsMatchingTarget allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorIsMatchingTargetR Reflect(this GetAnimatorIsMatchingTarget instance)
    {
        return new GetAnimatorIsMatchingTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GetAnimatorIsParameterControlledByCurve allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static GetAnimatorIsParameterControlledByCurveR Reflect(
        this GetAnimatorIsParameterControlledByCurve instance)
    {
        return new GetAnimatorIsParameterControlledByCurveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayerCount allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayerCountR Reflect(this GetAnimatorLayerCount instance)
    {
        return new GetAnimatorLayerCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayerName allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayerNameR Reflect(this GetAnimatorLayerName instance)
    {
        return new GetAnimatorLayerNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayersAffectMassCenter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayersAffectMassCenterR Reflect(this GetAnimatorLayersAffectMassCenter instance)
    {
        return new GetAnimatorLayersAffectMassCenterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLayerWeight allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLayerWeightR Reflect(this GetAnimatorLayerWeight instance)
    {
        return new GetAnimatorLayerWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorLeftFootBottomHeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorLeftFootBottomHeightR Reflect(this GetAnimatorLeftFootBottomHeight instance)
    {
        return new GetAnimatorLeftFootBottomHeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorNextStateInfo allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorNextStateInfoR Reflect(this GetAnimatorNextStateInfo instance)
    {
        return new GetAnimatorNextStateInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorPivot allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorPivotR Reflect(this GetAnimatorPivot instance)
    {
        return new GetAnimatorPivotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorPlayBackSpeed allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorPlayBackSpeedR Reflect(this GetAnimatorPlayBackSpeed instance)
    {
        return new GetAnimatorPlayBackSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorPlayBackTime allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorPlayBackTimeR Reflect(this GetAnimatorPlayBackTime instance)
    {
        return new GetAnimatorPlayBackTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorRightFootBottomHeight
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorRightFootBottomHeightR Reflect(this GetAnimatorRightFootBottomHeight instance)
    {
        return new GetAnimatorRightFootBottomHeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorRoot allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorRootR Reflect(this GetAnimatorRoot instance)
    {
        return new GetAnimatorRootR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorSpeed allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorSpeedR Reflect(this GetAnimatorSpeed instance)
    {
        return new GetAnimatorSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAnimatorTarget allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAnimatorTargetR Reflect(this GetAnimatorTarget instance)
    {
        return new GetAnimatorTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetASine allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetASineR Reflect(this GetASine instance)
    {
        return new GetASineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtanR Reflect(this GetAtan instance)
    {
        return new GetAtanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtan2R Reflect(this GetAtan2 instance)
    {
        return new GetAtan2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan2FromVector2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtan2FromVector2R Reflect(this GetAtan2FromVector2 instance)
    {
        return new GetAtan2FromVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAtan2FromVector3 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAtan2FromVector3R Reflect(this GetAtan2FromVector3 instance)
    {
        return new GetAtan2FromVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAudioVolume allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAudioVolumeR Reflect(this GetAudioVolume instance)
    {
        return new GetAudioVolumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAxis allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAxisR Reflect(this GetAxis instance)
    {
        return new GetAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetAxisVector allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetAxisVectorR Reflect(this GetAxisVector instance)
    {
        return new GetAxisVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetBoolProxy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetBoolProxyR Reflect(this GetBoolProxy instance)
    {
        return new GetBoolProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetButton allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetButtonR Reflect(this GetButton instance)
    {
        return new GetButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetButtonDown allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetButtonDownR Reflect(this GetButtonDown instance)
    {
        return new GetButtonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetButtonUp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetButtonUpR Reflect(this GetButtonUp instance)
    {
        return new GetButtonUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCameraPixelDimensions allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCameraPixelDimensionsR Reflect(this GetCameraPixelDimensions instance)
    {
        return new GetCameraPixelDimensionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCanSeeHero allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCanSeeHeroR Reflect(this GetCanSeeHero instance)
    {
        return new GetCanSeeHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCharmNum allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCharmNumR Reflect(this GetCharmNum instance)
    {
        return new GetCharmNumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCharmNumString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCharmNumStringR Reflect(this GetCharmNumString instance)
    {
        return new GetCharmNumStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCharmString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCharmStringR Reflect(this GetCharmString instance)
    {
        return new GetCharmStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetChild allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetChildR Reflect(this GetChild instance)
    {
        return new GetChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetChildCount allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetChildCountR Reflect(this GetChildCount instance)
    {
        return new GetChildCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetChildNum allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetChildNumR Reflect(this GetChildNum instance)
    {
        return new GetChildNumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetColliderRange allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetColliderRangeR Reflect(this GetColliderRange instance)
    {
        return new GetColliderRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCollision2dInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCollision2dInfoR Reflect(this GetCollision2dInfo instance)
    {
        return new GetCollision2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCollisionInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCollisionInfoR Reflect(this GetCollisionInfo instance)
    {
        return new GetCollisionInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetColorRGBA allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetColorRGBAR Reflect(this GetColorRGBA instance)
    {
        return new GetColorRGBAR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetComponent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetComponentR Reflect(this GetComponent instance)
    {
        return new GetComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetConstantsValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetConstantsValueR Reflect(this GetConstantsValue instance)
    {
        return new GetConstantsValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetControllerCollisionFlags allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetControllerCollisionFlagsR Reflect(this GetControllerCollisionFlags instance)
    {
        return new GetControllerCollisionFlagsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetControllerHitInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetControllerHitInfoR Reflect(this GetControllerHitInfo instance)
    {
        return new GetControllerHitInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCosine allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCosineR Reflect(this GetCosine instance)
    {
        return new GetCosineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentLanguageAsString allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentLanguageAsStringR Reflect(this GetCurrentLanguageAsString instance)
    {
        return new GetCurrentLanguageAsStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentMusicCue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentMusicCueR Reflect(this GetCurrentMusicCue instance)
    {
        return new GetCurrentMusicCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentMusicCueName allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentMusicCueNameR Reflect(this GetCurrentMusicCueName instance)
    {
        return new GetCurrentMusicCueNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetCurrentResolution allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetCurrentResolutionR Reflect(this GetCurrentResolution instance)
    {
        return new GetCurrentResolutionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetDeviceAcceleration allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetDeviceAccelerationR Reflect(this GetDeviceAcceleration instance)
    {
        return new GetDeviceAccelerationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetDeviceRoll allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetDeviceRollR Reflect(this GetDeviceRoll instance)
    {
        return new GetDeviceRollR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetDistance allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetDistanceR Reflect(this GetDistance instance)
    {
        return new GetDistanceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetEventInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetEventInfoR Reflect(this GetEventInfo instance)
    {
        return new GetEventInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetEventProperties allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetEventPropertiesR Reflect(this GetEventProperties instance)
    {
        return new GetEventPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetEventSender allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetEventSenderR Reflect(this GetEventSender instance)
    {
        return new GetEventSenderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFloatProxy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFloatProxyR Reflect(this GetFloatProxy instance)
    {
        return new GetFloatProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmArray allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmArrayR Reflect(this GetFsmArray instance)
    {
        return new GetFsmArrayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmArrayItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmArrayItemR Reflect(this GetFsmArrayItem instance)
    {
        return new GetFsmArrayItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmBool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmBoolR Reflect(this GetFsmBool instance)
    {
        return new GetFsmBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmColorR Reflect(this GetFsmColor instance)
    {
        return new GetFsmColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmEnum allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmEnumR Reflect(this GetFsmEnum instance)
    {
        return new GetFsmEnumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmFloat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmFloatR Reflect(this GetFsmFloat instance)
    {
        return new GetFsmFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmGameObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmGameObjectR Reflect(this GetFsmGameObject instance)
    {
        return new GetFsmGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmInt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmIntR Reflect(this GetFsmInt instance)
    {
        return new GetFsmIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmMaterial allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmMaterialR Reflect(this GetFsmMaterial instance)
    {
        return new GetFsmMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmObjectR Reflect(this GetFsmObject instance)
    {
        return new GetFsmObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmQuaternion allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmQuaternionR Reflect(this GetFsmQuaternion instance)
    {
        return new GetFsmQuaternionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmRect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmRectR Reflect(this GetFsmRect instance)
    {
        return new GetFsmRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmState allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmStateR Reflect(this GetFsmState instance)
    {
        return new GetFsmStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmString allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmStringR Reflect(this GetFsmString instance)
    {
        return new GetFsmStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmTexture allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmTextureR Reflect(this GetFsmTexture instance)
    {
        return new GetFsmTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVariable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVariableR Reflect(this GetFsmVariable instance)
    {
        return new GetFsmVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVariables allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVariablesR Reflect(this GetFsmVariables instance)
    {
        return new GetFsmVariablesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVector2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVector2R Reflect(this GetFsmVector2 instance)
    {
        return new GetFsmVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetFsmVector3 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetFsmVector3R Reflect(this GetFsmVector3 instance)
    {
        return new GetFsmVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetGrandparent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetGrandparentR Reflect(this GetGrandparent instance)
    {
        return new GetGrandparentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetHero allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetHeroR Reflect(this GetHero instance)
    {
        return new GetHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetHP allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static GetHPR Reflect(this GetHP instance)
    {
        return new GetHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetHPEveryFrame allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetHPEveryFrameR Reflect(this GetHPEveryFrame instance)
    {
        return new GetHPEveryFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputAxis allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputAxisR Reflect(this GetInControlDeviceInputAxis instance)
    {
        return new GetInControlDeviceInputAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputAxisVector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputAxisVectorR Reflect(this GetInControlDeviceInputAxisVector instance)
    {
        return new GetInControlDeviceInputAxisVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputButtonR Reflect(this GetInControlDeviceInputButton instance)
    {
        return new GetInControlDeviceInputButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputButtonDown
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputButtonDownR Reflect(this GetInControlDeviceInputButtonDown instance)
    {
        return new GetInControlDeviceInputButtonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetInControlDeviceInputButtonUp
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetInControlDeviceInputButtonUpR Reflect(this GetInControlDeviceInputButtonUp instance)
    {
        return new GetInControlDeviceInputButtonUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetIntProxy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetIntProxyR Reflect(this GetIntProxy instance)
    {
        return new GetIntProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetIPhoneSettings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetIPhoneSettingsR Reflect(this GetIPhoneSettings instance)
    {
        return new GetIPhoneSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetIsDead allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetIsDeadR Reflect(this GetIsDead instance)
    {
        return new GetIsDeadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetJointBreak2dInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetJointBreak2dInfoR Reflect(this GetJointBreak2dInfo instance)
    {
        return new GetJointBreak2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetJointBreakInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetJointBreakInfoR Reflect(this GetJointBreakInfo instance)
    {
        return new GetJointBreakInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetKey allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetKeyR Reflect(this GetKey instance)
    {
        return new GetKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetKeyDown allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetKeyDownR Reflect(this GetKeyDown instance)
    {
        return new GetKeyDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetKeyUp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetKeyUpR Reflect(this GetKeyUp instance)
    {
        return new GetKeyUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLanguageString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLanguageStringR Reflect(this GetLanguageString instance)
    {
        return new GetLanguageStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLanguageStringProcessed allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLanguageStringProcessedR Reflect(this GetLanguageStringProcessed instance)
    {
        return new GetLanguageStringProcessedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLastEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLastEventR Reflect(this GetLastEvent instance)
    {
        return new GetLastEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLastPointerDataInfo allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLastPointerDataInfoR Reflect(this GetLastPointerDataInfo instance)
    {
        return new GetLastPointerDataInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLayer allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLayerR Reflect(this GetLayer instance)
    {
        return new GetLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetLocationInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetLocationInfoR Reflect(this GetLocationInfo instance)
    {
        return new GetLocationInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMainCamera allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMainCameraR Reflect(this GetMainCamera instance)
    {
        return new GetMainCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMass allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMassR Reflect(this GetMass instance)
    {
        return new GetMassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMass2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMass2dR Reflect(this GetMass2d instance)
    {
        return new GetMass2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMaterial allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMaterialR Reflect(this GetMaterial instance)
    {
        return new GetMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMaterialColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMaterialColorR Reflect(this GetMaterialColor instance)
    {
        return new GetMaterialColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMaterialTexture allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMaterialTextureR Reflect(this GetMaterialTexture instance)
    {
        return new GetMaterialTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMeshRendererBounds allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMeshRendererBoundsR Reflect(this GetMeshRendererBounds instance)
    {
        return new GetMeshRendererBoundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMidPoint allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMidPointR Reflect(this GetMidPoint instance)
    {
        return new GetMidPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseButtonR Reflect(this GetMouseButton instance)
    {
        return new GetMouseButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseButtonDown allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseButtonDownR Reflect(this GetMouseButtonDown instance)
    {
        return new GetMouseButtonDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseButtonUp allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseButtonUpR Reflect(this GetMouseButtonUp instance)
    {
        return new GetMouseButtonUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseX allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseXR Reflect(this GetMouseX instance)
    {
        return new GetMouseXR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetMouseY allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetMouseYR Reflect(this GetMouseY instance)
    {
        return new GetMouseYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNailDamage allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNailDamageR Reflect(this GetNailDamage instance)
    {
        return new GetNailDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetName allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNameR Reflect(this GetName instance)
    {
        return new GetNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNamedParent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNamedParentR Reflect(this GetNamedParent instance)
    {
        return new GetNamedParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextChild allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextChildR Reflect(this GetNextChild instance)
    {
        return new GetNextChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextLineCast2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextLineCast2dR Reflect(this GetNextLineCast2d instance)
    {
        return new GetNextLineCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextOverlapArea2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextOverlapArea2dR Reflect(this GetNextOverlapArea2d instance)
    {
        return new GetNextOverlapArea2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextOverlapCircle2d allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextOverlapCircle2dR Reflect(this GetNextOverlapCircle2d instance)
    {
        return new GetNextOverlapCircle2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextOverlapPoint2d allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextOverlapPoint2dR Reflect(this GetNextOverlapPoint2d instance)
    {
        return new GetNextOverlapPoint2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextPreSpawnedGameObject allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextPreSpawnedGameObjectR Reflect(this GetNextPreSpawnedGameObject instance)
    {
        return new GetNextPreSpawnedGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetNextRayCast2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetNextRayCast2dR Reflect(this GetNextRayCast2d instance)
    {
        return new GetNextRayCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetOwner allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetOwnerR Reflect(this GetOwner instance)
    {
        return new GetOwnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetParent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetParentR Reflect(this GetParent instance)
    {
        return new GetParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetParticleCollisionInfo allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetParticleCollisionInfoR Reflect(this GetParticleCollisionInfo instance)
    {
        return new GetParticleCollisionInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPersistentBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPersistentBoolR Reflect(this GetPersistentBool instance)
    {
        return new GetPersistentBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPersistentBoolFromSaveData
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPersistentBoolFromSaveDataR Reflect(this GetPersistentBoolFromSaveData instance)
    {
        return new GetPersistentBoolFromSaveDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataBoolR Reflect(this GetPlayerDataBool instance)
    {
        return new GetPlayerDataBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataFloatR Reflect(this GetPlayerDataFloat instance)
    {
        return new GetPlayerDataFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataIntR Reflect(this GetPlayerDataInt instance)
    {
        return new GetPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataStringR Reflect(this GetPlayerDataString instance)
    {
        return new GetPlayerDataStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPlayerDataVector3 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPlayerDataVector3R Reflect(this GetPlayerDataVector3 instance)
    {
        return new GetPlayerDataVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPosition allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPositionR Reflect(this GetPosition instance)
    {
        return new GetPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPosition2D allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPosition2DR Reflect(this GetPosition2D instance)
    {
        return new GetPosition2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPreInstantiatedGameObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPreInstantiatedGameObjectR Reflect(this GetPreInstantiatedGameObject instance)
    {
        return new GetPreInstantiatedGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetPreviousStateName allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPreviousStateNameR Reflect(this GetPreviousStateName instance)
    {
        return new GetPreviousStateNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetProperty allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetPropertyR Reflect(this GetProperty instance)
    {
        return new GetPropertyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionEulerAngles allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionEulerAnglesR Reflect(this GetQuaternionEulerAngles instance)
    {
        return new GetQuaternionEulerAnglesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionFromRotation allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionFromRotationR Reflect(this GetQuaternionFromRotation instance)
    {
        return new GetQuaternionFromRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionMultipliedByQuaternion
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionMultipliedByQuaternionR Reflect(this GetQuaternionMultipliedByQuaternion instance)
    {
        return new GetQuaternionMultipliedByQuaternionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetQuaternionMultipliedByVector
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetQuaternionMultipliedByVectorR Reflect(this GetQuaternionMultipliedByVector instance)
    {
        return new GetQuaternionMultipliedByVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRandomChild allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRandomChildR Reflect(this GetRandomChild instance)
    {
        return new GetRandomChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRandomObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRandomObjectR Reflect(this GetRandomObject instance)
    {
        return new GetRandomObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRaycastAllInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRaycastAllInfoR Reflect(this GetRaycastAllInfo instance)
    {
        return new GetRaycastAllInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRayCastHit2dInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRayCastHit2dInfoR Reflect(this GetRayCastHit2dInfo instance)
    {
        return new GetRayCastHit2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRaycastHitInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRaycastHitInfoR Reflect(this GetRaycastHitInfo instance)
    {
        return new GetRaycastHitInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRectFields allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRectFieldsR Reflect(this GetRectFields instance)
    {
        return new GetRectFieldsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRespawningHero allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRespawningHeroR Reflect(this GetRespawningHero instance)
    {
        return new GetRespawningHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRoot allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRootR Reflect(this GetRoot instance)
    {
        return new GetRootR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetRotation allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetRotationR Reflect(this GetRotation instance)
    {
        return new GetRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetScale allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetScaleR Reflect(this GetScale instance)
    {
        return new GetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetScreenHeight allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetScreenHeightR Reflect(this GetScreenHeight instance)
    {
        return new GetScreenHeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetScreenWidth allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetScreenWidthR Reflect(this GetScreenWidth instance)
    {
        return new GetScreenWidthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSine allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSineR Reflect(this GetSine instance)
    {
        return new GetSineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSpeed allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSpeedR Reflect(this GetSpeed instance)
    {
        return new GetSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSpeed2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSpeed2dR Reflect(this GetSpeed2d instance)
    {
        return new GetSpeed2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSpriteRendererSprite allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSpriteRendererSpriteR Reflect(this GetSpriteRendererSprite instance)
    {
        return new GetSpriteRendererSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStaticVariable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStaticVariableR Reflect(this GetStaticVariable instance)
    {
        return new GetStaticVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringLeft allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringLeftR Reflect(this GetStringLeft instance)
    {
        return new GetStringLeftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringLength allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringLengthR Reflect(this GetStringLength instance)
    {
        return new GetStringLengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringProxyR Reflect(this GetStringProxy instance)
    {
        return new GetStringProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetStringRight allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetStringRightR Reflect(this GetStringRight instance)
    {
        return new GetStringRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSubstring allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSubstringR Reflect(this GetSubstring instance)
    {
        return new GetSubstringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetSystemDateTime allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetSystemDateTimeR Reflect(this GetSystemDateTime instance)
    {
        return new GetSystemDateTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTag allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTagR Reflect(this GetTag instance)
    {
        return new GetTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTagCount allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTagCountR Reflect(this GetTagCount instance)
    {
        return new GetTagCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTan allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTanR Reflect(this GetTan instance)
    {
        return new GetTanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTimeInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTimeInfoR Reflect(this GetTimeInfo instance)
    {
        return new GetTimeInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTMProLeftVertex allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTMProLeftVertexR Reflect(this GetTMProLeftVertex instance)
    {
        return new GetTMProLeftVertexR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTouchCount allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTouchCountR Reflect(this GetTouchCount instance)
    {
        return new GetTouchCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTouchInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTouchInfoR Reflect(this GetTouchInfo instance)
    {
        return new GetTouchInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTransform allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTransformR Reflect(this GetTransform instance)
    {
        return new GetTransformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTrigger2dInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTrigger2dInfoR Reflect(this GetTrigger2dInfo instance)
    {
        return new GetTrigger2dInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetTriggerInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetTriggerInfoR Reflect(this GetTriggerInfo instance)
    {
        return new GetTriggerInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVariableProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVariableProxyR Reflect(this GetVariableProxy instance)
    {
        return new GetVariableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVector2XY allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVector2XYR Reflect(this GetVector2XY instance)
    {
        return new GetVector2XYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVector3Proxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVector3ProxyR Reflect(this GetVector3Proxy instance)
    {
        return new GetVector3ProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVector3XYZ allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVector3XYZR Reflect(this GetVector3XYZ instance)
    {
        return new GetVector3XYZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVectorLength allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVectorLengthR Reflect(this GetVectorLength instance)
    {
        return new GetVectorLengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVelocity allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVelocityR Reflect(this GetVelocity instance)
    {
        return new GetVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVelocity2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVelocity2dR Reflect(this GetVelocity2d instance)
    {
        return new GetVelocity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVelocityAsAngle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVelocityAsAngleR Reflect(this GetVelocityAsAngle instance)
    {
        return new GetVelocityAsAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVertexCount allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVertexCountR Reflect(this GetVertexCount instance)
    {
        return new GetVertexCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetVertexPosition allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetVertexPositionR Reflect(this GetVertexPosition instance)
    {
        return new GetVertexPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetXDistance allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetXDistanceR Reflect(this GetXDistance instance)
    {
        return new GetXDistanceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GetYDistance allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GetYDistanceR Reflect(this GetYDistance instance)
    {
        return new GetYDistanceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBossSceneUnlocked allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBossSceneUnlockedR Reflect(this GGCheckBossSceneUnlocked instance)
    {
        return new GGCheckBossSceneUnlockedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBossSequenceList allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBossSequenceListR Reflect(this GGCheckBossSequenceList instance)
    {
        return new GGCheckBossSequenceListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundCharms allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundCharmsR Reflect(this GGCheckBoundCharms instance)
    {
        return new GGCheckBoundCharmsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundHeart allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundHeartR Reflect(this GGCheckBoundHeart instance)
    {
        return new GGCheckBoundHeartR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundNail allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundNailR Reflect(this GGCheckBoundNail instance)
    {
        return new GGCheckBoundNailR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckBoundSoul allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckBoundSoulR Reflect(this GGCheckBoundSoul instance)
    {
        return new GGCheckBoundSoulR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfBossScene allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfBossSceneR Reflect(this GGCheckIfBossScene instance)
    {
        return new GGCheckIfBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfBossSequence allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfBossSequenceR Reflect(this GGCheckIfBossSequence instance)
    {
        return new GGCheckIfBossSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfBossSequenceCompleted
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfBossSequenceCompletedR Reflect(this GGCheckIfBossSequenceCompleted instance)
    {
        return new GGCheckIfBossSequenceCompletedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfFirstBossScene allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfFirstBossSceneR Reflect(this GGCheckIfFirstBossScene instance)
    {
        return new GGCheckIfFirstBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIfLastBossScene allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIfLastBossSceneR Reflect(this GGCheckIfLastBossScene instance)
    {
        return new GGCheckIfLastBossSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCheckIsBossRushMode allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCheckIsBossRushModeR Reflect(this GGCheckIsBossRushMode instance)
    {
        return new GGCheckIsBossRushModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGCountCompletedBossDoors allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGCountCompletedBossDoorsR Reflect(this GGCountCompletedBossDoors instance)
    {
        return new GGCountCompletedBossDoorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGGetBossDoorCompletion allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGGetBossDoorCompletionR Reflect(this GGGetBossDoorCompletion instance)
    {
        return new GGGetBossDoorCompletionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGGetCompletedBindings allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGGetCompletedBindingsR Reflect(this GGGetCompletedBindings instance)
    {
        return new GGGetCompletedBindingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGGetTotalBindings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGGetTotalBindingsR Reflect(this GGGetTotalBindings instance)
    {
        return new GGGetTotalBindingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGResetBossSequenceController
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGResetBossSequenceControllerR Reflect(this GGResetBossSequenceController instance)
    {
        return new GGResetBossSequenceControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GGWaitForBossSceneTransitionIn
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GGWaitForBossSceneTransitionInR Reflect(this GGWaitForBossSceneTransitionIn instance)
    {
        return new GGWaitForBossSceneTransitionInR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GhostMovement allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GhostMovementR Reflect(this GhostMovement instance)
    {
        return new GhostMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlobalPrefabDefaults allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlobalPrefabDefaultsR Reflect(this GlobalPrefabDefaults instance)
    {
        return new GlobalPrefabDefaultsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlobControl allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlobControlR Reflect(this GlobControl instance)
    {
        return new GlobControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlowResponse allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlowResponseR Reflect(this GlowResponse instance)
    {
        return new GlowResponseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GlowResponseEnd allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GlowResponseEndR Reflect(this GlowResponseEnd instance)
    {
        return new GlowResponseEndR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Glyph2D allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Glyph2DR Reflect(this Glyph2D instance)
    {
        return new Glyph2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderGateIcon allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderGateIconR Reflect(this GodfinderGateIcon instance)
    {
        return new GodfinderGateIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderGateIconManager allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderGateIconManagerR Reflect(this GodfinderGateIconManager instance)
    {
        return new GodfinderGateIconManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderIcon allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderIconR Reflect(this GodfinderIcon instance)
    {
        return new GodfinderIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GodfinderInvIcon allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GodfinderInvIconR Reflect(this GodfinderInvIcon instance)
    {
        return new GodfinderInvIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaMacNativeProfileR Reflect(this GoogleStadiaMacNativeProfile instance)
    {
        return new GoogleStadiaMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaMacUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaMacUnityProfileR Reflect(this GoogleStadiaMacUnityProfile instance)
    {
        return new GoogleStadiaMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaUnityProfileR Reflect(this GoogleStadiaUnityProfile instance)
    {
        return new GoogleStadiaUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaWindowsNativeProfileR Reflect(this GoogleStadiaWindowsNativeProfile instance)
    {
        return new GoogleStadiaWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GoogleStadiaWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GoogleStadiaWindowsUnityProfileR Reflect(this GoogleStadiaWindowsUnityProfile instance)
    {
        return new GoogleStadiaWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GotoPreviousState allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GotoPreviousStateR Reflect(this GotoPreviousState instance)
    {
        return new GotoPreviousStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeMarker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeMarkerR Reflect(this GradeMarker instance)
    {
        return new GradeMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeOverride allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeOverrideR Reflect(this GradeOverride instance)
    {
        return new GradeOverrideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeTrigger allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeTriggerR Reflect(this GradeTrigger instance)
    {
        return new GradeTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GradeZone allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GradeZoneR Reflect(this GradeZone instance)
    {
        return new GradeZoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Grass allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassR Reflect(this Grass instance)
    {
        return new GrassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassBehaviour allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassBehaviourR Reflect(this GrassBehaviour instance)
    {
        return new GrassBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassCut allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassCutR Reflect(this GrassCut instance)
    {
        return new GrassCutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassSpriteBehaviour allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassSpriteBehaviourR Reflect(this GrassSpriteBehaviour instance)
    {
        return new GrassSpriteBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrassWind allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrassWindR Reflect(this GrassWind instance)
    {
        return new GrassWindR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     GreenThrottleAtlasAndroidUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static GreenThrottleAtlasAndroidUnityProfileR Reflect(this GreenThrottleAtlasAndroidUnityProfile instance)
    {
        return new GreenThrottleAtlasAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GridNavGraph allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GridNavGraphR Reflect(this GridNavGraph instance)
    {
        return new GridNavGraphR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrimmballControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrimmballControlR Reflect(this GrimmballControl instance)
    {
        return new GrimmballControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrimmChildFly allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrimmChildFlyR Reflect(this GrimmChildFly instance)
    {
        return new GrimmChildFlyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrimmEnemyRange allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrimmEnemyRangeR Reflect(this GrimmEnemyRange instance)
    {
        return new GrimmEnemyRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrubBGControl allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrubBGControlR Reflect(this GrubBGControl instance)
    {
        return new GrubBGControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GrubPin allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GrubPinR Reflect(this GrubPin instance)
    {
        return new GrubPinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIBox allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIBoxR Reflect(this GUIBox instance)
    {
        return new GUIBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIButton allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIButtonR Reflect(this GUIButton instance)
    {
        return new GUIButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIHorizontalSlider allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIHorizontalSliderR Reflect(this GUIHorizontalSlider instance)
    {
        return new GUIHorizontalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILabel allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILabelR Reflect(this GUILabel instance)
    {
        return new GUILabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginArea allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginAreaR Reflect(this GUILayoutBeginArea instance)
    {
        return new GUILayoutBeginAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginAreaFollowObject
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginAreaFollowObjectR Reflect(this GUILayoutBeginAreaFollowObject instance)
    {
        return new GUILayoutBeginAreaFollowObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginCentered allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginCenteredR Reflect(this GUILayoutBeginCentered instance)
    {
        return new GUILayoutBeginCenteredR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginHorizontal allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginHorizontalR Reflect(this GUILayoutBeginHorizontal instance)
    {
        return new GUILayoutBeginHorizontalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginScrollView allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginScrollViewR Reflect(this GUILayoutBeginScrollView instance)
    {
        return new GUILayoutBeginScrollViewR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBeginVertical allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBeginVerticalR Reflect(this GUILayoutBeginVertical instance)
    {
        return new GUILayoutBeginVerticalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutBox allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutBoxR Reflect(this GUILayoutBox instance)
    {
        return new GUILayoutBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutButtonR Reflect(this GUILayoutButton instance)
    {
        return new GUILayoutButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutConfirmPasswordField
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutConfirmPasswordFieldR Reflect(this GUILayoutConfirmPasswordField instance)
    {
        return new GUILayoutConfirmPasswordFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEmailField allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEmailFieldR Reflect(this GUILayoutEmailField instance)
    {
        return new GUILayoutEmailFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndArea allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndAreaR Reflect(this GUILayoutEndArea instance)
    {
        return new GUILayoutEndAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndCentered allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndCenteredR Reflect(this GUILayoutEndCentered instance)
    {
        return new GUILayoutEndCenteredR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndHorizontal allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndHorizontalR Reflect(this GUILayoutEndHorizontal instance)
    {
        return new GUILayoutEndHorizontalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndScrollView allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndScrollViewR Reflect(this GUILayoutEndScrollView instance)
    {
        return new GUILayoutEndScrollViewR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutEndVertical allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutEndVerticalR Reflect(this GUILayoutEndVertical instance)
    {
        return new GUILayoutEndVerticalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutFlexibleSpace allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutFlexibleSpaceR Reflect(this GUILayoutFlexibleSpace instance)
    {
        return new GUILayoutFlexibleSpaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutFloatField allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutFloatFieldR Reflect(this GUILayoutFloatField instance)
    {
        return new GUILayoutFloatFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutFloatLabel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutFloatLabelR Reflect(this GUILayoutFloatLabel instance)
    {
        return new GUILayoutFloatLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutHorizontalSlider allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutHorizontalSliderR Reflect(this GUILayoutHorizontalSlider instance)
    {
        return new GUILayoutHorizontalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutIntField allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutIntFieldR Reflect(this GUILayoutIntField instance)
    {
        return new GUILayoutIntFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutIntLabel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutIntLabelR Reflect(this GUILayoutIntLabel instance)
    {
        return new GUILayoutIntLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutLabel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutLabelR Reflect(this GUILayoutLabel instance)
    {
        return new GUILayoutLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutPasswordField allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutPasswordFieldR Reflect(this GUILayoutPasswordField instance)
    {
        return new GUILayoutPasswordFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutRepeatButton allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutRepeatButtonR Reflect(this GUILayoutRepeatButton instance)
    {
        return new GUILayoutRepeatButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutSpace allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutSpaceR Reflect(this GUILayoutSpace instance)
    {
        return new GUILayoutSpaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutTextField allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutTextFieldR Reflect(this GUILayoutTextField instance)
    {
        return new GUILayoutTextFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutTextLabel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutTextLabelR Reflect(this GUILayoutTextLabel instance)
    {
        return new GUILayoutTextLabelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutToggle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutToggleR Reflect(this GUILayoutToggle instance)
    {
        return new GUILayoutToggleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutToolbar allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutToolbarR Reflect(this GUILayoutToolbar instance)
    {
        return new GUILayoutToolbarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUILayoutVerticalSlider allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUILayoutVerticalSliderR Reflect(this GUILayoutVerticalSlider instance)
    {
        return new GUILayoutVerticalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GuitarHeroControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GuitarHeroControllerMacNativeProfileR Reflect(this GuitarHeroControllerMacNativeProfile instance)
    {
        return new GuitarHeroControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUITooltip allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUITooltipR Reflect(this GUITooltip instance)
    {
        return new GUITooltipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of GUIVerticalSlider allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static GUIVerticalSliderR Reflect(this GUIVerticalSlider instance)
    {
        return new GUIVerticalSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HamaBlackForceWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HamaBlackForceWindowsUnityProfileR Reflect(this HamaBlackForceWindowsUnityProfile instance)
    {
        return new HamaBlackForceWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HardLandEffect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HardLandEffectR Reflect(this HardLandEffect instance)
    {
        return new HardLandEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HarmonixDrumKitMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HarmonixDrumKitMacNativeProfileR Reflect(this HarmonixDrumKitMacNativeProfile instance)
    {
        return new HarmonixDrumKitMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HarmonixGuitarMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HarmonixGuitarMacNativeProfileR Reflect(this HarmonixGuitarMacNativeProfile instance)
    {
        return new HarmonixGuitarMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HarmonixKeyboardMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HarmonixKeyboardMacNativeProfileR Reflect(this HarmonixKeyboardMacNativeProfile instance)
    {
        return new HarmonixKeyboardMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HasComponent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HasComponentR Reflect(this HasComponent instance)
    {
        return new HasComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableAdd allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableAddR Reflect(this HashTableAdd instance)
    {
        return new HashTableAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableAddMany allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableAddManyR Reflect(this HashTableAddMany instance)
    {
        return new HashTableAddManyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableClear allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableClearR Reflect(this HashTableClear instance)
    {
        return new HashTableClearR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableConcat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableConcatR Reflect(this HashTableConcat instance)
    {
        return new HashTableConcatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableContains allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableContainsR Reflect(this HashTableContains instance)
    {
        return new HashTableContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableContainsKey allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableContainsKeyR Reflect(this HashTableContainsKey instance)
    {
        return new HashTableContainsKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableContainsValue allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableContainsValueR Reflect(this HashTableContainsValue instance)
    {
        return new HashTableContainsValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableCount allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableCountR Reflect(this HashTableCount instance)
    {
        return new HashTableCountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableCreate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableCreateR Reflect(this HashTableCreate instance)
    {
        return new HashTableCreateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableEditKey allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableEditKeyR Reflect(this HashTableEditKey instance)
    {
        return new HashTableEditKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableExists allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableExistsR Reflect(this HashTableExists instance)
    {
        return new HashTableExistsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetR Reflect(this HashTableGet instance)
    {
        return new HashTableGetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGetKeyFromValue allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetKeyFromValueR Reflect(this HashTableGetKeyFromValue instance)
    {
        return new HashTableGetKeyFromValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGetMany allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetManyR Reflect(this HashTableGetMany instance)
    {
        return new HashTableGetManyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableGetNext allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableGetNextR Reflect(this HashTableGetNext instance)
    {
        return new HashTableGetNextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableIsEmpty allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableIsEmptyR Reflect(this HashTableIsEmpty instance)
    {
        return new HashTableIsEmptyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableKeys allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableKeysR Reflect(this HashTableKeys instance)
    {
        return new HashTableKeysR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableRemove allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableRemoveR Reflect(this HashTableRemove instance)
    {
        return new HashTableRemoveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableRevertSnapShot allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableRevertSnapShotR Reflect(this HashTableRevertSnapShot instance)
    {
        return new HashTableRevertSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableSet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableSetR Reflect(this HashTableSet instance)
    {
        return new HashTableSetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableSetMany allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableSetManyR Reflect(this HashTableSetMany instance)
    {
        return new HashTableSetManyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableSortKeysfromValues allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableSortKeysfromValuesR Reflect(this HashTableSortKeysfromValues instance)
    {
        return new HashTableSortKeysfromValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableTakeSnapShot allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableTakeSnapShotR Reflect(this HashTableTakeSnapShot instance)
    {
        return new HashTableTakeSnapShotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HashTableValues allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HashTableValuesR Reflect(this HashTableValues instance)
    {
        return new HashTableValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HavitHVG95WLinuxProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HavitHVG95WLinuxProfileR Reflect(this HavitHVG95WLinuxProfile instance)
    {
        return new HavitHVG95WLinuxProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HazardRespawnMarker allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HazardRespawnMarkerR Reflect(this HazardRespawnMarker instance)
    {
        return new HazardRespawnMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HazardRespawnTrigger allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HazardRespawnTriggerR Reflect(this HazardRespawnTrigger instance)
    {
        return new HazardRespawnTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HealthCocoon allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HealthCocoonR Reflect(this HealthCocoon instance)
    {
        return new HealthCocoonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HealthManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HealthManagerR Reflect(this HealthManager instance)
    {
        return new HealthManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroActions allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroActionsR Reflect(this HeroActions instance)
    {
        return new HeroActionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroAnimationController allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroAnimationControllerR Reflect(this HeroAnimationController instance)
    {
        return new HeroAnimationControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroAudioController allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroAudioControllerR Reflect(this HeroAudioController instance)
    {
        return new HeroAudioControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroBox allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroBoxR Reflect(this HeroBox instance)
    {
        return new HeroBoxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroControllerStates allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroControllerStatesR Reflect(this HeroControllerStates instance)
    {
        return new HeroControllerStatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroDetect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroDetectR Reflect(this HeroDetect instance)
    {
        return new HeroDetectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HeroPlatformStick allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HeroPlatformStickR Reflect(this HeroPlatformStick instance)
    {
        return new HeroPlatformStickR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HexadecimalAttribute allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HexadecimalAttributeR Reflect(this HexadecimalAttribute instance)
    {
        return new HexadecimalAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HidePromptMarker allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HidePromptMarkerR Reflect(this HidePromptMarker instance)
    {
        return new HidePromptMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HitInstanceHandler allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HitInstanceHandlerR Reflect(this HitInstanceHandler instance)
    {
        return new HitInstanceHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HiveKnightStinger allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HiveKnightStingerR Reflect(this HiveKnightStinger instance)
    {
        return new HiveKnightStingerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HollowKnightInputModule allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HollowKnightInputModuleR Reflect(this HollowKnightInputModule instance)
    {
        return new HollowKnightInputModuleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoneyBeeControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoneyBeeControllerMacNativeProfileR Reflect(this HoneyBeeControllerMacNativeProfile instance)
    {
        return new HoneyBeeControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriBlueSoloControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static HoriBlueSoloControllerMacNativeProfileR Reflect(this HoriBlueSoloControllerMacNativeProfile instance)
    {
        return new HoriBlueSoloControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriControllerMacNativeProfileR Reflect(this HoriControllerMacNativeProfile instance)
    {
        return new HoriControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriDOA4ArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriDOA4ArcadeStickMacNativeProfileR Reflect(this HoriDOA4ArcadeStickMacNativeProfile instance)
    {
        return new HoriDOA4ArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriEdgeFightingStickMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static HoriEdgeFightingStickMacNativeProfileR Reflect(this HoriEdgeFightingStickMacNativeProfile instance)
    {
        return new HoriEdgeFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriEX2ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriEX2ControllerMacNativeProfileR Reflect(this HoriEX2ControllerMacNativeProfile instance)
    {
        return new HoriEX2ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HORIFightingCommanderControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static HORIFightingCommanderControllerMacNativeProfileR Reflect(this
        HORIFightingCommanderControllerMacNativeProfile instance)
    {
        return new HORIFightingCommanderControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriFightingCommanderMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static HoriFightingCommanderMacNativeProfileR Reflect(this HoriFightingCommanderMacNativeProfile instance)
    {
        return new HoriFightingCommanderMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriFightingEdgeArcadeStickMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static HoriFightingEdgeArcadeStickMacNativeProfileR Reflect(this
        HoriFightingEdgeArcadeStickMacNativeProfile instance)
    {
        return new HoriFightingEdgeArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriFightingStickEX2MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightingStickEX2MacNativeProfileR Reflect(this HoriFightingStickEX2MacNativeProfile instance)
    {
        return new HoriFightingStickEX2MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriFightingStickMiniMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static HoriFightingStickMiniMacNativeProfileR Reflect(this HoriFightingStickMiniMacNativeProfile instance)
    {
        return new HoriFightingStickMiniMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriFightingStickVXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightingStickVXMacNativeProfileR Reflect(this HoriFightingStickVXMacNativeProfile instance)
    {
        return new HoriFightingStickVXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriFightStickMacNativeProfileR Reflect(this HoriFightStickMacNativeProfile instance)
    {
        return new HoriFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriPadEXTurboControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static HoriPadEXTurboControllerMacNativeProfileR
        Reflect(this HoriPadEXTurboControllerMacNativeProfile instance)
    {
        return new HoriPadEXTurboControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriPadUltimateMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriPadUltimateMacNativeProfileR Reflect(this HoriPadUltimateMacNativeProfile instance)
    {
        return new HoriPadUltimateMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRAPNFightingStickMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static HoriRAPNFightingStickMacNativeProfileR Reflect(this HoriRAPNFightingStickMacNativeProfile instance)
    {
        return new HoriRAPNFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriRealArcadeProEXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProEXMacNativeProfileR Reflect(this HoriRealArcadeProEXMacNativeProfile instance)
    {
        return new HoriRealArcadeProEXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProEXPremiumVLXMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProEXPremiumVLXMacNativeProfileR Reflect(this
        HoriRealArcadeProEXPremiumVLXMacNativeProfile instance)
    {
        return new HoriRealArcadeProEXPremiumVLXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProEXSEMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static HoriRealArcadeProEXSEMacNativeProfileR Reflect(this HoriRealArcadeProEXSEMacNativeProfile instance)
    {
        return new HoriRealArcadeProEXSEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProHayabusaMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static HoriRealArcadeProHayabusaMacNativeProfileR
        Reflect(this HoriRealArcadeProHayabusaMacNativeProfile instance)
    {
        return new HoriRealArcadeProHayabusaMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriRealArcadeProIVMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProIVMacNativeProfileR Reflect(this HoriRealArcadeProIVMacNativeProfile instance)
    {
        return new HoriRealArcadeProIVMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProVHayabusaMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static HoriRealArcadeProVHayabusaMacNativeProfileR Reflect(this
        HoriRealArcadeProVHayabusaMacNativeProfile instance)
    {
        return new HoriRealArcadeProVHayabusaMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProVKaiFightingStickMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProVKaiFightingStickMacNativeProfileR Reflect(this
        HoriRealArcadeProVKaiFightingStickMacNativeProfile instance)
    {
        return new HoriRealArcadeProVKaiFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriRealArcadeProVXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriRealArcadeProVXMacNativeProfileR Reflect(this HoriRealArcadeProVXMacNativeProfile instance)
    {
        return new HoriRealArcadeProVXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     HoriRealArcadeProVXSAMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static HoriRealArcadeProVXSAMacNativeProfileR Reflect(this HoriRealArcadeProVXSAMacNativeProfile instance)
    {
        return new HoriRealArcadeProVXSAMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HoriXbox360GemPadExMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HoriXbox360GemPadExMacNativeProfileR Reflect(this HoriXbox360GemPadExMacNativeProfile instance)
    {
        return new HoriXbox360GemPadExMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HUDCamera allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HUDCameraR Reflect(this HUDCamera instance)
    {
        return new HUDCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of HyperkinX91MacNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static HyperkinX91MacNativeProfileR Reflect(this HyperkinX91MacNativeProfile instance)
    {
        return new HyperkinX91MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzz allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzR Reflect(this IdleBuzz instance)
    {
        return new IdleBuzzR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzzing allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzingR Reflect(this IdleBuzzing instance)
    {
        return new IdleBuzzingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzzV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzV2R Reflect(this IdleBuzzV2 instance)
    {
        return new IdleBuzzV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IdleBuzzV3 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IdleBuzzV3R Reflect(this IdleBuzzV3 instance)
    {
        return new IdleBuzzV3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IgnoreHeroCollision allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IgnoreHeroCollisionR Reflect(this IgnoreHeroCollision instance)
    {
        return new IgnoreHeroCollisionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InControlException allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InControlExceptionR Reflect(this InControlException instance)
    {
        return new InControlExceptionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InControlInputModule allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InControlInputModuleR Reflect(this InControlInputModule instance)
    {
        return new InControlInputModuleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InControlManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InControlManagerR Reflect(this InControlManager instance)
    {
        return new InControlManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IncrementPlayerDataInt allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IncrementPlayerDataIntR Reflect(this IncrementPlayerDataInt instance)
    {
        return new IncrementPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IncrementRenderQueue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IncrementRenderQueueR Reflect(this IncrementRenderQueue instance)
    {
        return new IncrementRenderQueueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InfectedBurstLarge allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InfectedBurstLargeR Reflect(this InfectedBurstLarge instance)
    {
        return new InfectedBurstLargeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InfectedBurstSmall allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InfectedBurstSmallR Reflect(this InfectedBurstSmall instance)
    {
        return new InfectedBurstSmallR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InfectedEnemyEffects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InfectedEnemyEffectsR Reflect(this InfectedEnemyEffects instance)
    {
        return new InfectedEnemyEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InGameConsoleSettings allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InGameConsoleSettingsR Reflect(this InGameConsoleSettings instance)
    {
        return new InGameConsoleSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InGameCutsceneInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InGameCutsceneInfoR Reflect(this InGameCutsceneInfo instance)
    {
        return new InGameCutsceneInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of INIParser allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static INIParserR Reflect(this INIParser instance)
    {
        return new INIParserR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InjusticeFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InjusticeFightStickMacNativeProfileR Reflect(this InjusticeFightStickMacNativeProfile instance)
    {
        return new InjusticeFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InlineGraphic allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InlineGraphicR Reflect(this InlineGraphic instance)
    {
        return new InlineGraphicR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InlineGraphicManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InlineGraphicManagerR Reflect(this InlineGraphicManager instance)
    {
        return new InlineGraphicManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputControl allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputControlR Reflect(this InputControl instance)
    {
        return new InputControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputControlMapping allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputControlMappingR Reflect(this InputControlMapping instance)
    {
        return new InputControlMappingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputDevice allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputDeviceR Reflect(this InputDevice instance)
    {
        return new InputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputDeviceProfile allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputDeviceProfileR Reflect(this InputDeviceProfile instance)
    {
        return new InputDeviceProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputHandler allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputHandlerRR Reflect(this InputHandler instance)
    {
        return new InputHandlerRR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputModuleActionAdaptor allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputModuleActionAdaptorR Reflect(this InputModuleActionAdaptor instance)
    {
        return new InputModuleActionAdaptorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InputModuleBinder allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InputModuleBinderR Reflect(this InputModuleBinder instance)
    {
        return new InputModuleBinderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InstaDeath allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InstaDeathR Reflect(this InstaDeath instance)
    {
        return new InstaDeathR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntAdd allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntAddR Reflect(this IntAdd instance)
    {
        return new IntAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntAddV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntAddV2R Reflect(this IntAddV2 instance)
    {
        return new IntAddV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntChanged allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntChangedR Reflect(this IntChanged instance)
    {
        return new IntChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntClamp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntClampR Reflect(this IntClamp instance)
    {
        return new IntClampR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntCompare allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntCompareR Reflect(this IntCompare instance)
    {
        return new IntCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntCompareToBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntCompareToBoolR Reflect(this IntCompareToBool instance)
    {
        return new IntCompareToBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntOperator allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntOperatorR Reflect(this IntOperator instance)
    {
        return new IntOperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntSwitch allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntSwitchR Reflect(this IntSwitch instance)
    {
        return new IntSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IntTestToBool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IntTestToBoolR Reflect(this IntTestToBool instance)
    {
        return new IntTestToBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvAnimateUpAndDown allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvAnimateUpAndDownR Reflect(this InvAnimateUpAndDown instance)
    {
        return new InvAnimateUpAndDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvCharmBackboard allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvCharmBackboardR Reflect(this InvCharmBackboard instance)
    {
        return new InvCharmBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InventoryArrowContainer allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InventoryArrowContainerR Reflect(this InventoryArrowContainer instance)
    {
        return new InventoryArrowContainerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InverseTransformDirection allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InverseTransformDirectionR Reflect(this InverseTransformDirection instance)
    {
        return new InverseTransformDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InverseTransformPoint allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InverseTransformPointR Reflect(this InverseTransformPoint instance)
    {
        return new InverseTransformPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvItemDisplay allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvItemDisplayR Reflect(this InvItemDisplay instance)
    {
        return new InvItemDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvMarker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvMarkerR Reflect(this InvMarker instance)
    {
        return new InvMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvMarkerCollide allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvMarkerCollideR Reflect(this InvMarkerCollide instance)
    {
        return new InvMarkerCollideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvNailArtBackboard allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvNailArtBackboardR Reflect(this InvNailArtBackboard instance)
    {
        return new InvNailArtBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvNailSprite allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvNailSpriteR Reflect(this InvNailSprite instance)
    {
        return new InvNailSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvokeMethod allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvokeMethodR Reflect(this InvokeMethod instance)
    {
        return new InvokeMethodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvRelicBackboard allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvRelicBackboardR Reflect(this InvRelicBackboard instance)
    {
        return new InvRelicBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvulnerablePulse allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvulnerablePulseR Reflect(this InvulnerablePulse instance)
    {
        return new InvulnerablePulseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of InvVesselFragments allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static InvVesselFragmentsR Reflect(this InvVesselFragments instance)
    {
        return new InvVesselFragmentsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IonDrumRockerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IonDrumRockerMacNativeProfileR Reflect(this IonDrumRockerMacNativeProfile instance)
    {
        return new IonDrumRockerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9021AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9021AndroidUnityProfileR Reflect(this IpegaPG9021AndroidUnityProfile instance)
    {
        return new IpegaPG9021AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9023AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9023AndroidUnityProfileR Reflect(this IpegaPG9023AndroidUnityProfile instance)
    {
        return new IpegaPG9023AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9025AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9025AndroidUnityProfileR Reflect(this IpegaPG9025AndroidUnityProfile instance)
    {
        return new IpegaPG9025AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9037AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9037AndroidUnityProfileR Reflect(this IpegaPG9037AndroidUnityProfile instance)
    {
        return new IpegaPG9037AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9055AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9055AndroidUnityProfileR Reflect(this IpegaPG9055AndroidUnityProfile instance)
    {
        return new IpegaPG9055AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IpegaPG9068AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IpegaPG9068AndroidUnityProfileR Reflect(this IpegaPG9068AndroidUnityProfile instance)
    {
        return new IpegaPG9068AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsFixedAngle2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsFixedAngle2dR Reflect(this IsFixedAngle2d instance)
    {
        return new IsFixedAngle2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsKinematic allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsKinematicR Reflect(this IsKinematic instance)
    {
        return new IsKinematicR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsKinematic2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsKinematic2dR Reflect(this IsKinematic2d instance)
    {
        return new IsKinematic2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsPointerOverUiObject allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsPointerOverUiObjectR Reflect(this IsPointerOverUiObject instance)
    {
        return new IsPointerOverUiObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsSleeping allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsSleepingR Reflect(this IsSleeping instance)
    {
        return new IsSleepingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of IsSleeping2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static IsSleeping2dR Reflect(this IsSleeping2d instance)
    {
        return new IsSleeping2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTween allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenR Reflect(this iTween instance)
    {
        return new iTweenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenFadeTo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenFadeToR Reflect(this iTweenFadeTo instance)
    {
        return new iTweenFadeToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenFSMEvents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenFSMEventsR Reflect(this iTweenFSMEvents instance)
    {
        return new iTweenFSMEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenLookFrom allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenLookFromR Reflect(this iTweenLookFrom instance)
    {
        return new iTweenLookFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenLookTo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenLookToR Reflect(this iTweenLookTo instance)
    {
        return new iTweenLookToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenLookUpdate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenLookUpdateR Reflect(this iTweenLookUpdate instance)
    {
        return new iTweenLookUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveAdd allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveAddR Reflect(this iTweenMoveAdd instance)
    {
        return new iTweenMoveAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveBy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveByR Reflect(this iTweenMoveBy instance)
    {
        return new iTweenMoveByR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveFrom allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveFromR Reflect(this iTweenMoveFrom instance)
    {
        return new iTweenMoveFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveTo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveToR Reflect(this iTweenMoveTo instance)
    {
        return new iTweenMoveToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenMoveUpdate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenMoveUpdateR Reflect(this iTweenMoveUpdate instance)
    {
        return new iTweenMoveUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPause allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPauseR Reflect(this iTweenPause instance)
    {
        return new iTweenPauseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPunchPosition allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPunchPositionR Reflect(this iTweenPunchPosition instance)
    {
        return new iTweenPunchPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPunchRotation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPunchRotationR Reflect(this iTweenPunchRotation instance)
    {
        return new iTweenPunchRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenPunchScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenPunchScaleR Reflect(this iTweenPunchScale instance)
    {
        return new iTweenPunchScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenResume allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenResumeR Reflect(this iTweenResume instance)
    {
        return new iTweenResumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateAdd allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateAddR Reflect(this iTweenRotateAdd instance)
    {
        return new iTweenRotateAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateBy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateByR Reflect(this iTweenRotateBy instance)
    {
        return new iTweenRotateByR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateFrom allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateFromR Reflect(this iTweenRotateFrom instance)
    {
        return new iTweenRotateFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateTo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateToR Reflect(this iTweenRotateTo instance)
    {
        return new iTweenRotateToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenRotateUpdate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenRotateUpdateR Reflect(this iTweenRotateUpdate instance)
    {
        return new iTweenRotateUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleAdd allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleAddR Reflect(this iTweenScaleAdd instance)
    {
        return new iTweenScaleAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleBy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleByR Reflect(this iTweenScaleBy instance)
    {
        return new iTweenScaleByR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleFrom allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleFromR Reflect(this iTweenScaleFrom instance)
    {
        return new iTweenScaleFromR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleTo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleToR Reflect(this iTweenScaleTo instance)
    {
        return new iTweenScaleToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenScaleUpdate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenScaleUpdateR Reflect(this iTweenScaleUpdate instance)
    {
        return new iTweenScaleUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenShakePosition allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenShakePositionR Reflect(this iTweenShakePosition instance)
    {
        return new iTweenShakePositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenShakeRotation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenShakeRotationR Reflect(this iTweenShakeRotation instance)
    {
        return new iTweenShakeRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenShakeScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenShakeScaleR Reflect(this iTweenShakeScale instance)
    {
        return new iTweenShakeScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of iTweenStop allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static iTweenStopR Reflect(this iTweenStop instance)
    {
        return new iTweenStopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JellyEgg allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JellyEggR Reflect(this JellyEgg instance)
    {
        return new JellyEggR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JournalEntryStats allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JournalEntryStatsR Reflect(this JournalEntryStats instance)
    {
        return new JournalEntryStatsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JournalList allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JournalListR Reflect(this JournalList instance)
    {
        return new JournalListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JournalListOld allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JournalListOldR Reflect(this JournalListOld instance)
    {
        return new JournalListOldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     JoytekXbox360ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static JoytekXbox360ControllerMacNativeProfileR Reflect(
        this JoytekXbox360ControllerMacNativeProfile instance)
    {
        return new JoytekXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of JumpEffects allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static JumpEffectsR Reflect(this JumpEffects instance)
    {
        return new JumpEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepFloatPositive allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepFloatPositiveR Reflect(this KeepFloatPositive instance)
    {
        return new KeepFloatPositiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepInScene allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepInSceneR Reflect(this KeepInScene instance)
    {
        return new KeepInSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepRotation allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepRotationR Reflect(this KeepRotation instance)
    {
        return new KeepRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepWorldPosition allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepWorldPositionR Reflect(this KeepWorldPosition instance)
    {
        return new KeepWorldPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepWorldScalePositive allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepWorldScalePositiveR Reflect(this KeepWorldScalePositive instance)
    {
        return new KeepWorldScalePositiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeepWorldScalePositiveLate allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeepWorldScalePositiveLateR Reflect(this KeepWorldScalePositiveLate instance)
    {
        return new KeepWorldScalePositiveLateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KerningPair allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KerningPairR Reflect(this KerningPair instance)
    {
        return new KerningPairR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KerningTable allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KerningTableR Reflect(this KerningTable instance)
    {
        return new KerningTableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeyBindingSource allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeyBindingSourceR Reflect(this KeyBindingSource instance)
    {
        return new KeyBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeyBindingSourceListener allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeyBindingSourceListenerR Reflect(this KeyBindingSourceListener instance)
    {
        return new KeyBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KeyboardButtonSkins allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KeyboardButtonSkinsR Reflect(this KeyboardButtonSkins instance)
    {
        return new KeyboardButtonSkinsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KillDelayedEvents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KillDelayedEventsR Reflect(this KillDelayedEvents instance)
    {
        return new KillDelayedEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KillOnContact allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KillOnContactR Reflect(this KillOnContact instance)
    {
        return new KillOnContactR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KiwitataNESWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KiwitataNESWindowsNativeProfileR Reflect(this KiwitataNESWindowsNativeProfile instance)
    {
        return new KiwitataNESWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KnightHatchling allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KnightHatchlingR Reflect(this KnightHatchling instance)
    {
        return new KnightHatchlingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of KonamiDancePadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static KonamiDancePadMacNativeProfileR Reflect(this KonamiDancePadMacNativeProfile instance)
    {
        return new KonamiDancePadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LanguageGetProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LanguageGetProxyR Reflect(this LanguageGetProxy instance)
    {
        return new LanguageGetProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Layer allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static LayerR Reflect(this Layer instance)
    {
        return new LayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LayerInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LayerInfoR Reflect(this LayerInfo instance)
    {
        return new LayerInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LayerSprites allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LayerSpritesR Reflect(this LayerSprites instance)
    {
        return new LayerSpritesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LensCAAndDistortion allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LensCAAndDistortionR Reflect(this LensCAAndDistortion instance)
    {
        return new LensCAAndDistortionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LerpTk2dSpriteColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LerpTk2dSpriteColorR Reflect(this LerpTk2dSpriteColor instance)
    {
        return new LerpTk2dSpriteColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LevelUpBlackHawkWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LevelUpBlackHawkWindowsUnityProfileR Reflect(this LevelUpBlackHawkWindowsUnityProfile instance)
    {
        return new LevelUpBlackHawkWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LiftChain allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LiftChainR Reflect(this LiftChain instance)
    {
        return new LiftChainR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LiftPlatform allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LiftPlatformR Reflect(this LiftPlatform instance)
    {
        return new LiftPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LightBlur allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LightBlurR Reflect(this LightBlur instance)
    {
        return new LightBlurR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LightBlurredBackground allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LightBlurredBackgroundR Reflect(this LightBlurredBackground instance)
    {
        return new LightBlurredBackgroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LimitBehaviour allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LimitBehaviourR Reflect(this LimitBehaviour instance)
    {
        return new LimitBehaviourR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LimitSendEvents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LimitSendEventsR Reflect(this LimitSendEvents instance)
    {
        return new LimitSendEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LineCast2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LineCast2dR Reflect(this LineCast2d instance)
    {
        return new LineCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LineOfSightDetector allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LineOfSightDetectorR Reflect(this LineOfSightDetector instance)
    {
        return new LineOfSightDetectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LinkRendererState allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LinkRendererStateR Reflect(this LinkRendererState instance)
    {
        return new LinkRendererStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForAttack allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForAttackR Reflect(this ListenForAttack instance)
    {
        return new ListenForAttackR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForBackdash allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForBackdashR Reflect(this ListenForBackdash instance)
    {
        return new ListenForBackdashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForCast allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForCastR Reflect(this ListenForCast instance)
    {
        return new ListenForCastR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForDash allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForDashR Reflect(this ListenForDash instance)
    {
        return new ListenForDashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForDown allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForDownR Reflect(this ListenForDown instance)
    {
        return new ListenForDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForDreamNail allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForDreamNailR Reflect(this ListenForDreamNail instance)
    {
        return new ListenForDreamNailR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForInventory allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForInventoryR Reflect(this ListenForInventory instance)
    {
        return new ListenForInventoryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForJump allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForJumpR Reflect(this ListenForJump instance)
    {
        return new ListenForJumpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForLeft allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForLeftR Reflect(this ListenForLeft instance)
    {
        return new ListenForLeftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForMenuActions allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForMenuActionsR Reflect(this ListenForMenuActions instance)
    {
        return new ListenForMenuActionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForMenuCancel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForMenuCancelR Reflect(this ListenForMenuCancel instance)
    {
        return new ListenForMenuCancelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForMenuSubmit allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForMenuSubmitR Reflect(this ListenForMenuSubmit instance)
    {
        return new ListenForMenuSubmitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForPaneLeft allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForPaneLeftR Reflect(this ListenForPaneLeft instance)
    {
        return new ListenForPaneLeftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForPaneRight allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForPaneRightR Reflect(this ListenForPaneRight instance)
    {
        return new ListenForPaneRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForQuickCast allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForQuickCastR Reflect(this ListenForQuickCast instance)
    {
        return new ListenForQuickCastR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForQuickMap allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForQuickMapR Reflect(this ListenForQuickMap instance)
    {
        return new ListenForQuickMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForRight allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForRightR Reflect(this ListenForRight instance)
    {
        return new ListenForRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForRsDown allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForRsDownR Reflect(this ListenForRsDown instance)
    {
        return new ListenForRsDownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForRsUp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForRsUpR Reflect(this ListenForRsUp instance)
    {
        return new ListenForRsUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForSuperdash allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForSuperdashR Reflect(this ListenForSuperdash instance)
    {
        return new ListenForSuperdashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ListenForUp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ListenForUpR Reflect(this ListenForUp instance)
    {
        return new ListenForUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadingCanvas allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadingCanvasR Reflect(this LoadingCanvas instance)
    {
        return new LoadingCanvasR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadingPulse allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadingPulseR Reflect(this LoadingPulse instance)
    {
        return new LoadingPulseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadingSpinner allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadingSpinnerR Reflect(this LoadingSpinner instance)
    {
        return new LoadingSpinnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadLevel allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadLevelR Reflect(this LoadLevel instance)
    {
        return new LoadLevelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LoadLevelNum allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoadLevelNumR Reflect(this LoadLevelNum instance)
    {
        return new LoadLevelNumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocaliseSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocaliseSpriteR Reflect(this LocaliseSprite instance)
    {
        return new LocaliseSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocalizationSettings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocalizationSettingsR Reflect(this LocalizationSettings instance)
    {
        return new LocalizationSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocalizedAsset allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocalizedAssetR Reflect(this LocalizedAsset instance)
    {
        return new LocalizedAssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LocalizedTextMesh allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LocalizedTextMeshR Reflect(this LocalizedTextMesh instance)
    {
        return new LocalizedTextMeshR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Logger allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LoggerR Reflect(this Logger instance)
    {
        return new LoggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechChillStreamControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static LogitechChillStreamControllerMacNativeProfileR Reflect(this
        LogitechChillStreamControllerMacNativeProfile instance)
    {
        return new LogitechChillStreamControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechControllerMacNativeProfileR Reflect(this LogitechControllerMacNativeProfile instance)
    {
        return new LogitechControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechDriveFXRacingWheelMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static LogitechDriveFXRacingWheelMacNativeProfileR Reflect(this
        LogitechDriveFXRacingWheelMacNativeProfile instance)
    {
        return new LogitechDriveFXRacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF310ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF310ControllerMacNativeProfileR Reflect(this LogitechF310ControllerMacNativeProfile instance)
    {
        return new LogitechF310ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310LinuxUnityProfileR Reflect(this LogitechF310LinuxUnityProfile instance)
    {
        return new LogitechF310LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeDMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeDMacNativeProfileR Reflect(this LogitechF310ModeDMacNativeProfile instance)
    {
        return new LogitechF310ModeDMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeDMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeDMacUnityProfileR Reflect(this LogitechF310ModeDMacUnityProfile instance)
    {
        return new LogitechF310ModeDMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF310ModeDWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF310ModeDWindowsNativeProfileR Reflect(this LogitechF310ModeDWindowsNativeProfile instance)
    {
        return new LogitechF310ModeDWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeDWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeDWindowsUnityProfileR Reflect(this LogitechF310ModeDWindowsUnityProfile instance)
    {
        return new LogitechF310ModeDWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeXMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeXMacUnityProfileR Reflect(this LogitechF310ModeXMacUnityProfile instance)
    {
        return new LogitechF310ModeXMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF310ModeXWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF310ModeXWindowsNativeProfileR Reflect(this LogitechF310ModeXWindowsNativeProfile instance)
    {
        return new LogitechF310ModeXWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF310ModeXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF310ModeXWindowsUnityProfileR Reflect(this LogitechF310ModeXWindowsUnityProfile instance)
    {
        return new LogitechF310ModeXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF510ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF510ControllerMacNativeProfileR Reflect(this LogitechF510ControllerMacNativeProfile instance)
    {
        return new LogitechF510ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510LinuxUnityProfileR Reflect(this LogitechF510LinuxUnityProfile instance)
    {
        return new LogitechF510LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeDMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeDMacNativeProfileR Reflect(this LogitechF510ModeDMacNativeProfile instance)
    {
        return new LogitechF510ModeDMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeDMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeDMacUnityProfileR Reflect(this LogitechF510ModeDMacUnityProfile instance)
    {
        return new LogitechF510ModeDMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF510ModeDWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF510ModeDWindowsNativeProfileR Reflect(this LogitechF510ModeDWindowsNativeProfile instance)
    {
        return new LogitechF510ModeDWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeDWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeDWindowsUnityProfileR Reflect(this LogitechF510ModeDWindowsUnityProfile instance)
    {
        return new LogitechF510ModeDWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeXMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeXMacUnityProfileR Reflect(this LogitechF510ModeXMacUnityProfile instance)
    {
        return new LogitechF510ModeXMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF510ModeXWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF510ModeXWindowsNativeProfileR Reflect(this LogitechF510ModeXWindowsNativeProfile instance)
    {
        return new LogitechF510ModeXWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF510ModeXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF510ModeXWindowsUnityProfileR Reflect(this LogitechF510ModeXWindowsUnityProfile instance)
    {
        return new LogitechF510ModeXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF710ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF710ControllerMacNativeProfileR Reflect(this LogitechF710ControllerMacNativeProfile instance)
    {
        return new LogitechF710ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710LinuxUnityProfileR Reflect(this LogitechF710LinuxUnityProfile instance)
    {
        return new LogitechF710LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710MacUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710MacUnityProfileR Reflect(this LogitechF710MacUnityProfile instance)
    {
        return new LogitechF710MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710ModeDMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeDMacNativeProfileR Reflect(this LogitechF710ModeDMacNativeProfile instance)
    {
        return new LogitechF710ModeDMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF710ModeDWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF710ModeDWindowsNativeProfileR Reflect(this LogitechF710ModeDWindowsNativeProfile instance)
    {
        return new LogitechF710ModeDWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710ModeDWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeDWindowsUnityProfileR Reflect(this LogitechF710ModeDWindowsUnityProfile instance)
    {
        return new LogitechF710ModeDWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechF710ModeXWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechF710ModeXWindowsNativeProfileR Reflect(this LogitechF710ModeXWindowsNativeProfile instance)
    {
        return new LogitechF710ModeXWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechF710ModeXWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechF710ModeXWindowsUnityProfileR Reflect(this LogitechF710ModeXWindowsUnityProfile instance)
    {
        return new LogitechF710ModeXWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     LogitechG920RacingWheelMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static LogitechG920RacingWheelMacNativeProfileR Reflect(
        this LogitechG920RacingWheelMacNativeProfile instance)
    {
        return new LogitechG920RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechModeDAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechModeDAmazonUnityProfileR Reflect(this LogitechModeDAmazonUnityProfile instance)
    {
        return new LogitechModeDAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechModeXAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechModeXAmazonUnityProfileR Reflect(this LogitechModeXAmazonUnityProfile instance)
    {
        return new LogitechModeXAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechThunderpadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechThunderpadMacNativeProfileR Reflect(this LogitechThunderpadMacNativeProfile instance)
    {
        return new LogitechThunderpadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogitechWingManWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogitechWingManWindowsUnityProfileR Reflect(this LogitechWingManWindowsUnityProfile instance)
    {
        return new LogitechWingManWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LogoLanguage allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LogoLanguageR Reflect(this LogoLanguage instance)
    {
        return new LogoLanguageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAnimNPC allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAnimNPCR Reflect(this LookAnimNPC instance)
    {
        return new LookAnimNPCR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAtR Reflect(this LookAt instance)
    {
        return new LookAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAt2dR Reflect(this LookAt2d instance)
    {
        return new LookAt2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt2dGameObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAt2dGameObjectR Reflect(this LookAt2dGameObject instance)
    {
        return new LookAt2dGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of LookAt2dGameObjectSmooth allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static LookAt2dGameObjectSmoothR Reflect(this LookAt2dGameObjectSmooth instance)
    {
        return new LookAt2dGameObjectSmoothR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzArcadeStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzArcadeStickMacNativeProfileR Reflect(this MadCatzArcadeStickMacNativeProfile instance)
    {
        return new MadCatzArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzBeatPadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzBeatPadMacNativeProfileR Reflect(this MadCatzBeatPadMacNativeProfile instance)
    {
        return new MadCatzBeatPadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzBrawlStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzBrawlStickMacNativeProfileR Reflect(this MadCatzBrawlStickMacNativeProfile instance)
    {
        return new MadCatzBrawlStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzCODControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzCODControllerMacNativeProfileR Reflect(this MadCatzCODControllerMacNativeProfile instance)
    {
        return new MadCatzCODControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzControllerMacNativeProfileR Reflect(this MadCatzControllerMacNativeProfile instance)
    {
        return new MadCatzControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzCTRLRAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzCTRLRAmazonUnityProfileR Reflect(this MadCatzCTRLRAmazonUnityProfile instance)
    {
        return new MadCatzCTRLRAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzCTRLRAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzCTRLRAndroidUnityProfileR Reflect(this MadCatzCTRLRAndroidUnityProfile instance)
    {
        return new MadCatzCTRLRAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzFightPadControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MadCatzFightPadControllerMacNativeProfileR
        Reflect(this MadCatzFightPadControllerMacNativeProfile instance)
    {
        return new MadCatzFightPadControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzFightPadMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFightPadMacNativeProfileR Reflect(this MadCatzFightPadMacNativeProfile instance)
    {
        return new MadCatzFightPadMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzFightStickTE2MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFightStickTE2MacNativeProfileR Reflect(this MadCatzFightStickTE2MacNativeProfile instance)
    {
        return new MadCatzFightStickTE2MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzFightStickTESPlusMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MadCatzFightStickTESPlusMacNativeProfileR
        Reflect(this MadCatzFightStickTESPlusMacNativeProfile instance)
    {
        return new MadCatzFightStickTESPlusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzFPSProMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzFPSProMacNativeProfileR Reflect(this MadCatzFPSProMacNativeProfile instance)
    {
        return new MadCatzFPSProMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzGhostReconFightingStickMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static MadCatzGhostReconFightingStickMacNativeProfileR Reflect(this
        MadCatzGhostReconFightingStickMacNativeProfile instance)
    {
        return new MadCatzGhostReconFightingStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzInnoControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MadCatzInnoControllerMacNativeProfileR Reflect(this MadCatzInnoControllerMacNativeProfile instance)
    {
        return new MadCatzInnoControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzMC2ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMC2ControllerMacNativeProfileR Reflect(this MadCatzMC2ControllerMacNativeProfile instance)
    {
        return new MadCatzMC2ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMC2RacingWheelMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MadCatzMC2RacingWheelMacNativeProfileR Reflect(this MadCatzMC2RacingWheelMacNativeProfile instance)
    {
        return new MadCatzMC2RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMicroConControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MadCatzMicroConControllerMacNativeProfileR
        Reflect(this MadCatzMicroConControllerMacNativeProfile instance)
    {
        return new MadCatzMicroConControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMicroControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MadCatzMicroControllerMacNativeProfileR Reflect(this MadCatzMicroControllerMacNativeProfile instance)
    {
        return new MadCatzMicroControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzMicroCTRLRAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzMicroCTRLRAmazonUnityProfileR Reflect(this MadCatzMicroCTRLRAmazonUnityProfile instance)
    {
        return new MadCatzMicroCTRLRAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzMLGFightStickTEMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MadCatzMLGFightStickTEMacNativeProfileR Reflect(this MadCatzMLGFightStickTEMacNativeProfile instance)
    {
        return new MadCatzMLGFightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzNeoFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzNeoFightStickMacNativeProfileR Reflect(this MadCatzNeoFightStickMacNativeProfile instance)
    {
        return new MadCatzNeoFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzPortableDrumMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzPortableDrumMacNativeProfileR Reflect(this MadCatzPortableDrumMacNativeProfile instance)
    {
        return new MadCatzPortableDrumMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzProControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzProControllerMacNativeProfileR Reflect(this MadCatzProControllerMacNativeProfile instance)
    {
        return new MadCatzProControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MadCatzSaitekAV8R02MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MadCatzSaitekAV8R02MacNativeProfileR Reflect(this MadCatzSaitekAV8R02MacNativeProfile instance)
    {
        return new MadCatzSaitekAV8R02MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSF4FightStickRound2TEMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MadCatzSF4FightStickRound2TEMacNativeProfileR Reflect(this
        MadCatzSF4FightStickRound2TEMacNativeProfile instance)
    {
        return new MadCatzSF4FightStickRound2TEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSF4FightStickSEMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MadCatzSF4FightStickSEMacNativeProfileR Reflect(this MadCatzSF4FightStickSEMacNativeProfile instance)
    {
        return new MadCatzSF4FightStickSEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSF4FightStickTEMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MadCatzSF4FightStickTEMacNativeProfileR Reflect(this MadCatzSF4FightStickTEMacNativeProfile instance)
    {
        return new MadCatzSF4FightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSoulCaliberFightStickMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MadCatzSoulCaliberFightStickMacNativeProfileR Reflect(this
        MadCatzSoulCaliberFightStickMacNativeProfile instance)
    {
        return new MadCatzSoulCaliberFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSSF4ChunLiFightStickTEMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static MadCatzSSF4ChunLiFightStickTEMacNativeProfileR Reflect(this
        MadCatzSSF4ChunLiFightStickTEMacNativeProfile instance)
    {
        return new MadCatzSSF4ChunLiFightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MadCatzSSF4FightStickTEMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MadCatzSSF4FightStickTEMacNativeProfileR Reflect(
        this MadCatzSSF4FightStickTEMacNativeProfile instance)
    {
        return new MadCatzSSF4FightStickTEMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MainMenuOptions allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MainMenuOptionsR Reflect(this MainMenuOptions instance)
    {
        return new MainMenuOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MakeEnemyDreamnailReactionReady
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MakeEnemyDreamnailReactionReadyR Reflect(this MakeEnemyDreamnailReactionReady instance)
    {
        return new MakeEnemyDreamnailReactionReadyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MakeSkippable allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MakeSkippableR Reflect(this MakeSkippable instance)
    {
        return new MakeSkippableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapAreas allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapAreasR Reflect(this MapAreas instance)
    {
        return new MapAreasR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapMarkerButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapMarkerButtonR Reflect(this MapMarkerButton instance)
    {
        return new MapMarkerButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapMarkerMenu allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapMarkerMenuR Reflect(this MapMarkerMenu instance)
    {
        return new MapMarkerMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapNextAreaDisplay allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapNextAreaDisplayR Reflect(this MapNextAreaDisplay instance)
    {
        return new MapNextAreaDisplayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MappableControllerButton allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MappableControllerButtonR Reflect(this MappableControllerButton instance)
    {
        return new MappableControllerButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MappableKey allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MappableKeyR Reflect(this MappableKey instance)
    {
        return new MappableKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapStartPan allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapStartPanR Reflect(this MapStartPan instance)
    {
        return new MapStartPanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MapStopPan allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MapStopPanR Reflect(this MapStopPan instance)
    {
        return new MapStopPanR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Mask allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static MaskR Reflect(this Mask instance)
    {
        return new MaskR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MaskByYPos allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MaskByYPosR Reflect(this MaskByYPos instance)
    {
        return new MaskByYPosR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MatCatzControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MatCatzControllerMacNativeProfileR Reflect(this MatCatzControllerMacNativeProfile instance)
    {
        return new MatCatzControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MatchMasterTimeSample allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MatchMasterTimeSampleR Reflect(this MatchMasterTimeSample instance)
    {
        return new MatchMasterTimeSampleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MaterialReferenceManager allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MaterialReferenceManagerR Reflect(this MaterialReferenceManager instance)
    {
        return new MaterialReferenceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MaxFireBlaze5WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MaxFireBlaze5WindowsUnityProfileR Reflect(this MaxFireBlaze5WindowsUnityProfile instance)
    {
        return new MaxFireBlaze5WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MayflashMagicNSMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MayflashMagicNSMacNativeProfileR Reflect(this MayflashMagicNSMacNativeProfile instance)
    {
        return new MayflashMagicNSMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of McbazelAdapterMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static McbazelAdapterMacNativeProfileR Reflect(this McbazelAdapterMacNativeProfile instance)
    {
        return new McbazelAdapterMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MegaJellyZap allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MegaJellyZapR Reflect(this MegaJellyZap instance)
    {
        return new MegaJellyZapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAchievement allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAchievementR Reflect(this MenuAchievement instance)
    {
        return new MenuAchievementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAchievementsList allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAchievementsListR Reflect(this MenuAchievementsList instance)
    {
        return new MenuAchievementsListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAudioController allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAudioControllerR Reflect(this MenuAudioController instance)
    {
        return new MenuAudioControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuAudioSlider allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuAudioSliderR Reflect(this MenuAudioSlider instance)
    {
        return new MenuAudioSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuBuilder allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuBuilderR Reflect(this MenuBuilder instance)
    {
        return new MenuBuilderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButton allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonR Reflect(this MenuButton instance)
    {
        return new MenuButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonAchievementListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonAchievementListConditionR Reflect(this MenuButtonAchievementListCondition instance)
    {
        return new MenuButtonAchievementListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonChineseListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonChineseListConditionR Reflect(this MenuButtonChineseListCondition instance)
    {
        return new MenuButtonChineseListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonControllerListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonControllerListConditionR Reflect(this MenuButtonControllerListCondition instance)
    {
        return new MenuButtonControllerListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonGraphicsListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonGraphicsListConditionR Reflect(this MenuButtonGraphicsListCondition instance)
    {
        return new MenuButtonGraphicsListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonIcon allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonIconR Reflect(this MenuButtonIcon instance)
    {
        return new MenuButtonIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonKeyboardListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonKeyboardListConditionR Reflect(this MenuButtonKeyboardListCondition instance)
    {
        return new MenuButtonKeyboardListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonList allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonListR Reflect(this MenuButtonList instance)
    {
        return new MenuButtonListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonListPlatformCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonListPlatformConditionR Reflect(this MenuButtonListPlatformCondition instance)
    {
        return new MenuButtonListPlatformConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonNativeInputListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonNativeInputListConditionR Reflect(this MenuButtonNativeInputListCondition instance)
    {
        return new MenuButtonNativeInputListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonQuitListCondition allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonQuitListConditionR Reflect(this MenuButtonQuitListCondition instance)
    {
        return new MenuButtonQuitListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuButtonSwitchUserListCondition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuButtonSwitchUserListConditionR Reflect(this MenuButtonSwitchUserListCondition instance)
    {
        return new MenuButtonSwitchUserListConditionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuDisplaySetting allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuDisplaySettingR Reflect(this MenuDisplaySetting instance)
    {
        return new MenuDisplaySettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuFrameCapSetting allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuFrameCapSettingR Reflect(this MenuFrameCapSetting instance)
    {
        return new MenuFrameCapSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuLanguageSetting allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuLanguageSettingR Reflect(this MenuLanguageSetting instance)
    {
        return new MenuLanguageSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuOptionHorizontal allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuOptionHorizontalR Reflect(this MenuOptionHorizontal instance)
    {
        return new MenuOptionHorizontalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuPreventDeselect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuPreventDeselectR Reflect(this MenuPreventDeselect instance)
    {
        return new MenuPreventDeselectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuResolutionSetting allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuResolutionSettingR Reflect(this MenuResolutionSetting instance)
    {
        return new MenuResolutionSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuResources allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuResourcesR Reflect(this MenuResources instance)
    {
        return new MenuResourcesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuScreen allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuScreenR Reflect(this MenuScreen instance)
    {
        return new MenuScreenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuScroller allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuScrollerR Reflect(this MenuScroller instance)
    {
        return new MenuScrollerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuSelectable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuSelectableR Reflect(this MenuSelectable instance)
    {
        return new MenuSelectableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuSetting allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuSettingR Reflect(this MenuSetting instance)
    {
        return new MenuSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyles allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStylesR Reflect(this MenuStyles instance)
    {
        return new MenuStylesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleSetting allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleSettingR Reflect(this MenuStyleSetting instance)
    {
        return new MenuStyleSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleTitle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleTitleR Reflect(this MenuStyleTitle instance)
    {
        return new MenuStyleTitleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleUnlock allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleUnlockR Reflect(this MenuStyleUnlock instance)
    {
        return new MenuStyleUnlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MenuStyleUnlockAction allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MenuStyleUnlockActionR Reflect(this MenuStyleUnlockAction instance)
    {
        return new MenuStyleUnlockActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MeshSortingOrder allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MeshSortingOrderR Reflect(this MeshSortingOrder instance)
    {
        return new MeshSortingOrderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftAdaptiveControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MicrosoftAdaptiveControllerMacNativeProfileR Reflect(this
        MicrosoftAdaptiveControllerMacNativeProfile instance)
    {
        return new MicrosoftAdaptiveControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXbox360ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MicrosoftXbox360ControllerMacNativeProfileR Reflect(this
        MicrosoftXbox360ControllerMacNativeProfile instance)
    {
        return new MicrosoftXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXboxControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static MicrosoftXboxControllerMacNativeProfileR Reflect(
        this MicrosoftXboxControllerMacNativeProfile instance)
    {
        return new MicrosoftXboxControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXboxOneControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static MicrosoftXboxOneControllerMacNativeProfileR Reflect(this
        MicrosoftXboxOneControllerMacNativeProfile instance)
    {
        return new MicrosoftXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     MicrosoftXboxOneEliteControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static MicrosoftXboxOneEliteControllerMacNativeProfileR Reflect(this
        MicrosoftXboxOneEliteControllerMacNativeProfile instance)
    {
        return new MicrosoftXboxOneEliteControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MKKlassikFightStickMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MKKlassikFightStickMacNativeProfileR Reflect(this MKKlassikFightStickMacNativeProfile instance)
    {
        return new MKKlassikFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MLGControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MLGControllerMacNativeProfileR Reflect(this MLGControllerMacNativeProfile instance)
    {
        return new MLGControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModalDialog allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModalDialogR Reflect(this ModalDialog instance)
    {
        return new ModalDialogR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModHooks allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModHooksR Reflect(this ModHooks instance)
    {
        return new ModHooksR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModHooksGlobalSettings allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModHooksGlobalSettingsR Reflect(this ModHooksGlobalSettings instance)
    {
        return new ModHooksGlobalSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ModVersionDraw allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ModVersionDrawR Reflect(this ModVersionDraw instance)
    {
        return new ModVersionDrawR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaHeroPowerAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaHeroPowerAndroidUnityProfileR Reflect(this MogaHeroPowerAndroidUnityProfile instance)
    {
        return new MogaHeroPowerAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProAndroidUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProAndroidUnityProfileR Reflect(this MogaProAndroidUnityProfile instance)
    {
        return new MogaProAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProLinuxUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProLinuxUnityProfileR Reflect(this MogaProLinuxUnityProfile instance)
    {
        return new MogaProLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProMacUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProMacUnityProfileR Reflect(this MogaProMacUnityProfile instance)
    {
        return new MogaProMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProPowerAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProPowerAndroidUnityProfileR Reflect(this MogaProPowerAndroidUnityProfile instance)
    {
        return new MogaProPowerAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MogaProWindowsUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MogaProWindowsUnityProfileR Reflect(this MogaProWindowsUnityProfile instance)
    {
        return new MogaProWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MonoModAdded allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MonoModAddedR Reflect(this MonoModAdded instance)
    {
        return new MonoModAddedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MonoModOriginal allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MonoModOriginalR Reflect(this MonoModOriginal instance)
    {
        return new MonoModOriginalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MonoModOriginalName allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MonoModOriginalNameR Reflect(this MonoModOriginalName instance)
    {
        return new MonoModOriginalNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseBindingSource allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseBindingSourceR Reflect(this MouseBindingSource instance)
    {
        return new MouseBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseBindingSourceListener allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseBindingSourceListenerR Reflect(this MouseBindingSourceListener instance)
    {
        return new MouseBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseLook allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseLookR Reflect(this MouseLook instance)
    {
        return new MouseLookR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MouseLook2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MouseLook2R Reflect(this MouseLook2 instance)
    {
        return new MouseLook2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePick allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePickR Reflect(this MousePick instance)
    {
        return new MousePickR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePick2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePick2dR Reflect(this MousePick2d instance)
    {
        return new MousePick2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePick2dEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePick2dEventR Reflect(this MousePick2dEvent instance)
    {
        return new MousePick2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MousePickEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MousePickEventR Reflect(this MousePickEvent instance)
    {
        return new MousePickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MoveLiftChain allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MoveLiftChainR Reflect(this MoveLiftChain instance)
    {
        return new MoveLiftChainR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MoveObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MoveObjectR Reflect(this MoveObject instance)
    {
        return new MoveObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MoveTowards allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MoveTowardsR Reflect(this MoveTowards instance)
    {
        return new MoveTowardsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MusicCue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MusicCueR Reflect(this MusicCue instance)
    {
        return new MusicCueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MusicRegion allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MusicRegionR Reflect(this MusicRegion instance)
    {
        return new MusicRegionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MuteAudioChannel allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MuteAudioChannelR Reflect(this MuteAudioChannel instance)
    {
        return new MuteAudioChannelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MVCTEStickMacNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MVCTEStickMacNativeProfileR Reflect(this MVCTEStickMacNativeProfile instance)
    {
        return new MVCTEStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of MyGuid allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static MyGuidR Reflect(this MyGuid instance)
    {
        return new MyGuidR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NaconGC100XFControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static NaconGC100XFControllerMacNativeProfileR Reflect(this NaconGC100XFControllerMacNativeProfile instance)
    {
        return new NaconGC100XFControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NailSlash allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NailSlashR Reflect(this NailSlash instance)
    {
        return new NailSlashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NatecGenesisP44WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NatecGenesisP44WindowsUnityProfileR Reflect(this NatecGenesisP44WindowsUnityProfile instance)
    {
        return new NatecGenesisP44WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDevice allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceR Reflect(this NativeInputDevice instance)
    {
        return new NativeInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDeviceManager allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceManagerR Reflect(this NativeInputDeviceManager instance)
    {
        return new NativeInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDeviceProfileAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceProfileAttributeR Reflect(this NativeInputDeviceProfileAttribute instance)
    {
        return new NativeInputDeviceProfileAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputDeviceProfileList
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputDeviceProfileListR Reflect(this NativeInputDeviceProfileList instance)
    {
        return new NativeInputDeviceProfileListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NativeInputModuleManager allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NativeInputModuleManagerR Reflect(this NativeInputModuleManager instance)
    {
        return new NativeInputModuleManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NavMeshAgentAnimatorSynchronizer
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NavMeshAgentAnimatorSynchronizerR Reflect(this NavMeshAgentAnimatorSynchronizer instance)
    {
        return new NavMeshAgentAnimatorSynchronizerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NewBehaviourScript allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NewBehaviourScriptR Reflect(this NewBehaviourScript instance)
    {
        return new NewBehaviourScriptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NextFrameEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NextFrameEventR Reflect(this NextFrameEvent instance)
    {
        return new NextFrameEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NextSceneOnInput allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NextSceneOnInputR Reflect(this NextSceneOnInput instance)
    {
        return new NextSceneOnInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerAndroidUnityProfileR Reflect(this NexusPlayerAndroidUnityProfile instance)
    {
        return new NexusPlayerAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerMacUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerMacUnityProfileR Reflect(this NexusPlayerMacUnityProfile instance)
    {
        return new NexusPlayerMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerRemoteAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerRemoteAndroidUnityProfileR Reflect(this NexusPlayerRemoteAndroidUnityProfile instance)
    {
        return new NexusPlayerRemoteAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NexusPlayerWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NexusPlayerWindowsUnityProfileR Reflect(this NexusPlayerWindowsUnityProfile instance)
    {
        return new NexusPlayerWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NintendoSwitchProMacChromeUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static NintendoSwitchProMacChromeUnityProfileR Reflect(this NintendoSwitchProMacChromeUnityProfile instance)
    {
        return new NintendoSwitchProMacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NintendoSwitchProMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NintendoSwitchProMacNativeProfileR Reflect(this NintendoSwitchProMacNativeProfile instance)
    {
        return new NintendoSwitchProMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NintendoSwitchProWindowsChromeUnityProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static NintendoSwitchProWindowsChromeUnityProfileR Reflect(this
        NintendoSwitchProWindowsChromeUnityProfile instance)
    {
        return new NintendoSwitchProWindowsChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NintendoSwitchProWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static NintendoSwitchProWindowsNativeProfileR Reflect(this NintendoSwitchProWindowsNativeProfile instance)
    {
        return new NintendoSwitchProWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NoHardLanding allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NoHardLandingR Reflect(this NoHardLanding instance)
    {
        return new NoHardLandingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NonBouncer allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NonBouncerR Reflect(this NonBouncer instance)
    {
        return new NonBouncerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NonSlider allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NonSliderR Reflect(this NonSlider instance)
    {
        return new NonSliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NonThunker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NonThunkerR Reflect(this NonThunker instance)
    {
        return new NonThunkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShield2016AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShield2016AndroidUnityProfileR Reflect(this NVidiaShield2016AndroidUnityProfile instance)
    {
        return new NVidiaShield2016AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShield2017AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShield2017AndroidUnityProfileR Reflect(this NVidiaShield2017AndroidUnityProfile instance)
    {
        return new NVidiaShield2017AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NVidiaShield2017NVidiaShieldUnityProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static NVidiaShield2017NVidiaShieldUnityProfileR
        Reflect(this NVidiaShield2017NVidiaShieldUnityProfile instance)
    {
        return new NVidiaShield2017NVidiaShieldUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     NvidiaShieldRemoteAndroidUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static NvidiaShieldRemoteAndroidUnityProfileR Reflect(this NvidiaShieldRemoteAndroidUnityProfile instance)
    {
        return new NvidiaShieldRemoteAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindows10UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindows10UnityProfileR Reflect(this NVidiaShieldWindows10UnityProfile instance)
    {
        return new NVidiaShieldWindows10UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindows81UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindows81UnityProfileR Reflect(this NVidiaShieldWindows81UnityProfile instance)
    {
        return new NVidiaShieldWindows81UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindowsNativeProfileR Reflect(this NVidiaShieldWindowsNativeProfile instance)
    {
        return new NVidiaShieldWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NVidiaShieldWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NVidiaShieldWindowsUnityProfileR Reflect(this NVidiaShieldWindowsUnityProfile instance)
    {
        return new NVidiaShieldWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of NykoPlayPadProAmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static NykoPlayPadProAmazonUnityProfileR Reflect(this NykoPlayPadProAmazonUnityProfile instance)
    {
        return new NykoPlayPadProAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectBounce allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectBounceR Reflect(this ObjectBounce instance)
    {
        return new ObjectBounceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectCompare allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectCompareR Reflect(this ObjectCompare instance)
    {
        return new ObjectCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectJitter allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectJitterR Reflect(this ObjectJitter instance)
    {
        return new ObjectJitterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectJitterLocal allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectJitterLocalR Reflect(this ObjectJitterLocal instance)
    {
        return new ObjectJitterLocalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ObjectPool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ObjectPoolR Reflect(this ObjectPool instance)
    {
        return new ObjectPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OneAxisInputControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OneAxisInputControlR Reflect(this OneAxisInputControl instance)
    {
        return new OneAxisInputControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OnEnableEnemyHandler allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OnEnableEnemyHandlerR Reflect(this OnEnableEnemyHandler instance)
    {
        return new OnEnableEnemyHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OnReceiveDeathEventHandler allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OnReceiveDeathEventHandlerR Reflect(this OnReceiveDeathEventHandler instance)
    {
        return new OnReceiveDeathEventHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OnScreenDebugInfo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OnScreenDebugInfoR Reflect(this OnScreenDebugInfo instance)
    {
        return new OnScreenDebugInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OpeningGameplayCredits allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OpeningGameplayCreditsR Reflect(this OpeningGameplayCredits instance)
    {
        return new OpeningGameplayCreditsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OpeningSequence allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OpeningSequenceR Reflect(this OpeningSequence instance)
    {
        return new OpeningSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OpenMarkerMenu allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OpenMarkerMenuR Reflect(this OpenMarkerMenu instance)
    {
        return new OpenMarkerMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OptionalTypeHasNoValueException
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OptionalTypeHasNoValueExceptionR Reflect(this OptionalTypeHasNoValueException instance)
    {
        return new OptionalTypeHasNoValueExceptionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaAmazonUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaAmazonUnityProfileR Reflect(this OuyaAmazonUnityProfile instance)
    {
        return new OuyaAmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaEverywhereDevice allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaEverywhereDeviceR Reflect(this OuyaEverywhereDevice instance)
    {
        return new OuyaEverywhereDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaEverywhereDeviceManager allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaEverywhereDeviceManagerR Reflect(this OuyaEverywhereDeviceManager instance)
    {
        return new OuyaEverywhereDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaLinuxUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaLinuxUnityProfileR Reflect(this OuyaLinuxUnityProfile instance)
    {
        return new OuyaLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OUYAWindowsNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OUYAWindowsNativeProfileR Reflect(this OUYAWindowsNativeProfile instance)
    {
        return new OUYAWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OuyaWindowsUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OuyaWindowsUnityProfileR Reflect(this OuyaWindowsUnityProfile instance)
    {
        return new OuyaWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of OverscanSetting allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static OverscanSettingR Reflect(this OverscanSetting instance)
    {
        return new OverscanSettingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Owner allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static OwnerR Reflect(this Owner instance)
    {
        return new OwnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PaintBullet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PaintBulletR Reflect(this PaintBullet instance)
    {
        return new PaintBulletR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PaintSplat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PaintSplatR Reflect(this PaintSplat instance)
    {
        return new PaintSplatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParallaxSorter allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParallaxSorterR Reflect(this ParallaxSorter instance)
    {
        return new ParallaxSorterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemAutoDestroy allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemAutoDestroyR Reflect(this ParticleSystemAutoDestroy instance)
    {
        return new ParticleSystemAutoDestroyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemAutoDisable allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemAutoDisableR Reflect(this ParticleSystemAutoDisable instance)
    {
        return new ParticleSystemAutoDisableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemAutoRecycle allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemAutoRecycleR Reflect(this ParticleSystemAutoRecycle instance)
    {
        return new ParticleSystemAutoRecycleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ParticleSystemCollisionLagFix
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ParticleSystemCollisionLagFixR Reflect(this ParticleSystemCollisionLagFix instance)
    {
        return new ParticleSystemCollisionLagFixR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PauseMenuButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PauseMenuButtonR Reflect(this PauseMenuButton instance)
    {
        return new PauseMenuButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PCTWINSHOCKWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PCTWINSHOCKWindowsNativeProfileR Reflect(this PCTWINSHOCKWindowsNativeProfile instance)
    {
        return new PCTWINSHOCKWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPAfterglowControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static PDPAfterglowControllerMacNativeProfileR Reflect(this PDPAfterglowControllerMacNativeProfile instance)
    {
        return new PDPAfterglowControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPAfterglowPrismaticControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static PDPAfterglowPrismaticControllerMacNativeProfileR Reflect(this
        PDPAfterglowPrismaticControllerMacNativeProfile instance)
    {
        return new PDPAfterglowPrismaticControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPBattlefieldXBoxOneControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static PDPBattlefieldXBoxOneControllerMacNativeProfileR Reflect(this
        PDPBattlefieldXBoxOneControllerMacNativeProfile instance)
    {
        return new PDPBattlefieldXBoxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPMarvelControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPMarvelControllerMacNativeProfileR Reflect(this PDPMarvelControllerMacNativeProfile instance)
    {
        return new PDPMarvelControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPMetallicsLEControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static PDPMetallicsLEControllerMacNativeProfileR
        Reflect(this PDPMetallicsLEControllerMacNativeProfile instance)
    {
        return new PDPMetallicsLEControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPTitanfall2XboxOneControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static PDPTitanfall2XboxOneControllerMacNativeProfileR Reflect(this
        PDPTitanfall2XboxOneControllerMacNativeProfile instance)
    {
        return new PDPTitanfall2XboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPTronControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPTronControllerMacNativeProfileR Reflect(this PDPTronControllerMacNativeProfile instance)
    {
        return new PDPTronControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPVersusControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPVersusControllerMacNativeProfileR Reflect(this PDPVersusControllerMacNativeProfile instance)
    {
        return new PDPVersusControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPXbox360ControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPXbox360ControllerMacNativeProfileR Reflect(this PDPXbox360ControllerMacNativeProfile instance)
    {
        return new PDPXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PDPXboxOneArcadeStickMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static PDPXboxOneArcadeStickMacNativeProfileR Reflect(this PDPXboxOneArcadeStickMacNativeProfile instance)
    {
        return new PDPXboxOneArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PDPXboxOneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PDPXboxOneControllerMacNativeProfileR Reflect(this PDPXboxOneControllerMacNativeProfile instance)
    {
        return new PDPXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PerBuildTypeOnEnableResponse
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PerBuildTypeOnEnableResponseR Reflect(this PerBuildTypeOnEnableResponse instance)
    {
        return new PerBuildTypeOnEnableResponseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PerformanceHUD allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PerformanceHUDR Reflect(this PerformanceHUD instance)
    {
        return new PerformanceHUDR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PermadeathUnlock allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PermadeathUnlockR Reflect(this PermadeathUnlock instance)
    {
        return new PermadeathUnlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PerSecond allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PerSecondR Reflect(this PerSecond instance)
    {
        return new PerSecondR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentBoolData allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentBoolDataR Reflect(this PersistentBoolData instance)
    {
        return new PersistentBoolDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentBoolItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentBoolItemR Reflect(this PersistentBoolItem instance)
    {
        return new PersistentBoolItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentIntData allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentIntDataR Reflect(this PersistentIntData instance)
    {
        return new PersistentIntDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersistentIntItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersistentIntItemR Reflect(this PersistentIntItem instance)
    {
        return new PersistentIntItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PersonalObjectPool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PersonalObjectPoolR Reflect(this PersonalObjectPool instance)
    {
        return new PersonalObjectPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlanarRealtimeReflection allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlanarRealtimeReflectionR Reflect(this PlanarRealtimeReflection instance)
    {
        return new PlanarRealtimeReflectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlatformSpecificLocalisation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlatformSpecificLocalisationR Reflect(this PlatformSpecificLocalisation instance)
    {
        return new PlatformSpecificLocalisationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlatformSpecificSprite allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlatformSpecificSpriteR Reflect(this PlatformSpecificSprite instance)
    {
        return new PlatformSpecificSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlatformVibrationHelper allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlatformVibrationHelperR Reflect(this PlatformVibrationHelper instance)
    {
        return new PlatformVibrationHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayAnimation allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayAnimationR Reflect(this PlayAnimation instance)
    {
        return new PlayAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayAudioAndRecycle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayAudioAndRecycleR Reflect(this PlayAudioAndRecycle instance)
    {
        return new PlayAudioAndRecycleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayAudioEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayAudioEventR Reflect(this PlayAudioEvent instance)
    {
        return new PlayAudioEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerAchievements allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerAchievementsR Reflect(this PlayerAchievements instance)
    {
        return new PlayerAchievementsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerAction allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerActionR Reflect(this PlayerAction instance)
    {
        return new PlayerActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerActionSetConverter allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerActionSetConverterR Reflect(this PlayerActionSetConverter instance)
    {
        return new PlayerActionSetConverterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataBoolAllTrue allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataBoolAllTrueR Reflect(this PlayerDataBoolAllTrue instance)
    {
        return new PlayerDataBoolAllTrueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataBoolTest allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataBoolTestR Reflect(this PlayerDataBoolTest instance)
    {
        return new PlayerDataBoolTestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataBoolTrueAndFalse allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataBoolTrueAndFalseR Reflect(this PlayerDataBoolTrueAndFalse instance)
    {
        return new PlayerDataBoolTrueAndFalseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerDataIntAdd allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerDataIntAddR Reflect(this PlayerDataIntAdd instance)
    {
        return new PlayerDataIntAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerOneAxisAction allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerOneAxisActionR Reflect(this PlayerOneAxisAction instance)
    {
        return new PlayerOneAxisActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsDeleteAll allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsDeleteAllR Reflect(this PlayerPrefsDeleteAll instance)
    {
        return new PlayerPrefsDeleteAllR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsDeleteKey allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsDeleteKeyR Reflect(this PlayerPrefsDeleteKey instance)
    {
        return new PlayerPrefsDeleteKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsGetFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsGetFloatR Reflect(this PlayerPrefsGetFloat instance)
    {
        return new PlayerPrefsGetFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsGetInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsGetIntR Reflect(this PlayerPrefsGetInt instance)
    {
        return new PlayerPrefsGetIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsGetString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsGetStringR Reflect(this PlayerPrefsGetString instance)
    {
        return new PlayerPrefsGetStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsHasKey allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsHasKeyR Reflect(this PlayerPrefsHasKey instance)
    {
        return new PlayerPrefsHasKeyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSetFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSetFloatR Reflect(this PlayerPrefsSetFloat instance)
    {
        return new PlayerPrefsSetFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSetInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSetIntR Reflect(this PlayerPrefsSetInt instance)
    {
        return new PlayerPrefsSetIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSetString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSetStringR Reflect(this PlayerPrefsSetString instance)
    {
        return new PlayerPrefsSetStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerPrefsSharedData allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerPrefsSharedDataR Reflect(this PlayerPrefsSharedData instance)
    {
        return new PlayerPrefsSharedDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayerTwoAxisAction allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayerTwoAxisActionR Reflect(this PlayerTwoAxisAction instance)
    {
        return new PlayerTwoAxisActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayFromRandomFrame allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayFromRandomFrameR Reflect(this PlayFromRandomFrame instance)
    {
        return new PlayFromRandomFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayFromRandomFrameMecanim allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayFromRandomFrameMecanimR Reflect(this PlayFromRandomFrameMecanim instance)
    {
        return new PlayFromRandomFrameMecanimR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayHitEffects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayHitEffectsR Reflect(this PlayHitEffects instance)
    {
        return new PlayHitEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerAnimatorIKProxy allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerAnimatorIKProxyR Reflect(this PlayMakerAnimatorIKProxy instance)
    {
        return new PlayMakerAnimatorIKProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerAnimatorMoveProxy allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerAnimatorMoveProxyR Reflect(this PlayMakerAnimatorMoveProxy instance)
    {
        return new PlayMakerAnimatorMoveProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayMakerAnimatorStateSynchronization allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static PlayMakerAnimatorStateSynchronizationR Reflect(this PlayMakerAnimatorStateSynchronization instance)
    {
        return new PlayMakerAnimatorStateSynchronizationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerArrayListProxy allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerArrayListProxyR Reflect(this PlayMakerArrayListProxy instance)
    {
        return new PlayMakerArrayListProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerEventR Reflect(this PlayMakerEvent instance)
    {
        return new PlayMakerEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerEventTarget allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerEventTargetR Reflect(this PlayMakerEventTarget instance)
    {
        return new PlayMakerEventTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerHashTableProxy allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerHashTableProxyR Reflect(this PlayMakerHashTableProxy instance)
    {
        return new PlayMakerHashTableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayMakerUGuiCanvasRaycastFilterEventsProxy allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static PlayMakerUGuiCanvasRaycastFilterEventsProxyR Reflect(this
        PlayMakerUGuiCanvasRaycastFilterEventsProxy instance)
    {
        return new PlayMakerUGuiCanvasRaycastFilterEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiComponentProxy allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiComponentProxyR Reflect(this PlayMakerUGuiComponentProxy instance)
    {
        return new PlayMakerUGuiComponentProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiDragEventsProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiDragEventsProxyR Reflect(this PlayMakerUGuiDragEventsProxy instance)
    {
        return new PlayMakerUGuiDragEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiDropEventsProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiDropEventsProxyR Reflect(this PlayMakerUGuiDropEventsProxy instance)
    {
        return new PlayMakerUGuiDropEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiPointerEventsProxy
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiPointerEventsProxyR Reflect(this PlayMakerUGuiPointerEventsProxy instance)
    {
        return new PlayMakerUGuiPointerEventsProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUGuiSceneProxy allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUGuiSceneProxyR Reflect(this PlayMakerUGuiSceneProxy instance)
    {
        return new PlayMakerUGuiSceneProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUnity2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUnity2dR Reflect(this PlayMakerUnity2d instance)
    {
        return new PlayMakerUnity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUnity2DProxy allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUnity2DProxyR Reflect(this PlayMakerUnity2DProxy instance)
    {
        return new PlayMakerUnity2DProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayMakerUtils allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayMakerUtilsR Reflect(this PlayMakerUtils instance)
    {
        return new PlayMakerUtilsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleEffects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleEffectsR Reflect(this PlayParticleEffects instance)
    {
        return new PlayParticleEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleEmitter allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleEmitterR Reflect(this PlayParticleEmitter instance)
    {
        return new PlayParticleEmitterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleEmitterInState allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleEmitterInStateR Reflect(this PlayParticleEmitterInState instance)
    {
        return new PlayParticleEmitterInStateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayParticleOnEntry allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayParticleOnEntryR Reflect(this PlayParticleOnEntry instance)
    {
        return new PlayParticleOnEntryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayRandomAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayRandomAnimationR Reflect(this PlayRandomAnimation instance)
    {
        return new PlayRandomAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayRandomSound allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayRandomSoundR Reflect(this PlayRandomSound instance)
    {
        return new PlayRandomSoundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlaySound allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlaySoundR Reflect(this PlaySound instance)
    {
        return new PlaySoundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation2LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation2LinuxUnityProfileR Reflect(this PlayStation2LinuxUnityProfile instance)
    {
        return new PlayStation2LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation2WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation2WindowsUnityProfileR Reflect(this PlayStation2WindowsUnityProfile instance)
    {
        return new PlayStation2WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3AndroidUnityProfileR Reflect(this PlayStation3AndroidUnityProfile instance)
    {
        return new PlayStation3AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3BWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3BWindowsUnityProfileR Reflect(this PlayStation3BWindowsUnityProfile instance)
    {
        return new PlayStation3BWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3LinuxUnityProfileR Reflect(this PlayStation3LinuxUnityProfile instance)
    {
        return new PlayStation3LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3MacNativeProfileR Reflect(this PlayStation3MacNativeProfile instance)
    {
        return new PlayStation3MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3MacUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3MacUnityProfileR Reflect(this PlayStation3MacUnityProfile instance)
    {
        return new PlayStation3MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayStation3ShenghicWindowsUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static PlayStation3ShenghicWindowsUnityProfileR Reflect(
        this PlayStation3ShenghicWindowsUnityProfile instance)
    {
        return new PlayStation3ShenghicWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation3WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation3WindowsUnityProfileR Reflect(this PlayStation3WindowsUnityProfile instance)
    {
        return new PlayStation3WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4AmazonUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4AmazonUnityProfileR Reflect(this PlayStation4AmazonUnityProfile instance)
    {
        return new PlayStation4AmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4AndroidUnityProfileR Reflect(this PlayStation4AndroidUnityProfile instance)
    {
        return new PlayStation4AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4LinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4LinuxUnityProfileR Reflect(this PlayStation4LinuxUnityProfile instance)
    {
        return new PlayStation4LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacBluetoothUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacBluetoothUnityProfileR Reflect(this PlayStation4MacBluetoothUnityProfile instance)
    {
        return new PlayStation4MacBluetoothUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacChromeUnityProfileR Reflect(this PlayStation4MacChromeUnityProfile instance)
    {
        return new PlayStation4MacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacFirefoxUnityProfileR Reflect(this PlayStation4MacFirefoxUnityProfile instance)
    {
        return new PlayStation4MacFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacNativeProfileR Reflect(this PlayStation4MacNativeProfile instance)
    {
        return new PlayStation4MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4MacUSBUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4MacUSBUnityProfileR Reflect(this PlayStation4MacUSBUnityProfile instance)
    {
        return new PlayStation4MacUSBUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4SteamLinkMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4SteamLinkMacUnityProfileR Reflect(this PlayStation4SteamLinkMacUnityProfile instance)
    {
        return new PlayStation4SteamLinkMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4UnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4UnityProfileR Reflect(this PlayStation4UnityProfile instance)
    {
        return new PlayStation4UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayStation4WindowsChromeUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static PlayStation4WindowsChromeUnityProfileR Reflect(this PlayStation4WindowsChromeUnityProfile instance)
    {
        return new PlayStation4WindowsChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PlayStation4WindowsFirefoxUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static PlayStation4WindowsFirefoxUnityProfileR Reflect(this PlayStation4WindowsFirefoxUnityProfile instance)
    {
        return new PlayStation4WindowsFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4WindowsNativeProfileR Reflect(this PlayStation4WindowsNativeProfile instance)
    {
        return new PlayStation4WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation4WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation4WindowsUnityProfileR Reflect(this PlayStation4WindowsUnityProfile instance)
    {
        return new PlayStation4WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation5MacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation5MacNativeProfileR Reflect(this PlayStation5MacNativeProfile instance)
    {
        return new PlayStation5MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation5UnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation5UnityProfileR Reflect(this PlayStation5UnityProfile instance)
    {
        return new PlayStation5UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStation5WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStation5WindowsNativeProfileR Reflect(this PlayStation5WindowsNativeProfile instance)
    {
        return new PlayStation5WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayStationVitaPSMUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayStationVitaPSMUnityProfileR Reflect(this PlayStationVitaPSMUnityProfile instance)
    {
        return new PlayStationVitaPSMUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PlayVibration allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PlayVibrationR Reflect(this PlayVibration instance)
    {
        return new PlayVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PositionShadeMarkerPerDoor allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PositionShadeMarkerPerDoorR Reflect(this PositionShadeMarkerPerDoor instance)
    {
        return new PositionShadeMarkerPerDoorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerAAirflowControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static PowerAAirflowControllerMacNativeProfileR Reflect(
        this PowerAAirflowControllerMacNativeProfile instance)
    {
        return new PowerAAirflowControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     POWERAFUS1ONTournamentControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static POWERAFUS1ONTournamentControllerMacNativeProfileR Reflect(this
        POWERAFUS1ONTournamentControllerMacNativeProfile instance)
    {
        return new POWERAFUS1ONTournamentControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PowerAMiniControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerAMiniControllerMacNativeProfileR Reflect(this PowerAMiniControllerMacNativeProfile instance)
    {
        return new PowerAMiniControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerAMiniProExControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static PowerAMiniProExControllerMacNativeProfileR
        Reflect(this PowerAMiniProExControllerMacNativeProfile instance)
    {
        return new PowerAMiniProExControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerAMiniXboxOneControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static PowerAMiniXboxOneControllerMacNativeProfileR Reflect(this
        PowerAMiniXboxOneControllerMacNativeProfile instance)
    {
        return new PowerAMiniXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PowerANintendoSwitchMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PowerANintendoSwitchMacNativeProfileR Reflect(this PowerANintendoSwitchMacNativeProfile instance)
    {
        return new PowerANintendoSwitchMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     PowerASpectraIlluminatedControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static PowerASpectraIlluminatedControllerMacNativeProfileR Reflect(this
        PowerASpectraIlluminatedControllerMacNativeProfile instance)
    {
        return new PowerASpectraIlluminatedControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreBuildTK2DSprites allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreBuildTK2DSpritesR Reflect(this PreBuildTK2DSprites instance)
    {
        return new PreBuildTK2DSpritesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PrefabSwapper allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PrefabSwapperR Reflect(this PrefabSwapper instance)
    {
        return new PrefabSwapperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreInstantiateGameObject allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreInstantiateGameObjectR Reflect(this PreInstantiateGameObject instance)
    {
        return new PreInstantiateGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreloadVibration allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreloadVibrationR Reflect(this PreloadVibration instance)
    {
        return new PreloadVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreMenuInputModuleActionAdaptor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreMenuInputModuleActionAdaptorR Reflect(this PreMenuInputModuleActionAdaptor instance)
    {
        return new PreMenuInputModuleActionAdaptorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreselectOption allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreselectOptionR Reflect(this PreselectOption instance)
    {
        return new PreselectOptionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreserveAttribute allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreserveAttributeR Reflect(this PreserveAttribute instance)
    {
        return new PreserveAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreSpawnCorpse allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreSpawnCorpseR Reflect(this PreSpawnCorpse instance)
    {
        return new PreSpawnCorpseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreSpawnGameObjects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreSpawnGameObjectsR Reflect(this PreSpawnGameObjects instance)
    {
        return new PreSpawnGameObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PreventInvincibleEffect allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PreventInvincibleEffectR Reflect(this PreventInvincibleEffect instance)
    {
        return new PreventInvincibleEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Probability allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProbabilityR Reflect(this Probability instance)
    {
        return new ProbabilityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ProEXXbox360ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static ProEXXbox360ControllerMacNativeProfileR Reflect(this ProEXXbox360ControllerMacNativeProfile instance)
    {
        return new ProEXXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ProEXXboxOneControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static ProEXXboxOneControllerMacNativeProfileR Reflect(this ProEXXboxOneControllerMacNativeProfile instance)
    {
        return new ProEXXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ProgressSaveMessagePanel allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProgressSaveMessagePanelR Reflect(this ProgressSaveMessagePanel instance)
    {
        return new ProgressSaveMessagePanelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ProjectileSquash allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProjectileSquashR Reflect(this ProjectileSquash instance)
    {
        return new ProjectileSquashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ProjectLocationToMap allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ProjectLocationToMapR Reflect(this ProjectLocationToMap instance)
    {
        return new ProjectLocationToMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PromptMarker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PromptMarkerR Reflect(this PromptMarker instance)
    {
        return new PromptMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PS4SimpleInputDevice allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PS4SimpleInputDeviceR Reflect(this PS4SimpleInputDevice instance)
    {
        return new PS4SimpleInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PS4SimpleInputDeviceManager allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PS4SimpleInputDeviceManagerR Reflect(this PS4SimpleInputDeviceManager instance)
    {
        return new PS4SimpleInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of PushableRubble allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static PushableRubbleR Reflect(this PushableRubble instance)
    {
        return new PushableRubbleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QanbaFightStickPlusMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QanbaFightStickPlusMacNativeProfileR Reflect(this QanbaFightStickPlusMacNativeProfile instance)
    {
        return new QanbaFightStickPlusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionAngleAxis allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionAngleAxisR Reflect(this QuaternionAngleAxis instance)
    {
        return new QuaternionAngleAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionCompare allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionCompareR Reflect(this QuaternionCompare instance)
    {
        return new QuaternionCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionEuler allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionEulerR Reflect(this QuaternionEuler instance)
    {
        return new QuaternionEulerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionInverse allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionInverseR Reflect(this QuaternionInverse instance)
    {
        return new QuaternionInverseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionLerp allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionLerpR Reflect(this QuaternionLerp instance)
    {
        return new QuaternionLerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionLookRotation allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionLookRotationR Reflect(this QuaternionLookRotation instance)
    {
        return new QuaternionLookRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionLowPassFilter allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionLowPassFilterR Reflect(this QuaternionLowPassFilter instance)
    {
        return new QuaternionLowPassFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionRotateTowards allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionRotateTowardsR Reflect(this QuaternionRotateTowards instance)
    {
        return new QuaternionRotateTowardsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuaternionSlerp allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuaternionSlerpR Reflect(this QuaternionSlerp instance)
    {
        return new QuaternionSlerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of QuitToMenu allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static QuitToMenuR Reflect(this QuitToMenu instance)
    {
        return new QuitToMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RadialLayoutUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RadialLayoutUIR Reflect(this RadialLayoutUI instance)
    {
        return new RadialLayoutUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomAudioClipTable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomAudioClipTableR Reflect(this RandomAudioClipTable instance)
    {
        return new RandomAudioClipTableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomAudioStart allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomAudioStartR Reflect(this RandomAudioStart instance)
    {
        return new RandomAudioStartR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomBool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomBoolR Reflect(this RandomBool instance)
    {
        return new RandomBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomEventR Reflect(this RandomEvent instance)
    {
        return new RandomEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFloat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFloatR Reflect(this RandomFloat instance)
    {
        return new RandomFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFloatEither allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFloatEitherR Reflect(this RandomFloatEither instance)
    {
        return new RandomFloatEitherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFloatV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFloatV2R Reflect(this RandomFloatV2 instance)
    {
        return new RandomFloatV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomFrame allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomFrameR Reflect(this RandomFrame instance)
    {
        return new RandomFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomInt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomIntR Reflect(this RandomInt instance)
    {
        return new RandomIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomlyFlipFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomlyFlipFloatR Reflect(this RandomlyFlipFloat instance)
    {
        return new RandomlyFlipFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomRotation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomRotationR Reflect(this RandomRotation instance)
    {
        return new RandomRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomRotationRange allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomRotationRangeR Reflect(this RandomRotationRange instance)
    {
        return new RandomRotationRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomScale allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomScaleR Reflect(this RandomScale instance)
    {
        return new RandomScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RandomWait allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RandomWaitR Reflect(this RandomWait instance)
    {
        return new RandomWaitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Raycast allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RaycastR Reflect(this Raycast instance)
    {
        return new RaycastR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RayCast2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RayCast2dR Reflect(this RayCast2d instance)
    {
        return new RayCast2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RayCast2dV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RayCast2dV2R Reflect(this RayCast2dV2 instance)
    {
        return new RayCast2dV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RaycastAll allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RaycastAllR Reflect(this RaycastAll instance)
    {
        return new RaycastAllR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerAtroxArcadeStickMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static RazerAtroxArcadeStickMacNativeProfileR Reflect(this RazerAtroxArcadeStickMacNativeProfile instance)
    {
        return new RazerAtroxArcadeStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerOnzaControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerOnzaControllerMacNativeProfileR Reflect(this RazerOnzaControllerMacNativeProfile instance)
    {
        return new RazerOnzaControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerOnzaTEControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static RazerOnzaTEControllerMacNativeProfileR Reflect(this RazerOnzaTEControllerMacNativeProfile instance)
    {
        return new RazerOnzaTEControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerSabertoothEliteControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static RazerSabertoothEliteControllerMacNativeProfileR Reflect(this
        RazerSabertoothEliteControllerMacNativeProfile instance)
    {
        return new RazerSabertoothEliteControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerServalForgeTVUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerServalForgeTVUnityProfileR Reflect(this RazerServalForgeTVUnityProfile instance)
    {
        return new RazerServalForgeTVUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerServalMacUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerServalMacUnityProfileR Reflect(this RazerServalMacUnityProfile instance)
    {
        return new RazerServalMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RazerServalWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RazerServalWindowsNativeProfileR Reflect(this RazerServalWindowsNativeProfile instance)
    {
        return new RazerServalWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerStrikeControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static RazerStrikeControllerMacNativeProfileR Reflect(this RazerStrikeControllerMacNativeProfile instance)
    {
        return new RazerStrikeControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerWildcatControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static RazerWildcatControllerMacNativeProfileR Reflect(this RazerWildcatControllerMacNativeProfile instance)
    {
        return new RazerWildcatControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RazerWolverineUltimateControllerMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static RazerWolverineUltimateControllerMacNativeProfileR Reflect(this
        RazerWolverineUltimateControllerMacNativeProfile instance)
    {
        return new RazerWolverineUltimateControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RealtimeReflections allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RealtimeReflectionsR Reflect(this RealtimeReflections instance)
    {
        return new RealtimeReflectionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReceivedDamage allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReceivedDamageR Reflect(this ReceivedDamage instance)
    {
        return new ReceivedDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReceivedDamageStay allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReceivedDamageStayR Reflect(this ReceivedDamageStay instance)
    {
        return new ReceivedDamageStayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Recoil allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecoilR Reflect(this Recoil instance)
    {
        return new RecoilR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RecordKillForJournalHandler allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecordKillForJournalHandlerR Reflect(this RecordKillForJournalHandler instance)
    {
        return new RecordKillForJournalHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectContains allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectContainsR Reflect(this RectContains instance)
    {
        return new RectContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectOverlaps allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectOverlapsR Reflect(this RectOverlaps instance)
    {
        return new RectOverlapsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformFlipLayoutAxis allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformFlipLayoutAxisR Reflect(this RectTransformFlipLayoutAxis instance)
    {
        return new RectTransformFlipLayoutAxisR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetAnchoredPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetAnchoredPositionR Reflect(this RectTransformGetAnchoredPosition instance)
    {
        return new RectTransformGetAnchoredPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetAnchorMax allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetAnchorMaxR Reflect(this RectTransformGetAnchorMax instance)
    {
        return new RectTransformGetAnchorMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetAnchorMin allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetAnchorMinR Reflect(this RectTransformGetAnchorMin instance)
    {
        return new RectTransformGetAnchorMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetLocalPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetLocalPositionR Reflect(this RectTransformGetLocalPosition instance)
    {
        return new RectTransformGetLocalPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetLocalRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetLocalRotationR Reflect(this RectTransformGetLocalRotation instance)
    {
        return new RectTransformGetLocalRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetOffsetMax allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetOffsetMaxR Reflect(this RectTransformGetOffsetMax instance)
    {
        return new RectTransformGetOffsetMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetOffsetMin allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetOffsetMinR Reflect(this RectTransformGetOffsetMin instance)
    {
        return new RectTransformGetOffsetMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetPivot allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetPivotR Reflect(this RectTransformGetPivot instance)
    {
        return new RectTransformGetPivotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetRect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetRectR Reflect(this RectTransformGetRect instance)
    {
        return new RectTransformGetRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetScale allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetScaleR Reflect(this RectTransformGetScale instance)
    {
        return new RectTransformGetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformGetSizeDelta allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformGetSizeDeltaR Reflect(this RectTransformGetSizeDelta instance)
    {
        return new RectTransformGetSizeDeltaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformPixelAdjustPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformPixelAdjustPointR Reflect(this RectTransformPixelAdjustPoint instance)
    {
        return new RectTransformPixelAdjustPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformPixelAdjustRect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformPixelAdjustRectR Reflect(this RectTransformPixelAdjustRect instance)
    {
        return new RectTransformPixelAdjustRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchoredPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchoredPositionR Reflect(this RectTransformSetAnchoredPosition instance)
    {
        return new RectTransformSetAnchoredPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchorMax allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchorMaxR Reflect(this RectTransformSetAnchorMax instance)
    {
        return new RectTransformSetAnchorMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchorMin allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchorMinR Reflect(this RectTransformSetAnchorMin instance)
    {
        return new RectTransformSetAnchorMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetAnchorRectPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetAnchorRectPositionR Reflect(this RectTransformSetAnchorRectPosition instance)
    {
        return new RectTransformSetAnchorRectPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetLocalPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetLocalPositionR Reflect(this RectTransformSetLocalPosition instance)
    {
        return new RectTransformSetLocalPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetLocalRotation
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetLocalRotationR Reflect(this RectTransformSetLocalRotation instance)
    {
        return new RectTransformSetLocalRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetOffsetMax allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetOffsetMaxR Reflect(this RectTransformSetOffsetMax instance)
    {
        return new RectTransformSetOffsetMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetOffsetMin allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetOffsetMinR Reflect(this RectTransformSetOffsetMin instance)
    {
        return new RectTransformSetOffsetMinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetPivot allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetPivotR Reflect(this RectTransformSetPivot instance)
    {
        return new RectTransformSetPivotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformSetSizeDelta allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformSetSizeDeltaR Reflect(this RectTransformSetSizeDelta instance)
    {
        return new RectTransformSetSizeDeltaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RectTransformWorldToScreenPoint
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RectTransformWorldToScreenPointR Reflect(this RectTransformWorldToScreenPoint instance)
    {
        return new RectTransformWorldToScreenPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RecycleAfter2dtkAnimation allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecycleAfter2dtkAnimationR Reflect(this RecycleAfter2dtkAnimation instance)
    {
        return new RecycleAfter2dtkAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RecycleSelf allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RecycleSelfR Reflect(this RecycleSelf instance)
    {
        return new RecycleSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RedOctaneControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RedOctaneControllerMacNativeProfileR Reflect(this RedOctaneControllerMacNativeProfile instance)
    {
        return new RedOctaneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RedOctaneGuitarMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RedOctaneGuitarMacNativeProfileR Reflect(this RedOctaneGuitarMacNativeProfile instance)
    {
        return new RedOctaneGuitarMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RedSamuraiAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RedSamuraiAndroidUnityProfileR Reflect(this RedSamuraiAndroidUnityProfile instance)
    {
        return new RedSamuraiAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReduceParticleEffects allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReduceParticleEffectsR Reflect(this ReduceParticleEffects instance)
    {
        return new ReduceParticleEffectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of References allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReferencesR Reflect(this References instance)
    {
        return new ReferencesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReflectAngle allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReflectAngleR Reflect(this ReflectAngle instance)
    {
        return new ReflectAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RegionDebugger allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RegionDebuggerR Reflect(this RegionDebugger instance)
    {
        return new RegionDebuggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RegionSetAudio allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RegionSetAudioR Reflect(this RegionSetAudio instance)
    {
        return new RegionSetAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RegularGridLayout allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RegularGridLayoutR Reflect(this RegularGridLayout instance)
    {
        return new RegularGridLayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemapTK2DSpriteAnimator allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemapTK2DSpriteAnimatorR Reflect(this RemapTK2DSpriteAnimator instance)
    {
        return new RemapTK2DSpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoteDisable allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoteDisableR Reflect(this RemoteDisable instance)
    {
        return new RemoteDisableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoteDisableChild allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoteDisableChildR Reflect(this RemoteDisableChild instance)
    {
        return new RemoteDisableChildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoveAllComponents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoveAllComponentsR Reflect(this RemoveAllComponents instance)
    {
        return new RemoveAllComponentsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoveMethodCall allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoveMethodCallR Reflect(this RemoveMethodCall instance)
    {
        return new RemoveMethodCallR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RemoveMixingTransform allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RemoveMixingTransformR Reflect(this RemoveMixingTransform instance)
    {
        return new RemoveMixingTransformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ReplaceTextLineBreaks allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ReplaceTextLineBreaksR Reflect(this ReplaceTextLineBreaks instance)
    {
        return new ReplaceTextLineBreaksR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RequestFadeSceneIn allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RequestFadeSceneInR Reflect(this RequestFadeSceneIn instance)
    {
        return new RequestFadeSceneInR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ResetGUIMatrix allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ResetGUIMatrixR Reflect(this ResetGUIMatrix instance)
    {
        return new ResetGUIMatrixR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ResetInputAxes allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ResetInputAxesR Reflect(this ResetInputAxes instance)
    {
        return new ResetInputAxesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ResolutionCountdownTimer allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ResolutionCountdownTimerR Reflect(this ResolutionCountdownTimer instance)
    {
        return new ResolutionCountdownTimerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RespawnMarker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RespawnMarkerR Reflect(this RespawnMarker instance)
    {
        return new RespawnMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RespawnTrigger allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RespawnTriggerR Reflect(this RespawnTrigger instance)
    {
        return new RespawnTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestartLevel allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestartLevelR Reflect(this RestartLevel instance)
    {
        return new RestartLevelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestBench allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestBenchR Reflect(this RestBench instance)
    {
        return new RestBenchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestBenchTilt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestBenchTiltR Reflect(this RestBenchTilt instance)
    {
        return new RestBenchTiltR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RestoreGameObjectPositions allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RestoreGameObjectPositionsR Reflect(this RestoreGameObjectPositions instance)
    {
        return new RestoreGameObjectPositionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RewindAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RewindAnimationR Reflect(this RewindAnimation instance)
    {
        return new RewindAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RockBandDrumsMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockBandDrumsMacNativeProfileR Reflect(this RockBandDrumsMacNativeProfile instance)
    {
        return new RockBandDrumsMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RockBandGuitarMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockBandGuitarMacNativeProfileR Reflect(this RockBandGuitarMacNativeProfile instance)
    {
        return new RockBandGuitarMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RockCandyControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RockCandyControllerMacNativeProfileR Reflect(this RockCandyControllerMacNativeProfile instance)
    {
        return new RockCandyControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RockCandyPS3ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static RockCandyPS3ControllerMacNativeProfileR Reflect(this RockCandyPS3ControllerMacNativeProfile instance)
    {
        return new RockCandyPS3ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RockCandyXbox360ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static RockCandyXbox360ControllerMacNativeProfileR Reflect(this
        RockCandyXbox360ControllerMacNativeProfile instance)
    {
        return new RockCandyXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     RockCandyXboxOneControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static RockCandyXboxOneControllerMacNativeProfileR Reflect(this
        RockCandyXboxOneControllerMacNativeProfile instance)
    {
        return new RockCandyXboxOneControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Roof allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static RoofR Reflect(this Roof instance)
    {
        return new RoofR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Rotate allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotateR Reflect(this Rotate instance)
    {
        return new RotateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RotateGUI allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotateGUIR Reflect(this RotateGUI instance)
    {
        return new RotateGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RotateTo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotateToR Reflect(this RotateTo instance)
    {
        return new RotateToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RotationController allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RotationControllerR Reflect(this RotationController instance)
    {
        return new RotationControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RoughMapRoom allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RoughMapRoomR Reflect(this RoughMapRoom instance)
    {
        return new RoughMapRoomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RuinsLift allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RuinsLiftR Reflect(this RuinsLift instance)
    {
        return new RuinsLiftR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RunAway allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RunAwayR Reflect(this RunAway instance)
    {
        return new RunAwayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RunFSM allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RunFSMR Reflect(this RunFSM instance)
    {
        return new RunFSMR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of RunGarbageCollector allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static RunGarbageCollectorR Reflect(this RunGarbageCollector instance)
    {
        return new RunGarbageCollectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaitekAviatorWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaitekAviatorWindowsUnityProfileR Reflect(this SaitekAviatorWindowsUnityProfile instance)
    {
        return new SaitekAviatorWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SaitekXbox360ControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static SaitekXbox360ControllerMacNativeProfileR Reflect(
        this SaitekXbox360ControllerMacNativeProfile instance)
    {
        return new SaitekXbox360ControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SampleCurve allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SampleCurveR Reflect(this SampleCurve instance)
    {
        return new SampleCurveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SamsungGP20AndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SamsungGP20AndroidUnityProfileR Reflect(this SamsungGP20AndroidUnityProfile instance)
    {
        return new SamsungGP20AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveConfig allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveConfigR Reflect(this SaveConfig instance)
    {
        return new SaveConfigR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveGameData allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveGameDataR Reflect(this SaveGameData instance)
    {
        return new SaveGameDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveProfileHealthBar allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveProfileHealthBarR Reflect(this SaveProfileHealthBar instance)
    {
        return new SaveProfileHealthBarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveProfileMPSlots allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveProfileMPSlotsR Reflect(this SaveProfileMPSlots instance)
    {
        return new SaveProfileMPSlotsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveSlotBackgrounds allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveSlotBackgroundsR Reflect(this SaveSlotBackgrounds instance)
    {
        return new SaveSlotBackgroundsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveSlotButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveSlotButtonR Reflect(this SaveSlotButton instance)
    {
        return new SaveSlotButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveSlotOverrides allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveSlotOverridesR Reflect(this SaveSlotOverrides instance)
    {
        return new SaveSlotOverridesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SaveStats allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SaveStatsR Reflect(this SaveStats instance)
    {
        return new SaveStatsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScaleGUI allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScaleGUIR Reflect(this ScaleGUI instance)
    {
        return new ScaleGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScaleTime allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScaleTimeR Reflect(this ScaleTime instance)
    {
        return new ScaleTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScaleTo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScaleToR Reflect(this ScaleTo instance)
    {
        return new ScaleToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneAdditiveLoadConditional
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneAdditiveLoadConditionalR Reflect(this SceneAdditiveLoadConditional instance)
    {
        return new SceneAdditiveLoadConditionalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneColorManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneColorManagerR Reflect(this SceneColorManager instance)
    {
        return new SceneColorManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneData allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneDataRR Reflect(this SceneData instance)
    {
        return new SceneDataRR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneDefaultSettings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneDefaultSettingsR Reflect(this SceneDefaultSettings instance)
    {
        return new SceneDefaultSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneImporter allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneImporterR Reflect(this SceneImporter instance)
    {
        return new SceneImporterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneLoad allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneLoadR Reflect(this SceneLoad instance)
    {
        return new SceneLoadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneManagerR Reflect(this SceneManager instance)
    {
        return new SceneManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneManagerSettings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneManagerSettingsR Reflect(this SceneManagerSettings instance)
    {
        return new SceneManagerSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneParticles allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneParticlesR Reflect(this SceneParticles instance)
    {
        return new SceneParticlesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneParticlesController allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneParticlesControllerR Reflect(this SceneParticlesController instance)
    {
        return new SceneParticlesControllerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScenePreloader allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScenePreloaderR Reflect(this ScenePreloader instance)
    {
        return new ScenePreloaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SceneryTriggerCircle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SceneryTriggerCircleR Reflect(this SceneryTriggerCircle instance)
    {
        return new SceneryTriggerCircleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenPick allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenPickR Reflect(this ScreenPick instance)
    {
        return new ScreenPickR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenPick2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenPick2dR Reflect(this ScreenPick2d instance)
    {
        return new ScreenPick2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenSetResolution allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenSetResolutionR Reflect(this ScreenSetResolution instance)
    {
        return new ScreenSetResolutionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScreenToWorldPoint allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScreenToWorldPointR Reflect(this ScreenToWorldPoint instance)
    {
        return new ScreenToWorldPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScrollBarHandle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScrollBarHandleR Reflect(this ScrollBarHandle instance)
    {
        return new ScrollBarHandleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScrollPaneSelector allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScrollPaneSelectorR Reflect(this ScrollPaneSelector instance)
    {
        return new ScrollPaneSelectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ScuttlerControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ScuttlerControlR Reflect(this ScuttlerControl instance)
    {
        return new ScuttlerControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SecurePlayerPrefs allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SecurePlayerPrefsR Reflect(this SecurePlayerPrefs instance)
    {
        return new SecurePlayerPrefsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SecurePlayerPrefsDemo allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SecurePlayerPrefsDemoR Reflect(this SecurePlayerPrefsDemo instance)
    {
        return new SecurePlayerPrefsDemoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SecureplayerPrefsDemoClass allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SecureplayerPrefsDemoClassR Reflect(this SecureplayerPrefsDemoClass instance)
    {
        return new SecureplayerPrefsDemoClassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectCharmBackboard allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectCharmBackboardR Reflect(this SelectCharmBackboard instance)
    {
        return new SelectCharmBackboardR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomColorR Reflect(this SelectRandomColor instance)
    {
        return new SelectRandomColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomGameObject allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomGameObjectR Reflect(this SelectRandomGameObject instance)
    {
        return new SelectRandomGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomStringR Reflect(this SelectRandomString instance)
    {
        return new SelectRandomStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SelectRandomVector3 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SelectRandomVector3R Reflect(this SelectRandomVector3 instance)
    {
        return new SelectRandomVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendDeathEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendDeathEventR Reflect(this SendDeathEvent instance)
    {
        return new SendDeathEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendDreamImpact allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendDreamImpactR Reflect(this SendDreamImpact instance)
    {
        return new SendDreamImpactR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEnemyMessage allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEnemyMessageR Reflect(this SendEnemyMessage instance)
    {
        return new SendEnemyMessageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEnemyMessageTrigger allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEnemyMessageTriggerR Reflect(this SendEnemyMessageTrigger instance)
    {
        return new SendEnemyMessageTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventR Reflect(this SendEvent instance)
    {
        return new SendEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventByName allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventByNameR Reflect(this SendEventByName instance)
    {
        return new SendEventByNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventByNameV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventByNameV2R Reflect(this SendEventByNameV2 instance)
    {
        return new SendEventByNameV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventByScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventByScaleR Reflect(this SendEventByScale instance)
    {
        return new SendEventByScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventToFsm allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventToFsmR Reflect(this SendEventToFsm instance)
    {
        return new SendEventToFsmR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventToGameObjectOptimized
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventToGameObjectOptimizedR Reflect(this SendEventToGameObjectOptimized instance)
    {
        return new SendEventToGameObjectOptimizedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendEventToRegister allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendEventToRegisterR Reflect(this SendEventToRegister instance)
    {
        return new SendEventToRegisterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendExtraDamage allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendExtraDamageR Reflect(this SendExtraDamage instance)
    {
        return new SendExtraDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendFSMEventOnEntry allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendFSMEventOnEntryR Reflect(this SendFSMEventOnEntry instance)
    {
        return new SendFSMEventOnEntryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendHealthManagerDeathEvent allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendHealthManagerDeathEventR Reflect(this SendHealthManagerDeathEvent instance)
    {
        return new SendHealthManagerDeathEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendMessage allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendMessageR Reflect(this SendMessage instance)
    {
        return new SendMessageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendMessageByTag allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendMessageByTagR Reflect(this SendMessageByTag instance)
    {
        return new SendMessageByTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendMessageV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendMessageV2R Reflect(this SendMessageV2 instance)
    {
        return new SendMessageV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendPlaymakerEventOnEnable allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendPlaymakerEventOnEnableR Reflect(this SendPlaymakerEventOnEnable instance)
    {
        return new SendPlaymakerEventOnEnableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendRandomEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendRandomEventR Reflect(this SendRandomEvent instance)
    {
        return new SendRandomEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendRandomEventV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendRandomEventV2R Reflect(this SendRandomEventV2 instance)
    {
        return new SendRandomEventV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendRandomEventV3 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendRandomEventV3R Reflect(this SendRandomEventV3 instance)
    {
        return new SendRandomEventV3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendTrigger2DEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendTrigger2DEventR Reflect(this SendTrigger2DEvent instance)
    {
        return new SendTrigger2DEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SendTrigger2DEventByName allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SendTrigger2DEventByNameR Reflect(this SendTrigger2DEventByName instance)
    {
        return new SendTrigger2DEventByNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SequenceEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SequenceEventR Reflect(this SequenceEvent instance)
    {
        return new SequenceEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAllFsmGameObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAllFsmGameObjectR Reflect(this SetAllFsmGameObject instance)
    {
        return new SetAllFsmGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAmbientLight allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAmbientLightR Reflect(this SetAmbientLight instance)
    {
        return new SetAmbientLightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAngleToVelocity allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAngleToVelocityR Reflect(this SetAngleToVelocity instance)
    {
        return new SetAngleToVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAngularVelocity2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAngularVelocity2dR Reflect(this SetAngularVelocity2d instance)
    {
        return new SetAngularVelocity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimationSpeed allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimationSpeedR Reflect(this SetAnimationSpeed instance)
    {
        return new SetAnimationSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimationTime allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimationTimeR Reflect(this SetAnimationTime instance)
    {
        return new SetAnimationTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimationWeight allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimationWeightR Reflect(this SetAnimationWeight instance)
    {
        return new SetAnimationWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimator allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorR Reflect(this SetAnimator instance)
    {
        return new SetAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorApplyRootMotion allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorApplyRootMotionR Reflect(this SetAnimatorApplyRootMotion instance)
    {
        return new SetAnimatorApplyRootMotionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorBody allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorBodyR Reflect(this SetAnimatorBody instance)
    {
        return new SetAnimatorBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorBoolR Reflect(this SetAnimatorBool instance)
    {
        return new SetAnimatorBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorCullingMode allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorCullingModeR Reflect(this SetAnimatorCullingMode instance)
    {
        return new SetAnimatorCullingModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorFeetPivotActive allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorFeetPivotActiveR Reflect(this SetAnimatorFeetPivotActive instance)
    {
        return new SetAnimatorFeetPivotActiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorFloatR Reflect(this SetAnimatorFloat instance)
    {
        return new SetAnimatorFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorIKGoal allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorIKGoalR Reflect(this SetAnimatorIKGoal instance)
    {
        return new SetAnimatorIKGoalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorIntR Reflect(this SetAnimatorInt instance)
    {
        return new SetAnimatorIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorLayersAffectMassCenter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorLayersAffectMassCenterR Reflect(this SetAnimatorLayersAffectMassCenter instance)
    {
        return new SetAnimatorLayersAffectMassCenterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorLayerWeight allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorLayerWeightR Reflect(this SetAnimatorLayerWeight instance)
    {
        return new SetAnimatorLayerWeightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorLookAt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorLookAtR Reflect(this SetAnimatorLookAt instance)
    {
        return new SetAnimatorLookAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorPlayBackSpeed allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorPlayBackSpeedR Reflect(this SetAnimatorPlayBackSpeed instance)
    {
        return new SetAnimatorPlayBackSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorPlayBackTime allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorPlayBackTimeR Reflect(this SetAnimatorPlayBackTime instance)
    {
        return new SetAnimatorPlayBackTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorSpeed allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorSpeedR Reflect(this SetAnimatorSpeed instance)
    {
        return new SetAnimatorSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorStabilizeFeet allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorStabilizeFeetR Reflect(this SetAnimatorStabilizeFeet instance)
    {
        return new SetAnimatorStabilizeFeetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorTarget allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorTargetR Reflect(this SetAnimatorTarget instance)
    {
        return new SetAnimatorTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAnimatorTrigger allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAnimatorTriggerR Reflect(this SetAnimatorTrigger instance)
    {
        return new SetAnimatorTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioClip allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioClipR Reflect(this SetAudioClip instance)
    {
        return new SetAudioClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioLoop allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioLoopR Reflect(this SetAudioLoop instance)
    {
        return new SetAudioLoopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioPitch allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioPitchR Reflect(this SetAudioPitch instance)
    {
        return new SetAudioPitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioSource allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioSourceR Reflect(this SetAudioSource instance)
    {
        return new SetAudioSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetAudioVolume allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetAudioVolumeR Reflect(this SetAudioVolume instance)
    {
        return new SetAudioVolumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBackgroundColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBackgroundColorR Reflect(this SetBackgroundColor instance)
    {
        return new SetBackgroundColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBattleScene allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBattleSceneR Reflect(this SetBattleScene instance)
    {
        return new SetBattleSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBlurDepth allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBlurDepthR Reflect(this SetBlurDepth instance)
    {
        return new SetBlurDepthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoolProxy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoolProxyR Reflect(this SetBoolProxy instance)
    {
        return new SetBoolProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoolValue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoolValueR Reflect(this SetBoolValue instance)
    {
        return new SetBoolValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoxCollider2DSize allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoxCollider2DSizeR Reflect(this SetBoxCollider2DSize instance)
    {
        return new SetBoxCollider2DSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoxCollider2DSizeVector allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoxCollider2DSizeVectorR Reflect(this SetBoxCollider2DSizeVector instance)
    {
        return new SetBoxCollider2DSizeVectorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetBoxColliderTrigger allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetBoxColliderTriggerR Reflect(this SetBoxColliderTrigger instance)
    {
        return new SetBoxColliderTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCameraCullingMask allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCameraCullingMaskR Reflect(this SetCameraCullingMask instance)
    {
        return new SetCameraCullingMaskR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCameraFOV allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCameraFOVR Reflect(this SetCameraFOV instance)
    {
        return new SetCameraFOVR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCircleCollider allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCircleColliderR Reflect(this SetCircleCollider instance)
    {
        return new SetCircleColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCircleColliderRadius allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCircleColliderRadiusR Reflect(this SetCircleColliderRadius instance)
    {
        return new SetCircleColliderRadiusR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCollider allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetColliderR Reflect(this SetCollider instance)
    {
        return new SetColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCollider2dIsTrigger allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCollider2dIsTriggerR Reflect(this SetCollider2dIsTrigger instance)
    {
        return new SetCollider2dIsTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetColorRGBA allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetColorRGBAR Reflect(this SetColorRGBA instance)
    {
        return new SetColorRGBAR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetColorValue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetColorValueR Reflect(this SetColorValue instance)
    {
        return new SetColorValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetCorpseSpawnPoint allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetCorpseSpawnPointR Reflect(this SetCorpseSpawnPoint instance)
    {
        return new SetCorpseSpawnPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDamageHeroAmount allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDamageHeroAmountR Reflect(this SetDamageHeroAmount instance)
    {
        return new SetDamageHeroAmountR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDamageOverride allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDamageOverrideR Reflect(this SetDamageOverride instance)
    {
        return new SetDamageOverrideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDrag allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDragR Reflect(this SetDrag instance)
    {
        return new SetDragR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetDreamNailConvo allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetDreamNailConvoR Reflect(this SetDreamNailConvo instance)
    {
        return new SetDreamNailConvoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEffectOrigin allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEffectOriginR Reflect(this SetEffectOrigin instance)
    {
        return new SetEffectOriginR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEnumValue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEnumValueR Reflect(this SetEnumValue instance)
    {
        return new SetEnumValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEventData allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEventDataR Reflect(this SetEventData instance)
    {
        return new SetEventDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEventProperties allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEventPropertiesR Reflect(this SetEventProperties instance)
    {
        return new SetEventPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetEventTarget allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetEventTargetR Reflect(this SetEventTarget instance)
    {
        return new SetEventTargetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetExtrapolate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetExtrapolateR Reflect(this SetExtrapolate instance)
    {
        return new SetExtrapolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFlareStrength allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFlareStrengthR Reflect(this SetFlareStrength instance)
    {
        return new SetFlareStrengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatProxy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatProxyR Reflect(this SetFloatProxy instance)
    {
        return new SetFloatProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatToHighest allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatToHighestR Reflect(this SetFloatToHighest instance)
    {
        return new SetFloatToHighestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatToSmallest allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatToSmallestR Reflect(this SetFloatToSmallest instance)
    {
        return new SetFloatToSmallestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatValue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatValueR Reflect(this SetFloatValue instance)
    {
        return new SetFloatValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFloatValueV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFloatValueV2R Reflect(this SetFloatValueV2 instance)
    {
        return new SetFloatValueV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFogColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFogColorR Reflect(this SetFogColor instance)
    {
        return new SetFogColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFogDensity allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFogDensityR Reflect(this SetFogDensity instance)
    {
        return new SetFogDensityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmArray allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmArrayR Reflect(this SetFsmArray instance)
    {
        return new SetFsmArrayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmArrayItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmArrayItemR Reflect(this SetFsmArrayItem instance)
    {
        return new SetFsmArrayItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmBool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmBoolR Reflect(this SetFsmBool instance)
    {
        return new SetFsmBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmColorR Reflect(this SetFsmColor instance)
    {
        return new SetFsmColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmEnum allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmEnumR Reflect(this SetFsmEnum instance)
    {
        return new SetFsmEnumR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmFloat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmFloatR Reflect(this SetFsmFloat instance)
    {
        return new SetFsmFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmGameObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmGameObjectR Reflect(this SetFsmGameObject instance)
    {
        return new SetFsmGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmInt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmIntR Reflect(this SetFsmInt instance)
    {
        return new SetFsmIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmMaterial allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmMaterialR Reflect(this SetFsmMaterial instance)
    {
        return new SetFsmMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmObjectR Reflect(this SetFsmObject instance)
    {
        return new SetFsmObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmQuaternion allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmQuaternionR Reflect(this SetFsmQuaternion instance)
    {
        return new SetFsmQuaternionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmRect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmRectR Reflect(this SetFsmRect instance)
    {
        return new SetFsmRectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmString allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmStringR Reflect(this SetFsmString instance)
    {
        return new SetFsmStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmStringReturn allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmStringReturnR Reflect(this SetFsmStringReturn instance)
    {
        return new SetFsmStringReturnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmTexture allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmTextureR Reflect(this SetFsmTexture instance)
    {
        return new SetFsmTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmVariable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmVariableR Reflect(this SetFsmVariable instance)
    {
        return new SetFsmVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmVector2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmVector2R Reflect(this SetFsmVector2 instance)
    {
        return new SetFsmVector2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetFsmVector3 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetFsmVector3R Reflect(this SetFsmVector3 instance)
    {
        return new SetFsmVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGameObject allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGameObjectR Reflect(this SetGameObject instance)
    {
        return new SetGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGameObjectSelf allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGameObjectSelfR Reflect(this SetGameObjectSelf instance)
    {
        return new SetGameObjectSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGameVolume allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGameVolumeR Reflect(this SetGameVolume instance)
    {
        return new SetGameVolumeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGeoDrop allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGeoDropR Reflect(this SetGeoDrop instance)
    {
        return new SetGeoDropR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGravity allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGravityR Reflect(this SetGravity instance)
    {
        return new SetGravityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGravity2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGravity2dR Reflect(this SetGravity2d instance)
    {
        return new SetGravity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGravity2dScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGravity2dScaleR Reflect(this SetGravity2dScale instance)
    {
        return new SetGravity2dScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIAlpha allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIAlphaR Reflect(this SetGUIAlpha instance)
    {
        return new SetGUIAlphaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIBackgroundColor allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIBackgroundColorR Reflect(this SetGUIBackgroundColor instance)
    {
        return new SetGUIBackgroundColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIColorR Reflect(this SetGUIColor instance)
    {
        return new SetGUIColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIContentColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIContentColorR Reflect(this SetGUIContentColor instance)
    {
        return new SetGUIContentColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUIDepth allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUIDepthR Reflect(this SetGUIDepth instance)
    {
        return new SetGUIDepthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetGUISkin allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetGUISkinR Reflect(this SetGUISkin instance)
    {
        return new SetGUISkinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHaloStrength allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHaloStrengthR Reflect(this SetHaloStrength instance)
    {
        return new SetHaloStrengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHealthManagerReset allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHealthManagerResetR Reflect(this SetHealthManagerReset instance)
    {
        return new SetHealthManagerResetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHingeJoint2dProperties allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHingeJoint2dPropertiesR Reflect(this SetHingeJoint2dProperties instance)
    {
        return new SetHingeJoint2dPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetHP allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static SetHPR Reflect(this SetHP instance)
    {
        return new SetHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetInterpolate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetInterpolateR Reflect(this SetInterpolate instance)
    {
        return new SetInterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetInterpolateNone allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetInterpolateNoneR Reflect(this SetInterpolateNone instance)
    {
        return new SetInterpolateNoneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntFromFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntFromFloatR Reflect(this SetIntFromFloat instance)
    {
        return new SetIntFromFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntProxy allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntProxyR Reflect(this SetIntProxy instance)
    {
        return new SetIntProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntToSmallest allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntToSmallestR Reflect(this SetIntToSmallest instance)
    {
        return new SetIntToSmallestR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIntValue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIntValueR Reflect(this SetIntValue instance)
    {
        return new SetIntValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetInvincible allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetInvincibleR Reflect(this SetInvincible instance)
    {
        return new SetInvincibleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsDead allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsDeadR Reflect(this SetIsDead instance)
    {
        return new SetIsDeadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsFixedAngle2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsFixedAngle2dR Reflect(this SetIsFixedAngle2d instance)
    {
        return new SetIsFixedAngle2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsKinematic allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsKinematicR Reflect(this SetIsKinematic instance)
    {
        return new SetIsKinematicR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetIsKinematic2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetIsKinematic2dR Reflect(this SetIsKinematic2d instance)
    {
        return new SetIsKinematic2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetJointConnectedBody allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetJointConnectedBodyR Reflect(this SetJointConnectedBody instance)
    {
        return new SetJointConnectedBodyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLayer allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLayerR Reflect(this SetLayer instance)
    {
        return new SetLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightColor allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightColorR Reflect(this SetLightColor instance)
    {
        return new SetLightColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightCookie allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightCookieR Reflect(this SetLightCookie instance)
    {
        return new SetLightCookieR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightFlare allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightFlareR Reflect(this SetLightFlare instance)
    {
        return new SetLightFlareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightIntensity allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightIntensityR Reflect(this SetLightIntensity instance)
    {
        return new SetLightIntensityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightRange allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightRangeR Reflect(this SetLightRange instance)
    {
        return new SetLightRangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightSpotAngle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightSpotAngleR Reflect(this SetLightSpotAngle instance)
    {
        return new SetLightSpotAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetLightType allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetLightTypeR Reflect(this SetLightType instance)
    {
        return new SetLightTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMainCamera allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMainCameraR Reflect(this SetMainCamera instance)
    {
        return new SetMainCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMass allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMassR Reflect(this SetMass instance)
    {
        return new SetMassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMass2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMass2dR Reflect(this SetMass2d instance)
    {
        return new SetMass2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterial allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialR Reflect(this SetMaterial instance)
    {
        return new SetMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterialColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialColorR Reflect(this SetMaterialColor instance)
    {
        return new SetMaterialColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterialFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialFloatR Reflect(this SetMaterialFloat instance)
    {
        return new SetMaterialFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMaterialTexture allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMaterialTextureR Reflect(this SetMaterialTexture instance)
    {
        return new SetMaterialTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMenuButtonIconAction allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMenuButtonIconActionR Reflect(this SetMenuButtonIconAction instance)
    {
        return new SetMenuButtonIconActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMeshRenderer allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMeshRendererR Reflect(this SetMeshRenderer instance)
    {
        return new SetMeshRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMeshRendererChildren allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMeshRendererChildrenR Reflect(this SetMeshRendererChildren instance)
    {
        return new SetMeshRendererChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetMouseCursor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetMouseCursorR Reflect(this SetMouseCursor instance)
    {
        return new SetMouseCursorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetName allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetNameR Reflect(this SetName instance)
    {
        return new SetNameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetObjectValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetObjectValueR Reflect(this SetObjectValue instance)
    {
        return new SetObjectValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParentR Reflect(this SetParent instance)
    {
        return new SetParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleEmission allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleEmissionR Reflect(this SetParticleEmission instance)
    {
        return new SetParticleEmissionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleEmissionRate allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleEmissionRateR Reflect(this SetParticleEmissionRate instance)
    {
        return new SetParticleEmissionRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleEmissionSpeed allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleEmissionSpeedR Reflect(this SetParticleEmissionSpeed instance)
    {
        return new SetParticleEmissionSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetParticleScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetParticleScaleR Reflect(this SetParticleScale instance)
    {
        return new SetParticleScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataBool allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataBoolR Reflect(this SetPlayerDataBool instance)
    {
        return new SetPlayerDataBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataFloat allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataFloatR Reflect(this SetPlayerDataFloat instance)
    {
        return new SetPlayerDataFloatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataInt allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataIntR Reflect(this SetPlayerDataInt instance)
    {
        return new SetPlayerDataIntR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataString allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataStringR Reflect(this SetPlayerDataString instance)
    {
        return new SetPlayerDataStringR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPlayerDataVector3 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPlayerDataVector3R Reflect(this SetPlayerDataVector3 instance)
    {
        return new SetPlayerDataVector3R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPolygonCollider allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPolygonColliderR Reflect(this SetPolygonCollider instance)
    {
        return new SetPolygonColliderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPosIfPlayerdataBool allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPosIfPlayerdataBoolR Reflect(this SetPosIfPlayerdataBool instance)
    {
        return new SetPosIfPlayerdataBoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPosition allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPositionR Reflect(this SetPosition instance)
    {
        return new SetPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetPositionToObject allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPositionToObjectR Reflect(this SetPositionToObject instance)
    {
        return new SetPositionToObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetProperty allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetPropertyR Reflect(this SetProperty instance)
    {
        return new SetPropertyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRandomMaterial allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRandomMaterialR Reflect(this SetRandomMaterial instance)
    {
        return new SetRandomMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRandomRotation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRandomRotationR Reflect(this SetRandomRotation instance)
    {
        return new SetRandomRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRandomSpriteId allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRandomSpriteIdR Reflect(this SetRandomSpriteId instance)
    {
        return new SetRandomSpriteIdR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRecoilFreeze allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRecoilFreezeR Reflect(this SetRecoilFreeze instance)
    {
        return new SetRecoilFreezeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRecoilSpeed allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRecoilSpeedR Reflect(this SetRecoilSpeed instance)
    {
        return new SetRecoilSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRectFields allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRectFieldsR Reflect(this SetRectFields instance)
    {
        return new SetRectFieldsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRectValue allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRectValueR Reflect(this SetRectValue instance)
    {
        return new SetRectValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRespawningHero allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRespawningHeroR Reflect(this SetRespawningHero instance)
    {
        return new SetRespawningHeroR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRigidbodySimulated2D allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRigidbodySimulated2DR Reflect(this SetRigidbodySimulated2D instance)
    {
        return new SetRigidbodySimulated2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetRotation allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetRotationR Reflect(this SetRotation instance)
    {
        return new SetRotationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetScale allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetScaleR Reflect(this SetScale instance)
    {
        return new SetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSceneAudio allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSceneAudioR Reflect(this SetSceneAudio instance)
    {
        return new SetSceneAudioR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSendKilledToObject allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSendKilledToObjectR Reflect(this SetSendKilledToObject instance)
    {
        return new SetSendKilledToObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetShadowStrength allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetShadowStrengthR Reflect(this SetShadowStrength instance)
    {
        return new SetShadowStrengthR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSkybox allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSkyboxR Reflect(this SetSkybox instance)
    {
        return new SetSkyboxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpawnJarContents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpawnJarContentsR Reflect(this SetSpawnJarContents instance)
    {
        return new SetSpawnJarContentsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpecialDeath allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpecialDeathR Reflect(this SetSpecialDeath instance)
    {
        return new SetSpecialDeathR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRenderer allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererR Reflect(this SetSpriteRenderer instance)
    {
        return new SetSpriteRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRendererByColor allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererByColorR Reflect(this SetSpriteRendererByColor instance)
    {
        return new SetSpriteRendererByColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRendererOrder allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererOrderR Reflect(this SetSpriteRendererOrder instance)
    {
        return new SetSpriteRendererOrderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetSpriteRendererSprite allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetSpriteRendererSpriteR Reflect(this SetSpriteRendererSprite instance)
    {
        return new SetSpriteRendererSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetStaticVariable allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetStaticVariableR Reflect(this SetStaticVariable instance)
    {
        return new SetStaticVariableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetStringProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetStringProxyR Reflect(this SetStringProxy instance)
    {
        return new SetStringProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetStringValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetStringValueR Reflect(this SetStringValue instance)
    {
        return new SetStringValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTag allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTagR Reflect(this SetTag instance)
    {
        return new SetTagR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTagsOnChildren allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTagsOnChildrenR Reflect(this SetTagsOnChildren instance)
    {
        return new SetTagsOnChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProAlignment allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProAlignmentR Reflect(this SetTextMeshProAlignment instance)
    {
        return new SetTextMeshProAlignmentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProColorR Reflect(this SetTextMeshProColor instance)
    {
        return new SetTextMeshProColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProGameText allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProGameTextR Reflect(this SetTextMeshProGameText instance)
    {
        return new SetTextMeshProGameTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshProText allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshProTextR Reflect(this SetTextMeshProText instance)
    {
        return new SetTextMeshProTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextMeshText allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextMeshTextR Reflect(this SetTextMeshText instance)
    {
        return new SetTextMeshTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextureOffset allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextureOffsetR Reflect(this SetTextureOffset instance)
    {
        return new SetTextureOffsetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTextureScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTextureScaleR Reflect(this SetTextureScale instance)
    {
        return new SetTextureScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTrailRenderer allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTrailRendererR Reflect(this SetTrailRenderer instance)
    {
        return new SetTrailRendererR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetTransformParent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetTransformParentR Reflect(this SetTransformParent instance)
    {
        return new SetTransformParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVariableProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVariableProxyR Reflect(this SetVariableProxy instance)
    {
        return new SetVariableProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector2XY allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector2XYR Reflect(this SetVector2XY instance)
    {
        return new SetVector2XYR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector3Proxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector3ProxyR Reflect(this SetVector3Proxy instance)
    {
        return new SetVector3ProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector3Value allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector3ValueR Reflect(this SetVector3Value instance)
    {
        return new SetVector3ValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVector3XYZ allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVector3XYZR Reflect(this SetVector3XYZ instance)
    {
        return new SetVector3XYZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocity allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocityR Reflect(this SetVelocity instance)
    {
        return new SetVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocity2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocity2dR Reflect(this SetVelocity2d instance)
    {
        return new SetVelocity2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocity2dIfFalse allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocity2dIfFalseR Reflect(this SetVelocity2dIfFalse instance)
    {
        return new SetVelocity2dIfFalseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVelocityAsAngle allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVelocityAsAngleR Reflect(this SetVelocityAsAngle instance)
    {
        return new SetVelocityAsAngleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVersionNumber allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVersionNumberR Reflect(this SetVersionNumber instance)
    {
        return new SetVersionNumberR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetVisibility allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetVisibilityR Reflect(this SetVisibility instance)
    {
        return new SetVisibilityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWalkerFacing allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWalkerFacingR Reflect(this SetWalkerFacing instance)
    {
        return new SetWalkerFacingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWalkerSpeed allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWalkerSpeedR Reflect(this SetWalkerSpeed instance)
    {
        return new SetWalkerSpeedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWalkerStartInactive allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWalkerStartInactiveR Reflect(this SetWalkerStartInactive instance)
    {
        return new SetWalkerStartInactiveR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetWheelJoint2dProperties allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetWheelJoint2dPropertiesR Reflect(this SetWheelJoint2dProperties instance)
    {
        return new SetWheelJoint2dPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetZ allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static SetZR Reflect(this SetZ instance)
    {
        return new SetZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SetZRandom allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SetZRandomR Reflect(this SetZRandom instance)
    {
        return new SetZRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShadowGateColliderControl allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShadowGateColliderControlR Reflect(this ShadowGateColliderControl instance)
    {
        return new ShadowGateColliderControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShakeAllGrass allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShakeAllGrassR Reflect(this ShakeAllGrass instance)
    {
        return new ShakeAllGrassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShakePosition allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShakePositionR Reflect(this ShakePosition instance)
    {
        return new ShakePositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShakePositionV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShakePositionV2R Reflect(this ShakePositionV2 instance)
    {
        return new ShakePositionV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShineAnimSequence allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShineAnimSequenceR Reflect(this ShineAnimSequence instance)
    {
        return new ShineAnimSequenceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShopItemStats allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShopItemStatsR Reflect(this ShopItemStats instance)
    {
        return new ShopItemStatsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShopMenuStock allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShopMenuStockR Reflect(this ShopMenuStock instance)
    {
        return new ShopMenuStockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShouldSerializeContractResolver
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShouldSerializeContractResolverR Reflect(this ShouldSerializeContractResolver instance)
    {
        return new ShouldSerializeContractResolverR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossChallengeUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossChallengeUIR Reflect(this ShowBossChallengeUI instance)
    {
        return new ShowBossChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossDoorChallengeUI allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossDoorChallengeUIR Reflect(this ShowBossDoorChallengeUI instance)
    {
        return new ShowBossDoorChallengeUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossDoorLockedUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossDoorLockedUIR Reflect(this ShowBossDoorLockedUI instance)
    {
        return new ShowBossDoorLockedUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowBossSummaryUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowBossSummaryUIR Reflect(this ShowBossSummaryUI instance)
    {
        return new ShowBossSummaryUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowGodfinderIcon allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowGodfinderIconR Reflect(this ShowGodfinderIcon instance)
    {
        return new ShowGodfinderIconR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowGodfinderIconQueued allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowGodfinderIconQueuedR Reflect(this ShowGodfinderIconQueued instance)
    {
        return new ShowGodfinderIconQueuedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowOptions allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowOptionsR Reflect(this ShowOptions instance)
    {
        return new ShowOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ShowPromptMarker allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ShowPromptMarkerR Reflect(this ShowPromptMarker instance)
    {
        return new ShowPromptMarkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleFadeOut allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleFadeOutR Reflect(this SimpleFadeOut instance)
    {
        return new SimpleFadeOutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleLogger allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleLoggerR Reflect(this SimpleLogger instance)
    {
        return new SimpleLoggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleRock allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleRockR Reflect(this SimpleRock instance)
    {
        return new SimpleRockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SimpleSpriteFade allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SimpleSpriteFadeR Reflect(this SimpleSpriteFade instance)
    {
        return new SimpleSpriteFadeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SingleContentLayout allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SingleContentLayoutR Reflect(this SingleContentLayout instance)
    {
        return new SingleContentLayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SlashHitHandler allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SlashHitHandlerR Reflect(this SlashHitHandler instance)
    {
        return new SlashHitHandlerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Sleep allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static SleepR Reflect(this Sleep instance)
    {
        return new SleepR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Sleep2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Sleep2dR Reflect(this Sleep2d instance)
    {
        return new Sleep2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SlopePlat allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SlopePlatR Reflect(this SlopePlat instance)
    {
        return new SlopePlatR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothFlyTo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothFlyToR Reflect(this SmoothFlyTo instance)
    {
        return new SmoothFlyToR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothFollowAction allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothFollowActionR Reflect(this SmoothFollowAction instance)
    {
        return new SmoothFollowActionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothFollowTarget2D allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothFollowTarget2DR Reflect(this SmoothFollowTarget2D instance)
    {
        return new SmoothFollowTarget2DR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothLookAt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothLookAtR Reflect(this SmoothLookAt instance)
    {
        return new SmoothLookAtR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothLookAt2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothLookAt2dR Reflect(this SmoothLookAt2d instance)
    {
        return new SmoothLookAt2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SmoothLookAtDirection allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SmoothLookAtDirectionR Reflect(this SmoothLookAtDirection instance)
    {
        return new SmoothLookAtDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SnapshotOnActivation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SnapshotOnActivationR Reflect(this SnapshotOnActivation instance)
    {
        return new SnapshotOnActivationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SnapToGround allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SnapToGroundR Reflect(this SnapToGround instance)
    {
        return new SnapToGroundR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SoftLandEffect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SoftLandEffectR Reflect(this SoftLandEffect instance)
    {
        return new SoftLandEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SoftMaskScript allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SoftMaskScriptR Reflect(this SoftMaskScript instance)
    {
        return new SoftMaskScriptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SoulOrb allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SoulOrbR Reflect(this SoulOrb instance)
    {
        return new SoulOrbR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpatterHoney allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpatterHoneyR Reflect(this SpatterHoney instance)
    {
        return new SpatterHoneyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpatterOrange allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpatterOrangeR Reflect(this SpatterOrange instance)
    {
        return new SpatterOrangeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnableAudioSource allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnableAudioSourceR Reflect(this SpawnableAudioSource instance)
    {
        return new SpawnableAudioSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnBlood allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnBloodR Reflect(this SpawnBlood instance)
    {
        return new SpawnBloodR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnBloodTime allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnBloodTimeR Reflect(this SpawnBloodTime instance)
    {
        return new SpawnBloodTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnFromPool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnFromPoolR Reflect(this SpawnFromPool instance)
    {
        return new SpawnFromPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnFromPoolV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnFromPoolV2R Reflect(this SpawnFromPoolV2 instance)
    {
        return new SpawnFromPoolV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnJarControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnJarControlR Reflect(this SpawnJarControl instance)
    {
        return new SpawnJarControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnObjectFromGlobalPool allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnObjectFromGlobalPoolR Reflect(this SpawnObjectFromGlobalPool instance)
    {
        return new SpawnObjectFromGlobalPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnObjectFromGlobalPoolOverTime
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnObjectFromGlobalPoolOverTimeR Reflect(this SpawnObjectFromGlobalPoolOverTime instance)
    {
        return new SpawnObjectFromGlobalPoolOverTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnObjectFromGlobalPoolOverTimeV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnObjectFromGlobalPoolOverTimeV2R Reflect(this SpawnObjectFromGlobalPoolOverTimeV2 instance)
    {
        return new SpawnObjectFromGlobalPoolOverTimeV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsR Reflect(this SpawnRandomObjects instance)
    {
        return new SpawnRandomObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsOverTime allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsOverTimeR Reflect(this SpawnRandomObjectsOverTime instance)
    {
        return new SpawnRandomObjectsOverTimeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsOverTimeV2
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsOverTimeV2R Reflect(this SpawnRandomObjectsOverTimeV2 instance)
    {
        return new SpawnRandomObjectsOverTimeV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsV2R Reflect(this SpawnRandomObjectsV2 instance)
    {
        return new SpawnRandomObjectsV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnRandomObjectsVelocity allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnRandomObjectsVelocityR Reflect(this SpawnRandomObjectsVelocity instance)
    {
        return new SpawnRandomObjectsVelocityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpawnStagMenu allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpawnStagMenuR Reflect(this SpawnStagMenu instance)
    {
        return new SpawnStagMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpeedlinkStrikeMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpeedlinkStrikeMacUnityProfileR Reflect(this SpeedlinkStrikeMacUnityProfile instance)
    {
        return new SpeedlinkStrikeMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpeedlinkStrikeWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpeedlinkStrikeWindowsUnityProfileR Reflect(this SpeedlinkStrikeWindowsUnityProfile instance)
    {
        return new SpeedlinkStrikeWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpellFluke allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpellFlukeR Reflect(this SpellFluke instance)
    {
        return new SpellFlukeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpellGetOrb allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpellGetOrbR Reflect(this SpellGetOrb instance)
    {
        return new SpellGetOrbR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpinSelf allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpinSelfR Reflect(this SpinSelf instance)
    {
        return new SpinSelfR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpinSelfSimple allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpinSelfSimpleR Reflect(this SpinSelfSimple instance)
    {
        return new SpinSelfSimpleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SplashAnimator allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SplashAnimatorR Reflect(this SplashAnimator instance)
    {
        return new SplashAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SplitTextToArrayList allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SplitTextToArrayListR Reflect(this SplitTextToArrayList instance)
    {
        return new SplitTextToArrayListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteChannel allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteChannelR Reflect(this SpriteChannel instance)
    {
        return new SpriteChannelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteChunk allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteChunkR Reflect(this SpriteChunk instance)
    {
        return new SpriteChunkR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteFadeMaterial allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteFadeMaterialR Reflect(this SpriteFadeMaterial instance)
    {
        return new SpriteFadeMaterialR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteFadePulse allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteFadePulseR Reflect(this SpriteFadePulse instance)
    {
        return new SpriteFadePulseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteFlash allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteFlashR Reflect(this SpriteFlash instance)
    {
        return new SpriteFlashR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SpriteTweenColorNeutral allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SpriteTweenColorNeutralR Reflect(this SpriteTweenColorNeutral instance)
    {
        return new SpriteTweenColorNeutralR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StagTravel allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StagTravelR Reflect(this StagTravel instance)
    {
        return new StagTravelR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StalactiteControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StalactiteControlR Reflect(this StalactiteControl instance)
    {
        return new StalactiteControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StandaloneLoadingSpinner allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StandaloneLoadingSpinnerR Reflect(this StandaloneLoadingSpinner instance)
    {
        return new StandaloneLoadingSpinnerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartAudioPlayerAfterHeroInPosition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartAudioPlayerAfterHeroInPositionR Reflect(this StartAudioPlayerAfterHeroInPosition instance)
    {
        return new StartAudioPlayerAfterHeroInPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartCoroutine allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartCoroutineR Reflect(this StartCoroutine instance)
    {
        return new StartCoroutineR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartGameEventTrigger allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartGameEventTriggerR Reflect(this StartGameEventTrigger instance)
    {
        return new StartGameEventTriggerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartLocationServiceUpdates allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartLocationServiceUpdatesR Reflect(this StartLocationServiceUpdates instance)
    {
        return new StartLocationServiceUpdatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartManagerR Reflect(this StartManager instance)
    {
        return new StartManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StartWalker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StartWalkerR Reflect(this StartWalker instance)
    {
        return new StartWalkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteamManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteamManagerR Reflect(this SteamManager instance)
    {
        return new SteamManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteamOnlineSubsystem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteamOnlineSubsystemR Reflect(this SteamOnlineSubsystem instance)
    {
        return new SteamOnlineSubsystemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteamWindowsNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteamWindowsNativeProfileR Reflect(this SteamWindowsNativeProfile instance)
    {
        return new SteamWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeAndroidUnityProfileR Reflect(this SteelSeriesFreeAndroidUnityProfile instance)
    {
        return new SteelSeriesFreeAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeLinuxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeLinuxUnityProfileR Reflect(this SteelSeriesFreeLinuxUnityProfile instance)
    {
        return new SteelSeriesFreeLinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeMacUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeMacUnityProfileR Reflect(this SteelSeriesFreeMacUnityProfile instance)
    {
        return new SteelSeriesFreeMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelSeriesFreeWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelSeriesFreeWindowsUnityProfileR Reflect(this SteelSeriesFreeWindowsUnityProfile instance)
    {
        return new SteelSeriesFreeWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteelseriesNimbusMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteelseriesNimbusMacNativeProfileR Reflect(this SteelseriesNimbusMacNativeProfile instance)
    {
        return new SteelseriesNimbusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SteelseriesNimbusPlusMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static SteelseriesNimbusPlusMacNativeProfileR Reflect(this SteelseriesNimbusPlusMacNativeProfile instance)
    {
        return new SteelseriesNimbusPlusMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SteelSeriesStratusXLAndroidUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static SteelSeriesStratusXLAndroidUnityProfileR Reflect(
        this SteelSeriesStratusXLAndroidUnityProfile instance)
    {
        return new SteelSeriesStratusXLAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     SteelSeriesStratusXLWindowsUnityProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static SteelSeriesStratusXLWindowsUnityProfileR Reflect(
        this SteelSeriesStratusXLWindowsUnityProfile instance)
    {
        return new SteelSeriesStratusXLWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SteepSlope allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SteepSlopeR Reflect(this SteepSlope instance)
    {
        return new SteepSlopeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopAnimation allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopAnimationR Reflect(this StopAnimation instance)
    {
        return new StopAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopAnimatorsAtPoint allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopAnimatorsAtPointR Reflect(this StopAnimatorsAtPoint instance)
    {
        return new StopAnimatorsAtPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopLiftChain allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopLiftChainR Reflect(this StopLiftChain instance)
    {
        return new StopLiftChainR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopLocationServiceUpdates allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopLocationServiceUpdatesR Reflect(this StopLocationServiceUpdates instance)
    {
        return new StopLocationServiceUpdatesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopParticleEmitter allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopParticleEmitterR Reflect(this StopParticleEmitter instance)
    {
        return new StopParticleEmitterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopParticleEmittersInChildren
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopParticleEmittersInChildrenR Reflect(this StopParticleEmittersInChildren instance)
    {
        return new StopParticleEmittersInChildrenR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopVibration allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopVibrationR Reflect(this StopVibration instance)
    {
        return new StopVibrationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StopWalker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StopWalkerR Reflect(this StopWalker instance)
    {
        return new StopWalkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringChanged allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringChangedR Reflect(this StringChanged instance)
    {
        return new StringChangedR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringCompare allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringCompareR Reflect(this StringCompare instance)
    {
        return new StringCompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringContains allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringContainsR Reflect(this StringContains instance)
    {
        return new StringContainsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringEncrypt allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringEncryptR Reflect(this StringEncrypt instance)
    {
        return new StringEncryptR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringJoin allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringJoinR Reflect(this StringJoin instance)
    {
        return new StringJoinR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringReplace allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringReplaceR Reflect(this StringReplace instance)
    {
        return new StringReplaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringSplit allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringSplitR Reflect(this StringSplit instance)
    {
        return new StringSplitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of StringSwitch allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static StringSwitchR Reflect(this StringSwitch instance)
    {
        return new StringSwitchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SubtractHP allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SubtractHPR Reflect(this SubtractHP instance)
    {
        return new SubtractHPR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwipeGestureEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwipeGestureEventR Reflect(this SwipeGestureEvent instance)
    {
        return new SwipeGestureEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwitchOnPlatform allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwitchOnPlatformR Reflect(this SwitchOnPlatform instance)
    {
        return new SwitchOnPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwitchSimpleInputDevice allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwitchSimpleInputDeviceR Reflect(this SwitchSimpleInputDevice instance)
    {
        return new SwitchSimpleInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of SwitchSimpleInputDeviceManager
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static SwitchSimpleInputDeviceManagerR Reflect(this SwitchSimpleInputDeviceManager instance)
    {
        return new SwitchSimpleInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeDamage allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeDamageR Reflect(this TakeDamage instance)
    {
        return new TakeDamageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeDamageProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeDamageProxyR Reflect(this TakeDamageProxy instance)
    {
        return new TakeDamageProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeHealthProxy allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeHealthProxyR Reflect(this TakeHealthProxy instance)
    {
        return new TakeHealthProxyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TakeScreenshot allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TakeScreenshotR Reflect(this TakeScreenshot instance)
    {
        return new TakeScreenshotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TestInputManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TestInputManagerR Reflect(this TestInputManager instance)
    {
        return new TestInputManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextContainer allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextContainerR Reflect(this TextContainer instance)
    {
        return new TextContainerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshOrderingLayer allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshOrderingLayerR Reflect(this TextMeshOrderingLayer instance)
    {
        return new TextMeshOrderingLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshPro allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshProR Reflect(this TextMeshPro instance)
    {
        return new TextMeshProR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshProUGUI allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshProUGUIR Reflect(this TextMeshProUGUI instance)
    {
        return new TextMeshProUGUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TextMeshSharpener allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TextMeshSharpenerR Reflect(this TextMeshSharpener instance)
    {
        return new TextMeshSharpenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Throbber allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrobberR Reflect(this Throbber instance)
    {
        return new ThrobberR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustMasterFerrari430RacingWheelMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static ThrustMasterFerrari430RacingWheelMacNativeProfileR Reflect(this
        ThrustMasterFerrari430RacingWheelMacNativeProfile instance)
    {
        return new ThrustMasterFerrari430RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustmasterFerrari458RacingWheelMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static ThrustmasterFerrari458RacingWheelMacNativeProfileR Reflect(this
        ThrustmasterFerrari458RacingWheelMacNativeProfile instance)
    {
        return new ThrustmasterFerrari458RacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile allowing you to easily get/set fields and call methods
    ///     without dealing with reflection.
    /// </summary>
    public static ThrustMasterFerrari458SpiderRacingWheelMacNativeProfileR Reflect(this
        ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile instance)
    {
        return new ThrustMasterFerrari458SpiderRacingWheelMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     ThrustmasterGPXControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static ThrustmasterGPXControllerMacNativeProfileR
        Reflect(this ThrustmasterGPXControllerMacNativeProfile instance)
    {
        return new ThrustmasterGPXControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ThrustmasterTMXMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustmasterTMXMacNativeProfileR Reflect(this ThrustmasterTMXMacNativeProfile instance)
    {
        return new ThrustmasterTMXMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ThrustmasterTXGIPMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ThrustmasterTXGIPMacNativeProfileR Reflect(this ThrustmasterTXGIPMacNativeProfile instance)
    {
        return new ThrustmasterTXGIPMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TileInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TileInfoR Reflect(this TileInfo instance)
    {
        return new TileInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TimeLimitCheck allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TimeLimitCheckR Reflect(this TimeLimitCheck instance)
    {
        return new TimeLimitCheckR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TimeLimitSet allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TimeLimitSetR Reflect(this TimeLimitSet instance)
    {
        return new TimeLimitSetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TimeScaleIndependentUpdate allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TimeScaleIndependentUpdateR Reflect(this TimeScaleIndependentUpdate instance)
    {
        return new TimeScaleIndependentUpdateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TinkEffect allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TinkEffectR Reflect(this TinkEffect instance)
    {
        return new TinkEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TitleLogo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TitleLogoR Reflect(this TitleLogo instance)
    {
        return new TitleLogoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dAnimatedSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dAnimatedSpriteR Reflect(this tk2dAnimatedSprite instance)
    {
        return new tk2dAnimatedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dAssetPlatform allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dAssetPlatformR Reflect(this tk2dAssetPlatform instance)
    {
        return new tk2dAssetPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dBatchedSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dBatchedSpriteR Reflect(this tk2dBatchedSprite instance)
    {
        return new tk2dBatchedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dButton allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dButtonR Reflect(this tk2dButton instance)
    {
        return new tk2dButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCamera allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraR Reflect(this tk2dCamera instance)
    {
        return new tk2dCameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCameraAnchor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraAnchorR Reflect(this tk2dCameraAnchor instance)
    {
        return new tk2dCameraAnchorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCameraResolutionOverride
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraResolutionOverrideR Reflect(this tk2dCameraResolutionOverride instance)
    {
        return new tk2dCameraResolutionOverrideR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCameraSettings allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCameraSettingsR Reflect(this tk2dCameraSettings instance)
    {
        return new tk2dCameraSettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dClippedSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dClippedSpriteR Reflect(this tk2dClippedSprite instance)
    {
        return new tk2dClippedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dCollider2DData allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dCollider2DDataR Reflect(this tk2dCollider2DData instance)
    {
        return new tk2dCollider2DDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dEditorSpriteDataUnloader
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dEditorSpriteDataUnloaderR Reflect(this tk2dEditorSpriteDataUnloader instance)
    {
        return new tk2dEditorSpriteDataUnloaderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFont allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontR Reflect(this tk2dFont instance)
    {
        return new tk2dFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFontChar allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontCharR Reflect(this tk2dFontChar instance)
    {
        return new tk2dFontCharR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFontData allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontDataR Reflect(this tk2dFontData instance)
    {
        return new tk2dFontDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dFontKerning allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dFontKerningR Reflect(this tk2dFontKerning instance)
    {
        return new tk2dFontKerningR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dIsPlaying allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dIsPlayingR Reflect(this Tk2dIsPlaying instance)
    {
        return new Tk2dIsPlayingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dLinkedSpriteCollection allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dLinkedSpriteCollectionR Reflect(this tk2dLinkedSpriteCollection instance)
    {
        return new tk2dLinkedSpriteCollectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPauseAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPauseAnimationR Reflect(this Tk2dPauseAnimation instance)
    {
        return new Tk2dPauseAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dPixelPerfectHelper allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dPixelPerfectHelperR Reflect(this tk2dPixelPerfectHelper instance)
    {
        return new tk2dPixelPerfectHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayAnimationR Reflect(this Tk2dPlayAnimation instance)
    {
        return new Tk2dPlayAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayAnimationV2 allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayAnimationV2R Reflect(this Tk2dPlayAnimationV2 instance)
    {
        return new Tk2dPlayAnimationV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayAnimationWithEvents allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayAnimationWithEventsR Reflect(this Tk2dPlayAnimationWithEvents instance)
    {
        return new Tk2dPlayAnimationWithEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dPlayFrame allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dPlayFrameR Reflect(this Tk2dPlayFrame instance)
    {
        return new Tk2dPlayFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dResource allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dResourceR Reflect(this tk2dResource instance)
    {
        return new tk2dResourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dResourceTocEntry allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dResourceTocEntryR Reflect(this tk2dResourceTocEntry instance)
    {
        return new tk2dResourceTocEntryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dResumeAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dResumeAnimationR Reflect(this Tk2dResumeAnimation instance)
    {
        return new Tk2dResumeAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSetAnimationFrameRate allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSetAnimationFrameRateR Reflect(this Tk2dSetAnimationFrameRate instance)
    {
        return new Tk2dSetAnimationFrameRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSlicedSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSlicedSpriteR Reflect(this tk2dSlicedSprite instance)
    {
        return new tk2dSlicedSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSprite allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteR Reflect(this tk2dSprite instance)
    {
        return new tk2dSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimationR Reflect(this tk2dSpriteAnimation instance)
    {
        return new tk2dSpriteAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimationClip allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimationClipR Reflect(this tk2dSpriteAnimationClip instance)
    {
        return new tk2dSpriteAnimationClipR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimationFrame allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimationFrameR Reflect(this tk2dSpriteAnimationFrame instance)
    {
        return new tk2dSpriteAnimationFrameR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAnimator allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAnimatorR Reflect(this tk2dSpriteAnimator instance)
    {
        return new tk2dSpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteAttachPoint allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteAttachPointR Reflect(this tk2dSpriteAttachPoint instance)
    {
        return new tk2dSpriteAttachPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollection allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionR Reflect(this tk2dSpriteCollection instance)
    {
        return new tk2dSpriteCollectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionData allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionDataR Reflect(this tk2dSpriteCollectionData instance)
    {
        return new tk2dSpriteCollectionDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionDefault allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionDefaultR Reflect(this tk2dSpriteCollectionDefault instance)
    {
        return new tk2dSpriteCollectionDefaultR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionDefinition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionDefinitionR Reflect(this tk2dSpriteCollectionDefinition instance)
    {
        return new tk2dSpriteCollectionDefinitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionFont allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionFontR Reflect(this tk2dSpriteCollectionFont instance)
    {
        return new tk2dSpriteCollectionFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionPlatform
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionPlatformR Reflect(this tk2dSpriteCollectionPlatform instance)
    {
        return new tk2dSpriteCollectionPlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteCollectionSize allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteCollectionSizeR Reflect(this tk2dSpriteCollectionSize instance)
    {
        return new tk2dSpriteCollectionSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteColliderDefinition
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteColliderDefinitionR Reflect(this tk2dSpriteColliderDefinition instance)
    {
        return new tk2dSpriteColliderDefinitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteColliderIsland allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteColliderIslandR Reflect(this tk2dSpriteColliderIsland instance)
    {
        return new tk2dSpriteColliderIslandR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteDefinition allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteDefinitionR Reflect(this tk2dSpriteDefinition instance)
    {
        return new tk2dSpriteDefinitionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteFromTexture allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteFromTextureR Reflect(this tk2dSpriteFromTexture instance)
    {
        return new tk2dSpriteFromTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetColorR Reflect(this Tk2dSpriteGetColor instance)
    {
        return new Tk2dSpriteGetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetId allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetIdR Reflect(this Tk2dSpriteGetId instance)
    {
        return new Tk2dSpriteGetIdR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetPixelPerfect allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetPixelPerfectR Reflect(this Tk2dSpriteGetPixelPerfect instance)
    {
        return new Tk2dSpriteGetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteGetScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteGetScaleR Reflect(this Tk2dSpriteGetScale instance)
    {
        return new Tk2dSpriteGetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteMakePixelPerfect allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteMakePixelPerfectR Reflect(this Tk2dSpriteMakePixelPerfect instance)
    {
        return new Tk2dSpriteMakePixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetColorR Reflect(this Tk2dSpriteSetColor instance)
    {
        return new Tk2dSpriteSetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetId allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetIdR Reflect(this Tk2dSpriteSetId instance)
    {
        return new Tk2dSpriteSetIdR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetIdRandom allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetIdRandomR Reflect(this Tk2dSpriteSetIdRandom instance)
    {
        return new Tk2dSpriteSetIdRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetPixelPerfect allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetPixelPerfectR Reflect(this Tk2dSpriteSetPixelPerfect instance)
    {
        return new Tk2dSpriteSetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteSetScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteSetScaleR Reflect(this Tk2dSpriteSetScale instance)
    {
        return new Tk2dSpriteSetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSpriteSheetSource allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSpriteSheetSourceR Reflect(this tk2dSpriteSheetSource instance)
    {
        return new tk2dSpriteSheetSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dSpriteTweenColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dSpriteTweenColorR Reflect(this Tk2dSpriteTweenColor instance)
    {
        return new Tk2dSpriteTweenColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dStaticSpriteBatcher allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dStaticSpriteBatcherR Reflect(this tk2dStaticSpriteBatcher instance)
    {
        return new tk2dStaticSpriteBatcherR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dStopAnimation allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dStopAnimationR Reflect(this Tk2dStopAnimation instance)
    {
        return new Tk2dStopAnimationR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dSystem allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dSystemR Reflect(this tk2dSystem instance)
    {
        return new tk2dSystemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTextMesh allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTextMeshR Reflect(this tk2dTextMesh instance)
    {
        return new tk2dTextMeshR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshCommit allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshCommitR Reflect(this Tk2dTextMeshCommit instance)
    {
        return new Tk2dTextMeshCommitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTextMeshData allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTextMeshDataR Reflect(this tk2dTextMeshData instance)
    {
        return new tk2dTextMeshDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetAnchor allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetAnchorR Reflect(this Tk2dTextMeshGetAnchor instance)
    {
        return new Tk2dTextMeshGetAnchorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetColors allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetColorsR Reflect(this Tk2dTextMeshGetColors instance)
    {
        return new Tk2dTextMeshGetColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetFont allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetFontR Reflect(this Tk2dTextMeshGetFont instance)
    {
        return new Tk2dTextMeshGetFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetInlineStyling
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetInlineStylingR Reflect(this Tk2dTextMeshGetInlineStyling instance)
    {
        return new Tk2dTextMeshGetInlineStylingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     Tk2dTextMeshGetInlineStylingIsAvailable allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static Tk2dTextMeshGetInlineStylingIsAvailableR Reflect(
        this Tk2dTextMeshGetInlineStylingIsAvailable instance)
    {
        return new Tk2dTextMeshGetInlineStylingIsAvailableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetMaxChars allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetMaxCharsR Reflect(this Tk2dTextMeshGetMaxChars instance)
    {
        return new Tk2dTextMeshGetMaxCharsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetNumDrawnCharacters
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetNumDrawnCharactersR Reflect(this Tk2dTextMeshGetNumDrawnCharacters instance)
    {
        return new Tk2dTextMeshGetNumDrawnCharactersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetPixelPerfect allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetPixelPerfectR Reflect(this Tk2dTextMeshGetPixelPerfect instance)
    {
        return new Tk2dTextMeshGetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetProperties allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetPropertiesR Reflect(this Tk2dTextMeshGetProperties instance)
    {
        return new Tk2dTextMeshGetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetScaleR Reflect(this Tk2dTextMeshGetScale instance)
    {
        return new Tk2dTextMeshGetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetText allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetTextR Reflect(this Tk2dTextMeshGetText instance)
    {
        return new Tk2dTextMeshGetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshGetTextureGradient
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshGetTextureGradientR Reflect(this Tk2dTextMeshGetTextureGradient instance)
    {
        return new Tk2dTextMeshGetTextureGradientR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshMakePixelPerfect
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshMakePixelPerfectR Reflect(this Tk2dTextMeshMakePixelPerfect instance)
    {
        return new Tk2dTextMeshMakePixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetAnchor allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetAnchorR Reflect(this Tk2dTextMeshSetAnchor instance)
    {
        return new Tk2dTextMeshSetAnchorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetColors allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetColorsR Reflect(this Tk2dTextMeshSetColors instance)
    {
        return new Tk2dTextMeshSetColorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetFont allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetFontR Reflect(this Tk2dTextMeshSetFont instance)
    {
        return new Tk2dTextMeshSetFontR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetInlineStyling
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetInlineStylingR Reflect(this Tk2dTextMeshSetInlineStyling instance)
    {
        return new Tk2dTextMeshSetInlineStylingR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetMaxChars allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetMaxCharsR Reflect(this Tk2dTextMeshSetMaxChars instance)
    {
        return new Tk2dTextMeshSetMaxCharsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetPixelPerfect allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetPixelPerfectR Reflect(this Tk2dTextMeshSetPixelPerfect instance)
    {
        return new Tk2dTextMeshSetPixelPerfectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetProperties allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetPropertiesR Reflect(this Tk2dTextMeshSetProperties instance)
    {
        return new Tk2dTextMeshSetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetScale allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetScaleR Reflect(this Tk2dTextMeshSetScale instance)
    {
        return new Tk2dTextMeshSetScaleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetText allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetTextR Reflect(this Tk2dTextMeshSetText instance)
    {
        return new Tk2dTextMeshSetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dTextMeshSetTextureGradient
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dTextMeshSetTextureGradientR Reflect(this Tk2dTextMeshSetTextureGradient instance)
    {
        return new Tk2dTextMeshSetTextureGradientR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTiledSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTiledSpriteR Reflect(this tk2dTiledSprite instance)
    {
        return new tk2dTiledSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTileMap allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTileMapR Reflect(this tk2dTileMap instance)
    {
        return new tk2dTileMapR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dTileMapData allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dTileMapDataR Reflect(this tk2dTileMapData instance)
    {
        return new tk2dTileMapDataR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIAudioManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIAudioManagerR Reflect(this tk2dUIAudioManager instance)
    {
        return new tk2dUIAudioManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUICamera allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUICameraR Reflect(this tk2dUICamera instance)
    {
        return new tk2dUICameraR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIDragItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIDragItemR Reflect(this tk2dUIDragItem instance)
    {
        return new tk2dUIDragItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIDropDownItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIDropDownItemR Reflect(this tk2dUIDropDownItem instance)
    {
        return new tk2dUIDropDownItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIDropDownMenu allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIDropDownMenuR Reflect(this tk2dUIDropDownMenu instance)
    {
        return new tk2dUIDropDownMenuR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIHoverItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIHoverItemR Reflect(this tk2dUIHoverItem instance)
    {
        return new tk2dUIHoverItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIItem allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIItemR Reflect(this tk2dUIItem instance)
    {
        return new tk2dUIItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUILayout allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUILayoutR Reflect(this tk2dUILayout instance)
    {
        return new tk2dUILayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUILayoutContainerSizer allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUILayoutContainerSizerR Reflect(this tk2dUILayoutContainerSizer instance)
    {
        return new tk2dUILayoutContainerSizerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUILayoutItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUILayoutItemR Reflect(this tk2dUILayoutItem instance)
    {
        return new tk2dUILayoutItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIManagerR Reflect(this tk2dUIManager instance)
    {
        return new tk2dUIManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIMask allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIMaskR Reflect(this tk2dUIMask instance)
    {
        return new tk2dUIMaskR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIMultiStateToggleButton
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIMultiStateToggleButtonR Reflect(this tk2dUIMultiStateToggleButton instance)
    {
        return new tk2dUIMultiStateToggleButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIProgressBar allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIProgressBarR Reflect(this tk2dUIProgressBar instance)
    {
        return new tk2dUIProgressBarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIScrollableArea allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIScrollableAreaR Reflect(this tk2dUIScrollableArea instance)
    {
        return new tk2dUIScrollableAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIScrollbar allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIScrollbarR Reflect(this tk2dUIScrollbar instance)
    {
        return new tk2dUIScrollbarR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUISoundItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUISoundItemR Reflect(this tk2dUISoundItem instance)
    {
        return new tk2dUISoundItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUISpriteAnimator allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUISpriteAnimatorR Reflect(this tk2dUISpriteAnimator instance)
    {
        return new tk2dUISpriteAnimatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUITextInput allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUITextInputR Reflect(this tk2dUITextInput instance)
    {
        return new tk2dUITextInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIToggleButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIToggleButtonR Reflect(this tk2dUIToggleButton instance)
    {
        return new tk2dUIToggleButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIToggleButtonGroup allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIToggleButtonGroupR Reflect(this tk2dUIToggleButtonGroup instance)
    {
        return new tk2dUIToggleButtonGroupR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIToggleControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIToggleControlR Reflect(this tk2dUIToggleControl instance)
    {
        return new tk2dUIToggleControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUITweenItem allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUITweenItemR Reflect(this tk2dUITweenItem instance)
    {
        return new tk2dUITweenItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIUpDownButton allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIUpDownButtonR Reflect(this tk2dUIUpDownButton instance)
    {
        return new tk2dUIUpDownButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUIUpDownHoverButton allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUIUpDownHoverButtonR Reflect(this tk2dUIUpDownHoverButton instance)
    {
        return new tk2dUIUpDownHoverButtonR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of tk2dUpdateManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static tk2dUpdateManagerR Reflect(this tk2dUpdateManager instance)
    {
        return new tk2dUpdateManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Tk2dWatchAnimationEvents allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Tk2dWatchAnimationEventsR Reflect(this Tk2dWatchAnimationEvents instance)
    {
        return new Tk2dWatchAnimationEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Asset allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_AssetR Reflect(this TMP_Asset instance)
    {
        return new TMP_AssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_ColorGradient allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_ColorGradientR Reflect(this TMP_ColorGradient instance)
    {
        return new TMP_ColorGradientR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Dropdown allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_DropdownR Reflect(this TMP_Dropdown instance)
    {
        return new TMP_DropdownR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_FontAsset allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_FontAssetR Reflect(this TMP_FontAsset instance)
    {
        return new TMP_FontAssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Glyph allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_GlyphR Reflect(this TMP_Glyph instance)
    {
        return new TMP_GlyphR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_InputField allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_InputFieldR Reflect(this TMP_InputField instance)
    {
        return new TMP_InputFieldR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Settings allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SettingsR Reflect(this TMP_Settings instance)
    {
        return new TMP_SettingsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Sprite allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SpriteR Reflect(this TMP_Sprite instance)
    {
        return new TMP_SpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_SpriteAsset allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SpriteAssetR Reflect(this TMP_SpriteAsset instance)
    {
        return new TMP_SpriteAssetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Style allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_StyleR Reflect(this TMP_Style instance)
    {
        return new TMP_StyleR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_StyleSheet allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_StyleSheetR Reflect(this TMP_StyleSheet instance)
    {
        return new TMP_StyleSheetR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_SubMesh allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SubMeshR Reflect(this TMP_SubMesh instance)
    {
        return new TMP_SubMeshR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_SubMeshUI allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_SubMeshUIR Reflect(this TMP_SubMeshUI instance)
    {
        return new TMP_SubMeshUIR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_Text allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_TextR Reflect(this TMP_Text instance)
    {
        return new TMP_TextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_TextElement allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_TextElementR Reflect(this TMP_TextElement instance)
    {
        return new TMP_TextElementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_TextInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_TextInfoR Reflect(this TMP_TextInfo instance)
    {
        return new TMP_TextInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_UpdateManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_UpdateManagerR Reflect(this TMP_UpdateManager instance)
    {
        return new TMP_UpdateManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TMP_UpdateRegistry allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TMP_UpdateRegistryR Reflect(this TMP_UpdateRegistry instance)
    {
        return new TMP_UpdateRegistryR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Touch allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchR Reflect(this Touch instance)
    {
        return new TouchR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchButtonControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchButtonControlR Reflect(this TouchButtonControl instance)
    {
        return new TouchButtonControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchEventR Reflect(this TouchEvent instance)
    {
        return new TouchEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchInputDevice allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchInputDeviceR Reflect(this TouchInputDevice instance)
    {
        return new TouchInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchManager allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchManagerR Reflect(this TouchManager instance)
    {
        return new TouchManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchObject2dEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchObject2dEventR Reflect(this TouchObject2dEvent instance)
    {
        return new TouchObject2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchObjectEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchObjectEventR Reflect(this TouchObjectEvent instance)
    {
        return new TouchObjectEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchPool allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchPoolR Reflect(this TouchPool instance)
    {
        return new TouchPoolR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchShake allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchShakeR Reflect(this TouchShake instance)
    {
        return new TouchShakeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchSprite allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchSpriteR Reflect(this TouchSprite instance)
    {
        return new TouchSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchStickControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchStickControlR Reflect(this TouchStickControl instance)
    {
        return new TouchStickControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchSwipeControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchSwipeControlR Reflect(this TouchSwipeControl instance)
    {
        return new TouchSwipeControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TouchTrackControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TouchTrackControlR Reflect(this TouchTrackControl instance)
    {
        return new TouchTrackControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TownGrass allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TownGrassR Reflect(this TownGrass instance)
    {
        return new TownGrassR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackMouseMovement allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackMouseMovementR Reflect(this TrackMouseMovement instance)
    {
        return new TrackMouseMovementR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackSpawnedEnemies allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackSpawnedEnemiesR Reflect(this TrackSpawnedEnemies instance)
    {
        return new TrackSpawnedEnemiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackSpawnedEnemiesAdd allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackSpawnedEnemiesAddR Reflect(this TrackSpawnedEnemiesAdd instance)
    {
        return new TrackSpawnedEnemiesAddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackSpawnedEnemiesGetInfo allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackSpawnedEnemiesGetInfoR Reflect(this TrackSpawnedEnemiesGetInfo instance)
    {
        return new TrackSpawnedEnemiesGetInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TrackTriggerObjects allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TrackTriggerObjectsR Reflect(this TrackTriggerObjects instance)
    {
        return new TrackTriggerObjectsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransformDirection allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransformDirectionR Reflect(this TransformDirection instance)
    {
        return new TransformDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransformInputToWorldSpace allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransformInputToWorldSpaceR Reflect(this TransformInputToWorldSpace instance)
    {
        return new TransformInputToWorldSpaceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransformPoint allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransformPointR Reflect(this TransformPoint instance)
    {
        return new TransformPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransitionPoint allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransitionPointR Reflect(this TransitionPoint instance)
    {
        return new TransitionPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TransitionToAudioSnapshot allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TransitionToAudioSnapshotR Reflect(this TransitionToAudioSnapshot instance)
    {
        return new TransitionToAudioSnapshotR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Translate allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TranslateR Reflect(this Translate instance)
    {
        return new TranslateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TranslateContinuous allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TranslateContinuousR Reflect(this TranslateContinuous instance)
    {
        return new TranslateContinuousR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TranslateV2 allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TranslateV2R Reflect(this TranslateV2 instance)
    {
        return new TranslateV2R(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Trigger2dEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Trigger2dEventR Reflect(this Trigger2dEvent instance)
    {
        return new Trigger2dEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Trigger2dEventLayer allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Trigger2dEventLayerR Reflect(this Trigger2dEventLayer instance)
    {
        return new Trigger2dEventLayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Trigger2dEventToParent allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Trigger2dEventToParentR Reflect(this Trigger2dEventToParent instance)
    {
        return new Trigger2dEventToParentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerActivateComponent allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerActivateComponentR Reflect(this TriggerActivateComponent instance)
    {
        return new TriggerActivateComponentR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerActivateGameObject allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerActivateGameObjectR Reflect(this TriggerActivateGameObject instance)
    {
        return new TriggerActivateGameObjectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEnterEvent allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEnterEventR Reflect(this TriggerEnterEvent instance)
    {
        return new TriggerEnterEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEnterEventSubscribe allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEnterEventSubscribeR Reflect(this TriggerEnterEventSubscribe instance)
    {
        return new TriggerEnterEventSubscribeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEnterSendMessage allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEnterSendMessageR Reflect(this TriggerEnterSendMessage instance)
    {
        return new TriggerEnterSendMessageR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TriggerEvent allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TriggerEventR Reflect(this TriggerEvent instance)
    {
        return new TriggerEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     TrustPredatorJoystickMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static TrustPredatorJoystickMacNativeProfileR Reflect(this TrustPredatorJoystickMacNativeProfile instance)
    {
        return new TrustPredatorJoystickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TSZPelicanControllerMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TSZPelicanControllerMacNativeProfileR Reflect(this TSZPelicanControllerMacNativeProfile instance)
    {
        return new TSZPelicanControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Turret allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TurretR Reflect(this Turret instance)
    {
        return new TurretR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TutorialEntryPauser allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TutorialEntryPauserR Reflect(this TutorialEntryPauser instance)
    {
        return new TutorialEntryPauserR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of TwoAxisInputControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static TwoAxisInputControlR Reflect(this TwoAxisInputControl instance)
    {
        return new TwoAxisInputControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiButtonOnClickEvent allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiButtonOnClickEventR Reflect(this uGuiButtonOnClickEvent instance)
    {
        return new uGuiButtonOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiCanvasEnableRaycastFilter
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiCanvasEnableRaycastFilterR Reflect(this uGuiCanvasEnableRaycastFilter instance)
    {
        return new uGuiCanvasEnableRaycastFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGetColorBlock allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGetColorBlockR Reflect(this uGuiGetColorBlock instance)
    {
        return new uGuiGetColorBlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGetIsInteractable allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGetIsInteractableR Reflect(this uGuiGetIsInteractable instance)
    {
        return new uGuiGetIsInteractableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGraphicGetColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGraphicGetColorR Reflect(this uGuiGraphicGetColor instance)
    {
        return new uGuiGraphicGetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiGraphicSetColor allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiGraphicSetColorR Reflect(this uGuiGraphicSetColor instance)
    {
        return new uGuiGraphicSetColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiImageGetSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiImageGetSpriteR Reflect(this uGuiImageGetSprite instance)
    {
        return new uGuiImageGetSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiImageSetSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiImageSetSpriteR Reflect(this uGuiImageSetSprite instance)
    {
        return new uGuiImageSetSpriteR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldActivate allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldActivateR Reflect(this uGuiInputFieldActivate instance)
    {
        return new uGuiInputFieldActivateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldDeactivate allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldDeactivateR Reflect(this uGuiInputFieldDeactivate instance)
    {
        return new uGuiInputFieldDeactivateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetCaretBlinkRate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetCaretBlinkRateR Reflect(this uGuiInputFieldGetCaretBlinkRate instance)
    {
        return new uGuiInputFieldGetCaretBlinkRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetCharacterLimit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetCharacterLimitR Reflect(this uGuiInputFieldGetCharacterLimit instance)
    {
        return new uGuiInputFieldGetCharacterLimitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetHideMobileInput
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetHideMobileInputR Reflect(this uGuiInputFieldGetHideMobileInput instance)
    {
        return new uGuiInputFieldGetHideMobileInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetPlaceHolder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetPlaceHolderR Reflect(this uGuiInputFieldGetPlaceHolder instance)
    {
        return new uGuiInputFieldGetPlaceHolderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetSelectionColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetSelectionColorR Reflect(this uGuiInputFieldGetSelectionColor instance)
    {
        return new uGuiInputFieldGetSelectionColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldGetText allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldGetTextR Reflect(this uGuiInputFieldGetText instance)
    {
        return new uGuiInputFieldGetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldMoveCaretToTextEnd
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldMoveCaretToTextEndR Reflect(this uGuiInputFieldMoveCaretToTextEnd instance)
    {
        return new uGuiInputFieldMoveCaretToTextEndR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldMoveCaretToTextStart
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldMoveCaretToTextStartR Reflect(this uGuiInputFieldMoveCaretToTextStart instance)
    {
        return new uGuiInputFieldMoveCaretToTextStartR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldOnEndEditEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldOnEndEditEventR Reflect(this uGuiInputFieldOnEndEditEvent instance)
    {
        return new uGuiInputFieldOnEndEditEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldOnValueChangeEvent
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldOnValueChangeEventR Reflect(this uGuiInputFieldOnValueChangeEvent instance)
    {
        return new uGuiInputFieldOnValueChangeEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldRebuild allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldRebuildR Reflect(this uGuiInputFieldRebuild instance)
    {
        return new uGuiInputFieldRebuildR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldScreenToLocal allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldScreenToLocalR Reflect(this uGuiInputFieldScreenToLocal instance)
    {
        return new uGuiInputFieldScreenToLocalR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetAsterixChar
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetAsterixCharR Reflect(this uGuiInputFieldSetAsterixChar instance)
    {
        return new uGuiInputFieldSetAsterixCharR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputfieldSetCaretBlinkRate
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputfieldSetCaretBlinkRateR Reflect(this uGuiInputfieldSetCaretBlinkRate instance)
    {
        return new uGuiInputfieldSetCaretBlinkRateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetCharacterLimit
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetCharacterLimitR Reflect(this uGuiInputFieldSetCharacterLimit instance)
    {
        return new uGuiInputFieldSetCharacterLimitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetHideMobileInput
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetHideMobileInputR Reflect(this uGuiInputFieldSetHideMobileInput instance)
    {
        return new uGuiInputFieldSetHideMobileInputR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetPlaceHolder
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetPlaceHolderR Reflect(this uGuiInputFieldSetPlaceHolder instance)
    {
        return new uGuiInputFieldSetPlaceHolderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetSelectionColor
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetSelectionColorR Reflect(this uGuiInputFieldSetSelectionColor instance)
    {
        return new uGuiInputFieldSetSelectionColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiInputFieldSetText allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiInputFieldSetTextR Reflect(this uGuiInputFieldSetText instance)
    {
        return new uGuiInputFieldSetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiLayoutElementGetValues allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiLayoutElementGetValuesR Reflect(this uGuiLayoutElementGetValues instance)
    {
        return new uGuiLayoutElementGetValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiLayoutElementSetValues allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiLayoutElementSetValuesR Reflect(this uGuiLayoutElementSetValues instance)
    {
        return new uGuiLayoutElementSetValuesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationExplicitGetProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationExplicitGetPropertiesR Reflect(this uGuiNavigationExplicitGetProperties instance)
    {
        return new uGuiNavigationExplicitGetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationExplicitSetProperties
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationExplicitSetPropertiesR Reflect(this uGuiNavigationExplicitSetProperties instance)
    {
        return new uGuiNavigationExplicitSetPropertiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationGetMode allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationGetModeR Reflect(this uGuiNavigationGetMode instance)
    {
        return new uGuiNavigationGetModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiNavigationSetMode allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiNavigationSetModeR Reflect(this uGuiNavigationSetMode instance)
    {
        return new uGuiNavigationSetModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiRawImageSetTexture allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiRawImageSetTextureR Reflect(this uGuiRawImageSetTexture instance)
    {
        return new uGuiRawImageSetTextureR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarGetValue allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarGetValueR Reflect(this uGuiScrollbarGetValue instance)
    {
        return new uGuiScrollbarGetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarOnClickEvent allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarOnClickEventR Reflect(this uGuiScrollbarOnClickEvent instance)
    {
        return new uGuiScrollbarOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetDirection allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetDirectionR Reflect(this uGuiScrollbarSetDirection instance)
    {
        return new uGuiScrollbarSetDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetNumberOfSteps
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetNumberOfStepsR Reflect(this uGuiScrollbarSetNumberOfSteps instance)
    {
        return new uGuiScrollbarSetNumberOfStepsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetSize allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetSizeR Reflect(this uGuiScrollbarSetSize instance)
    {
        return new uGuiScrollbarSetSizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiScrollbarSetValue allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiScrollbarSetValueR Reflect(this uGuiScrollbarSetValue instance)
    {
        return new uGuiScrollbarSetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetAnimationTriggers allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetAnimationTriggersR Reflect(this uGuiSetAnimationTriggers instance)
    {
        return new uGuiSetAnimationTriggersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetButtonNormalColor allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetButtonNormalColorR Reflect(this uGuiSetButtonNormalColor instance)
    {
        return new uGuiSetButtonNormalColorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetColorBlock allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetColorBlockR Reflect(this uGuiSetColorBlock instance)
    {
        return new uGuiSetColorBlockR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSetIsInteractable allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSetIsInteractableR Reflect(this uGuiSetIsInteractable instance)
    {
        return new uGuiSetIsInteractableR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetMinMax allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetMinMaxR Reflect(this uGuiSliderGetMinMax instance)
    {
        return new uGuiSliderGetMinMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetNormalizedValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetNormalizedValueR Reflect(this uGuiSliderGetNormalizedValue instance)
    {
        return new uGuiSliderGetNormalizedValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetValueR Reflect(this uGuiSliderGetValue instance)
    {
        return new uGuiSliderGetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderGetWholeNumbers allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderGetWholeNumbersR Reflect(this uGuiSliderGetWholeNumbers instance)
    {
        return new uGuiSliderGetWholeNumbersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderOnClickEvent allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderOnClickEventR Reflect(this uGuiSliderOnClickEvent instance)
    {
        return new uGuiSliderOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetDirection allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetDirectionR Reflect(this uGuiSliderSetDirection instance)
    {
        return new uGuiSliderSetDirectionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetIsOn allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetIsOnR Reflect(this uGuiSliderSetIsOn instance)
    {
        return new uGuiSliderSetIsOnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetMinMax allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetMinMaxR Reflect(this uGuiSliderSetMinMax instance)
    {
        return new uGuiSliderSetMinMaxR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetNormalizedValue
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetNormalizedValueR Reflect(this uGuiSliderSetNormalizedValue instance)
    {
        return new uGuiSliderSetNormalizedValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetValue allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetValueR Reflect(this uGuiSliderSetValue instance)
    {
        return new uGuiSliderSetValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiSliderSetWholeNumbers allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiSliderSetWholeNumbersR Reflect(this uGuiSliderSetWholeNumbers instance)
    {
        return new uGuiSliderSetWholeNumbersR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTextGetText allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTextGetTextR Reflect(this uGuiTextGetText instance)
    {
        return new uGuiTextGetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTextSetText allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTextSetTextR Reflect(this uGuiTextSetText instance)
    {
        return new uGuiTextSetTextR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiToggleGetIsOn allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiToggleGetIsOnR Reflect(this uGuiToggleGetIsOn instance)
    {
        return new uGuiToggleGetIsOnR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiToggleOnClickEvent allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiToggleOnClickEventR Reflect(this uGuiToggleOnClickEvent instance)
    {
        return new uGuiToggleOnClickEventR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTransitionGetType allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTransitionGetTypeR Reflect(this uGuiTransitionGetType instance)
    {
        return new uGuiTransitionGetTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of uGuiTransitionSetType allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static uGuiTransitionSetTypeR Reflect(this uGuiTransitionSetType instance)
    {
        return new uGuiTransitionSetTypeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIAnimationEvents allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIAnimationEventsR Reflect(this UIAnimationEvents instance)
    {
        return new UIAnimationEventsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIBlendMode allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIBlendModeR Reflect(this UIBlendMode instance)
    {
        return new UIBlendModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIButtonSkins allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIButtonSkinsR Reflect(this UIButtonSkins instance)
    {
        return new UIButtonSkinsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UIWindowBase allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UIWindowBaseR Reflect(this UIWindowBase instance)
    {
        return new UIWindowBaseR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnboldIfCJK allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnboldIfCJKR Reflect(this UnboldIfCJK instance)
    {
        return new UnboldIfCJKR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDevice allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceR Reflect(this UnityInputDevice instance)
    {
        return new UnityInputDeviceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDeviceManager allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceManagerR Reflect(this UnityInputDeviceManager instance)
    {
        return new UnityInputDeviceManagerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDeviceProfileAttribute
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceProfileAttributeR Reflect(this UnityInputDeviceProfileAttribute instance)
    {
        return new UnityInputDeviceProfileAttributeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityInputDeviceProfileList allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityInputDeviceProfileListR Reflect(this UnityInputDeviceProfileList instance)
    {
        return new UnityInputDeviceProfileListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityKeyboardProvider allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityKeyboardProviderR Reflect(this UnityKeyboardProvider instance)
    {
        return new UnityKeyboardProviderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnityMouseProvider allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnityMouseProviderR Reflect(this UnityMouseProvider instance)
    {
        return new UnityMouseProviderR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnknownDeviceBindingSource allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnknownDeviceBindingSourceR Reflect(this UnknownDeviceBindingSource instance)
    {
        return new UnknownDeviceBindingSourceR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnknownDeviceBindingSourceListener
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnknownDeviceBindingSourceListenerR Reflect(this UnknownDeviceBindingSourceListener instance)
    {
        return new UnknownDeviceBindingSourceListenerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnlockGGMode allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnlockGGModeR Reflect(this UnlockGGMode instance)
    {
        return new UnlockGGModeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UnsupportedVibrationEmission
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UnsupportedVibrationEmissionR Reflect(this UnsupportedVibrationEmission instance)
    {
        return new UnsupportedVibrationEmissionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UpdateHelper allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UpdateHelperR Reflect(this UpdateHelper instance)
    {
        return new UpdateHelperR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UpdateTextWithSliderValue allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UpdateTextWithSliderValueR Reflect(this UpdateTextWithSliderValue instance)
    {
        return new UpdateTextWithSliderValueR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UseGravity allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UseGravityR Reflect(this UseGravity instance)
    {
        return new UseGravityR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of UseGUILayout allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static UseGUILayoutR Reflect(this UseGUILayout instance)
    {
        return new UseGUILayoutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ValveStreamingWindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ValveStreamingWindowsUnityProfileR Reflect(this ValveStreamingWindowsUnityProfile instance)
    {
        return new ValveStreamingWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector2Converter allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector2ConverterR Reflect(this Vector2Converter instance)
    {
        return new Vector2ConverterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector2Multiply allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector2MultiplyR Reflect(this Vector2Multiply instance)
    {
        return new Vector2MultiplyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Add allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3AddR Reflect(this Vector3Add instance)
    {
        return new Vector3AddR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3AddXYZ allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3AddXYZR Reflect(this Vector3AddXYZ instance)
    {
        return new Vector3AddXYZR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3ClampMagnitude allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3ClampMagnitudeR Reflect(this Vector3ClampMagnitude instance)
    {
        return new Vector3ClampMagnitudeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Compare allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3CompareR Reflect(this Vector3Compare instance)
    {
        return new Vector3CompareR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Converter allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3ConverterR Reflect(this Vector3Converter instance)
    {
        return new Vector3ConverterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3HighPassFilter allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3HighPassFilterR Reflect(this Vector3HighPassFilter instance)
    {
        return new Vector3HighPassFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Interpolate allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3InterpolateR Reflect(this Vector3Interpolate instance)
    {
        return new Vector3InterpolateR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Invert allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3InvertR Reflect(this Vector3Invert instance)
    {
        return new Vector3InvertR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Lerp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3LerpR Reflect(this Vector3Lerp instance)
    {
        return new Vector3LerpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3LowPassFilter allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3LowPassFilterR Reflect(this Vector3LowPassFilter instance)
    {
        return new Vector3LowPassFilterR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Multiply allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3MultiplyR Reflect(this Vector3Multiply instance)
    {
        return new Vector3MultiplyR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Normalize allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3NormalizeR Reflect(this Vector3Normalize instance)
    {
        return new Vector3NormalizeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Operator allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3OperatorR Reflect(this Vector3Operator instance)
    {
        return new Vector3OperatorR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3PerSecond allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3PerSecondR Reflect(this Vector3PerSecond instance)
    {
        return new Vector3PerSecondR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3RotateTowards allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3RotateTowardsR Reflect(this Vector3RotateTowards instance)
    {
        return new Vector3RotateTowardsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Vector3Subtract allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Vector3SubtractR Reflect(this Vector3Subtract instance)
    {
        return new Vector3SubtractR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationEffect allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationEffectR Reflect(this VibrationEffect instance)
    {
        return new VibrationEffectR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayer allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerR Reflect(this VibrationPlayer instance)
    {
        return new VibrationPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayerPlay allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerPlayR Reflect(this VibrationPlayerPlay instance)
    {
        return new VibrationPlayerPlayR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayerSetMotors allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerSetMotorsR Reflect(this VibrationPlayerSetMotors instance)
    {
        return new VibrationPlayerSetMotorsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VibrationPlayerStop allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VibrationPlayerStopR Reflect(this VibrationPlayerStop instance)
    {
        return new VibrationPlayerStopR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VideoMenuOptions allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VideoMenuOptionsR Reflect(this VideoMenuOptions instance)
    {
        return new VideoMenuOptionsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VinePlatform allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VinePlatformR Reflect(this VinePlatform instance)
    {
        return new VinePlatformR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VinePlatformCut allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VinePlatformCutR Reflect(this VinePlatformCut instance)
    {
        return new VinePlatformCutR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of VisibilityControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static VisibilityControlR Reflect(this VisibilityControl instance)
    {
        return new VisibilityControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Wait allowing you to easily get/set
    ///     fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitR Reflect(this Wait instance)
    {
        return new WaitR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForBossLoad allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForBossLoadR Reflect(this WaitForBossLoad instance)
    {
        return new WaitForBossLoadR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForFinishedEnteringScene
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForFinishedEnteringSceneR Reflect(this WaitForFinishedEnteringScene instance)
    {
        return new WaitForFinishedEnteringSceneR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForHeroInPosition allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForHeroInPositionR Reflect(this WaitForHeroInPosition instance)
    {
        return new WaitForHeroInPositionR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitForSceneLoadFinish allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitForSceneLoadFinishR Reflect(this WaitForSceneLoadFinish instance)
    {
        return new WaitForSceneLoadFinishR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaitRandom allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaitRandomR Reflect(this WaitRandom instance)
    {
        return new WaitRandomR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeAllRigidBodies allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeAllRigidBodiesR Reflect(this WakeAllRigidBodies instance)
    {
        return new WakeAllRigidBodiesR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeAllRigidBodies2d allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeAllRigidBodies2dR Reflect(this WakeAllRigidBodies2d instance)
    {
        return new WakeAllRigidBodies2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeUp allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeUpR Reflect(this WakeUp instance)
    {
        return new WakeUpR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WakeUp2d allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WakeUp2dR Reflect(this WakeUp2d instance)
    {
        return new WakeUp2dR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WalkArea allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkAreaR Reflect(this WalkArea instance)
    {
        return new WalkAreaR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Walker allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkerR Reflect(this Walker instance)
    {
        return new WalkerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WalkLeftRight allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkLeftRightR Reflect(this WalkLeftRight instance)
    {
        return new WalkLeftRightR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WalkSlope allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WalkSlopeR Reflect(this WalkSlope instance)
    {
        return new WalkSlopeR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WasHere allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WasHereR Reflect(this WasHere instance)
    {
        return new WasHereR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaterDrip allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaterDripR Reflect(this WaterDrip instance)
    {
        return new WaterDripR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WaveEffectControl allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WaveEffectControlR Reflect(this WaveEffectControl instance)
    {
        return new WaveEffectControlR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WeaverlingEnemyList allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WeaverlingEnemyListR Reflect(this WeaverlingEnemyList instance)
    {
        return new WeaverlingEnemyListR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WeightedItem allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WeightedItemR Reflect(this WeightedItem instance)
    {
        return new WeightedItemR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldInfo allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WorldInfoR Reflect(this WorldInfo instance)
    {
        return new WorldInfoR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldItems allowing you to easily
    ///     get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WorldItemsR Reflect(this WorldItems instance)
    {
        return new WorldItemsR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of WorldToScreenPoint allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static WorldToScreenPointR Reflect(this WorldToScreenPoint instance)
    {
        return new WorldToScreenPointR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XB1CinematicVideoPlayer allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XB1CinematicVideoPlayerR Reflect(this XB1CinematicVideoPlayer instance)
    {
        return new XB1CinematicVideoPlayerR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360AmazonUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360AmazonUnityProfileR Reflect(this Xbox360AmazonUnityProfile instance)
    {
        return new Xbox360AmazonUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360AndroidUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360AndroidUnityProfileR Reflect(this Xbox360AndroidUnityProfile instance)
    {
        return new Xbox360AndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360DriverMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360DriverMacNativeProfileR Reflect(this Xbox360DriverMacNativeProfile instance)
    {
        return new Xbox360DriverMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360LinuxUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360LinuxUnityProfileR Reflect(this Xbox360LinuxUnityProfile instance)
    {
        return new Xbox360LinuxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacChromeUnityProfileR Reflect(this Xbox360MacChromeUnityProfile instance)
    {
        return new Xbox360MacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacFirefoxUnityProfileR Reflect(this Xbox360MacFirefoxUnityProfile instance)
    {
        return new Xbox360MacFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacSafariUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacSafariUnityProfileR Reflect(this Xbox360MacSafariUnityProfile instance)
    {
        return new Xbox360MacSafariUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360MacUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360MacUnityProfileR Reflect(this Xbox360MacUnityProfile instance)
    {
        return new Xbox360MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     Xbox360MortalKombatFightStickMacNativeProfile allowing you to easily get/set fields and call methods without
    ///     dealing with reflection.
    /// </summary>
    public static Xbox360MortalKombatFightStickMacNativeProfileR Reflect(this
        Xbox360MortalKombatFightStickMacNativeProfile instance)
    {
        return new Xbox360MortalKombatFightStickMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     Xbox360ProEXControllerMacNativeProfile allowing you to easily get/set fields and call methods without dealing with
    ///     reflection.
    /// </summary>
    public static Xbox360ProEXControllerMacNativeProfileR Reflect(this Xbox360ProEXControllerMacNativeProfile instance)
    {
        return new Xbox360ProEXControllerMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360RockCandyAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360RockCandyAndroidUnityProfileR Reflect(this Xbox360RockCandyAndroidUnityProfile instance)
    {
        return new Xbox360RockCandyAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360WindowsUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360WindowsUnityProfileR Reflect(this Xbox360WindowsUnityProfile instance)
    {
        return new Xbox360WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360WiredWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360WiredWindowsNativeProfileR Reflect(this Xbox360WiredWindowsNativeProfile instance)
    {
        return new Xbox360WiredWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of Xbox360WirelessWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static Xbox360WirelessWindowsNativeProfileR Reflect(this Xbox360WirelessWindowsNativeProfile instance)
    {
        return new Xbox360WirelessWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneBluetoothAndroidUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneBluetoothAndroidUnityProfileR Reflect(this XboxOneBluetoothAndroidUnityProfile instance)
    {
        return new XboxOneBluetoothAndroidUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneDriverMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneDriverMacNativeProfileR Reflect(this XboxOneDriverMacNativeProfile instance)
    {
        return new XboxOneDriverMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneEliteWindows10AENativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneEliteWindows10AENativeProfileR Reflect(this XboxOneEliteWindows10AENativeProfile instance)
    {
        return new XboxOneEliteWindows10AENativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneEliteWindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneEliteWindowsNativeProfileR Reflect(this XboxOneEliteWindowsNativeProfile instance)
    {
        return new XboxOneEliteWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacChromeUnityProfileR Reflect(this XboxOneMacChromeUnityProfile instance)
    {
        return new XboxOneMacChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacFirefoxUnityProfileR Reflect(this XboxOneMacFirefoxUnityProfile instance)
    {
        return new XboxOneMacFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacSafariUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacSafariUnityProfileR Reflect(this XboxOneMacSafariUnityProfile instance)
    {
        return new XboxOneMacSafariUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMacUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMacUnityProfileR Reflect(this XboxOneMacUnityProfile instance)
    {
        return new XboxOneMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneMFiNativeProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneMFiNativeProfileR Reflect(this XboxOneMFiNativeProfile instance)
    {
        return new XboxOneMFiNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneSBluetoothMacNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneSBluetoothMacNativeProfileR Reflect(this XboxOneSBluetoothMacNativeProfile instance)
    {
        return new XboxOneSBluetoothMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneSMacNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneSMacNativeProfileR Reflect(this XboxOneSMacNativeProfile instance)
    {
        return new XboxOneSMacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneUnityProfile allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneUnityProfileR Reflect(this XboxOneUnityProfile instance)
    {
        return new XboxOneUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10AENativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10AENativeProfileR Reflect(this XboxOneWindows10AENativeProfile instance)
    {
        return new XboxOneWindows10AENativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10AEUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10AEUnityProfileR Reflect(this XboxOneWindows10AEUnityProfile instance)
    {
        return new XboxOneWindows10AEUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10NativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10NativeProfileR Reflect(this XboxOneWindows10NativeProfile instance)
    {
        return new XboxOneWindows10NativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindows10UnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindows10UnityProfileR Reflect(this XboxOneWindows10UnityProfile instance)
    {
        return new XboxOneWindows10UnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindowsNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindowsNativeProfileR Reflect(this XboxOneWindowsNativeProfile instance)
    {
        return new XboxOneWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XboxOneWindowsUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XboxOneWindowsUnityProfileR Reflect(this XboxOneWindowsUnityProfile instance)
    {
        return new XboxOneWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of
    ///     XboxOneWirelessAdapterWindowsNativeProfile allowing you to easily get/set fields and call methods without dealing
    ///     with reflection.
    /// </summary>
    public static XboxOneWirelessAdapterWindowsNativeProfileR Reflect(this
        XboxOneWirelessAdapterWindowsNativeProfile instance)
    {
        return new XboxOneWirelessAdapterWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XiamoiWindowsUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XiamoiWindowsUnityProfileR Reflect(this XiamoiWindowsUnityProfile instance)
    {
        return new XiamoiWindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XiaomiMacUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XiaomiMacUnityProfileR Reflect(this XiaomiMacUnityProfile instance)
    {
        return new XiaomiMacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XInputWindowsChromeUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XInputWindowsChromeUnityProfileR Reflect(this XInputWindowsChromeUnityProfile instance)
    {
        return new XInputWindowsChromeUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XInputWindowsFirefoxUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XInputWindowsFirefoxUnityProfileR Reflect(this XInputWindowsFirefoxUnityProfile instance)
    {
        return new XInputWindowsFirefoxUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XInputWindowsNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XInputWindowsNativeProfileR Reflect(this XInputWindowsNativeProfile instance)
    {
        return new XInputWindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_MacNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_MacNativeProfileR Reflect(this XTR55_G2_MacNativeProfile instance)
    {
        return new XTR55_G2_MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_MacUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_MacUnityProfileR Reflect(this XTR55_G2_MacUnityProfile instance)
    {
        return new XTR55_G2_MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_WindowsNativeProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_WindowsNativeProfileR Reflect(this XTR55_G2_WindowsNativeProfile instance)
    {
        return new XTR55_G2_WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR55_G2_WindowsUnityProfile
    ///     allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR55_G2_WindowsUnityProfileR Reflect(this XTR55_G2_WindowsUnityProfile instance)
    {
        return new XTR55_G2_WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_MacNativeProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_MacNativeProfileR Reflect(this XTR_G2_MacNativeProfile instance)
    {
        return new XTR_G2_MacNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_MacUnityProfile allowing you
    ///     to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_MacUnityProfileR Reflect(this XTR_G2_MacUnityProfile instance)
    {
        return new XTR_G2_MacUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_WindowsNativeProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_WindowsNativeProfileR Reflect(this XTR_G2_WindowsNativeProfile instance)
    {
        return new XTR_G2_WindowsNativeProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of XTR_G2_WindowsUnityProfile allowing
    ///     you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static XTR_G2_WindowsUnityProfileR Reflect(this XTR_G2_WindowsUnityProfile instance)
    {
        return new XTR_G2_WindowsUnityProfileR(instance);
    }

    /// <summary>
    ///     Returns an object that contains all (public and private) fields and methods of ZeroAlphaOnStart allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static ZeroAlphaOnStartR Reflect(this ZeroAlphaOnStart instance)
    {
        return new ZeroAlphaOnStartR(instance);
    }
}