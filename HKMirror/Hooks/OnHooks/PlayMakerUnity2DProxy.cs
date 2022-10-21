using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for PlayMakerUnity2DProxy class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerUnity2DProxy
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hookhelp()
{
if (!HookedList.Contains("help"))
{
HookedList.Add("help");
On.PlayMakerUnity2DProxy.help += help;

}
}
internal static event Delegates.help_BeforeArgs _beforehelp;
internal static event Delegates.help_AfterArgs _afterhelp;
private static void help(On.PlayMakerUnity2DProxy.orig_help orig,PlayMakerUnity2DProxy self)
{
Delegates.Params_help @params = new() 
{
self = self
};
if (_beforehelp != null)
{
foreach (Delegates.help_BeforeArgs toInvoke in _beforehelp.GetInvocationList())
{
try
{
_beforehelp?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterhelp != null)
{
foreach (Delegates.help_AfterArgs toInvoke in _afterhelp.GetInvocationList())
{
try
{
_afterhelp.Invoke(@params);
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
On.PlayMakerUnity2DProxy.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.PlayMakerUnity2DProxy.orig_Start orig,PlayMakerUnity2DProxy self)
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
internal static void HookRefreshImplementation()
{
if (!HookedList.Contains("RefreshImplementation"))
{
HookedList.Add("RefreshImplementation");
On.PlayMakerUnity2DProxy.RefreshImplementation += RefreshImplementation;

}
}
internal static event Delegates.RefreshImplementation_BeforeArgs _beforeRefreshImplementation;
internal static event Delegates.RefreshImplementation_AfterArgs _afterRefreshImplementation;
private static void RefreshImplementation(On.PlayMakerUnity2DProxy.orig_RefreshImplementation orig,PlayMakerUnity2DProxy self)
{
Delegates.Params_RefreshImplementation @params = new() 
{
self = self
};
if (_beforeRefreshImplementation != null)
{
foreach (Delegates.RefreshImplementation_BeforeArgs toInvoke in _beforeRefreshImplementation.GetInvocationList())
{
try
{
_beforeRefreshImplementation?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterRefreshImplementation != null)
{
foreach (Delegates.RefreshImplementation_AfterArgs toInvoke in _afterRefreshImplementation.GetInvocationList())
{
try
{
_afterRefreshImplementation.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnCollisionEnter2D()
{
if (!HookedList.Contains("OnCollisionEnter2D"))
{
HookedList.Add("OnCollisionEnter2D");
On.PlayMakerUnity2DProxy.OnCollisionEnter2D += OnCollisionEnter2D;

}
}
internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
internal static event Delegates.OnCollisionEnter2D_AfterArgs _afterOnCollisionEnter2D;
private static void OnCollisionEnter2D(On.PlayMakerUnity2DProxy.orig_OnCollisionEnter2D orig,PlayMakerUnity2DProxy self,  UnityEngine.Collision2D coll)
{
Delegates.Params_OnCollisionEnter2D @params = new() 
{
self = self
, coll = coll
};
if (_beforeOnCollisionEnter2D != null)
{
foreach (Delegates.OnCollisionEnter2D_BeforeArgs toInvoke in _beforeOnCollisionEnter2D.GetInvocationList())
{
try
{
_beforeOnCollisionEnter2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
coll = @params.coll;
orig(self, coll);
if (_afterOnCollisionEnter2D != null)
{
foreach (Delegates.OnCollisionEnter2D_AfterArgs toInvoke in _afterOnCollisionEnter2D.GetInvocationList())
{
try
{
_afterOnCollisionEnter2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnCollisionStay2D()
{
if (!HookedList.Contains("OnCollisionStay2D"))
{
HookedList.Add("OnCollisionStay2D");
On.PlayMakerUnity2DProxy.OnCollisionStay2D += OnCollisionStay2D;

}
}
internal static event Delegates.OnCollisionStay2D_BeforeArgs _beforeOnCollisionStay2D;
internal static event Delegates.OnCollisionStay2D_AfterArgs _afterOnCollisionStay2D;
private static void OnCollisionStay2D(On.PlayMakerUnity2DProxy.orig_OnCollisionStay2D orig,PlayMakerUnity2DProxy self,  UnityEngine.Collision2D coll)
{
Delegates.Params_OnCollisionStay2D @params = new() 
{
self = self
, coll = coll
};
if (_beforeOnCollisionStay2D != null)
{
foreach (Delegates.OnCollisionStay2D_BeforeArgs toInvoke in _beforeOnCollisionStay2D.GetInvocationList())
{
try
{
_beforeOnCollisionStay2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
coll = @params.coll;
orig(self, coll);
if (_afterOnCollisionStay2D != null)
{
foreach (Delegates.OnCollisionStay2D_AfterArgs toInvoke in _afterOnCollisionStay2D.GetInvocationList())
{
try
{
_afterOnCollisionStay2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnCollisionExit2D()
{
if (!HookedList.Contains("OnCollisionExit2D"))
{
HookedList.Add("OnCollisionExit2D");
On.PlayMakerUnity2DProxy.OnCollisionExit2D += OnCollisionExit2D;

}
}
internal static event Delegates.OnCollisionExit2D_BeforeArgs _beforeOnCollisionExit2D;
internal static event Delegates.OnCollisionExit2D_AfterArgs _afterOnCollisionExit2D;
private static void OnCollisionExit2D(On.PlayMakerUnity2DProxy.orig_OnCollisionExit2D orig,PlayMakerUnity2DProxy self,  UnityEngine.Collision2D coll)
{
Delegates.Params_OnCollisionExit2D @params = new() 
{
self = self
, coll = coll
};
if (_beforeOnCollisionExit2D != null)
{
foreach (Delegates.OnCollisionExit2D_BeforeArgs toInvoke in _beforeOnCollisionExit2D.GetInvocationList())
{
try
{
_beforeOnCollisionExit2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
coll = @params.coll;
orig(self, coll);
if (_afterOnCollisionExit2D != null)
{
foreach (Delegates.OnCollisionExit2D_AfterArgs toInvoke in _afterOnCollisionExit2D.GetInvocationList())
{
try
{
_afterOnCollisionExit2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnTriggerEnter2D()
{
if (!HookedList.Contains("OnTriggerEnter2D"))
{
HookedList.Add("OnTriggerEnter2D");
On.PlayMakerUnity2DProxy.OnTriggerEnter2D += OnTriggerEnter2D;

}
}
internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;
private static void OnTriggerEnter2D(On.PlayMakerUnity2DProxy.orig_OnTriggerEnter2D orig,PlayMakerUnity2DProxy self,  UnityEngine.Collider2D coll)
{
Delegates.Params_OnTriggerEnter2D @params = new() 
{
self = self
, coll = coll
};
if (_beforeOnTriggerEnter2D != null)
{
foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
{
try
{
_beforeOnTriggerEnter2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
coll = @params.coll;
orig(self, coll);
if (_afterOnTriggerEnter2D != null)
{
foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
{
try
{
_afterOnTriggerEnter2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnTriggerStay2D()
{
if (!HookedList.Contains("OnTriggerStay2D"))
{
HookedList.Add("OnTriggerStay2D");
On.PlayMakerUnity2DProxy.OnTriggerStay2D += OnTriggerStay2D;

}
}
internal static event Delegates.OnTriggerStay2D_BeforeArgs _beforeOnTriggerStay2D;
internal static event Delegates.OnTriggerStay2D_AfterArgs _afterOnTriggerStay2D;
private static void OnTriggerStay2D(On.PlayMakerUnity2DProxy.orig_OnTriggerStay2D orig,PlayMakerUnity2DProxy self,  UnityEngine.Collider2D coll)
{
Delegates.Params_OnTriggerStay2D @params = new() 
{
self = self
, coll = coll
};
if (_beforeOnTriggerStay2D != null)
{
foreach (Delegates.OnTriggerStay2D_BeforeArgs toInvoke in _beforeOnTriggerStay2D.GetInvocationList())
{
try
{
_beforeOnTriggerStay2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
coll = @params.coll;
orig(self, coll);
if (_afterOnTriggerStay2D != null)
{
foreach (Delegates.OnTriggerStay2D_AfterArgs toInvoke in _afterOnTriggerStay2D.GetInvocationList())
{
try
{
_afterOnTriggerStay2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnTriggerExit2D()
{
if (!HookedList.Contains("OnTriggerExit2D"))
{
HookedList.Add("OnTriggerExit2D");
On.PlayMakerUnity2DProxy.OnTriggerExit2D += OnTriggerExit2D;

}
}
internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;
private static void OnTriggerExit2D(On.PlayMakerUnity2DProxy.orig_OnTriggerExit2D orig,PlayMakerUnity2DProxy self,  UnityEngine.Collider2D coll)
{
Delegates.Params_OnTriggerExit2D @params = new() 
{
self = self
, coll = coll
};
if (_beforeOnTriggerExit2D != null)
{
foreach (Delegates.OnTriggerExit2D_BeforeArgs toInvoke in _beforeOnTriggerExit2D.GetInvocationList())
{
try
{
_beforeOnTriggerExit2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
coll = @params.coll;
orig(self, coll);
if (_afterOnTriggerExit2D != null)
{
foreach (Delegates.OnTriggerExit2D_AfterArgs toInvoke in _afterOnTriggerExit2D.GetInvocationList())
{
try
{
_afterOnTriggerExit2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookCheckGameObjectEventsImplementation()
{
if (!HookedList.Contains("CheckGameObjectEventsImplementation"))
{
HookedList.Add("CheckGameObjectEventsImplementation");
On.PlayMakerUnity2DProxy.CheckGameObjectEventsImplementation += CheckGameObjectEventsImplementation;

}
}
internal static event Delegates.CheckGameObjectEventsImplementation_BeforeArgs _beforeCheckGameObjectEventsImplementation;
internal static event Delegates.CheckGameObjectEventsImplementation_AfterArgs _afterCheckGameObjectEventsImplementation;
private static void CheckGameObjectEventsImplementation(On.PlayMakerUnity2DProxy.orig_CheckGameObjectEventsImplementation orig,PlayMakerUnity2DProxy self)
{
Delegates.Params_CheckGameObjectEventsImplementation @params = new() 
{
self = self
};
if (_beforeCheckGameObjectEventsImplementation != null)
{
foreach (Delegates.CheckGameObjectEventsImplementation_BeforeArgs toInvoke in _beforeCheckGameObjectEventsImplementation.GetInvocationList())
{
try
{
_beforeCheckGameObjectEventsImplementation?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterCheckGameObjectEventsImplementation != null)
{
foreach (Delegates.CheckGameObjectEventsImplementation_AfterArgs toInvoke in _afterCheckGameObjectEventsImplementation.GetInvocationList())
{
try
{
_afterCheckGameObjectEventsImplementation.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookCheckFsmEventsImplementation()
{
if (!HookedList.Contains("CheckFsmEventsImplementation"))
{
HookedList.Add("CheckFsmEventsImplementation");
On.PlayMakerUnity2DProxy.CheckFsmEventsImplementation += CheckFsmEventsImplementation;

}
}
internal static event Delegates.CheckFsmEventsImplementation_BeforeArgs _beforeCheckFsmEventsImplementation;
internal static event Delegates.CheckFsmEventsImplementation_AfterArgs _afterCheckFsmEventsImplementation;
private static void CheckFsmEventsImplementation(On.PlayMakerUnity2DProxy.orig_CheckFsmEventsImplementation orig,PlayMakerUnity2DProxy self,  PlayMakerFSM fsm)
{
Delegates.Params_CheckFsmEventsImplementation @params = new() 
{
self = self
, fsm = fsm
};
if (_beforeCheckFsmEventsImplementation != null)
{
foreach (Delegates.CheckFsmEventsImplementation_BeforeArgs toInvoke in _beforeCheckFsmEventsImplementation.GetInvocationList())
{
try
{
_beforeCheckFsmEventsImplementation?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
fsm = @params.fsm;
orig(self, fsm);
if (_afterCheckFsmEventsImplementation != null)
{
foreach (Delegates.CheckFsmEventsImplementation_AfterArgs toInvoke in _afterCheckFsmEventsImplementation.GetInvocationList())
{
try
{
_afterCheckFsmEventsImplementation.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookCheckTransition()
{
if (!HookedList.Contains("CheckTransition"))
{
HookedList.Add("CheckTransition");
On.PlayMakerUnity2DProxy.CheckTransition += CheckTransition;

}
}
internal static event Delegates.CheckTransition_BeforeArgs _beforeCheckTransition;
internal static event Delegates.CheckTransition_AfterArgs _afterCheckTransition;
private static void CheckTransition(On.PlayMakerUnity2DProxy.orig_CheckTransition orig,PlayMakerUnity2DProxy self,  string transitionName)
{
Delegates.Params_CheckTransition @params = new() 
{
self = self
, transitionName = transitionName
};
if (_beforeCheckTransition != null)
{
foreach (Delegates.CheckTransition_BeforeArgs toInvoke in _beforeCheckTransition.GetInvocationList())
{
try
{
_beforeCheckTransition?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
transitionName = @params.transitionName;
orig(self, transitionName);
if (_afterCheckTransition != null)
{
foreach (Delegates.CheckTransition_AfterArgs toInvoke in _afterCheckTransition.GetInvocationList())
{
try
{
_afterCheckTransition.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookorig_Start()
{
if (!HookedList.Contains("orig_Start"))
{
HookedList.Add("orig_Start");
new Hook(ReflectionHelper.GetMethodInfo(typeof(PlayMakerUnity2DProxy), "orig_Start", true), orig_Start);

}
}
internal static event Delegates.orig_Start_BeforeArgs _beforeorig_Start;
internal static event Delegates.orig_Start_AfterArgs _afterorig_Start;
private static void orig_Start(Action<PlayMakerUnity2DProxy> orig, PlayMakerUnity2DProxy self)
{
Delegates.Params_orig_Start @params = new() 
{
self = self
};
if (_beforeorig_Start != null)
{
foreach (Delegates.orig_Start_BeforeArgs toInvoke in _beforeorig_Start.GetInvocationList())
{
try
{
_beforeorig_Start?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterorig_Start != null)
{
foreach (Delegates.orig_Start_AfterArgs toInvoke in _afterorig_Start.GetInvocationList())
{
try
{
_afterorig_Start.Invoke(@params);
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
public sealed class Params_help
{
public PlayMakerUnity2DProxy self;
}
public delegate void help_BeforeArgs(Params_help args);
public delegate void help_AfterArgs(Params_help args);
public delegate void help_WithArgs (Action<PlayMakerUnity2DProxy> orig, PlayMakerUnity2DProxy self);
public sealed class Params_Start
{
public PlayMakerUnity2DProxy self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<PlayMakerUnity2DProxy> orig, PlayMakerUnity2DProxy self);
public sealed class Params_RefreshImplementation
{
public PlayMakerUnity2DProxy self;
}
public delegate void RefreshImplementation_BeforeArgs(Params_RefreshImplementation args);
public delegate void RefreshImplementation_AfterArgs(Params_RefreshImplementation args);
public delegate void RefreshImplementation_WithArgs (Action<PlayMakerUnity2DProxy> orig, PlayMakerUnity2DProxy self);
public sealed class Params_OnCollisionEnter2D
{
public PlayMakerUnity2DProxy self;
public UnityEngine.Collision2D coll;
}
public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);
public delegate void OnCollisionEnter2D_AfterArgs(Params_OnCollisionEnter2D args);
public delegate void OnCollisionEnter2D_WithArgs (Action<PlayMakerUnity2DProxy,  UnityEngine.Collision2D> orig, PlayMakerUnity2DProxy self,  UnityEngine.Collision2D coll);
public sealed class Params_OnCollisionStay2D
{
public PlayMakerUnity2DProxy self;
public UnityEngine.Collision2D coll;
}
public delegate void OnCollisionStay2D_BeforeArgs(Params_OnCollisionStay2D args);
public delegate void OnCollisionStay2D_AfterArgs(Params_OnCollisionStay2D args);
public delegate void OnCollisionStay2D_WithArgs (Action<PlayMakerUnity2DProxy,  UnityEngine.Collision2D> orig, PlayMakerUnity2DProxy self,  UnityEngine.Collision2D coll);
public sealed class Params_OnCollisionExit2D
{
public PlayMakerUnity2DProxy self;
public UnityEngine.Collision2D coll;
}
public delegate void OnCollisionExit2D_BeforeArgs(Params_OnCollisionExit2D args);
public delegate void OnCollisionExit2D_AfterArgs(Params_OnCollisionExit2D args);
public delegate void OnCollisionExit2D_WithArgs (Action<PlayMakerUnity2DProxy,  UnityEngine.Collision2D> orig, PlayMakerUnity2DProxy self,  UnityEngine.Collision2D coll);
public sealed class Params_OnTriggerEnter2D
{
public PlayMakerUnity2DProxy self;
public UnityEngine.Collider2D coll;
}
public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_WithArgs (Action<PlayMakerUnity2DProxy,  UnityEngine.Collider2D> orig, PlayMakerUnity2DProxy self,  UnityEngine.Collider2D coll);
public sealed class Params_OnTriggerStay2D
{
public PlayMakerUnity2DProxy self;
public UnityEngine.Collider2D coll;
}
public delegate void OnTriggerStay2D_BeforeArgs(Params_OnTriggerStay2D args);
public delegate void OnTriggerStay2D_AfterArgs(Params_OnTriggerStay2D args);
public delegate void OnTriggerStay2D_WithArgs (Action<PlayMakerUnity2DProxy,  UnityEngine.Collider2D> orig, PlayMakerUnity2DProxy self,  UnityEngine.Collider2D coll);
public sealed class Params_OnTriggerExit2D
{
public PlayMakerUnity2DProxy self;
public UnityEngine.Collider2D coll;
}
public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);
public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);
public delegate void OnTriggerExit2D_WithArgs (Action<PlayMakerUnity2DProxy,  UnityEngine.Collider2D> orig, PlayMakerUnity2DProxy self,  UnityEngine.Collider2D coll);
public sealed class Params_CheckGameObjectEventsImplementation
{
public PlayMakerUnity2DProxy self;
}
public delegate void CheckGameObjectEventsImplementation_BeforeArgs(Params_CheckGameObjectEventsImplementation args);
public delegate void CheckGameObjectEventsImplementation_AfterArgs(Params_CheckGameObjectEventsImplementation args);
public delegate void CheckGameObjectEventsImplementation_WithArgs (Action<PlayMakerUnity2DProxy> orig, PlayMakerUnity2DProxy self);
public sealed class Params_CheckFsmEventsImplementation
{
public PlayMakerUnity2DProxy self;
public PlayMakerFSM fsm;
}
public delegate void CheckFsmEventsImplementation_BeforeArgs(Params_CheckFsmEventsImplementation args);
public delegate void CheckFsmEventsImplementation_AfterArgs(Params_CheckFsmEventsImplementation args);
public delegate void CheckFsmEventsImplementation_WithArgs (Action<PlayMakerUnity2DProxy,  PlayMakerFSM> orig, PlayMakerUnity2DProxy self,  PlayMakerFSM fsm);
public sealed class Params_CheckTransition
{
public PlayMakerUnity2DProxy self;
public string transitionName;
}
public delegate void CheckTransition_BeforeArgs(Params_CheckTransition args);
public delegate void CheckTransition_AfterArgs(Params_CheckTransition args);
public delegate void CheckTransition_WithArgs (Action<PlayMakerUnity2DProxy,  string> orig, PlayMakerUnity2DProxy self,  string transitionName);
public sealed class Params_orig_Start
{
public PlayMakerUnity2DProxy self;
}
public delegate void orig_Start_BeforeArgs(Params_orig_Start args);
public delegate void orig_Start_AfterArgs(Params_orig_Start args);
public delegate void orig_Start_WithArgs (Action<PlayMakerUnity2DProxy> orig, PlayMakerUnity2DProxy self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.help_BeforeArgs help
{
add
{

HookHandler._beforehelp += value;
HookHandler.Hookhelp();
}
remove => HookHandler._beforehelp -= value;
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
public static event Delegates.RefreshImplementation_BeforeArgs RefreshImplementation
{
add
{

HookHandler._beforeRefreshImplementation += value;
HookHandler.HookRefreshImplementation();
}
remove => HookHandler._beforeRefreshImplementation -= value;
}
public static event Delegates.OnCollisionEnter2D_BeforeArgs OnCollisionEnter2D
{
add
{

HookHandler._beforeOnCollisionEnter2D += value;
HookHandler.HookOnCollisionEnter2D();
}
remove => HookHandler._beforeOnCollisionEnter2D -= value;
}
public static event Delegates.OnCollisionStay2D_BeforeArgs OnCollisionStay2D
{
add
{

HookHandler._beforeOnCollisionStay2D += value;
HookHandler.HookOnCollisionStay2D();
}
remove => HookHandler._beforeOnCollisionStay2D -= value;
}
public static event Delegates.OnCollisionExit2D_BeforeArgs OnCollisionExit2D
{
add
{

HookHandler._beforeOnCollisionExit2D += value;
HookHandler.HookOnCollisionExit2D();
}
remove => HookHandler._beforeOnCollisionExit2D -= value;
}
public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
{
add
{

HookHandler._beforeOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._beforeOnTriggerEnter2D -= value;
}
public static event Delegates.OnTriggerStay2D_BeforeArgs OnTriggerStay2D
{
add
{

HookHandler._beforeOnTriggerStay2D += value;
HookHandler.HookOnTriggerStay2D();
}
remove => HookHandler._beforeOnTriggerStay2D -= value;
}
public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
{
add
{

HookHandler._beforeOnTriggerExit2D += value;
HookHandler.HookOnTriggerExit2D();
}
remove => HookHandler._beforeOnTriggerExit2D -= value;
}
public static event Delegates.CheckGameObjectEventsImplementation_BeforeArgs CheckGameObjectEventsImplementation
{
add
{

HookHandler._beforeCheckGameObjectEventsImplementation += value;
HookHandler.HookCheckGameObjectEventsImplementation();
}
remove => HookHandler._beforeCheckGameObjectEventsImplementation -= value;
}
public static event Delegates.CheckFsmEventsImplementation_BeforeArgs CheckFsmEventsImplementation
{
add
{

HookHandler._beforeCheckFsmEventsImplementation += value;
HookHandler.HookCheckFsmEventsImplementation();
}
remove => HookHandler._beforeCheckFsmEventsImplementation -= value;
}
public static event Delegates.CheckTransition_BeforeArgs CheckTransition
{
add
{

HookHandler._beforeCheckTransition += value;
HookHandler.HookCheckTransition();
}
remove => HookHandler._beforeCheckTransition -= value;
}
public static event Delegates.orig_Start_BeforeArgs orig_Start
{
add
{

HookHandler._beforeorig_Start += value;
HookHandler.Hookorig_Start();
}
remove => HookHandler._beforeorig_Start -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.help_AfterArgs help
{
add
{

HookHandler._afterhelp += value;
HookHandler.Hookhelp();
}
remove => HookHandler._afterhelp -= value;
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
public static event Delegates.RefreshImplementation_AfterArgs RefreshImplementation
{
add
{

HookHandler._afterRefreshImplementation += value;
HookHandler.HookRefreshImplementation();
}
remove => HookHandler._afterRefreshImplementation -= value;
}
public static event Delegates.OnCollisionEnter2D_AfterArgs OnCollisionEnter2D
{
add
{

HookHandler._afterOnCollisionEnter2D += value;
HookHandler.HookOnCollisionEnter2D();
}
remove => HookHandler._afterOnCollisionEnter2D -= value;
}
public static event Delegates.OnCollisionStay2D_AfterArgs OnCollisionStay2D
{
add
{

HookHandler._afterOnCollisionStay2D += value;
HookHandler.HookOnCollisionStay2D();
}
remove => HookHandler._afterOnCollisionStay2D -= value;
}
public static event Delegates.OnCollisionExit2D_AfterArgs OnCollisionExit2D
{
add
{

HookHandler._afterOnCollisionExit2D += value;
HookHandler.HookOnCollisionExit2D();
}
remove => HookHandler._afterOnCollisionExit2D -= value;
}
public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
{
add
{

HookHandler._afterOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._afterOnTriggerEnter2D -= value;
}
public static event Delegates.OnTriggerStay2D_AfterArgs OnTriggerStay2D
{
add
{

HookHandler._afterOnTriggerStay2D += value;
HookHandler.HookOnTriggerStay2D();
}
remove => HookHandler._afterOnTriggerStay2D -= value;
}
public static event Delegates.OnTriggerExit2D_AfterArgs OnTriggerExit2D
{
add
{

HookHandler._afterOnTriggerExit2D += value;
HookHandler.HookOnTriggerExit2D();
}
remove => HookHandler._afterOnTriggerExit2D -= value;
}
public static event Delegates.CheckGameObjectEventsImplementation_AfterArgs CheckGameObjectEventsImplementation
{
add
{

HookHandler._afterCheckGameObjectEventsImplementation += value;
HookHandler.HookCheckGameObjectEventsImplementation();
}
remove => HookHandler._afterCheckGameObjectEventsImplementation -= value;
}
public static event Delegates.CheckFsmEventsImplementation_AfterArgs CheckFsmEventsImplementation
{
add
{

HookHandler._afterCheckFsmEventsImplementation += value;
HookHandler.HookCheckFsmEventsImplementation();
}
remove => HookHandler._afterCheckFsmEventsImplementation -= value;
}
public static event Delegates.CheckTransition_AfterArgs CheckTransition
{
add
{

HookHandler._afterCheckTransition += value;
HookHandler.HookCheckTransition();
}
remove => HookHandler._afterCheckTransition -= value;
}
public static event Delegates.orig_Start_AfterArgs orig_Start
{
add
{

HookHandler._afterorig_Start += value;
HookHandler.Hookorig_Start();
}
remove => HookHandler._afterorig_Start -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.PlayMakerUnity2DProxy.hook_help help
{
add => On.PlayMakerUnity2DProxy.help += value;
remove => On.PlayMakerUnity2DProxy.help -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_Start Start
{
add => On.PlayMakerUnity2DProxy.Start += value;
remove => On.PlayMakerUnity2DProxy.Start -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_RefreshImplementation RefreshImplementation
{
add => On.PlayMakerUnity2DProxy.RefreshImplementation += value;
remove => On.PlayMakerUnity2DProxy.RefreshImplementation -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_OnCollisionEnter2D OnCollisionEnter2D
{
add => On.PlayMakerUnity2DProxy.OnCollisionEnter2D += value;
remove => On.PlayMakerUnity2DProxy.OnCollisionEnter2D -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_OnCollisionStay2D OnCollisionStay2D
{
add => On.PlayMakerUnity2DProxy.OnCollisionStay2D += value;
remove => On.PlayMakerUnity2DProxy.OnCollisionStay2D -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_OnCollisionExit2D OnCollisionExit2D
{
add => On.PlayMakerUnity2DProxy.OnCollisionExit2D += value;
remove => On.PlayMakerUnity2DProxy.OnCollisionExit2D -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_OnTriggerEnter2D OnTriggerEnter2D
{
add => On.PlayMakerUnity2DProxy.OnTriggerEnter2D += value;
remove => On.PlayMakerUnity2DProxy.OnTriggerEnter2D -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_OnTriggerStay2D OnTriggerStay2D
{
add => On.PlayMakerUnity2DProxy.OnTriggerStay2D += value;
remove => On.PlayMakerUnity2DProxy.OnTriggerStay2D -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_OnTriggerExit2D OnTriggerExit2D
{
add => On.PlayMakerUnity2DProxy.OnTriggerExit2D += value;
remove => On.PlayMakerUnity2DProxy.OnTriggerExit2D -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_CheckGameObjectEventsImplementation CheckGameObjectEventsImplementation
{
add => On.PlayMakerUnity2DProxy.CheckGameObjectEventsImplementation += value;
remove => On.PlayMakerUnity2DProxy.CheckGameObjectEventsImplementation -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_CheckFsmEventsImplementation CheckFsmEventsImplementation
{
add => On.PlayMakerUnity2DProxy.CheckFsmEventsImplementation += value;
remove => On.PlayMakerUnity2DProxy.CheckFsmEventsImplementation -= value;
}
public static event On.PlayMakerUnity2DProxy.hook_CheckTransition CheckTransition
{
add => On.PlayMakerUnity2DProxy.CheckTransition += value;
remove => On.PlayMakerUnity2DProxy.CheckTransition -= value;
}
public static event Delegates.orig_Start_WithArgs orig_Start
{
add => HookEndpointManager.Add<Delegates.orig_Start_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(PlayMakerUnity2DProxy), "orig_Start", true), value);
remove => HookEndpointManager.Remove<Delegates.orig_Start_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(PlayMakerUnity2DProxy), "orig_Start", true), value);
}
}

}
