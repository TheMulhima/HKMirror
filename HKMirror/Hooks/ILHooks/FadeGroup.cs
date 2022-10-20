namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FadeGroup.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFadeGroup
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.FadeGroup.OnEnable += value;
        remove => IL.FadeGroup.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.FadeGroup.Update += value;
        remove => IL.FadeGroup.Update -= value;
    }

    public static event ILContext.Manipulator FadeUp
    {
        add => IL.FadeGroup.FadeUp += value;
        remove => IL.FadeGroup.FadeUp -= value;
    }

    public static event ILContext.Manipulator FadeDown
    {
        add => IL.FadeGroup.FadeDown += value;
        remove => IL.FadeGroup.FadeDown -= value;
    }

    public static event ILContext.Manipulator FadeDownFast
    {
        add => IL.FadeGroup.FadeDownFast += value;
        remove => IL.FadeGroup.FadeDownFast -= value;
    }

    public static event ILContext.Manipulator DisableRenderers
    {
        add => IL.FadeGroup.DisableRenderers += value;
        remove => IL.FadeGroup.DisableRenderers -= value;
    }
}