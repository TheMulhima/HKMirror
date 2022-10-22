namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementIDMap_AchievementIDPair allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementIDMap_AchievementIDPairR:InstanceClassWrapper<AchievementIDMap.AchievementIDPair>
{
public AchievementIDMap_AchievementIDPairR(AchievementIDMap.AchievementIDPair _orig) : base(_orig) {}
public string internalId
{
get => GetField<string>();
set => SetField(value);
}

public int serviceId
{
get => GetField<int>();
set => SetField(value);
}

public string InternalId
{
get => orig.InternalId;
}

public int ServiceId
{
get => orig.ServiceId;
}

}
}
