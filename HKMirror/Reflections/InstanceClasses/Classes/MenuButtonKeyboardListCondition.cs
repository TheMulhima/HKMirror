namespace HKMirror.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonKeyboardListCondition allowing you
///     to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonKeyboardListConditionR : InstanceClassWrapper<MenuButtonKeyboardListCondition>
{
    public MenuButtonKeyboardListConditionR(MenuButtonKeyboardListCondition _orig) : base(_orig)
    {
    }


    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}