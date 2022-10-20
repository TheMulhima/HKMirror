using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSceneController.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSceneController
{
    public static event ILContext.Manipulator get_IsBossScene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_IsBossScene", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_IsBossScene", false), value);
    }

    public static event ILContext.Manipulator get_HasTransitionedIn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_HasTransitionedIn"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_HasTransitionedIn"), value);
    }

    public static event ILContext.Manipulator set_HasTransitionedIn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_HasTransitionedIn"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_HasTransitionedIn"), value);
    }

    public static event ILContext.Manipulator get_IsTransitioning
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_IsTransitioning", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_IsTransitioning", false), value);
    }

    public static event ILContext.Manipulator get_CanTransition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_CanTransition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_CanTransition"), value);
    }

    public static event ILContext.Manipulator set_CanTransition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_CanTransition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_CanTransition"), value);
    }

    public static event ILContext.Manipulator get_BossLevel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_BossLevel"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_BossLevel"), value);
    }

    public static event ILContext.Manipulator set_BossLevel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_BossLevel"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_BossLevel"), value);
    }

    public static event ILContext.Manipulator get_DreamReturnEvent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_DreamReturnEvent"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_DreamReturnEvent"), value);
    }

    public static event ILContext.Manipulator set_DreamReturnEvent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_DreamReturnEvent"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "set_DreamReturnEvent"), value);
    }

    public static event ILContext.Manipulator get_BossHealthLookup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_BossHealthLookup"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "get_BossHealthLookup"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.BossSceneController.Awake += value;
        remove => IL.BossSceneController.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.BossSceneController.OnDestroy += value;
        remove => IL.BossSceneController.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.BossSceneController.Update += value;
        remove => IL.BossSceneController.Update -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.BossSceneController.Setup += value;
        remove => IL.BossSceneController.Setup -= value;
    }

    public static event ILContext.Manipulator SetKnightDamaged
    {
        add => IL.BossSceneController.SetKnightDamaged += value;
        remove => IL.BossSceneController.SetKnightDamaged -= value;
    }

    public static event ILContext.Manipulator CheckBossesDead
    {
        add => IL.BossSceneController.CheckBossesDead += value;
        remove => IL.BossSceneController.CheckBossesDead -= value;
    }

    public static event ILContext.Manipulator EndBossScene
    {
        add => IL.BossSceneController.EndBossScene += value;
        remove => IL.BossSceneController.EndBossScene -= value;
    }

    public static event ILContext.Manipulator EndSceneDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "EndSceneDelayed").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSceneController), "EndSceneDelayed").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator DoDreamReturn
    {
        add => IL.BossSceneController.DoDreamReturn += value;
        remove => IL.BossSceneController.DoDreamReturn -= value;
    }

    public static event ILContext.Manipulator ApplyBindings
    {
        add => IL.BossSceneController.ApplyBindings += value;
        remove => IL.BossSceneController.ApplyBindings -= value;
    }

    public static event ILContext.Manipulator RestoreBindings
    {
        add => IL.BossSceneController.RestoreBindings += value;
        remove => IL.BossSceneController.RestoreBindings -= value;
    }

    public static event ILContext.Manipulator ReportHealth
    {
        add => IL.BossSceneController.ReportHealth += value;
        remove => IL.BossSceneController.ReportHealth -= value;
    }
}