namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuAudioSlider.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuAudioSlider
{
    public static event ILContext.Manipulator Start
    {
        add => IL.MenuAudioSlider.Start += value;
        remove => IL.MenuAudioSlider.Start -= value;
    }

    public static event ILContext.Manipulator UpdateValue
    {
        add => IL.MenuAudioSlider.UpdateValue += value;
        remove => IL.MenuAudioSlider.UpdateValue -= value;
    }

    public static event ILContext.Manipulator RefreshValueFromSettings
    {
        add => IL.MenuAudioSlider.RefreshValueFromSettings += value;
        remove => IL.MenuAudioSlider.RefreshValueFromSettings -= value;
    }

    public static event ILContext.Manipulator UpdateTextValue
    {
        add => IL.MenuAudioSlider.UpdateTextValue += value;
        remove => IL.MenuAudioSlider.UpdateTextValue -= value;
    }

    public static event ILContext.Manipulator SetMasterLevel
    {
        add => IL.MenuAudioSlider.SetMasterLevel += value;
        remove => IL.MenuAudioSlider.SetMasterLevel -= value;
    }

    public static event ILContext.Manipulator SetMusicLevel
    {
        add => IL.MenuAudioSlider.SetMusicLevel += value;
        remove => IL.MenuAudioSlider.SetMusicLevel -= value;
    }

    public static event ILContext.Manipulator SetSoundLevel
    {
        add => IL.MenuAudioSlider.SetSoundLevel += value;
        remove => IL.MenuAudioSlider.SetSoundLevel -= value;
    }

    public static event ILContext.Manipulator GetVolumeLevel
    {
        add => IL.MenuAudioSlider.GetVolumeLevel += value;
        remove => IL.MenuAudioSlider.GetVolumeLevel -= value;
    }
}