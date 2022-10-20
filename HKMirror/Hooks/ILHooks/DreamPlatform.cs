namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DreamPlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDreamPlatform
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.DreamPlatform.Awake += value;
        remove => IL.DreamPlatform.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.DreamPlatform.Start += value;
        remove => IL.DreamPlatform.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DreamPlatform.OnEnable += value;
        remove => IL.DreamPlatform.OnEnable -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.DreamPlatform.Show += value;
        remove => IL.DreamPlatform.Show -= value;
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.DreamPlatform.Hide += value;
        remove => IL.DreamPlatform.Hide -= value;
    }

    public static event ILContext.Manipulator PlayAnimation
    {
        add => IL.DreamPlatform.PlayAnimation += value;
        remove => IL.DreamPlatform.PlayAnimation -= value;
    }
}