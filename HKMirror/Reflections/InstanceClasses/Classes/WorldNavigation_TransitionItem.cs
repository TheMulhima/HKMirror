namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WorldNavigation_TransitionItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldNavigation_TransitionItemR:InstanceClassWrapper<WorldNavigation.TransitionItem>
{
public WorldNavigation_TransitionItemR(WorldNavigation.TransitionItem _orig) : base(_orig) {}
public string Name
{
get => orig.Name;
set => orig.Name = value;
}

}
}
