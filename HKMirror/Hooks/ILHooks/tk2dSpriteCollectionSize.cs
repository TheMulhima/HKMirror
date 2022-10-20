using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteCollectionSize.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteCollectionSize
{
    public static event ILContext.Manipulator Explicit
    {
        add => IL.tk2dSpriteCollectionSize.Explicit += value;
        remove => IL.tk2dSpriteCollectionSize.Explicit -= value;
    }

    public static event ILContext.Manipulator PixelsPerMeter
    {
        add => IL.tk2dSpriteCollectionSize.PixelsPerMeter += value;
        remove => IL.tk2dSpriteCollectionSize.PixelsPerMeter -= value;
    }

    public static event ILContext.Manipulator ForResolution
    {
        add => IL.tk2dSpriteCollectionSize.ForResolution += value;
        remove => IL.tk2dSpriteCollectionSize.ForResolution -= value;
    }

    public static event ILContext.Manipulator ForTk2dCamera
    {
        add => IL.tk2dSpriteCollectionSize.ForTk2dCamera += value;
        remove => IL.tk2dSpriteCollectionSize.ForTk2dCamera -= value;
    }

    public static event ILContext.Manipulator ForTk2dCamera_tk2dCamera
    {
        add => IL.tk2dSpriteCollectionSize.ForTk2dCamera_tk2dCamera += value;
        remove => IL.tk2dSpriteCollectionSize.ForTk2dCamera_tk2dCamera -= value;
    }

    public static event ILContext.Manipulator Default
    {
        add => IL.tk2dSpriteCollectionSize.Default += value;
        remove => IL.tk2dSpriteCollectionSize.Default -= value;
    }

    public static event ILContext.Manipulator CopyFromLegacy
    {
        add => IL.tk2dSpriteCollectionSize.CopyFromLegacy += value;
        remove => IL.tk2dSpriteCollectionSize.CopyFromLegacy -= value;
    }

    public static event ILContext.Manipulator CopyFrom
    {
        add => IL.tk2dSpriteCollectionSize.CopyFrom += value;
        remove => IL.tk2dSpriteCollectionSize.CopyFrom -= value;
    }

    public static event ILContext.Manipulator get_OrthoSize
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionSize), "get_OrthoSize"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionSize), "get_OrthoSize"), value);
    }

    public static event ILContext.Manipulator get_TargetHeight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionSize), "get_TargetHeight"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionSize), "get_TargetHeight"), value);
    }
}