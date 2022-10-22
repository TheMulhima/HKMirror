using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatue,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatue
{
    public static event ILContext.Manipulator get_UsingDreamVersion
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossStatue), "get_UsingDreamVersion"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "get_UsingDreamVersion"), value);
    }

    public static event ILContext.Manipulator set_UsingDreamVersion
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossStatue), "set_UsingDreamVersion"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "set_UsingDreamVersion"), value);
    }

    public static event ILContext.Manipulator set_StatueState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossStatue), "set_StatueState"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BossStatue), "set_StatueState"),
            value);
    }

    public static event ILContext.Manipulator set_DreamStatueState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossStatue), "set_DreamStatueState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "set_DreamStatueState"), value);
    }

    public static event ILContext.Manipulator get_HasRegularVersion
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossStatue), "get_HasRegularVersion"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "get_HasRegularVersion"), value);
    }

    public static event ILContext.Manipulator get_HasDreamVersion
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossStatue), "get_HasDreamVersion"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "get_HasDreamVersion"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.BossStatue.Awake += value;
        remove => IL.BossStatue.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossStatue.Start += value;
        remove => IL.BossStatue.Start -= value;
    }

    public static event ILContext.Manipulator SetPlaquesVisible
    {
        add => IL.BossStatue.SetPlaquesVisible += value;
        remove => IL.BossStatue.SetPlaquesVisible -= value;
    }

    public static event ILContext.Manipulator SetPlaqueState
    {
        add => IL.BossStatue.SetPlaqueState += value;
        remove => IL.BossStatue.SetPlaqueState -= value;
    }

    public static event ILContext.Manipulator SetDreamVersion
    {
        add => IL.BossStatue.SetDreamVersion += value;
        remove => IL.BossStatue.SetDreamVersion -= value;
    }

    public static event ILContext.Manipulator UpdateDetails
    {
        add => IL.BossStatue.UpdateDetails += value;
        remove => IL.BossStatue.UpdateDetails -= value;
    }

    public static event ILContext.Manipulator SwapStatues
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "SwapStatues").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "SwapStatues").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Jitter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "Jitter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "Jitter").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator PlayAnimWait
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "PlayAnimWait").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "PlayAnimWait").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator PlayParticlesDelay
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "PlayParticlesDelay").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "PlayParticlesDelay").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator PlayAudioEventDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "PlayAudioEventDelayed").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatue), "PlayAudioEventDelayed").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnDrawGizmosSelected
    {
        add => IL.BossStatue.OnDrawGizmosSelected += value;
        remove => IL.BossStatue.OnDrawGizmosSelected -= value;
    }
}