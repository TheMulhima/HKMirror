namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MakeSkippable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMakeSkippable
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.MakeSkippable.Awake += value;
        remove => IL.MakeSkippable.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.MakeSkippable.Start += value;
        remove => IL.MakeSkippable.Start -= value;
    }

    public static event ILContext.Manipulator UnlockSkip
    {
        add => IL.MakeSkippable.UnlockSkip += value;
        remove => IL.MakeSkippable.UnlockSkip -= value;
    }
}