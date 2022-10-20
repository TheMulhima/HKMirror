using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUpdateManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUpdateManager
{
    public static event ILContext.Manipulator get_Instance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUpdateManager), "get_Instance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUpdateManager), "get_Instance", false), value);
    }

    public static event ILContext.Manipulator QueueCommit
    {
        add => IL.tk2dUpdateManager.QueueCommit += value;
        remove => IL.tk2dUpdateManager.QueueCommit -= value;
    }

    public static event ILContext.Manipulator FlushQueues
    {
        add => IL.tk2dUpdateManager.FlushQueues += value;
        remove => IL.tk2dUpdateManager.FlushQueues -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUpdateManager.OnEnable += value;
        remove => IL.tk2dUpdateManager.OnEnable -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.tk2dUpdateManager.LateUpdate += value;
        remove => IL.tk2dUpdateManager.LateUpdate -= value;
    }

    public static event ILContext.Manipulator coSuperLateUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUpdateManager), "coSuperLateUpdate").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUpdateManager), "coSuperLateUpdate").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator QueueCommitInternal
    {
        add => IL.tk2dUpdateManager.QueueCommitInternal += value;
        remove => IL.tk2dUpdateManager.QueueCommitInternal -= value;
    }

    public static event ILContext.Manipulator FlushQueuesInternal
    {
        add => IL.tk2dUpdateManager.FlushQueuesInternal += value;
        remove => IL.tk2dUpdateManager.FlushQueuesInternal -= value;
    }
}