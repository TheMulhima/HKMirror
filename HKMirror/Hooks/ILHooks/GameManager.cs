using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameManager
{
    public static event ILContext.Manipulator get_TimeSlowed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_TimeSlowed"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_TimeSlowed"),
            value);
    }

    public static event ILContext.Manipulator get_inputHandler
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_inputHandler"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_inputHandler"),
            value);
    }

    public static event ILContext.Manipulator set_inputHandler
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_inputHandler"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_inputHandler"),
            value);
    }

    public static event ILContext.Manipulator get_achievementHandler
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_achievementHandler"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_achievementHandler"), value);
    }

    public static event ILContext.Manipulator set_achievementHandler
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_achievementHandler"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_achievementHandler"), value);
    }

    public static event ILContext.Manipulator get_AudioManager
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_AudioManager"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_AudioManager"),
            value);
    }

    public static event ILContext.Manipulator get_cameraCtrl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_cameraCtrl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_cameraCtrl"),
            value);
    }

    public static event ILContext.Manipulator set_cameraCtrl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_cameraCtrl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_cameraCtrl"),
            value);
    }

    public static event ILContext.Manipulator get_hero_ctrl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_hero_ctrl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_hero_ctrl"),
            value);
    }

    public static event ILContext.Manipulator set_hero_ctrl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_hero_ctrl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_hero_ctrl"),
            value);
    }

    public static event ILContext.Manipulator get_heroLight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_heroLight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_heroLight"),
            value);
    }

    public static event ILContext.Manipulator set_heroLight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_heroLight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_heroLight"),
            value);
    }

    public static event ILContext.Manipulator get_sm
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_sm"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_sm"), value);
    }

    public static event ILContext.Manipulator set_sm
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_sm"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_sm"), value);
    }

    public static event ILContext.Manipulator get_ui
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_ui"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_ui"), value);
    }

    public static event ILContext.Manipulator set_ui
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_ui"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_ui"), value);
    }

    public static event ILContext.Manipulator get_tilemap
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_tilemap"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_tilemap"),
            value);
    }

    public static event ILContext.Manipulator set_tilemap
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_tilemap"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_tilemap"),
            value);
    }

    public static event ILContext.Manipulator get_soulOrb_fsm
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_soulOrb_fsm"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_soulOrb_fsm"),
            value);
    }

    public static event ILContext.Manipulator set_soulOrb_fsm
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_soulOrb_fsm"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_soulOrb_fsm"),
            value);
    }

    public static event ILContext.Manipulator get_soulVessel_fsm
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_soulVessel_fsm"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_soulVessel_fsm"), value);
    }

    public static event ILContext.Manipulator set_soulVessel_fsm
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_soulVessel_fsm"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_soulVessel_fsm"), value);
    }

    public static event ILContext.Manipulator get_PlayTime
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_PlayTime"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_PlayTime"),
            value);
    }

    public static event ILContext.Manipulator get_RespawningHero
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_RespawningHero"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_RespawningHero"), value);
    }

    public static event ILContext.Manipulator set_RespawningHero
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_RespawningHero"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_RespawningHero"), value);
    }

    public static event ILContext.Manipulator get_IsInSceneTransition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_IsInSceneTransition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_IsInSceneTransition"), value);
    }

    public static event ILContext.Manipulator set_IsInSceneTransition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_IsInSceneTransition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "set_IsInSceneTransition"), value);
    }

    public static event ILContext.Manipulator get_HasFinishedEnteringScene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_HasFinishedEnteringScene"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_HasFinishedEnteringScene"), value);
    }

    public static event ILContext.Manipulator get_WorldInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_WorldInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_WorldInfo"),
            value);
    }

    public static event ILContext.Manipulator get_IsLoadingSceneTransition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_IsLoadingSceneTransition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_IsLoadingSceneTransition"), value);
    }

    public static event ILContext.Manipulator get_CurrentLoadDuration
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_CurrentLoadDuration"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_CurrentLoadDuration"), value);
    }

    public static event ILContext.Manipulator get_IsUsingCustomLoadAnimation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_IsUsingCustomLoadAnimation"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_IsUsingCustomLoadAnimation"), value);
    }

    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_instance", false), value);
    }

    public static event ILContext.Manipulator get_UnsafeInstance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_UnsafeInstance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "get_UnsafeInstance", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.GameManager.Awake += value;
        remove => IL.GameManager.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GameManager.Start += value;
        remove => IL.GameManager.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GameManager.Update += value;
        remove => IL.GameManager.Update -= value;
    }

    public static event ILContext.Manipulator UpdateEngagement
    {
        add => IL.GameManager.UpdateEngagement += value;
        remove => IL.GameManager.UpdateEngagement -= value;
    }

    public static event ILContext.Manipulator LevelActivated
    {
        add => IL.GameManager.LevelActivated += value;
        remove => IL.GameManager.LevelActivated -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.GameManager.OnDisable += value;
        remove => IL.GameManager.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnApplicationQuit
    {
        add => IL.GameManager.OnApplicationQuit += value;
        remove => IL.GameManager.OnApplicationQuit -= value;
    }

    public static event ILContext.Manipulator TransitionScene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "TransitionScene").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "TransitionScene").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ChangeToScene
    {
        add => IL.GameManager.ChangeToScene += value;
        remove => IL.GameManager.ChangeToScene -= value;
    }

    public static event ILContext.Manipulator WarpToDreamGate
    {
        add => IL.GameManager.WarpToDreamGate += value;
        remove => IL.GameManager.WarpToDreamGate -= value;
    }

    public static event ILContext.Manipulator LeftScene
    {
        add => IL.GameManager.LeftScene += value;
        remove => IL.GameManager.LeftScene -= value;
    }

    public static event ILContext.Manipulator PlayerDead
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PlayerDead").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PlayerDead").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator PlayerDeadFromHazard
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PlayerDeadFromHazard").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PlayerDeadFromHazard").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ReadyForRespawn
    {
        add => IL.GameManager.ReadyForRespawn += value;
        remove => IL.GameManager.ReadyForRespawn -= value;
    }

    public static event ILContext.Manipulator HazardRespawn
    {
        add => IL.GameManager.HazardRespawn += value;
        remove => IL.GameManager.HazardRespawn -= value;
    }

    public static event ILContext.Manipulator TimePasses
    {
        add => IL.GameManager.TimePasses += value;
        remove => IL.GameManager.TimePasses -= value;
    }

    public static event ILContext.Manipulator FadeSceneIn
    {
        add => IL.GameManager.FadeSceneIn += value;
        remove => IL.GameManager.FadeSceneIn -= value;
    }

    public static event ILContext.Manipulator FadeSceneInWithDelay
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FadeSceneInWithDelay").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FadeSceneInWithDelay").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator IsGamePaused
    {
        add => IL.GameManager.IsGamePaused += value;
        remove => IL.GameManager.IsGamePaused -= value;
    }

    public static event ILContext.Manipulator SetGameMap
    {
        add => IL.GameManager.SetGameMap += value;
        remove => IL.GameManager.SetGameMap -= value;
    }

    public static event ILContext.Manipulator CalculateNotchesUsed
    {
        add => IL.GameManager.CalculateNotchesUsed += value;
        remove => IL.GameManager.CalculateNotchesUsed -= value;
    }

    public static event ILContext.Manipulator GetLanguageAsString
    {
        add => IL.GameManager.GetLanguageAsString += value;
        remove => IL.GameManager.GetLanguageAsString -= value;
    }

    public static event ILContext.Manipulator GetEntryGateName
    {
        add => IL.GameManager.GetEntryGateName += value;
        remove => IL.GameManager.GetEntryGateName -= value;
    }

    public static event ILContext.Manipulator SetPlayerDataBool
    {
        add => IL.GameManager.SetPlayerDataBool += value;
        remove => IL.GameManager.SetPlayerDataBool -= value;
    }

    public static event ILContext.Manipulator SetPlayerDataInt
    {
        add => IL.GameManager.SetPlayerDataInt += value;
        remove => IL.GameManager.SetPlayerDataInt -= value;
    }

    public static event ILContext.Manipulator SetPlayerDataFloat
    {
        add => IL.GameManager.SetPlayerDataFloat += value;
        remove => IL.GameManager.SetPlayerDataFloat -= value;
    }

    public static event ILContext.Manipulator SetPlayerDataString
    {
        add => IL.GameManager.SetPlayerDataString += value;
        remove => IL.GameManager.SetPlayerDataString -= value;
    }

    public static event ILContext.Manipulator IncrementPlayerDataInt
    {
        add => IL.GameManager.IncrementPlayerDataInt += value;
        remove => IL.GameManager.IncrementPlayerDataInt -= value;
    }

    public static event ILContext.Manipulator DecrementPlayerDataInt
    {
        add => IL.GameManager.DecrementPlayerDataInt += value;
        remove => IL.GameManager.DecrementPlayerDataInt -= value;
    }

    public static event ILContext.Manipulator IntAdd
    {
        add => IL.GameManager.IntAdd += value;
        remove => IL.GameManager.IntAdd -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataBool
    {
        add => IL.GameManager.GetPlayerDataBool += value;
        remove => IL.GameManager.GetPlayerDataBool -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataInt
    {
        add => IL.GameManager.GetPlayerDataInt += value;
        remove => IL.GameManager.GetPlayerDataInt -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataFloat
    {
        add => IL.GameManager.GetPlayerDataFloat += value;
        remove => IL.GameManager.GetPlayerDataFloat -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataString
    {
        add => IL.GameManager.GetPlayerDataString += value;
        remove => IL.GameManager.GetPlayerDataString -= value;
    }

    public static event ILContext.Manipulator SetPlayerDataVector3
    {
        add => IL.GameManager.SetPlayerDataVector3 += value;
        remove => IL.GameManager.SetPlayerDataVector3 -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataVector3
    {
        add => IL.GameManager.GetPlayerDataVector3 += value;
        remove => IL.GameManager.GetPlayerDataVector3 -= value;
    }

    public static event ILContext.Manipulator EquipCharm
    {
        add => IL.GameManager.EquipCharm += value;
        remove => IL.GameManager.EquipCharm -= value;
    }

    public static event ILContext.Manipulator UnequipCharm
    {
        add => IL.GameManager.UnequipCharm += value;
        remove => IL.GameManager.UnequipCharm -= value;
    }

    public static event ILContext.Manipulator RefreshOvercharm
    {
        add => IL.GameManager.RefreshOvercharm += value;
        remove => IL.GameManager.RefreshOvercharm -= value;
    }

    public static event ILContext.Manipulator UpdateBlueHealth
    {
        add => IL.GameManager.UpdateBlueHealth += value;
        remove => IL.GameManager.UpdateBlueHealth -= value;
    }

    public static event ILContext.Manipulator SetCurrentMapZoneAsRespawn
    {
        add => IL.GameManager.SetCurrentMapZoneAsRespawn += value;
        remove => IL.GameManager.SetCurrentMapZoneAsRespawn -= value;
    }

    public static event ILContext.Manipulator SetMapZoneToSpecific
    {
        add => IL.GameManager.SetMapZoneToSpecific += value;
        remove => IL.GameManager.SetMapZoneToSpecific -= value;
    }

    public static event ILContext.Manipulator StartSoulLimiter
    {
        add => IL.GameManager.StartSoulLimiter += value;
        remove => IL.GameManager.StartSoulLimiter -= value;
    }

    public static event ILContext.Manipulator EndSoulLimiter
    {
        add => IL.GameManager.EndSoulLimiter += value;
        remove => IL.GameManager.EndSoulLimiter -= value;
    }

    public static event ILContext.Manipulator UpdateGameMap
    {
        add => IL.GameManager.UpdateGameMap += value;
        remove => IL.GameManager.UpdateGameMap -= value;
    }

    public static event ILContext.Manipulator CheckAllMaps
    {
        add => IL.GameManager.CheckAllMaps += value;
        remove => IL.GameManager.CheckAllMaps -= value;
    }

    public static event ILContext.Manipulator AddToScenesVisited
    {
        add => IL.GameManager.AddToScenesVisited += value;
        remove => IL.GameManager.AddToScenesVisited -= value;
    }

    public static event ILContext.Manipulator GetIsSceneVisited
    {
        add => IL.GameManager.GetIsSceneVisited += value;
        remove => IL.GameManager.GetIsSceneVisited -= value;
    }

    public static event ILContext.Manipulator AddToBenchList
    {
        add => IL.GameManager.AddToBenchList += value;
        remove => IL.GameManager.AddToBenchList -= value;
    }

    public static event ILContext.Manipulator AddToGrubList
    {
        add => IL.GameManager.AddToGrubList += value;
        remove => IL.GameManager.AddToGrubList -= value;
    }

    public static event ILContext.Manipulator AddToFlameList
    {
        add => IL.GameManager.AddToFlameList += value;
        remove => IL.GameManager.AddToFlameList -= value;
    }

    public static event ILContext.Manipulator AddToCocoonList
    {
        add => IL.GameManager.AddToCocoonList += value;
        remove => IL.GameManager.AddToCocoonList -= value;
    }

    public static event ILContext.Manipulator AddToDreamPlantList
    {
        add => IL.GameManager.AddToDreamPlantList += value;
        remove => IL.GameManager.AddToDreamPlantList -= value;
    }

    public static event ILContext.Manipulator AddToDreamPlantCList
    {
        add => IL.GameManager.AddToDreamPlantCList += value;
        remove => IL.GameManager.AddToDreamPlantCList -= value;
    }

    public static event ILContext.Manipulator CountGameCompletion
    {
        add => IL.GameManager.CountGameCompletion += value;
        remove => IL.GameManager.CountGameCompletion -= value;
    }

    public static event ILContext.Manipulator CountCharms
    {
        add => IL.GameManager.CountCharms += value;
        remove => IL.GameManager.CountCharms -= value;
    }

    public static event ILContext.Manipulator CountJournalEntries
    {
        add => IL.GameManager.CountJournalEntries += value;
        remove => IL.GameManager.CountJournalEntries -= value;
    }

    public static event ILContext.Manipulator ActivateTestingCheats
    {
        add => IL.GameManager.ActivateTestingCheats += value;
        remove => IL.GameManager.ActivateTestingCheats -= value;
    }

    public static event ILContext.Manipulator GetAllPowerups
    {
        add => IL.GameManager.GetAllPowerups += value;
        remove => IL.GameManager.GetAllPowerups -= value;
    }

    public static event ILContext.Manipulator StoryRecord_death
    {
        add => IL.GameManager.StoryRecord_death += value;
        remove => IL.GameManager.StoryRecord_death -= value;
    }

    public static event ILContext.Manipulator StoryRecord_rescueGrub
    {
        add => IL.GameManager.StoryRecord_rescueGrub += value;
        remove => IL.GameManager.StoryRecord_rescueGrub -= value;
    }

    public static event ILContext.Manipulator StoryRecord_defeatedShade
    {
        add => IL.GameManager.StoryRecord_defeatedShade += value;
        remove => IL.GameManager.StoryRecord_defeatedShade -= value;
    }

    public static event ILContext.Manipulator StoryRecord_discoveredArea
    {
        add => IL.GameManager.StoryRecord_discoveredArea += value;
        remove => IL.GameManager.StoryRecord_discoveredArea -= value;
    }

    public static event ILContext.Manipulator StoryRecord_travelledToArea
    {
        add => IL.GameManager.StoryRecord_travelledToArea += value;
        remove => IL.GameManager.StoryRecord_travelledToArea -= value;
    }

    public static event ILContext.Manipulator StoryRecord_bankDeposit
    {
        add => IL.GameManager.StoryRecord_bankDeposit += value;
        remove => IL.GameManager.StoryRecord_bankDeposit -= value;
    }

    public static event ILContext.Manipulator StoryRecord_bankWithdraw
    {
        add => IL.GameManager.StoryRecord_bankWithdraw += value;
        remove => IL.GameManager.StoryRecord_bankWithdraw -= value;
    }

    public static event ILContext.Manipulator StoryRecord_boughtCorniferMap
    {
        add => IL.GameManager.StoryRecord_boughtCorniferMap += value;
        remove => IL.GameManager.StoryRecord_boughtCorniferMap -= value;
    }

    public static event ILContext.Manipulator StoryRecord_visited
    {
        add => IL.GameManager.StoryRecord_visited += value;
        remove => IL.GameManager.StoryRecord_visited -= value;
    }

    public static event ILContext.Manipulator StoryRecord_defeated
    {
        add => IL.GameManager.StoryRecord_defeated += value;
        remove => IL.GameManager.StoryRecord_defeated -= value;
    }

    public static event ILContext.Manipulator StoryRecord_jiji
    {
        add => IL.GameManager.StoryRecord_jiji += value;
        remove => IL.GameManager.StoryRecord_jiji -= value;
    }

    public static event ILContext.Manipulator StoryRecord_rodeStag
    {
        add => IL.GameManager.StoryRecord_rodeStag += value;
        remove => IL.GameManager.StoryRecord_rodeStag -= value;
    }

    public static event ILContext.Manipulator StoryRecord_acquired
    {
        add => IL.GameManager.StoryRecord_acquired += value;
        remove => IL.GameManager.StoryRecord_acquired -= value;
    }

    public static event ILContext.Manipulator StoryRecord_bought
    {
        add => IL.GameManager.StoryRecord_bought += value;
        remove => IL.GameManager.StoryRecord_bought -= value;
    }

    public static event ILContext.Manipulator StoryRecord_quit
    {
        add => IL.GameManager.StoryRecord_quit += value;
        remove => IL.GameManager.StoryRecord_quit -= value;
    }

    public static event ILContext.Manipulator StoryRecord_rest
    {
        add => IL.GameManager.StoryRecord_rest += value;
        remove => IL.GameManager.StoryRecord_rest -= value;
    }

    public static event ILContext.Manipulator StoryRecord_upgradeNail
    {
        add => IL.GameManager.StoryRecord_upgradeNail += value;
        remove => IL.GameManager.StoryRecord_upgradeNail -= value;
    }

    public static event ILContext.Manipulator StoryRecord_heartPiece
    {
        add => IL.GameManager.StoryRecord_heartPiece += value;
        remove => IL.GameManager.StoryRecord_heartPiece -= value;
    }

    public static event ILContext.Manipulator StoryRecord_maxHealthUp
    {
        add => IL.GameManager.StoryRecord_maxHealthUp += value;
        remove => IL.GameManager.StoryRecord_maxHealthUp -= value;
    }

    public static event ILContext.Manipulator StoryRecord_soulPiece
    {
        add => IL.GameManager.StoryRecord_soulPiece += value;
        remove => IL.GameManager.StoryRecord_soulPiece -= value;
    }

    public static event ILContext.Manipulator StoryRecord_maxSoulUp
    {
        add => IL.GameManager.StoryRecord_maxSoulUp += value;
        remove => IL.GameManager.StoryRecord_maxSoulUp -= value;
    }

    public static event ILContext.Manipulator StoryRecord_charmsChanged
    {
        add => IL.GameManager.StoryRecord_charmsChanged += value;
        remove => IL.GameManager.StoryRecord_charmsChanged -= value;
    }

    public static event ILContext.Manipulator StoryRecord_charmEquipped
    {
        add => IL.GameManager.StoryRecord_charmEquipped += value;
        remove => IL.GameManager.StoryRecord_charmEquipped -= value;
    }

    public static event ILContext.Manipulator StoryRecord_start
    {
        add => IL.GameManager.StoryRecord_start += value;
        remove => IL.GameManager.StoryRecord_start -= value;
    }

    public static event ILContext.Manipulator AwardAchievement
    {
        add => IL.GameManager.AwardAchievement += value;
        remove => IL.GameManager.AwardAchievement -= value;
    }

    public static event ILContext.Manipulator QueueAchievement
    {
        add => IL.GameManager.QueueAchievement += value;
        remove => IL.GameManager.QueueAchievement -= value;
    }

    public static event ILContext.Manipulator AwardQueuedAchievements
    {
        add => IL.GameManager.AwardQueuedAchievements += value;
        remove => IL.GameManager.AwardQueuedAchievements -= value;
    }

    public static event ILContext.Manipulator IsAchievementAwarded
    {
        add => IL.GameManager.IsAchievementAwarded += value;
        remove => IL.GameManager.IsAchievementAwarded -= value;
    }

    public static event ILContext.Manipulator ClearAllAchievements
    {
        add => IL.GameManager.ClearAllAchievements += value;
        remove => IL.GameManager.ClearAllAchievements -= value;
    }

    public static event ILContext.Manipulator CheckCharmAchievements
    {
        add => IL.GameManager.CheckCharmAchievements += value;
        remove => IL.GameManager.CheckCharmAchievements -= value;
    }

    public static event ILContext.Manipulator CheckGrubAchievements
    {
        add => IL.GameManager.CheckGrubAchievements += value;
        remove => IL.GameManager.CheckGrubAchievements -= value;
    }

    public static event ILContext.Manipulator CheckStagStationAchievements
    {
        add => IL.GameManager.CheckStagStationAchievements += value;
        remove => IL.GameManager.CheckStagStationAchievements -= value;
    }

    public static event ILContext.Manipulator CheckMapAchievement
    {
        add => IL.GameManager.CheckMapAchievement += value;
        remove => IL.GameManager.CheckMapAchievement -= value;
    }

    public static event ILContext.Manipulator CheckJournalAchievements
    {
        add => IL.GameManager.CheckJournalAchievements += value;
        remove => IL.GameManager.CheckJournalAchievements -= value;
    }

    public static event ILContext.Manipulator CheckAllAchievements
    {
        add => IL.GameManager.CheckAllAchievements += value;
        remove => IL.GameManager.CheckAllAchievements -= value;
    }

    public static event ILContext.Manipulator CheckBanishmentAchievement
    {
        add => IL.GameManager.CheckBanishmentAchievement += value;
        remove => IL.GameManager.CheckBanishmentAchievement -= value;
    }

    public static event ILContext.Manipulator SetStatusRecordInt
    {
        add => IL.GameManager.SetStatusRecordInt += value;
        remove => IL.GameManager.SetStatusRecordInt -= value;
    }

    public static event ILContext.Manipulator GetStatusRecordInt
    {
        add => IL.GameManager.GetStatusRecordInt += value;
        remove => IL.GameManager.GetStatusRecordInt -= value;
    }

    public static event ILContext.Manipulator ResetStatusRecords
    {
        add => IL.GameManager.ResetStatusRecords += value;
        remove => IL.GameManager.ResetStatusRecords -= value;
    }

    public static event ILContext.Manipulator SaveStatusRecords
    {
        add => IL.GameManager.SaveStatusRecords += value;
        remove => IL.GameManager.SaveStatusRecords -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.GameManager.SetState += value;
        remove => IL.GameManager.SetState -= value;
    }

    public static event ILContext.Manipulator LoadScene
    {
        add => IL.GameManager.LoadScene += value;
        remove => IL.GameManager.LoadScene -= value;
    }

    public static event ILContext.Manipulator LoadSceneAdditive
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "LoadSceneAdditive").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "LoadSceneAdditive").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnNextLevelReady
    {
        add => IL.GameManager.OnNextLevelReady += value;
        remove => IL.GameManager.OnNextLevelReady -= value;
    }

    public static event ILContext.Manipulator OnWillActivateFirstLevel
    {
        add => IL.GameManager.OnWillActivateFirstLevel += value;
        remove => IL.GameManager.OnWillActivateFirstLevel -= value;
    }

    public static event ILContext.Manipulator LoadFirstScene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "LoadFirstScene").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "LoadFirstScene").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LoadPermadeathUnlockScene
    {
        add => IL.GameManager.LoadPermadeathUnlockScene += value;
        remove => IL.GameManager.LoadPermadeathUnlockScene -= value;
    }

    public static event ILContext.Manipulator LoadMrMushromScene
    {
        add => IL.GameManager.LoadMrMushromScene += value;
        remove => IL.GameManager.LoadMrMushromScene -= value;
    }

    public static event ILContext.Manipulator LoadOpeningCinematic
    {
        add => IL.GameManager.LoadOpeningCinematic += value;
        remove => IL.GameManager.LoadOpeningCinematic -= value;
    }

    public static event ILContext.Manipulator PositionHeroAtSceneEntrance
    {
        add => IL.GameManager.PositionHeroAtSceneEntrance += value;
        remove => IL.GameManager.PositionHeroAtSceneEntrance -= value;
    }

    public static event ILContext.Manipulator FindEntryPoint
    {
        add => IL.GameManager.FindEntryPoint += value;
        remove => IL.GameManager.FindEntryPoint -= value;
    }

    public static event ILContext.Manipulator FindTransitionPoint
    {
        add => IL.GameManager.FindTransitionPoint += value;
        remove => IL.GameManager.FindTransitionPoint -= value;
    }

    public static event ILContext.Manipulator EnterHero
    {
        add => IL.GameManager.EnterHero += value;
        remove => IL.GameManager.EnterHero -= value;
    }

    public static event ILContext.Manipulator FinishedEnteringScene
    {
        add => IL.GameManager.FinishedEnteringScene += value;
        remove => IL.GameManager.FinishedEnteringScene -= value;
    }

    public static event ILContext.Manipulator SetupGameRefs
    {
        add => IL.GameManager.SetupGameRefs += value;
        remove => IL.GameManager.SetupGameRefs -= value;
    }

    public static event ILContext.Manipulator SetupSceneRefs
    {
        add => IL.GameManager.SetupSceneRefs += value;
        remove => IL.GameManager.SetupSceneRefs -= value;
    }

    public static event ILContext.Manipulator SetupHeroRefs
    {
        add => IL.GameManager.SetupHeroRefs += value;
        remove => IL.GameManager.SetupHeroRefs -= value;
    }

    public static event ILContext.Manipulator BeginScene
    {
        add => IL.GameManager.BeginScene += value;
        remove => IL.GameManager.BeginScene -= value;
    }

    public static event ILContext.Manipulator UpdateUIStateFromGameState
    {
        add => IL.GameManager.UpdateUIStateFromGameState += value;
        remove => IL.GameManager.UpdateUIStateFromGameState -= value;
    }

    public static event ILContext.Manipulator SkipCutscene
    {
        add => IL.GameManager.SkipCutscene += value;
        remove => IL.GameManager.SkipCutscene -= value;
    }

    public static event ILContext.Manipulator SkipCutsceneNoMash
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "SkipCutsceneNoMash").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "SkipCutsceneNoMash").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator NoLongerFirstGame
    {
        add => IL.GameManager.NoLongerFirstGame += value;
        remove => IL.GameManager.NoLongerFirstGame -= value;
    }

    public static event ILContext.Manipulator SetupStatusModifiers
    {
        add => IL.GameManager.SetupStatusModifiers += value;
        remove => IL.GameManager.SetupStatusModifiers -= value;
    }

    public static event ILContext.Manipulator MatchBackerCreditsSetting
    {
        add => IL.GameManager.MatchBackerCreditsSetting += value;
        remove => IL.GameManager.MatchBackerCreditsSetting -= value;
    }

    public static event ILContext.Manipulator RefreshLocalization
    {
        add => IL.GameManager.RefreshLocalization += value;
        remove => IL.GameManager.RefreshLocalization -= value;
    }

    public static event ILContext.Manipulator RefreshParticleSystems
    {
        add => IL.GameManager.RefreshParticleSystems += value;
        remove => IL.GameManager.RefreshParticleSystems -= value;
    }

    public static event ILContext.Manipulator ApplyNativeInput
    {
        add => IL.GameManager.ApplyNativeInput += value;
        remove => IL.GameManager.ApplyNativeInput -= value;
    }

    public static event ILContext.Manipulator EnablePermadeathMode
    {
        add => IL.GameManager.EnablePermadeathMode += value;
        remove => IL.GameManager.EnablePermadeathMode -= value;
    }

    public static event ILContext.Manipulator GetCurrentMapZone
    {
        add => IL.GameManager.GetCurrentMapZone += value;
        remove => IL.GameManager.GetCurrentMapZone -= value;
    }

    public static event ILContext.Manipulator GetSceneWidth
    {
        add => IL.GameManager.GetSceneWidth += value;
        remove => IL.GameManager.GetSceneWidth -= value;
    }

    public static event ILContext.Manipulator GetSceneHeight
    {
        add => IL.GameManager.GetSceneHeight += value;
        remove => IL.GameManager.GetSceneHeight -= value;
    }

    public static event ILContext.Manipulator GetSceneManager
    {
        add => IL.GameManager.GetSceneManager += value;
        remove => IL.GameManager.GetSceneManager -= value;
    }

    public static event ILContext.Manipulator GetFormattedMapZoneString
    {
        add => IL.GameManager.GetFormattedMapZoneString += value;
        remove => IL.GameManager.GetFormattedMapZoneString -= value;
    }

    public static event ILContext.Manipulator UpdateSceneName
    {
        add => IL.GameManager.UpdateSceneName += value;
        remove => IL.GameManager.UpdateSceneName -= value;
    }

    public static event ILContext.Manipulator GetBaseSceneName
    {
        add => IL.GameManager.GetBaseSceneName += value;
        remove => IL.GameManager.GetBaseSceneName -= value;
    }

    public static event ILContext.Manipulator GetSceneNameString
    {
        add => IL.GameManager.GetSceneNameString += value;
        remove => IL.GameManager.GetSceneNameString -= value;
    }

    public static event ILContext.Manipulator GetTileMap
    {
        add => IL.GameManager.GetTileMap += value;
        remove => IL.GameManager.GetTileMap -= value;
    }

    public static event ILContext.Manipulator RefreshTilemapInfo
    {
        add => IL.GameManager.RefreshTilemapInfo += value;
        remove => IL.GameManager.RefreshTilemapInfo -= value;
    }

    public static event ILContext.Manipulator SaveLevelState
    {
        add => IL.GameManager.SaveLevelState += value;
        remove => IL.GameManager.SaveLevelState -= value;
    }

    public static event ILContext.Manipulator ResetSemiPersistentItems
    {
        add => IL.GameManager.ResetSemiPersistentItems += value;
        remove => IL.GameManager.ResetSemiPersistentItems -= value;
    }

    public static event ILContext.Manipulator IsMenuScene
    {
        add => IL.GameManager.IsMenuScene += value;
        remove => IL.GameManager.IsMenuScene -= value;
    }

    public static event ILContext.Manipulator IsTitleScreenScene
    {
        add => IL.GameManager.IsTitleScreenScene += value;
        remove => IL.GameManager.IsTitleScreenScene -= value;
    }

    public static event ILContext.Manipulator IsGameplayScene
    {
        add => IL.GameManager.IsGameplayScene += value;
        remove => IL.GameManager.IsGameplayScene -= value;
    }

    public static event ILContext.Manipulator IsNonGameplayScene
    {
        add => IL.GameManager.IsNonGameplayScene += value;
        remove => IL.GameManager.IsNonGameplayScene -= value;
    }

    public static event ILContext.Manipulator IsCinematicScene
    {
        add => IL.GameManager.IsCinematicScene += value;
        remove => IL.GameManager.IsCinematicScene -= value;
    }

    public static event ILContext.Manipulator IsStagTravelScene
    {
        add => IL.GameManager.IsStagTravelScene += value;
        remove => IL.GameManager.IsStagTravelScene -= value;
    }

    public static event ILContext.Manipulator IsBetaEndScene
    {
        add => IL.GameManager.IsBetaEndScene += value;
        remove => IL.GameManager.IsBetaEndScene -= value;
    }

    public static event ILContext.Manipulator IsTutorialScene
    {
        add => IL.GameManager.IsTutorialScene += value;
        remove => IL.GameManager.IsTutorialScene -= value;
    }

    public static event ILContext.Manipulator IsTestScene
    {
        add => IL.GameManager.IsTestScene += value;
        remove => IL.GameManager.IsTestScene -= value;
    }

    public static event ILContext.Manipulator IsBossDoorScene
    {
        add => IL.GameManager.IsBossDoorScene += value;
        remove => IL.GameManager.IsBossDoorScene -= value;
    }

    public static event ILContext.Manipulator ShouldKeepHUDCameraActive
    {
        add => IL.GameManager.ShouldKeepHUDCameraActive += value;
        remove => IL.GameManager.ShouldKeepHUDCameraActive -= value;
    }

    public static event ILContext.Manipulator GetSceneZoneName
    {
        add => IL.GameManager.GetSceneZoneName += value;
        remove => IL.GameManager.GetSceneZoneName -= value;
    }

    public static event ILContext.Manipulator CountBits
    {
        add => IL.GameManager.CountBits += value;
        remove => IL.GameManager.CountBits -= value;
    }

    public static event ILContext.Manipulator IsUnloadAssetsRequired
    {
        add => IL.GameManager.IsUnloadAssetsRequired += value;
        remove => IL.GameManager.IsUnloadAssetsRequired -= value;
    }

    public static event ILContext.Manipulator HasSaveFile
    {
        add => IL.GameManager.HasSaveFile += value;
        remove => IL.GameManager.HasSaveFile -= value;
    }

    public static event ILContext.Manipulator SaveGame
    {
        add => IL.GameManager.SaveGame += value;
        remove => IL.GameManager.SaveGame -= value;
    }

    public static event ILContext.Manipulator ShowSaveIcon
    {
        add => IL.GameManager.ShowSaveIcon += value;
        remove => IL.GameManager.ShowSaveIcon -= value;
    }

    public static event ILContext.Manipulator HideSaveIcon
    {
        add => IL.GameManager.HideSaveIcon += value;
        remove => IL.GameManager.HideSaveIcon -= value;
    }

    public static event ILContext.Manipulator SaveGame_Action
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "SaveGame"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "SaveGame"), value);
    }

    public static event ILContext.Manipulator ResetGameTimer
    {
        add => IL.GameManager.ResetGameTimer += value;
        remove => IL.GameManager.ResetGameTimer -= value;
    }

    public static event ILContext.Manipulator IncreaseGameTimer
    {
        add => IL.GameManager.IncreaseGameTimer += value;
        remove => IL.GameManager.IncreaseGameTimer -= value;
    }

    public static event ILContext.Manipulator SaveGame_int_Action
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "SaveGame"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "SaveGame"), value);
    }

    public static event ILContext.Manipulator LoadGameFromUI
    {
        add => IL.GameManager.LoadGameFromUI += value;
        remove => IL.GameManager.LoadGameFromUI -= value;
    }

    public static event ILContext.Manipulator LoadGameFromUIRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "LoadGameFromUIRoutine").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "LoadGameFromUIRoutine").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator LoadGame
    {
        add => IL.GameManager.LoadGame += value;
        remove => IL.GameManager.LoadGame -= value;
    }

    public static event ILContext.Manipulator ClearSaveFile
    {
        add => IL.GameManager.ClearSaveFile += value;
        remove => IL.GameManager.ClearSaveFile -= value;
    }

    public static event ILContext.Manipulator GetSaveStatsForSlot
    {
        add => IL.GameManager.GetSaveStatsForSlot += value;
        remove => IL.GameManager.GetSaveStatsForSlot -= value;
    }

    public static event ILContext.Manipulator PauseGameToggleByMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PauseGameToggleByMenu").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PauseGameToggleByMenu").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator PauseGameToggle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PauseGameToggle").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PauseGameToggle").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetTimeScale_float_float
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "SetTimeScale").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "SetTimeScale").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetTimeScale_float
    {
        add => IL.GameManager.SetTimeScale_float += value;
        remove => IL.GameManager.SetTimeScale_float -= value;
    }

    public static event ILContext.Manipulator FreezeMoment_int
    {
        add => IL.GameManager.FreezeMoment_int += value;
        remove => IL.GameManager.FreezeMoment_int -= value;
    }

    public static event ILContext.Manipulator FreezeMoment_float_float_float_float
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FreezeMoment").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FreezeMoment").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FreezeMomentGC
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FreezeMomentGC").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FreezeMomentGC").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FreezeMoment_float_float_float_bool
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FreezeMoment").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "FreezeMoment").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator EnsureSaveSlotSpace
    {
        add => IL.GameManager.EnsureSaveSlotSpace += value;
        remove => IL.GameManager.EnsureSaveSlotSpace -= value;
    }

    public static event ILContext.Manipulator StartNewGame
    {
        add => IL.GameManager.StartNewGame += value;
        remove => IL.GameManager.StartNewGame -= value;
    }

    public static event ILContext.Manipulator RunStartNewGame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "RunStartNewGame").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "RunStartNewGame").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ContinueGame
    {
        add => IL.GameManager.ContinueGame += value;
        remove => IL.GameManager.ContinueGame -= value;
    }

    public static event ILContext.Manipulator RunContinueGame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "RunContinueGame").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "RunContinueGame").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator WillTerminateInBackground
    {
        add => IL.GameManager.WillTerminateInBackground += value;
        remove => IL.GameManager.WillTerminateInBackground -= value;
    }

    public static event ILContext.Manipulator OnDisengage
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "Platform.IDisengageHandler.OnDisengage"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "Platform.IDisengageHandler.OnDisengage"), value);
    }

    public static event ILContext.Manipulator EmergencyReturnToMenu
    {
        add => IL.GameManager.EmergencyReturnToMenu += value;
        remove => IL.GameManager.EmergencyReturnToMenu -= value;
    }

    public static event ILContext.Manipulator QuitGame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "QuitGame").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "QuitGame").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LoadedBoss
    {
        add => IL.GameManager.LoadedBoss += value;
        remove => IL.GameManager.LoadedBoss -= value;
    }

    public static event ILContext.Manipulator DoDestroyPersonalPools
    {
        add => IL.GameManager.DoDestroyPersonalPools += value;
        remove => IL.GameManager.DoDestroyPersonalPools -= value;
    }

    public static event ILContext.Manipulator GetImplicitCinematicVolume
    {
        add => IL.GameManager.GetImplicitCinematicVolume += value;
        remove => IL.GameManager.GetImplicitCinematicVolume -= value;
    }

    public static event ILContext.Manipulator orig_get_ui
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_get_ui"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_get_ui"),
            value);
    }

    public static event ILContext.Manipulator orig_set_ui
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_set_ui"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_set_ui"),
            value);
    }

    public static event ILContext.Manipulator orig_OnApplicationQuit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_OnApplicationQuit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_OnApplicationQuit"), value);
    }

    public static event ILContext.Manipulator orig_LoadScene
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_LoadScene"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_LoadScene"),
            value);
    }

    public static event ILContext.Manipulator orig_ClearSaveFile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_ClearSaveFile"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_ClearSaveFile"), value);
    }

    public static event ILContext.Manipulator orig_PlayerDead
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_PlayerDead").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_PlayerDead").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ModdedSavePath
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "ModdedSavePath", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "ModdedSavePath", false), value);
    }

    public static event ILContext.Manipulator orig_SetupSceneRefs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_SetupSceneRefs"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_SetupSceneRefs"), value);
    }

    public static event ILContext.Manipulator orig_OnWillActivateFirstLevel
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_OnWillActivateFirstLevel"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "orig_OnWillActivateFirstLevel"), value);
    }

    public static event ILContext.Manipulator PauseToggleDynamicMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PauseToggleDynamicMenu").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameManager), "PauseToggleDynamicMenu").GetStateMachineTarget(),
            value);
    }
}