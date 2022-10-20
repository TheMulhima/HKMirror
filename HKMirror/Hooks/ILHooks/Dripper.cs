using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Dripper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDripper
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.Dripper.OnEnable += value;
        remove => IL.Dripper.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.Dripper.OnDisable += value;
        remove => IL.Dripper.OnDisable -= value;
    }

    public static event ILContext.Manipulator Behaviour
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Dripper), "Behaviour").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Dripper), "Behaviour").GetStateMachineTarget(), value);
    }
}