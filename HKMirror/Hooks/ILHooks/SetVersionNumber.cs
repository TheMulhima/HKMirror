namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetVersionNumber.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetVersionNumber
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SetVersionNumber.Awake += value;
        remove => IL.SetVersionNumber.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.SetVersionNumber.Start += value;
        remove => IL.SetVersionNumber.Start -= value;
    }
}