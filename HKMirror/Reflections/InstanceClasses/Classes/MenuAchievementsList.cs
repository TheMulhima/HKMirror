namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuAchievementsList allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuAchievementsListR : InstanceClassWrapper<MenuAchievementsList>
{
    public MenuAchievementsListR(MenuAchievementsList _orig) : base(_orig)
    {
    }

    public MenuAchievement menuAchievementPrefab
    {
        get => orig.menuAchievementPrefab;
        set => orig.menuAchievementPrefab = value;
    }

    public List<MenuAchievement> menuAchievementsList
    {
        get => GetField<List<MenuAchievement>>();
        set => SetField(value);
    }

    public bool init
    {
        get => orig.init;
        set => SetProperty(value);
    }


    public void AddMenuAchievement(MenuAchievement achievement)
    {
        orig.AddMenuAchievement(achievement);
    }

    public MenuAchievement FindAchievement(string key)
    {
        return orig.FindAchievement(key);
    }

    public void MarkInit()
    {
        orig.MarkInit();
    }
}