using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for EnemyDreamnailReaction class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyDreamnailReaction
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
On.EnemyDreamnailReaction.Reset += Reset;

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(On.EnemyDreamnailReaction.orig_Reset orig,EnemyDreamnailReaction self)
{
Delegates.Params_Reset @params = new() 
{
self = self
};
if (_beforeReset != null)
{
foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
{
try
{
_beforeReset?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterReset != null)
{
foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
{
try
{
_afterReset.Invoke(@params);
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
On.EnemyDreamnailReaction.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.EnemyDreamnailReaction.orig_Start orig,EnemyDreamnailReaction self)
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
internal static void HookRecieveDreamImpact()
{
if (!HookedList.Contains("RecieveDreamImpact"))
{
HookedList.Add("RecieveDreamImpact");
On.EnemyDreamnailReaction.RecieveDreamImpact += RecieveDreamImpact;

}
}
internal static event Delegates.RecieveDreamImpact_BeforeArgs _beforeRecieveDreamImpact;
internal static event Delegates.RecieveDreamImpact_AfterArgs _afterRecieveDreamImpact;
private static void RecieveDreamImpact(On.EnemyDreamnailReaction.orig_RecieveDreamImpact orig,EnemyDreamnailReaction self)
{
Delegates.Params_RecieveDreamImpact @params = new() 
{
self = self
};
if (_beforeRecieveDreamImpact != null)
{
foreach (Delegates.RecieveDreamImpact_BeforeArgs toInvoke in _beforeRecieveDreamImpact.GetInvocationList())
{
try
{
_beforeRecieveDreamImpact?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterRecieveDreamImpact != null)
{
foreach (Delegates.RecieveDreamImpact_AfterArgs toInvoke in _afterRecieveDreamImpact.GetInvocationList())
{
try
{
_afterRecieveDreamImpact.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookMakeReady()
{
if (!HookedList.Contains("MakeReady"))
{
HookedList.Add("MakeReady");
On.EnemyDreamnailReaction.MakeReady += MakeReady;

}
}
internal static event Delegates.MakeReady_BeforeArgs _beforeMakeReady;
internal static event Delegates.MakeReady_AfterArgs _afterMakeReady;
private static void MakeReady(On.EnemyDreamnailReaction.orig_MakeReady orig,EnemyDreamnailReaction self)
{
Delegates.Params_MakeReady @params = new() 
{
self = self
};
if (_beforeMakeReady != null)
{
foreach (Delegates.MakeReady_BeforeArgs toInvoke in _beforeMakeReady.GetInvocationList())
{
try
{
_beforeMakeReady?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterMakeReady != null)
{
foreach (Delegates.MakeReady_AfterArgs toInvoke in _afterMakeReady.GetInvocationList())
{
try
{
_afterMakeReady.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookSetConvoTitle()
{
if (!HookedList.Contains("SetConvoTitle"))
{
HookedList.Add("SetConvoTitle");
On.EnemyDreamnailReaction.SetConvoTitle += SetConvoTitle;

}
}
internal static event Delegates.SetConvoTitle_BeforeArgs _beforeSetConvoTitle;
internal static event Delegates.SetConvoTitle_AfterArgs _afterSetConvoTitle;
private static void SetConvoTitle(On.EnemyDreamnailReaction.orig_SetConvoTitle orig,EnemyDreamnailReaction self,  string title)
{
Delegates.Params_SetConvoTitle @params = new() 
{
self = self
, title = title
};
if (_beforeSetConvoTitle != null)
{
foreach (Delegates.SetConvoTitle_BeforeArgs toInvoke in _beforeSetConvoTitle.GetInvocationList())
{
try
{
_beforeSetConvoTitle?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
title = @params.title;
orig(self, title);
if (_afterSetConvoTitle != null)
{
foreach (Delegates.SetConvoTitle_AfterArgs toInvoke in _afterSetConvoTitle.GetInvocationList())
{
try
{
_afterSetConvoTitle.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookShowConvo()
{
if (!HookedList.Contains("ShowConvo"))
{
HookedList.Add("ShowConvo");
On.EnemyDreamnailReaction.ShowConvo += ShowConvo;

}
}
internal static event Delegates.ShowConvo_BeforeArgs _beforeShowConvo;
internal static event Delegates.ShowConvo_AfterArgs _afterShowConvo;
private static void ShowConvo(On.EnemyDreamnailReaction.orig_ShowConvo orig,EnemyDreamnailReaction self)
{
Delegates.Params_ShowConvo @params = new() 
{
self = self
};
if (_beforeShowConvo != null)
{
foreach (Delegates.ShowConvo_BeforeArgs toInvoke in _beforeShowConvo.GetInvocationList())
{
try
{
_beforeShowConvo?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterShowConvo != null)
{
foreach (Delegates.ShowConvo_AfterArgs toInvoke in _afterShowConvo.GetInvocationList())
{
try
{
_afterShowConvo.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookUpdate()
{
if (!HookedList.Contains("Update"))
{
HookedList.Add("Update");
On.EnemyDreamnailReaction.Update += Update;

}
}
internal static event Delegates.Update_BeforeArgs _beforeUpdate;
internal static event Delegates.Update_AfterArgs _afterUpdate;
private static void Update(On.EnemyDreamnailReaction.orig_Update orig,EnemyDreamnailReaction self)
{
Delegates.Params_Update @params = new() 
{
self = self
};
if (_beforeUpdate != null)
{
foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
{
try
{
_beforeUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterUpdate != null)
{
foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
{
try
{
_afterUpdate.Invoke(@params);
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
public sealed class Params_Reset
{
public EnemyDreamnailReaction self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<EnemyDreamnailReaction> orig, EnemyDreamnailReaction self);
public sealed class Params_Start
{
public EnemyDreamnailReaction self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<EnemyDreamnailReaction> orig, EnemyDreamnailReaction self);
public sealed class Params_RecieveDreamImpact
{
public EnemyDreamnailReaction self;
}
public delegate void RecieveDreamImpact_BeforeArgs(Params_RecieveDreamImpact args);
public delegate void RecieveDreamImpact_AfterArgs(Params_RecieveDreamImpact args);
public delegate void RecieveDreamImpact_WithArgs (Action<EnemyDreamnailReaction> orig, EnemyDreamnailReaction self);
public sealed class Params_MakeReady
{
public EnemyDreamnailReaction self;
}
public delegate void MakeReady_BeforeArgs(Params_MakeReady args);
public delegate void MakeReady_AfterArgs(Params_MakeReady args);
public delegate void MakeReady_WithArgs (Action<EnemyDreamnailReaction> orig, EnemyDreamnailReaction self);
public sealed class Params_SetConvoTitle
{
public EnemyDreamnailReaction self;
public string title;
}
public delegate void SetConvoTitle_BeforeArgs(Params_SetConvoTitle args);
public delegate void SetConvoTitle_AfterArgs(Params_SetConvoTitle args);
public delegate void SetConvoTitle_WithArgs (Action<EnemyDreamnailReaction,  string> orig, EnemyDreamnailReaction self,  string title);
public sealed class Params_ShowConvo
{
public EnemyDreamnailReaction self;
}
public delegate void ShowConvo_BeforeArgs(Params_ShowConvo args);
public delegate void ShowConvo_AfterArgs(Params_ShowConvo args);
public delegate void ShowConvo_WithArgs (Action<EnemyDreamnailReaction> orig, EnemyDreamnailReaction self);
public sealed class Params_Update
{
public EnemyDreamnailReaction self;
}
public delegate void Update_BeforeArgs(Params_Update args);
public delegate void Update_AfterArgs(Params_Update args);
public delegate void Update_WithArgs (Action<EnemyDreamnailReaction> orig, EnemyDreamnailReaction self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Reset_BeforeArgs Reset
{
add
{

HookHandler._beforeReset += value;
HookHandler.HookReset();
}
remove => HookHandler._beforeReset -= value;
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
public static event Delegates.RecieveDreamImpact_BeforeArgs RecieveDreamImpact
{
add
{

HookHandler._beforeRecieveDreamImpact += value;
HookHandler.HookRecieveDreamImpact();
}
remove => HookHandler._beforeRecieveDreamImpact -= value;
}
public static event Delegates.MakeReady_BeforeArgs MakeReady
{
add
{

HookHandler._beforeMakeReady += value;
HookHandler.HookMakeReady();
}
remove => HookHandler._beforeMakeReady -= value;
}
public static event Delegates.SetConvoTitle_BeforeArgs SetConvoTitle
{
add
{

HookHandler._beforeSetConvoTitle += value;
HookHandler.HookSetConvoTitle();
}
remove => HookHandler._beforeSetConvoTitle -= value;
}
public static event Delegates.ShowConvo_BeforeArgs ShowConvo
{
add
{

HookHandler._beforeShowConvo += value;
HookHandler.HookShowConvo();
}
remove => HookHandler._beforeShowConvo -= value;
}
public static event Delegates.Update_BeforeArgs Update
{
add
{

HookHandler._beforeUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._beforeUpdate -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Reset_AfterArgs Reset
{
add
{

HookHandler._afterReset += value;
HookHandler.HookReset();
}
remove => HookHandler._afterReset -= value;
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
public static event Delegates.RecieveDreamImpact_AfterArgs RecieveDreamImpact
{
add
{

HookHandler._afterRecieveDreamImpact += value;
HookHandler.HookRecieveDreamImpact();
}
remove => HookHandler._afterRecieveDreamImpact -= value;
}
public static event Delegates.MakeReady_AfterArgs MakeReady
{
add
{

HookHandler._afterMakeReady += value;
HookHandler.HookMakeReady();
}
remove => HookHandler._afterMakeReady -= value;
}
public static event Delegates.SetConvoTitle_AfterArgs SetConvoTitle
{
add
{

HookHandler._afterSetConvoTitle += value;
HookHandler.HookSetConvoTitle();
}
remove => HookHandler._afterSetConvoTitle -= value;
}
public static event Delegates.ShowConvo_AfterArgs ShowConvo
{
add
{

HookHandler._afterShowConvo += value;
HookHandler.HookShowConvo();
}
remove => HookHandler._afterShowConvo -= value;
}
public static event Delegates.Update_AfterArgs Update
{
add
{

HookHandler._afterUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._afterUpdate -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.EnemyDreamnailReaction.hook_Reset Reset
{
add => On.EnemyDreamnailReaction.Reset += value;
remove => On.EnemyDreamnailReaction.Reset -= value;
}
public static event On.EnemyDreamnailReaction.hook_Start Start
{
add => On.EnemyDreamnailReaction.Start += value;
remove => On.EnemyDreamnailReaction.Start -= value;
}
public static event On.EnemyDreamnailReaction.hook_RecieveDreamImpact RecieveDreamImpact
{
add => On.EnemyDreamnailReaction.RecieveDreamImpact += value;
remove => On.EnemyDreamnailReaction.RecieveDreamImpact -= value;
}
public static event On.EnemyDreamnailReaction.hook_MakeReady MakeReady
{
add => On.EnemyDreamnailReaction.MakeReady += value;
remove => On.EnemyDreamnailReaction.MakeReady -= value;
}
public static event On.EnemyDreamnailReaction.hook_SetConvoTitle SetConvoTitle
{
add => On.EnemyDreamnailReaction.SetConvoTitle += value;
remove => On.EnemyDreamnailReaction.SetConvoTitle -= value;
}
public static event On.EnemyDreamnailReaction.hook_ShowConvo ShowConvo
{
add => On.EnemyDreamnailReaction.ShowConvo += value;
remove => On.EnemyDreamnailReaction.ShowConvo -= value;
}
public static event On.EnemyDreamnailReaction.hook_Update Update
{
add => On.EnemyDreamnailReaction.Update += value;
remove => On.EnemyDreamnailReaction.Update -= value;
}
}

}
