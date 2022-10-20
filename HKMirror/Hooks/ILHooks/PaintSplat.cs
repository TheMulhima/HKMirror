namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PaintSplat.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPaintSplat
{
    public static event ILContext.Manipulator Start
    {
        add => IL.PaintSplat.Start += value;
        remove => IL.PaintSplat.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PaintSplat.Update += value;
        remove => IL.PaintSplat.Update -= value;
    }
}