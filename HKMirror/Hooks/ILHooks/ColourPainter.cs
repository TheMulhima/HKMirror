namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ColourPainter.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILColourPainter
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ColourPainter.Awake += value;
        remove => IL.ColourPainter.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ColourPainter.Update += value;
        remove => IL.ColourPainter.Update -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.ColourPainter.OnTriggerEnter2D += value;
        remove => IL.ColourPainter.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator DoPaint
    {
        add => IL.ColourPainter.DoPaint += value;
        remove => IL.ColourPainter.DoPaint -= value;
    }
}