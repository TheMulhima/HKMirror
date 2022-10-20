using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteAnimationClip.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteAnimationClip
{
    public static event ILContext.Manipulator get_Duration
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Duration"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Duration"), value);
    }

    public static event ILContext.Manipulator CopyFrom
    {
        add => IL.tk2dSpriteAnimationClip.CopyFrom += value;
        remove => IL.tk2dSpriteAnimationClip.CopyFrom -= value;
    }

    public static event ILContext.Manipulator Clear
    {
        add => IL.tk2dSpriteAnimationClip.Clear += value;
        remove => IL.tk2dSpriteAnimationClip.Clear -= value;
    }

    public static event ILContext.Manipulator get_Empty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Empty"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimationClip), "get_Empty"), value);
    }

    public static event ILContext.Manipulator GetFrame
    {
        add => IL.tk2dSpriteAnimationClip.GetFrame += value;
        remove => IL.tk2dSpriteAnimationClip.GetFrame -= value;
    }
}