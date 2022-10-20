using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Explosion.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILExplosion
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "Reset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "Reset"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "OnPreprocess"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "OnPreprocess"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "OnFixedUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "OnFixedUpdate"), value);
    }

    public static event ILContext.Manipulator DoExplosion
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "DoExplosion"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "DoExplosion"), value);
    }

    public static event ILContext.Manipulator ShouldApplyForce
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "ShouldApplyForce"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Explosion), "ShouldApplyForce"), value);
    }
}