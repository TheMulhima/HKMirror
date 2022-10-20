using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AutoRecycleSelf.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAutoRecycleSelf
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.AutoRecycleSelf.OnEnable += value;
        remove => IL.AutoRecycleSelf.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.AutoRecycleSelf.Update += value;
        remove => IL.AutoRecycleSelf.Update -= value;
    }

    public static event ILContext.Manipulator Update20
    {
        add => IL.AutoRecycleSelf.Update20 += value;
        remove => IL.AutoRecycleSelf.Update20 -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.AutoRecycleSelf.OnDisable += value;
        remove => IL.AutoRecycleSelf.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnApplicationQuit
    {
        add => IL.AutoRecycleSelf.OnApplicationQuit += value;
        remove => IL.AutoRecycleSelf.OnApplicationQuit -= value;
    }

    public static event ILContext.Manipulator StartTimer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AutoRecycleSelf), "StartTimer").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AutoRecycleSelf), "StartTimer").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator RecycleSelf
    {
        add => IL.AutoRecycleSelf.RecycleSelf += value;
        remove => IL.AutoRecycleSelf.RecycleSelf -= value;
    }
}