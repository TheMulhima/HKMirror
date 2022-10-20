namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DebrisPiece.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDebrisPiece
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.DebrisPiece.Reset += value;
        remove => IL.DebrisPiece.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.DebrisPiece.Awake += value;
        remove => IL.DebrisPiece.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DebrisPiece.OnEnable += value;
        remove => IL.DebrisPiece.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.DebrisPiece.OnDisable += value;
        remove => IL.DebrisPiece.OnDisable -= value;
    }

    public static event ILContext.Manipulator Launch
    {
        add => IL.DebrisPiece.Launch += value;
        remove => IL.DebrisPiece.Launch -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.DebrisPiece.FixedUpdate += value;
        remove => IL.DebrisPiece.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator Spin
    {
        add => IL.DebrisPiece.Spin += value;
        remove => IL.DebrisPiece.Spin -= value;
    }
}