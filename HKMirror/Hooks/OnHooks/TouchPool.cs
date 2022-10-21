using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for TouchPool class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTouchPool
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookFindOrCreateTouch()
{
if (!HookedList.Contains("FindOrCreateTouch"))
{
HookedList.Add("FindOrCreateTouch");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FindOrCreateTouch", true), FindOrCreateTouch);

}
}
internal static event Delegates.FindOrCreateTouch_BeforeArgs _beforeFindOrCreateTouch;
internal static event Delegates.FindOrCreateTouch_AfterArgs _afterFindOrCreateTouch;
private static InControl.Touch FindOrCreateTouch(Func<InControl.TouchPool,  int, InControl.Touch> orig, InControl.TouchPool self,  int fingerId)
{
Delegates.Params_FindOrCreateTouch @params = new() 
{
self = self
, fingerId = fingerId
};
if (_beforeFindOrCreateTouch != null)
{
foreach (Delegates.FindOrCreateTouch_BeforeArgs toInvoke in _beforeFindOrCreateTouch.GetInvocationList())
{
try
{
_beforeFindOrCreateTouch?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
fingerId = @params.fingerId;
var retVal = orig(self, fingerId);
if (_afterFindOrCreateTouch != null)
{
foreach (Delegates.FindOrCreateTouch_AfterArgs toInvoke in _afterFindOrCreateTouch.GetInvocationList())
{
try
{
retVal = _afterFindOrCreateTouch.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookFindTouch()
{
if (!HookedList.Contains("FindTouch"))
{
HookedList.Add("FindTouch");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FindTouch", true), FindTouch);

}
}
internal static event Delegates.FindTouch_BeforeArgs _beforeFindTouch;
internal static event Delegates.FindTouch_AfterArgs _afterFindTouch;
private static InControl.Touch FindTouch(Func<InControl.TouchPool,  int, InControl.Touch> orig, InControl.TouchPool self,  int fingerId)
{
Delegates.Params_FindTouch @params = new() 
{
self = self
, fingerId = fingerId
};
if (_beforeFindTouch != null)
{
foreach (Delegates.FindTouch_BeforeArgs toInvoke in _beforeFindTouch.GetInvocationList())
{
try
{
_beforeFindTouch?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
fingerId = @params.fingerId;
var retVal = orig(self, fingerId);
if (_afterFindTouch != null)
{
foreach (Delegates.FindTouch_AfterArgs toInvoke in _afterFindTouch.GetInvocationList())
{
try
{
retVal = _afterFindTouch.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookNewTouch()
{
if (!HookedList.Contains("NewTouch"))
{
HookedList.Add("NewTouch");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "NewTouch", true), NewTouch);

}
}
internal static event Delegates.NewTouch_BeforeArgs _beforeNewTouch;
internal static event Delegates.NewTouch_AfterArgs _afterNewTouch;
private static InControl.Touch NewTouch(Func<InControl.TouchPool, InControl.Touch> orig, InControl.TouchPool self)
{
Delegates.Params_NewTouch @params = new() 
{
self = self
};
if (_beforeNewTouch != null)
{
foreach (Delegates.NewTouch_BeforeArgs toInvoke in _beforeNewTouch.GetInvocationList())
{
try
{
_beforeNewTouch?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterNewTouch != null)
{
foreach (Delegates.NewTouch_AfterArgs toInvoke in _afterNewTouch.GetInvocationList())
{
try
{
retVal = _afterNewTouch.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookFreeTouch()
{
if (!HookedList.Contains("FreeTouch"))
{
HookedList.Add("FreeTouch");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FreeTouch", true), FreeTouch);

}
}
internal static event Delegates.FreeTouch_BeforeArgs _beforeFreeTouch;
internal static event Delegates.FreeTouch_AfterArgs _afterFreeTouch;
private static void FreeTouch(Action<InControl.TouchPool,  InControl.Touch> orig, InControl.TouchPool self,  InControl.Touch touch)
{
Delegates.Params_FreeTouch @params = new() 
{
self = self
, touch = touch
};
if (_beforeFreeTouch != null)
{
foreach (Delegates.FreeTouch_BeforeArgs toInvoke in _beforeFreeTouch.GetInvocationList())
{
try
{
_beforeFreeTouch?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
touch = @params.touch;
orig(self, touch);
if (_afterFreeTouch != null)
{
foreach (Delegates.FreeTouch_AfterArgs toInvoke in _afterFreeTouch.GetInvocationList())
{
try
{
_afterFreeTouch.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookFreeEndedTouches()
{
if (!HookedList.Contains("FreeEndedTouches"))
{
HookedList.Add("FreeEndedTouches");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FreeEndedTouches", true), FreeEndedTouches);

}
}
internal static event Delegates.FreeEndedTouches_BeforeArgs _beforeFreeEndedTouches;
internal static event Delegates.FreeEndedTouches_AfterArgs _afterFreeEndedTouches;
private static void FreeEndedTouches(Action<InControl.TouchPool> orig, InControl.TouchPool self)
{
Delegates.Params_FreeEndedTouches @params = new() 
{
self = self
};
if (_beforeFreeEndedTouches != null)
{
foreach (Delegates.FreeEndedTouches_BeforeArgs toInvoke in _beforeFreeEndedTouches.GetInvocationList())
{
try
{
_beforeFreeEndedTouches?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterFreeEndedTouches != null)
{
foreach (Delegates.FreeEndedTouches_AfterArgs toInvoke in _afterFreeEndedTouches.GetInvocationList())
{
try
{
_afterFreeEndedTouches.Invoke(@params);
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
public sealed class Params_FindOrCreateTouch
{
public InControl.TouchPool self;
public int fingerId;
}
public delegate void FindOrCreateTouch_BeforeArgs(Params_FindOrCreateTouch args);
public delegate InControl.Touch FindOrCreateTouch_AfterArgs(Params_FindOrCreateTouch args, InControl.Touch ret);
public delegate InControl.Touch FindOrCreateTouch_WithArgs (Func<InControl.TouchPool,  int, InControl.Touch> orig, InControl.TouchPool self,  int fingerId);
public sealed class Params_FindTouch
{
public InControl.TouchPool self;
public int fingerId;
}
public delegate void FindTouch_BeforeArgs(Params_FindTouch args);
public delegate InControl.Touch FindTouch_AfterArgs(Params_FindTouch args, InControl.Touch ret);
public delegate InControl.Touch FindTouch_WithArgs (Func<InControl.TouchPool,  int, InControl.Touch> orig, InControl.TouchPool self,  int fingerId);
public sealed class Params_NewTouch
{
public InControl.TouchPool self;
}
public delegate void NewTouch_BeforeArgs(Params_NewTouch args);
public delegate InControl.Touch NewTouch_AfterArgs(Params_NewTouch args, InControl.Touch ret);
public delegate InControl.Touch NewTouch_WithArgs (Func<InControl.TouchPool, InControl.Touch> orig, InControl.TouchPool self);
public sealed class Params_FreeTouch
{
public InControl.TouchPool self;
public InControl.Touch touch;
}
public delegate void FreeTouch_BeforeArgs(Params_FreeTouch args);
public delegate void FreeTouch_AfterArgs(Params_FreeTouch args);
public delegate void FreeTouch_WithArgs (Action<InControl.TouchPool,  InControl.Touch> orig, InControl.TouchPool self,  InControl.Touch touch);
public sealed class Params_FreeEndedTouches
{
public InControl.TouchPool self;
}
public delegate void FreeEndedTouches_BeforeArgs(Params_FreeEndedTouches args);
public delegate void FreeEndedTouches_AfterArgs(Params_FreeEndedTouches args);
public delegate void FreeEndedTouches_WithArgs (Action<InControl.TouchPool> orig, InControl.TouchPool self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.FindOrCreateTouch_BeforeArgs FindOrCreateTouch
{
add
{

HookHandler._beforeFindOrCreateTouch += value;
HookHandler.HookFindOrCreateTouch();
}
remove => HookHandler._beforeFindOrCreateTouch -= value;
}
public static event Delegates.FindTouch_BeforeArgs FindTouch
{
add
{

HookHandler._beforeFindTouch += value;
HookHandler.HookFindTouch();
}
remove => HookHandler._beforeFindTouch -= value;
}
public static event Delegates.NewTouch_BeforeArgs NewTouch
{
add
{

HookHandler._beforeNewTouch += value;
HookHandler.HookNewTouch();
}
remove => HookHandler._beforeNewTouch -= value;
}
public static event Delegates.FreeTouch_BeforeArgs FreeTouch
{
add
{

HookHandler._beforeFreeTouch += value;
HookHandler.HookFreeTouch();
}
remove => HookHandler._beforeFreeTouch -= value;
}
public static event Delegates.FreeEndedTouches_BeforeArgs FreeEndedTouches
{
add
{

HookHandler._beforeFreeEndedTouches += value;
HookHandler.HookFreeEndedTouches();
}
remove => HookHandler._beforeFreeEndedTouches -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.FindOrCreateTouch_AfterArgs FindOrCreateTouch
{
add
{

HookHandler._afterFindOrCreateTouch += value;
HookHandler.HookFindOrCreateTouch();
}
remove => HookHandler._afterFindOrCreateTouch -= value;
}
public static event Delegates.FindTouch_AfterArgs FindTouch
{
add
{

HookHandler._afterFindTouch += value;
HookHandler.HookFindTouch();
}
remove => HookHandler._afterFindTouch -= value;
}
public static event Delegates.NewTouch_AfterArgs NewTouch
{
add
{

HookHandler._afterNewTouch += value;
HookHandler.HookNewTouch();
}
remove => HookHandler._afterNewTouch -= value;
}
public static event Delegates.FreeTouch_AfterArgs FreeTouch
{
add
{

HookHandler._afterFreeTouch += value;
HookHandler.HookFreeTouch();
}
remove => HookHandler._afterFreeTouch -= value;
}
public static event Delegates.FreeEndedTouches_AfterArgs FreeEndedTouches
{
add
{

HookHandler._afterFreeEndedTouches += value;
HookHandler.HookFreeEndedTouches();
}
remove => HookHandler._afterFreeEndedTouches -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.FindOrCreateTouch_WithArgs FindOrCreateTouch
{
add => HookEndpointManager.Add<Delegates.FindOrCreateTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FindOrCreateTouch", true), value);
remove => HookEndpointManager.Remove<Delegates.FindOrCreateTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FindOrCreateTouch", true), value);
}
public static event Delegates.FindTouch_WithArgs FindTouch
{
add => HookEndpointManager.Add<Delegates.FindTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FindTouch", true), value);
remove => HookEndpointManager.Remove<Delegates.FindTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FindTouch", true), value);
}
public static event Delegates.NewTouch_WithArgs NewTouch
{
add => HookEndpointManager.Add<Delegates.NewTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "NewTouch", true), value);
remove => HookEndpointManager.Remove<Delegates.NewTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "NewTouch", true), value);
}
public static event Delegates.FreeTouch_WithArgs FreeTouch
{
add => HookEndpointManager.Add<Delegates.FreeTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FreeTouch", true), value);
remove => HookEndpointManager.Remove<Delegates.FreeTouch_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FreeTouch", true), value);
}
public static event Delegates.FreeEndedTouches_WithArgs FreeEndedTouches
{
add => HookEndpointManager.Add<Delegates.FreeEndedTouches_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FreeEndedTouches", true), value);
remove => HookEndpointManager.Remove<Delegates.FreeEndedTouches_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.TouchPool), "FreeEndedTouches", true), value);
}
}

}
