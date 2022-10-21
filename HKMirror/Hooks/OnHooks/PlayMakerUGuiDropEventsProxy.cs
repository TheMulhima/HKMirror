using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for PlayMakerUGuiDropEventsProxy class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerUGuiDropEventsProxy
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnDrop()
{
if (!HookedList.Contains("OnDrop"))
{
HookedList.Add("OnDrop");
On.PlayMakerUGuiDropEventsProxy.OnDrop += OnDrop;

}
}
internal static event Delegates.OnDrop_BeforeArgs _beforeOnDrop;
internal static event Delegates.OnDrop_AfterArgs _afterOnDrop;
private static void OnDrop(On.PlayMakerUGuiDropEventsProxy.orig_OnDrop orig,PlayMakerUGuiDropEventsProxy self,  UnityEngine.EventSystems.PointerEventData data)
{
Delegates.Params_OnDrop @params = new() 
{
self = self
, data = data
};
if (_beforeOnDrop != null)
{
foreach (Delegates.OnDrop_BeforeArgs toInvoke in _beforeOnDrop.GetInvocationList())
{
try
{
_beforeOnDrop?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
data = @params.data;
orig(self, data);
if (_afterOnDrop != null)
{
foreach (Delegates.OnDrop_AfterArgs toInvoke in _afterOnDrop.GetInvocationList())
{
try
{
_afterOnDrop.Invoke(@params);
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
public sealed class Params_OnDrop
{
public PlayMakerUGuiDropEventsProxy self;
public UnityEngine.EventSystems.PointerEventData data;
}
public delegate void OnDrop_BeforeArgs(Params_OnDrop args);
public delegate void OnDrop_AfterArgs(Params_OnDrop args);
public delegate void OnDrop_WithArgs (Action<PlayMakerUGuiDropEventsProxy,  UnityEngine.EventSystems.PointerEventData> orig, PlayMakerUGuiDropEventsProxy self,  UnityEngine.EventSystems.PointerEventData data);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnDrop_BeforeArgs OnDrop
{
add
{

HookHandler._beforeOnDrop += value;
HookHandler.HookOnDrop();
}
remove => HookHandler._beforeOnDrop -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnDrop_AfterArgs OnDrop
{
add
{

HookHandler._afterOnDrop += value;
HookHandler.HookOnDrop();
}
remove => HookHandler._afterOnDrop -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.PlayMakerUGuiDropEventsProxy.hook_OnDrop OnDrop
{
add => On.PlayMakerUGuiDropEventsProxy.OnDrop += value;
remove => On.PlayMakerUGuiDropEventsProxy.OnDrop -= value;
}
}

}
