namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteAnimationFrame.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteAnimationFrame
{
    public static event ILContext.Manipulator CopyFrom_tk2dSpriteAnimationFrame
    {
        add => IL.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame += value;
        remove => IL.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame -= value;
    }

    public static event ILContext.Manipulator CopyTriggerFrom
    {
        add => IL.tk2dSpriteAnimationFrame.CopyTriggerFrom += value;
        remove => IL.tk2dSpriteAnimationFrame.CopyTriggerFrom -= value;
    }

    public static event ILContext.Manipulator ClearTrigger
    {
        add => IL.tk2dSpriteAnimationFrame.ClearTrigger += value;
        remove => IL.tk2dSpriteAnimationFrame.ClearTrigger -= value;
    }

    public static event ILContext.Manipulator CopyFrom_tk2dSpriteAnimationFrame_bool
    {
        add => IL.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame_bool += value;
        remove => IL.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame_bool -= value;
    }
}