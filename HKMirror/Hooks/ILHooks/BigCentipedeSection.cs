namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BigCentipedeSection.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBigCentipedeSection
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BigCentipedeSection.Awake += value;
        remove => IL.BigCentipedeSection.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.BigCentipedeSection.Update += value;
        remove => IL.BigCentipedeSection.Update -= value;
    }
}