using UnityEngine.UI;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorChallengeCompleteUI_BindingIcon
///     allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorChallengeCompleteUI_BindingIconR : InstanceClassWrapper<BossDoorChallengeCompleteUI.BindingIcon>
{
    public BossDoorChallengeCompleteUI_BindingIconR(BossDoorChallengeCompleteUI.BindingIcon _orig) : base(_orig)
    {
    }

    public Image icon
    {
        get => orig.icon;
        set => orig.icon = value;
    }

    public Sprite allUnlockedSprite
    {
        get => orig.allUnlockedSprite;
        set => orig.allUnlockedSprite = value;
    }

    public GameObject[] flashEffects
    {
        get => orig.flashEffects;
        set => orig.flashEffects = value;
    }

    public bool alreadyVisible
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public void SetAlreadyVisible(bool value, bool allUnlocked)
    {
        orig.SetAlreadyVisible(value, allUnlocked);
    }

    public IEnumerator DoAppearAnim(float appearDelay)
    {
        return orig.DoAppearAnim(appearDelay);
    }

    public IEnumerator DoAllAppearAnim(float appearDelay)
    {
        return orig.DoAllAppearAnim(appearDelay);
    }

    public void SetAllUnlocked()
    {
        CallMethod();
    }
}