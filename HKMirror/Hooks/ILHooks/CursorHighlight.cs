namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CursorHighlight.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCursorHighlight
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CursorHighlight.Awake += value;
        remove => IL.CursorHighlight.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.CursorHighlight.Start += value;
        remove => IL.CursorHighlight.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CursorHighlight.Update += value;
        remove => IL.CursorHighlight.Update -= value;
    }

    public static event ILContext.Manipulator MoveCursor
    {
        add => IL.CursorHighlight.MoveCursor += value;
        remove => IL.CursorHighlight.MoveCursor -= value;
    }
}