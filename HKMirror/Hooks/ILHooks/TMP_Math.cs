using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_Math,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_Math
{
    public static event ILContext.Manipulator Approximately
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Math), "Approximately", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Math), "Approximately", false),
            value);
    }
}