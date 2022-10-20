namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetPosIfPlayerdataBool.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetPosIfPlayerdataBool
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SetPosIfPlayerdataBool.OnEnable += value;
        remove => IL.SetPosIfPlayerdataBool.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.SetPosIfPlayerdataBool.OnDisable += value;
        remove => IL.SetPosIfPlayerdataBool.OnDisable -= value;
    }

    public static event ILContext.Manipulator DoCheck
    {
        add => IL.SetPosIfPlayerdataBool.DoCheck += value;
        remove => IL.SetPosIfPlayerdataBool.DoCheck -= value;
    }
}