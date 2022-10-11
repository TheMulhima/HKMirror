namespace HKMirror.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonSwitchUserListCondition allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonSwitchUserListConditionR : InstanceClassWrapper<MenuButtonSwitchUserListCondition>
{
    public MenuButtonSwitchUserListConditionR(MenuButtonSwitchUserListCondition _orig) : base(_orig)
    {
    }


    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}