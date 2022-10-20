using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSequence.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSequence
{
    public static event ILContext.Manipulator get_Count
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossSequence), "get_Count"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BossSequence), "get_Count"), value);
    }

    public static event ILContext.Manipulator GetSceneAt
    {
        add => IL.BossSequence.GetSceneAt += value;
        remove => IL.BossSequence.GetSceneAt -= value;
    }

    public static event ILContext.Manipulator GetSceneObjectName
    {
        add => IL.BossSequence.GetSceneObjectName += value;
        remove => IL.BossSequence.GetSceneObjectName -= value;
    }

    public static event ILContext.Manipulator CanLoad
    {
        add => IL.BossSequence.CanLoad += value;
        remove => IL.BossSequence.CanLoad -= value;
    }

    public static event ILContext.Manipulator GetBossScene
    {
        add => IL.BossSequence.GetBossScene += value;
        remove => IL.BossSequence.GetBossScene -= value;
    }

    public static event ILContext.Manipulator IsUnlocked
    {
        add => IL.BossSequence.IsUnlocked += value;
        remove => IL.BossSequence.IsUnlocked -= value;
    }

    public static event ILContext.Manipulator IsSceneHidden
    {
        add => IL.BossSequence.IsSceneHidden += value;
        remove => IL.BossSequence.IsSceneHidden -= value;
    }
}