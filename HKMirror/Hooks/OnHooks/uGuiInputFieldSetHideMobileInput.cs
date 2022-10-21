using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for uGuiInputFieldSetHideMobileInput class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnuGuiInputFieldSetHideMobileInput
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self)
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
internal static void HookDoSetValue()
{
if (!HookedList.Contains("DoSetValue"))
{
HookedList.Add("DoSetValue");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "DoSetValue", true), DoSetValue);

}
}
internal static event Delegates.DoSetValue_BeforeArgs _beforeDoSetValue;
internal static event Delegates.DoSetValue_AfterArgs _afterDoSetValue;
private static void DoSetValue(Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self)
{
Delegates.Params_DoSetValue @params = new() 
{
self = self
};
if (_beforeDoSetValue != null)
{
foreach (Delegates.DoSetValue_BeforeArgs toInvoke in _beforeDoSetValue.GetInvocationList())
{
try
{
_beforeDoSetValue?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoSetValue != null)
{
foreach (Delegates.DoSetValue_AfterArgs toInvoke in _afterDoSetValue.GetInvocationList())
{
try
{
_afterDoSetValue.Invoke(@params);
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "OnExit", true), OnExit);

}
}
internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
internal static event Delegates.OnExit_AfterArgs _afterOnExit;
private static void OnExit(Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self)
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
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_Reset
{
public HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self);
public sealed class Params_DoSetValue
{
public HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self;
}
public delegate void DoSetValue_BeforeArgs(Params_DoSetValue args);
public delegate void DoSetValue_AfterArgs(Params_DoSetValue args);
public delegate void DoSetValue_WithArgs (Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self);
public sealed class Params_OnExit
{
public HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self;
}
public delegate void OnExit_BeforeArgs(Params_OnExit args);
public delegate void OnExit_AfterArgs(Params_OnExit args);
public delegate void OnExit_WithArgs (Action<HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput> orig, HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput self);
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
public static event Delegates.DoSetValue_BeforeArgs DoSetValue
{
add
{

HookHandler._beforeDoSetValue += value;
HookHandler.HookDoSetValue();
}
remove => HookHandler._beforeDoSetValue -= value;
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
public static event Delegates.DoSetValue_AfterArgs DoSetValue
{
add
{

HookHandler._afterDoSetValue += value;
HookHandler.HookDoSetValue();
}
remove => HookHandler._afterDoSetValue -= value;
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
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "OnEnter", true), value);
}
public static event Delegates.DoSetValue_WithArgs DoSetValue
{
add => HookEndpointManager.Add<Delegates.DoSetValue_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "DoSetValue", true), value);
remove => HookEndpointManager.Remove<Delegates.DoSetValue_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "DoSetValue", true), value);
}
public static event Delegates.OnExit_WithArgs OnExit
{
add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "OnExit", true), value);
remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.uGuiInputFieldSetHideMobileInput), "OnExit", true), value);
}
}

}
