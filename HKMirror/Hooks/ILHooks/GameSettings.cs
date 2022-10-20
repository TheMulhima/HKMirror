namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameSettings.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameSettings
{
    public static event ILContext.Manipulator LoadGameOptionsSettings
    {
        add => IL.GameSettings.LoadGameOptionsSettings += value;
        remove => IL.GameSettings.LoadGameOptionsSettings -= value;
    }

    public static event ILContext.Manipulator SaveGameOptionsSettings
    {
        add => IL.GameSettings.SaveGameOptionsSettings += value;
        remove => IL.GameSettings.SaveGameOptionsSettings -= value;
    }

    public static event ILContext.Manipulator ResetGameOptionsSettings
    {
        add => IL.GameSettings.ResetGameOptionsSettings += value;
        remove => IL.GameSettings.ResetGameOptionsSettings -= value;
    }

    public static event ILContext.Manipulator LoadVideoSettings
    {
        add => IL.GameSettings.LoadVideoSettings += value;
        remove => IL.GameSettings.LoadVideoSettings -= value;
    }

    public static event ILContext.Manipulator SaveVideoSettings
    {
        add => IL.GameSettings.SaveVideoSettings += value;
        remove => IL.GameSettings.SaveVideoSettings -= value;
    }

    public static event ILContext.Manipulator ResetVideoSettings
    {
        add => IL.GameSettings.ResetVideoSettings += value;
        remove => IL.GameSettings.ResetVideoSettings -= value;
    }

    public static event ILContext.Manipulator LoadOverscanSettings
    {
        add => IL.GameSettings.LoadOverscanSettings += value;
        remove => IL.GameSettings.LoadOverscanSettings -= value;
    }

    public static event ILContext.Manipulator SaveOverscanSettings
    {
        add => IL.GameSettings.SaveOverscanSettings += value;
        remove => IL.GameSettings.SaveOverscanSettings -= value;
    }

    public static event ILContext.Manipulator ResetOverscanSettings
    {
        add => IL.GameSettings.ResetOverscanSettings += value;
        remove => IL.GameSettings.ResetOverscanSettings -= value;
    }

    public static event ILContext.Manipulator LoadOverscanConfigured
    {
        add => IL.GameSettings.LoadOverscanConfigured += value;
        remove => IL.GameSettings.LoadOverscanConfigured -= value;
    }

    public static event ILContext.Manipulator LoadBrightnessSettings
    {
        add => IL.GameSettings.LoadBrightnessSettings += value;
        remove => IL.GameSettings.LoadBrightnessSettings -= value;
    }

    public static event ILContext.Manipulator SaveBrightnessSettings
    {
        add => IL.GameSettings.SaveBrightnessSettings += value;
        remove => IL.GameSettings.SaveBrightnessSettings -= value;
    }

    public static event ILContext.Manipulator ResetBrightnessSettings
    {
        add => IL.GameSettings.ResetBrightnessSettings += value;
        remove => IL.GameSettings.ResetBrightnessSettings -= value;
    }

    public static event ILContext.Manipulator LoadBrightnessConfigured
    {
        add => IL.GameSettings.LoadBrightnessConfigured += value;
        remove => IL.GameSettings.LoadBrightnessConfigured -= value;
    }

    public static event ILContext.Manipulator LoadAudioSettings
    {
        add => IL.GameSettings.LoadAudioSettings += value;
        remove => IL.GameSettings.LoadAudioSettings -= value;
    }

    public static event ILContext.Manipulator SaveAudioSettings
    {
        add => IL.GameSettings.SaveAudioSettings += value;
        remove => IL.GameSettings.SaveAudioSettings -= value;
    }

    public static event ILContext.Manipulator ResetAudioSettings
    {
        add => IL.GameSettings.ResetAudioSettings += value;
        remove => IL.GameSettings.ResetAudioSettings -= value;
    }

    public static event ILContext.Manipulator LoadKeyboardSettings
    {
        add => IL.GameSettings.LoadKeyboardSettings += value;
        remove => IL.GameSettings.LoadKeyboardSettings -= value;
    }

    public static event ILContext.Manipulator LoadAndUpgradeKeyboardKey
    {
        add => IL.GameSettings.LoadAndUpgradeKeyboardKey += value;
        remove => IL.GameSettings.LoadAndUpgradeKeyboardKey -= value;
    }

    public static event ILContext.Manipulator SaveKeyboardSettings
    {
        add => IL.GameSettings.SaveKeyboardSettings += value;
        remove => IL.GameSettings.SaveKeyboardSettings -= value;
    }

    public static event ILContext.Manipulator LoadGamepadSettings
    {
        add => IL.GameSettings.LoadGamepadSettings += value;
        remove => IL.GameSettings.LoadGamepadSettings -= value;
    }

    public static event ILContext.Manipulator SaveGamepadSettings
    {
        add => IL.GameSettings.SaveGamepadSettings += value;
        remove => IL.GameSettings.SaveGamepadSettings -= value;
    }

    public static event ILContext.Manipulator ResetGamepadSettings
    {
        add => IL.GameSettings.ResetGamepadSettings += value;
        remove => IL.GameSettings.ResetGamepadSettings -= value;
    }

    public static event ILContext.Manipulator RemapGamepadTypeForSettings
    {
        add => IL.GameSettings.RemapGamepadTypeForSettings += value;
        remove => IL.GameSettings.RemapGamepadTypeForSettings -= value;
    }

    public static event ILContext.Manipulator LoadInt
    {
        add => IL.GameSettings.LoadInt += value;
        remove => IL.GameSettings.LoadInt -= value;
    }

    public static event ILContext.Manipulator HasSetting
    {
        add => IL.GameSettings.HasSetting += value;
        remove => IL.GameSettings.HasSetting -= value;
    }

    public static event ILContext.Manipulator LoadBool
    {
        add => IL.GameSettings.LoadBool += value;
        remove => IL.GameSettings.LoadBool -= value;
    }

    public static event ILContext.Manipulator LoadFloat
    {
        add => IL.GameSettings.LoadFloat += value;
        remove => IL.GameSettings.LoadFloat -= value;
    }

    public static event ILContext.Manipulator LoadString
    {
        add => IL.GameSettings.LoadString += value;
        remove => IL.GameSettings.LoadString -= value;
    }

    public static event ILContext.Manipulator LogMissingKey
    {
        add => IL.GameSettings.LogMissingKey += value;
        remove => IL.GameSettings.LogMissingKey -= value;
    }

    public static event ILContext.Manipulator LogLoadedKey_string_int
    {
        add => IL.GameSettings.LogLoadedKey_string_int += value;
        remove => IL.GameSettings.LogLoadedKey_string_int -= value;
    }

    public static event ILContext.Manipulator LogLoadedKey_string_float
    {
        add => IL.GameSettings.LogLoadedKey_string_float += value;
        remove => IL.GameSettings.LogLoadedKey_string_float -= value;
    }

    public static event ILContext.Manipulator LogLoadedKey_string_string
    {
        add => IL.GameSettings.LogLoadedKey_string_string += value;
        remove => IL.GameSettings.LogLoadedKey_string_string -= value;
    }

    public static event ILContext.Manipulator LogSavedKey_string_int
    {
        add => IL.GameSettings.LogSavedKey_string_int += value;
        remove => IL.GameSettings.LogSavedKey_string_int -= value;
    }

    public static event ILContext.Manipulator LogSavedKey_string_float
    {
        add => IL.GameSettings.LogSavedKey_string_float += value;
        remove => IL.GameSettings.LogSavedKey_string_float -= value;
    }

    public static event ILContext.Manipulator LogSavedKey_string_string
    {
        add => IL.GameSettings.LogSavedKey_string_string += value;
        remove => IL.GameSettings.LogSavedKey_string_string -= value;
    }

    public static event ILContext.Manipulator CommandArgumentUsed
    {
        add => IL.GameSettings.CommandArgumentUsed += value;
        remove => IL.GameSettings.CommandArgumentUsed -= value;
    }
}