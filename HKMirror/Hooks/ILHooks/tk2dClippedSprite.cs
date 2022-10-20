using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dClippedSprite.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dClippedSprite
{
    public static event ILContext.Manipulator get_ClipRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_ClipRect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_ClipRect"), value);
    }

    public static event ILContext.Manipulator set_ClipRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_ClipRect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_ClipRect"), value);
    }

    public static event ILContext.Manipulator get_clipBottomLeft
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_clipBottomLeft"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_clipBottomLeft"), value);
    }

    public static event ILContext.Manipulator set_clipBottomLeft
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_clipBottomLeft"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_clipBottomLeft"), value);
    }

    public static event ILContext.Manipulator get_clipTopRight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_clipTopRight"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_clipTopRight"), value);
    }

    public static event ILContext.Manipulator set_clipTopRight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_clipTopRight"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_clipTopRight"), value);
    }

    public static event ILContext.Manipulator get_CreateBoxCollider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_CreateBoxCollider"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "get_CreateBoxCollider"), value);
    }

    public static event ILContext.Manipulator set_CreateBoxCollider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_CreateBoxCollider"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dClippedSprite), "set_CreateBoxCollider"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dClippedSprite.Awake += value;
        remove => IL.tk2dClippedSprite.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dClippedSprite.OnDestroy += value;
        remove => IL.tk2dClippedSprite.OnDestroy -= value;
    }

    public static event ILContext.Manipulator SetColors
    {
        add => IL.tk2dClippedSprite.SetColors += value;
        remove => IL.tk2dClippedSprite.SetColors -= value;
    }

    public static event ILContext.Manipulator SetGeometry
    {
        add => IL.tk2dClippedSprite.SetGeometry += value;
        remove => IL.tk2dClippedSprite.SetGeometry -= value;
    }

    public static event ILContext.Manipulator Build
    {
        add => IL.tk2dClippedSprite.Build += value;
        remove => IL.tk2dClippedSprite.Build -= value;
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => IL.tk2dClippedSprite.UpdateGeometry += value;
        remove => IL.tk2dClippedSprite.UpdateGeometry -= value;
    }

    public static event ILContext.Manipulator UpdateColors
    {
        add => IL.tk2dClippedSprite.UpdateColors += value;
        remove => IL.tk2dClippedSprite.UpdateColors -= value;
    }

    public static event ILContext.Manipulator UpdateVertices
    {
        add => IL.tk2dClippedSprite.UpdateVertices += value;
        remove => IL.tk2dClippedSprite.UpdateVertices -= value;
    }

    public static event ILContext.Manipulator UpdateColorsImpl
    {
        add => IL.tk2dClippedSprite.UpdateColorsImpl += value;
        remove => IL.tk2dClippedSprite.UpdateColorsImpl -= value;
    }

    public static event ILContext.Manipulator UpdateGeometryImpl
    {
        add => IL.tk2dClippedSprite.UpdateGeometryImpl += value;
        remove => IL.tk2dClippedSprite.UpdateGeometryImpl -= value;
    }

    public static event ILContext.Manipulator UpdateCollider
    {
        add => IL.tk2dClippedSprite.UpdateCollider += value;
        remove => IL.tk2dClippedSprite.UpdateCollider -= value;
    }

    public static event ILContext.Manipulator CreateCollider
    {
        add => IL.tk2dClippedSprite.CreateCollider += value;
        remove => IL.tk2dClippedSprite.CreateCollider -= value;
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => IL.tk2dClippedSprite.UpdateMaterial += value;
        remove => IL.tk2dClippedSprite.UpdateMaterial -= value;
    }

    public static event ILContext.Manipulator GetCurrentVertexCount
    {
        add => IL.tk2dClippedSprite.GetCurrentVertexCount += value;
        remove => IL.tk2dClippedSprite.GetCurrentVertexCount -= value;
    }

    public static event ILContext.Manipulator ReshapeBounds
    {
        add => IL.tk2dClippedSprite.ReshapeBounds += value;
        remove => IL.tk2dClippedSprite.ReshapeBounds -= value;
    }
}