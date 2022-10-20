using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayerData.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayerData
{
    public static event ILContext.Manipulator InitMapBools
    {
        add => IL.PlayerData.InitMapBools += value;
        remove => IL.PlayerData.InitMapBools -= value;
    }

    public static event ILContext.Manipulator HasMapForScene
    {
        add => IL.PlayerData.HasMapForScene += value;
        remove => IL.PlayerData.HasMapForScene -= value;
    }

    public static event ILContext.Manipulator get_CurrentMaxHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "get_CurrentMaxHealth"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerData), "get_CurrentMaxHealth"), value);
    }

    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerData), "get_instance", false), value);
    }

    public static event ILContext.Manipulator set_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "set_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerData), "set_instance", false), value);
    }

    public static event ILContext.Manipulator PrintStory
    {
        add => IL.PlayerData.PrintStory += value;
        remove => IL.PlayerData.PrintStory -= value;
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.PlayerData.Reset += value;
        remove => IL.PlayerData.Reset -= value;
    }

    public static event ILContext.Manipulator UpdateGameMap
    {
        add => IL.PlayerData.UpdateGameMap += value;
        remove => IL.PlayerData.UpdateGameMap -= value;
    }

    public static event ILContext.Manipulator CheckAllMaps
    {
        add => IL.PlayerData.CheckAllMaps += value;
        remove => IL.PlayerData.CheckAllMaps -= value;
    }

    public static event ILContext.Manipulator SetBool
    {
        add => IL.PlayerData.SetBool += value;
        remove => IL.PlayerData.SetBool -= value;
    }

    public static event ILContext.Manipulator SetInt
    {
        add => IL.PlayerData.SetInt += value;
        remove => IL.PlayerData.SetInt -= value;
    }

    public static event ILContext.Manipulator IncrementInt
    {
        add => IL.PlayerData.IncrementInt += value;
        remove => IL.PlayerData.IncrementInt -= value;
    }

    public static event ILContext.Manipulator IntAdd
    {
        add => IL.PlayerData.IntAdd += value;
        remove => IL.PlayerData.IntAdd -= value;
    }

    public static event ILContext.Manipulator SetFloat
    {
        add => IL.PlayerData.SetFloat += value;
        remove => IL.PlayerData.SetFloat -= value;
    }

    public static event ILContext.Manipulator DecrementInt
    {
        add => IL.PlayerData.DecrementInt += value;
        remove => IL.PlayerData.DecrementInt -= value;
    }

    public static event ILContext.Manipulator GetBool
    {
        add => IL.PlayerData.GetBool += value;
        remove => IL.PlayerData.GetBool -= value;
    }

    public static event ILContext.Manipulator GetInt
    {
        add => IL.PlayerData.GetInt += value;
        remove => IL.PlayerData.GetInt -= value;
    }

    public static event ILContext.Manipulator GetFloat
    {
        add => IL.PlayerData.GetFloat += value;
        remove => IL.PlayerData.GetFloat -= value;
    }

    public static event ILContext.Manipulator GetString
    {
        add => IL.PlayerData.GetString += value;
        remove => IL.PlayerData.GetString -= value;
    }

    public static event ILContext.Manipulator SetString
    {
        add => IL.PlayerData.SetString += value;
        remove => IL.PlayerData.SetString -= value;
    }

    public static event ILContext.Manipulator SetVector3
    {
        add => IL.PlayerData.SetVector3 += value;
        remove => IL.PlayerData.SetVector3 -= value;
    }

    public static event ILContext.Manipulator GetVector3
    {
        add => IL.PlayerData.GetVector3 += value;
        remove => IL.PlayerData.GetVector3 -= value;
    }

    public static event ILContext.Manipulator AddHealth
    {
        add => IL.PlayerData.AddHealth += value;
        remove => IL.PlayerData.AddHealth -= value;
    }

    public static event ILContext.Manipulator TakeHealth
    {
        add => IL.PlayerData.TakeHealth += value;
        remove => IL.PlayerData.TakeHealth -= value;
    }

    public static event ILContext.Manipulator MaxHealth
    {
        add => IL.PlayerData.MaxHealth += value;
        remove => IL.PlayerData.MaxHealth -= value;
    }

    public static event ILContext.Manipulator ActivateTestingCheats
    {
        add => IL.PlayerData.ActivateTestingCheats += value;
        remove => IL.PlayerData.ActivateTestingCheats -= value;
    }

    public static event ILContext.Manipulator GetAllPowerups
    {
        add => IL.PlayerData.GetAllPowerups += value;
        remove => IL.PlayerData.GetAllPowerups -= value;
    }

    public static event ILContext.Manipulator AddToMaxHealth
    {
        add => IL.PlayerData.AddToMaxHealth += value;
        remove => IL.PlayerData.AddToMaxHealth -= value;
    }

    public static event ILContext.Manipulator UpdateBlueHealth
    {
        add => IL.PlayerData.UpdateBlueHealth += value;
        remove => IL.PlayerData.UpdateBlueHealth -= value;
    }

    public static event ILContext.Manipulator AddGeo
    {
        add => IL.PlayerData.AddGeo += value;
        remove => IL.PlayerData.AddGeo -= value;
    }

    public static event ILContext.Manipulator TakeGeo
    {
        add => IL.PlayerData.TakeGeo += value;
        remove => IL.PlayerData.TakeGeo -= value;
    }

    public static event ILContext.Manipulator WouldDie
    {
        add => IL.PlayerData.WouldDie += value;
        remove => IL.PlayerData.WouldDie -= value;
    }

    public static event ILContext.Manipulator AddMPCharge
    {
        add => IL.PlayerData.AddMPCharge += value;
        remove => IL.PlayerData.AddMPCharge -= value;
    }

    public static event ILContext.Manipulator TakeMP
    {
        add => IL.PlayerData.TakeMP += value;
        remove => IL.PlayerData.TakeMP -= value;
    }

    public static event ILContext.Manipulator TakeReserveMP
    {
        add => IL.PlayerData.TakeReserveMP += value;
        remove => IL.PlayerData.TakeReserveMP -= value;
    }

    public static event ILContext.Manipulator ClearMP
    {
        add => IL.PlayerData.ClearMP += value;
        remove => IL.PlayerData.ClearMP -= value;
    }

    public static event ILContext.Manipulator AddToMaxMPReserve
    {
        add => IL.PlayerData.AddToMaxMPReserve += value;
        remove => IL.PlayerData.AddToMaxMPReserve -= value;
    }

    public static event ILContext.Manipulator StartSoulLimiter
    {
        add => IL.PlayerData.StartSoulLimiter += value;
        remove => IL.PlayerData.StartSoulLimiter -= value;
    }

    public static event ILContext.Manipulator EndSoulLimiter
    {
        add => IL.PlayerData.EndSoulLimiter += value;
        remove => IL.PlayerData.EndSoulLimiter -= value;
    }

    public static event ILContext.Manipulator EquipCharm
    {
        add => IL.PlayerData.EquipCharm += value;
        remove => IL.PlayerData.EquipCharm -= value;
    }

    public static event ILContext.Manipulator UnequipCharm
    {
        add => IL.PlayerData.UnequipCharm += value;
        remove => IL.PlayerData.UnequipCharm -= value;
    }

    public static event ILContext.Manipulator CalculateNotchesUsed
    {
        add => IL.PlayerData.CalculateNotchesUsed += value;
        remove => IL.PlayerData.CalculateNotchesUsed -= value;
    }

    public static event ILContext.Manipulator SetBenchRespawn_RespawnMarker_string_int
    {
        add => IL.PlayerData.SetBenchRespawn_RespawnMarker_string_int += value;
        remove => IL.PlayerData.SetBenchRespawn_RespawnMarker_string_int -= value;
    }

    public static event ILContext.Manipulator SetBenchRespawn_string_string_bool
    {
        add => IL.PlayerData.SetBenchRespawn_string_string_bool += value;
        remove => IL.PlayerData.SetBenchRespawn_string_string_bool -= value;
    }

    public static event ILContext.Manipulator SetBenchRespawn_string_string_int_bool
    {
        add => IL.PlayerData.SetBenchRespawn_string_string_int_bool += value;
        remove => IL.PlayerData.SetBenchRespawn_string_string_int_bool -= value;
    }

    public static event ILContext.Manipulator SetHazardRespawn_HazardRespawnMarker
    {
        add => IL.PlayerData.SetHazardRespawn_HazardRespawnMarker += value;
        remove => IL.PlayerData.SetHazardRespawn_HazardRespawnMarker -= value;
    }

    public static event ILContext.Manipulator SetHazardRespawn_Vector3_bool
    {
        add => IL.PlayerData.SetHazardRespawn_Vector3_bool += value;
        remove => IL.PlayerData.SetHazardRespawn_Vector3_bool -= value;
    }

    public static event ILContext.Manipulator CountGameCompletion
    {
        add => IL.PlayerData.CountGameCompletion += value;
        remove => IL.PlayerData.CountGameCompletion -= value;
    }

    public static event ILContext.Manipulator CountCharms
    {
        add => IL.PlayerData.CountCharms += value;
        remove => IL.PlayerData.CountCharms -= value;
    }

    public static event ILContext.Manipulator CountJournalEntries
    {
        add => IL.PlayerData.CountJournalEntries += value;
        remove => IL.PlayerData.CountJournalEntries -= value;
    }

    public static event ILContext.Manipulator SetupNewPlayerData
    {
        add => IL.PlayerData.SetupNewPlayerData += value;
        remove => IL.PlayerData.SetupNewPlayerData -= value;
    }

    public static event ILContext.Manipulator AddGGPlayerDataOverrides
    {
        add => IL.PlayerData.AddGGPlayerDataOverrides += value;
        remove => IL.PlayerData.AddGGPlayerDataOverrides -= value;
    }

    public static event ILContext.Manipulator SetBoolSwappedArgs
    {
        add => IL.PlayerData.SetBoolSwappedArgs += value;
        remove => IL.PlayerData.SetBoolSwappedArgs -= value;
    }

    public static event ILContext.Manipulator SetFloatSwappedArgs
    {
        add => IL.PlayerData.SetFloatSwappedArgs += value;
        remove => IL.PlayerData.SetFloatSwappedArgs -= value;
    }

    public static event ILContext.Manipulator SetIntSwappedArgs
    {
        add => IL.PlayerData.SetIntSwappedArgs += value;
        remove => IL.PlayerData.SetIntSwappedArgs -= value;
    }

    public static event ILContext.Manipulator SetStringSwappedArgs
    {
        add => IL.PlayerData.SetStringSwappedArgs += value;
        remove => IL.PlayerData.SetStringSwappedArgs -= value;
    }

    public static event ILContext.Manipulator SetVector3SwappedArgs
    {
        add => IL.PlayerData.SetVector3SwappedArgs += value;
        remove => IL.PlayerData.SetVector3SwappedArgs -= value;
    }

    public static event ILContext.Manipulator SetBoolInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetBoolInternal"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetBoolInternal"),
            value);
    }

    public static event ILContext.Manipulator GetBoolInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetBoolInternal"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetBoolInternal"),
            value);
    }

    public static event ILContext.Manipulator SetIntInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetIntInternal"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetIntInternal"),
            value);
    }

    public static event ILContext.Manipulator GetIntInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetIntInternal"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetIntInternal"),
            value);
    }

    public static event ILContext.Manipulator SetFloatInternal
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetFloatInternal"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetFloatInternal"),
            value);
    }

    public static event ILContext.Manipulator GetFloatInternal
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetFloatInternal"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetFloatInternal"),
            value);
    }

    public static event ILContext.Manipulator SetStringInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetStringInternal"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetStringInternal"),
            value);
    }

    public static event ILContext.Manipulator GetStringInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetStringInternal"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetStringInternal"),
            value);
    }

    public static event ILContext.Manipulator SetVector3Internal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetVector3Internal"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "SetVector3Internal"),
            value);
    }

    public static event ILContext.Manipulator GetVector3Internal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetVector3Internal"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "GetVector3Internal"),
            value);
    }

    public static event ILContext.Manipulator TakeHealthInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "TakeHealthInternal"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "TakeHealthInternal"),
            value);
    }

    public static event ILContext.Manipulator orig_UpdateBlueHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "orig_UpdateBlueHealth"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerData), "orig_UpdateBlueHealth"), value);
    }

    public static event ILContext.Manipulator orig_AddHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "orig_AddHealth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerData), "orig_AddHealth"),
            value);
    }
}