using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUITweenItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUITweenItem
{
    public static event ILContext.Manipulator get_UseOnReleaseInsteadOfOnUp
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITweenItem), "get_UseOnReleaseInsteadOfOnUp"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITweenItem), "get_UseOnReleaseInsteadOfOnUp"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUITweenItem.Awake += value;
        remove => IL.tk2dUITweenItem.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUITweenItem.OnEnable += value;
        remove => IL.tk2dUITweenItem.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUITweenItem.OnDisable += value;
        remove => IL.tk2dUITweenItem.OnDisable -= value;
    }

    public static event ILContext.Manipulator ButtonDown
    {
        add => IL.tk2dUITweenItem.ButtonDown += value;
        remove => IL.tk2dUITweenItem.ButtonDown -= value;
    }

    public static event ILContext.Manipulator ButtonUp
    {
        add => IL.tk2dUITweenItem.ButtonUp += value;
        remove => IL.tk2dUITweenItem.ButtonUp -= value;
    }

    public static event ILContext.Manipulator ScaleTween
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITweenItem), "ScaleTween").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITweenItem), "ScaleTween").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator InternalSetUseOnReleaseInsteadOfOnUp
    {
        add => IL.tk2dUITweenItem.InternalSetUseOnReleaseInsteadOfOnUp += value;
        remove => IL.tk2dUITweenItem.InternalSetUseOnReleaseInsteadOfOnUp -= value;
    }
}