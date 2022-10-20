using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BetaEndPrompt.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBetaEndPrompt
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BetaEndPrompt.Awake += value;
        remove => IL.BetaEndPrompt.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BetaEndPrompt), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BetaEndPrompt), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.BetaEndPrompt.Update += value;
        remove => IL.BetaEndPrompt.Update -= value;
    }

    public static event ILContext.Manipulator BeginEnd
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BetaEndPrompt), "BeginEnd").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BetaEndPrompt), "BeginEnd").GetStateMachineTarget(), value);
    }
}