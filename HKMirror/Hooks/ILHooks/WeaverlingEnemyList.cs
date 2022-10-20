namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WeaverlingEnemyList.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWeaverlingEnemyList
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.WeaverlingEnemyList.OnEnable += value;
        remove => IL.WeaverlingEnemyList.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.WeaverlingEnemyList.OnTriggerEnter2D += value;
        remove => IL.WeaverlingEnemyList.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.WeaverlingEnemyList.OnTriggerExit2D += value;
        remove => IL.WeaverlingEnemyList.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator GetTarget
    {
        add => IL.WeaverlingEnemyList.GetTarget += value;
        remove => IL.WeaverlingEnemyList.GetTarget -= value;
    }
}