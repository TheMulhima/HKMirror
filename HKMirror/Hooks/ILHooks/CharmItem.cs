namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CharmItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCharmItem
{
    public static event ILContext.Manipulator GetListNumber
    {
        add => IL.CharmItem.GetListNumber += value;
        remove => IL.CharmItem.GetListNumber -= value;
    }

    public static event ILContext.Manipulator SetListNumber
    {
        add => IL.CharmItem.SetListNumber += value;
        remove => IL.CharmItem.SetListNumber -= value;
    }
}