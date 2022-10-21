using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for Tk2dSetAnimationFrameRate class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dSetAnimationFrameRate
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hook_getSprite()
{
if (!HookedList.Contains("_getSprite"))
{
HookedList.Add("_getSprite");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "_getSprite", true), _getSprite);

}
}
internal static event Delegates._getSprite_BeforeArgs _before_getSprite;
internal static event Delegates._getSprite_AfterArgs _after_getSprite;
private static void _getSprite(Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self)
{
Delegates.Params__getSprite @params = new() 
{
self = self
};
if (_before_getSprite != null)
{
foreach (Delegates._getSprite_BeforeArgs toInvoke in _before_getSprite.GetInvocationList())
{
try
{
_before_getSprite?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_after_getSprite != null)
{
foreach (Delegates._getSprite_AfterArgs toInvoke in _after_getSprite.GetInvocationList())
{
try
{
_after_getSprite.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "OnUpdate", true), OnUpdate);

}
}
internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;
private static void OnUpdate(Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self)
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
internal static void HookDoSetAnimationFPS()
{
if (!HookedList.Contains("DoSetAnimationFPS"))
{
HookedList.Add("DoSetAnimationFPS");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "DoSetAnimationFPS", true), DoSetAnimationFPS);

}
}
internal static event Delegates.DoSetAnimationFPS_BeforeArgs _beforeDoSetAnimationFPS;
internal static event Delegates.DoSetAnimationFPS_AfterArgs _afterDoSetAnimationFPS;
private static void DoSetAnimationFPS(Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self)
{
Delegates.Params_DoSetAnimationFPS @params = new() 
{
self = self
};
if (_beforeDoSetAnimationFPS != null)
{
foreach (Delegates.DoSetAnimationFPS_BeforeArgs toInvoke in _beforeDoSetAnimationFPS.GetInvocationList())
{
try
{
_beforeDoSetAnimationFPS?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoSetAnimationFPS != null)
{
foreach (Delegates.DoSetAnimationFPS_AfterArgs toInvoke in _afterDoSetAnimationFPS.GetInvocationList())
{
try
{
_afterDoSetAnimationFPS.Invoke(@params);
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
public sealed class Params__getSprite
{
public HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self;
}
public delegate void _getSprite_BeforeArgs(Params__getSprite args);
public delegate void _getSprite_AfterArgs(Params__getSprite args);
public delegate void _getSprite_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self);
public sealed class Params_Reset
{
public HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self);
public sealed class Params_OnUpdate
{
public HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self;
}
public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);
public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);
public delegate void OnUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self);
public sealed class Params_DoSetAnimationFPS
{
public HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self;
}
public delegate void DoSetAnimationFPS_BeforeArgs(Params_DoSetAnimationFPS args);
public delegate void DoSetAnimationFPS_AfterArgs(Params_DoSetAnimationFPS args);
public delegate void DoSetAnimationFPS_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate> orig, HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates._getSprite_BeforeArgs _getSprite
{
add
{

HookHandler._before_getSprite += value;
HookHandler.Hook_getSprite();
}
remove => HookHandler._before_getSprite -= value;
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
public static event Delegates.OnUpdate_BeforeArgs OnUpdate
{
add
{

HookHandler._beforeOnUpdate += value;
HookHandler.HookOnUpdate();
}
remove => HookHandler._beforeOnUpdate -= value;
}
public static event Delegates.DoSetAnimationFPS_BeforeArgs DoSetAnimationFPS
{
add
{

HookHandler._beforeDoSetAnimationFPS += value;
HookHandler.HookDoSetAnimationFPS();
}
remove => HookHandler._beforeDoSetAnimationFPS -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates._getSprite_AfterArgs _getSprite
{
add
{

HookHandler._after_getSprite += value;
HookHandler.Hook_getSprite();
}
remove => HookHandler._after_getSprite -= value;
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
public static event Delegates.OnUpdate_AfterArgs OnUpdate
{
add
{

HookHandler._afterOnUpdate += value;
HookHandler.HookOnUpdate();
}
remove => HookHandler._afterOnUpdate -= value;
}
public static event Delegates.DoSetAnimationFPS_AfterArgs DoSetAnimationFPS
{
add
{

HookHandler._afterDoSetAnimationFPS += value;
HookHandler.HookDoSetAnimationFPS();
}
remove => HookHandler._afterDoSetAnimationFPS -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates._getSprite_WithArgs _getSprite
{
add => HookEndpointManager.Add<Delegates._getSprite_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "_getSprite", true), value);
remove => HookEndpointManager.Remove<Delegates._getSprite_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "_getSprite", true), value);
}
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "OnEnter", true), value);
}
public static event Delegates.OnUpdate_WithArgs OnUpdate
{
add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "OnUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "OnUpdate", true), value);
}
public static event Delegates.DoSetAnimationFPS_WithArgs DoSetAnimationFPS
{
add => HookEndpointManager.Add<Delegates.DoSetAnimationFPS_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "DoSetAnimationFPS", true), value);
remove => HookEndpointManager.Remove<Delegates.DoSetAnimationFPS_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dSetAnimationFrameRate), "DoSetAnimationFPS", true), value);
}
}

}
