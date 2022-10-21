using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for PlayMakerUGuiCanvasRaycastFilterEventsProxy class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerUGuiCanvasRaycastFilterEventsProxy
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookIsRaycastLocationValid()
{
if (!HookedList.Contains("IsRaycastLocationValid"))
{
HookedList.Add("IsRaycastLocationValid");
On.PlayMakerUGuiCanvasRaycastFilterEventsProxy.IsRaycastLocationValid += IsRaycastLocationValid;

}
}
internal static event Delegates.IsRaycastLocationValid_BeforeArgs _beforeIsRaycastLocationValid;
internal static event Delegates.IsRaycastLocationValid_AfterArgs _afterIsRaycastLocationValid;
private static bool IsRaycastLocationValid(On.PlayMakerUGuiCanvasRaycastFilterEventsProxy.orig_IsRaycastLocationValid orig,PlayMakerUGuiCanvasRaycastFilterEventsProxy self,  UnityEngine.Vector2 sp,  UnityEngine.Camera eventCamera)
{
Delegates.Params_IsRaycastLocationValid @params = new() 
{
self = self
, sp = sp
, eventCamera = eventCamera
};
if (_beforeIsRaycastLocationValid != null)
{
foreach (Delegates.IsRaycastLocationValid_BeforeArgs toInvoke in _beforeIsRaycastLocationValid.GetInvocationList())
{
try
{
_beforeIsRaycastLocationValid?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
sp = @params.sp;
eventCamera = @params.eventCamera;
var retVal = orig(self, sp, eventCamera);
if (_afterIsRaycastLocationValid != null)
{
foreach (Delegates.IsRaycastLocationValid_AfterArgs toInvoke in _afterIsRaycastLocationValid.GetInvocationList())
{
try
{
retVal = _afterIsRaycastLocationValid.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_IsRaycastLocationValid
{
public PlayMakerUGuiCanvasRaycastFilterEventsProxy self;
public UnityEngine.Vector2 sp;
public UnityEngine.Camera eventCamera;
}
public delegate void IsRaycastLocationValid_BeforeArgs(Params_IsRaycastLocationValid args);
public delegate bool IsRaycastLocationValid_AfterArgs(Params_IsRaycastLocationValid args, bool ret);
public delegate bool IsRaycastLocationValid_WithArgs (Func<PlayMakerUGuiCanvasRaycastFilterEventsProxy,  UnityEngine.Vector2,  UnityEngine.Camera, bool> orig, PlayMakerUGuiCanvasRaycastFilterEventsProxy self,  UnityEngine.Vector2 sp,  UnityEngine.Camera eventCamera);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.IsRaycastLocationValid_BeforeArgs IsRaycastLocationValid
{
add
{

HookHandler._beforeIsRaycastLocationValid += value;
HookHandler.HookIsRaycastLocationValid();
}
remove => HookHandler._beforeIsRaycastLocationValid -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.IsRaycastLocationValid_AfterArgs IsRaycastLocationValid
{
add
{

HookHandler._afterIsRaycastLocationValid += value;
HookHandler.HookIsRaycastLocationValid();
}
remove => HookHandler._afterIsRaycastLocationValid -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.PlayMakerUGuiCanvasRaycastFilterEventsProxy.hook_IsRaycastLocationValid IsRaycastLocationValid
{
add => On.PlayMakerUGuiCanvasRaycastFilterEventsProxy.IsRaycastLocationValid += value;
remove => On.PlayMakerUGuiCanvasRaycastFilterEventsProxy.IsRaycastLocationValid -= value;
}
}

}
