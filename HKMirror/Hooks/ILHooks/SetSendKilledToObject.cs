namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetSendKilledToObject.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetSendKilledToObject
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetSendKilledToObject.Reset += value;
        remove => IL.SetSendKilledToObject.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetSendKilledToObject.OnEnter += value;
        remove => IL.SetSendKilledToObject.OnEnter -= value;
    }
}