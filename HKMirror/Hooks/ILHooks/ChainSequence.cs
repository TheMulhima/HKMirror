using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ChainSequence.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILChainSequence
{
    public static event ILContext.Manipulator get_CurrentSequence
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_CurrentSequence"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_CurrentSequence"), value);
    }

    public static event ILContext.Manipulator get_IsCurrentSkipped
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_IsCurrentSkipped"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_IsCurrentSkipped"), value);
    }

    public static event ILContext.Manipulator get_IsSkipped
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_IsSkipped"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_IsSkipped"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.ChainSequence.Awake += value;
        remove => IL.ChainSequence.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ChainSequence.Update += value;
        remove => IL.ChainSequence.Update -= value;
    }

    public static event ILContext.Manipulator Begin
    {
        add => IL.ChainSequence.Begin += value;
        remove => IL.ChainSequence.Begin -= value;
    }

    public static event ILContext.Manipulator Next
    {
        add => IL.ChainSequence.Next += value;
        remove => IL.ChainSequence.Next -= value;
    }

    public static event ILContext.Manipulator get_IsPlaying
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_IsPlaying"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_IsPlaying"),
            value);
    }

    public static event ILContext.Manipulator Skip
    {
        add => IL.ChainSequence.Skip += value;
        remove => IL.ChainSequence.Skip -= value;
    }

    public static event ILContext.Manipulator SkipSingle
    {
        add => IL.ChainSequence.SkipSingle += value;
        remove => IL.ChainSequence.SkipSingle -= value;
    }

    public static event ILContext.Manipulator get_FadeByController
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_FadeByController"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "get_FadeByController"), value);
    }

    public static event ILContext.Manipulator set_FadeByController
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "set_FadeByController"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ChainSequence), "set_FadeByController"), value);
    }
}