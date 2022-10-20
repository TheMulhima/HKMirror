using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ModHooks.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILModHooks
{
    public static event ILContext.Manipulator get_BuiltModMenuScreens
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "get_BuiltModMenuScreens", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "get_BuiltModMenuScreens", false), value);
    }

    public static event ILContext.Manipulator get_GlobalSettings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "get_GlobalSettings", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "get_GlobalSettings", false), value);
    }

    public static event ILContext.Manipulator set_GlobalSettings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "set_GlobalSettings", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "set_GlobalSettings", false), value);
    }

    public static event ILContext.Manipulator get_Instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "get_Instance", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "get_Instance", false),
            value);
    }

    public static event ILContext.Manipulator LoadGlobalSettings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "LoadGlobalSettings", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "LoadGlobalSettings", false), value);
    }

    public static event ILContext.Manipulator SaveGlobalSettings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SaveGlobalSettings", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SaveGlobalSettings", false), value);
    }

    public static event ILContext.Manipulator LogConsole
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "LogConsole", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "LogConsole", false),
            value);
    }

    public static event ILContext.Manipulator LanguageGet
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "LanguageGet", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "LanguageGet", false),
            value);
    }

    public static event ILContext.Manipulator OnCursor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnCursor", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnCursor", false),
            value);
    }

    public static event ILContext.Manipulator OnColliderCreate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnColliderCreate", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnColliderCreate", false), value);
    }

    public static event ILContext.Manipulator OnObjectPoolSpawn
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnObjectPoolSpawn", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnObjectPoolSpawn", false), value);
    }

    public static event ILContext.Manipulator OnApplicationQuit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnApplicationQuit", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnApplicationQuit", false), value);
    }

    public static event ILContext.Manipulator OnHitInstanceBeforeHit
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnHitInstanceBeforeHit", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnHitInstanceBeforeHit", false), value);
    }

    public static event ILContext.Manipulator OnDrawBlackBorders
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnDrawBlackBorders", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnDrawBlackBorders", false), value);
    }

    public static event ILContext.Manipulator OnEnableEnemy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnEnableEnemy", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnEnableEnemy", false),
            value);
    }

    public static event ILContext.Manipulator OnRecieveDeathEvent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnRecieveDeathEvent", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnRecieveDeathEvent", false), value);
    }

    public static event ILContext.Manipulator OnRecordKillForJournal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnRecordKillForJournal", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnRecordKillForJournal", false), value);
    }

    public static event ILContext.Manipulator SetPlayerBool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerBool", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerBool", false),
            value);
    }

    public static event ILContext.Manipulator GetPlayerBool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerBool", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerBool", false),
            value);
    }

    public static event ILContext.Manipulator SetPlayerInt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerInt", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerInt", false),
            value);
    }

    public static event ILContext.Manipulator GetPlayerInt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerInt", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerInt", false),
            value);
    }

    public static event ILContext.Manipulator SetPlayerFloat
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerFloat", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerFloat", false), value);
    }

    public static event ILContext.Manipulator GetPlayerFloat
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerFloat", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerFloat", false), value);
    }

    public static event ILContext.Manipulator SetPlayerString
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerString", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerString", false), value);
    }

    public static event ILContext.Manipulator GetPlayerString
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerString", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerString", false), value);
    }

    public static event ILContext.Manipulator SetPlayerVector3
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerVector3", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "SetPlayerVector3", false), value);
    }

    public static event ILContext.Manipulator GetPlayerVector3
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerVector3", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetPlayerVector3", false), value);
    }

    public static event ILContext.Manipulator OnBlueHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnBlueHealth", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnBlueHealth", false),
            value);
    }

    public static event ILContext.Manipulator OnTakeHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnTakeHealth", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnTakeHealth", false),
            value);
    }

    public static event ILContext.Manipulator OnTakeDamage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnTakeDamage", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnTakeDamage", false),
            value);
    }

    public static event ILContext.Manipulator AfterTakeDamage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "AfterTakeDamage", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "AfterTakeDamage", false), value);
    }

    public static event ILContext.Manipulator OnBeforePlayerDead
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnBeforePlayerDead", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnBeforePlayerDead", false), value);
    }

    public static event ILContext.Manipulator OnAfterPlayerDead
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAfterPlayerDead", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAfterPlayerDead", false), value);
    }

    public static event ILContext.Manipulator OnAttack
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAttack", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAttack", false),
            value);
    }

    public static event ILContext.Manipulator OnDoAttack
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnDoAttack", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnDoAttack", false),
            value);
    }

    public static event ILContext.Manipulator AfterAttack
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "AfterAttack", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "AfterAttack", false),
            value);
    }

    public static event ILContext.Manipulator OnSlashHit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSlashHit", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSlashHit", false),
            value);
    }

    public static event ILContext.Manipulator OnCharmUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnCharmUpdate", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnCharmUpdate", false),
            value);
    }

    public static event ILContext.Manipulator OnHeroUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnHeroUpdate", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnHeroUpdate", false),
            value);
    }

    public static event ILContext.Manipulator BeforeAddHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "BeforeAddHealth", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "BeforeAddHealth", false), value);
    }

    public static event ILContext.Manipulator OnFocusCost
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnFocusCost", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnFocusCost", false),
            value);
    }

    public static event ILContext.Manipulator OnSoulGain
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSoulGain", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSoulGain", false),
            value);
    }

    public static event ILContext.Manipulator DashVelocityChange
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "DashVelocityChange", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "DashVelocityChange", false), value);
    }

    public static event ILContext.Manipulator OnDashPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnDashPressed", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnDashPressed", false),
            value);
    }

    public static event ILContext.Manipulator OnSavegameLoad
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSavegameLoad", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSavegameLoad", false), value);
    }

    public static event ILContext.Manipulator OnSavegameSave
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSavegameSave", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSavegameSave", false), value);
    }

    public static event ILContext.Manipulator OnNewGame
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnNewGame", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnNewGame", false),
            value);
    }

    public static event ILContext.Manipulator OnSavegameClear
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSavegameClear", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSavegameClear", false), value);
    }

    public static event ILContext.Manipulator OnAfterSaveGameLoad
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAfterSaveGameLoad", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAfterSaveGameLoad", false), value);
    }

    public static event ILContext.Manipulator OnBeforeSaveGameSave
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnBeforeSaveGameSave", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnBeforeSaveGameSave", false), value);
    }

    public static event ILContext.Manipulator GetSaveFileName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetSaveFileName", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetSaveFileName", false), value);
    }

    public static event ILContext.Manipulator OnAfterSaveGameClear
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAfterSaveGameClear", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnAfterSaveGameClear", false), value);
    }

    public static event ILContext.Manipulator OnSceneChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSceneChanged", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnSceneChanged", false), value);
    }

    public static event ILContext.Manipulator BeforeSceneLoad
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "BeforeSceneLoad", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "BeforeSceneLoad", false), value);
    }

    public static event ILContext.Manipulator GetMod_string_bool_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetMod", false), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetMod", false), value);
    }

    public static event ILContext.Manipulator GetMod_Type_bool_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetMod", false), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetMod", false), value);
    }

    public static event ILContext.Manipulator ModEnabled_ITogglableMod
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "ModEnabled", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "ModEnabled", false),
            value);
    }

    public static event ILContext.Manipulator ModEnabled_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "ModEnabled", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "ModEnabled", false),
            value);
    }

    public static event ILContext.Manipulator ModEnabled_Type
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "ModEnabled", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "ModEnabled", false),
            value);
    }

    public static event ILContext.Manipulator GetAllMods
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetAllMods", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ModHooks), "GetAllMods", false),
            value);
    }

    public static event ILContext.Manipulator OnFinishedLoadingMods
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnFinishedLoadingMods", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ModHooks), "OnFinishedLoadingMods", false), value);
    }
}