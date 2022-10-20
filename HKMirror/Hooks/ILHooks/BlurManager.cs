namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BlurManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBlurManager
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BlurManager.Awake += value;
        remove => IL.BlurManager.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.BlurManager.Update += value;
        remove => IL.BlurManager.Update -= value;
    }
}