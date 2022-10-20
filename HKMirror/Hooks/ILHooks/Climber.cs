using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Climber.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILClimber
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.Climber.Awake += value;
        remove => IL.Climber.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.Climber.Start += value;
        remove => IL.Climber.Start -= value;
    }

    public static event ILContext.Manipulator Walk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Climber), "Walk").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Climber), "Walk").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Turn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Climber), "Turn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Climber), "Turn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator CheckGround
    {
        add => IL.Climber.CheckGround += value;
        remove => IL.Climber.CheckGround -= value;
    }

    public static event ILContext.Manipulator CheckWall
    {
        add => IL.Climber.CheckWall += value;
        remove => IL.Climber.CheckWall -= value;
    }

    public static event ILContext.Manipulator Stun
    {
        add => IL.Climber.Stun += value;
        remove => IL.Climber.Stun -= value;
    }

    public static event ILContext.Manipulator DoStun
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Climber), "DoStun").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Climber), "DoStun").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FireRayLocal
    {
        add => IL.Climber.FireRayLocal += value;
        remove => IL.Climber.FireRayLocal -= value;
    }

    public static event ILContext.Manipulator StickToGround
    {
        add => IL.Climber.StickToGround += value;
        remove => IL.Climber.StickToGround -= value;
    }
}