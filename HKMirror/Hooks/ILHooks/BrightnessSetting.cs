namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BrightnessSetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBrightnessSetting
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BrightnessSetting.Start += value;
        remove => IL.BrightnessSetting.Start -= value;
    }

    public static event ILContext.Manipulator UpdateValue
    {
        add => IL.BrightnessSetting.UpdateValue += value;
        remove => IL.BrightnessSetting.UpdateValue -= value;
    }

    public static event ILContext.Manipulator UpdateTextValue
    {
        add => IL.BrightnessSetting.UpdateTextValue += value;
        remove => IL.BrightnessSetting.UpdateTextValue -= value;
    }

    public static event ILContext.Manipulator SetBrightness
    {
        add => IL.BrightnessSetting.SetBrightness += value;
        remove => IL.BrightnessSetting.SetBrightness -= value;
    }

    public static event ILContext.Manipulator RefreshValueFromSettings
    {
        add => IL.BrightnessSetting.RefreshValueFromSettings += value;
        remove => IL.BrightnessSetting.RefreshValueFromSettings -= value;
    }

    public static event ILContext.Manipulator DoneMode
    {
        add => IL.BrightnessSetting.DoneMode += value;
        remove => IL.BrightnessSetting.DoneMode -= value;
    }

    public static event ILContext.Manipulator NormalMode
    {
        add => IL.BrightnessSetting.NormalMode += value;
        remove => IL.BrightnessSetting.NormalMode -= value;
    }
}