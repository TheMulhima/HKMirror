namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dTextGeomGen,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dTextGeomGen
{
    public static event ILContext.Manipulator PostAlignTextData
    {
        add => IL.tk2dTextGeomGen.PostAlignTextData += value;
        remove => IL.tk2dTextGeomGen.PostAlignTextData -= value;
    }

    public static event ILContext.Manipulator GetFullHexColorComponent
    {
        add => IL.tk2dTextGeomGen.GetFullHexColorComponent += value;
        remove => IL.tk2dTextGeomGen.GetFullHexColorComponent -= value;
    }

    public static event ILContext.Manipulator GetCompactHexColorComponent
    {
        add => IL.tk2dTextGeomGen.GetCompactHexColorComponent += value;
        remove => IL.tk2dTextGeomGen.GetCompactHexColorComponent -= value;
    }

    public static event ILContext.Manipulator GetStyleHexColor
    {
        add => IL.tk2dTextGeomGen.GetStyleHexColor += value;
        remove => IL.tk2dTextGeomGen.GetStyleHexColor -= value;
    }

    public static event ILContext.Manipulator SetColorsFromStyleCommand
    {
        add => IL.tk2dTextGeomGen.SetColorsFromStyleCommand += value;
        remove => IL.tk2dTextGeomGen.SetColorsFromStyleCommand -= value;
    }

    public static event ILContext.Manipulator SetGradientTexUFromStyleCommand
    {
        add => IL.tk2dTextGeomGen.SetGradientTexUFromStyleCommand += value;
        remove => IL.tk2dTextGeomGen.SetGradientTexUFromStyleCommand -= value;
    }

    public static event ILContext.Manipulator HandleStyleCommand
    {
        add => IL.tk2dTextGeomGen.HandleStyleCommand += value;
        remove => IL.tk2dTextGeomGen.HandleStyleCommand -= value;
    }
}