using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DialogueBox.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDialogueBox
{
    public static event ILContext.Manipulator Start
    {
        add => IL.DialogueBox.Start += value;
        remove => IL.DialogueBox.Start -= value;
    }

    public static event ILContext.Manipulator SetConversation
    {
        add => IL.DialogueBox.SetConversation += value;
        remove => IL.DialogueBox.SetConversation -= value;
    }

    public static event ILContext.Manipulator ShowPage
    {
        add => IL.DialogueBox.ShowPage += value;
        remove => IL.DialogueBox.ShowPage -= value;
    }

    public static event ILContext.Manipulator ShowNextPage
    {
        add => IL.DialogueBox.ShowNextPage += value;
        remove => IL.DialogueBox.ShowNextPage -= value;
    }

    public static event ILContext.Manipulator ShowPrevPage
    {
        add => IL.DialogueBox.ShowPrevPage += value;
        remove => IL.DialogueBox.ShowPrevPage -= value;
    }

    public static event ILContext.Manipulator HideText
    {
        add => IL.DialogueBox.HideText += value;
        remove => IL.DialogueBox.HideText -= value;
    }

    public static event ILContext.Manipulator StartConversation
    {
        add => IL.DialogueBox.StartConversation += value;
        remove => IL.DialogueBox.StartConversation -= value;
    }

    public static event ILContext.Manipulator TypewriteCurrentPage
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DialogueBox), "TypewriteCurrentPage").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DialogueBox), "TypewriteCurrentPage").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ShowNextChar
    {
        add => IL.DialogueBox.ShowNextChar += value;
        remove => IL.DialogueBox.ShowNextChar -= value;
    }

    public static event ILContext.Manipulator StopTypewriter
    {
        add => IL.DialogueBox.StopTypewriter += value;
        remove => IL.DialogueBox.StopTypewriter -= value;
    }

    public static event ILContext.Manipulator SpeedupTypewriter
    {
        add => IL.DialogueBox.SpeedupTypewriter += value;
        remove => IL.DialogueBox.SpeedupTypewriter -= value;
    }

    public static event ILContext.Manipulator RestoreTypewriter
    {
        add => IL.DialogueBox.RestoreTypewriter += value;
        remove => IL.DialogueBox.RestoreTypewriter -= value;
    }

    public static event ILContext.Manipulator SendEndEvent
    {
        add => IL.DialogueBox.SendEndEvent += value;
        remove => IL.DialogueBox.SendEndEvent -= value;
    }

    public static event ILContext.Manipulator SendPageEndEvent
    {
        add => IL.DialogueBox.SendPageEndEvent += value;
        remove => IL.DialogueBox.SendPageEndEvent -= value;
    }

    public static event ILContext.Manipulator SendConvEndEvent
    {
        add => IL.DialogueBox.SendConvEndEvent += value;
        remove => IL.DialogueBox.SendConvEndEvent -= value;
    }

    public static event ILContext.Manipulator GetFirstCharIndexOnPage
    {
        add => IL.DialogueBox.GetFirstCharIndexOnPage += value;
        remove => IL.DialogueBox.GetFirstCharIndexOnPage -= value;
    }

    public static event ILContext.Manipulator GetLastCharIndexOnPage
    {
        add => IL.DialogueBox.GetLastCharIndexOnPage += value;
        remove => IL.DialogueBox.GetLastCharIndexOnPage -= value;
    }

    public static event ILContext.Manipulator PrintPageInfo
    {
        add => IL.DialogueBox.PrintPageInfo += value;
        remove => IL.DialogueBox.PrintPageInfo -= value;
    }

    public static event ILContext.Manipulator PrintPageInfoAll
    {
        add => IL.DialogueBox.PrintPageInfoAll += value;
        remove => IL.DialogueBox.PrintPageInfoAll -= value;
    }

    public static event ILContext.Manipulator PrintCurrentConversation
    {
        add => IL.DialogueBox.PrintCurrentConversation += value;
        remove => IL.DialogueBox.PrintCurrentConversation -= value;
    }
}