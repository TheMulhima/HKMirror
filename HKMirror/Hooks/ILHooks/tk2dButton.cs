using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dButton
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dButton.OnEnable += value;
        remove => IL.tk2dButton.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dButton.Start += value;
        remove => IL.tk2dButton.Start -= value;
    }

    public static event ILContext.Manipulator UpdateSpriteIds
    {
        add => IL.tk2dButton.UpdateSpriteIds += value;
        remove => IL.tk2dButton.UpdateSpriteIds -= value;
    }

    public static event ILContext.Manipulator PlaySound
    {
        add => IL.tk2dButton.PlaySound += value;
        remove => IL.tk2dButton.PlaySound -= value;
    }

    public static event ILContext.Manipulator coScale
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dButton), "coScale").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dButton), "coScale").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LocalWaitForSeconds
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dButton), "LocalWaitForSeconds").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dButton), "LocalWaitForSeconds").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator coHandleButtonPress
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dButton), "coHandleButtonPress").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dButton), "coHandleButtonPress").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.tk2dButton.Update += value;
        remove => IL.tk2dButton.Update -= value;
    }
}