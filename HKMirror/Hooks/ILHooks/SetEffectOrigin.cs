namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetEffectOrigin.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetEffectOrigin
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetEffectOrigin.Reset += value;
        remove => IL.SetEffectOrigin.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetEffectOrigin.OnEnter += value;
        remove => IL.SetEffectOrigin.OnEnter -= value;
    }
}