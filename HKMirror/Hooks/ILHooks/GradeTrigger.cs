namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GradeTrigger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGradeTrigger
{
    public static event ILContext.Manipulator Start
    {
        add => IL.GradeTrigger.Start += value;
        remove => IL.GradeTrigger.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GradeTrigger.OnTriggerEnter2D += value;
        remove => IL.GradeTrigger.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.GradeTrigger.OnTriggerExit2D += value;
        remove => IL.GradeTrigger.OnTriggerExit2D -= value;
    }
}