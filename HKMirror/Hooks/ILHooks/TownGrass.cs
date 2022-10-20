namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TownGrass.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTownGrass
{
    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TownGrass.OnTriggerEnter2D += value;
        remove => IL.TownGrass.OnTriggerEnter2D -= value;
    }
}