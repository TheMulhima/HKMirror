using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ColorChunk.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILColorChunk
{
    public static event ILContext.Manipulator get_Dirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChunk), "get_Dirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChunk), "get_Dirty"), value);
    }

    public static event ILContext.Manipulator set_Dirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChunk), "set_Dirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChunk), "set_Dirty"), value);
    }

    public static event ILContext.Manipulator get_Empty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChunk), "get_Empty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChunk), "get_Empty"), value);
    }
}