namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputModuleActionAdaptor.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputModuleActionAdaptor
{
    public static event ILContext.Manipulator Start
    {
        add => IL.InputModuleActionAdaptor.Start += value;
        remove => IL.InputModuleActionAdaptor.Start -= value;
    }
}