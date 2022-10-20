using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Tk2dSpriteSetColor.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTk2dSpriteSetColor
{
    public static event ILContext.Manipulator _getSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "_getSprite"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "_getSprite"),
            value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoSetSpriteColor
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "DoSetSpriteColor"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetColor), "DoSetSpriteColor"), value);
    }
}