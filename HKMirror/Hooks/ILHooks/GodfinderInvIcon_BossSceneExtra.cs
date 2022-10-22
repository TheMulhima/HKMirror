using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for GodfinderInvIcon_BossSceneExtra,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGodfinderInvIcon_BossSceneExtra
{
public static event ILContext.Manipulator IsUnlocked
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GodfinderInvIcon.BossSceneExtra), "IsUnlocked", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GodfinderInvIcon.BossSceneExtra), "IsUnlocked", true), value);
}
}
