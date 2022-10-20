namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RadialLayoutUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRadialLayoutUI
{
    public static event ILContext.Manipulator Update
    {
        add => IL.RadialLayoutUI.Update += value;
        remove => IL.RadialLayoutUI.Update -= value;
    }

    public static event ILContext.Manipulator OnTransformChildrenChanged
    {
        add => IL.RadialLayoutUI.OnTransformChildrenChanged += value;
        remove => IL.RadialLayoutUI.OnTransformChildrenChanged -= value;
    }

    public static event ILContext.Manipulator HasValueChanged
    {
        add => IL.RadialLayoutUI.HasValueChanged += value;
        remove => IL.RadialLayoutUI.HasValueChanged -= value;
    }

    public static event ILContext.Manipulator UpdateUI
    {
        add => IL.RadialLayoutUI.UpdateUI += value;
        remove => IL.RadialLayoutUI.UpdateUI -= value;
    }
}