namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnviroRegion.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnviroRegion
{
    public static event ILContext.Manipulator Start
    {
        add => IL.EnviroRegion.Start += value;
        remove => IL.EnviroRegion.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.EnviroRegion.OnTriggerEnter2D += value;
        remove => IL.EnviroRegion.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.EnviroRegion.OnTriggerExit2D += value;
        remove => IL.EnviroRegion.OnTriggerExit2D -= value;
    }
}