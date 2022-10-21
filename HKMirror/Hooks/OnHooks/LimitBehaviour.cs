using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for LimitBehaviour class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnLimitBehaviour
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnDisable()
{
if (!HookedList.Contains("OnDisable"))
{
HookedList.Add("OnDisable");
On.LimitBehaviour.OnDisable += OnDisable;

}
}
internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;
private static void OnDisable(On.LimitBehaviour.orig_OnDisable orig,LimitBehaviour self)
{
Delegates.Params_OnDisable @params = new() 
{
self = self
};
if (_beforeOnDisable != null)
{
foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
{
try
{
_beforeOnDisable?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnDisable != null)
{
foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
{
try
{
_afterOnDisable.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookAdd()
{
if (!HookedList.Contains("Add"))
{
HookedList.Add("Add");
On.LimitBehaviour.Add += Add;

}
}
internal static event Delegates.Add_BeforeArgs _beforeAdd;
internal static event Delegates.Add_AfterArgs _afterAdd;
private static void Add(On.LimitBehaviour.orig_Add orig,LimitBehaviour self)
{
Delegates.Params_Add @params = new() 
{
self = self
};
if (_beforeAdd != null)
{
foreach (Delegates.Add_BeforeArgs toInvoke in _beforeAdd.GetInvocationList())
{
try
{
_beforeAdd?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterAdd != null)
{
foreach (Delegates.Add_AfterArgs toInvoke in _afterAdd.GetInvocationList())
{
try
{
_afterAdd.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookRemoveFirst()
{
if (!HookedList.Contains("RemoveFirst"))
{
HookedList.Add("RemoveFirst");
On.LimitBehaviour.RemoveFirst += RemoveFirst;

}
}
internal static event Delegates.RemoveFirst_BeforeArgs _beforeRemoveFirst;
internal static event Delegates.RemoveFirst_AfterArgs _afterRemoveFirst;
private static void RemoveFirst(On.LimitBehaviour.orig_RemoveFirst orig,LimitBehaviour self)
{
Delegates.Params_RemoveFirst @params = new() 
{
self = self
};
if (_beforeRemoveFirst != null)
{
foreach (Delegates.RemoveFirst_BeforeArgs toInvoke in _beforeRemoveFirst.GetInvocationList())
{
try
{
_beforeRemoveFirst?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterRemoveFirst != null)
{
foreach (Delegates.RemoveFirst_AfterArgs toInvoke in _afterRemoveFirst.GetInvocationList())
{
try
{
_afterRemoveFirst.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookRemoveSelf()
{
if (!HookedList.Contains("RemoveSelf"))
{
HookedList.Add("RemoveSelf");
On.LimitBehaviour.RemoveSelf += RemoveSelf;

}
}
internal static event Delegates.RemoveSelf_BeforeArgs _beforeRemoveSelf;
internal static event Delegates.RemoveSelf_AfterArgs _afterRemoveSelf;
private static void RemoveSelf(On.LimitBehaviour.orig_RemoveSelf orig,LimitBehaviour self)
{
Delegates.Params_RemoveSelf @params = new() 
{
self = self
};
if (_beforeRemoveSelf != null)
{
foreach (Delegates.RemoveSelf_BeforeArgs toInvoke in _beforeRemoveSelf.GetInvocationList())
{
try
{
_beforeRemoveSelf?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterRemoveSelf != null)
{
foreach (Delegates.RemoveSelf_AfterArgs toInvoke in _afterRemoveSelf.GetInvocationList())
{
try
{
_afterRemoveSelf.Invoke(@params);
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
public sealed class Params_OnDisable
{
public LimitBehaviour self;
}
public delegate void OnDisable_BeforeArgs(Params_OnDisable args);
public delegate void OnDisable_AfterArgs(Params_OnDisable args);
public delegate void OnDisable_WithArgs (Action<LimitBehaviour> orig, LimitBehaviour self);
public sealed class Params_Add
{
public LimitBehaviour self;
}
public delegate void Add_BeforeArgs(Params_Add args);
public delegate void Add_AfterArgs(Params_Add args);
public delegate void Add_WithArgs (Action<LimitBehaviour> orig, LimitBehaviour self);
public sealed class Params_RemoveFirst
{
public LimitBehaviour self;
}
public delegate void RemoveFirst_BeforeArgs(Params_RemoveFirst args);
public delegate void RemoveFirst_AfterArgs(Params_RemoveFirst args);
public delegate void RemoveFirst_WithArgs (Action<LimitBehaviour> orig, LimitBehaviour self);
public sealed class Params_RemoveSelf
{
public LimitBehaviour self;
}
public delegate void RemoveSelf_BeforeArgs(Params_RemoveSelf args);
public delegate void RemoveSelf_AfterArgs(Params_RemoveSelf args);
public delegate void RemoveSelf_WithArgs (Action<LimitBehaviour> orig, LimitBehaviour self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnDisable_BeforeArgs OnDisable
{
add
{

HookHandler._beforeOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._beforeOnDisable -= value;
}
public static event Delegates.Add_BeforeArgs Add
{
add
{

HookHandler._beforeAdd += value;
HookHandler.HookAdd();
}
remove => HookHandler._beforeAdd -= value;
}
public static event Delegates.RemoveFirst_BeforeArgs RemoveFirst
{
add
{

HookHandler._beforeRemoveFirst += value;
HookHandler.HookRemoveFirst();
}
remove => HookHandler._beforeRemoveFirst -= value;
}
public static event Delegates.RemoveSelf_BeforeArgs RemoveSelf
{
add
{

HookHandler._beforeRemoveSelf += value;
HookHandler.HookRemoveSelf();
}
remove => HookHandler._beforeRemoveSelf -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnDisable_AfterArgs OnDisable
{
add
{

HookHandler._afterOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._afterOnDisable -= value;
}
public static event Delegates.Add_AfterArgs Add
{
add
{

HookHandler._afterAdd += value;
HookHandler.HookAdd();
}
remove => HookHandler._afterAdd -= value;
}
public static event Delegates.RemoveFirst_AfterArgs RemoveFirst
{
add
{

HookHandler._afterRemoveFirst += value;
HookHandler.HookRemoveFirst();
}
remove => HookHandler._afterRemoveFirst -= value;
}
public static event Delegates.RemoveSelf_AfterArgs RemoveSelf
{
add
{

HookHandler._afterRemoveSelf += value;
HookHandler.HookRemoveSelf();
}
remove => HookHandler._afterRemoveSelf -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.LimitBehaviour.hook_OnDisable OnDisable
{
add => On.LimitBehaviour.OnDisable += value;
remove => On.LimitBehaviour.OnDisable -= value;
}
public static event On.LimitBehaviour.hook_Add Add
{
add => On.LimitBehaviour.Add += value;
remove => On.LimitBehaviour.Add -= value;
}
public static event On.LimitBehaviour.hook_RemoveFirst RemoveFirst
{
add => On.LimitBehaviour.RemoveFirst += value;
remove => On.LimitBehaviour.RemoveFirst -= value;
}
public static event On.LimitBehaviour.hook_RemoveSelf RemoveSelf
{
add => On.LimitBehaviour.RemoveSelf += value;
remove => On.LimitBehaviour.RemoveSelf -= value;
}
}

}
