namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckSceneName.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckSceneName
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckSceneName.Reset += value;
        remove => IL.CheckSceneName.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckSceneName.OnEnter += value;
        remove => IL.CheckSceneName.OnEnter -= value;
    }
}