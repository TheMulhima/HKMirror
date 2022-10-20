namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrassCut.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrassCut
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GrassCut.Awake += value;
        remove => IL.GrassCut.Awake -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GrassCut.OnTriggerEnter2D += value;
        remove => IL.GrassCut.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator ShouldCut
    {
        add => IL.GrassCut.ShouldCut += value;
        remove => IL.GrassCut.ShouldCut -= value;
    }
}