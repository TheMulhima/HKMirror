namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HeroControllerStates.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHeroControllerStates
{
    public static event ILContext.Manipulator GetState
    {
        add => IL.HeroControllerStates.GetState += value;
        remove => IL.HeroControllerStates.GetState -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.HeroControllerStates.SetState += value;
        remove => IL.HeroControllerStates.SetState -= value;
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.HeroControllerStates.Reset += value;
        remove => IL.HeroControllerStates.Reset -= value;
    }
}