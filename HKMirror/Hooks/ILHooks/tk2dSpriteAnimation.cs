using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteAnimation.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteAnimation
{
    public static event ILContext.Manipulator GetClipByName
    {
        add => IL.tk2dSpriteAnimation.GetClipByName += value;
        remove => IL.tk2dSpriteAnimation.GetClipByName -= value;
    }

    public static event ILContext.Manipulator GetClipById
    {
        add => IL.tk2dSpriteAnimation.GetClipById += value;
        remove => IL.tk2dSpriteAnimation.GetClipById -= value;
    }

    public static event ILContext.Manipulator GetClipIdByName_string
    {
        add => IL.tk2dSpriteAnimation.GetClipIdByName_string += value;
        remove => IL.tk2dSpriteAnimation.GetClipIdByName_string -= value;
    }

    public static event ILContext.Manipulator GetClipIdByName_tk2dSpriteAnimationClip
    {
        add => IL.tk2dSpriteAnimation.GetClipIdByName_tk2dSpriteAnimationClip += value;
        remove => IL.tk2dSpriteAnimation.GetClipIdByName_tk2dSpriteAnimationClip -= value;
    }

    public static event ILContext.Manipulator get_FirstValidClip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimation), "get_FirstValidClip"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimation), "get_FirstValidClip"), value);
    }
}