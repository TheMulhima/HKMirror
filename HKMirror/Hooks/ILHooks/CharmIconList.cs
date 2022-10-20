namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CharmIconList.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCharmIconList
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CharmIconList.Awake += value;
        remove => IL.CharmIconList.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.CharmIconList.Start += value;
        remove => IL.CharmIconList.Start -= value;
    }

    public static event ILContext.Manipulator GetSprite
    {
        add => IL.CharmIconList.GetSprite += value;
        remove => IL.CharmIconList.GetSprite -= value;
    }
}