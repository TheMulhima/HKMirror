namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PreMenuInputModuleActionAdaptor.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPreMenuInputModuleActionAdaptor
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PreMenuInputModuleActionAdaptor.OnEnable += value;
        remove => IL.PreMenuInputModuleActionAdaptor.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.PreMenuInputModuleActionAdaptor.OnDisable += value;
        remove => IL.PreMenuInputModuleActionAdaptor.OnDisable -= value;
    }

    public static event ILContext.Manipulator CreateActions
    {
        add => IL.PreMenuInputModuleActionAdaptor.CreateActions += value;
        remove => IL.PreMenuInputModuleActionAdaptor.CreateActions -= value;
    }

    public static event ILContext.Manipulator DestroyActions
    {
        add => IL.PreMenuInputModuleActionAdaptor.DestroyActions += value;
        remove => IL.PreMenuInputModuleActionAdaptor.DestroyActions -= value;
    }
}