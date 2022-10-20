namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetConstantsValue.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetConstantsValue
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetConstantsValue.Reset += value;
        remove => IL.GetConstantsValue.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetConstantsValue.OnEnter += value;
        remove => IL.GetConstantsValue.OnEnter -= value;
    }
}