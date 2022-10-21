using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for PlayParticleOnEntry class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayParticleOnEntry
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookStart()
{
if (!HookedList.Contains("Start"))
{
HookedList.Add("Start");
On.PlayParticleOnEntry.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.PlayParticleOnEntry.orig_Start orig,PlayParticleOnEntry self)
{
Delegates.Params_Start @params = new() 
{
self = self
};
if (_beforeStart != null)
{
foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
{
try
{
_beforeStart?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterStart != null)
{
foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
{
try
{
_afterStart.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnTriggerEnter2D()
{
if (!HookedList.Contains("OnTriggerEnter2D"))
{
HookedList.Add("OnTriggerEnter2D");
On.PlayParticleOnEntry.OnTriggerEnter2D += OnTriggerEnter2D;

}
}
internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;
private static void OnTriggerEnter2D(On.PlayParticleOnEntry.orig_OnTriggerEnter2D orig,PlayParticleOnEntry self,  UnityEngine.Collider2D collision)
{
Delegates.Params_OnTriggerEnter2D @params = new() 
{
self = self
, collision = collision
};
if (_beforeOnTriggerEnter2D != null)
{
foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
{
try
{
_beforeOnTriggerEnter2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
collision = @params.collision;
orig(self, collision);
if (_afterOnTriggerEnter2D != null)
{
foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
{
try
{
_afterOnTriggerEnter2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnTriggerExit2D()
{
if (!HookedList.Contains("OnTriggerExit2D"))
{
HookedList.Add("OnTriggerExit2D");
On.PlayParticleOnEntry.OnTriggerExit2D += OnTriggerExit2D;

}
}
internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;
private static void OnTriggerExit2D(On.PlayParticleOnEntry.orig_OnTriggerExit2D orig,PlayParticleOnEntry self,  UnityEngine.Collider2D collision)
{
Delegates.Params_OnTriggerExit2D @params = new() 
{
self = self
, collision = collision
};
if (_beforeOnTriggerExit2D != null)
{
foreach (Delegates.OnTriggerExit2D_BeforeArgs toInvoke in _beforeOnTriggerExit2D.GetInvocationList())
{
try
{
_beforeOnTriggerExit2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
collision = @params.collision;
orig(self, collision);
if (_afterOnTriggerExit2D != null)
{
foreach (Delegates.OnTriggerExit2D_AfterArgs toInvoke in _afterOnTriggerExit2D.GetInvocationList())
{
try
{
_afterOnTriggerExit2D.Invoke(@params);
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
public sealed class Params_Start
{
public PlayParticleOnEntry self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<PlayParticleOnEntry> orig, PlayParticleOnEntry self);
public sealed class Params_OnTriggerEnter2D
{
public PlayParticleOnEntry self;
public UnityEngine.Collider2D collision;
}
public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_WithArgs (Action<PlayParticleOnEntry,  UnityEngine.Collider2D> orig, PlayParticleOnEntry self,  UnityEngine.Collider2D collision);
public sealed class Params_OnTriggerExit2D
{
public PlayParticleOnEntry self;
public UnityEngine.Collider2D collision;
}
public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);
public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);
public delegate void OnTriggerExit2D_WithArgs (Action<PlayParticleOnEntry,  UnityEngine.Collider2D> orig, PlayParticleOnEntry self,  UnityEngine.Collider2D collision);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Start_BeforeArgs Start
{
add
{

HookHandler._beforeStart += value;
HookHandler.HookStart();
}
remove => HookHandler._beforeStart -= value;
}
public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
{
add
{

HookHandler._beforeOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._beforeOnTriggerEnter2D -= value;
}
public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
{
add
{

HookHandler._beforeOnTriggerExit2D += value;
HookHandler.HookOnTriggerExit2D();
}
remove => HookHandler._beforeOnTriggerExit2D -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Start_AfterArgs Start
{
add
{

HookHandler._afterStart += value;
HookHandler.HookStart();
}
remove => HookHandler._afterStart -= value;
}
public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
{
add
{

HookHandler._afterOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._afterOnTriggerEnter2D -= value;
}
public static event Delegates.OnTriggerExit2D_AfterArgs OnTriggerExit2D
{
add
{

HookHandler._afterOnTriggerExit2D += value;
HookHandler.HookOnTriggerExit2D();
}
remove => HookHandler._afterOnTriggerExit2D -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.PlayParticleOnEntry.hook_Start Start
{
add => On.PlayParticleOnEntry.Start += value;
remove => On.PlayParticleOnEntry.Start -= value;
}
public static event On.PlayParticleOnEntry.hook_OnTriggerEnter2D OnTriggerEnter2D
{
add => On.PlayParticleOnEntry.OnTriggerEnter2D += value;
remove => On.PlayParticleOnEntry.OnTriggerEnter2D -= value;
}
public static event On.PlayParticleOnEntry.hook_OnTriggerExit2D OnTriggerExit2D
{
add => On.PlayParticleOnEntry.OnTriggerExit2D += value;
remove => On.PlayParticleOnEntry.OnTriggerExit2D -= value;
}
}

}
