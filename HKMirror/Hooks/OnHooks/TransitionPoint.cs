using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for TransitionPoint class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTransitionPoint
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hookget_TransitionPoints()
{
if (!HookedList.Contains("get_TransitionPoints"))
{
HookedList.Add("get_TransitionPoints");
new Hook(ReflectionHelper.GetMethodInfo(typeof(TransitionPoint), "get_TransitionPoints", false), get_TransitionPoints);

}
}
internal static event Delegates.get_TransitionPoints_BeforeArgs _beforeget_TransitionPoints;
internal static event Delegates.get_TransitionPoints_AfterArgs _afterget_TransitionPoints;
private static System.Collections.Generic.List<TransitionPoint> get_TransitionPoints(Func<System.Collections.Generic.List<TransitionPoint>> orig)
{
if (_beforeget_TransitionPoints != null)
{
foreach (Delegates.get_TransitionPoints_BeforeArgs toInvoke in _beforeget_TransitionPoints.GetInvocationList())
{
try
{
_beforeget_TransitionPoints?.Invoke();
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
var retVal = orig();
if (_afterget_TransitionPoints != null)
{
foreach (Delegates.get_TransitionPoints_AfterArgs toInvoke in _afterget_TransitionPoints.GetInvocationList())
{
try
{
retVal = _afterget_TransitionPoints.Invoke(retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookInit()
{
if (!HookedList.Contains("Init"))
{
HookedList.Add("Init");
On.TransitionPoint.Init += Init;

}
}
internal static event Delegates.Init_BeforeArgs _beforeInit;
internal static event Delegates.Init_AfterArgs _afterInit;
private static void Init(On.TransitionPoint.orig_Init orig)
{
if (_beforeInit != null)
{
foreach (Delegates.Init_BeforeArgs toInvoke in _beforeInit.GetInvocationList())
{
try
{
_beforeInit?.Invoke();
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
orig();
if (_afterInit != null)
{
foreach (Delegates.Init_AfterArgs toInvoke in _afterInit.GetInvocationList())
{
try
{
_afterInit.Invoke();
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.TransitionPoint.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.TransitionPoint.orig_Awake orig,TransitionPoint self)
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
internal static void HookOnDestroy()
{
if (!HookedList.Contains("OnDestroy"))
{
HookedList.Add("OnDestroy");
On.TransitionPoint.OnDestroy += OnDestroy;

}
}
internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;
private static void OnDestroy(On.TransitionPoint.orig_OnDestroy orig,TransitionPoint self)
{
Delegates.Params_OnDestroy @params = new() 
{
self = self
};
if (_beforeOnDestroy != null)
{
foreach (Delegates.OnDestroy_BeforeArgs toInvoke in _beforeOnDestroy.GetInvocationList())
{
try
{
_beforeOnDestroy?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnDestroy != null)
{
foreach (Delegates.OnDestroy_AfterArgs toInvoke in _afterOnDestroy.GetInvocationList())
{
try
{
_afterOnDestroy.Invoke(@params);
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
On.TransitionPoint.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.TransitionPoint.orig_Start orig,TransitionPoint self)
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
internal static void HookOnTriggerEnter2D()
{
if (!HookedList.Contains("OnTriggerEnter2D"))
{
HookedList.Add("OnTriggerEnter2D");
On.TransitionPoint.OnTriggerEnter2D += OnTriggerEnter2D;

}
}
internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;
private static void OnTriggerEnter2D(On.TransitionPoint.orig_OnTriggerEnter2D orig,TransitionPoint self,  UnityEngine.Collider2D movingObj)
{
Delegates.Params_OnTriggerEnter2D @params = new() 
{
self = self
, movingObj = movingObj
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
movingObj = @params.movingObj;
orig(self, movingObj);
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
On.TransitionPoint.OnTriggerStay2D += OnTriggerStay2D;

}
}
internal static event Delegates.OnTriggerStay2D_BeforeArgs _beforeOnTriggerStay2D;
internal static event Delegates.OnTriggerStay2D_AfterArgs _afterOnTriggerStay2D;
private static void OnTriggerStay2D(On.TransitionPoint.orig_OnTriggerStay2D orig,TransitionPoint self,  UnityEngine.Collider2D movingObj)
{
Delegates.Params_OnTriggerStay2D @params = new() 
{
self = self
, movingObj = movingObj
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
movingObj = @params.movingObj;
orig(self, movingObj);
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
internal static void HookOnDrawGizmos()
{
if (!HookedList.Contains("OnDrawGizmos"))
{
HookedList.Add("OnDrawGizmos");
On.TransitionPoint.OnDrawGizmos += OnDrawGizmos;

}
}
internal static event Delegates.OnDrawGizmos_BeforeArgs _beforeOnDrawGizmos;
internal static event Delegates.OnDrawGizmos_AfterArgs _afterOnDrawGizmos;
private static void OnDrawGizmos(On.TransitionPoint.orig_OnDrawGizmos orig,TransitionPoint self)
{
Delegates.Params_OnDrawGizmos @params = new() 
{
self = self
};
if (_beforeOnDrawGizmos != null)
{
foreach (Delegates.OnDrawGizmos_BeforeArgs toInvoke in _beforeOnDrawGizmos.GetInvocationList())
{
try
{
_beforeOnDrawGizmos?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnDrawGizmos != null)
{
foreach (Delegates.OnDrawGizmos_AfterArgs toInvoke in _afterOnDrawGizmos.GetInvocationList())
{
try
{
_afterOnDrawGizmos.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookGetGatePosition()
{
if (!HookedList.Contains("GetGatePosition"))
{
HookedList.Add("GetGatePosition");
On.TransitionPoint.GetGatePosition += GetGatePosition;

}
}
internal static event Delegates.GetGatePosition_BeforeArgs _beforeGetGatePosition;
internal static event Delegates.GetGatePosition_AfterArgs _afterGetGatePosition;
private static GlobalEnums.GatePosition GetGatePosition(On.TransitionPoint.orig_GetGatePosition orig,TransitionPoint self)
{
Delegates.Params_GetGatePosition @params = new() 
{
self = self
};
if (_beforeGetGatePosition != null)
{
foreach (Delegates.GetGatePosition_BeforeArgs toInvoke in _beforeGetGatePosition.GetInvocationList())
{
try
{
_beforeGetGatePosition?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterGetGatePosition != null)
{
foreach (Delegates.GetGatePosition_AfterArgs toInvoke in _afterGetGatePosition.GetInvocationList())
{
try
{
retVal = _afterGetGatePosition.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookSetTargetScene()
{
if (!HookedList.Contains("SetTargetScene"))
{
HookedList.Add("SetTargetScene");
On.TransitionPoint.SetTargetScene += SetTargetScene;

}
}
internal static event Delegates.SetTargetScene_BeforeArgs _beforeSetTargetScene;
internal static event Delegates.SetTargetScene_AfterArgs _afterSetTargetScene;
private static void SetTargetScene(On.TransitionPoint.orig_SetTargetScene orig,TransitionPoint self,  string newScene)
{
Delegates.Params_SetTargetScene @params = new() 
{
self = self
, newScene = newScene
};
if (_beforeSetTargetScene != null)
{
foreach (Delegates.SetTargetScene_BeforeArgs toInvoke in _beforeSetTargetScene.GetInvocationList())
{
try
{
_beforeSetTargetScene?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
newScene = @params.newScene;
orig(self, newScene);
if (_afterSetTargetScene != null)
{
foreach (Delegates.SetTargetScene_AfterArgs toInvoke in _afterSetTargetScene.GetInvocationList())
{
try
{
_afterSetTargetScene.Invoke(@params);
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
public delegate void get_TransitionPoints_BeforeArgs();
public delegate System.Collections.Generic.List<TransitionPoint> get_TransitionPoints_AfterArgs(System.Collections.Generic.List<TransitionPoint> ret);
public delegate System.Collections.Generic.List<TransitionPoint> get_TransitionPoints_WithArgs (Func<System.Collections.Generic.List<TransitionPoint>> orig);
public delegate void Init_BeforeArgs();
public delegate void Init_AfterArgs();
public delegate void Init_WithArgs (Action orig);
public sealed class Params_Awake
{
public TransitionPoint self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<TransitionPoint> orig, TransitionPoint self);
public sealed class Params_OnDestroy
{
public TransitionPoint self;
}
public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);
public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);
public delegate void OnDestroy_WithArgs (Action<TransitionPoint> orig, TransitionPoint self);
public sealed class Params_Start
{
public TransitionPoint self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<TransitionPoint> orig, TransitionPoint self);
public sealed class Params_OnTriggerEnter2D
{
public TransitionPoint self;
public UnityEngine.Collider2D movingObj;
}
public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_WithArgs (Action<TransitionPoint,  UnityEngine.Collider2D> orig, TransitionPoint self,  UnityEngine.Collider2D movingObj);
public sealed class Params_OnTriggerStay2D
{
public TransitionPoint self;
public UnityEngine.Collider2D movingObj;
}
public delegate void OnTriggerStay2D_BeforeArgs(Params_OnTriggerStay2D args);
public delegate void OnTriggerStay2D_AfterArgs(Params_OnTriggerStay2D args);
public delegate void OnTriggerStay2D_WithArgs (Action<TransitionPoint,  UnityEngine.Collider2D> orig, TransitionPoint self,  UnityEngine.Collider2D movingObj);
public sealed class Params_OnDrawGizmos
{
public TransitionPoint self;
}
public delegate void OnDrawGizmos_BeforeArgs(Params_OnDrawGizmos args);
public delegate void OnDrawGizmos_AfterArgs(Params_OnDrawGizmos args);
public delegate void OnDrawGizmos_WithArgs (Action<TransitionPoint> orig, TransitionPoint self);
public sealed class Params_GetGatePosition
{
public TransitionPoint self;
}
public delegate void GetGatePosition_BeforeArgs(Params_GetGatePosition args);
public delegate GlobalEnums.GatePosition GetGatePosition_AfterArgs(Params_GetGatePosition args, GlobalEnums.GatePosition ret);
public delegate GlobalEnums.GatePosition GetGatePosition_WithArgs (Func<TransitionPoint, GlobalEnums.GatePosition> orig, TransitionPoint self);
public sealed class Params_SetTargetScene
{
public TransitionPoint self;
public string newScene;
}
public delegate void SetTargetScene_BeforeArgs(Params_SetTargetScene args);
public delegate void SetTargetScene_AfterArgs(Params_SetTargetScene args);
public delegate void SetTargetScene_WithArgs (Action<TransitionPoint,  string> orig, TransitionPoint self,  string newScene);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.get_TransitionPoints_BeforeArgs get_TransitionPoints
{
add
{

HookHandler._beforeget_TransitionPoints += value;
HookHandler.Hookget_TransitionPoints();
}
remove => HookHandler._beforeget_TransitionPoints -= value;
}
public static event Delegates.Init_BeforeArgs Init
{
add
{

HookHandler._beforeInit += value;
HookHandler.HookInit();
}
remove => HookHandler._beforeInit -= value;
}
public static event Delegates.Awake_BeforeArgs Awake
{
add
{

HookHandler._beforeAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._beforeAwake -= value;
}
public static event Delegates.OnDestroy_BeforeArgs OnDestroy
{
add
{

HookHandler._beforeOnDestroy += value;
HookHandler.HookOnDestroy();
}
remove => HookHandler._beforeOnDestroy -= value;
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
public static event Delegates.OnDrawGizmos_BeforeArgs OnDrawGizmos
{
add
{

HookHandler._beforeOnDrawGizmos += value;
HookHandler.HookOnDrawGizmos();
}
remove => HookHandler._beforeOnDrawGizmos -= value;
}
public static event Delegates.GetGatePosition_BeforeArgs GetGatePosition
{
add
{

HookHandler._beforeGetGatePosition += value;
HookHandler.HookGetGatePosition();
}
remove => HookHandler._beforeGetGatePosition -= value;
}
public static event Delegates.SetTargetScene_BeforeArgs SetTargetScene
{
add
{

HookHandler._beforeSetTargetScene += value;
HookHandler.HookSetTargetScene();
}
remove => HookHandler._beforeSetTargetScene -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.get_TransitionPoints_AfterArgs get_TransitionPoints
{
add
{

HookHandler._afterget_TransitionPoints += value;
HookHandler.Hookget_TransitionPoints();
}
remove => HookHandler._afterget_TransitionPoints -= value;
}
public static event Delegates.Init_AfterArgs Init
{
add
{

HookHandler._afterInit += value;
HookHandler.HookInit();
}
remove => HookHandler._afterInit -= value;
}
public static event Delegates.Awake_AfterArgs Awake
{
add
{

HookHandler._afterAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._afterAwake -= value;
}
public static event Delegates.OnDestroy_AfterArgs OnDestroy
{
add
{

HookHandler._afterOnDestroy += value;
HookHandler.HookOnDestroy();
}
remove => HookHandler._afterOnDestroy -= value;
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
public static event Delegates.OnDrawGizmos_AfterArgs OnDrawGizmos
{
add
{

HookHandler._afterOnDrawGizmos += value;
HookHandler.HookOnDrawGizmos();
}
remove => HookHandler._afterOnDrawGizmos -= value;
}
public static event Delegates.GetGatePosition_AfterArgs GetGatePosition
{
add
{

HookHandler._afterGetGatePosition += value;
HookHandler.HookGetGatePosition();
}
remove => HookHandler._afterGetGatePosition -= value;
}
public static event Delegates.SetTargetScene_AfterArgs SetTargetScene
{
add
{

HookHandler._afterSetTargetScene += value;
HookHandler.HookSetTargetScene();
}
remove => HookHandler._afterSetTargetScene -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.get_TransitionPoints_WithArgs get_TransitionPoints
{
add => HookEndpointManager.Add<Delegates.get_TransitionPoints_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TransitionPoint), "get_TransitionPoints", false), value);
remove => HookEndpointManager.Remove<Delegates.get_TransitionPoints_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TransitionPoint), "get_TransitionPoints", false), value);
}
public static event On.TransitionPoint.hook_Init Init
{
add => On.TransitionPoint.Init += value;
remove => On.TransitionPoint.Init -= value;
}
public static event On.TransitionPoint.hook_Awake Awake
{
add => On.TransitionPoint.Awake += value;
remove => On.TransitionPoint.Awake -= value;
}
public static event On.TransitionPoint.hook_OnDestroy OnDestroy
{
add => On.TransitionPoint.OnDestroy += value;
remove => On.TransitionPoint.OnDestroy -= value;
}
public static event On.TransitionPoint.hook_Start Start
{
add => On.TransitionPoint.Start += value;
remove => On.TransitionPoint.Start -= value;
}
public static event On.TransitionPoint.hook_OnTriggerEnter2D OnTriggerEnter2D
{
add => On.TransitionPoint.OnTriggerEnter2D += value;
remove => On.TransitionPoint.OnTriggerEnter2D -= value;
}
public static event On.TransitionPoint.hook_OnTriggerStay2D OnTriggerStay2D
{
add => On.TransitionPoint.OnTriggerStay2D += value;
remove => On.TransitionPoint.OnTriggerStay2D -= value;
}
public static event On.TransitionPoint.hook_OnDrawGizmos OnDrawGizmos
{
add => On.TransitionPoint.OnDrawGizmos += value;
remove => On.TransitionPoint.OnDrawGizmos -= value;
}
public static event On.TransitionPoint.hook_GetGatePosition GetGatePosition
{
add => On.TransitionPoint.GetGatePosition += value;
remove => On.TransitionPoint.GetGatePosition -= value;
}
public static event On.TransitionPoint.hook_SetTargetScene SetTargetScene
{
add => On.TransitionPoint.SetTargetScene += value;
remove => On.TransitionPoint.SetTargetScene -= value;
}
}

}
