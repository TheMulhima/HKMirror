namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WorldInfo_SceneInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldInfo_SceneInfoR:InstanceClassWrapper<WorldInfo.SceneInfo>
{
public WorldInfo_SceneInfoR(WorldInfo.SceneInfo _orig) : base(_orig) {}
public string SceneName
{
get => orig.SceneName;
set => orig.SceneName = value;
}

public WorldInfo.TransitionInfo[] Transitions
{
get => orig.Transitions;
set => orig.Transitions = value;
}

public int ZoneTags
{
get => orig.ZoneTags;
set => orig.ZoneTags = value;
}

}
}
