namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameCameraTextureDisplay.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameCameraTextureDisplay
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GameCameraTextureDisplay.Awake += value;
        remove => IL.GameCameraTextureDisplay.Awake -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.GameCameraTextureDisplay.LateUpdate += value;
        remove => IL.GameCameraTextureDisplay.LateUpdate -= value;
    }

    public static event ILContext.Manipulator UpdateDisplay
    {
        add => IL.GameCameraTextureDisplay.UpdateDisplay += value;
        remove => IL.GameCameraTextureDisplay.UpdateDisplay -= value;
    }
}