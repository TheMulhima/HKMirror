namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dStaticSpriteBatcher.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dStaticSpriteBatcher
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dStaticSpriteBatcher.Awake += value;
        remove => IL.tk2dStaticSpriteBatcher.Awake -= value;
    }

    public static event ILContext.Manipulator UpgradeData
    {
        add => IL.tk2dStaticSpriteBatcher.UpgradeData += value;
        remove => IL.tk2dStaticSpriteBatcher.UpgradeData -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dStaticSpriteBatcher.OnDestroy += value;
        remove => IL.tk2dStaticSpriteBatcher.OnDestroy -= value;
    }

    public static event ILContext.Manipulator UpdateMatrices
    {
        add => IL.tk2dStaticSpriteBatcher.UpdateMatrices += value;
        remove => IL.tk2dStaticSpriteBatcher.UpdateMatrices -= value;
    }

    public static event ILContext.Manipulator Build
    {
        add => IL.tk2dStaticSpriteBatcher.Build += value;
        remove => IL.tk2dStaticSpriteBatcher.Build -= value;
    }

    public static event ILContext.Manipulator SortBatchedSprites
    {
        add => IL.tk2dStaticSpriteBatcher.SortBatchedSprites += value;
        remove => IL.tk2dStaticSpriteBatcher.SortBatchedSprites -= value;
    }

    public static event ILContext.Manipulator GetMaterial
    {
        add => IL.tk2dStaticSpriteBatcher.GetMaterial += value;
        remove => IL.tk2dStaticSpriteBatcher.GetMaterial -= value;
    }

    public static event ILContext.Manipulator BuildRenderMesh
    {
        add => IL.tk2dStaticSpriteBatcher.BuildRenderMesh += value;
        remove => IL.tk2dStaticSpriteBatcher.BuildRenderMesh -= value;
    }

    public static event ILContext.Manipulator BuildPhysicsMesh
    {
        add => IL.tk2dStaticSpriteBatcher.BuildPhysicsMesh += value;
        remove => IL.tk2dStaticSpriteBatcher.BuildPhysicsMesh -= value;
    }

    public static event ILContext.Manipulator BuildPhysicsMesh2D
    {
        add => IL.tk2dStaticSpriteBatcher.BuildPhysicsMesh2D += value;
        remove => IL.tk2dStaticSpriteBatcher.BuildPhysicsMesh2D -= value;
    }

    public static event ILContext.Manipulator BuildPhysicsMesh3D
    {
        add => IL.tk2dStaticSpriteBatcher.BuildPhysicsMesh3D += value;
        remove => IL.tk2dStaticSpriteBatcher.BuildPhysicsMesh3D -= value;
    }

    public static event ILContext.Manipulator UsesSpriteCollection
    {
        add => IL.tk2dStaticSpriteBatcher.UsesSpriteCollection += value;
        remove => IL.tk2dStaticSpriteBatcher.UsesSpriteCollection -= value;
    }

    public static event ILContext.Manipulator ForceBuild
    {
        add => IL.tk2dStaticSpriteBatcher.ForceBuild += value;
        remove => IL.tk2dStaticSpriteBatcher.ForceBuild -= value;
    }
}