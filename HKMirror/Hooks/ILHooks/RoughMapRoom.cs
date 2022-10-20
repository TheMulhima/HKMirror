namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RoughMapRoom.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRoughMapRoom
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RoughMapRoom.Start += value;
        remove => IL.RoughMapRoom.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.RoughMapRoom.OnEnable += value;
        remove => IL.RoughMapRoom.OnEnable -= value;
    }
}