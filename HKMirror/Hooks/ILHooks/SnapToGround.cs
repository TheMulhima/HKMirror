namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SnapToGround.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSnapToGround
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SnapToGround.Awake += value;
        remove => IL.SnapToGround.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SnapToGround.OnEnable += value;
        remove => IL.SnapToGround.OnEnable -= value;
    }
}