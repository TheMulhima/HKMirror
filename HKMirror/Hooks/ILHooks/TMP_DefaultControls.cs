using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_DefaultControls,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_DefaultControls
{
    public static event ILContext.Manipulator CreateUIElementRoot
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "CreateUIElementRoot", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "CreateUIElementRoot", false), value);
    }

    public static event ILContext.Manipulator CreateUIObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "CreateUIObject", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "CreateUIObject", false), value);
    }

    public static event ILContext.Manipulator SetDefaultTextValues
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetDefaultTextValues", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetDefaultTextValues", false), value);
    }

    public static event ILContext.Manipulator SetDefaultColorTransitionValues
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetDefaultColorTransitionValues", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetDefaultColorTransitionValues", false),
            value);
    }

    public static event ILContext.Manipulator SetParentAndAlign
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetParentAndAlign", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetParentAndAlign", false), value);
    }

    public static event ILContext.Manipulator SetLayerRecursively
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetLayerRecursively", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_DefaultControls), "SetLayerRecursively", false), value);
    }
}