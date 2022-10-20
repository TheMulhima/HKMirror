namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrimmEnemyRange.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrimmEnemyRange
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GrimmEnemyRange.OnEnable += value;
        remove => IL.GrimmEnemyRange.OnEnable -= value;
    }

    public static event ILContext.Manipulator IsEnemyInRange
    {
        add => IL.GrimmEnemyRange.IsEnemyInRange += value;
        remove => IL.GrimmEnemyRange.IsEnemyInRange -= value;
    }

    public static event ILContext.Manipulator GetTarget
    {
        add => IL.GrimmEnemyRange.GetTarget += value;
        remove => IL.GrimmEnemyRange.GetTarget -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GrimmEnemyRange.OnTriggerEnter2D += value;
        remove => IL.GrimmEnemyRange.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.GrimmEnemyRange.OnTriggerExit2D += value;
        remove => IL.GrimmEnemyRange.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator ClearEnemyList
    {
        add => IL.GrimmEnemyRange.ClearEnemyList += value;
        remove => IL.GrimmEnemyRange.ClearEnemyList -= value;
    }
}