using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpriteChunk.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpriteChunk
{
    public static event ILContext.Manipulator get_Dirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_Dirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_Dirty"), value);
    }

    public static event ILContext.Manipulator set_Dirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "set_Dirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "set_Dirty"), value);
    }

    public static event ILContext.Manipulator get_IsEmpty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_IsEmpty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_IsEmpty"),
            value);
    }

    public static event ILContext.Manipulator get_HasGameData
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_HasGameData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_HasGameData"),
            value);
    }

    public static event ILContext.Manipulator DestroyGameData
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyGameData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyGameData"),
            value);
    }

    public static event ILContext.Manipulator DestroyColliderData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyColliderData"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyColliderData"), value);
    }
}