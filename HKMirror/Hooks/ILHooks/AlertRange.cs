using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AlertRange.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAlertRange
{
    public static event ILContext.Manipulator get_IsHeroInRange
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AlertRange), "get_IsHeroInRange"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AlertRange), "get_IsHeroInRange"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.AlertRange.Awake += value;
        remove => IL.AlertRange.Awake -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.AlertRange.OnTriggerEnter2D += value;
        remove => IL.AlertRange.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.AlertRange.OnTriggerExit2D += value;
        remove => IL.AlertRange.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator StillInColliders
    {
        add => IL.AlertRange.StillInColliders += value;
        remove => IL.AlertRange.StillInColliders -= value;
    }

    public static event ILContext.Manipulator Find
    {
        add => IL.AlertRange.Find += value;
        remove => IL.AlertRange.Find -= value;
    }
}