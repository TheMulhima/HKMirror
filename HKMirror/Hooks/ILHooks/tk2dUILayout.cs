using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUILayout.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUILayout
{
    public static event ILContext.Manipulator get_ItemCount
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUILayout), "get_ItemCount"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUILayout), "get_ItemCount"),
            value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.tk2dUILayout.Reset += value;
        remove => IL.tk2dUILayout.Reset -= value;
    }

    public static event ILContext.Manipulator Reshape
    {
        add => IL.tk2dUILayout.Reshape += value;
        remove => IL.tk2dUILayout.Reshape -= value;
    }

    public static event ILContext.Manipulator SetBounds
    {
        add => IL.tk2dUILayout.SetBounds += value;
        remove => IL.tk2dUILayout.SetBounds -= value;
    }

    public static event ILContext.Manipulator GetMinBounds
    {
        add => IL.tk2dUILayout.GetMinBounds += value;
        remove => IL.tk2dUILayout.GetMinBounds -= value;
    }

    public static event ILContext.Manipulator GetMaxBounds
    {
        add => IL.tk2dUILayout.GetMaxBounds += value;
        remove => IL.tk2dUILayout.GetMaxBounds -= value;
    }

    public static event ILContext.Manipulator Refresh
    {
        add => IL.tk2dUILayout.Refresh += value;
        remove => IL.tk2dUILayout.Refresh -= value;
    }
}