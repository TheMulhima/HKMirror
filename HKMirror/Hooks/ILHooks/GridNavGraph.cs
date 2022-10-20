using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GridNavGraph.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGridNavGraph
{
    public static event ILContext.Manipulator get_Columns
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "get_Columns"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "get_Columns"),
            value);
    }

    public static event ILContext.Manipulator set_Columns
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "set_Columns"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "set_Columns"),
            value);
    }

    public static event ILContext.Manipulator ChangeColumns
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "ChangeColumns"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "ChangeColumns"),
            value);
    }

    public static event ILContext.Manipulator AddNavigationNode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "AddNavigationNode"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "AddNavigationNode"), value);
    }

    public static event ILContext.Manipulator BuildNavigation
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "BuildNavigation"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "BuildNavigation"),
            value);
    }
}