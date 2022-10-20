using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorLockUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorLockUI
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossDoorLockUI.Awake += value;
        remove => IL.BossDoorLockUI.Awake -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.BossDoorLockUI.Show += value;
        remove => IL.BossDoorLockUI.Show -= value;
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.BossDoorLockUI.Hide += value;
        remove => IL.BossDoorLockUI.Hide -= value;
    }

    public static event ILContext.Manipulator ShowRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUI), "ShowRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUI), "ShowRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator HideRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUI), "HideRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUI), "HideRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeButtonPrompts
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUI), "FadeButtonPrompts").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorLockUI), "FadeButtonPrompts").GetStateMachineTarget(), value);
    }
}