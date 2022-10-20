using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RuinsLift.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRuinsLift
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RuinsLift.Start += value;
        remove => IL.RuinsLift.Start -= value;
    }

    public static event ILContext.Manipulator HideChains
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RuinsLift), "HideChains").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RuinsLift), "HideChains").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GetPositionY
    {
        add => IL.RuinsLift.GetPositionY += value;
        remove => IL.RuinsLift.GetPositionY -= value;
    }

    public static event ILContext.Manipulator IsCurrentPositionTerminus
    {
        add => IL.RuinsLift.IsCurrentPositionTerminus += value;
        remove => IL.RuinsLift.IsCurrentPositionTerminus -= value;
    }

    public static event ILContext.Manipulator KeepInBounds
    {
        add => IL.RuinsLift.KeepInBounds += value;
        remove => IL.RuinsLift.KeepInBounds -= value;
    }
}