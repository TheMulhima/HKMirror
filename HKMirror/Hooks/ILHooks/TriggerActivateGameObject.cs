namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TriggerActivateGameObject.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTriggerActivateGameObject
{
    public static event ILContext.Manipulator Start
    {
        add => IL.TriggerActivateGameObject.Start += value;
        remove => IL.TriggerActivateGameObject.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TriggerActivateGameObject.OnTriggerEnter2D += value;
        remove => IL.TriggerActivateGameObject.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.TriggerActivateGameObject.OnTriggerStay2D += value;
        remove => IL.TriggerActivateGameObject.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.TriggerActivateGameObject.OnTriggerExit2D += value;
        remove => IL.TriggerActivateGameObject.OnTriggerExit2D -= value;
    }
}