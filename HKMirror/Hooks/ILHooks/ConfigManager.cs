using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ConfigManager,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILConfigManager
{
    public static event ILContext.Manipulator get_CameraShakeMultiplier
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_CameraShakeMultiplier", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_CameraShakeMultiplier", false), value);
    }

    public static event ILContext.Manipulator set_CameraShakeMultiplier
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "set_CameraShakeMultiplier", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "set_CameraShakeMultiplier", false), value);
    }

    public static event ILContext.Manipulator get_ControllerRumbleMultiplier
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_ControllerRumbleMultiplier", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_ControllerRumbleMultiplier", false), value);
    }

    public static event ILContext.Manipulator set_ControllerRumbleMultiplier
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "set_ControllerRumbleMultiplier", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "set_ControllerRumbleMultiplier", false), value);
    }

    public static event ILContext.Manipulator get_IsConfigFileSupported
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_IsConfigFileSupported", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_IsConfigFileSupported", false), value);
    }

    public static event ILContext.Manipulator get_IsSavingConfig
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_IsSavingConfig", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "get_IsSavingConfig", false), value);
    }

    public static event ILContext.Manipulator set_IsSavingConfig
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "set_IsSavingConfig", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ConfigManager), "set_IsSavingConfig", false), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.ConfigManager.Init += value;
        remove => IL.ConfigManager.Init -= value;
    }

    public static event ILContext.Manipulator LoadConfig
    {
        add => IL.ConfigManager.LoadConfig += value;
        remove => IL.ConfigManager.LoadConfig -= value;
    }

    public static event ILContext.Manipulator SetDefaultLanguageSetting
    {
        add => IL.ConfigManager.SetDefaultLanguageSetting += value;
        remove => IL.ConfigManager.SetDefaultLanguageSetting -= value;
    }

    public static event ILContext.Manipulator SaveConfig
    {
        add => IL.ConfigManager.SaveConfig += value;
        remove => IL.ConfigManager.SaveConfig -= value;
    }

    public static event ILContext.Manipulator IsLanguageValid
    {
        add => IL.ConfigManager.IsLanguageValid += value;
        remove => IL.ConfigManager.IsLanguageValid -= value;
    }
}