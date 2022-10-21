using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for ControllerProfileButton class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnControllerProfileButton
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnSelect()
{
if (!HookedList.Contains("OnSelect"))
{
HookedList.Add("OnSelect");
new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnSelect", true), OnSelect);

}
}
internal static event Delegates.OnSelect_BeforeArgs _beforeOnSelect;
internal static event Delegates.OnSelect_AfterArgs _afterOnSelect;
private static void OnSelect(Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.BaseEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.BaseEventData eventData)
{
Delegates.Params_OnSelect @params = new() 
{
self = self
, eventData = eventData
};
if (_beforeOnSelect != null)
{
foreach (Delegates.OnSelect_BeforeArgs toInvoke in _beforeOnSelect.GetInvocationList())
{
try
{
_beforeOnSelect?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
eventData = @params.eventData;
orig(self, eventData);
if (_afterOnSelect != null)
{
foreach (Delegates.OnSelect_AfterArgs toInvoke in _afterOnSelect.GetInvocationList())
{
try
{
_afterOnSelect.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnDeselect()
{
if (!HookedList.Contains("OnDeselect"))
{
HookedList.Add("OnDeselect");
new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnDeselect", true), OnDeselect);

}
}
internal static event Delegates.OnDeselect_BeforeArgs _beforeOnDeselect;
internal static event Delegates.OnDeselect_AfterArgs _afterOnDeselect;
private static void OnDeselect(Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.BaseEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.BaseEventData eventData)
{
Delegates.Params_OnDeselect @params = new() 
{
self = self
, eventData = eventData
};
if (_beforeOnDeselect != null)
{
foreach (Delegates.OnDeselect_BeforeArgs toInvoke in _beforeOnDeselect.GetInvocationList())
{
try
{
_beforeOnDeselect?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
eventData = @params.eventData;
orig(self, eventData);
if (_afterOnDeselect != null)
{
foreach (Delegates.OnDeselect_AfterArgs toInvoke in _afterOnDeselect.GetInvocationList())
{
try
{
_afterOnDeselect.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnSubmit()
{
if (!HookedList.Contains("OnSubmit"))
{
HookedList.Add("OnSubmit");
new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnSubmit", true), OnSubmit);

}
}
internal static event Delegates.OnSubmit_BeforeArgs _beforeOnSubmit;
internal static event Delegates.OnSubmit_AfterArgs _afterOnSubmit;
private static void OnSubmit(Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.BaseEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.BaseEventData eventData)
{
Delegates.Params_OnSubmit @params = new() 
{
self = self
, eventData = eventData
};
if (_beforeOnSubmit != null)
{
foreach (Delegates.OnSubmit_BeforeArgs toInvoke in _beforeOnSubmit.GetInvocationList())
{
try
{
_beforeOnSubmit?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
eventData = @params.eventData;
orig(self, eventData);
if (_afterOnSubmit != null)
{
foreach (Delegates.OnSubmit_AfterArgs toInvoke in _afterOnSubmit.GetInvocationList())
{
try
{
_afterOnSubmit.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnPointerClick()
{
if (!HookedList.Contains("OnPointerClick"))
{
HookedList.Add("OnPointerClick");
new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnPointerClick", true), OnPointerClick);

}
}
internal static event Delegates.OnPointerClick_BeforeArgs _beforeOnPointerClick;
internal static event Delegates.OnPointerClick_AfterArgs _afterOnPointerClick;
private static void OnPointerClick(Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.PointerEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.PointerEventData eventData)
{
Delegates.Params_OnPointerClick @params = new() 
{
self = self
, eventData = eventData
};
if (_beforeOnPointerClick != null)
{
foreach (Delegates.OnPointerClick_BeforeArgs toInvoke in _beforeOnPointerClick.GetInvocationList())
{
try
{
_beforeOnPointerClick?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
eventData = @params.eventData;
orig(self, eventData);
if (_afterOnPointerClick != null)
{
foreach (Delegates.OnPointerClick_AfterArgs toInvoke in _afterOnPointerClick.GetInvocationList())
{
try
{
_afterOnPointerClick.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookValidateDeselect()
{
if (!HookedList.Contains("ValidateDeselect"))
{
HookedList.Add("ValidateDeselect");
new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "ValidateDeselect", true), ValidateDeselect);

}
}
internal static event Delegates.ValidateDeselect_BeforeArgs _beforeValidateDeselect;
private static System.Collections.IEnumerator ValidateDeselect(Func<UnityEngine.UI.ControllerProfileButton, System.Collections.IEnumerator> orig, UnityEngine.UI.ControllerProfileButton self)
{
Delegates.Params_ValidateDeselect @params = new() 
{
self = self
};
if (_beforeValidateDeselect != null)
{
foreach (Delegates.ValidateDeselect_BeforeArgs toInvoke in _beforeValidateDeselect.GetInvocationList())
{
try
{
_beforeValidateDeselect?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
return orig(self);
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_OnSelect
{
public UnityEngine.UI.ControllerProfileButton self;
public UnityEngine.EventSystems.BaseEventData eventData;
}
public delegate void OnSelect_BeforeArgs(Params_OnSelect args);
public delegate void OnSelect_AfterArgs(Params_OnSelect args);
public delegate void OnSelect_WithArgs (Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.BaseEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.BaseEventData eventData);
public sealed class Params_OnDeselect
{
public UnityEngine.UI.ControllerProfileButton self;
public UnityEngine.EventSystems.BaseEventData eventData;
}
public delegate void OnDeselect_BeforeArgs(Params_OnDeselect args);
public delegate void OnDeselect_AfterArgs(Params_OnDeselect args);
public delegate void OnDeselect_WithArgs (Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.BaseEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.BaseEventData eventData);
public sealed class Params_OnSubmit
{
public UnityEngine.UI.ControllerProfileButton self;
public UnityEngine.EventSystems.BaseEventData eventData;
}
public delegate void OnSubmit_BeforeArgs(Params_OnSubmit args);
public delegate void OnSubmit_AfterArgs(Params_OnSubmit args);
public delegate void OnSubmit_WithArgs (Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.BaseEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.BaseEventData eventData);
public sealed class Params_OnPointerClick
{
public UnityEngine.UI.ControllerProfileButton self;
public UnityEngine.EventSystems.PointerEventData eventData;
}
public delegate void OnPointerClick_BeforeArgs(Params_OnPointerClick args);
public delegate void OnPointerClick_AfterArgs(Params_OnPointerClick args);
public delegate void OnPointerClick_WithArgs (Action<UnityEngine.UI.ControllerProfileButton,  UnityEngine.EventSystems.PointerEventData> orig, UnityEngine.UI.ControllerProfileButton self,  UnityEngine.EventSystems.PointerEventData eventData);
public sealed class Params_ValidateDeselect
{
public UnityEngine.UI.ControllerProfileButton self;
}
public delegate void ValidateDeselect_BeforeArgs(Params_ValidateDeselect args);
public delegate System.Collections.IEnumerator ValidateDeselect_AfterArgs(Params_ValidateDeselect args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator ValidateDeselect_WithArgs (Func<UnityEngine.UI.ControllerProfileButton, System.Collections.IEnumerator> orig, UnityEngine.UI.ControllerProfileButton self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnSelect_BeforeArgs OnSelect
{
add
{

HookHandler._beforeOnSelect += value;
HookHandler.HookOnSelect();
}
remove => HookHandler._beforeOnSelect -= value;
}
public static event Delegates.OnDeselect_BeforeArgs OnDeselect
{
add
{

HookHandler._beforeOnDeselect += value;
HookHandler.HookOnDeselect();
}
remove => HookHandler._beforeOnDeselect -= value;
}
public static event Delegates.OnSubmit_BeforeArgs OnSubmit
{
add
{

HookHandler._beforeOnSubmit += value;
HookHandler.HookOnSubmit();
}
remove => HookHandler._beforeOnSubmit -= value;
}
public static event Delegates.OnPointerClick_BeforeArgs OnPointerClick
{
add
{

HookHandler._beforeOnPointerClick += value;
HookHandler.HookOnPointerClick();
}
remove => HookHandler._beforeOnPointerClick -= value;
}
public static event Delegates.ValidateDeselect_BeforeArgs ValidateDeselect
{
add
{

HookHandler._beforeValidateDeselect += value;
HookHandler.HookValidateDeselect();
}
remove => HookHandler._beforeValidateDeselect -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnSelect_AfterArgs OnSelect
{
add
{

HookHandler._afterOnSelect += value;
HookHandler.HookOnSelect();
}
remove => HookHandler._afterOnSelect -= value;
}
public static event Delegates.OnDeselect_AfterArgs OnDeselect
{
add
{

HookHandler._afterOnDeselect += value;
HookHandler.HookOnDeselect();
}
remove => HookHandler._afterOnDeselect -= value;
}
public static event Delegates.OnSubmit_AfterArgs OnSubmit
{
add
{

HookHandler._afterOnSubmit += value;
HookHandler.HookOnSubmit();
}
remove => HookHandler._afterOnSubmit -= value;
}
public static event Delegates.OnPointerClick_AfterArgs OnPointerClick
{
add
{

HookHandler._afterOnPointerClick += value;
HookHandler.HookOnPointerClick();
}
remove => HookHandler._afterOnPointerClick -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.OnSelect_WithArgs OnSelect
{
add => HookEndpointManager.Add<Delegates.OnSelect_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnSelect", true), value);
remove => HookEndpointManager.Remove<Delegates.OnSelect_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnSelect", true), value);
}
public static event Delegates.OnDeselect_WithArgs OnDeselect
{
add => HookEndpointManager.Add<Delegates.OnDeselect_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnDeselect", true), value);
remove => HookEndpointManager.Remove<Delegates.OnDeselect_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnDeselect", true), value);
}
public static event Delegates.OnSubmit_WithArgs OnSubmit
{
add => HookEndpointManager.Add<Delegates.OnSubmit_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnSubmit", true), value);
remove => HookEndpointManager.Remove<Delegates.OnSubmit_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnSubmit", true), value);
}
public static event Delegates.OnPointerClick_WithArgs OnPointerClick
{
add => HookEndpointManager.Add<Delegates.OnPointerClick_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnPointerClick", true), value);
remove => HookEndpointManager.Remove<Delegates.OnPointerClick_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "OnPointerClick", true), value);
}
public static event Delegates.ValidateDeselect_WithArgs ValidateDeselect
{
add => HookEndpointManager.Add<Delegates.ValidateDeselect_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "ValidateDeselect", true), value);
remove => HookEndpointManager.Remove<Delegates.ValidateDeselect_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.ControllerProfileButton), "ValidateDeselect", true), value);
}
}

}
