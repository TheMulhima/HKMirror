using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for DisableAfterTime class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDisableAfterTime
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnEnable()
{
if (!HookedList.Contains("OnEnable"))
{
HookedList.Add("OnEnable");
On.DisableAfterTime.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.DisableAfterTime.orig_OnEnable orig,DisableAfterTime self)
{
Delegates.Params_OnEnable @params = new() 
{
self = self
};
if (_beforeOnEnable != null)
{
foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
{
try
{
_beforeOnEnable?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnEnable != null)
{
foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
{
try
{
_afterOnEnable.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookUpdate()
{
if (!HookedList.Contains("Update"))
{
HookedList.Add("Update");
On.DisableAfterTime.Update += Update;

}
}
internal static event Delegates.Update_BeforeArgs _beforeUpdate;
internal static event Delegates.Update_AfterArgs _afterUpdate;
private static void Update(On.DisableAfterTime.orig_Update orig,DisableAfterTime self)
{
Delegates.Params_Update @params = new() 
{
self = self
};
if (_beforeUpdate != null)
{
foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
{
try
{
_beforeUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterUpdate != null)
{
foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
{
try
{
_afterUpdate.Invoke(@params);
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
public sealed class Params_OnEnable
{
public DisableAfterTime self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<DisableAfterTime> orig, DisableAfterTime self);
public sealed class Params_Update
{
public DisableAfterTime self;
}
public delegate void Update_BeforeArgs(Params_Update args);
public delegate void Update_AfterArgs(Params_Update args);
public delegate void Update_WithArgs (Action<DisableAfterTime> orig, DisableAfterTime self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnEnable_BeforeArgs OnEnable
{
add
{

HookHandler._beforeOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._beforeOnEnable -= value;
}
public static event Delegates.Update_BeforeArgs Update
{
add
{

HookHandler._beforeUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._beforeUpdate -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnEnable_AfterArgs OnEnable
{
add
{

HookHandler._afterOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._afterOnEnable -= value;
}
public static event Delegates.Update_AfterArgs Update
{
add
{

HookHandler._afterUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._afterUpdate -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.DisableAfterTime.hook_OnEnable OnEnable
{
add => On.DisableAfterTime.OnEnable += value;
remove => On.DisableAfterTime.OnEnable -= value;
}
public static event On.DisableAfterTime.hook_Update Update
{
add => On.DisableAfterTime.Update += value;
remove => On.DisableAfterTime.Update -= value;
}
}

}
