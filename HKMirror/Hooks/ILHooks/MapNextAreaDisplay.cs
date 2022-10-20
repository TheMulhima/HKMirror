namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MapNextAreaDisplay.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMapNextAreaDisplay
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MapNextAreaDisplay.OnEnable += value;
        remove => IL.MapNextAreaDisplay.OnEnable -= value;
    }

    public static event ILContext.Manipulator ActivateChildren
    {
        add => IL.MapNextAreaDisplay.ActivateChildren += value;
        remove => IL.MapNextAreaDisplay.ActivateChildren -= value;
    }

    public static event ILContext.Manipulator DeactivateChildren
    {
        add => IL.MapNextAreaDisplay.DeactivateChildren += value;
        remove => IL.MapNextAreaDisplay.DeactivateChildren -= value;
    }
}