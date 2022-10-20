namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Turret.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTurret
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.Turret.Awake += value;
        remove => IL.Turret.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.Turret.Update += value;
        remove => IL.Turret.Update -= value;
    }
}