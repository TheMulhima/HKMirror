namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LoadingCanvas.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLoadingCanvas
{
    public static event ILContext.Manipulator Start
    {
        add => IL.LoadingCanvas.Start += value;
        remove => IL.LoadingCanvas.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LoadingCanvas.Update += value;
        remove => IL.LoadingCanvas.Update -= value;
    }
}