using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrassBehaviour.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrassBehaviour
{
    public static event ILContext.Manipulator get_SharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GrassBehaviour), "get_SharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GrassBehaviour), "get_SharedMaterial"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.GrassBehaviour.Awake += value;
        remove => IL.GrassBehaviour.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GrassBehaviour.Start += value;
        remove => IL.GrassBehaviour.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GrassBehaviour.OnEnable += value;
        remove => IL.GrassBehaviour.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.GrassBehaviour.OnDisable += value;
        remove => IL.GrassBehaviour.OnDisable -= value;
    }

    public static event ILContext.Manipulator DelayedInfectedCheck
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GrassBehaviour), "DelayedInfectedCheck").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GrassBehaviour), "DelayedInfectedCheck").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.GrassBehaviour.LateUpdate += value;
        remove => IL.GrassBehaviour.LateUpdate -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.GrassBehaviour.FixedUpdate += value;
        remove => IL.GrassBehaviour.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GrassBehaviour.OnTriggerEnter2D += value;
        remove => IL.GrassBehaviour.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.GrassBehaviour.OnTriggerExit2D += value;
        remove => IL.GrassBehaviour.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator CutReact
    {
        add => IL.GrassBehaviour.CutReact += value;
        remove => IL.GrassBehaviour.CutReact -= value;
    }

    public static event ILContext.Manipulator WindReact
    {
        add => IL.GrassBehaviour.WindReact += value;
        remove => IL.GrassBehaviour.WindReact -= value;
    }

    public static event ILContext.Manipulator PlayRandomSound
    {
        add => IL.GrassBehaviour.PlayRandomSound += value;
        remove => IL.GrassBehaviour.PlayRandomSound -= value;
    }

    public static event ILContext.Manipulator SetPushAmount
    {
        add => IL.GrassBehaviour.SetPushAmount += value;
        remove => IL.GrassBehaviour.SetPushAmount -= value;
    }
}