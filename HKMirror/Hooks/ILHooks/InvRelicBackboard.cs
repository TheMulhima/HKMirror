namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InvRelicBackboard.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInvRelicBackboard
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.InvRelicBackboard.Awake += value;
        remove => IL.InvRelicBackboard.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.InvRelicBackboard.OnEnable += value;
        remove => IL.InvRelicBackboard.OnEnable -= value;
    }
}