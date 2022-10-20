using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ColorChannel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILColorChannel
{
    public static event ILContext.Manipulator Init
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Init"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Init"), value);
    }

    public static event ILContext.Manipulator FindChunkAndCoordinate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "FindChunkAndCoordinate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "FindChunkAndCoordinate"), value);
    }

    public static event ILContext.Manipulator GetColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "GetColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "GetColor"), value);
    }

    public static event ILContext.Manipulator InitChunk
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "InitChunk"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "InitChunk"), value);
    }

    public static event ILContext.Manipulator SetColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "SetColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "SetColor"), value);
    }

    public static event ILContext.Manipulator GetChunk_int_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "GetChunk"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "GetChunk"), value);
    }

    public static event ILContext.Manipulator GetChunk_int_int_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "GetChunk"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "GetChunk"), value);
    }

    public static event ILContext.Manipulator ClearChunk
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "ClearChunk"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "ClearChunk"),
            value);
    }

    public static event ILContext.Manipulator ClearDirtyFlag
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "ClearDirtyFlag"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "ClearDirtyFlag"),
            value);
    }

    public static event ILContext.Manipulator Clear
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Clear"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Clear"), value);
    }

    public static event ILContext.Manipulator Delete
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Delete"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Delete"), value);
    }

    public static event ILContext.Manipulator Create
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Create"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Create"), value);
    }

    public static event ILContext.Manipulator Optimize_ColorChunk
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Optimize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Optimize"), value);
    }

    public static event ILContext.Manipulator Optimize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Optimize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "Optimize"), value);
    }

    public static event ILContext.Manipulator get_IsEmpty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "get_IsEmpty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "get_IsEmpty"),
            value);
    }

    public static event ILContext.Manipulator get_NumActiveChunks
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "get_NumActiveChunks"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColorChannel), "get_NumActiveChunks"), value);
    }
}