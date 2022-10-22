using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dTiledSprite,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dTiledSprite
{
    public static event ILContext.Manipulator get_dimensions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "get_dimensions"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "get_dimensions"), value);
    }

    public static event ILContext.Manipulator set_dimensions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "set_dimensions"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "set_dimensions"), value);
    }

    public static event ILContext.Manipulator set_anchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "set_anchor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "set_anchor"),
            value);
    }

    public static event ILContext.Manipulator get_CreateBoxCollider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "get_CreateBoxCollider"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "get_CreateBoxCollider"), value);
    }

    public static event ILContext.Manipulator set_CreateBoxCollider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "set_CreateBoxCollider"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTiledSprite), "set_CreateBoxCollider"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dTiledSprite.Awake += value;
        remove => IL.tk2dTiledSprite.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dTiledSprite.OnDestroy += value;
        remove => IL.tk2dTiledSprite.OnDestroy -= value;
    }

    public static event ILContext.Manipulator SetColors
    {
        add => IL.tk2dTiledSprite.SetColors += value;
        remove => IL.tk2dTiledSprite.SetColors -= value;
    }

    public static event ILContext.Manipulator Build
    {
        add => IL.tk2dTiledSprite.Build += value;
        remove => IL.tk2dTiledSprite.Build -= value;
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => IL.tk2dTiledSprite.UpdateGeometry += value;
        remove => IL.tk2dTiledSprite.UpdateGeometry -= value;
    }

    public static event ILContext.Manipulator UpdateColors
    {
        add => IL.tk2dTiledSprite.UpdateColors += value;
        remove => IL.tk2dTiledSprite.UpdateColors -= value;
    }

    public static event ILContext.Manipulator UpdateVertices
    {
        add => IL.tk2dTiledSprite.UpdateVertices += value;
        remove => IL.tk2dTiledSprite.UpdateVertices -= value;
    }

    public static event ILContext.Manipulator UpdateColorsImpl
    {
        add => IL.tk2dTiledSprite.UpdateColorsImpl += value;
        remove => IL.tk2dTiledSprite.UpdateColorsImpl -= value;
    }

    public static event ILContext.Manipulator UpdateGeometryImpl
    {
        add => IL.tk2dTiledSprite.UpdateGeometryImpl += value;
        remove => IL.tk2dTiledSprite.UpdateGeometryImpl -= value;
    }

    public static event ILContext.Manipulator UpdateCollider
    {
        add => IL.tk2dTiledSprite.UpdateCollider += value;
        remove => IL.tk2dTiledSprite.UpdateCollider -= value;
    }

    public static event ILContext.Manipulator CreateCollider
    {
        add => IL.tk2dTiledSprite.CreateCollider += value;
        remove => IL.tk2dTiledSprite.CreateCollider -= value;
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => IL.tk2dTiledSprite.UpdateMaterial += value;
        remove => IL.tk2dTiledSprite.UpdateMaterial -= value;
    }

    public static event ILContext.Manipulator GetCurrentVertexCount
    {
        add => IL.tk2dTiledSprite.GetCurrentVertexCount += value;
        remove => IL.tk2dTiledSprite.GetCurrentVertexCount -= value;
    }

    public static event ILContext.Manipulator ReshapeBounds
    {
        add => IL.tk2dTiledSprite.ReshapeBounds += value;
        remove => IL.tk2dTiledSprite.ReshapeBounds -= value;
    }
}