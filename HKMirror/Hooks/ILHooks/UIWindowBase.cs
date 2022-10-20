namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UIWindowBase.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUIWindowBase
{
    public static event ILContext.Manipulator Start
    {
        add => IL.UIWindowBase.Start += value;
        remove => IL.UIWindowBase.Start -= value;
    }

    public static event ILContext.Manipulator OnDrag
    {
        add => IL.UIWindowBase.OnDrag += value;
        remove => IL.UIWindowBase.OnDrag -= value;
    }

    public static event ILContext.Manipulator ChangeStrength
    {
        add => IL.UIWindowBase.ChangeStrength += value;
        remove => IL.UIWindowBase.ChangeStrength -= value;
    }

    public static event ILContext.Manipulator ChangeVibrancy
    {
        add => IL.UIWindowBase.ChangeVibrancy += value;
        remove => IL.UIWindowBase.ChangeVibrancy -= value;
    }
}