using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HashTableGetKeyFromValue.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHashTableGetKeyFromValue
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetKeyFromValue), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HashTableGetKeyFromValue), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetKeyFromValue), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HashTableGetKeyFromValue), "OnEnter"), value);
    }

    public static event ILContext.Manipulator SortHashTableByValues
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HashTableGetKeyFromValue), "SortHashTableByValues"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HashTableGetKeyFromValue), "SortHashTableByValues"), value);
    }
}