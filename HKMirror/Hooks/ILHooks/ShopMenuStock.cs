namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShopMenuStock.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShopMenuStock
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ShopMenuStock.Start += value;
        remove => IL.ShopMenuStock.Start -= value;
    }

    public static event ILContext.Manipulator SpawnStock
    {
        add => IL.ShopMenuStock.SpawnStock += value;
        remove => IL.ShopMenuStock.SpawnStock -= value;
    }

    public static event ILContext.Manipulator UpdateStock
    {
        add => IL.ShopMenuStock.UpdateStock += value;
        remove => IL.ShopMenuStock.UpdateStock -= value;
    }

    public static event ILContext.Manipulator BuildFromMasterList
    {
        add => IL.ShopMenuStock.BuildFromMasterList += value;
        remove => IL.ShopMenuStock.BuildFromMasterList -= value;
    }

    public static event ILContext.Manipulator StockLeft
    {
        add => IL.ShopMenuStock.StockLeft += value;
        remove => IL.ShopMenuStock.StockLeft -= value;
    }

    public static event ILContext.Manipulator BuildItemList
    {
        add => IL.ShopMenuStock.BuildItemList += value;
        remove => IL.ShopMenuStock.BuildItemList -= value;
    }

    public static event ILContext.Manipulator GetItemCount
    {
        add => IL.ShopMenuStock.GetItemCount += value;
        remove => IL.ShopMenuStock.GetItemCount -= value;
    }

    public static event ILContext.Manipulator GetCost
    {
        add => IL.ShopMenuStock.GetCost += value;
        remove => IL.ShopMenuStock.GetCost -= value;
    }

    public static event ILContext.Manipulator GetNotchCost
    {
        add => IL.ShopMenuStock.GetNotchCost += value;
        remove => IL.ShopMenuStock.GetNotchCost -= value;
    }

    public static event ILContext.Manipulator GetNameConvo
    {
        add => IL.ShopMenuStock.GetNameConvo += value;
        remove => IL.ShopMenuStock.GetNameConvo -= value;
    }

    public static event ILContext.Manipulator GetDescConvo
    {
        add => IL.ShopMenuStock.GetDescConvo += value;
        remove => IL.ShopMenuStock.GetDescConvo -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataBoolName
    {
        add => IL.ShopMenuStock.GetPlayerDataBoolName += value;
        remove => IL.ShopMenuStock.GetPlayerDataBoolName -= value;
    }

    public static event ILContext.Manipulator GetSpecialType
    {
        add => IL.ShopMenuStock.GetSpecialType += value;
        remove => IL.ShopMenuStock.GetSpecialType -= value;
    }

    public static event ILContext.Manipulator GetRelicNumber
    {
        add => IL.ShopMenuStock.GetRelicNumber += value;
        remove => IL.ShopMenuStock.GetRelicNumber -= value;
    }

    public static event ILContext.Manipulator GetCharmsRequired
    {
        add => IL.ShopMenuStock.GetCharmsRequired += value;
        remove => IL.ShopMenuStock.GetCharmsRequired -= value;
    }

    public static event ILContext.Manipulator GetYDistance
    {
        add => IL.ShopMenuStock.GetYDistance += value;
        remove => IL.ShopMenuStock.GetYDistance -= value;
    }

    public static event ILContext.Manipulator GetItemSprite
    {
        add => IL.ShopMenuStock.GetItemSprite += value;
        remove => IL.ShopMenuStock.GetItemSprite -= value;
    }

    public static event ILContext.Manipulator GetItemSpriteScale
    {
        add => IL.ShopMenuStock.GetItemSpriteScale += value;
        remove => IL.ShopMenuStock.GetItemSpriteScale -= value;
    }

    public static event ILContext.Manipulator CanBuy
    {
        add => IL.ShopMenuStock.CanBuy += value;
        remove => IL.ShopMenuStock.CanBuy -= value;
    }

    public static event ILContext.Manipulator GetItemGameObject
    {
        add => IL.ShopMenuStock.GetItemGameObject += value;
        remove => IL.ShopMenuStock.GetItemGameObject -= value;
    }
}