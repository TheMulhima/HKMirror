namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShopItemStats.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShopItemStats
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ShopItemStats.Awake += value;
        remove => IL.ShopItemStats.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ShopItemStats.OnEnable += value;
        remove => IL.ShopItemStats.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ShopItemStats.Update += value;
        remove => IL.ShopItemStats.Update -= value;
    }

    public static event ILContext.Manipulator GetCost
    {
        add => IL.ShopItemStats.GetCost += value;
        remove => IL.ShopItemStats.GetCost -= value;
    }

    public static event ILContext.Manipulator GetNotchCost
    {
        add => IL.ShopItemStats.GetNotchCost += value;
        remove => IL.ShopItemStats.GetNotchCost -= value;
    }

    public static event ILContext.Manipulator GetCharmsRequired
    {
        add => IL.ShopItemStats.GetCharmsRequired += value;
        remove => IL.ShopItemStats.GetCharmsRequired -= value;
    }

    public static event ILContext.Manipulator GetRelicNumber
    {
        add => IL.ShopItemStats.GetRelicNumber += value;
        remove => IL.ShopItemStats.GetRelicNumber -= value;
    }

    public static event ILContext.Manipulator GetNameConvo
    {
        add => IL.ShopItemStats.GetNameConvo += value;
        remove => IL.ShopItemStats.GetNameConvo -= value;
    }

    public static event ILContext.Manipulator GetDescConvo
    {
        add => IL.ShopItemStats.GetDescConvo += value;
        remove => IL.ShopItemStats.GetDescConvo -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataBoolName
    {
        add => IL.ShopItemStats.GetPlayerDataBoolName += value;
        remove => IL.ShopItemStats.GetPlayerDataBoolName -= value;
    }

    public static event ILContext.Manipulator GetRequiredPlayerDataBoolName
    {
        add => IL.ShopItemStats.GetRequiredPlayerDataBoolName += value;
        remove => IL.ShopItemStats.GetRequiredPlayerDataBoolName -= value;
    }

    public static event ILContext.Manipulator GetRemovalPlayerDataBoolName
    {
        add => IL.ShopItemStats.GetRemovalPlayerDataBoolName += value;
        remove => IL.ShopItemStats.GetRemovalPlayerDataBoolName -= value;
    }

    public static event ILContext.Manipulator GetItemNumber
    {
        add => IL.ShopItemStats.GetItemNumber += value;
        remove => IL.ShopItemStats.GetItemNumber -= value;
    }

    public static event ILContext.Manipulator GetSpecialType
    {
        add => IL.ShopItemStats.GetSpecialType += value;
        remove => IL.ShopItemStats.GetSpecialType -= value;
    }

    public static event ILContext.Manipulator CanBuy
    {
        add => IL.ShopItemStats.CanBuy += value;
        remove => IL.ShopItemStats.CanBuy -= value;
    }

    public static event ILContext.Manipulator SetCanBuy
    {
        add => IL.ShopItemStats.SetCanBuy += value;
        remove => IL.ShopItemStats.SetCanBuy -= value;
    }

    public static event ILContext.Manipulator SetDescConvo
    {
        add => IL.ShopItemStats.SetDescConvo += value;
        remove => IL.ShopItemStats.SetDescConvo -= value;
    }

    public static event ILContext.Manipulator SetCost
    {
        add => IL.ShopItemStats.SetCost += value;
        remove => IL.ShopItemStats.SetCost -= value;
    }
}