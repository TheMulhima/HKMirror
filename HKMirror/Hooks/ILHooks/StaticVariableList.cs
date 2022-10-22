namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StaticVariableList,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStaticVariableList
{
    public static event ILContext.Manipulator Clear
    {
        add => IL.StaticVariableList.Clear += value;
        remove => IL.StaticVariableList.Clear -= value;
    }

    public static event ILContext.Manipulator Exists
    {
        add => IL.StaticVariableList.Exists += value;
        remove => IL.StaticVariableList.Exists -= value;
    }
}