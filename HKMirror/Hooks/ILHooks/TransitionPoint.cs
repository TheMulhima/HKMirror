using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TransitionPoint.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTransitionPoint
{
    public static event ILContext.Manipulator get_TransitionPoints
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TransitionPoint), "get_TransitionPoints", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TransitionPoint), "get_TransitionPoints", false), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.TransitionPoint.Init += value;
        remove => IL.TransitionPoint.Init -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.TransitionPoint.Awake += value;
        remove => IL.TransitionPoint.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.TransitionPoint.OnDestroy += value;
        remove => IL.TransitionPoint.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.TransitionPoint.Start += value;
        remove => IL.TransitionPoint.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TransitionPoint.OnTriggerEnter2D += value;
        remove => IL.TransitionPoint.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.TransitionPoint.OnTriggerStay2D += value;
        remove => IL.TransitionPoint.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator OnDrawGizmos
    {
        add => IL.TransitionPoint.OnDrawGizmos += value;
        remove => IL.TransitionPoint.OnDrawGizmos -= value;
    }

    public static event ILContext.Manipulator GetGatePosition
    {
        add => IL.TransitionPoint.GetGatePosition += value;
        remove => IL.TransitionPoint.GetGatePosition -= value;
    }

    public static event ILContext.Manipulator SetTargetScene
    {
        add => IL.TransitionPoint.SetTargetScene += value;
        remove => IL.TransitionPoint.SetTargetScene -= value;
    }
}