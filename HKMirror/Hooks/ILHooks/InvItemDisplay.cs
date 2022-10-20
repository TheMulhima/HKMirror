namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InvItemDisplay.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInvItemDisplay
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.InvItemDisplay.Awake += value;
        remove => IL.InvItemDisplay.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.InvItemDisplay.OnEnable += value;
        remove => IL.InvItemDisplay.OnEnable -= value;
    }
}