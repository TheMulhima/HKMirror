using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BasicSpriteAnimator.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBasicSpriteAnimator
{
    public static event ILContext.Manipulator get_Length
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BasicSpriteAnimator), "get_Length"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BasicSpriteAnimator), "get_Length"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.BasicSpriteAnimator.Awake += value;
        remove => IL.BasicSpriteAnimator.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.BasicSpriteAnimator.OnEnable += value;
        remove => IL.BasicSpriteAnimator.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.BasicSpriteAnimator.OnDisable += value;
        remove => IL.BasicSpriteAnimator.OnDisable -= value;
    }

    public static event ILContext.Manipulator Animate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BasicSpriteAnimator), "Animate").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BasicSpriteAnimator), "Animate").GetStateMachineTarget(), value);
    }
}