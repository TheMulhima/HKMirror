using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Bullet.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBullet
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.Bullet.OnEnable += value;
        remove => IL.Bullet.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.Bullet.OnDisable += value;
        remove => IL.Bullet.OnDisable -= value;
    }

    public static event ILContext.Manipulator Shoot
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Bullet), "Shoot").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Bullet), "Shoot").GetStateMachineTarget(), value);
    }
}