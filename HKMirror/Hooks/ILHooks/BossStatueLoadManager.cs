using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueLoadManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueLoadManager
{
    public static event ILContext.Manipulator get_ShouldUnload
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueLoadManager), "get_ShouldUnload", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueLoadManager), "get_ShouldUnload", false), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.BossStatueLoadManager.OnEnable += value;
        remove => IL.BossStatueLoadManager.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.BossStatueLoadManager.OnDisable += value;
        remove => IL.BossStatueLoadManager.OnDisable -= value;
    }

    public static event ILContext.Manipulator Clear
    {
        add => IL.BossStatueLoadManager.Clear += value;
        remove => IL.BossStatueLoadManager.Clear -= value;
    }

    public static event ILContext.Manipulator RecordBossScene
    {
        add => IL.BossStatueLoadManager.RecordBossScene += value;
        remove => IL.BossStatueLoadManager.RecordBossScene -= value;
    }
}