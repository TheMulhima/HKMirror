using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetZ.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetZ
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SetZ.OnEnable += value;
        remove => IL.SetZ.OnEnable -= value;
    }

    public static event ILContext.Manipulator SetPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SetZ), "SetPosition").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SetZ), "SetPosition").GetStateMachineTarget(), value);
    }
}