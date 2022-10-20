namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrassSpriteBehaviour.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrassSpriteBehaviour
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GrassSpriteBehaviour.Awake += value;
        remove => IL.GrassSpriteBehaviour.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GrassSpriteBehaviour.Start += value;
        remove => IL.GrassSpriteBehaviour.Start -= value;
    }

    public static event ILContext.Manipulator OnBecameVisible
    {
        add => IL.GrassSpriteBehaviour.OnBecameVisible += value;
        remove => IL.GrassSpriteBehaviour.OnBecameVisible -= value;
    }

    public static event ILContext.Manipulator OnBecameInvisible
    {
        add => IL.GrassSpriteBehaviour.OnBecameInvisible += value;
        remove => IL.GrassSpriteBehaviour.OnBecameInvisible -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GrassSpriteBehaviour.OnTriggerEnter2D += value;
        remove => IL.GrassSpriteBehaviour.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.GrassSpriteBehaviour.Init += value;
        remove => IL.GrassSpriteBehaviour.Init -= value;
    }

    public static event ILContext.Manipulator SetWindy
    {
        add => IL.GrassSpriteBehaviour.SetWindy += value;
        remove => IL.GrassSpriteBehaviour.SetWindy -= value;
    }

    public static event ILContext.Manipulator SetNotWindy
    {
        add => IL.GrassSpriteBehaviour.SetNotWindy += value;
        remove => IL.GrassSpriteBehaviour.SetNotWindy -= value;
    }
}