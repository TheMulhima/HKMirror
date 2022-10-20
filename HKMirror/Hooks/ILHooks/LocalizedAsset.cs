using Language;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LocalizedAsset.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLocalizedAsset
{
    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LocalizedAsset), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LocalizedAsset), "Awake"), value);
    }

    public static event ILContext.Manipulator LocalizeAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LocalizedAsset), "LocalizeAsset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LocalizedAsset), "LocalizeAsset"),
            value);
    }

    public static event ILContext.Manipulator LocalizeAsset_Object
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LocalizedAsset), "LocalizeAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LocalizedAsset), "LocalizeAsset", false), value);
    }
}