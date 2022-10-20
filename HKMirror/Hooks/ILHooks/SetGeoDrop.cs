namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetGeoDrop.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetGeoDrop
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetGeoDrop.Reset += value;
        remove => IL.SetGeoDrop.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetGeoDrop.OnEnter += value;
        remove => IL.SetGeoDrop.OnEnter -= value;
    }
}