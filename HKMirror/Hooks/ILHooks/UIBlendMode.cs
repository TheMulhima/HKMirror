using GUIBlendModes;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UIBlendMode.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUIBlendMode
{
    public static event ILContext.Manipulator get_BlendMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_BlendMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_BlendMode"),
            value);
    }

    public static event ILContext.Manipulator set_BlendMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_BlendMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_BlendMode"),
            value);
    }

    public static event ILContext.Manipulator get_ShaderOptimization
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_ShaderOptimization"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_ShaderOptimization"), value);
    }

    public static event ILContext.Manipulator set_ShaderOptimization
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_ShaderOptimization"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_ShaderOptimization"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnDisable"), value);
    }

    public static event ILContext.Manipulator SetBlendMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SetBlendMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SetBlendMode"),
            value);
    }

    public static event ILContext.Manipulator SyncEditor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SyncEditor"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SyncEditor"), value);
    }
}