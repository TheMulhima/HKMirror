namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeepInScene.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeepInScene
{
    public static event ILContext.Manipulator Start
    {
        add => IL.KeepInScene.Start += value;
        remove => IL.KeepInScene.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.KeepInScene.OnEnable += value;
        remove => IL.KeepInScene.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.KeepInScene.Update += value;
        remove => IL.KeepInScene.Update -= value;
    }
}