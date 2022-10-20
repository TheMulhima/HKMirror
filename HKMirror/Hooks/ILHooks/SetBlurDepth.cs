namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetBlurDepth.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetBlurDepth
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SetBlurDepth.Start += value;
        remove => IL.SetBlurDepth.Start -= value;
    }
}