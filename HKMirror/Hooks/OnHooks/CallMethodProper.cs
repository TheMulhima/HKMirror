using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for CallMethodProper class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCallMethodProper
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnEnter()
{
if (!HookedList.Contains("OnEnter"))
{
HookedList.Add("OnEnter");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.CallMethodProper> orig, HutongGames.PlayMaker.Actions.CallMethodProper self)
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
internal static void HookDoMethodCall()
{
if (!HookedList.Contains("DoMethodCall"))
{
HookedList.Add("DoMethodCall");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "DoMethodCall", true), DoMethodCall);

}
}
internal static event Delegates.DoMethodCall_BeforeArgs _beforeDoMethodCall;
internal static event Delegates.DoMethodCall_AfterArgs _afterDoMethodCall;
private static void DoMethodCall(Action<HutongGames.PlayMaker.Actions.CallMethodProper> orig, HutongGames.PlayMaker.Actions.CallMethodProper self)
{
Delegates.Params_DoMethodCall @params = new() 
{
self = self
};
if (_beforeDoMethodCall != null)
{
foreach (Delegates.DoMethodCall_BeforeArgs toInvoke in _beforeDoMethodCall.GetInvocationList())
{
try
{
_beforeDoMethodCall?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoMethodCall != null)
{
foreach (Delegates.DoMethodCall_AfterArgs toInvoke in _afterDoMethodCall.GetInvocationList())
{
try
{
_afterDoMethodCall.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookDoCache()
{
if (!HookedList.Contains("DoCache"))
{
HookedList.Add("DoCache");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "DoCache", true), DoCache);

}
}
internal static event Delegates.DoCache_BeforeArgs _beforeDoCache;
internal static event Delegates.DoCache_AfterArgs _afterDoCache;
private static bool DoCache(Func<HutongGames.PlayMaker.Actions.CallMethodProper, bool> orig, HutongGames.PlayMaker.Actions.CallMethodProper self)
{
Delegates.Params_DoCache @params = new() 
{
self = self
};
if (_beforeDoCache != null)
{
foreach (Delegates.DoCache_BeforeArgs toInvoke in _beforeDoCache.GetInvocationList())
{
try
{
_beforeDoCache?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterDoCache != null)
{
foreach (Delegates.DoCache_AfterArgs toInvoke in _afterDoCache.GetInvocationList())
{
try
{
retVal = _afterDoCache.Invoke(@params, retVal);
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
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.CallMethodProper self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.CallMethodProper> orig, HutongGames.PlayMaker.Actions.CallMethodProper self);
public sealed class Params_DoMethodCall
{
public HutongGames.PlayMaker.Actions.CallMethodProper self;
}
public delegate void DoMethodCall_BeforeArgs(Params_DoMethodCall args);
public delegate void DoMethodCall_AfterArgs(Params_DoMethodCall args);
public delegate void DoMethodCall_WithArgs (Action<HutongGames.PlayMaker.Actions.CallMethodProper> orig, HutongGames.PlayMaker.Actions.CallMethodProper self);
public sealed class Params_DoCache
{
public HutongGames.PlayMaker.Actions.CallMethodProper self;
}
public delegate void DoCache_BeforeArgs(Params_DoCache args);
public delegate bool DoCache_AfterArgs(Params_DoCache args, bool ret);
public delegate bool DoCache_WithArgs (Func<HutongGames.PlayMaker.Actions.CallMethodProper, bool> orig, HutongGames.PlayMaker.Actions.CallMethodProper self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnEnter_BeforeArgs OnEnter
{
add
{

HookHandler._beforeOnEnter += value;
HookHandler.HookOnEnter();
}
remove => HookHandler._beforeOnEnter -= value;
}
public static event Delegates.DoMethodCall_BeforeArgs DoMethodCall
{
add
{

HookHandler._beforeDoMethodCall += value;
HookHandler.HookDoMethodCall();
}
remove => HookHandler._beforeDoMethodCall -= value;
}
public static event Delegates.DoCache_BeforeArgs DoCache
{
add
{

HookHandler._beforeDoCache += value;
HookHandler.HookDoCache();
}
remove => HookHandler._beforeDoCache -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnEnter_AfterArgs OnEnter
{
add
{

HookHandler._afterOnEnter += value;
HookHandler.HookOnEnter();
}
remove => HookHandler._afterOnEnter -= value;
}
public static event Delegates.DoMethodCall_AfterArgs DoMethodCall
{
add
{

HookHandler._afterDoMethodCall += value;
HookHandler.HookDoMethodCall();
}
remove => HookHandler._afterDoMethodCall -= value;
}
public static event Delegates.DoCache_AfterArgs DoCache
{
add
{

HookHandler._afterDoCache += value;
HookHandler.HookDoCache();
}
remove => HookHandler._afterDoCache -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "OnEnter", true), value);
}
public static event Delegates.DoMethodCall_WithArgs DoMethodCall
{
add => HookEndpointManager.Add<Delegates.DoMethodCall_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "DoMethodCall", true), value);
remove => HookEndpointManager.Remove<Delegates.DoMethodCall_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "DoMethodCall", true), value);
}
public static event Delegates.DoCache_WithArgs DoCache
{
add => HookEndpointManager.Add<Delegates.DoCache_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "DoCache", true), value);
remove => HookEndpointManager.Remove<Delegates.DoCache_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.CallMethodProper), "DoCache", true), value);
}
}

}
