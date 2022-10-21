using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for tk2dSpriteAttachPoint class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteAttachPoint
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.tk2dSpriteAttachPoint.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.tk2dSpriteAttachPoint.orig_Awake orig,tk2dSpriteAttachPoint self)
{
Delegates.Params_Awake @params = new() 
{
self = self
};
if (_beforeAwake != null)
{
foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
{
try
{
_beforeAwake?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterAwake != null)
{
foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
{
try
{
_afterAwake.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnEnable()
{
if (!HookedList.Contains("OnEnable"))
{
HookedList.Add("OnEnable");
On.tk2dSpriteAttachPoint.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.tk2dSpriteAttachPoint.orig_OnEnable orig,tk2dSpriteAttachPoint self)
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
internal static void HookOnDisable()
{
if (!HookedList.Contains("OnDisable"))
{
HookedList.Add("OnDisable");
On.tk2dSpriteAttachPoint.OnDisable += OnDisable;

}
}
internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;
private static void OnDisable(On.tk2dSpriteAttachPoint.orig_OnDisable orig,tk2dSpriteAttachPoint self)
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
internal static void HookGetInstanceName()
{
if (!HookedList.Contains("GetInstanceName"))
{
HookedList.Add("GetInstanceName");
On.tk2dSpriteAttachPoint.GetInstanceName += GetInstanceName;

}
}
internal static event Delegates.GetInstanceName_BeforeArgs _beforeGetInstanceName;
internal static event Delegates.GetInstanceName_AfterArgs _afterGetInstanceName;
private static string GetInstanceName(On.tk2dSpriteAttachPoint.orig_GetInstanceName orig,tk2dSpriteAttachPoint self,  UnityEngine.Transform t)
{
Delegates.Params_GetInstanceName @params = new() 
{
self = self
, t = t
};
if (_beforeGetInstanceName != null)
{
foreach (Delegates.GetInstanceName_BeforeArgs toInvoke in _beforeGetInstanceName.GetInvocationList())
{
try
{
_beforeGetInstanceName?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
t = @params.t;
var retVal = orig(self, t);
if (_afterGetInstanceName != null)
{
foreach (Delegates.GetInstanceName_AfterArgs toInvoke in _afterGetInstanceName.GetInvocationList())
{
try
{
retVal = _afterGetInstanceName.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookHandleSpriteChanged()
{
if (!HookedList.Contains("HandleSpriteChanged"))
{
HookedList.Add("HandleSpriteChanged");
On.tk2dSpriteAttachPoint.HandleSpriteChanged += HandleSpriteChanged;

}
}
internal static event Delegates.HandleSpriteChanged_BeforeArgs _beforeHandleSpriteChanged;
internal static event Delegates.HandleSpriteChanged_AfterArgs _afterHandleSpriteChanged;
private static void HandleSpriteChanged(On.tk2dSpriteAttachPoint.orig_HandleSpriteChanged orig,tk2dSpriteAttachPoint self,  tk2dBaseSprite spr)
{
Delegates.Params_HandleSpriteChanged @params = new() 
{
self = self
, spr = spr
};
if (_beforeHandleSpriteChanged != null)
{
foreach (Delegates.HandleSpriteChanged_BeforeArgs toInvoke in _beforeHandleSpriteChanged.GetInvocationList())
{
try
{
_beforeHandleSpriteChanged?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
spr = @params.spr;
orig(self, spr);
if (_afterHandleSpriteChanged != null)
{
foreach (Delegates.HandleSpriteChanged_AfterArgs toInvoke in _afterHandleSpriteChanged.GetInvocationList())
{
try
{
_afterHandleSpriteChanged.Invoke(@params);
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
public sealed class Params_Awake
{
public tk2dSpriteAttachPoint self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<tk2dSpriteAttachPoint> orig, tk2dSpriteAttachPoint self);
public sealed class Params_OnEnable
{
public tk2dSpriteAttachPoint self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<tk2dSpriteAttachPoint> orig, tk2dSpriteAttachPoint self);
public sealed class Params_OnDisable
{
public tk2dSpriteAttachPoint self;
}
public delegate void OnDisable_BeforeArgs(Params_OnDisable args);
public delegate void OnDisable_AfterArgs(Params_OnDisable args);
public delegate void OnDisable_WithArgs (Action<tk2dSpriteAttachPoint> orig, tk2dSpriteAttachPoint self);
public sealed class Params_GetInstanceName
{
public tk2dSpriteAttachPoint self;
public UnityEngine.Transform t;
}
public delegate void GetInstanceName_BeforeArgs(Params_GetInstanceName args);
public delegate string GetInstanceName_AfterArgs(Params_GetInstanceName args, string ret);
public delegate string GetInstanceName_WithArgs (Func<tk2dSpriteAttachPoint,  UnityEngine.Transform, string> orig, tk2dSpriteAttachPoint self,  UnityEngine.Transform t);
public sealed class Params_HandleSpriteChanged
{
public tk2dSpriteAttachPoint self;
public tk2dBaseSprite spr;
}
public delegate void HandleSpriteChanged_BeforeArgs(Params_HandleSpriteChanged args);
public delegate void HandleSpriteChanged_AfterArgs(Params_HandleSpriteChanged args);
public delegate void HandleSpriteChanged_WithArgs (Action<tk2dSpriteAttachPoint,  tk2dBaseSprite> orig, tk2dSpriteAttachPoint self,  tk2dBaseSprite spr);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Awake_BeforeArgs Awake
{
add
{

HookHandler._beforeAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._beforeAwake -= value;
}
public static event Delegates.OnEnable_BeforeArgs OnEnable
{
add
{

HookHandler._beforeOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._beforeOnEnable -= value;
}
public static event Delegates.OnDisable_BeforeArgs OnDisable
{
add
{

HookHandler._beforeOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._beforeOnDisable -= value;
}
public static event Delegates.GetInstanceName_BeforeArgs GetInstanceName
{
add
{

HookHandler._beforeGetInstanceName += value;
HookHandler.HookGetInstanceName();
}
remove => HookHandler._beforeGetInstanceName -= value;
}
public static event Delegates.HandleSpriteChanged_BeforeArgs HandleSpriteChanged
{
add
{

HookHandler._beforeHandleSpriteChanged += value;
HookHandler.HookHandleSpriteChanged();
}
remove => HookHandler._beforeHandleSpriteChanged -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Awake_AfterArgs Awake
{
add
{

HookHandler._afterAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._afterAwake -= value;
}
public static event Delegates.OnEnable_AfterArgs OnEnable
{
add
{

HookHandler._afterOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._afterOnEnable -= value;
}
public static event Delegates.OnDisable_AfterArgs OnDisable
{
add
{

HookHandler._afterOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._afterOnDisable -= value;
}
public static event Delegates.GetInstanceName_AfterArgs GetInstanceName
{
add
{

HookHandler._afterGetInstanceName += value;
HookHandler.HookGetInstanceName();
}
remove => HookHandler._afterGetInstanceName -= value;
}
public static event Delegates.HandleSpriteChanged_AfterArgs HandleSpriteChanged
{
add
{

HookHandler._afterHandleSpriteChanged += value;
HookHandler.HookHandleSpriteChanged();
}
remove => HookHandler._afterHandleSpriteChanged -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.tk2dSpriteAttachPoint.hook_Awake Awake
{
add => On.tk2dSpriteAttachPoint.Awake += value;
remove => On.tk2dSpriteAttachPoint.Awake -= value;
}
public static event On.tk2dSpriteAttachPoint.hook_OnEnable OnEnable
{
add => On.tk2dSpriteAttachPoint.OnEnable += value;
remove => On.tk2dSpriteAttachPoint.OnEnable -= value;
}
public static event On.tk2dSpriteAttachPoint.hook_OnDisable OnDisable
{
add => On.tk2dSpriteAttachPoint.OnDisable += value;
remove => On.tk2dSpriteAttachPoint.OnDisable -= value;
}
public static event On.tk2dSpriteAttachPoint.hook_GetInstanceName GetInstanceName
{
add => On.tk2dSpriteAttachPoint.GetInstanceName += value;
remove => On.tk2dSpriteAttachPoint.GetInstanceName -= value;
}
public static event On.tk2dSpriteAttachPoint.hook_HandleSpriteChanged HandleSpriteChanged
{
add => On.tk2dSpriteAttachPoint.HandleSpriteChanged += value;
remove => On.tk2dSpriteAttachPoint.HandleSpriteChanged -= value;
}
}

}
