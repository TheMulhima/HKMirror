namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WorldInfo.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWorldInfo
{
    public static event ILContext.Manipulator NameLooksLikeGameplayScene
    {
        add => IL.WorldInfo.NameLooksLikeGameplayScene += value;
        remove => IL.WorldInfo.NameLooksLikeGameplayScene -= value;
    }
}