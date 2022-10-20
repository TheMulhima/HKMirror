namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UpdateTextWithSliderValue.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUpdateTextWithSliderValue
{
    public static event ILContext.Manipulator Start
    {
        add => IL.UpdateTextWithSliderValue.Start += value;
        remove => IL.UpdateTextWithSliderValue.Start -= value;
    }

    public static event ILContext.Manipulator UpdateValue
    {
        add => IL.UpdateTextWithSliderValue.UpdateValue += value;
        remove => IL.UpdateTextWithSliderValue.UpdateValue -= value;
    }
}