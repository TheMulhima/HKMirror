using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CoroutineQueue.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCoroutineQueue
{
    public static event ILContext.Manipulator Enqueue
    {
        add => IL.CoroutineQueue.Enqueue += value;
        remove => IL.CoroutineQueue.Enqueue -= value;
    }

    public static event ILContext.Manipulator Run
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CoroutineQueue), "Run").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CoroutineQueue), "Run").GetStateMachineTarget(), value);
    }
}