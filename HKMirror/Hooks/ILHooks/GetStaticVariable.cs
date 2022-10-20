namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetStaticVariable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetStaticVariable
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetStaticVariable.Reset += value;
        remove => IL.GetStaticVariable.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetStaticVariable.OnEnter += value;
        remove => IL.GetStaticVariable.OnEnter -= value;
    }
}