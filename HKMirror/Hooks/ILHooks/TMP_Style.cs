using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_Style.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_Style
{
    public static event ILContext.Manipulator get_name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_name"), value);
    }

    public static event ILContext.Manipulator set_name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "set_name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "set_name"), value);
    }

    public static event ILContext.Manipulator get_hashCode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_hashCode"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_hashCode"), value);
    }

    public static event ILContext.Manipulator set_hashCode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "set_hashCode"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "set_hashCode"), value);
    }

    public static event ILContext.Manipulator get_styleOpeningDefinition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleOpeningDefinition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleOpeningDefinition"), value);
    }

    public static event ILContext.Manipulator get_styleClosingDefinition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleClosingDefinition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleClosingDefinition"), value);
    }

    public static event ILContext.Manipulator get_styleOpeningTagArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleOpeningTagArray"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleOpeningTagArray"), value);
    }

    public static event ILContext.Manipulator get_styleClosingTagArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleClosingTagArray"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "get_styleClosingTagArray"), value);
    }

    public static event ILContext.Manipulator RefreshStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "RefreshStyle"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Style), "RefreshStyle"), value);
    }
}