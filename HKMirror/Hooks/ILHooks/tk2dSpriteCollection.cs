using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteCollection.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteCollection
{
    public static event ILContext.Manipulator get_DoNotUse__TextureRefs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_DoNotUse__TextureRefs"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_DoNotUse__TextureRefs"), value);
    }

    public static event ILContext.Manipulator set_DoNotUse__TextureRefs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "set_DoNotUse__TextureRefs"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "set_DoNotUse__TextureRefs"), value);
    }

    public static event ILContext.Manipulator get_HasPlatformData
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_HasPlatformData"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_HasPlatformData"), value);
    }

    public static event ILContext.Manipulator Upgrade
    {
        add => IL.tk2dSpriteCollection.Upgrade += value;
        remove => IL.tk2dSpriteCollection.Upgrade -= value;
    }
}