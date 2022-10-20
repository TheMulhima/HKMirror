namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckCurrentMapZone.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckCurrentMapZone
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckCurrentMapZone.Reset += value;
        remove => IL.CheckCurrentMapZone.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckCurrentMapZone.OnEnter += value;
        remove => IL.CheckCurrentMapZone.OnEnter -= value;
    }
}