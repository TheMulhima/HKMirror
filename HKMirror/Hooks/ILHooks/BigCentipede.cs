using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BigCentipede.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBigCentipede
{
    public static event ILContext.Manipulator get_EntryPoint
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_EntryPoint"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_EntryPoint"),
            value);
    }

    public static event ILContext.Manipulator get_ExitPoint
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_ExitPoint"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_ExitPoint"),
            value);
    }

    public static event ILContext.Manipulator get_Direction
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_Direction"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_Direction"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.BigCentipede.Awake += value;
        remove => IL.BigCentipede.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BigCentipede.Start += value;
        remove => IL.BigCentipede.Start -= value;
    }

    public static event ILContext.Manipulator UnBurrow
    {
        add => IL.BigCentipede.UnBurrow += value;
        remove => IL.BigCentipede.UnBurrow -= value;
    }

    public static event ILContext.Manipulator Burrow
    {
        add => IL.BigCentipede.Burrow += value;
        remove => IL.BigCentipede.Burrow -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.BigCentipede.FixedUpdate += value;
        remove => IL.BigCentipede.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.BigCentipede.Update += value;
        remove => IL.BigCentipede.Update -= value;
    }
}