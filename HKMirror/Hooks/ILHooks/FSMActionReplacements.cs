namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FSMActionReplacements,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFSMActionReplacements
{
    public static event ILContext.Manipulator SetMaterialColor
    {
        add => IL.FSMActionReplacements.SetMaterialColor += value;
        remove => IL.FSMActionReplacements.SetMaterialColor -= value;
    }
}