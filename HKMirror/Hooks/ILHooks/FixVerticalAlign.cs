namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FixVerticalAlign.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFixVerticalAlign
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.FixVerticalAlign.OnEnable += value;
        remove => IL.FixVerticalAlign.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.FixVerticalAlign.Start += value;
        remove => IL.FixVerticalAlign.Start -= value;
    }

    public static event ILContext.Manipulator AlignText
    {
        add => IL.FixVerticalAlign.AlignText += value;
        remove => IL.FixVerticalAlign.AlignText -= value;
    }

    public static event ILContext.Manipulator AlignTextKeymap
    {
        add => IL.FixVerticalAlign.AlignTextKeymap += value;
        remove => IL.FixVerticalAlign.AlignTextKeymap -= value;
    }
}