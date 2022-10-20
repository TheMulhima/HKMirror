using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSummaryUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSummaryUI
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossSummaryUI.Awake += value;
        remove => IL.BossSummaryUI.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossSummaryUI.Start += value;
        remove => IL.BossSummaryUI.Start -= value;
    }

    public static event ILContext.Manipulator SetupUI
    {
        add => IL.BossSummaryUI.SetupUI += value;
        remove => IL.BossSummaryUI.SetupUI -= value;
    }

    public static event ILContext.Manipulator CreateListItem
    {
        add => IL.BossSummaryUI.CreateListItem += value;
        remove => IL.BossSummaryUI.CreateListItem -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.BossSummaryUI.Show += value;
        remove => IL.BossSummaryUI.Show -= value;
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.BossSummaryUI.Hide += value;
        remove => IL.BossSummaryUI.Hide -= value;
    }

    public static event ILContext.Manipulator Close
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSummaryUI), "Close").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSummaryUI), "Close").GetStateMachineTarget(), value);
    }
}