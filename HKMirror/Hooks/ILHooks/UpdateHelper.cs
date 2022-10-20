using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UpdateHelper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUpdateHelper
{
    public static event ILContext.Manipulator SetDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UpdateHelper), "SetDirty", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UpdateHelper), "SetDirty", false),
            value);
    }
}