using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BossDoorLockUI class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossDoorLockUI
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.BossDoorLockUI.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.BossDoorLockUI.orig_Awake orig,BossDoorLockUI self)
{
Delegates.Params_Awake @params = new() 
{
self = self
};
if (_beforeAwake != null)
{
foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
{
try
{
_beforeAwake?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterAwake != null)
{
foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
{
try
{
_afterAwake.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookShow()
{
if (!HookedList.Contains("Show"))
{
HookedList.Add("Show");
On.BossDoorLockUI.Show += Show;

}
}
internal static event Delegates.Show_BeforeArgs _beforeShow;
internal static event Delegates.Show_AfterArgs _afterShow;
private static void Show(On.BossDoorLockUI.orig_Show orig,BossDoorLockUI self,  BossSequenceDoor door)
{
Delegates.Params_Show @params = new() 
{
self = self
, door = door
};
if (_beforeShow != null)
{
foreach (Delegates.Show_BeforeArgs toInvoke in _beforeShow.GetInvocationList())
{
try
{
_beforeShow?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
door = @params.door;
orig(self, door);
if (_afterShow != null)
{
foreach (Delegates.Show_AfterArgs toInvoke in _afterShow.GetInvocationList())
{
try
{
_afterShow.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookHide()
{
if (!HookedList.Contains("Hide"))
{
HookedList.Add("Hide");
On.BossDoorLockUI.Hide += Hide;

}
}
internal static event Delegates.Hide_BeforeArgs _beforeHide;
internal static event Delegates.Hide_AfterArgs _afterHide;
private static void Hide(On.BossDoorLockUI.orig_Hide orig,BossDoorLockUI self)
{
Delegates.Params_Hide @params = new() 
{
self = self
};
if (_beforeHide != null)
{
foreach (Delegates.Hide_BeforeArgs toInvoke in _beforeHide.GetInvocationList())
{
try
{
_beforeHide?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterHide != null)
{
foreach (Delegates.Hide_AfterArgs toInvoke in _afterHide.GetInvocationList())
{
try
{
_afterHide.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookShowRoutine()
{
if (!HookedList.Contains("ShowRoutine"))
{
HookedList.Add("ShowRoutine");
On.BossDoorLockUI.ShowRoutine += ShowRoutine;

}
}
internal static event Delegates.ShowRoutine_BeforeArgs _beforeShowRoutine;
private static System.Collections.IEnumerator ShowRoutine(On.BossDoorLockUI.orig_ShowRoutine orig,BossDoorLockUI self)
{
Delegates.Params_ShowRoutine @params = new() 
{
self = self
};
if (_beforeShowRoutine != null)
{
foreach (Delegates.ShowRoutine_BeforeArgs toInvoke in _beforeShowRoutine.GetInvocationList())
{
try
{
_beforeShowRoutine?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
return orig(self);
}
internal static void HookHideRoutine()
{
if (!HookedList.Contains("HideRoutine"))
{
HookedList.Add("HideRoutine");
On.BossDoorLockUI.HideRoutine += HideRoutine;

}
}
internal static event Delegates.HideRoutine_BeforeArgs _beforeHideRoutine;
private static System.Collections.IEnumerator HideRoutine(On.BossDoorLockUI.orig_HideRoutine orig,BossDoorLockUI self)
{
Delegates.Params_HideRoutine @params = new() 
{
self = self
};
if (_beforeHideRoutine != null)
{
foreach (Delegates.HideRoutine_BeforeArgs toInvoke in _beforeHideRoutine.GetInvocationList())
{
try
{
_beforeHideRoutine?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
return orig(self);
}
internal static void HookFadeButtonPrompts()
{
if (!HookedList.Contains("FadeButtonPrompts"))
{
HookedList.Add("FadeButtonPrompts");
On.BossDoorLockUI.FadeButtonPrompts += FadeButtonPrompts;

}
}
internal static event Delegates.FadeButtonPrompts_BeforeArgs _beforeFadeButtonPrompts;
private static System.Collections.IEnumerator FadeButtonPrompts(On.BossDoorLockUI.orig_FadeButtonPrompts orig,BossDoorLockUI self,  float toAlpha,  float time)
{
Delegates.Params_FadeButtonPrompts @params = new() 
{
self = self
, toAlpha = toAlpha
, time = time
};
if (_beforeFadeButtonPrompts != null)
{
foreach (Delegates.FadeButtonPrompts_BeforeArgs toInvoke in _beforeFadeButtonPrompts.GetInvocationList())
{
try
{
_beforeFadeButtonPrompts?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
toAlpha = @params.toAlpha;
time = @params.time;
return orig(self, toAlpha, time);
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_Awake
{
public BossDoorLockUI self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<BossDoorLockUI> orig, BossDoorLockUI self);
public sealed class Params_Show
{
public BossDoorLockUI self;
public BossSequenceDoor door;
}
public delegate void Show_BeforeArgs(Params_Show args);
public delegate void Show_AfterArgs(Params_Show args);
public delegate void Show_WithArgs (Action<BossDoorLockUI,  BossSequenceDoor> orig, BossDoorLockUI self,  BossSequenceDoor door);
public sealed class Params_Hide
{
public BossDoorLockUI self;
}
public delegate void Hide_BeforeArgs(Params_Hide args);
public delegate void Hide_AfterArgs(Params_Hide args);
public delegate void Hide_WithArgs (Action<BossDoorLockUI> orig, BossDoorLockUI self);
public sealed class Params_ShowRoutine
{
public BossDoorLockUI self;
}
public delegate void ShowRoutine_BeforeArgs(Params_ShowRoutine args);
public delegate System.Collections.IEnumerator ShowRoutine_AfterArgs(Params_ShowRoutine args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator ShowRoutine_WithArgs (Func<BossDoorLockUI, System.Collections.IEnumerator> orig, BossDoorLockUI self);
public sealed class Params_HideRoutine
{
public BossDoorLockUI self;
}
public delegate void HideRoutine_BeforeArgs(Params_HideRoutine args);
public delegate System.Collections.IEnumerator HideRoutine_AfterArgs(Params_HideRoutine args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator HideRoutine_WithArgs (Func<BossDoorLockUI, System.Collections.IEnumerator> orig, BossDoorLockUI self);
public sealed class Params_FadeButtonPrompts
{
public BossDoorLockUI self;
public float toAlpha;
public float time;
}
public delegate void FadeButtonPrompts_BeforeArgs(Params_FadeButtonPrompts args);
public delegate System.Collections.IEnumerator FadeButtonPrompts_AfterArgs(Params_FadeButtonPrompts args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator FadeButtonPrompts_WithArgs (Func<BossDoorLockUI,  float,  float, System.Collections.IEnumerator> orig, BossDoorLockUI self,  float toAlpha,  float time);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Awake_BeforeArgs Awake
{
add
{

HookHandler._beforeAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._beforeAwake -= value;
}
public static event Delegates.Show_BeforeArgs Show
{
add
{

HookHandler._beforeShow += value;
HookHandler.HookShow();
}
remove => HookHandler._beforeShow -= value;
}
public static event Delegates.Hide_BeforeArgs Hide
{
add
{

HookHandler._beforeHide += value;
HookHandler.HookHide();
}
remove => HookHandler._beforeHide -= value;
}
public static event Delegates.ShowRoutine_BeforeArgs ShowRoutine
{
add
{

HookHandler._beforeShowRoutine += value;
HookHandler.HookShowRoutine();
}
remove => HookHandler._beforeShowRoutine -= value;
}
public static event Delegates.HideRoutine_BeforeArgs HideRoutine
{
add
{

HookHandler._beforeHideRoutine += value;
HookHandler.HookHideRoutine();
}
remove => HookHandler._beforeHideRoutine -= value;
}
public static event Delegates.FadeButtonPrompts_BeforeArgs FadeButtonPrompts
{
add
{

HookHandler._beforeFadeButtonPrompts += value;
HookHandler.HookFadeButtonPrompts();
}
remove => HookHandler._beforeFadeButtonPrompts -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Awake_AfterArgs Awake
{
add
{

HookHandler._afterAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._afterAwake -= value;
}
public static event Delegates.Show_AfterArgs Show
{
add
{

HookHandler._afterShow += value;
HookHandler.HookShow();
}
remove => HookHandler._afterShow -= value;
}
public static event Delegates.Hide_AfterArgs Hide
{
add
{

HookHandler._afterHide += value;
HookHandler.HookHide();
}
remove => HookHandler._afterHide -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.BossDoorLockUI.hook_Awake Awake
{
add => On.BossDoorLockUI.Awake += value;
remove => On.BossDoorLockUI.Awake -= value;
}
public static event On.BossDoorLockUI.hook_Show Show
{
add => On.BossDoorLockUI.Show += value;
remove => On.BossDoorLockUI.Show -= value;
}
public static event On.BossDoorLockUI.hook_Hide Hide
{
add => On.BossDoorLockUI.Hide += value;
remove => On.BossDoorLockUI.Hide -= value;
}
public static event On.BossDoorLockUI.hook_ShowRoutine ShowRoutine
{
add => On.BossDoorLockUI.ShowRoutine += value;
remove => On.BossDoorLockUI.ShowRoutine -= value;
}
public static event On.BossDoorLockUI.hook_HideRoutine HideRoutine
{
add => On.BossDoorLockUI.HideRoutine += value;
remove => On.BossDoorLockUI.HideRoutine -= value;
}
public static event On.BossDoorLockUI.hook_FadeButtonPrompts FadeButtonPrompts
{
add => On.BossDoorLockUI.FadeButtonPrompts += value;
remove => On.BossDoorLockUI.FadeButtonPrompts -= value;
}
}

}
