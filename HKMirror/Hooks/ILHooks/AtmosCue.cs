using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AtmosCue.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAtmosCue
{
    public static event ILContext.Manipulator get_Snapshot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AtmosCue), "get_Snapshot"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AtmosCue), "get_Snapshot"), value);
    }

    public static event ILContext.Manipulator IsChannelEnabled
    {
        add => IL.AtmosCue.IsChannelEnabled += value;
        remove => IL.AtmosCue.IsChannelEnabled -= value;
    }
}