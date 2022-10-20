namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DustyPlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDustyPlatform
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.DustyPlatform.Reset += value;
        remove => IL.DustyPlatform.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.DustyPlatform.Awake += value;
        remove => IL.DustyPlatform.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DustyPlatform.Update += value;
        remove => IL.DustyPlatform.Update -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.DustyPlatform.OnCollisionEnter2D += value;
        remove => IL.DustyPlatform.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator SpawnRocks
    {
        add => IL.DustyPlatform.SpawnRocks += value;
        remove => IL.DustyPlatform.SpawnRocks -= value;
    }

    public static event ILContext.Manipulator SetRateOverTime
    {
        add => IL.DustyPlatform.SetRateOverTime += value;
        remove => IL.DustyPlatform.SetRateOverTime -= value;
    }
}