using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HashTableGetNext.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHashTableGetNext
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "Reset"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator DoGetNextItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "DoGetNextItem"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "DoGetNextItem"), value);
    }

    public static event ILContext.Manipulator GetItemAtIndex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "GetItemAtIndex"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HashTableGetNext), "GetItemAtIndex"), value);
    }
}