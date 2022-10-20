using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Recoil.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRecoil
{
    public static event ILContext.Manipulator get_SkipFreezingByController
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Recoil), "get_SkipFreezingByController"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Recoil), "get_SkipFreezingByController"), value);
    }

    public static event ILContext.Manipulator set_SkipFreezingByController
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Recoil), "set_SkipFreezingByController"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Recoil), "set_SkipFreezingByController"), value);
    }

    public static event ILContext.Manipulator get_IsRecoiling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Recoil), "get_IsRecoiling"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Recoil), "get_IsRecoiling"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.Recoil.Reset += value;
        remove => IL.Recoil.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.Recoil.Awake += value;
        remove => IL.Recoil.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.Recoil.OnEnable += value;
        remove => IL.Recoil.OnEnable -= value;
    }

    public static event ILContext.Manipulator RecoilByHealthManagerFSMParameters
    {
        add => IL.Recoil.RecoilByHealthManagerFSMParameters += value;
        remove => IL.Recoil.RecoilByHealthManagerFSMParameters -= value;
    }

    public static event ILContext.Manipulator RecoilByDamage
    {
        add => IL.Recoil.RecoilByDamage += value;
        remove => IL.Recoil.RecoilByDamage -= value;
    }

    public static event ILContext.Manipulator RecoilByDirection
    {
        add => IL.Recoil.RecoilByDirection += value;
        remove => IL.Recoil.RecoilByDirection -= value;
    }

    public static event ILContext.Manipulator CancelRecoil
    {
        add => IL.Recoil.CancelRecoil += value;
        remove => IL.Recoil.CancelRecoil -= value;
    }

    public static event ILContext.Manipulator Freeze
    {
        add => IL.Recoil.Freeze += value;
        remove => IL.Recoil.Freeze -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.Recoil.FixedUpdate += value;
        remove => IL.Recoil.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator UpdatePhysics
    {
        add => IL.Recoil.UpdatePhysics += value;
        remove => IL.Recoil.UpdatePhysics -= value;
    }

    public static event ILContext.Manipulator SetRecoilSpeed
    {
        add => IL.Recoil.SetRecoilSpeed += value;
        remove => IL.Recoil.SetRecoilSpeed -= value;
    }
}