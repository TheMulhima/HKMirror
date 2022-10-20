namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputModuleBinder.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputModuleBinder
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.InputModuleBinder.OnEnable += value;
        remove => IL.InputModuleBinder.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.InputModuleBinder.OnDisable += value;
        remove => IL.InputModuleBinder.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnAcceptRejectInputStyleChanged
    {
        add => IL.InputModuleBinder.OnAcceptRejectInputStyleChanged += value;
        remove => IL.InputModuleBinder.OnAcceptRejectInputStyleChanged -= value;
    }

    public static event ILContext.Manipulator BindAndApplyActions
    {
        add => IL.InputModuleBinder.BindAndApplyActions += value;
        remove => IL.InputModuleBinder.BindAndApplyActions -= value;
    }
}