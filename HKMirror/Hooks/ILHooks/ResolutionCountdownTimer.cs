using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ResolutionCountdownTimer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILResolutionCountdownTimer
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ResolutionCountdownTimer.Start += value;
        remove => IL.ResolutionCountdownTimer.Start -= value;
    }

    public static event ILContext.Manipulator StartTimer
    {
        add => IL.ResolutionCountdownTimer.StartTimer += value;
        remove => IL.ResolutionCountdownTimer.StartTimer -= value;
    }

    public static event ILContext.Manipulator CancelTimer
    {
        add => IL.ResolutionCountdownTimer.CancelTimer += value;
        remove => IL.ResolutionCountdownTimer.CancelTimer -= value;
    }

    public static event ILContext.Manipulator TickDown
    {
        add => IL.ResolutionCountdownTimer.TickDown += value;
        remove => IL.ResolutionCountdownTimer.TickDown -= value;
    }

    public static event ILContext.Manipulator CountDown
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ResolutionCountdownTimer), "CountDown").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ResolutionCountdownTimer), "CountDown").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator RollbackRes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ResolutionCountdownTimer), "RollbackRes").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ResolutionCountdownTimer), "RollbackRes").GetStateMachineTarget(),
            value);
    }
}