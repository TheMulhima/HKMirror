using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Corpse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpse
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.Corpse.Awake += value;
        remove => IL.Corpse.Awake -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.Corpse.Setup += value;
        remove => IL.Corpse.Setup -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.Corpse.Start += value;
        remove => IL.Corpse.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.Corpse.Update += value;
        remove => IL.Corpse.Update -= value;
    }

    public static event ILContext.Manipulator Complete
    {
        add => IL.Corpse.Complete += value;
        remove => IL.Corpse.Complete -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.Corpse.OnCollisionEnter2D += value;
        remove => IL.Corpse.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionStay2D
    {
        add => IL.Corpse.OnCollisionStay2D += value;
        remove => IL.Corpse.OnCollisionStay2D -= value;
    }

    public static event ILContext.Manipulator OnCollision
    {
        add => IL.Corpse.OnCollision += value;
        remove => IL.Corpse.OnCollision -= value;
    }

    public static event ILContext.Manipulator Land
    {
        add => IL.Corpse.Land += value;
        remove => IL.Corpse.Land -= value;
    }

    public static event ILContext.Manipulator LandEffects
    {
        add => IL.Corpse.LandEffects += value;
        remove => IL.Corpse.LandEffects -= value;
    }

    public static event ILContext.Manipulator Smash
    {
        add => IL.Corpse.Smash += value;
        remove => IL.Corpse.Smash -= value;
    }

    public static event ILContext.Manipulator Acid
    {
        add => IL.Corpse.Acid += value;
        remove => IL.Corpse.Acid -= value;
    }

    public static event ILContext.Manipulator DropThroughFloor
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Corpse), "DropThroughFloor").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Corpse), "DropThroughFloor").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator DisableFlame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Corpse), "DisableFlame").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Corpse), "DisableFlame").GetStateMachineTarget(), value);
    }
}