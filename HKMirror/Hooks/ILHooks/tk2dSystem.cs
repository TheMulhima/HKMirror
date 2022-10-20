using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSystem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSystem
{
    public static event ILContext.Manipulator get_inst
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_inst", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_inst", false),
            value);
    }

    public static event ILContext.Manipulator get_inst_NoCreate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_inst_NoCreate", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_inst_NoCreate", false), value);
    }

    public static event ILContext.Manipulator get_CurrentPlatform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_CurrentPlatform", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_CurrentPlatform", false), value);
    }

    public static event ILContext.Manipulator set_CurrentPlatform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "set_CurrentPlatform", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "set_CurrentPlatform", false), value);
    }

    public static event ILContext.Manipulator get_OverrideBuildMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_OverrideBuildMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSystem), "get_OverrideBuildMaterial", false), value);
    }

    public static event ILContext.Manipulator GetAssetPlatform
    {
        add => IL.tk2dSystem.GetAssetPlatform += value;
        remove => IL.tk2dSystem.GetAssetPlatform -= value;
    }
}