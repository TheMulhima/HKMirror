using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KerningTable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKerningTable
{
    public static event ILContext.Manipulator AddKerningPair
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "AddKerningPair"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "AddKerningPair"),
            value);
    }

    public static event ILContext.Manipulator AddKerningPair_int_int_float
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "AddKerningPair"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "AddKerningPair"),
            value);
    }

    public static event ILContext.Manipulator RemoveKerningPair_int_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "RemoveKerningPair"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KerningTable), "RemoveKerningPair"), value);
    }

    public static event ILContext.Manipulator RemoveKerningPair_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "RemoveKerningPair"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KerningTable), "RemoveKerningPair"), value);
    }

    public static event ILContext.Manipulator SortKerningPairs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "SortKerningPairs"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KerningTable), "SortKerningPairs"),
            value);
    }
}