namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Grass.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrass
{
    public static event ILContext.Manipulator Init
    {
        add => IL.Grass.Init += value;
        remove => IL.Grass.Init -= value;
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.Grass.Reset += value;
        remove => IL.Grass.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.Grass.Awake += value;
        remove => IL.Grass.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.Grass.OnDestroy += value;
        remove => IL.Grass.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.Grass.Start += value;
        remove => IL.Grass.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.Grass.OnTriggerEnter2D += value;
        remove => IL.Grass.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Push
    {
        add => IL.Grass.Push += value;
        remove => IL.Grass.Push -= value;
    }

    public static event ILContext.Manipulator PushAll
    {
        add => IL.Grass.PushAll += value;
        remove => IL.Grass.PushAll -= value;
    }

    public static event ILContext.Manipulator Hit
    {
        add => IL.Grass.Hit += value;
        remove => IL.Grass.Hit -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.Grass.Update += value;
        remove => IL.Grass.Update -= value;
    }
}