using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for GetAnimatorLayerName class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetAnimatorLayerName
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.GetAnimatorLayerName> orig, HutongGames.PlayMaker.Actions.GetAnimatorLayerName self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.GetAnimatorLayerName> orig, HutongGames.PlayMaker.Actions.GetAnimatorLayerName self)
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
internal static void HookDoGetLayerName()
{
if (!HookedList.Contains("DoGetLayerName"))
{
HookedList.Add("DoGetLayerName");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "DoGetLayerName", true), DoGetLayerName);

}
}
internal static event Delegates.DoGetLayerName_BeforeArgs _beforeDoGetLayerName;
internal static event Delegates.DoGetLayerName_AfterArgs _afterDoGetLayerName;
private static void DoGetLayerName(Action<HutongGames.PlayMaker.Actions.GetAnimatorLayerName> orig, HutongGames.PlayMaker.Actions.GetAnimatorLayerName self)
{
Delegates.Params_DoGetLayerName @params = new() 
{
self = self
};
if (_beforeDoGetLayerName != null)
{
foreach (Delegates.DoGetLayerName_BeforeArgs toInvoke in _beforeDoGetLayerName.GetInvocationList())
{
try
{
_beforeDoGetLayerName?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoGetLayerName != null)
{
foreach (Delegates.DoGetLayerName_AfterArgs toInvoke in _afterDoGetLayerName.GetInvocationList())
{
try
{
_afterDoGetLayerName.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.GetAnimatorLayerName self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.GetAnimatorLayerName> orig, HutongGames.PlayMaker.Actions.GetAnimatorLayerName self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.GetAnimatorLayerName self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.GetAnimatorLayerName> orig, HutongGames.PlayMaker.Actions.GetAnimatorLayerName self);
public sealed class Params_DoGetLayerName
{
public HutongGames.PlayMaker.Actions.GetAnimatorLayerName self;
}
public delegate void DoGetLayerName_BeforeArgs(Params_DoGetLayerName args);
public delegate void DoGetLayerName_AfterArgs(Params_DoGetLayerName args);
public delegate void DoGetLayerName_WithArgs (Action<HutongGames.PlayMaker.Actions.GetAnimatorLayerName> orig, HutongGames.PlayMaker.Actions.GetAnimatorLayerName self);
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
public static event Delegates.DoGetLayerName_BeforeArgs DoGetLayerName
{
add
{

HookHandler._beforeDoGetLayerName += value;
HookHandler.HookDoGetLayerName();
}
remove => HookHandler._beforeDoGetLayerName -= value;
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
public static event Delegates.DoGetLayerName_AfterArgs DoGetLayerName
{
add
{

HookHandler._afterDoGetLayerName += value;
HookHandler.HookDoGetLayerName();
}
remove => HookHandler._afterDoGetLayerName -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "OnEnter", true), value);
}
public static event Delegates.DoGetLayerName_WithArgs DoGetLayerName
{
add => HookEndpointManager.Add<Delegates.DoGetLayerName_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "DoGetLayerName", true), value);
remove => HookEndpointManager.Remove<Delegates.DoGetLayerName_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetAnimatorLayerName), "DoGetLayerName", true), value);
}
}

}
