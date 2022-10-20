namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FlashMaterialGroup.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFlashMaterialGroup
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.FlashMaterialGroup.Awake += value;
        remove => IL.FlashMaterialGroup.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.FlashMaterialGroup.Start += value;
        remove => IL.FlashMaterialGroup.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.FlashMaterialGroup.Update += value;
        remove => IL.FlashMaterialGroup.Update -= value;
    }
}