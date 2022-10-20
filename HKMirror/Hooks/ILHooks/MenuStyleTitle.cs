namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuStyleTitle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuStyleTitle
{
    public static event ILContext.Manipulator SetTitle
    {
        add => IL.MenuStyleTitle.SetTitle += value;
        remove => IL.MenuStyleTitle.SetTitle -= value;
    }
}