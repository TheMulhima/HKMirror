using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GlobControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGlobControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GlobControl.Awake += value;
        remove => IL.GlobControl.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GlobControl.OnEnable += value;
        remove => IL.GlobControl.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GlobControl.Start += value;
        remove => IL.GlobControl.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GlobControl.OnTriggerEnter2D += value;
        remove => IL.GlobControl.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Break
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GlobControl), "Break").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GlobControl), "Break").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator CheckForGround
    {
        add => IL.GlobControl.CheckForGround += value;
        remove => IL.GlobControl.CheckForGround -= value;
    }
}