using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrassWind.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrassWind
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GrassWind.Awake += value;
        remove => IL.GrassWind.Awake -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GrassWind.OnTriggerEnter2D += value;
        remove => IL.GrassWind.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator DelayReact
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GrassWind), "DelayReact").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GrassWind), "DelayReact").GetStateMachineTarget(), value);
    }
}