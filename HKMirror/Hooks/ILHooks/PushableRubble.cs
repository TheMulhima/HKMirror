namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PushableRubble.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPushableRubble
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.PushableRubble.Awake += value;
        remove => IL.PushableRubble.Awake -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.PushableRubble.OnTriggerEnter2D += value;
        remove => IL.PushableRubble.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Push
    {
        add => IL.PushableRubble.Push += value;
        remove => IL.PushableRubble.Push -= value;
    }

    public static event ILContext.Manipulator EndRubble
    {
        add => IL.PushableRubble.EndRubble += value;
        remove => IL.PushableRubble.EndRubble -= value;
    }

    public static event ILContext.Manipulator EndRubbleContinuation
    {
        add => IL.PushableRubble.EndRubbleContinuation += value;
        remove => IL.PushableRubble.EndRubbleContinuation -= value;
    }
}