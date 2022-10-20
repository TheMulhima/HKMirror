namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CorpseBitEnd.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpseBitEnd
{
    public static event ILContext.Manipulator Update
    {
        add => IL.CorpseBitEnd.Update += value;
        remove => IL.CorpseBitEnd.Update -= value;
    }
}