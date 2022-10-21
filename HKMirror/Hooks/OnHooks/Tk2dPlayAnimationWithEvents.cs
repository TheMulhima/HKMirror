using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for Tk2dPlayAnimationWithEvents class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTk2dPlayAnimationWithEvents
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hook_getSprite()
{
if (!HookedList.Contains("_getSprite"))
{
HookedList.Add("_getSprite");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "_getSprite", true), _getSprite);

}
}
internal static event Delegates._getSprite_BeforeArgs _before_getSprite;
internal static event Delegates._getSprite_AfterArgs _after_getSprite;
private static void _getSprite(Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self)
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self)
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
internal static void HookDoPlayAnimationWithEvents()
{
if (!HookedList.Contains("DoPlayAnimationWithEvents"))
{
HookedList.Add("DoPlayAnimationWithEvents");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "DoPlayAnimationWithEvents", true), DoPlayAnimationWithEvents);

}
}
internal static event Delegates.DoPlayAnimationWithEvents_BeforeArgs _beforeDoPlayAnimationWithEvents;
internal static event Delegates.DoPlayAnimationWithEvents_AfterArgs _afterDoPlayAnimationWithEvents;
private static void DoPlayAnimationWithEvents(Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self)
{
Delegates.Params_DoPlayAnimationWithEvents @params = new() 
{
self = self
};
if (_beforeDoPlayAnimationWithEvents != null)
{
foreach (Delegates.DoPlayAnimationWithEvents_BeforeArgs toInvoke in _beforeDoPlayAnimationWithEvents.GetInvocationList())
{
try
{
_beforeDoPlayAnimationWithEvents?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoPlayAnimationWithEvents != null)
{
foreach (Delegates.DoPlayAnimationWithEvents_AfterArgs toInvoke in _afterDoPlayAnimationWithEvents.GetInvocationList())
{
try
{
_afterDoPlayAnimationWithEvents.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookAnimationEventDelegate()
{
if (!HookedList.Contains("AnimationEventDelegate"))
{
HookedList.Add("AnimationEventDelegate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "AnimationEventDelegate", true), AnimationEventDelegate);

}
}
internal static event Delegates.AnimationEventDelegate_BeforeArgs _beforeAnimationEventDelegate;
internal static event Delegates.AnimationEventDelegate_AfterArgs _afterAnimationEventDelegate;
private static void AnimationEventDelegate(Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents,  tk2dSpriteAnimator,  tk2dSpriteAnimationClip,  int> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self,  tk2dSpriteAnimator sprite,  tk2dSpriteAnimationClip clip,  int frameNum)
{
Delegates.Params_AnimationEventDelegate @params = new() 
{
self = self
, sprite = sprite
, clip = clip
, frameNum = frameNum
};
if (_beforeAnimationEventDelegate != null)
{
foreach (Delegates.AnimationEventDelegate_BeforeArgs toInvoke in _beforeAnimationEventDelegate.GetInvocationList())
{
try
{
_beforeAnimationEventDelegate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
sprite = @params.sprite;
clip = @params.clip;
frameNum = @params.frameNum;
orig(self, sprite, clip, frameNum);
if (_afterAnimationEventDelegate != null)
{
foreach (Delegates.AnimationEventDelegate_AfterArgs toInvoke in _afterAnimationEventDelegate.GetInvocationList())
{
try
{
_afterAnimationEventDelegate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookAnimationCompleteDelegate()
{
if (!HookedList.Contains("AnimationCompleteDelegate"))
{
HookedList.Add("AnimationCompleteDelegate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "AnimationCompleteDelegate", true), AnimationCompleteDelegate);

}
}
internal static event Delegates.AnimationCompleteDelegate_BeforeArgs _beforeAnimationCompleteDelegate;
internal static event Delegates.AnimationCompleteDelegate_AfterArgs _afterAnimationCompleteDelegate;
private static void AnimationCompleteDelegate(Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents,  tk2dSpriteAnimator,  tk2dSpriteAnimationClip> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self,  tk2dSpriteAnimator sprite,  tk2dSpriteAnimationClip clip)
{
Delegates.Params_AnimationCompleteDelegate @params = new() 
{
self = self
, sprite = sprite
, clip = clip
};
if (_beforeAnimationCompleteDelegate != null)
{
foreach (Delegates.AnimationCompleteDelegate_BeforeArgs toInvoke in _beforeAnimationCompleteDelegate.GetInvocationList())
{
try
{
_beforeAnimationCompleteDelegate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
sprite = @params.sprite;
clip = @params.clip;
orig(self, sprite, clip);
if (_afterAnimationCompleteDelegate != null)
{
foreach (Delegates.AnimationCompleteDelegate_AfterArgs toInvoke in _afterAnimationCompleteDelegate.GetInvocationList())
{
try
{
_afterAnimationCompleteDelegate.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self;
}
public delegate void _getSprite_BeforeArgs(Params__getSprite args);
public delegate void _getSprite_AfterArgs(Params__getSprite args);
public delegate void _getSprite_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self);
public sealed class Params_Reset
{
public HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self);
public sealed class Params_DoPlayAnimationWithEvents
{
public HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self;
}
public delegate void DoPlayAnimationWithEvents_BeforeArgs(Params_DoPlayAnimationWithEvents args);
public delegate void DoPlayAnimationWithEvents_AfterArgs(Params_DoPlayAnimationWithEvents args);
public delegate void DoPlayAnimationWithEvents_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self);
public sealed class Params_AnimationEventDelegate
{
public HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self;
public tk2dSpriteAnimator sprite;
public tk2dSpriteAnimationClip clip;
public int frameNum;
}
public delegate void AnimationEventDelegate_BeforeArgs(Params_AnimationEventDelegate args);
public delegate void AnimationEventDelegate_AfterArgs(Params_AnimationEventDelegate args);
public delegate void AnimationEventDelegate_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents,  tk2dSpriteAnimator,  tk2dSpriteAnimationClip,  int> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self,  tk2dSpriteAnimator sprite,  tk2dSpriteAnimationClip clip,  int frameNum);
public sealed class Params_AnimationCompleteDelegate
{
public HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self;
public tk2dSpriteAnimator sprite;
public tk2dSpriteAnimationClip clip;
}
public delegate void AnimationCompleteDelegate_BeforeArgs(Params_AnimationCompleteDelegate args);
public delegate void AnimationCompleteDelegate_AfterArgs(Params_AnimationCompleteDelegate args);
public delegate void AnimationCompleteDelegate_WithArgs (Action<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents,  tk2dSpriteAnimator,  tk2dSpriteAnimationClip> orig, HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents self,  tk2dSpriteAnimator sprite,  tk2dSpriteAnimationClip clip);
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
public static event Delegates.DoPlayAnimationWithEvents_BeforeArgs DoPlayAnimationWithEvents
{
add
{

HookHandler._beforeDoPlayAnimationWithEvents += value;
HookHandler.HookDoPlayAnimationWithEvents();
}
remove => HookHandler._beforeDoPlayAnimationWithEvents -= value;
}
public static event Delegates.AnimationEventDelegate_BeforeArgs AnimationEventDelegate
{
add
{

HookHandler._beforeAnimationEventDelegate += value;
HookHandler.HookAnimationEventDelegate();
}
remove => HookHandler._beforeAnimationEventDelegate -= value;
}
public static event Delegates.AnimationCompleteDelegate_BeforeArgs AnimationCompleteDelegate
{
add
{

HookHandler._beforeAnimationCompleteDelegate += value;
HookHandler.HookAnimationCompleteDelegate();
}
remove => HookHandler._beforeAnimationCompleteDelegate -= value;
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
public static event Delegates.DoPlayAnimationWithEvents_AfterArgs DoPlayAnimationWithEvents
{
add
{

HookHandler._afterDoPlayAnimationWithEvents += value;
HookHandler.HookDoPlayAnimationWithEvents();
}
remove => HookHandler._afterDoPlayAnimationWithEvents -= value;
}
public static event Delegates.AnimationEventDelegate_AfterArgs AnimationEventDelegate
{
add
{

HookHandler._afterAnimationEventDelegate += value;
HookHandler.HookAnimationEventDelegate();
}
remove => HookHandler._afterAnimationEventDelegate -= value;
}
public static event Delegates.AnimationCompleteDelegate_AfterArgs AnimationCompleteDelegate
{
add
{

HookHandler._afterAnimationCompleteDelegate += value;
HookHandler.HookAnimationCompleteDelegate();
}
remove => HookHandler._afterAnimationCompleteDelegate -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates._getSprite_WithArgs _getSprite
{
add => HookEndpointManager.Add<Delegates._getSprite_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "_getSprite", true), value);
remove => HookEndpointManager.Remove<Delegates._getSprite_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "_getSprite", true), value);
}
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "Reset", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "OnEnter", true), value);
}
public static event Delegates.DoPlayAnimationWithEvents_WithArgs DoPlayAnimationWithEvents
{
add => HookEndpointManager.Add<Delegates.DoPlayAnimationWithEvents_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "DoPlayAnimationWithEvents", true), value);
remove => HookEndpointManager.Remove<Delegates.DoPlayAnimationWithEvents_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "DoPlayAnimationWithEvents", true), value);
}
public static event Delegates.AnimationEventDelegate_WithArgs AnimationEventDelegate
{
add => HookEndpointManager.Add<Delegates.AnimationEventDelegate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "AnimationEventDelegate", true), value);
remove => HookEndpointManager.Remove<Delegates.AnimationEventDelegate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "AnimationEventDelegate", true), value);
}
public static event Delegates.AnimationCompleteDelegate_WithArgs AnimationCompleteDelegate
{
add => HookEndpointManager.Add<Delegates.AnimationCompleteDelegate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "AnimationCompleteDelegate", true), value);
remove => HookEndpointManager.Remove<Delegates.AnimationCompleteDelegate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents), "AnimationCompleteDelegate", true), value);
}
}

}
