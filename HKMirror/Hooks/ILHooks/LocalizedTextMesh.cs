namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LocalizedTextMesh.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLocalizedTextMesh
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.LocalizedTextMesh.Awake += value;
        remove => IL.LocalizedTextMesh.Awake -= value;
    }

    public static event ILContext.Manipulator LocalizeTextMesh
    {
        add => IL.LocalizedTextMesh.LocalizeTextMesh += value;
        remove => IL.LocalizedTextMesh.LocalizeTextMesh -= value;
    }
}