using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrimmballControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrimmballControl
{
    public static event ILContext.Manipulator get_Force
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "get_Force"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "get_Force"),
            value);
    }

    public static event ILContext.Manipulator set_Force
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "set_Force"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "set_Force"),
            value);
    }

    public static event ILContext.Manipulator get_TweenY
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "get_TweenY"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "get_TweenY"),
            value);
    }

    public static event ILContext.Manipulator set_TweenY
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "set_TweenY"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "set_TweenY"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.GrimmballControl.Awake += value;
        remove => IL.GrimmballControl.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GrimmballControl.OnEnable += value;
        remove => IL.GrimmballControl.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.GrimmballControl.OnDisable += value;
        remove => IL.GrimmballControl.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GrimmballControl.OnTriggerEnter2D += value;
        remove => IL.GrimmballControl.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator DoHit
    {
        add => IL.GrimmballControl.DoHit += value;
        remove => IL.GrimmballControl.DoHit -= value;
    }

    public static event ILContext.Manipulator Fire
    {
        add => IL.GrimmballControl.Fire += value;
        remove => IL.GrimmballControl.Fire -= value;
    }

    public static event ILContext.Manipulator DoFire
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "DoFire").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "DoFire").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Shrink
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "Shrink").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GrimmballControl), "Shrink").GetStateMachineTarget(), value);
    }
}