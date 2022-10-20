namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ParallaxSorter.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILParallaxSorter
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ParallaxSorter.Awake += value;
        remove => IL.ParallaxSorter.Awake -= value;
    }
}