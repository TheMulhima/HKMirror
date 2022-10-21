using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for GetInControlDeviceInputButton class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetInControlDeviceInputButton
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "OnUpdate", true), OnUpdate);

}
}
internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;
private static void OnUpdate(Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self)
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
internal static void HookDoGetButton()
{
if (!HookedList.Contains("DoGetButton"))
{
HookedList.Add("DoGetButton");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "DoGetButton", true), DoGetButton);

}
}
internal static event Delegates.DoGetButton_BeforeArgs _beforeDoGetButton;
internal static event Delegates.DoGetButton_AfterArgs _afterDoGetButton;
private static void DoGetButton(Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self)
{
Delegates.Params_DoGetButton @params = new() 
{
self = self
};
if (_beforeDoGetButton != null)
{
foreach (Delegates.DoGetButton_BeforeArgs toInvoke in _beforeDoGetButton.GetInvocationList())
{
try
{
_beforeDoGetButton?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoGetButton != null)
{
foreach (Delegates.DoGetButton_AfterArgs toInvoke in _afterDoGetButton.GetInvocationList())
{
try
{
_afterDoGetButton.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self);
public sealed class Params_OnUpdate
{
public HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self;
}
public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);
public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);
public delegate void OnUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self);
public sealed class Params_DoGetButton
{
public HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self;
}
public delegate void DoGetButton_BeforeArgs(Params_DoGetButton args);
public delegate void DoGetButton_AfterArgs(Params_DoGetButton args);
public delegate void DoGetButton_WithArgs (Action<HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton> orig, HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton self);
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
public static event Delegates.DoGetButton_BeforeArgs DoGetButton
{
add
{

HookHandler._beforeDoGetButton += value;
HookHandler.HookDoGetButton();
}
remove => HookHandler._beforeDoGetButton -= value;
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
public static event Delegates.DoGetButton_AfterArgs DoGetButton
{
add
{

HookHandler._afterDoGetButton += value;
HookHandler.HookDoGetButton();
}
remove => HookHandler._afterDoGetButton -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "OnEnter", true), value);
}
public static event Delegates.OnUpdate_WithArgs OnUpdate
{
add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "OnUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "OnUpdate", true), value);
}
public static event Delegates.DoGetButton_WithArgs DoGetButton
{
add => HookEndpointManager.Add<Delegates.DoGetButton_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "DoGetButton", true), value);
remove => HookEndpointManager.Remove<Delegates.DoGetButton_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetInControlDeviceInputButton), "DoGetButton", true), value);
}
}

}
