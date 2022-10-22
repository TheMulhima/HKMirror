namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorChallengeCompleteUI_BindingIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorChallengeCompleteUI_BindingIconR:InstanceClassWrapper<BossDoorChallengeCompleteUI.BindingIcon>
{
public BossDoorChallengeCompleteUI_BindingIconR(BossDoorChallengeCompleteUI.BindingIcon _orig) : base(_orig) {}
public UnityEngine.UI.Image icon
{
get => orig.icon;
set => orig.icon = value;
}

public UnityEngine.Sprite allUnlockedSprite
{
get => orig.allUnlockedSprite;
set => orig.allUnlockedSprite = value;
}

public UnityEngine.GameObject[] flashEffects
{
get => orig.flashEffects;
set => orig.flashEffects = value;
}

public bool alreadyVisible
{
get => GetField<bool>();
set => SetField(value);
}

public void SetAlreadyVisible (bool value, bool allUnlocked) =>
orig.SetAlreadyVisible(value, allUnlocked);

public System.Collections.IEnumerator DoAppearAnim (float appearDelay) =>
orig.DoAppearAnim(appearDelay);

public System.Collections.IEnumerator DoAllAppearAnim (float appearDelay) =>
orig.DoAllAppearAnim(appearDelay);

public void SetAllUnlocked () =>
CallMethod();

}
}
