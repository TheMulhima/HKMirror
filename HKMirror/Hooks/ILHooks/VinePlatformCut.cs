namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VinePlatformCut.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVinePlatformCut
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.VinePlatformCut.Awake += value;
        remove => IL.VinePlatformCut.Awake -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.VinePlatformCut.OnTriggerEnter2D += value;
        remove => IL.VinePlatformCut.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Cut
    {
        add => IL.VinePlatformCut.Cut += value;
        remove => IL.VinePlatformCut.Cut -= value;
    }

    public static event ILContext.Manipulator Disable
    {
        add => IL.VinePlatformCut.Disable += value;
        remove => IL.VinePlatformCut.Disable -= value;
    }
}