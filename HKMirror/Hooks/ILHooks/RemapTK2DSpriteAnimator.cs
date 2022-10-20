namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RemapTK2DSpriteAnimator.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRemapTK2DSpriteAnimator
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RemapTK2DSpriteAnimator.Start += value;
        remove => IL.RemapTK2DSpriteAnimator.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.RemapTK2DSpriteAnimator.Update += value;
        remove => IL.RemapTK2DSpriteAnimator.Update -= value;
    }
}