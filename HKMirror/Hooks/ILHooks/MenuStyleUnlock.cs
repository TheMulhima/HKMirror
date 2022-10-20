namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuStyleUnlock.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuStyleUnlock
{
    public static event ILContext.Manipulator Start
    {
        add => IL.MenuStyleUnlock.Start += value;
        remove => IL.MenuStyleUnlock.Start -= value;
    }

    public static event ILContext.Manipulator Unlock
    {
        add => IL.MenuStyleUnlock.Unlock += value;
        remove => IL.MenuStyleUnlock.Unlock -= value;
    }
}