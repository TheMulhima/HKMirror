namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TextMeshSharpener.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTextMeshSharpener
{
    public static event ILContext.Manipulator Start
    {
        add => IL.TextMeshSharpener.Start += value;
        remove => IL.TextMeshSharpener.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.TextMeshSharpener.Update += value;
        remove => IL.TextMeshSharpener.Update -= value;
    }

    public static event ILContext.Manipulator resize
    {
        add => IL.TextMeshSharpener.resize += value;
        remove => IL.TextMeshSharpener.resize -= value;
    }
}