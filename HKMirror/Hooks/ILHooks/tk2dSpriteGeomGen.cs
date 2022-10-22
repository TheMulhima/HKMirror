namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteGeomGen,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteGeomGen
{
    public static event ILContext.Manipulator SetSpriteColors
    {
        add => IL.tk2dSpriteGeomGen.SetSpriteColors += value;
        remove => IL.tk2dSpriteGeomGen.SetSpriteColors -= value;
    }

    public static event ILContext.Manipulator GetSpriteGeomDesc
    {
        add => IL.tk2dSpriteGeomGen.GetSpriteGeomDesc += value;
        remove => IL.tk2dSpriteGeomGen.GetSpriteGeomDesc -= value;
    }

    public static event ILContext.Manipulator SetSpriteGeom
    {
        add => IL.tk2dSpriteGeomGen.SetSpriteGeom += value;
        remove => IL.tk2dSpriteGeomGen.SetSpriteGeom -= value;
    }

    public static event ILContext.Manipulator SetSpriteIndices
    {
        add => IL.tk2dSpriteGeomGen.SetSpriteIndices += value;
        remove => IL.tk2dSpriteGeomGen.SetSpriteIndices -= value;
    }

    public static event ILContext.Manipulator GetClippedSpriteGeomDesc
    {
        add => IL.tk2dSpriteGeomGen.GetClippedSpriteGeomDesc += value;
        remove => IL.tk2dSpriteGeomGen.GetClippedSpriteGeomDesc -= value;
    }

    public static event ILContext.Manipulator SetClippedSpriteGeom
    {
        add => IL.tk2dSpriteGeomGen.SetClippedSpriteGeom += value;
        remove => IL.tk2dSpriteGeomGen.SetClippedSpriteGeom -= value;
    }

    public static event ILContext.Manipulator SetClippedSpriteIndices
    {
        add => IL.tk2dSpriteGeomGen.SetClippedSpriteIndices += value;
        remove => IL.tk2dSpriteGeomGen.SetClippedSpriteIndices -= value;
    }

    public static event ILContext.Manipulator GetSlicedSpriteGeomDesc
    {
        add => IL.tk2dSpriteGeomGen.GetSlicedSpriteGeomDesc += value;
        remove => IL.tk2dSpriteGeomGen.GetSlicedSpriteGeomDesc -= value;
    }

    public static event ILContext.Manipulator SetSlicedSpriteIndices
    {
        add => IL.tk2dSpriteGeomGen.SetSlicedSpriteIndices += value;
        remove => IL.tk2dSpriteGeomGen.SetSlicedSpriteIndices -= value;
    }

    public static event ILContext.Manipulator GetTiledSpriteGeomDesc
    {
        add => IL.tk2dSpriteGeomGen.GetTiledSpriteGeomDesc += value;
        remove => IL.tk2dSpriteGeomGen.GetTiledSpriteGeomDesc -= value;
    }

    public static event ILContext.Manipulator SetTiledSpriteIndices
    {
        add => IL.tk2dSpriteGeomGen.SetTiledSpriteIndices += value;
        remove => IL.tk2dSpriteGeomGen.SetTiledSpriteIndices -= value;
    }

    public static event ILContext.Manipulator SetBoxMeshData
    {
        add => IL.tk2dSpriteGeomGen.SetBoxMeshData += value;
        remove => IL.tk2dSpriteGeomGen.SetBoxMeshData -= value;
    }

    public static event ILContext.Manipulator SetSpriteDefinitionMeshData
    {
        add => IL.tk2dSpriteGeomGen.SetSpriteDefinitionMeshData += value;
        remove => IL.tk2dSpriteGeomGen.SetSpriteDefinitionMeshData -= value;
    }

    public static event ILContext.Manipulator SetSpriteVertexNormals
    {
        add => IL.tk2dSpriteGeomGen.SetSpriteVertexNormals += value;
        remove => IL.tk2dSpriteGeomGen.SetSpriteVertexNormals -= value;
    }
}