using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for ArrayListSwapItems class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListSwapItems
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.ArrayListSwapItems> orig, HutongGames.PlayMaker.Actions.ArrayListSwapItems self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.ArrayListSwapItems> orig, HutongGames.PlayMaker.Actions.ArrayListSwapItems self)
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
internal static void HookdoArrayListSwap()
{
if (!HookedList.Contains("doArrayListSwap"))
{
HookedList.Add("doArrayListSwap");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "doArrayListSwap", true), doArrayListSwap);

}
}
internal static event Delegates.doArrayListSwap_BeforeArgs _beforedoArrayListSwap;
internal static event Delegates.doArrayListSwap_AfterArgs _afterdoArrayListSwap;
private static void doArrayListSwap(Action<HutongGames.PlayMaker.Actions.ArrayListSwapItems> orig, HutongGames.PlayMaker.Actions.ArrayListSwapItems self)
{
Delegates.Params_doArrayListSwap @params = new() 
{
self = self
};
if (_beforedoArrayListSwap != null)
{
foreach (Delegates.doArrayListSwap_BeforeArgs toInvoke in _beforedoArrayListSwap.GetInvocationList())
{
try
{
_beforedoArrayListSwap?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterdoArrayListSwap != null)
{
foreach (Delegates.doArrayListSwap_AfterArgs toInvoke in _afterdoArrayListSwap.GetInvocationList())
{
try
{
_afterdoArrayListSwap.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.ArrayListSwapItems self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.ArrayListSwapItems> orig, HutongGames.PlayMaker.Actions.ArrayListSwapItems self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.ArrayListSwapItems self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.ArrayListSwapItems> orig, HutongGames.PlayMaker.Actions.ArrayListSwapItems self);
public sealed class Params_doArrayListSwap
{
public HutongGames.PlayMaker.Actions.ArrayListSwapItems self;
}
public delegate void doArrayListSwap_BeforeArgs(Params_doArrayListSwap args);
public delegate void doArrayListSwap_AfterArgs(Params_doArrayListSwap args);
public delegate void doArrayListSwap_WithArgs (Action<HutongGames.PlayMaker.Actions.ArrayListSwapItems> orig, HutongGames.PlayMaker.Actions.ArrayListSwapItems self);
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
public static event Delegates.doArrayListSwap_BeforeArgs doArrayListSwap
{
add
{

HookHandler._beforedoArrayListSwap += value;
HookHandler.HookdoArrayListSwap();
}
remove => HookHandler._beforedoArrayListSwap -= value;
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
public static event Delegates.doArrayListSwap_AfterArgs doArrayListSwap
{
add
{

HookHandler._afterdoArrayListSwap += value;
HookHandler.HookdoArrayListSwap();
}
remove => HookHandler._afterdoArrayListSwap -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "OnEnter", true), value);
}
public static event Delegates.doArrayListSwap_WithArgs doArrayListSwap
{
add => HookEndpointManager.Add<Delegates.doArrayListSwap_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "doArrayListSwap", true), value);
remove => HookEndpointManager.Remove<Delegates.doArrayListSwap_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ArrayListSwapItems), "doArrayListSwap", true), value);
}
}

}
