namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetDreamNailConvo.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetDreamNailConvo
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetDreamNailConvo.Reset += value;
        remove => IL.SetDreamNailConvo.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetDreamNailConvo.OnEnter += value;
        remove => IL.SetDreamNailConvo.OnEnter -= value;
    }
}