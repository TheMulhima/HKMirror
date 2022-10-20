using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for NailSlash.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILNailSlash
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.NailSlash.Awake += value;
        remove => IL.NailSlash.Awake -= value;
    }

    public static event ILContext.Manipulator StartSlash
    {
        add => IL.NailSlash.StartSlash += value;
        remove => IL.NailSlash.StartSlash -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.NailSlash.FixedUpdate += value;
        remove => IL.NailSlash.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.NailSlash.OnTriggerEnter2D += value;
        remove => IL.NailSlash.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Bounce
    {
        add => IL.NailSlash.Bounce += value;
        remove => IL.NailSlash.Bounce -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.NailSlash.OnTriggerStay2D += value;
        remove => IL.NailSlash.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator Disable
    {
        add => IL.NailSlash.Disable += value;
        remove => IL.NailSlash.Disable -= value;
    }

    public static event ILContext.Manipulator SetLongnail
    {
        add => IL.NailSlash.SetLongnail += value;
        remove => IL.NailSlash.SetLongnail -= value;
    }

    public static event ILContext.Manipulator SetMantis
    {
        add => IL.NailSlash.SetMantis += value;
        remove => IL.NailSlash.SetMantis -= value;
    }

    public static event ILContext.Manipulator SetFury
    {
        add => IL.NailSlash.SetFury += value;
        remove => IL.NailSlash.SetFury -= value;
    }

    public static event ILContext.Manipulator CancelAttack
    {
        add => IL.NailSlash.CancelAttack += value;
        remove => IL.NailSlash.CancelAttack -= value;
    }

    public static event ILContext.Manipulator orig_OnTriggerEnter2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NailSlash), "orig_OnTriggerEnter2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NailSlash), "orig_OnTriggerEnter2D"), value);
    }
}