namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Breakable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBreakable
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.Breakable.Reset += value;
        remove => IL.Breakable.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.Breakable.Awake += value;
        remove => IL.Breakable.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.Breakable.Start += value;
        remove => IL.Breakable.Start -= value;
    }

    public static event ILContext.Manipulator CreateAdditionalDebrisParts
    {
        add => IL.Breakable.CreateAdditionalDebrisParts += value;
        remove => IL.Breakable.CreateAdditionalDebrisParts -= value;
    }

    public static event ILContext.Manipulator BreakSelf
    {
        add => IL.Breakable.BreakSelf += value;
        remove => IL.Breakable.BreakSelf -= value;
    }

    public static event ILContext.Manipulator Hit
    {
        add => IL.Breakable.Hit += value;
        remove => IL.Breakable.Hit -= value;
    }

    public static event ILContext.Manipulator SpawnNailHitEffect
    {
        add => IL.Breakable.SpawnNailHitEffect += value;
        remove => IL.Breakable.SpawnNailHitEffect -= value;
    }

    public static event ILContext.Manipulator SetStaticPartsActivation
    {
        add => IL.Breakable.SetStaticPartsActivation += value;
        remove => IL.Breakable.SetStaticPartsActivation -= value;
    }

    public static event ILContext.Manipulator Break
    {
        add => IL.Breakable.Break += value;
        remove => IL.Breakable.Break -= value;
    }
}