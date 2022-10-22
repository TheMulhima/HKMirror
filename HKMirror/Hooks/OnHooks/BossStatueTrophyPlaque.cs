using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BossStatueTrophyPlaque class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossStatueTrophyPlaque
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookSetDisplay()
{
if (!HookedList.Contains("SetDisplay"))
{
HookedList.Add("SetDisplay");
On.BossStatueTrophyPlaque.SetDisplay += SetDisplay;

}
}
internal static event Delegates.SetDisplay_BeforeArgs _beforeSetDisplay;
internal static event Delegates.SetDisplay_AfterArgs _afterSetDisplay;
private static void SetDisplay(On.BossStatueTrophyPlaque.orig_SetDisplay orig,BossStatueTrophyPlaque self,  BossStatueTrophyPlaque.DisplayType type)
{
Delegates.Params_SetDisplay @params = new() 
{
self = self
, type = type
};
if (_beforeSetDisplay != null)
{
foreach (Delegates.SetDisplay_BeforeArgs toInvoke in _beforeSetDisplay.GetInvocationList())
{
try
{
_beforeSetDisplay?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
type = @params.type;
orig(self, type);
if (_afterSetDisplay != null)
{
foreach (Delegates.SetDisplay_AfterArgs toInvoke in _afterSetDisplay.GetInvocationList())
{
try
{
_afterSetDisplay.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookDoTierCompleteEffect()
{
if (!HookedList.Contains("DoTierCompleteEffect"))
{
HookedList.Add("DoTierCompleteEffect");
On.BossStatueTrophyPlaque.DoTierCompleteEffect += DoTierCompleteEffect;

}
}
internal static event Delegates.DoTierCompleteEffect_BeforeArgs _beforeDoTierCompleteEffect;
internal static event Delegates.DoTierCompleteEffect_AfterArgs _afterDoTierCompleteEffect;
private static void DoTierCompleteEffect(On.BossStatueTrophyPlaque.orig_DoTierCompleteEffect orig,BossStatueTrophyPlaque self,  BossStatueTrophyPlaque.DisplayType type)
{
Delegates.Params_DoTierCompleteEffect @params = new() 
{
self = self
, type = type
};
if (_beforeDoTierCompleteEffect != null)
{
foreach (Delegates.DoTierCompleteEffect_BeforeArgs toInvoke in _beforeDoTierCompleteEffect.GetInvocationList())
{
try
{
_beforeDoTierCompleteEffect?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
type = @params.type;
orig(self, type);
if (_afterDoTierCompleteEffect != null)
{
foreach (Delegates.DoTierCompleteEffect_AfterArgs toInvoke in _afterDoTierCompleteEffect.GetInvocationList())
{
try
{
_afterDoTierCompleteEffect.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookTierCompleteEffectDelayed()
{
if (!HookedList.Contains("TierCompleteEffectDelayed"))
{
HookedList.Add("TierCompleteEffectDelayed");
On.BossStatueTrophyPlaque.TierCompleteEffectDelayed += TierCompleteEffectDelayed;

}
}
internal static event Delegates.TierCompleteEffectDelayed_BeforeArgs _beforeTierCompleteEffectDelayed;
private static System.Collections.IEnumerator TierCompleteEffectDelayed(On.BossStatueTrophyPlaque.orig_TierCompleteEffectDelayed orig,BossStatueTrophyPlaque self)
{
Delegates.Params_TierCompleteEffectDelayed @params = new() 
{
self = self
};
if (_beforeTierCompleteEffectDelayed != null)
{
foreach (Delegates.TierCompleteEffectDelayed_BeforeArgs toInvoke in _beforeTierCompleteEffectDelayed.GetInvocationList())
{
try
{
_beforeTierCompleteEffectDelayed?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
return orig(self);
}
internal static void HookSetDisplayObject()
{
if (!HookedList.Contains("SetDisplayObject"))
{
HookedList.Add("SetDisplayObject");
On.BossStatueTrophyPlaque.SetDisplayObject += SetDisplayObject;

}
}
internal static event Delegates.SetDisplayObject_BeforeArgs _beforeSetDisplayObject;
internal static event Delegates.SetDisplayObject_AfterArgs _afterSetDisplayObject;
private static void SetDisplayObject(On.BossStatueTrophyPlaque.orig_SetDisplayObject orig,BossStatueTrophyPlaque self,  BossStatueTrophyPlaque.DisplayType type)
{
Delegates.Params_SetDisplayObject @params = new() 
{
self = self
, type = type
};
if (_beforeSetDisplayObject != null)
{
foreach (Delegates.SetDisplayObject_BeforeArgs toInvoke in _beforeSetDisplayObject.GetInvocationList())
{
try
{
_beforeSetDisplayObject?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
type = @params.type;
orig(self, type);
if (_afterSetDisplayObject != null)
{
foreach (Delegates.SetDisplayObject_AfterArgs toInvoke in _afterSetDisplayObject.GetInvocationList())
{
try
{
_afterSetDisplayObject.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_SetDisplay
{
public BossStatueTrophyPlaque self;
public BossStatueTrophyPlaque.DisplayType type;
}
public delegate void SetDisplay_BeforeArgs(Params_SetDisplay args);
public delegate void SetDisplay_AfterArgs(Params_SetDisplay args);
public delegate void SetDisplay_WithArgs (Action<BossStatueTrophyPlaque,  BossStatueTrophyPlaque.DisplayType> orig, BossStatueTrophyPlaque self,  BossStatueTrophyPlaque.DisplayType type);
public sealed class Params_DoTierCompleteEffect
{
public BossStatueTrophyPlaque self;
public BossStatueTrophyPlaque.DisplayType type;
}
public delegate void DoTierCompleteEffect_BeforeArgs(Params_DoTierCompleteEffect args);
public delegate void DoTierCompleteEffect_AfterArgs(Params_DoTierCompleteEffect args);
public delegate void DoTierCompleteEffect_WithArgs (Action<BossStatueTrophyPlaque,  BossStatueTrophyPlaque.DisplayType> orig, BossStatueTrophyPlaque self,  BossStatueTrophyPlaque.DisplayType type);
public sealed class Params_TierCompleteEffectDelayed
{
public BossStatueTrophyPlaque self;
}
public delegate void TierCompleteEffectDelayed_BeforeArgs(Params_TierCompleteEffectDelayed args);
public delegate System.Collections.IEnumerator TierCompleteEffectDelayed_AfterArgs(Params_TierCompleteEffectDelayed args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator TierCompleteEffectDelayed_WithArgs (Func<BossStatueTrophyPlaque, System.Collections.IEnumerator> orig, BossStatueTrophyPlaque self);
public sealed class Params_SetDisplayObject
{
public BossStatueTrophyPlaque self;
public BossStatueTrophyPlaque.DisplayType type;
}
public delegate void SetDisplayObject_BeforeArgs(Params_SetDisplayObject args);
public delegate void SetDisplayObject_AfterArgs(Params_SetDisplayObject args);
public delegate void SetDisplayObject_WithArgs (Action<BossStatueTrophyPlaque,  BossStatueTrophyPlaque.DisplayType> orig, BossStatueTrophyPlaque self,  BossStatueTrophyPlaque.DisplayType type);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.SetDisplay_BeforeArgs SetDisplay
{
add
{

HookHandler._beforeSetDisplay += value;
HookHandler.HookSetDisplay();
}
remove => HookHandler._beforeSetDisplay -= value;
}
public static event Delegates.DoTierCompleteEffect_BeforeArgs DoTierCompleteEffect
{
add
{

HookHandler._beforeDoTierCompleteEffect += value;
HookHandler.HookDoTierCompleteEffect();
}
remove => HookHandler._beforeDoTierCompleteEffect -= value;
}
public static event Delegates.TierCompleteEffectDelayed_BeforeArgs TierCompleteEffectDelayed
{
add
{

HookHandler._beforeTierCompleteEffectDelayed += value;
HookHandler.HookTierCompleteEffectDelayed();
}
remove => HookHandler._beforeTierCompleteEffectDelayed -= value;
}
public static event Delegates.SetDisplayObject_BeforeArgs SetDisplayObject
{
add
{

HookHandler._beforeSetDisplayObject += value;
HookHandler.HookSetDisplayObject();
}
remove => HookHandler._beforeSetDisplayObject -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.SetDisplay_AfterArgs SetDisplay
{
add
{

HookHandler._afterSetDisplay += value;
HookHandler.HookSetDisplay();
}
remove => HookHandler._afterSetDisplay -= value;
}
public static event Delegates.DoTierCompleteEffect_AfterArgs DoTierCompleteEffect
{
add
{

HookHandler._afterDoTierCompleteEffect += value;
HookHandler.HookDoTierCompleteEffect();
}
remove => HookHandler._afterDoTierCompleteEffect -= value;
}
public static event Delegates.SetDisplayObject_AfterArgs SetDisplayObject
{
add
{

HookHandler._afterSetDisplayObject += value;
HookHandler.HookSetDisplayObject();
}
remove => HookHandler._afterSetDisplayObject -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.BossStatueTrophyPlaque.hook_SetDisplay SetDisplay
{
add => On.BossStatueTrophyPlaque.SetDisplay += value;
remove => On.BossStatueTrophyPlaque.SetDisplay -= value;
}
public static event On.BossStatueTrophyPlaque.hook_DoTierCompleteEffect DoTierCompleteEffect
{
add => On.BossStatueTrophyPlaque.DoTierCompleteEffect += value;
remove => On.BossStatueTrophyPlaque.DoTierCompleteEffect -= value;
}
public static event On.BossStatueTrophyPlaque.hook_TierCompleteEffectDelayed TierCompleteEffectDelayed
{
add => On.BossStatueTrophyPlaque.TierCompleteEffectDelayed += value;
remove => On.BossStatueTrophyPlaque.TierCompleteEffectDelayed -= value;
}
public static event On.BossStatueTrophyPlaque.hook_SetDisplayObject SetDisplayObject
{
add => On.BossStatueTrophyPlaque.SetDisplayObject += value;
remove => On.BossStatueTrophyPlaque.SetDisplayObject -= value;
}
}

}
