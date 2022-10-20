namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CoreLoop.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCoreLoop
{
    public static event ILContext.Manipulator Init
    {
        add => IL.CoreLoop.Init += value;
        remove => IL.CoreLoop.Init -= value;
    }

    public static event ILContext.Manipulator InvokeNext
    {
        add => IL.CoreLoop.InvokeNext += value;
        remove => IL.CoreLoop.InvokeNext -= value;
    }

    public static event ILContext.Manipulator EnqueueInvokeNext
    {
        add => IL.CoreLoop.EnqueueInvokeNext += value;
        remove => IL.CoreLoop.EnqueueInvokeNext -= value;
    }

    public static event ILContext.Manipulator FireInvokeNext
    {
        add => IL.CoreLoop.FireInvokeNext += value;
        remove => IL.CoreLoop.FireInvokeNext -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CoreLoop.Update += value;
        remove => IL.CoreLoop.Update -= value;
    }
}