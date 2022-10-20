using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TrackTriggerObjects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTrackTriggerObjects
{
    public static event ILContext.Manipulator get_InsideCount
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TrackTriggerObjects), "get_InsideCount"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TrackTriggerObjects), "get_InsideCount"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.TrackTriggerObjects.OnDisable += value;
        remove => IL.TrackTriggerObjects.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.TrackTriggerObjects.OnEnable += value;
        remove => IL.TrackTriggerObjects.OnEnable -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.TrackTriggerObjects.FixedUpdate += value;
        remove => IL.TrackTriggerObjects.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator OnHeroInPosition
    {
        add => IL.TrackTriggerObjects.OnHeroInPosition += value;
        remove => IL.TrackTriggerObjects.OnHeroInPosition -= value;
    }

    public static event ILContext.Manipulator GetOverlappedColliders
    {
        add => IL.TrackTriggerObjects.GetOverlappedColliders += value;
        remove => IL.TrackTriggerObjects.GetOverlappedColliders -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TrackTriggerObjects.OnTriggerEnter2D += value;
        remove => IL.TrackTriggerObjects.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.TrackTriggerObjects.OnTriggerExit2D += value;
        remove => IL.TrackTriggerObjects.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator OnExit
    {
        add => IL.TrackTriggerObjects.OnExit += value;
        remove => IL.TrackTriggerObjects.OnExit -= value;
    }

    public static event ILContext.Manipulator IsIgnored
    {
        add => IL.TrackTriggerObjects.IsIgnored += value;
        remove => IL.TrackTriggerObjects.IsIgnored -= value;
    }
}