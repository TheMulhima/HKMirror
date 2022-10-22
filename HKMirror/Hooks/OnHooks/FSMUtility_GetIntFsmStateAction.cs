using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for FSMUtility_GetIntFsmStateAction class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFSMUtility_GetIntFsmStateAction
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hookget_IntValue()
{
if (!HookedList.Contains("get_IntValue"))
{
HookedList.Add("get_IntValue");
new Hook(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "get_IntValue", true), get_IntValue);

}
}
internal static event Delegates.get_IntValue_BeforeArgs _beforeget_IntValue;
internal static event Delegates.get_IntValue_AfterArgs _afterget_IntValue;
private static int get_IntValue(Func<FSMUtility.GetIntFsmStateAction, int> orig, FSMUtility.GetIntFsmStateAction self)
{
Delegates.Params_get_IntValue @params = new() 
{
self = self
};
if (_beforeget_IntValue != null)
{
foreach (Delegates.get_IntValue_BeforeArgs toInvoke in _beforeget_IntValue.GetInvocationList())
{
try
{
_beforeget_IntValue?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_IntValue != null)
{
foreach (Delegates.get_IntValue_AfterArgs toInvoke in _afterget_IntValue.GetInvocationList())
{
try
{
retVal = _afterget_IntValue.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<FSMUtility.GetIntFsmStateAction> orig, FSMUtility.GetIntFsmStateAction self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<FSMUtility.GetIntFsmStateAction> orig, FSMUtility.GetIntFsmStateAction self)
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
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_get_IntValue
{
public FSMUtility.GetIntFsmStateAction self;
}
public delegate void get_IntValue_BeforeArgs(Params_get_IntValue args);
public delegate int get_IntValue_AfterArgs(Params_get_IntValue args, int ret);
public delegate int get_IntValue_WithArgs (Func<FSMUtility.GetIntFsmStateAction, int> orig, FSMUtility.GetIntFsmStateAction self);
public sealed class Params_Reset
{
public FSMUtility.GetIntFsmStateAction self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<FSMUtility.GetIntFsmStateAction> orig, FSMUtility.GetIntFsmStateAction self);
public sealed class Params_OnEnter
{
public FSMUtility.GetIntFsmStateAction self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<FSMUtility.GetIntFsmStateAction> orig, FSMUtility.GetIntFsmStateAction self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.get_IntValue_BeforeArgs get_IntValue
{
add
{

HookHandler._beforeget_IntValue += value;
HookHandler.Hookget_IntValue();
}
remove => HookHandler._beforeget_IntValue -= value;
}
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
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.get_IntValue_AfterArgs get_IntValue
{
add
{

HookHandler._afterget_IntValue += value;
HookHandler.Hookget_IntValue();
}
remove => HookHandler._afterget_IntValue -= value;
}
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
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.get_IntValue_WithArgs get_IntValue
{
add => HookEndpointManager.Add<Delegates.get_IntValue_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "get_IntValue", true), value);
remove => HookEndpointManager.Remove<Delegates.get_IntValue_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "get_IntValue", true), value);
}
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "OnEnter", true), value);
}
}

}