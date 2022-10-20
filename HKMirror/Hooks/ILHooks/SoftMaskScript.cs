using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI.Extensions;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SoftMaskScript.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSoftMaskScript
{
    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Start"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Update"), value);
    }

    public static event ILContext.Manipulator SetMask
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "SetMask"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "SetMask"), value);
    }

    public static event ILContext.Manipulator GetCanvasRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "GetCanvasRect"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "GetCanvasRect"),
            value);
    }
}