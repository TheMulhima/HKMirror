using Language;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StringExtensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStringExtensions
{
    public static event ILContext.Manipulator UnescapeXML
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StringExtensions), "UnescapeXML", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StringExtensions), "UnescapeXML", false), value);
    }
}