using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for AddRelativeForce2d class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAddRelativeForce2d
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self)
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
internal static void HookOnPreprocess()
{
if (!HookedList.Contains("OnPreprocess"))
{
HookedList.Add("OnPreprocess");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnPreprocess", true), OnPreprocess);

}
}
internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;
private static void OnPreprocess(Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self)
{
Delegates.Params_OnPreprocess @params = new() 
{
self = self
};
if (_beforeOnPreprocess != null)
{
foreach (Delegates.OnPreprocess_BeforeArgs toInvoke in _beforeOnPreprocess.GetInvocationList())
{
try
{
_beforeOnPreprocess?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnPreprocess != null)
{
foreach (Delegates.OnPreprocess_AfterArgs toInvoke in _afterOnPreprocess.GetInvocationList())
{
try
{
_afterOnPreprocess.Invoke(@params);
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self)
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
internal static void HookOnFixedUpdate()
{
if (!HookedList.Contains("OnFixedUpdate"))
{
HookedList.Add("OnFixedUpdate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnFixedUpdate", true), OnFixedUpdate);

}
}
internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
internal static event Delegates.OnFixedUpdate_AfterArgs _afterOnFixedUpdate;
private static void OnFixedUpdate(Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self)
{
Delegates.Params_OnFixedUpdate @params = new() 
{
self = self
};
if (_beforeOnFixedUpdate != null)
{
foreach (Delegates.OnFixedUpdate_BeforeArgs toInvoke in _beforeOnFixedUpdate.GetInvocationList())
{
try
{
_beforeOnFixedUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnFixedUpdate != null)
{
foreach (Delegates.OnFixedUpdate_AfterArgs toInvoke in _afterOnFixedUpdate.GetInvocationList())
{
try
{
_afterOnFixedUpdate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookDoAddRelativeForce()
{
if (!HookedList.Contains("DoAddRelativeForce"))
{
HookedList.Add("DoAddRelativeForce");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "DoAddRelativeForce", true), DoAddRelativeForce);

}
}
internal static event Delegates.DoAddRelativeForce_BeforeArgs _beforeDoAddRelativeForce;
internal static event Delegates.DoAddRelativeForce_AfterArgs _afterDoAddRelativeForce;
private static void DoAddRelativeForce(Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self)
{
Delegates.Params_DoAddRelativeForce @params = new() 
{
self = self
};
if (_beforeDoAddRelativeForce != null)
{
foreach (Delegates.DoAddRelativeForce_BeforeArgs toInvoke in _beforeDoAddRelativeForce.GetInvocationList())
{
try
{
_beforeDoAddRelativeForce?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoAddRelativeForce != null)
{
foreach (Delegates.DoAddRelativeForce_AfterArgs toInvoke in _afterDoAddRelativeForce.GetInvocationList())
{
try
{
_afterDoAddRelativeForce.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.AddRelativeForce2d self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self);
public sealed class Params_OnPreprocess
{
public HutongGames.PlayMaker.Actions.AddRelativeForce2d self;
}
public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);
public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);
public delegate void OnPreprocess_WithArgs (Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.AddRelativeForce2d self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self);
public sealed class Params_OnFixedUpdate
{
public HutongGames.PlayMaker.Actions.AddRelativeForce2d self;
}
public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);
public delegate void OnFixedUpdate_AfterArgs(Params_OnFixedUpdate args);
public delegate void OnFixedUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self);
public sealed class Params_DoAddRelativeForce
{
public HutongGames.PlayMaker.Actions.AddRelativeForce2d self;
}
public delegate void DoAddRelativeForce_BeforeArgs(Params_DoAddRelativeForce args);
public delegate void DoAddRelativeForce_AfterArgs(Params_DoAddRelativeForce args);
public delegate void DoAddRelativeForce_WithArgs (Action<HutongGames.PlayMaker.Actions.AddRelativeForce2d> orig, HutongGames.PlayMaker.Actions.AddRelativeForce2d self);
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
public static event Delegates.OnPreprocess_BeforeArgs OnPreprocess
{
add
{

HookHandler._beforeOnPreprocess += value;
HookHandler.HookOnPreprocess();
}
remove => HookHandler._beforeOnPreprocess -= value;
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
public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
{
add
{

HookHandler._beforeOnFixedUpdate += value;
HookHandler.HookOnFixedUpdate();
}
remove => HookHandler._beforeOnFixedUpdate -= value;
}
public static event Delegates.DoAddRelativeForce_BeforeArgs DoAddRelativeForce
{
add
{

HookHandler._beforeDoAddRelativeForce += value;
HookHandler.HookDoAddRelativeForce();
}
remove => HookHandler._beforeDoAddRelativeForce -= value;
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
public static event Delegates.OnPreprocess_AfterArgs OnPreprocess
{
add
{

HookHandler._afterOnPreprocess += value;
HookHandler.HookOnPreprocess();
}
remove => HookHandler._afterOnPreprocess -= value;
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
public static event Delegates.OnFixedUpdate_AfterArgs OnFixedUpdate
{
add
{

HookHandler._afterOnFixedUpdate += value;
HookHandler.HookOnFixedUpdate();
}
remove => HookHandler._afterOnFixedUpdate -= value;
}
public static event Delegates.DoAddRelativeForce_AfterArgs DoAddRelativeForce
{
add
{

HookHandler._afterDoAddRelativeForce += value;
HookHandler.HookDoAddRelativeForce();
}
remove => HookHandler._afterDoAddRelativeForce -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "Reset", true), value);
}
public static event Delegates.OnPreprocess_WithArgs OnPreprocess
{
add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnPreprocess", true), value);
remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnPreprocess", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnEnter", true), value);
}
public static event Delegates.OnFixedUpdate_WithArgs OnFixedUpdate
{
add => HookEndpointManager.Add<Delegates.OnFixedUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnFixedUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "OnFixedUpdate", true), value);
}
public static event Delegates.DoAddRelativeForce_WithArgs DoAddRelativeForce
{
add => HookEndpointManager.Add<Delegates.DoAddRelativeForce_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "DoAddRelativeForce", true), value);
remove => HookEndpointManager.Remove<Delegates.DoAddRelativeForce_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.AddRelativeForce2d), "DoAddRelativeForce", true), value);
}
}

}
