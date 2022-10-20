namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetNailDamage.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetNailDamage
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetNailDamage.Reset += value;
        remove => IL.GetNailDamage.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetNailDamage.OnEnter += value;
        remove => IL.GetNailDamage.OnEnter -= value;
    }
}