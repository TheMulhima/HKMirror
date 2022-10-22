using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BossStatueCompletionStates class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossStatueCompletionStates
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnValidate()
{
if (!HookedList.Contains("OnValidate"))
{
HookedList.Add("OnValidate");
On.BossStatueCompletionStates.OnValidate += OnValidate;

}
}
internal static event Delegates.OnValidate_BeforeArgs _beforeOnValidate;
internal static event Delegates.OnValidate_AfterArgs _afterOnValidate;
private static void OnValidate(On.BossStatueCompletionStates.orig_OnValidate orig,BossStatueCompletionStates self)
{
Delegates.Params_OnValidate @params = new() 
{
self = self
};
if (_beforeOnValidate != null)
{
foreach (Delegates.OnValidate_BeforeArgs toInvoke in _beforeOnValidate.GetInvocationList())
{
try
{
_beforeOnValidate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnValidate != null)
{
foreach (Delegates.OnValidate_AfterArgs toInvoke in _afterOnValidate.GetInvocationList())
{
try
{
_afterOnValidate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookStart()
{
if (!HookedList.Contains("Start"))
{
HookedList.Add("Start");
On.BossStatueCompletionStates.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.BossStatueCompletionStates.orig_Start orig,BossStatueCompletionStates self)
{
Delegates.Params_Start @params = new() 
{
self = self
};
if (_beforeStart != null)
{
foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
{
try
{
_beforeStart?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterStart != null)
{
foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
{
try
{
_afterStart.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookGetHighestCompletedTier()
{
if (!HookedList.Contains("GetHighestCompletedTier"))
{
HookedList.Add("GetHighestCompletedTier");
On.BossStatueCompletionStates.GetHighestCompletedTier += GetHighestCompletedTier;

}
}
internal static event Delegates.GetHighestCompletedTier_BeforeArgs _beforeGetHighestCompletedTier;
internal static event Delegates.GetHighestCompletedTier_AfterArgs _afterGetHighestCompletedTier;
private static BossStatueCompletionStates.Tiers? GetHighestCompletedTier(On.BossStatueCompletionStates.orig_GetHighestCompletedTier orig,BossStatueCompletionStates self)
{
Delegates.Params_GetHighestCompletedTier @params = new() 
{
self = self
};
if (_beforeGetHighestCompletedTier != null)
{
foreach (Delegates.GetHighestCompletedTier_BeforeArgs toInvoke in _beforeGetHighestCompletedTier.GetInvocationList())
{
try
{
_beforeGetHighestCompletedTier?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterGetHighestCompletedTier != null)
{
foreach (Delegates.GetHighestCompletedTier_AfterArgs toInvoke in _afterGetHighestCompletedTier.GetInvocationList())
{
try
{
retVal = _afterGetHighestCompletedTier.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookGetIsTierCompleted()
{
if (!HookedList.Contains("GetIsTierCompleted"))
{
HookedList.Add("GetIsTierCompleted");
On.BossStatueCompletionStates.GetIsTierCompleted += GetIsTierCompleted;

}
}
internal static event Delegates.GetIsTierCompleted_BeforeArgs _beforeGetIsTierCompleted;
internal static event Delegates.GetIsTierCompleted_AfterArgs _afterGetIsTierCompleted;
private static bool GetIsTierCompleted(On.BossStatueCompletionStates.orig_GetIsTierCompleted orig,BossStatueCompletionStates self,  BossStatueCompletionStates.Tiers tier)
{
Delegates.Params_GetIsTierCompleted @params = new() 
{
self = self
, tier = tier
};
if (_beforeGetIsTierCompleted != null)
{
foreach (Delegates.GetIsTierCompleted_BeforeArgs toInvoke in _beforeGetIsTierCompleted.GetInvocationList())
{
try
{
_beforeGetIsTierCompleted?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
tier = @params.tier;
var retVal = orig(self, tier);
if (_afterGetIsTierCompleted != null)
{
foreach (Delegates.GetIsTierCompleted_AfterArgs toInvoke in _afterGetIsTierCompleted.GetInvocationList())
{
try
{
retVal = _afterGetIsTierCompleted.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookCountCompletion()
{
if (!HookedList.Contains("CountCompletion"))
{
HookedList.Add("CountCompletion");
On.BossStatueCompletionStates.CountCompletion += CountCompletion;

}
}
internal static event Delegates.CountCompletion_BeforeArgs _beforeCountCompletion;
internal static event Delegates.CountCompletion_AfterArgs _afterCountCompletion;
private static void CountCompletion(On.BossStatueCompletionStates.orig_CountCompletion orig,BossStatueCompletionStates self,  BossStatueCompletionStates.Tiers tier, out  int completed, out  int total)
{
Delegates.Params_CountCompletion @params = new() 
{
self = self
, tier = tier
, completed = completed
, total = total
};
if (_beforeCountCompletion != null)
{
foreach (Delegates.CountCompletion_BeforeArgs toInvoke in _beforeCountCompletion.GetInvocationList())
{
try
{
_beforeCountCompletion?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
tier = @params.tier;
completed = @params.completed;
total = @params.total;
orig(self, tier, out completed, out total);
if (_afterCountCompletion != null)
{
foreach (Delegates.CountCompletion_AfterArgs toInvoke in _afterCountCompletion.GetInvocationList())
{
try
{
_afterCountCompletion.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookHasCompletedTier()
{
if (!HookedList.Contains("HasCompletedTier"))
{
HookedList.Add("HasCompletedTier");
On.BossStatueCompletionStates.HasCompletedTier += HasCompletedTier;

}
}
internal static event Delegates.HasCompletedTier_BeforeArgs _beforeHasCompletedTier;
internal static event Delegates.HasCompletedTier_AfterArgs _afterHasCompletedTier;
private static bool HasCompletedTier(On.BossStatueCompletionStates.orig_HasCompletedTier orig,BossStatueCompletionStates self,  BossStatue.Completion completion,  BossStatueCompletionStates.Tiers tier)
{
Delegates.Params_HasCompletedTier @params = new() 
{
self = self
, completion = completion
, tier = tier
};
if (_beforeHasCompletedTier != null)
{
foreach (Delegates.HasCompletedTier_BeforeArgs toInvoke in _beforeHasCompletedTier.GetInvocationList())
{
try
{
_beforeHasCompletedTier?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
completion = @params.completion;
tier = @params.tier;
var retVal = orig(self, completion, tier);
if (_afterHasCompletedTier != null)
{
foreach (Delegates.HasCompletedTier_AfterArgs toInvoke in _afterHasCompletedTier.GetInvocationList())
{
try
{
retVal = _afterHasCompletedTier.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_OnValidate
{
public BossStatueCompletionStates self;
}
public delegate void OnValidate_BeforeArgs(Params_OnValidate args);
public delegate void OnValidate_AfterArgs(Params_OnValidate args);
public delegate void OnValidate_WithArgs (Action<BossStatueCompletionStates> orig, BossStatueCompletionStates self);
public sealed class Params_Start
{
public BossStatueCompletionStates self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<BossStatueCompletionStates> orig, BossStatueCompletionStates self);
public sealed class Params_GetHighestCompletedTier
{
public BossStatueCompletionStates self;
}
public delegate void GetHighestCompletedTier_BeforeArgs(Params_GetHighestCompletedTier args);
public delegate BossStatueCompletionStates.Tiers? GetHighestCompletedTier_AfterArgs(Params_GetHighestCompletedTier args, BossStatueCompletionStates.Tiers? ret);
public delegate BossStatueCompletionStates.Tiers? GetHighestCompletedTier_WithArgs (Func<BossStatueCompletionStates, BossStatueCompletionStates.Tiers?> orig, BossStatueCompletionStates self);
public sealed class Params_GetIsTierCompleted
{
public BossStatueCompletionStates self;
public BossStatueCompletionStates.Tiers tier;
}
public delegate void GetIsTierCompleted_BeforeArgs(Params_GetIsTierCompleted args);
public delegate bool GetIsTierCompleted_AfterArgs(Params_GetIsTierCompleted args, bool ret);
public delegate bool GetIsTierCompleted_WithArgs (Func<BossStatueCompletionStates,  BossStatueCompletionStates.Tiers, bool> orig, BossStatueCompletionStates self,  BossStatueCompletionStates.Tiers tier);
public sealed class Params_CountCompletion
{
public BossStatueCompletionStates self;
public BossStatueCompletionStates.Tiers tier;
public int completed;
public int total;
}
public delegate void CountCompletion_BeforeArgs(Params_CountCompletion args);
public delegate void CountCompletion_AfterArgs(Params_CountCompletion args);
public delegate void CountCompletion_WithArgs (Action<BossStatueCompletionStates,  BossStatueCompletionStates.Tiers,  int,  int> orig, BossStatueCompletionStates self,  BossStatueCompletionStates.Tiers tier, out  int completed, out  int total);
public sealed class Params_HasCompletedTier
{
public BossStatueCompletionStates self;
public BossStatue.Completion completion;
public BossStatueCompletionStates.Tiers tier;
}
public delegate void HasCompletedTier_BeforeArgs(Params_HasCompletedTier args);
public delegate bool HasCompletedTier_AfterArgs(Params_HasCompletedTier args, bool ret);
public delegate bool HasCompletedTier_WithArgs (Func<BossStatueCompletionStates,  BossStatue.Completion,  BossStatueCompletionStates.Tiers, bool> orig, BossStatueCompletionStates self,  BossStatue.Completion completion,  BossStatueCompletionStates.Tiers tier);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnValidate_BeforeArgs OnValidate
{
add
{

HookHandler._beforeOnValidate += value;
HookHandler.HookOnValidate();
}
remove => HookHandler._beforeOnValidate -= value;
}
public static event Delegates.Start_BeforeArgs Start
{
add
{

HookHandler._beforeStart += value;
HookHandler.HookStart();
}
remove => HookHandler._beforeStart -= value;
}
public static event Delegates.GetHighestCompletedTier_BeforeArgs GetHighestCompletedTier
{
add
{

HookHandler._beforeGetHighestCompletedTier += value;
HookHandler.HookGetHighestCompletedTier();
}
remove => HookHandler._beforeGetHighestCompletedTier -= value;
}
public static event Delegates.GetIsTierCompleted_BeforeArgs GetIsTierCompleted
{
add
{

HookHandler._beforeGetIsTierCompleted += value;
HookHandler.HookGetIsTierCompleted();
}
remove => HookHandler._beforeGetIsTierCompleted -= value;
}
public static event Delegates.CountCompletion_BeforeArgs CountCompletion
{
add
{

HookHandler._beforeCountCompletion += value;
HookHandler.HookCountCompletion();
}
remove => HookHandler._beforeCountCompletion -= value;
}
public static event Delegates.HasCompletedTier_BeforeArgs HasCompletedTier
{
add
{

HookHandler._beforeHasCompletedTier += value;
HookHandler.HookHasCompletedTier();
}
remove => HookHandler._beforeHasCompletedTier -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnValidate_AfterArgs OnValidate
{
add
{

HookHandler._afterOnValidate += value;
HookHandler.HookOnValidate();
}
remove => HookHandler._afterOnValidate -= value;
}
public static event Delegates.Start_AfterArgs Start
{
add
{

HookHandler._afterStart += value;
HookHandler.HookStart();
}
remove => HookHandler._afterStart -= value;
}
public static event Delegates.GetHighestCompletedTier_AfterArgs GetHighestCompletedTier
{
add
{

HookHandler._afterGetHighestCompletedTier += value;
HookHandler.HookGetHighestCompletedTier();
}
remove => HookHandler._afterGetHighestCompletedTier -= value;
}
public static event Delegates.GetIsTierCompleted_AfterArgs GetIsTierCompleted
{
add
{

HookHandler._afterGetIsTierCompleted += value;
HookHandler.HookGetIsTierCompleted();
}
remove => HookHandler._afterGetIsTierCompleted -= value;
}
public static event Delegates.CountCompletion_AfterArgs CountCompletion
{
add
{

HookHandler._afterCountCompletion += value;
HookHandler.HookCountCompletion();
}
remove => HookHandler._afterCountCompletion -= value;
}
public static event Delegates.HasCompletedTier_AfterArgs HasCompletedTier
{
add
{

HookHandler._afterHasCompletedTier += value;
HookHandler.HookHasCompletedTier();
}
remove => HookHandler._afterHasCompletedTier -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.BossStatueCompletionStates.hook_OnValidate OnValidate
{
add => On.BossStatueCompletionStates.OnValidate += value;
remove => On.BossStatueCompletionStates.OnValidate -= value;
}
public static event On.BossStatueCompletionStates.hook_Start Start
{
add => On.BossStatueCompletionStates.Start += value;
remove => On.BossStatueCompletionStates.Start -= value;
}
public static event On.BossStatueCompletionStates.hook_GetHighestCompletedTier GetHighestCompletedTier
{
add => On.BossStatueCompletionStates.GetHighestCompletedTier += value;
remove => On.BossStatueCompletionStates.GetHighestCompletedTier -= value;
}
public static event On.BossStatueCompletionStates.hook_GetIsTierCompleted GetIsTierCompleted
{
add => On.BossStatueCompletionStates.GetIsTierCompleted += value;
remove => On.BossStatueCompletionStates.GetIsTierCompleted -= value;
}
public static event On.BossStatueCompletionStates.hook_CountCompletion CountCompletion
{
add => On.BossStatueCompletionStates.CountCompletion += value;
remove => On.BossStatueCompletionStates.CountCompletion -= value;
}
public static event On.BossStatueCompletionStates.hook_HasCompletedTier HasCompletedTier
{
add => On.BossStatueCompletionStates.HasCompletedTier += value;
remove => On.BossStatueCompletionStates.HasCompletedTier -= value;
}
}

}
