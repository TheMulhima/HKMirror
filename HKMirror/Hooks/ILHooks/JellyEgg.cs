namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for JellyEgg.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILJellyEgg
{
    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.JellyEgg.OnTriggerEnter2D += value;
        remove => IL.JellyEgg.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Burst
    {
        add => IL.JellyEgg.Burst += value;
        remove => IL.JellyEgg.Burst -= value;
    }
}