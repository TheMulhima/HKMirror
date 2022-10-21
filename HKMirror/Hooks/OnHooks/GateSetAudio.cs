using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for GateSetAudio class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGateSetAudio
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnTriggerEnter2D()
{
if (!HookedList.Contains("OnTriggerEnter2D"))
{
HookedList.Add("OnTriggerEnter2D");
On.GateSetAudio.OnTriggerEnter2D += OnTriggerEnter2D;

}
}
internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;
private static void OnTriggerEnter2D(On.GateSetAudio.orig_OnTriggerEnter2D orig,GateSetAudio self,  UnityEngine.Collider2D otherCollider)
{
Delegates.Params_OnTriggerEnter2D @params = new() 
{
self = self
, otherCollider = otherCollider
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
otherCollider = @params.otherCollider;
orig(self, otherCollider);
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
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_OnTriggerEnter2D
{
public GateSetAudio self;
public UnityEngine.Collider2D otherCollider;
}
public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_WithArgs (Action<GateSetAudio,  UnityEngine.Collider2D> orig, GateSetAudio self,  UnityEngine.Collider2D otherCollider);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
{
add
{

HookHandler._beforeOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._beforeOnTriggerEnter2D -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
{
add
{

HookHandler._afterOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._afterOnTriggerEnter2D -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.GateSetAudio.hook_OnTriggerEnter2D OnTriggerEnter2D
{
add => On.GateSetAudio.OnTriggerEnter2D += value;
remove => On.GateSetAudio.OnTriggerEnter2D -= value;
}
}

}
