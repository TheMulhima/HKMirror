namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for iTweenFSMEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILiTweenFSMEvents
{
    public static event ILContext.Manipulator iTweenOnStart
    {
        add => IL.iTweenFSMEvents.iTweenOnStart += value;
        remove => IL.iTweenFSMEvents.iTweenOnStart -= value;
    }

    public static event ILContext.Manipulator iTweenOnComplete
    {
        add => IL.iTweenFSMEvents.iTweenOnComplete += value;
        remove => IL.iTweenFSMEvents.iTweenOnComplete -= value;
    }
}