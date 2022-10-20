using InControl.Internal;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CodeWriter.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCodeWriter
{
    public static event ILContext.Manipulator IncreaseIndent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "IncreaseIndent"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "IncreaseIndent"),
            value);
    }

    public static event ILContext.Manipulator DecreaseIndent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "DecreaseIndent"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "DecreaseIndent"),
            value);
    }

    public static event ILContext.Manipulator Append_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "Append"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "Append"), value);
    }

    public static event ILContext.Manipulator Append_bool_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "Append"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "Append"), value);
    }

    public static event ILContext.Manipulator AppendLine_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendLine"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendLine"), value);
    }

    public static event ILContext.Manipulator AppendLine_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendLine"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendLine"), value);
    }

    public static event ILContext.Manipulator AppendFormat
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendFormat"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendFormat"),
            value);
    }

    public static event ILContext.Manipulator AppendLineFormat
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendLineFormat"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "AppendLineFormat"),
            value);
    }

    public static event ILContext.Manipulator ToString
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "ToString"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CodeWriter), "ToString"), value);
    }
}