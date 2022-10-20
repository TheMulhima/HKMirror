using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GodfinderIcon.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGodfinderIcon
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GodfinderIcon.Awake += value;
        remove => IL.GodfinderIcon.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GodfinderIcon.Start += value;
        remove => IL.GodfinderIcon.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GodfinderIcon.Update += value;
        remove => IL.GodfinderIcon.Update -= value;
    }

    public static event ILContext.Manipulator ShowIcon
    {
        add => IL.GodfinderIcon.ShowIcon += value;
        remove => IL.GodfinderIcon.ShowIcon -= value;
    }

    public static event ILContext.Manipulator ShowIconQueued
    {
        add => IL.GodfinderIcon.ShowIconQueued += value;
        remove => IL.GodfinderIcon.ShowIconQueued -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GodfinderIcon), "Show").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GodfinderIcon), "Show").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.GodfinderIcon.Hide += value;
        remove => IL.GodfinderIcon.Hide -= value;
    }
}