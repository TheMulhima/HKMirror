namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CollisionEnterEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCollisionEnterEvent
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CollisionEnterEvent.Awake += value;
        remove => IL.CollisionEnterEvent.Awake -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.CollisionEnterEvent.OnCollisionEnter2D += value;
        remove => IL.CollisionEnterEvent.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionStay2D
    {
        add => IL.CollisionEnterEvent.OnCollisionStay2D += value;
        remove => IL.CollisionEnterEvent.OnCollisionStay2D -= value;
    }

    public static event ILContext.Manipulator HandleCollision
    {
        add => IL.CollisionEnterEvent.HandleCollision += value;
        remove => IL.CollisionEnterEvent.HandleCollision -= value;
    }

    public static event ILContext.Manipulator CheckTouching
    {
        add => IL.CollisionEnterEvent.CheckTouching += value;
        remove => IL.CollisionEnterEvent.CheckTouching -= value;
    }
}