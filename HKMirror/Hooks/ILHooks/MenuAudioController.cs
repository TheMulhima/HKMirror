using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuAudioController.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuAudioController
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.MenuAudioController.Awake += value;
        remove => IL.MenuAudioController.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuAudioController), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuAudioController), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator PlaySelect
    {
        add => IL.MenuAudioController.PlaySelect += value;
        remove => IL.MenuAudioController.PlaySelect -= value;
    }

    public static event ILContext.Manipulator PlaySubmit
    {
        add => IL.MenuAudioController.PlaySubmit += value;
        remove => IL.MenuAudioController.PlaySubmit -= value;
    }

    public static event ILContext.Manipulator PlayCancel
    {
        add => IL.MenuAudioController.PlayCancel += value;
        remove => IL.MenuAudioController.PlayCancel -= value;
    }

    public static event ILContext.Manipulator PlaySlider
    {
        add => IL.MenuAudioController.PlaySlider += value;
        remove => IL.MenuAudioController.PlaySlider -= value;
    }

    public static event ILContext.Manipulator PlayStartGame
    {
        add => IL.MenuAudioController.PlayStartGame += value;
        remove => IL.MenuAudioController.PlayStartGame -= value;
    }
}