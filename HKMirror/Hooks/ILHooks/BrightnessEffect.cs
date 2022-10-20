namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BrightnessEffect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBrightnessEffect
{
    public static event ILContext.Manipulator OnRenderImage
    {
        add => IL.BrightnessEffect.OnRenderImage += value;
        remove => IL.BrightnessEffect.OnRenderImage -= value;
    }

    public static event ILContext.Manipulator SetBrightness
    {
        add => IL.BrightnessEffect.SetBrightness += value;
        remove => IL.BrightnessEffect.SetBrightness -= value;
    }

    public static event ILContext.Manipulator SetContrast
    {
        add => IL.BrightnessEffect.SetContrast += value;
        remove => IL.BrightnessEffect.SetContrast -= value;
    }
}