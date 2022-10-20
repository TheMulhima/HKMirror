namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for JumpEffects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILJumpEffects
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.JumpEffects.OnEnable += value;
        remove => IL.JumpEffects.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.JumpEffects.Update += value;
        remove => IL.JumpEffects.Update -= value;
    }

    public static event ILContext.Manipulator GetHero
    {
        add => IL.JumpEffects.GetHero += value;
        remove => IL.JumpEffects.GetHero -= value;
    }

    public static event ILContext.Manipulator CheckForFall
    {
        add => IL.JumpEffects.CheckForFall += value;
        remove => IL.JumpEffects.CheckForFall -= value;
    }

    public static event ILContext.Manipulator PlayTrail
    {
        add => IL.JumpEffects.PlayTrail += value;
        remove => IL.JumpEffects.PlayTrail -= value;
    }

    public static event ILContext.Manipulator PlayJumpPuff
    {
        add => IL.JumpEffects.PlayJumpPuff += value;
        remove => IL.JumpEffects.PlayJumpPuff -= value;
    }

    public static event ILContext.Manipulator SplashOut
    {
        add => IL.JumpEffects.SplashOut += value;
        remove => IL.JumpEffects.SplashOut -= value;
    }
}