using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for GetAnimatorCurrentTransitionInfo class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetAnimatorCurrentTransitionInfo
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self)
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
internal static void HookOnActionUpdate()
{
if (!HookedList.Contains("OnActionUpdate"))
{
HookedList.Add("OnActionUpdate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "OnActionUpdate", true), OnActionUpdate);

}
}
internal static event Delegates.OnActionUpdate_BeforeArgs _beforeOnActionUpdate;
internal static event Delegates.OnActionUpdate_AfterArgs _afterOnActionUpdate;
private static void OnActionUpdate(Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self)
{
Delegates.Params_OnActionUpdate @params = new() 
{
self = self
};
if (_beforeOnActionUpdate != null)
{
foreach (Delegates.OnActionUpdate_BeforeArgs toInvoke in _beforeOnActionUpdate.GetInvocationList())
{
try
{
_beforeOnActionUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnActionUpdate != null)
{
foreach (Delegates.OnActionUpdate_AfterArgs toInvoke in _afterOnActionUpdate.GetInvocationList())
{
try
{
_afterOnActionUpdate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookGetTransitionInfo()
{
if (!HookedList.Contains("GetTransitionInfo"))
{
HookedList.Add("GetTransitionInfo");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "GetTransitionInfo", true), GetTransitionInfo);

}
}
internal static event Delegates.GetTransitionInfo_BeforeArgs _beforeGetTransitionInfo;
internal static event Delegates.GetTransitionInfo_AfterArgs _afterGetTransitionInfo;
private static void GetTransitionInfo(Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self)
{
Delegates.Params_GetTransitionInfo @params = new() 
{
self = self
};
if (_beforeGetTransitionInfo != null)
{
foreach (Delegates.GetTransitionInfo_BeforeArgs toInvoke in _beforeGetTransitionInfo.GetInvocationList())
{
try
{
_beforeGetTransitionInfo?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterGetTransitionInfo != null)
{
foreach (Delegates.GetTransitionInfo_AfterArgs toInvoke in _afterGetTransitionInfo.GetInvocationList())
{
try
{
_afterGetTransitionInfo.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self);
public sealed class Params_OnActionUpdate
{
public HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self;
}
public delegate void OnActionUpdate_BeforeArgs(Params_OnActionUpdate args);
public delegate void OnActionUpdate_AfterArgs(Params_OnActionUpdate args);
public delegate void OnActionUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self);
public sealed class Params_GetTransitionInfo
{
public HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self;
}
public delegate void GetTransitionInfo_BeforeArgs(Params_GetTransitionInfo args);
public delegate void GetTransitionInfo_AfterArgs(Params_GetTransitionInfo args);
public delegate void GetTransitionInfo_WithArgs (Action<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo> orig, HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo self);
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
public static event Delegates.OnActionUpdate_BeforeArgs OnActionUpdate
{
add
{

HookHandler._beforeOnActionUpdate += value;
HookHandler.HookOnActionUpdate();
}
remove => HookHandler._beforeOnActionUpdate -= value;
}
public static event Delegates.GetTransitionInfo_BeforeArgs GetTransitionInfo
{
add
{

HookHandler._beforeGetTransitionInfo += value;
HookHandler.HookGetTransitionInfo();
}
remove => HookHandler._beforeGetTransitionInfo -= value;
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
public static event Delegates.OnActionUpdate_AfterArgs OnActionUpdate
{
add
{

HookHandler._afterOnActionUpdate += value;
HookHandler.HookOnActionUpdate();
}
remove => HookHandler._afterOnActionUpdate -= value;
}
public static event Delegates.GetTransitionInfo_AfterArgs GetTransitionInfo
{
add
{

HookHandler._afterGetTransitionInfo += value;
HookHandler.HookGetTransitionInfo();
}
remove => HookHandler._afterGetTransitionInfo -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "OnEnter", true), value);
}
public static event Delegates.OnActionUpdate_WithArgs OnActionUpdate
{
add => HookEndpointManager.Add<Delegates.OnActionUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "OnActionUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnActionUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "OnActionUpdate", true), value);
}
public static event Delegates.GetTransitionInfo_WithArgs GetTransitionInfo
{
add => HookEndpointManager.Add<Delegates.GetTransitionInfo_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "GetTransitionInfo", true), value);
remove => HookEndpointManager.Remove<Delegates.GetTransitionInfo_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfo), "GetTransitionInfo", true), value);
}
}

}
