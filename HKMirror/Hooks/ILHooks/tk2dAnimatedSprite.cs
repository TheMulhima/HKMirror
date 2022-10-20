using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dAnimatedSprite.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dAnimatedSprite
{
    public static event ILContext.Manipulator get_Animator
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Animator"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Animator"), value);
    }

    public static event ILContext.Manipulator CheckAddAnimatorInternal
    {
        add => IL.tk2dAnimatedSprite.CheckAddAnimatorInternal += value;
        remove => IL.tk2dAnimatedSprite.CheckAddAnimatorInternal -= value;
    }

    public static event ILContext.Manipulator NeedBoxCollider
    {
        add => IL.tk2dAnimatedSprite.NeedBoxCollider += value;
        remove => IL.tk2dAnimatedSprite.NeedBoxCollider -= value;
    }

    public static event ILContext.Manipulator get_Library
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Library"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Library"), value);
    }

    public static event ILContext.Manipulator set_Library
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_Library"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_Library"), value);
    }

    public static event ILContext.Manipulator get_DefaultClipId
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_DefaultClipId"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_DefaultClipId"), value);
    }

    public static event ILContext.Manipulator set_DefaultClipId
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_DefaultClipId"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_DefaultClipId"), value);
    }

    public static event ILContext.Manipulator get_g_paused
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_g_paused", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_g_paused", false), value);
    }

    public static event ILContext.Manipulator set_g_paused
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_g_paused", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_g_paused", false), value);
    }

    public static event ILContext.Manipulator get_Paused
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Paused"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Paused"),
            value);
    }

    public static event ILContext.Manipulator set_Paused
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_Paused"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_Paused"),
            value);
    }

    public static event ILContext.Manipulator ProxyCompletedHandler
    {
        add => IL.tk2dAnimatedSprite.ProxyCompletedHandler += value;
        remove => IL.tk2dAnimatedSprite.ProxyCompletedHandler -= value;
    }

    public static event ILContext.Manipulator ProxyEventTriggeredHandler
    {
        add => IL.tk2dAnimatedSprite.ProxyEventTriggeredHandler += value;
        remove => IL.tk2dAnimatedSprite.ProxyEventTriggeredHandler -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dAnimatedSprite.OnEnable += value;
        remove => IL.tk2dAnimatedSprite.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dAnimatedSprite.OnDisable += value;
        remove => IL.tk2dAnimatedSprite.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dAnimatedSprite.Start += value;
        remove => IL.tk2dAnimatedSprite.Start -= value;
    }

    public static event ILContext.Manipulator AddComponent
    {
        add => IL.tk2dAnimatedSprite.AddComponent += value;
        remove => IL.tk2dAnimatedSprite.AddComponent -= value;
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.tk2dAnimatedSprite.Play += value;
        remove => IL.tk2dAnimatedSprite.Play -= value;
    }

    public static event ILContext.Manipulator Play_float
    {
        add => IL.tk2dAnimatedSprite.Play_float += value;
        remove => IL.tk2dAnimatedSprite.Play_float -= value;
    }

    public static event ILContext.Manipulator PlayFromFrame_int
    {
        add => IL.tk2dAnimatedSprite.PlayFromFrame_int += value;
        remove => IL.tk2dAnimatedSprite.PlayFromFrame_int -= value;
    }

    public static event ILContext.Manipulator Play_string
    {
        add => IL.tk2dAnimatedSprite.Play_string += value;
        remove => IL.tk2dAnimatedSprite.Play_string -= value;
    }

    public static event ILContext.Manipulator PlayFromFrame_string_int
    {
        add => IL.tk2dAnimatedSprite.PlayFromFrame_string_int += value;
        remove => IL.tk2dAnimatedSprite.PlayFromFrame_string_int -= value;
    }

    public static event ILContext.Manipulator Play_string_float
    {
        add => IL.tk2dAnimatedSprite.Play_string_float += value;
        remove => IL.tk2dAnimatedSprite.Play_string_float -= value;
    }

    public static event ILContext.Manipulator Play_tk2dSpriteAnimationClip_float
    {
        add => IL.tk2dAnimatedSprite.Play_tk2dSpriteAnimationClip_float += value;
        remove => IL.tk2dAnimatedSprite.Play_tk2dSpriteAnimationClip_float -= value;
    }

    public static event ILContext.Manipulator Play_tk2dSpriteAnimationClip_float_float
    {
        add => IL.tk2dAnimatedSprite.Play_tk2dSpriteAnimationClip_float_float += value;
        remove => IL.tk2dAnimatedSprite.Play_tk2dSpriteAnimationClip_float_float -= value;
    }

    public static event ILContext.Manipulator get_CurrentClip
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_CurrentClip"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_CurrentClip"), value);
    }

    public static event ILContext.Manipulator get_ClipTimeSeconds
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_ClipTimeSeconds"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_ClipTimeSeconds"), value);
    }

    public static event ILContext.Manipulator get_ClipFps
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_ClipFps"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_ClipFps"), value);
    }

    public static event ILContext.Manipulator set_ClipFps
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_ClipFps"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "set_ClipFps"), value);
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.tk2dAnimatedSprite.Stop += value;
        remove => IL.tk2dAnimatedSprite.Stop -= value;
    }

    public static event ILContext.Manipulator StopAndResetFrame
    {
        add => IL.tk2dAnimatedSprite.StopAndResetFrame += value;
        remove => IL.tk2dAnimatedSprite.StopAndResetFrame -= value;
    }

    public static event ILContext.Manipulator isPlaying
    {
        add => IL.tk2dAnimatedSprite.isPlaying += value;
        remove => IL.tk2dAnimatedSprite.isPlaying -= value;
    }

    public static event ILContext.Manipulator IsPlaying_string
    {
        add => IL.tk2dAnimatedSprite.IsPlaying_string += value;
        remove => IL.tk2dAnimatedSprite.IsPlaying_string -= value;
    }

    public static event ILContext.Manipulator IsPlaying_tk2dSpriteAnimationClip
    {
        add => IL.tk2dAnimatedSprite.IsPlaying_tk2dSpriteAnimationClip += value;
        remove => IL.tk2dAnimatedSprite.IsPlaying_tk2dSpriteAnimationClip -= value;
    }

    public static event ILContext.Manipulator get_Playing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Playing"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_Playing"), value);
    }

    public static event ILContext.Manipulator GetClipIdByName
    {
        add => IL.tk2dAnimatedSprite.GetClipIdByName += value;
        remove => IL.tk2dAnimatedSprite.GetClipIdByName -= value;
    }

    public static event ILContext.Manipulator GetClipByName
    {
        add => IL.tk2dAnimatedSprite.GetClipByName += value;
        remove => IL.tk2dAnimatedSprite.GetClipByName -= value;
    }

    public static event ILContext.Manipulator get_DefaultFps
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_DefaultFps", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dAnimatedSprite), "get_DefaultFps", false), value);
    }

    public static event ILContext.Manipulator Pause
    {
        add => IL.tk2dAnimatedSprite.Pause += value;
        remove => IL.tk2dAnimatedSprite.Pause -= value;
    }

    public static event ILContext.Manipulator Resume
    {
        add => IL.tk2dAnimatedSprite.Resume += value;
        remove => IL.tk2dAnimatedSprite.Resume -= value;
    }

    public static event ILContext.Manipulator SetFrame_int
    {
        add => IL.tk2dAnimatedSprite.SetFrame_int += value;
        remove => IL.tk2dAnimatedSprite.SetFrame_int -= value;
    }

    public static event ILContext.Manipulator SetFrame_int_bool
    {
        add => IL.tk2dAnimatedSprite.SetFrame_int_bool += value;
        remove => IL.tk2dAnimatedSprite.SetFrame_int_bool -= value;
    }

    public static event ILContext.Manipulator UpdateAnimation
    {
        add => IL.tk2dAnimatedSprite.UpdateAnimation += value;
        remove => IL.tk2dAnimatedSprite.UpdateAnimation -= value;
    }
}