using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSequenceBindingsDoor.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSequenceBindingsDoor
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossSequenceBindingsDoor.Awake += value;
        remove => IL.BossSequenceBindingsDoor.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossSequenceBindingsDoor.Start += value;
        remove => IL.BossSequenceBindingsDoor.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BossSequenceBindingsDoor.OnTriggerEnter2D += value;
        remove => IL.BossSequenceBindingsDoor.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator SetUnlocked
    {
        add => IL.BossSequenceBindingsDoor.SetUnlocked += value;
        remove => IL.BossSequenceBindingsDoor.SetUnlocked -= value;
    }

    public static event ILContext.Manipulator DoUnlockAnimation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceBindingsDoor), "DoUnlockAnimation")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceBindingsDoor), "DoUnlockAnimation")
                .GetStateMachineTarget(), value);
    }
}