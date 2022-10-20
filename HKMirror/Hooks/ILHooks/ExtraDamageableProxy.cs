using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ExtraDamageableProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILExtraDamageableProxy
{
    public static event ILContext.Manipulator RecieveExtraDamage
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ExtraDamageableProxy), "IExtraDamageable.RecieveExtraDamage"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ExtraDamageableProxy), "IExtraDamageable.RecieveExtraDamage"), value);
    }
}