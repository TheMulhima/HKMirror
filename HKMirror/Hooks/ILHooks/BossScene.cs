using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossScene.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossScene
{
    public static event ILContext.Manipulator get_DisplayIcon
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_DisplayIcon"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_DisplayIcon"),
            value);
    }

    public static event ILContext.Manipulator get_ForceAssetUnload
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_ForceAssetUnload"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_ForceAssetUnload"), value);
    }

    public static event ILContext.Manipulator get_Tier1Scene
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier1Scene"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier1Scene"),
            value);
    }

    public static event ILContext.Manipulator get_Tier2Scene
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier2Scene"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier2Scene"),
            value);
    }

    public static event ILContext.Manipulator get_Tier3Scene
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier3Scene"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier3Scene"),
            value);
    }

    public static event ILContext.Manipulator IsUnlocked
    {
        add => IL.BossScene.IsUnlocked += value;
        remove => IL.BossScene.IsUnlocked -= value;
    }

    public static event ILContext.Manipulator IsUnlockedSelf
    {
        add => IL.BossScene.IsUnlockedSelf += value;
        remove => IL.BossScene.IsUnlockedSelf -= value;
    }
}