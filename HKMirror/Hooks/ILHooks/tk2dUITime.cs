using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUITime,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUITime
{
    public static event ILContext.Manipulator get_deltaTime
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITime), "get_deltaTime", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITime), "get_deltaTime", false), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.tk2dUITime.Init += value;
        remove => IL.tk2dUITime.Init -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.tk2dUITime.Update += value;
        remove => IL.tk2dUITime.Update -= value;
    }
}