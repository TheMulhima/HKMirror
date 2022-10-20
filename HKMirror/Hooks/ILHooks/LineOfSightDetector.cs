using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LineOfSightDetector.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLineOfSightDetector
{
    public static event ILContext.Manipulator get_CanSeeHero
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LineOfSightDetector), "get_CanSeeHero"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LineOfSightDetector), "get_CanSeeHero"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.LineOfSightDetector.Awake += value;
        remove => IL.LineOfSightDetector.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LineOfSightDetector.Update += value;
        remove => IL.LineOfSightDetector.Update -= value;
    }
}