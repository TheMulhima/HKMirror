using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WeightedItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWeightedItem
{
    public static event ILContext.Manipulator get_Weight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WeightedItem), "get_Weight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WeightedItem), "get_Weight"),
            value);
    }
}