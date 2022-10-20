using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Tk2dSpriteSetId.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTk2dSpriteSetId
{
    public static event ILContext.Manipulator _getSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "_getSprite"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "_getSprite"),
            value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator DoSetSpriteID
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "DoSetSpriteID"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dSpriteSetId), "DoSetSpriteID"),
            value);
    }
}