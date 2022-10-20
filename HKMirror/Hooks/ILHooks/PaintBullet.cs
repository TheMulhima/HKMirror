using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PaintBullet.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPaintBullet
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.PaintBullet.Awake += value;
        remove => IL.PaintBullet.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PaintBullet.OnEnable += value;
        remove => IL.PaintBullet.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PaintBullet.Update += value;
        remove => IL.PaintBullet.Update -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.PaintBullet.OnTriggerEnter2D += value;
        remove => IL.PaintBullet.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.PaintBullet.OnTriggerExit2D += value;
        remove => IL.PaintBullet.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.PaintBullet.OnCollisionEnter2D += value;
        remove => IL.PaintBullet.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OrbitShieldHit
    {
        add => IL.PaintBullet.OrbitShieldHit += value;
        remove => IL.PaintBullet.OrbitShieldHit -= value;
    }

    public static event ILContext.Manipulator Collision
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PaintBullet), "Collision").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PaintBullet), "Collision").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetColourBlue
    {
        add => IL.PaintBullet.SetColourBlue += value;
        remove => IL.PaintBullet.SetColourBlue -= value;
    }

    public static event ILContext.Manipulator SetColourRed
    {
        add => IL.PaintBullet.SetColourRed += value;
        remove => IL.PaintBullet.SetColourRed -= value;
    }

    public static event ILContext.Manipulator SetBlue
    {
        add => IL.PaintBullet.SetBlue += value;
        remove => IL.PaintBullet.SetBlue -= value;
    }

    public static event ILContext.Manipulator SetRed
    {
        add => IL.PaintBullet.SetRed += value;
        remove => IL.PaintBullet.SetRed -= value;
    }

    public static event ILContext.Manipulator SetPink
    {
        add => IL.PaintBullet.SetPink += value;
        remove => IL.PaintBullet.SetPink -= value;
    }
}