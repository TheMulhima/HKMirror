using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BuildMetadata.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBuildMetadata
{
    public static event ILContext.Manipulator get_BranchName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BranchName"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BranchName"),
            value);
    }

    public static event ILContext.Manipulator get_Revision
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Revision"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Revision"),
            value);
    }

    public static event ILContext.Manipulator get_CommitTime
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_CommitTime"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_CommitTime"),
            value);
    }

    public static event ILContext.Manipulator get_MachineName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_MachineName"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_MachineName"),
            value);
    }

    public static event ILContext.Manipulator get_BuildTime
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BuildTime"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BuildTime"),
            value);
    }

    public static event ILContext.Manipulator get_Embedded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Embedded", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Embedded", false), value);
    }

    public static event ILContext.Manipulator Create
    {
        add => IL.BuildMetadata.Create += value;
        remove => IL.BuildMetadata.Create -= value;
    }
}