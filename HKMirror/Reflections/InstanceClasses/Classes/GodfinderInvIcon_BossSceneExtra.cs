namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GodfinderInvIcon_BossSceneExtra allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GodfinderInvIcon_BossSceneExtraR:InstanceClassWrapper<GodfinderInvIcon.BossSceneExtra>
{
public GodfinderInvIcon_BossSceneExtraR(GodfinderInvIcon.BossSceneExtra _orig) : base(_orig) {}
public BossScene bossScene
{
get => orig.bossScene;
set => orig.bossScene = value;
}

public BossScene.BossTest[] extraTests
{
get => orig.extraTests;
set => orig.extraTests = value;
}

public bool IsUnlocked () =>
orig.IsUnlocked();

}
}
