using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SceneryTriggerCircle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneryTriggerCircle
{
    public static event ILContext.Manipulator get_active
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneryTriggerCircle), "get_active"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneryTriggerCircle), "get_active"), value);
    }

    public static event ILContext.Manipulator set_active
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneryTriggerCircle), "set_active"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneryTriggerCircle), "set_active"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.SceneryTriggerCircle.Awake += value;
        remove => IL.SceneryTriggerCircle.Awake -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.SceneryTriggerCircle.OnTriggerEnter2D += value;
        remove => IL.SceneryTriggerCircle.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.SceneryTriggerCircle.OnTriggerStay2D += value;
        remove => IL.SceneryTriggerCircle.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.SceneryTriggerCircle.OnTriggerExit2D += value;
        remove => IL.SceneryTriggerCircle.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator RandomizePitch
    {
        add => IL.SceneryTriggerCircle.RandomizePitch += value;
        remove => IL.SceneryTriggerCircle.RandomizePitch -= value;
    }

    public static event ILContext.Manipulator ResetPitch
    {
        add => IL.SceneryTriggerCircle.ResetPitch += value;
        remove => IL.SceneryTriggerCircle.ResetPitch -= value;
    }
}