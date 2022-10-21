using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for MouseBindingSourceListener class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMouseBindingSourceListener
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<InControl.MouseBindingSourceListener> orig, InControl.MouseBindingSourceListener self)
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
internal static void HookListen()
{
if (!HookedList.Contains("Listen"))
{
HookedList.Add("Listen");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "Listen", true), Listen);

}
}
internal static event Delegates.Listen_BeforeArgs _beforeListen;
internal static event Delegates.Listen_AfterArgs _afterListen;
private static InControl.BindingSource Listen(Func<InControl.MouseBindingSourceListener,  InControl.BindingListenOptions,  InControl.InputDevice, InControl.BindingSource> orig, InControl.MouseBindingSourceListener self,  InControl.BindingListenOptions listenOptions,  InControl.InputDevice device)
{
Delegates.Params_Listen @params = new() 
{
self = self
, listenOptions = listenOptions
, device = device
};
if (_beforeListen != null)
{
foreach (Delegates.Listen_BeforeArgs toInvoke in _beforeListen.GetInvocationList())
{
try
{
_beforeListen?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
listenOptions = @params.listenOptions;
device = @params.device;
var retVal = orig(self, listenOptions, device);
if (_afterListen != null)
{
foreach (Delegates.Listen_AfterArgs toInvoke in _afterListen.GetInvocationList())
{
try
{
retVal = _afterListen.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookIsPressed()
{
if (!HookedList.Contains("IsPressed"))
{
HookedList.Add("IsPressed");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "IsPressed", true), IsPressed);

}
}
internal static event Delegates.IsPressed_BeforeArgs _beforeIsPressed;
internal static event Delegates.IsPressed_AfterArgs _afterIsPressed;
private static bool IsPressed(Func<InControl.MouseBindingSourceListener,  InControl.Mouse, bool> orig, InControl.MouseBindingSourceListener self,  InControl.Mouse control)
{
Delegates.Params_IsPressed @params = new() 
{
self = self
, control = control
};
if (_beforeIsPressed != null)
{
foreach (Delegates.IsPressed_BeforeArgs toInvoke in _beforeIsPressed.GetInvocationList())
{
try
{
_beforeIsPressed?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
control = @params.control;
var retVal = orig(self, control);
if (_afterIsPressed != null)
{
foreach (Delegates.IsPressed_AfterArgs toInvoke in _afterIsPressed.GetInvocationList())
{
try
{
retVal = _afterIsPressed.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookListenForControl()
{
if (!HookedList.Contains("ListenForControl"))
{
HookedList.Add("ListenForControl");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "ListenForControl", true), ListenForControl);

}
}
internal static event Delegates.ListenForControl_BeforeArgs _beforeListenForControl;
internal static event Delegates.ListenForControl_AfterArgs _afterListenForControl;
private static InControl.Mouse ListenForControl(Func<InControl.MouseBindingSourceListener,  InControl.BindingListenOptions, InControl.Mouse> orig, InControl.MouseBindingSourceListener self,  InControl.BindingListenOptions listenOptions)
{
Delegates.Params_ListenForControl @params = new() 
{
self = self
, listenOptions = listenOptions
};
if (_beforeListenForControl != null)
{
foreach (Delegates.ListenForControl_BeforeArgs toInvoke in _beforeListenForControl.GetInvocationList())
{
try
{
_beforeListenForControl?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
listenOptions = @params.listenOptions;
var retVal = orig(self, listenOptions);
if (_afterListenForControl != null)
{
foreach (Delegates.ListenForControl_AfterArgs toInvoke in _afterListenForControl.GetInvocationList())
{
try
{
retVal = _afterListenForControl.Invoke(@params, retVal);
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
public InControl.MouseBindingSourceListener self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<InControl.MouseBindingSourceListener> orig, InControl.MouseBindingSourceListener self);
public sealed class Params_Listen
{
public InControl.MouseBindingSourceListener self;
public InControl.BindingListenOptions listenOptions;
public InControl.InputDevice device;
}
public delegate void Listen_BeforeArgs(Params_Listen args);
public delegate InControl.BindingSource Listen_AfterArgs(Params_Listen args, InControl.BindingSource ret);
public delegate InControl.BindingSource Listen_WithArgs (Func<InControl.MouseBindingSourceListener,  InControl.BindingListenOptions,  InControl.InputDevice, InControl.BindingSource> orig, InControl.MouseBindingSourceListener self,  InControl.BindingListenOptions listenOptions,  InControl.InputDevice device);
public sealed class Params_IsPressed
{
public InControl.MouseBindingSourceListener self;
public InControl.Mouse control;
}
public delegate void IsPressed_BeforeArgs(Params_IsPressed args);
public delegate bool IsPressed_AfterArgs(Params_IsPressed args, bool ret);
public delegate bool IsPressed_WithArgs (Func<InControl.MouseBindingSourceListener,  InControl.Mouse, bool> orig, InControl.MouseBindingSourceListener self,  InControl.Mouse control);
public sealed class Params_ListenForControl
{
public InControl.MouseBindingSourceListener self;
public InControl.BindingListenOptions listenOptions;
}
public delegate void ListenForControl_BeforeArgs(Params_ListenForControl args);
public delegate InControl.Mouse ListenForControl_AfterArgs(Params_ListenForControl args, InControl.Mouse ret);
public delegate InControl.Mouse ListenForControl_WithArgs (Func<InControl.MouseBindingSourceListener,  InControl.BindingListenOptions, InControl.Mouse> orig, InControl.MouseBindingSourceListener self,  InControl.BindingListenOptions listenOptions);
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
public static event Delegates.Listen_BeforeArgs Listen
{
add
{

HookHandler._beforeListen += value;
HookHandler.HookListen();
}
remove => HookHandler._beforeListen -= value;
}
public static event Delegates.IsPressed_BeforeArgs IsPressed
{
add
{

HookHandler._beforeIsPressed += value;
HookHandler.HookIsPressed();
}
remove => HookHandler._beforeIsPressed -= value;
}
public static event Delegates.ListenForControl_BeforeArgs ListenForControl
{
add
{

HookHandler._beforeListenForControl += value;
HookHandler.HookListenForControl();
}
remove => HookHandler._beforeListenForControl -= value;
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
public static event Delegates.Listen_AfterArgs Listen
{
add
{

HookHandler._afterListen += value;
HookHandler.HookListen();
}
remove => HookHandler._afterListen -= value;
}
public static event Delegates.IsPressed_AfterArgs IsPressed
{
add
{

HookHandler._afterIsPressed += value;
HookHandler.HookIsPressed();
}
remove => HookHandler._afterIsPressed -= value;
}
public static event Delegates.ListenForControl_AfterArgs ListenForControl
{
add
{

HookHandler._afterListenForControl += value;
HookHandler.HookListenForControl();
}
remove => HookHandler._afterListenForControl -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "Reset", true), value);
}
public static event Delegates.Listen_WithArgs Listen
{
add => HookEndpointManager.Add<Delegates.Listen_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "Listen", true), value);
remove => HookEndpointManager.Remove<Delegates.Listen_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "Listen", true), value);
}
public static event Delegates.IsPressed_WithArgs IsPressed
{
add => HookEndpointManager.Add<Delegates.IsPressed_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "IsPressed", true), value);
remove => HookEndpointManager.Remove<Delegates.IsPressed_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "IsPressed", true), value);
}
public static event Delegates.ListenForControl_WithArgs ListenForControl
{
add => HookEndpointManager.Add<Delegates.ListenForControl_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "ListenForControl", true), value);
remove => HookEndpointManager.Remove<Delegates.ListenForControl_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.MouseBindingSourceListener), "ListenForControl", true), value);
}
}

}
