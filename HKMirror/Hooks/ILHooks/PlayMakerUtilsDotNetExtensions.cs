namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUtilsDotNetExtensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUtilsDotNetExtensions
{
    public static event ILContext.Manipulator Contains
    {
        add => IL.PlayMakerUtilsDotNetExtensions.Contains += value;
        remove => IL.PlayMakerUtilsDotNetExtensions.Contains -= value;
    }
}