using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for FloatCompare class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFloatCompare
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self)
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
internal static void HookOnUpdate()
{
if (!HookedList.Contains("OnUpdate"))
{
HookedList.Add("OnUpdate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "OnUpdate", true), OnUpdate);

}
}
internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;
private static void OnUpdate(Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self)
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
internal static void HookDoCompare()
{
if (!HookedList.Contains("DoCompare"))
{
HookedList.Add("DoCompare");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "DoCompare", true), DoCompare);

}
}
internal static event Delegates.DoCompare_BeforeArgs _beforeDoCompare;
internal static event Delegates.DoCompare_AfterArgs _afterDoCompare;
private static void DoCompare(Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self)
{
Delegates.Params_DoCompare @params = new() 
{
self = self
};
if (_beforeDoCompare != null)
{
foreach (Delegates.DoCompare_BeforeArgs toInvoke in _beforeDoCompare.GetInvocationList())
{
try
{
_beforeDoCompare?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoCompare != null)
{
foreach (Delegates.DoCompare_AfterArgs toInvoke in _afterDoCompare.GetInvocationList())
{
try
{
_afterDoCompare.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookErrorCheck()
{
if (!HookedList.Contains("ErrorCheck"))
{
HookedList.Add("ErrorCheck");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "ErrorCheck", true), ErrorCheck);

}
}
internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
internal static event Delegates.ErrorCheck_AfterArgs _afterErrorCheck;
private static string ErrorCheck(Func<HutongGames.PlayMaker.Actions.FloatCompare, string> orig, HutongGames.PlayMaker.Actions.FloatCompare self)
{
Delegates.Params_ErrorCheck @params = new() 
{
self = self
};
if (_beforeErrorCheck != null)
{
foreach (Delegates.ErrorCheck_BeforeArgs toInvoke in _beforeErrorCheck.GetInvocationList())
{
try
{
_beforeErrorCheck?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterErrorCheck != null)
{
foreach (Delegates.ErrorCheck_AfterArgs toInvoke in _afterErrorCheck.GetInvocationList())
{
try
{
retVal = _afterErrorCheck.Invoke(@params, retVal);
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
public sealed class Params_Reset
{
public HutongGames.PlayMaker.Actions.FloatCompare self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.FloatCompare self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self);
public sealed class Params_OnUpdate
{
public HutongGames.PlayMaker.Actions.FloatCompare self;
}
public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);
public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);
public delegate void OnUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self);
public sealed class Params_DoCompare
{
public HutongGames.PlayMaker.Actions.FloatCompare self;
}
public delegate void DoCompare_BeforeArgs(Params_DoCompare args);
public delegate void DoCompare_AfterArgs(Params_DoCompare args);
public delegate void DoCompare_WithArgs (Action<HutongGames.PlayMaker.Actions.FloatCompare> orig, HutongGames.PlayMaker.Actions.FloatCompare self);
public sealed class Params_ErrorCheck
{
public HutongGames.PlayMaker.Actions.FloatCompare self;
}
public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);
public delegate string ErrorCheck_AfterArgs(Params_ErrorCheck args, string ret);
public delegate string ErrorCheck_WithArgs (Func<HutongGames.PlayMaker.Actions.FloatCompare, string> orig, HutongGames.PlayMaker.Actions.FloatCompare self);
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
public static event Delegates.OnUpdate_BeforeArgs OnUpdate
{
add
{

HookHandler._beforeOnUpdate += value;
HookHandler.HookOnUpdate();
}
remove => HookHandler._beforeOnUpdate -= value;
}
public static event Delegates.DoCompare_BeforeArgs DoCompare
{
add
{

HookHandler._beforeDoCompare += value;
HookHandler.HookDoCompare();
}
remove => HookHandler._beforeDoCompare -= value;
}
public static event Delegates.ErrorCheck_BeforeArgs ErrorCheck
{
add
{

HookHandler._beforeErrorCheck += value;
HookHandler.HookErrorCheck();
}
remove => HookHandler._beforeErrorCheck -= value;
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
public static event Delegates.OnUpdate_AfterArgs OnUpdate
{
add
{

HookHandler._afterOnUpdate += value;
HookHandler.HookOnUpdate();
}
remove => HookHandler._afterOnUpdate -= value;
}
public static event Delegates.DoCompare_AfterArgs DoCompare
{
add
{

HookHandler._afterDoCompare += value;
HookHandler.HookDoCompare();
}
remove => HookHandler._afterDoCompare -= value;
}
public static event Delegates.ErrorCheck_AfterArgs ErrorCheck
{
add
{

HookHandler._afterErrorCheck += value;
HookHandler.HookErrorCheck();
}
remove => HookHandler._afterErrorCheck -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "OnEnter", true), value);
}
public static event Delegates.OnUpdate_WithArgs OnUpdate
{
add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "OnUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "OnUpdate", true), value);
}
public static event Delegates.DoCompare_WithArgs DoCompare
{
add => HookEndpointManager.Add<Delegates.DoCompare_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "DoCompare", true), value);
remove => HookEndpointManager.Remove<Delegates.DoCompare_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "DoCompare", true), value);
}
public static event Delegates.ErrorCheck_WithArgs ErrorCheck
{
add => HookEndpointManager.Add<Delegates.ErrorCheck_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "ErrorCheck", true), value);
remove => HookEndpointManager.Remove<Delegates.ErrorCheck_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FloatCompare), "ErrorCheck", true), value);
}
}

}
