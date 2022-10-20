namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dFont.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dFont
{
    public static event ILContext.Manipulator Upgrade
    {
        add => IL.tk2dFont.Upgrade += value;
        remove => IL.tk2dFont.Upgrade -= value;
    }
}