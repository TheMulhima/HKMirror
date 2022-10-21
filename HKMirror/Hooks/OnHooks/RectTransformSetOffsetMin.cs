using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for RectTransformSetOffsetMin class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnRectTransformSetOffsetMin
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "OnActionUpdate", true), OnActionUpdate);

}
}
internal static event Delegates.OnActionUpdate_BeforeArgs _beforeOnActionUpdate;
internal static event Delegates.OnActionUpdate_AfterArgs _afterOnActionUpdate;
private static void OnActionUpdate(Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self)
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
internal static void HookDoSetOffsetMin()
{
if (!HookedList.Contains("DoSetOffsetMin"))
{
HookedList.Add("DoSetOffsetMin");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "DoSetOffsetMin", true), DoSetOffsetMin);

}
}
internal static event Delegates.DoSetOffsetMin_BeforeArgs _beforeDoSetOffsetMin;
internal static event Delegates.DoSetOffsetMin_AfterArgs _afterDoSetOffsetMin;
private static void DoSetOffsetMin(Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self)
{
Delegates.Params_DoSetOffsetMin @params = new() 
{
self = self
};
if (_beforeDoSetOffsetMin != null)
{
foreach (Delegates.DoSetOffsetMin_BeforeArgs toInvoke in _beforeDoSetOffsetMin.GetInvocationList())
{
try
{
_beforeDoSetOffsetMin?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoSetOffsetMin != null)
{
foreach (Delegates.DoSetOffsetMin_AfterArgs toInvoke in _afterDoSetOffsetMin.GetInvocationList())
{
try
{
_afterDoSetOffsetMin.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self);
public sealed class Params_OnActionUpdate
{
public HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self;
}
public delegate void OnActionUpdate_BeforeArgs(Params_OnActionUpdate args);
public delegate void OnActionUpdate_AfterArgs(Params_OnActionUpdate args);
public delegate void OnActionUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self);
public sealed class Params_DoSetOffsetMin
{
public HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self;
}
public delegate void DoSetOffsetMin_BeforeArgs(Params_DoSetOffsetMin args);
public delegate void DoSetOffsetMin_AfterArgs(Params_DoSetOffsetMin args);
public delegate void DoSetOffsetMin_WithArgs (Action<HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin> orig, HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin self);
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
public static event Delegates.DoSetOffsetMin_BeforeArgs DoSetOffsetMin
{
add
{

HookHandler._beforeDoSetOffsetMin += value;
HookHandler.HookDoSetOffsetMin();
}
remove => HookHandler._beforeDoSetOffsetMin -= value;
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
public static event Delegates.DoSetOffsetMin_AfterArgs DoSetOffsetMin
{
add
{

HookHandler._afterDoSetOffsetMin += value;
HookHandler.HookDoSetOffsetMin();
}
remove => HookHandler._afterDoSetOffsetMin -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "OnEnter", true), value);
}
public static event Delegates.OnActionUpdate_WithArgs OnActionUpdate
{
add => HookEndpointManager.Add<Delegates.OnActionUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "OnActionUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnActionUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "OnActionUpdate", true), value);
}
public static event Delegates.DoSetOffsetMin_WithArgs DoSetOffsetMin
{
add => HookEndpointManager.Add<Delegates.DoSetOffsetMin_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "DoSetOffsetMin", true), value);
remove => HookEndpointManager.Remove<Delegates.DoSetOffsetMin_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.RectTransformSetOffsetMin), "DoSetOffsetMin", true), value);
}
}

}
