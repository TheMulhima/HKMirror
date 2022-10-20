using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Tk2dSpriteSetPixelPerfect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTk2dSpriteSetPixelPerfect
{
    public static event ILContext.Manipulator _getSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "_getSprite"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "_getSprite"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetSpritePixelPerfect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "DoSetSpritePixelPerfect"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetPixelPerfect), "DoSetSpritePixelPerfect"), value);
    }
}