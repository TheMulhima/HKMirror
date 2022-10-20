namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DisplayItemAmount.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDisplayItemAmount
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DisplayItemAmount.OnEnable += value;
        remove => IL.DisplayItemAmount.OnEnable -= value;
    }
}