namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ColorCurvesManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILColorCurvesManager
{
    public static event ILContext.Manipulator SetFactor
    {
        add => IL.ColorCurvesManager.SetFactor += value;
        remove => IL.ColorCurvesManager.SetFactor -= value;
    }

    public static event ILContext.Manipulator SetSaturationA
    {
        add => IL.ColorCurvesManager.SetSaturationA += value;
        remove => IL.ColorCurvesManager.SetSaturationA -= value;
    }

    public static event ILContext.Manipulator SetSaturationB
    {
        add => IL.ColorCurvesManager.SetSaturationB += value;
        remove => IL.ColorCurvesManager.SetSaturationB -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ColorCurvesManager.Start += value;
        remove => IL.ColorCurvesManager.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ColorCurvesManager.Update += value;
        remove => IL.ColorCurvesManager.Update -= value;
    }

    public static event ILContext.Manipulator UpdateScript
    {
        add => IL.ColorCurvesManager.UpdateScript += value;
        remove => IL.ColorCurvesManager.UpdateScript -= value;
    }

    public static event ILContext.Manipulator EditorHasChanged
    {
        add => IL.ColorCurvesManager.EditorHasChanged += value;
        remove => IL.ColorCurvesManager.EditorHasChanged -= value;
    }

    public static event ILContext.Manipulator PairKeyframes
    {
        add => IL.ColorCurvesManager.PairKeyframes += value;
        remove => IL.ColorCurvesManager.PairKeyframes -= value;
    }

    public static event ILContext.Manipulator SimplePairKeyframes
    {
        add => IL.ColorCurvesManager.SimplePairKeyframes += value;
        remove => IL.ColorCurvesManager.SimplePairKeyframes -= value;
    }

    public static event ILContext.Manipulator CreatePair
    {
        add => IL.ColorCurvesManager.CreatePair += value;
        remove => IL.ColorCurvesManager.CreatePair -= value;
    }

    public static event ILContext.Manipulator CreateCurveFromKeyframes
    {
        add => IL.ColorCurvesManager.CreateCurveFromKeyframes += value;
        remove => IL.ColorCurvesManager.CreateCurveFromKeyframes -= value;
    }

    public static event ILContext.Manipulator AverageKeyframe
    {
        add => IL.ColorCurvesManager.AverageKeyframe += value;
        remove => IL.ColorCurvesManager.AverageKeyframe -= value;
    }

    public static event ILContext.Manipulator PairCurvesKeyframes
    {
        add => IL.ColorCurvesManager.PairCurvesKeyframes += value;
        remove => IL.ColorCurvesManager.PairCurvesKeyframes -= value;
    }

    public static event ILContext.Manipulator UpdateScriptParameters
    {
        add => IL.ColorCurvesManager.UpdateScriptParameters += value;
        remove => IL.ColorCurvesManager.UpdateScriptParameters -= value;
    }

    public static event ILContext.Manipulator PairedListsInitiated
    {
        add => IL.ColorCurvesManager.PairedListsInitiated += value;
        remove => IL.ColorCurvesManager.PairedListsInitiated -= value;
    }
}