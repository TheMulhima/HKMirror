namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuButtonControllerListCondition.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuButtonControllerListCondition
{
    public static event ILContext.Manipulator IsFulfilled
    {
        add => IL.MenuButtonControllerListCondition.IsFulfilled += value;
        remove => IL.MenuButtonControllerListCondition.IsFulfilled -= value;
    }
}