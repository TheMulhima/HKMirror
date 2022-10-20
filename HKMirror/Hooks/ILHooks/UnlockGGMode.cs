namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UnlockGGMode.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUnlockGGMode
{
    public static event ILContext.Manipulator Start
    {
        add => IL.UnlockGGMode.Start += value;
        remove => IL.UnlockGGMode.Start -= value;
    }

    public static event ILContext.Manipulator SetUnlocked
    {
        add => IL.UnlockGGMode.SetUnlocked += value;
        remove => IL.UnlockGGMode.SetUnlocked -= value;
    }
}