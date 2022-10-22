using Modding.Utils;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AssemblyExtensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAssemblyExtensions
{
    public static event ILContext.Manipulator GetTypesSafely
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "GetTypesSafely", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "GetTypesSafely", false), value);
    }

    public static event ILContext.Manipulator LoadEmbeddedSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "LoadEmbeddedSprite", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "LoadEmbeddedSprite", false), value);
    }
}