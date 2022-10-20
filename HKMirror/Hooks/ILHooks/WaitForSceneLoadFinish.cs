namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WaitForSceneLoadFinish.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWaitForSceneLoadFinish
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.WaitForSceneLoadFinish.Reset += value;
        remove => IL.WaitForSceneLoadFinish.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.WaitForSceneLoadFinish.OnEnter += value;
        remove => IL.WaitForSceneLoadFinish.OnEnter -= value;
    }
}