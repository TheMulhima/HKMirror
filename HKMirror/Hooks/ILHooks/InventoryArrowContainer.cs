namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InventoryArrowContainer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInventoryArrowContainer
{
    public static event ILContext.Manipulator Start
    {
        add => IL.InventoryArrowContainer.Start += value;
        remove => IL.InventoryArrowContainer.Start -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.InventoryArrowContainer.OnDestroy += value;
        remove => IL.InventoryArrowContainer.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.InventoryArrowContainer.Setup += value;
        remove => IL.InventoryArrowContainer.Setup -= value;
    }
}