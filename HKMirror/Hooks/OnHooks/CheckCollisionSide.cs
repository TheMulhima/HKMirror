using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for CheckCollisionSide class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCheckCollisionSide
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self)
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
internal static void HookOnEnter()
{
if (!HookedList.Contains("OnEnter"))
{
HookedList.Add("OnEnter");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self)
{
Delegates.Params_OnEnter @params = new() 
{
self = self
};
if (_beforeOnEnter != null)
{
foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
{
try
{
_beforeOnEnter?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnEnter != null)
{
foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
{
try
{
_afterOnEnter.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnExit()
{
if (!HookedList.Contains("OnExit"))
{
HookedList.Add("OnExit");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnExit", true), OnExit);

}
}
internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
internal static event Delegates.OnExit_AfterArgs _afterOnExit;
private static void OnExit(Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self)
{
Delegates.Params_OnExit @params = new() 
{
self = self
};
if (_beforeOnExit != null)
{
foreach (Delegates.OnExit_BeforeArgs toInvoke in _beforeOnExit.GetInvocationList())
{
try
{
_beforeOnExit?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnExit != null)
{
foreach (Delegates.OnExit_AfterArgs toInvoke in _afterOnExit.GetInvocationList())
{
try
{
_afterOnExit.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnUpdate()
{
if (!HookedList.Contains("OnUpdate"))
{
HookedList.Add("OnUpdate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnUpdate", true), OnUpdate);

}
}
internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;
private static void OnUpdate(Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self)
{
Delegates.Params_OnUpdate @params = new() 
{
self = self
};
if (_beforeOnUpdate != null)
{
foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
{
try
{
_beforeOnUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnUpdate != null)
{
foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
{
try
{
_afterOnUpdate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookDoCollisionStay2D()
{
if (!HookedList.Contains("DoCollisionStay2D"))
{
HookedList.Add("DoCollisionStay2D");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "DoCollisionStay2D", true), DoCollisionStay2D);

}
}
internal static event Delegates.DoCollisionStay2D_BeforeArgs _beforeDoCollisionStay2D;
internal static event Delegates.DoCollisionStay2D_AfterArgs _afterDoCollisionStay2D;
private static void DoCollisionStay2D(Action<HutongGames.PlayMaker.Actions.CheckCollisionSide,  UnityEngine.Collision2D> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self,  UnityEngine.Collision2D collision)
{
Delegates.Params_DoCollisionStay2D @params = new() 
{
self = self
, collision = collision
};
if (_beforeDoCollisionStay2D != null)
{
foreach (Delegates.DoCollisionStay2D_BeforeArgs toInvoke in _beforeDoCollisionStay2D.GetInvocationList())
{
try
{
_beforeDoCollisionStay2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
collision = @params.collision;
orig(self, collision);
if (_afterDoCollisionStay2D != null)
{
foreach (Delegates.DoCollisionStay2D_AfterArgs toInvoke in _afterDoCollisionStay2D.GetInvocationList())
{
try
{
_afterDoCollisionStay2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookDoCollisionExit2D()
{
if (!HookedList.Contains("DoCollisionExit2D"))
{
HookedList.Add("DoCollisionExit2D");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "DoCollisionExit2D", true), DoCollisionExit2D);

}
}
internal static event Delegates.DoCollisionExit2D_BeforeArgs _beforeDoCollisionExit2D;
internal static event Delegates.DoCollisionExit2D_AfterArgs _afterDoCollisionExit2D;
private static void DoCollisionExit2D(Action<HutongGames.PlayMaker.Actions.CheckCollisionSide,  UnityEngine.Collision2D> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self,  UnityEngine.Collision2D collision)
{
Delegates.Params_DoCollisionExit2D @params = new() 
{
self = self
, collision = collision
};
if (_beforeDoCollisionExit2D != null)
{
foreach (Delegates.DoCollisionExit2D_BeforeArgs toInvoke in _beforeDoCollisionExit2D.GetInvocationList())
{
try
{
_beforeDoCollisionExit2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
collision = @params.collision;
orig(self, collision);
if (_afterDoCollisionExit2D != null)
{
foreach (Delegates.DoCollisionExit2D_AfterArgs toInvoke in _afterDoCollisionExit2D.GetInvocationList())
{
try
{
_afterDoCollisionExit2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookCheckTouching()
{
if (!HookedList.Contains("CheckTouching"))
{
HookedList.Add("CheckTouching");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "CheckTouching", true), CheckTouching);

}
}
internal static event Delegates.CheckTouching_BeforeArgs _beforeCheckTouching;
internal static event Delegates.CheckTouching_AfterArgs _afterCheckTouching;
private static void CheckTouching(Action<HutongGames.PlayMaker.Actions.CheckCollisionSide,  UnityEngine.LayerMask> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self,  UnityEngine.LayerMask layer)
{
Delegates.Params_CheckTouching @params = new() 
{
self = self
, layer = layer
};
if (_beforeCheckTouching != null)
{
foreach (Delegates.CheckTouching_BeforeArgs toInvoke in _beforeCheckTouching.GetInvocationList())
{
try
{
_beforeCheckTouching?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
layer = @params.layer;
orig(self, layer);
if (_afterCheckTouching != null)
{
foreach (Delegates.CheckTouching_AfterArgs toInvoke in _afterCheckTouching.GetInvocationList())
{
try
{
_afterCheckTouching.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.CheckCollisionSide self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.CheckCollisionSide self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self);
public sealed class Params_OnExit
{
public HutongGames.PlayMaker.Actions.CheckCollisionSide self;
}
public delegate void OnExit_BeforeArgs(Params_OnExit args);
public delegate void OnExit_AfterArgs(Params_OnExit args);
public delegate void OnExit_WithArgs (Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self);
public sealed class Params_OnUpdate
{
public HutongGames.PlayMaker.Actions.CheckCollisionSide self;
}
public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);
public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);
public delegate void OnUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.CheckCollisionSide> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self);
public sealed class Params_DoCollisionStay2D
{
public HutongGames.PlayMaker.Actions.CheckCollisionSide self;
public UnityEngine.Collision2D collision;
}
public delegate void DoCollisionStay2D_BeforeArgs(Params_DoCollisionStay2D args);
public delegate void DoCollisionStay2D_AfterArgs(Params_DoCollisionStay2D args);
public delegate void DoCollisionStay2D_WithArgs (Action<HutongGames.PlayMaker.Actions.CheckCollisionSide,  UnityEngine.Collision2D> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self,  UnityEngine.Collision2D collision);
public sealed class Params_DoCollisionExit2D
{
public HutongGames.PlayMaker.Actions.CheckCollisionSide self;
public UnityEngine.Collision2D collision;
}
public delegate void DoCollisionExit2D_BeforeArgs(Params_DoCollisionExit2D args);
public delegate void DoCollisionExit2D_AfterArgs(Params_DoCollisionExit2D args);
public delegate void DoCollisionExit2D_WithArgs (Action<HutongGames.PlayMaker.Actions.CheckCollisionSide,  UnityEngine.Collision2D> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self,  UnityEngine.Collision2D collision);
public sealed class Params_CheckTouching
{
public HutongGames.PlayMaker.Actions.CheckCollisionSide self;
public UnityEngine.LayerMask layer;
}
public delegate void CheckTouching_BeforeArgs(Params_CheckTouching args);
public delegate void CheckTouching_AfterArgs(Params_CheckTouching args);
public delegate void CheckTouching_WithArgs (Action<HutongGames.PlayMaker.Actions.CheckCollisionSide,  UnityEngine.LayerMask> orig, HutongGames.PlayMaker.Actions.CheckCollisionSide self,  UnityEngine.LayerMask layer);
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
public static event Delegates.OnEnter_BeforeArgs OnEnter
{
add
{

HookHandler._beforeOnEnter += value;
HookHandler.HookOnEnter();
}
remove => HookHandler._beforeOnEnter -= value;
}
public static event Delegates.OnExit_BeforeArgs OnExit
{
add
{

HookHandler._beforeOnExit += value;
HookHandler.HookOnExit();
}
remove => HookHandler._beforeOnExit -= value;
}
public static event Delegates.OnUpdate_BeforeArgs OnUpdate
{
add
{

HookHandler._beforeOnUpdate += value;
HookHandler.HookOnUpdate();
}
remove => HookHandler._beforeOnUpdate -= value;
}
public static event Delegates.DoCollisionStay2D_BeforeArgs DoCollisionStay2D
{
add
{

HookHandler._beforeDoCollisionStay2D += value;
HookHandler.HookDoCollisionStay2D();
}
remove => HookHandler._beforeDoCollisionStay2D -= value;
}
public static event Delegates.DoCollisionExit2D_BeforeArgs DoCollisionExit2D
{
add
{

HookHandler._beforeDoCollisionExit2D += value;
HookHandler.HookDoCollisionExit2D();
}
remove => HookHandler._beforeDoCollisionExit2D -= value;
}
public static event Delegates.CheckTouching_BeforeArgs CheckTouching
{
add
{

HookHandler._beforeCheckTouching += value;
HookHandler.HookCheckTouching();
}
remove => HookHandler._beforeCheckTouching -= value;
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
public static event Delegates.OnEnter_AfterArgs OnEnter
{
add
{

HookHandler._afterOnEnter += value;
HookHandler.HookOnEnter();
}
remove => HookHandler._afterOnEnter -= value;
}
public static event Delegates.OnExit_AfterArgs OnExit
{
add
{

HookHandler._afterOnExit += value;
HookHandler.HookOnExit();
}
remove => HookHandler._afterOnExit -= value;
}
public static event Delegates.OnUpdate_AfterArgs OnUpdate
{
add
{

HookHandler._afterOnUpdate += value;
HookHandler.HookOnUpdate();
}
remove => HookHandler._afterOnUpdate -= value;
}
public static event Delegates.DoCollisionStay2D_AfterArgs DoCollisionStay2D
{
add
{

HookHandler._afterDoCollisionStay2D += value;
HookHandler.HookDoCollisionStay2D();
}
remove => HookHandler._afterDoCollisionStay2D -= value;
}
public static event Delegates.DoCollisionExit2D_AfterArgs DoCollisionExit2D
{
add
{

HookHandler._afterDoCollisionExit2D += value;
HookHandler.HookDoCollisionExit2D();
}
remove => HookHandler._afterDoCollisionExit2D -= value;
}
public static event Delegates.CheckTouching_AfterArgs CheckTouching
{
add
{

HookHandler._afterCheckTouching += value;
HookHandler.HookCheckTouching();
}
remove => HookHandler._afterCheckTouching -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnEnter", true), value);
}
public static event Delegates.OnExit_WithArgs OnExit
{
add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnExit", true), value);
remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnExit", true), value);
}
public static event Delegates.OnUpdate_WithArgs OnUpdate
{
add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "OnUpdate", true), value);
}
public static event Delegates.DoCollisionStay2D_WithArgs DoCollisionStay2D
{
add => HookEndpointManager.Add<Delegates.DoCollisionStay2D_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "DoCollisionStay2D", true), value);
remove => HookEndpointManager.Remove<Delegates.DoCollisionStay2D_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "DoCollisionStay2D", true), value);
}
public static event Delegates.DoCollisionExit2D_WithArgs DoCollisionExit2D
{
add => HookEndpointManager.Add<Delegates.DoCollisionExit2D_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "DoCollisionExit2D", true), value);
remove => HookEndpointManager.Remove<Delegates.DoCollisionExit2D_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "DoCollisionExit2D", true), value);
}
public static event Delegates.CheckTouching_WithArgs CheckTouching
{
add => HookEndpointManager.Add<Delegates.CheckTouching_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "CheckTouching", true), value);
remove => HookEndpointManager.Remove<Delegates.CheckTouching_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CheckCollisionSide), "CheckTouching", true), value);
}
}

}
