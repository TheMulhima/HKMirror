using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FakeBat.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFakeBat
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.FakeBat.Awake += value;
        remove => IL.FakeBat.Awake -= value;
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.FakeBat.Init += value;
        remove => IL.FakeBat.Init -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.FakeBat.OnEnable += value;
        remove => IL.FakeBat.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.FakeBat.OnDisable += value;
        remove => IL.FakeBat.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.FakeBat.Start += value;
        remove => IL.FakeBat.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.FakeBat.Update += value;
        remove => IL.FakeBat.Update -= value;
    }

    public static event ILContext.Manipulator NotifyAllBossAwake
    {
        add => IL.FakeBat.NotifyAllBossAwake += value;
        remove => IL.FakeBat.NotifyAllBossAwake -= value;
    }

    public static event ILContext.Manipulator NotifyBossAwake
    {
        add => IL.FakeBat.NotifyBossAwake += value;
        remove => IL.FakeBat.NotifyBossAwake -= value;
    }

    public static event ILContext.Manipulator SendAllOut
    {
        add => IL.FakeBat.SendAllOut += value;
        remove => IL.FakeBat.SendAllOut -= value;
    }

    public static event ILContext.Manipulator SendOut
    {
        add => IL.FakeBat.SendOut += value;
        remove => IL.FakeBat.SendOut -= value;
    }

    public static event ILContext.Manipulator SendOutRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(FakeBat), "SendOutRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FakeBat), "SendOutRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator BringAllIn
    {
        add => IL.FakeBat.BringAllIn += value;
        remove => IL.FakeBat.BringAllIn -= value;
    }

    public static event ILContext.Manipulator BringIn
    {
        add => IL.FakeBat.BringIn += value;
        remove => IL.FakeBat.BringIn -= value;
    }

    public static event ILContext.Manipulator BringInRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(FakeBat), "BringInRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FakeBat), "BringInRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FaceDirection
    {
        add => IL.FakeBat.FaceDirection += value;
        remove => IL.FakeBat.FaceDirection -= value;
    }

    public static event ILContext.Manipulator Accelerate
    {
        add => IL.FakeBat.Accelerate += value;
        remove => IL.FakeBat.Accelerate -= value;
    }
}