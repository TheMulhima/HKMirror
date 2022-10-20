namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUISoundItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUISoundItem
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUISoundItem.OnEnable += value;
        remove => IL.tk2dUISoundItem.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUISoundItem.OnDisable += value;
        remove => IL.tk2dUISoundItem.OnDisable -= value;
    }

    public static event ILContext.Manipulator PlayDownSound
    {
        add => IL.tk2dUISoundItem.PlayDownSound += value;
        remove => IL.tk2dUISoundItem.PlayDownSound -= value;
    }

    public static event ILContext.Manipulator PlayUpSound
    {
        add => IL.tk2dUISoundItem.PlayUpSound += value;
        remove => IL.tk2dUISoundItem.PlayUpSound -= value;
    }

    public static event ILContext.Manipulator PlayClickSound
    {
        add => IL.tk2dUISoundItem.PlayClickSound += value;
        remove => IL.tk2dUISoundItem.PlayClickSound -= value;
    }

    public static event ILContext.Manipulator PlayReleaseSound
    {
        add => IL.tk2dUISoundItem.PlayReleaseSound += value;
        remove => IL.tk2dUISoundItem.PlayReleaseSound -= value;
    }

    public static event ILContext.Manipulator PlaySound
    {
        add => IL.tk2dUISoundItem.PlaySound += value;
        remove => IL.tk2dUISoundItem.PlaySound -= value;
    }
}