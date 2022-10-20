namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for OverscanSetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILOverscanSetting
{
    public static event ILContext.Manipulator Start
    {
        add => IL.OverscanSetting.Start += value;
        remove => IL.OverscanSetting.Start -= value;
    }

    public static event ILContext.Manipulator UpdateValue
    {
        add => IL.OverscanSetting.UpdateValue += value;
        remove => IL.OverscanSetting.UpdateValue -= value;
    }

    public static event ILContext.Manipulator UpdateTextValue
    {
        add => IL.OverscanSetting.UpdateTextValue += value;
        remove => IL.OverscanSetting.UpdateTextValue -= value;
    }

    public static event ILContext.Manipulator SetOverscan
    {
        add => IL.OverscanSetting.SetOverscan += value;
        remove => IL.OverscanSetting.SetOverscan -= value;
    }

    public static event ILContext.Manipulator RefreshValueFromSettings
    {
        add => IL.OverscanSetting.RefreshValueFromSettings += value;
        remove => IL.OverscanSetting.RefreshValueFromSettings -= value;
    }

    public static event ILContext.Manipulator DoneMode
    {
        add => IL.OverscanSetting.DoneMode += value;
        remove => IL.OverscanSetting.DoneMode -= value;
    }

    public static event ILContext.Manipulator NormalMode
    {
        add => IL.OverscanSetting.NormalMode += value;
        remove => IL.OverscanSetting.NormalMode -= value;
    }
}