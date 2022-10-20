using MonoMod.RuntimeDetour.HookGen;
using TeamCherry;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WorldItems.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWorldItems
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WorldItems), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WorldItems), "OnEnable"), value);
    }

    public static event ILContext.Manipulator RegisterGeoRock
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WorldItems), "RegisterGeoRock"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WorldItems), "RegisterGeoRock"),
            value);
    }
}