namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CycloneDust.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCycloneDust
{
    public static event ILContext.Manipulator Start
    {
        add => IL.CycloneDust.Start += value;
        remove => IL.CycloneDust.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.CycloneDust.OnEnable += value;
        remove => IL.CycloneDust.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CycloneDust.Update += value;
        remove => IL.CycloneDust.Update -= value;
    }
}