using UnityEngine.UI;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossChallengeUI_ButtonDisplay allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossChallengeUI_ButtonDisplayR : InstanceClassWrapper<BossChallengeUI.ButtonDisplay>
{
    public BossChallengeUI_ButtonDisplayR(BossChallengeUI.ButtonDisplay _orig) : base(_orig)
    {
    }

    public Image completeImage
    {
        get => orig.completeImage;
        set => orig.completeImage = value;
    }

    public Image incompleteImage
    {
        get => orig.incompleteImage;
        set => orig.incompleteImage = value;
    }

    public MenuSelectable button
    {
        get => orig.button;
        set => orig.button = value;
    }

    public float enabledAlpha
    {
        get => orig.enabledAlpha;
        set => orig.enabledAlpha = value;
    }

    public float disabledAlpha
    {
        get => orig.disabledAlpha;
        set => orig.disabledAlpha = value;
    }

    public void SetupNavigation(bool isActive, BossChallengeUI.ButtonDisplay selectOnUp,
        BossChallengeUI.ButtonDisplay selectOnDown)
    {
        orig.SetupNavigation(isActive, selectOnUp, selectOnDown);
    }

    public void SetState(bool isComplete)
    {
        orig.SetState(isComplete);
    }
}