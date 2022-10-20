namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckStaticBool.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckStaticBool
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckStaticBool.Reset += value;
        remove => IL.CheckStaticBool.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckStaticBool.OnEnter += value;
        remove => IL.CheckStaticBool.OnEnter -= value;
    }
}