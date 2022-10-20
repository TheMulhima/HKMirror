namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StartGameEventTrigger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStartGameEventTrigger
{
    public static event ILContext.Manipulator OnSubmit
    {
        add => IL.StartGameEventTrigger.OnSubmit += value;
        remove => IL.StartGameEventTrigger.OnSubmit -= value;
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => IL.StartGameEventTrigger.OnPointerClick += value;
        remove => IL.StartGameEventTrigger.OnPointerClick -= value;
    }

    public static event ILContext.Manipulator IsFulfilled
    {
        add => IL.StartGameEventTrigger.IsFulfilled += value;
        remove => IL.StartGameEventTrigger.IsFulfilled -= value;
    }
}