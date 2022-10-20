using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueDreamToggle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueDreamToggle
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.BossStatueDreamToggle.OnEnable += value;
        remove => IL.BossStatueDreamToggle.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossStatueDreamToggle.Start += value;
        remove => IL.BossStatueDreamToggle.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BossStatueDreamToggle.OnTriggerEnter2D += value;
        remove => IL.BossStatueDreamToggle.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Fade
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueDreamToggle), "Fade").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueDreamToggle), "Fade").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetOwner
    {
        add => IL.BossStatueDreamToggle.SetOwner += value;
        remove => IL.BossStatueDreamToggle.SetOwner -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.BossStatueDreamToggle.SetState += value;
        remove => IL.BossStatueDreamToggle.SetState -= value;
    }
}