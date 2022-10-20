namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetPersistentBool.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetPersistentBool
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetPersistentBool.Reset += value;
        remove => IL.GetPersistentBool.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetPersistentBool.OnEnter += value;
        remove => IL.GetPersistentBool.OnEnter -= value;
    }
}