namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSprite.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSprite
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dSprite.Awake += value;
        remove => IL.tk2dSprite.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dSprite.OnDestroy += value;
        remove => IL.tk2dSprite.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Build
    {
        add => IL.tk2dSprite.Build += value;
        remove => IL.tk2dSprite.Build -= value;
    }

    public static event ILContext.Manipulator AddComponent_GameObject_tk2dSpriteCollectionData_int
    {
        add => IL.tk2dSprite.AddComponent_GameObject_tk2dSpriteCollectionData_int += value;
        remove => IL.tk2dSprite.AddComponent_GameObject_tk2dSpriteCollectionData_int -= value;
    }

    public static event ILContext.Manipulator AddComponent_GameObject_tk2dSpriteCollectionData_string
    {
        add => IL.tk2dSprite.AddComponent_GameObject_tk2dSpriteCollectionData_string += value;
        remove => IL.tk2dSprite.AddComponent_GameObject_tk2dSpriteCollectionData_string -= value;
    }

    public static event ILContext.Manipulator CreateFromTexture
    {
        add => IL.tk2dSprite.CreateFromTexture += value;
        remove => IL.tk2dSprite.CreateFromTexture -= value;
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => IL.tk2dSprite.UpdateGeometry += value;
        remove => IL.tk2dSprite.UpdateGeometry -= value;
    }

    public static event ILContext.Manipulator UpdateColors
    {
        add => IL.tk2dSprite.UpdateColors += value;
        remove => IL.tk2dSprite.UpdateColors -= value;
    }

    public static event ILContext.Manipulator UpdateVertices
    {
        add => IL.tk2dSprite.UpdateVertices += value;
        remove => IL.tk2dSprite.UpdateVertices -= value;
    }

    public static event ILContext.Manipulator UpdateColorsImpl
    {
        add => IL.tk2dSprite.UpdateColorsImpl += value;
        remove => IL.tk2dSprite.UpdateColorsImpl -= value;
    }

    public static event ILContext.Manipulator UpdateVerticesImpl
    {
        add => IL.tk2dSprite.UpdateVerticesImpl += value;
        remove => IL.tk2dSprite.UpdateVerticesImpl -= value;
    }

    public static event ILContext.Manipulator UpdateGeometryImpl
    {
        add => IL.tk2dSprite.UpdateGeometryImpl += value;
        remove => IL.tk2dSprite.UpdateGeometryImpl -= value;
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => IL.tk2dSprite.UpdateMaterial += value;
        remove => IL.tk2dSprite.UpdateMaterial -= value;
    }

    public static event ILContext.Manipulator GetCurrentVertexCount
    {
        add => IL.tk2dSprite.GetCurrentVertexCount += value;
        remove => IL.tk2dSprite.GetCurrentVertexCount -= value;
    }

    public static event ILContext.Manipulator ForceBuild
    {
        add => IL.tk2dSprite.ForceBuild += value;
        remove => IL.tk2dSprite.ForceBuild -= value;
    }

    public static event ILContext.Manipulator ReshapeBounds
    {
        add => IL.tk2dSprite.ReshapeBounds += value;
        remove => IL.tk2dSprite.ReshapeBounds -= value;
    }
}