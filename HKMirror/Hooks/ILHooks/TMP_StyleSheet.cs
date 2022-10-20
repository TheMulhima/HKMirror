using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_StyleSheet.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_StyleSheet
{
    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "get_instance", false), value);
    }

    public static event ILContext.Manipulator LoadDefaultStyleSheet
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadDefaultStyleSheet", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadDefaultStyleSheet", false), value);
    }

    public static event ILContext.Manipulator GetStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyle", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyle", false), value);
    }

    public static event ILContext.Manipulator GetStyleInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyleInternal"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyleInternal"), value);
    }

    public static event ILContext.Manipulator UpdateStyleDictionaryKey
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "UpdateStyleDictionaryKey"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "UpdateStyleDictionaryKey"), value);
    }

    public static event ILContext.Manipulator RefreshStyles
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "RefreshStyles", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "RefreshStyles", false), value);
    }

    public static event ILContext.Manipulator LoadStyleDictionaryInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadStyleDictionaryInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadStyleDictionaryInternal"), value);
    }
}