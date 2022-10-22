namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WorldNavigation_SceneItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldNavigation_SceneItemR:InstanceClassWrapper<WorldNavigation.SceneItem>
{
public WorldNavigation_SceneItemR(WorldNavigation.SceneItem _orig) : base(_orig) {}
public string Path
{
get => orig.Path;
set => orig.Path = value;
}

public string Name
{
get => orig.Name;
set => orig.Name = value;
}

public WorldNavigation.TransitionItem[] Transitions
{
get => orig.Transitions;
set => orig.Transitions = value;
}

}
}
