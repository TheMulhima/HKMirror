namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MaskByYPos.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMaskByYPos
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MaskByYPos.OnEnable += value;
        remove => IL.MaskByYPos.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.MaskByYPos.Update += value;
        remove => IL.MaskByYPos.Update -= value;
    }
}