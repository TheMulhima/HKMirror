namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUGuiSceneProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUGuiSceneProxy
{
    public static event ILContext.Manipulator Start
    {
        add => IL.PlayMakerUGuiSceneProxy.Start += value;
        remove => IL.PlayMakerUGuiSceneProxy.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PlayMakerUGuiSceneProxy.Update += value;
        remove => IL.PlayMakerUGuiSceneProxy.Update -= value;
    }
}