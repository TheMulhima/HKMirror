namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueLever.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueLever
{
    public static event ILContext.Manipulator Enable
    {
        add => IL.BossStatueLever.Enable += value;
        remove => IL.BossStatueLever.Enable -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BossStatueLever.OnTriggerEnter2D += value;
        remove => IL.BossStatueLever.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator SetOwner
    {
        add => IL.BossStatueLever.SetOwner += value;
        remove => IL.BossStatueLever.SetOwner -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.BossStatueLever.SetState += value;
        remove => IL.BossStatueLever.SetState -= value;
    }
}