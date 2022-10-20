namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetTextMeshProGameText.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetTextMeshProGameText
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SetTextMeshProGameText.Awake += value;
        remove => IL.SetTextMeshProGameText.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.SetTextMeshProGameText.Start += value;
        remove => IL.SetTextMeshProGameText.Start -= value;
    }

    public static event ILContext.Manipulator UpdateText
    {
        add => IL.SetTextMeshProGameText.UpdateText += value;
        remove => IL.SetTextMeshProGameText.UpdateText -= value;
    }

    public static event ILContext.Manipulator ChangedLanguage
    {
        add => IL.SetTextMeshProGameText.ChangedLanguage += value;
        remove => IL.SetTextMeshProGameText.ChangedLanguage -= value;
    }
}