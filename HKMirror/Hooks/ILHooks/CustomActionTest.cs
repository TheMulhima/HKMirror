namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CustomActionTest.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCustomActionTest
{
    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CustomActionTest.OnEnter += value;
        remove => IL.CustomActionTest.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.CustomActionTest.OnUpdate += value;
        remove => IL.CustomActionTest.OnUpdate -= value;
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => IL.CustomActionTest.OnFixedUpdate += value;
        remove => IL.CustomActionTest.OnFixedUpdate -= value;
    }

    public static event ILContext.Manipulator OnLateUpdate
    {
        add => IL.CustomActionTest.OnLateUpdate += value;
        remove => IL.CustomActionTest.OnLateUpdate -= value;
    }

    public static event ILContext.Manipulator OnExit
    {
        add => IL.CustomActionTest.OnExit += value;
        remove => IL.CustomActionTest.OnExit -= value;
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => IL.CustomActionTest.ErrorCheck += value;
        remove => IL.CustomActionTest.ErrorCheck -= value;
    }
}