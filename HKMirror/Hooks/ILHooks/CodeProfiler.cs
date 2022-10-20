namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CodeProfiler.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCodeProfiler
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CodeProfiler.Awake += value;
        remove => IL.CodeProfiler.Awake -= value;
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => IL.CodeProfiler.OnGUI += value;
        remove => IL.CodeProfiler.OnGUI -= value;
    }

    public static event ILContext.Manipulator Begin
    {
        add => IL.CodeProfiler.Begin += value;
        remove => IL.CodeProfiler.Begin -= value;
    }

    public static event ILContext.Manipulator End
    {
        add => IL.CodeProfiler.End += value;
        remove => IL.CodeProfiler.End -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CodeProfiler.Update += value;
        remove => IL.CodeProfiler.Update -= value;
    }
}