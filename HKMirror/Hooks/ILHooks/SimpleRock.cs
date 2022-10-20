namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SimpleRock.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSimpleRock
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SimpleRock.Start += value;
        remove => IL.SimpleRock.Start -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.SimpleRock.FixedUpdate += value;
        remove => IL.SimpleRock.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter
    {
        add => IL.SimpleRock.OnTriggerEnter += value;
        remove => IL.SimpleRock.OnTriggerEnter -= value;
    }
}