using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIHoverItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIHoverItem
{
    public static event ILContext.Manipulator get_IsOver
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "get_IsOver"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "get_IsOver"),
            value);
    }

    public static event ILContext.Manipulator set_IsOver
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "set_IsOver"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIHoverItem), "set_IsOver"),
            value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIHoverItem.Start += value;
        remove => IL.tk2dUIHoverItem.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIHoverItem.OnEnable += value;
        remove => IL.tk2dUIHoverItem.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIHoverItem.OnDisable += value;
        remove => IL.tk2dUIHoverItem.OnDisable -= value;
    }

    public static event ILContext.Manipulator HoverOver
    {
        add => IL.tk2dUIHoverItem.HoverOver += value;
        remove => IL.tk2dUIHoverItem.HoverOver -= value;
    }

    public static event ILContext.Manipulator HoverOut
    {
        add => IL.tk2dUIHoverItem.HoverOut += value;
        remove => IL.tk2dUIHoverItem.HoverOut -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.tk2dUIHoverItem.SetState += value;
        remove => IL.tk2dUIHoverItem.SetState -= value;
    }
}