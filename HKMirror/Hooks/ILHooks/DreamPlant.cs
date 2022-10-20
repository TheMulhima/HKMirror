using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DreamPlant.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDreamPlant
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.DreamPlant.Awake += value;
        remove => IL.DreamPlant.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.DreamPlant.Start += value;
        remove => IL.DreamPlant.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.DreamPlant.OnTriggerEnter2D += value;
        remove => IL.DreamPlant.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator AddOrbCount
    {
        add => IL.DreamPlant.AddOrbCount += value;
        remove => IL.DreamPlant.AddOrbCount -= value;
    }

    public static event ILContext.Manipulator RemoveOrbCount
    {
        add => IL.DreamPlant.RemoveOrbCount += value;
        remove => IL.DreamPlant.RemoveOrbCount -= value;
    }

    public static event ILContext.Manipulator ShowPrompt
    {
        add => IL.DreamPlant.ShowPrompt += value;
        remove => IL.DreamPlant.ShowPrompt -= value;
    }

    public static event ILContext.Manipulator CheckOrbs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlant), "CheckOrbs").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlant), "CheckOrbs").GetStateMachineTarget(), value);
    }
}