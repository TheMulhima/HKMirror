using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SoulOrb.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSoulOrb
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SoulOrb.Awake += value;
        remove => IL.SoulOrb.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.SoulOrb.Start += value;
        remove => IL.SoulOrb.Start -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.SoulOrb.OnDisable += value;
        remove => IL.SoulOrb.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SoulOrb.OnEnable += value;
        remove => IL.SoulOrb.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SoulOrb.Update += value;
        remove => IL.SoulOrb.Update -= value;
    }

    public static event ILContext.Manipulator SceneLoading
    {
        add => IL.SoulOrb.SceneLoading += value;
        remove => IL.SoulOrb.SceneLoading -= value;
    }

    public static event ILContext.Manipulator Zoom
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SoulOrb), "Zoom").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SoulOrb), "Zoom").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FireAtTarget
    {
        add => IL.SoulOrb.FireAtTarget += value;
        remove => IL.SoulOrb.FireAtTarget -= value;
    }

    public static event ILContext.Manipulator FaceAngle
    {
        add => IL.SoulOrb.FaceAngle += value;
        remove => IL.SoulOrb.FaceAngle -= value;
    }

    public static event ILContext.Manipulator ProjectileSquash
    {
        add => IL.SoulOrb.ProjectileSquash += value;
        remove => IL.SoulOrb.ProjectileSquash -= value;
    }
}