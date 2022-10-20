using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteAnimator.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteAnimator
{
    public static event ILContext.Manipulator get_g_Paused
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_g_Paused", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_g_Paused", false), value);
    }

    public static event ILContext.Manipulator set_g_Paused
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_g_Paused", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_g_Paused", false), value);
    }

    public static event ILContext.Manipulator get_Paused
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Paused"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Paused"),
            value);
    }

    public static event ILContext.Manipulator set_Paused
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_Paused"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_Paused"),
            value);
    }

    public static event ILContext.Manipulator get_Library
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Library"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Library"), value);
    }

    public static event ILContext.Manipulator set_Library
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_Library"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_Library"), value);
    }

    public static event ILContext.Manipulator get_DefaultClipId
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_DefaultClipId"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_DefaultClipId"), value);
    }

    public static event ILContext.Manipulator set_DefaultClipId
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_DefaultClipId"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_DefaultClipId"), value);
    }

    public static event ILContext.Manipulator get_DefaultClip
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_DefaultClip"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_DefaultClip"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dSpriteAnimator.OnEnable += value;
        remove => IL.tk2dSpriteAnimator.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dSpriteAnimator.Start += value;
        remove => IL.tk2dSpriteAnimator.Start -= value;
    }

    public static event ILContext.Manipulator get_Sprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Sprite"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Sprite"),
            value);
    }

    public static event ILContext.Manipulator AddComponent
    {
        add => IL.tk2dSpriteAnimator.AddComponent += value;
        remove => IL.tk2dSpriteAnimator.AddComponent -= value;
    }

    public static event ILContext.Manipulator GetClipByNameVerbose
    {
        add => IL.tk2dSpriteAnimator.GetClipByNameVerbose += value;
        remove => IL.tk2dSpriteAnimator.GetClipByNameVerbose -= value;
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.tk2dSpriteAnimator.Play += value;
        remove => IL.tk2dSpriteAnimator.Play -= value;
    }

    public static event ILContext.Manipulator Play_string
    {
        add => IL.tk2dSpriteAnimator.Play_string += value;
        remove => IL.tk2dSpriteAnimator.Play_string -= value;
    }

    public static event ILContext.Manipulator Play_tk2dSpriteAnimationClip
    {
        add => IL.tk2dSpriteAnimator.Play_tk2dSpriteAnimationClip += value;
        remove => IL.tk2dSpriteAnimator.Play_tk2dSpriteAnimationClip -= value;
    }

    public static event ILContext.Manipulator PlayFromFrame_int
    {
        add => IL.tk2dSpriteAnimator.PlayFromFrame_int += value;
        remove => IL.tk2dSpriteAnimator.PlayFromFrame_int -= value;
    }

    public static event ILContext.Manipulator PlayFromFrame_string_int
    {
        add => IL.tk2dSpriteAnimator.PlayFromFrame_string_int += value;
        remove => IL.tk2dSpriteAnimator.PlayFromFrame_string_int -= value;
    }

    public static event ILContext.Manipulator PlayFromFrame_tk2dSpriteAnimationClip_int
    {
        add => IL.tk2dSpriteAnimator.PlayFromFrame_tk2dSpriteAnimationClip_int += value;
        remove => IL.tk2dSpriteAnimator.PlayFromFrame_tk2dSpriteAnimationClip_int -= value;
    }

    public static event ILContext.Manipulator PlayFrom_float
    {
        add => IL.tk2dSpriteAnimator.PlayFrom_float += value;
        remove => IL.tk2dSpriteAnimator.PlayFrom_float -= value;
    }

    public static event ILContext.Manipulator PlayFrom_string_float
    {
        add => IL.tk2dSpriteAnimator.PlayFrom_string_float += value;
        remove => IL.tk2dSpriteAnimator.PlayFrom_string_float -= value;
    }

    public static event ILContext.Manipulator PlayFrom_tk2dSpriteAnimationClip_float
    {
        add => IL.tk2dSpriteAnimator.PlayFrom_tk2dSpriteAnimationClip_float += value;
        remove => IL.tk2dSpriteAnimator.PlayFrom_tk2dSpriteAnimationClip_float -= value;
    }

    public static event ILContext.Manipulator Play_tk2dSpriteAnimationClip_float_float
    {
        add => IL.tk2dSpriteAnimator.Play_tk2dSpriteAnimationClip_float_float += value;
        remove => IL.tk2dSpriteAnimator.Play_tk2dSpriteAnimationClip_float_float -= value;
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.tk2dSpriteAnimator.Stop += value;
        remove => IL.tk2dSpriteAnimator.Stop -= value;
    }

    public static event ILContext.Manipulator StopAndResetFrame
    {
        add => IL.tk2dSpriteAnimator.StopAndResetFrame += value;
        remove => IL.tk2dSpriteAnimator.StopAndResetFrame -= value;
    }

    public static event ILContext.Manipulator IsPlaying_string
    {
        add => IL.tk2dSpriteAnimator.IsPlaying_string += value;
        remove => IL.tk2dSpriteAnimator.IsPlaying_string -= value;
    }

    public static event ILContext.Manipulator IsPlaying_tk2dSpriteAnimationClip
    {
        add => IL.tk2dSpriteAnimator.IsPlaying_tk2dSpriteAnimationClip += value;
        remove => IL.tk2dSpriteAnimator.IsPlaying_tk2dSpriteAnimationClip -= value;
    }

    public static event ILContext.Manipulator get_Playing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Playing"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_Playing"), value);
    }

    public static event ILContext.Manipulator get_CurrentClip
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_CurrentClip"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_CurrentClip"), value);
    }

    public static event ILContext.Manipulator get_ClipTimeSeconds
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_ClipTimeSeconds"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_ClipTimeSeconds"), value);
    }

    public static event ILContext.Manipulator get_ClipFps
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_ClipFps"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_ClipFps"), value);
    }

    public static event ILContext.Manipulator set_ClipFps
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_ClipFps"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "set_ClipFps"), value);
    }

    public static event ILContext.Manipulator GetClipById
    {
        add => IL.tk2dSpriteAnimator.GetClipById += value;
        remove => IL.tk2dSpriteAnimator.GetClipById -= value;
    }

    public static event ILContext.Manipulator get_DefaultFps
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_DefaultFps", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_DefaultFps", false), value);
    }

    public static event ILContext.Manipulator GetClipIdByName
    {
        add => IL.tk2dSpriteAnimator.GetClipIdByName += value;
        remove => IL.tk2dSpriteAnimator.GetClipIdByName -= value;
    }

    public static event ILContext.Manipulator GetClipByName
    {
        add => IL.tk2dSpriteAnimator.GetClipByName += value;
        remove => IL.tk2dSpriteAnimator.GetClipByName -= value;
    }

    public static event ILContext.Manipulator Pause
    {
        add => IL.tk2dSpriteAnimator.Pause += value;
        remove => IL.tk2dSpriteAnimator.Pause -= value;
    }

    public static event ILContext.Manipulator Resume
    {
        add => IL.tk2dSpriteAnimator.Resume += value;
        remove => IL.tk2dSpriteAnimator.Resume -= value;
    }

    public static event ILContext.Manipulator SetFrame_int
    {
        add => IL.tk2dSpriteAnimator.SetFrame_int += value;
        remove => IL.tk2dSpriteAnimator.SetFrame_int -= value;
    }

    public static event ILContext.Manipulator SetFrame_int_bool
    {
        add => IL.tk2dSpriteAnimator.SetFrame_int_bool += value;
        remove => IL.tk2dSpriteAnimator.SetFrame_int_bool -= value;
    }

    public static event ILContext.Manipulator get_CurrentFrame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_CurrentFrame"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimator), "get_CurrentFrame"), value);
    }

    public static event ILContext.Manipulator UpdateAnimation
    {
        add => IL.tk2dSpriteAnimator.UpdateAnimation += value;
        remove => IL.tk2dSpriteAnimator.UpdateAnimation -= value;
    }

    public static event ILContext.Manipulator ClipNameError
    {
        add => IL.tk2dSpriteAnimator.ClipNameError += value;
        remove => IL.tk2dSpriteAnimator.ClipNameError -= value;
    }

    public static event ILContext.Manipulator ClipIdError
    {
        add => IL.tk2dSpriteAnimator.ClipIdError += value;
        remove => IL.tk2dSpriteAnimator.ClipIdError -= value;
    }

    public static event ILContext.Manipulator WarpClipToLocalTime
    {
        add => IL.tk2dSpriteAnimator.WarpClipToLocalTime += value;
        remove => IL.tk2dSpriteAnimator.WarpClipToLocalTime -= value;
    }

    public static event ILContext.Manipulator SetFrameInternal
    {
        add => IL.tk2dSpriteAnimator.SetFrameInternal += value;
        remove => IL.tk2dSpriteAnimator.SetFrameInternal -= value;
    }

    public static event ILContext.Manipulator ProcessEvents
    {
        add => IL.tk2dSpriteAnimator.ProcessEvents += value;
        remove => IL.tk2dSpriteAnimator.ProcessEvents -= value;
    }

    public static event ILContext.Manipulator OnAnimationCompleted
    {
        add => IL.tk2dSpriteAnimator.OnAnimationCompleted += value;
        remove => IL.tk2dSpriteAnimator.OnAnimationCompleted -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.tk2dSpriteAnimator.LateUpdate += value;
        remove => IL.tk2dSpriteAnimator.LateUpdate -= value;
    }

    public static event ILContext.Manipulator SetSprite
    {
        add => IL.tk2dSpriteAnimator.SetSprite += value;
        remove => IL.tk2dSpriteAnimator.SetSprite -= value;
    }
}