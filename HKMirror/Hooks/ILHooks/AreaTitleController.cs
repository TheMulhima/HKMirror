using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AreaTitleController.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAreaTitleController
{
    public static event ILContext.Manipulator Start
    {
        add => IL.AreaTitleController.Start += value;
        remove => IL.AreaTitleController.Start -= value;
    }

    public static event ILContext.Manipulator FindAreaTitle
    {
        add => IL.AreaTitleController.FindAreaTitle += value;
        remove => IL.AreaTitleController.FindAreaTitle -= value;
    }

    public static event ILContext.Manipulator DoPlay
    {
        add => IL.AreaTitleController.DoPlay += value;
        remove => IL.AreaTitleController.DoPlay -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.AreaTitleController.OnDestroy += value;
        remove => IL.AreaTitleController.OnDestroy -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.AreaTitleController.OnTriggerEnter2D += value;
        remove => IL.AreaTitleController.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.AreaTitleController.Play += value;
        remove => IL.AreaTitleController.Play -= value;
    }

    public static event ILContext.Manipulator CheckArea
    {
        add => IL.AreaTitleController.CheckArea += value;
        remove => IL.AreaTitleController.CheckArea -= value;
    }

    public static event ILContext.Manipulator Finish
    {
        add => IL.AreaTitleController.Finish += value;
        remove => IL.AreaTitleController.Finish -= value;
    }

    public static event ILContext.Manipulator VisitPause
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AreaTitleController), "VisitPause").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AreaTitleController), "VisitPause").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UnvisitPause
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AreaTitleController), "UnvisitPause").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AreaTitleController), "UnvisitPause").GetStateMachineTarget(), value);
    }
}