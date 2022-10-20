namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RegionSetAudio.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRegionSetAudio
{
    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.RegionSetAudio.OnTriggerEnter2D += value;
        remove => IL.RegionSetAudio.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.RegionSetAudio.OnTriggerStay2D += value;
        remove => IL.RegionSetAudio.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.RegionSetAudio.OnTriggerExit2D += value;
        remove => IL.RegionSetAudio.OnTriggerExit2D -= value;
    }
}