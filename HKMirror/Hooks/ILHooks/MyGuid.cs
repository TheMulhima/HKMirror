using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MyGuid.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMyGuid
{
    public static event ILContext.Manipulator get_guid
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MyGuid), "get_guid"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MyGuid), "get_guid"), value);
    }

    public static event ILContext.Manipulator Generate
    {
        add => IL.MyGuid.Generate += value;
        remove => IL.MyGuid.Generate -= value;
    }

    public static event ILContext.Manipulator GetGuid
    {
        add => IL.MyGuid.GetGuid += value;
        remove => IL.MyGuid.GetGuid -= value;
    }
}