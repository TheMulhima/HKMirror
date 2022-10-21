using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for UseGravity class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnUseGravity
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.UseGravity> orig, HutongGames.PlayMaker.Actions.UseGravity self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.UseGravity> orig, HutongGames.PlayMaker.Actions.UseGravity self)
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
internal static void HookDoUseGravity()
{
if (!HookedList.Contains("DoUseGravity"))
{
HookedList.Add("DoUseGravity");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "DoUseGravity", true), DoUseGravity);

}
}
internal static event Delegates.DoUseGravity_BeforeArgs _beforeDoUseGravity;
internal static event Delegates.DoUseGravity_AfterArgs _afterDoUseGravity;
private static void DoUseGravity(Action<HutongGames.PlayMaker.Actions.UseGravity> orig, HutongGames.PlayMaker.Actions.UseGravity self)
{
Delegates.Params_DoUseGravity @params = new() 
{
self = self
};
if (_beforeDoUseGravity != null)
{
foreach (Delegates.DoUseGravity_BeforeArgs toInvoke in _beforeDoUseGravity.GetInvocationList())
{
try
{
_beforeDoUseGravity?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoUseGravity != null)
{
foreach (Delegates.DoUseGravity_AfterArgs toInvoke in _afterDoUseGravity.GetInvocationList())
{
try
{
_afterDoUseGravity.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.UseGravity self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.UseGravity> orig, HutongGames.PlayMaker.Actions.UseGravity self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.UseGravity self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.UseGravity> orig, HutongGames.PlayMaker.Actions.UseGravity self);
public sealed class Params_DoUseGravity
{
public HutongGames.PlayMaker.Actions.UseGravity self;
}
public delegate void DoUseGravity_BeforeArgs(Params_DoUseGravity args);
public delegate void DoUseGravity_AfterArgs(Params_DoUseGravity args);
public delegate void DoUseGravity_WithArgs (Action<HutongGames.PlayMaker.Actions.UseGravity> orig, HutongGames.PlayMaker.Actions.UseGravity self);
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
public static event Delegates.DoUseGravity_BeforeArgs DoUseGravity
{
add
{

HookHandler._beforeDoUseGravity += value;
HookHandler.HookDoUseGravity();
}
remove => HookHandler._beforeDoUseGravity -= value;
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
public static event Delegates.DoUseGravity_AfterArgs DoUseGravity
{
add
{

HookHandler._afterDoUseGravity += value;
HookHandler.HookDoUseGravity();
}
remove => HookHandler._afterDoUseGravity -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "OnEnter", true), value);
}
public static event Delegates.DoUseGravity_WithArgs DoUseGravity
{
add => HookEndpointManager.Add<Delegates.DoUseGravity_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "DoUseGravity", true), value);
remove => HookEndpointManager.Remove<Delegates.DoUseGravity_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.UseGravity), "DoUseGravity", true), value);
}
}

}
