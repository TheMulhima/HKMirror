using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchShake.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchShake
{
    public static event ILContext.Manipulator Start
    {
        add => IL.TouchShake.Start += value;
        remove => IL.TouchShake.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TouchShake.OnTriggerEnter2D += value;
        remove => IL.TouchShake.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator DoAnimation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchShake), "DoAnimation").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchShake), "DoAnimation").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SpriteAnimation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchShake), "SpriteAnimation").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchShake), "SpriteAnimation").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator tk2dAnimation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchShake), "tk2dAnimation").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchShake), "tk2dAnimation").GetStateMachineTarget(), value);
    }
}