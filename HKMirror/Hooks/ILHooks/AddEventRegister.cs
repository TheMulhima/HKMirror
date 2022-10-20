namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AddEventRegister.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAddEventRegister
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.AddEventRegister.Reset += value;
        remove => IL.AddEventRegister.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.AddEventRegister.OnEnter += value;
        remove => IL.AddEventRegister.OnEnter -= value;
    }
}