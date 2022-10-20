using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VinePlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVinePlatform
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.VinePlatform.Awake += value;
        remove => IL.VinePlatform.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.VinePlatform.Start += value;
        remove => IL.VinePlatform.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.VinePlatform.Update += value;
        remove => IL.VinePlatform.Update -= value;
    }

    public static event ILContext.Manipulator Land
    {
        add => IL.VinePlatform.Land += value;
        remove => IL.VinePlatform.Land -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.VinePlatform.OnCollisionEnter2D += value;
        remove => IL.VinePlatform.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator PlaySound
    {
        add => IL.VinePlatform.PlaySound += value;
        remove => IL.VinePlatform.PlaySound -= value;
    }

    public static event ILContext.Manipulator PlayerLand
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(VinePlatform), "PlayerLand").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VinePlatform), "PlayerLand").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnDrawGizmosSelected
    {
        add => IL.VinePlatform.OnDrawGizmosSelected += value;
        remove => IL.VinePlatform.OnDrawGizmosSelected -= value;
    }
}