using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BossStatueSetUnlockIndicator class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossStatueSetUnlockIndicator
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookStart()
{
if (!HookedList.Contains("Start"))
{
HookedList.Add("Start");
On.BossStatueSetUnlockIndicator.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.BossStatueSetUnlockIndicator.orig_Start orig,BossStatueSetUnlockIndicator self)
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
internal static void HookCheckIfNewBossStatue()
{
if (!HookedList.Contains("CheckIfNewBossStatue"))
{
HookedList.Add("CheckIfNewBossStatue");
On.BossStatueSetUnlockIndicator.CheckIfNewBossStatue += CheckIfNewBossStatue;

}
}
internal static event Delegates.CheckIfNewBossStatue_BeforeArgs _beforeCheckIfNewBossStatue;
internal static event Delegates.CheckIfNewBossStatue_AfterArgs _afterCheckIfNewBossStatue;
private static bool CheckIfNewBossStatue(On.BossStatueSetUnlockIndicator.orig_CheckIfNewBossStatue orig,BossStatueSetUnlockIndicator self,  BossStatue.Completion completion)
{
Delegates.Params_CheckIfNewBossStatue @params = new() 
{
self = self
, completion = completion
};
if (_beforeCheckIfNewBossStatue != null)
{
foreach (Delegates.CheckIfNewBossStatue_BeforeArgs toInvoke in _beforeCheckIfNewBossStatue.GetInvocationList())
{
try
{
_beforeCheckIfNewBossStatue?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
completion = @params.completion;
var retVal = orig(self, completion);
if (_afterCheckIfNewBossStatue != null)
{
foreach (Delegates.CheckIfNewBossStatue_AfterArgs toInvoke in _afterCheckIfNewBossStatue.GetInvocationList())
{
try
{
retVal = _afterCheckIfNewBossStatue.Invoke(@params, retVal);
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
public sealed class Params_Start
{
public BossStatueSetUnlockIndicator self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<BossStatueSetUnlockIndicator> orig, BossStatueSetUnlockIndicator self);
public sealed class Params_CheckIfNewBossStatue
{
public BossStatueSetUnlockIndicator self;
public BossStatue.Completion completion;
}
public delegate void CheckIfNewBossStatue_BeforeArgs(Params_CheckIfNewBossStatue args);
public delegate bool CheckIfNewBossStatue_AfterArgs(Params_CheckIfNewBossStatue args, bool ret);
public delegate bool CheckIfNewBossStatue_WithArgs (Func<BossStatueSetUnlockIndicator,  BossStatue.Completion, bool> orig, BossStatueSetUnlockIndicator self,  BossStatue.Completion completion);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Start_BeforeArgs Start
{
add
{

HookHandler._beforeStart += value;
HookHandler.HookStart();
}
remove => HookHandler._beforeStart -= value;
}
public static event Delegates.CheckIfNewBossStatue_BeforeArgs CheckIfNewBossStatue
{
add
{

HookHandler._beforeCheckIfNewBossStatue += value;
HookHandler.HookCheckIfNewBossStatue();
}
remove => HookHandler._beforeCheckIfNewBossStatue -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Start_AfterArgs Start
{
add
{

HookHandler._afterStart += value;
HookHandler.HookStart();
}
remove => HookHandler._afterStart -= value;
}
public static event Delegates.CheckIfNewBossStatue_AfterArgs CheckIfNewBossStatue
{
add
{

HookHandler._afterCheckIfNewBossStatue += value;
HookHandler.HookCheckIfNewBossStatue();
}
remove => HookHandler._afterCheckIfNewBossStatue -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.BossStatueSetUnlockIndicator.hook_Start Start
{
add => On.BossStatueSetUnlockIndicator.Start += value;
remove => On.BossStatueSetUnlockIndicator.Start -= value;
}
public static event On.BossStatueSetUnlockIndicator.hook_CheckIfNewBossStatue CheckIfNewBossStatue
{
add => On.BossStatueSetUnlockIndicator.CheckIfNewBossStatue += value;
remove => On.BossStatueSetUnlockIndicator.CheckIfNewBossStatue -= value;
}
}

}
