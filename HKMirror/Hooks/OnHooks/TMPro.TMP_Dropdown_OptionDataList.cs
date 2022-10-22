using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for TMPro.TMP_Dropdown_OptionDataList class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTMPro_TMP_Dropdown_OptionDataList
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hookget_options()
{
if (!HookedList.Contains("get_options"))
{
HookedList.Add("get_options");
new Hook(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "get_options", true), get_options);

}
}
internal static event Delegates.get_options_BeforeArgs _beforeget_options;
internal static event Delegates.get_options_AfterArgs _afterget_options;
private static System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options(Func<TMPro.TMP_Dropdown.OptionDataList, System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> orig, TMPro.TMP_Dropdown.OptionDataList self)
{
Delegates.Params_get_options @params = new() 
{
self = self
};
if (_beforeget_options != null)
{
foreach (Delegates.get_options_BeforeArgs toInvoke in _beforeget_options.GetInvocationList())
{
try
{
_beforeget_options?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_options != null)
{
foreach (Delegates.get_options_AfterArgs toInvoke in _afterget_options.GetInvocationList())
{
try
{
retVal = _afterget_options.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_options()
{
if (!HookedList.Contains("set_options"))
{
HookedList.Add("set_options");
new Hook(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "set_options", true), set_options);

}
}
internal static event Delegates.set_options_BeforeArgs _beforeset_options;
internal static event Delegates.set_options_AfterArgs _afterset_options;
private static void set_options(Action<TMPro.TMP_Dropdown.OptionDataList,  System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> orig, TMPro.TMP_Dropdown.OptionDataList self,  System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value)
{
Delegates.Params_set_options @params = new() 
{
self = self
, value = value
};
if (_beforeset_options != null)
{
foreach (Delegates.set_options_BeforeArgs toInvoke in _beforeset_options.GetInvocationList())
{
try
{
_beforeset_options?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_options != null)
{
foreach (Delegates.set_options_AfterArgs toInvoke in _afterset_options.GetInvocationList())
{
try
{
_afterset_options.Invoke(@params);
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
public sealed class Params_get_options
{
public TMPro.TMP_Dropdown.OptionDataList self;
}
public delegate void get_options_BeforeArgs(Params_get_options args);
public delegate System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options_AfterArgs(Params_get_options args, System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> ret);
public delegate System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options_WithArgs (Func<TMPro.TMP_Dropdown.OptionDataList, System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> orig, TMPro.TMP_Dropdown.OptionDataList self);
public sealed class Params_set_options
{
public TMPro.TMP_Dropdown.OptionDataList self;
public System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value;
}
public delegate void set_options_BeforeArgs(Params_set_options args);
public delegate void set_options_AfterArgs(Params_set_options args);
public delegate void set_options_WithArgs (Action<TMPro.TMP_Dropdown.OptionDataList,  System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>> orig, TMPro.TMP_Dropdown.OptionDataList self,  System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.get_options_BeforeArgs get_options
{
add
{

HookHandler._beforeget_options += value;
HookHandler.Hookget_options();
}
remove => HookHandler._beforeget_options -= value;
}
public static event Delegates.set_options_BeforeArgs set_options
{
add
{

HookHandler._beforeset_options += value;
HookHandler.Hookset_options();
}
remove => HookHandler._beforeset_options -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.get_options_AfterArgs get_options
{
add
{

HookHandler._afterget_options += value;
HookHandler.Hookget_options();
}
remove => HookHandler._afterget_options -= value;
}
public static event Delegates.set_options_AfterArgs set_options
{
add
{

HookHandler._afterset_options += value;
HookHandler.Hookset_options();
}
remove => HookHandler._afterset_options -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.get_options_WithArgs get_options
{
add => HookEndpointManager.Add<Delegates.get_options_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "get_options", true), value);
remove => HookEndpointManager.Remove<Delegates.get_options_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "get_options", true), value);
}
public static event Delegates.set_options_WithArgs set_options
{
add => HookEndpointManager.Add<Delegates.set_options_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "set_options", true), value);
remove => HookEndpointManager.Remove<Delegates.set_options_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "set_options", true), value);
}
}

}
