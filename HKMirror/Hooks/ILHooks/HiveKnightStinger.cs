namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HiveKnightStinger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHiveKnightStinger
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.HiveKnightStinger.OnEnable += value;
        remove => IL.HiveKnightStinger.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.HiveKnightStinger.Update += value;
        remove => IL.HiveKnightStinger.Update -= value;
    }
}