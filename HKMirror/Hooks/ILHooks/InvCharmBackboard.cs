namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InvCharmBackboard.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInvCharmBackboard
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.InvCharmBackboard.Awake += value;
        remove => IL.InvCharmBackboard.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.InvCharmBackboard.OnEnable += value;
        remove => IL.InvCharmBackboard.OnEnable -= value;
    }

    public static event ILContext.Manipulator SelectCharm
    {
        add => IL.InvCharmBackboard.SelectCharm += value;
        remove => IL.InvCharmBackboard.SelectCharm -= value;
    }

    public static event ILContext.Manipulator GetCharmNum
    {
        add => IL.InvCharmBackboard.GetCharmNum += value;
        remove => IL.InvCharmBackboard.GetCharmNum -= value;
    }

    public static event ILContext.Manipulator GetCharmString
    {
        add => IL.InvCharmBackboard.GetCharmString += value;
        remove => IL.InvCharmBackboard.GetCharmString -= value;
    }

    public static event ILContext.Manipulator GetCharmNumString
    {
        add => IL.InvCharmBackboard.GetCharmNumString += value;
        remove => IL.InvCharmBackboard.GetCharmNumString -= value;
    }
}