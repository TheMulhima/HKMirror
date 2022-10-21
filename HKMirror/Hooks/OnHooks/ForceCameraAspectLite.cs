using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for ForceCameraAspectLite class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnForceCameraAspectLite
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookStart()
{
if (!HookedList.Contains("Start"))
{
HookedList.Add("Start");
On.ForceCameraAspectLite.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.ForceCameraAspectLite.orig_Start orig,ForceCameraAspectLite self)
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
internal static void HookUpdate()
{
if (!HookedList.Contains("Update"))
{
HookedList.Add("Update");
On.ForceCameraAspectLite.Update += Update;

}
}
internal static event Delegates.Update_BeforeArgs _beforeUpdate;
internal static event Delegates.Update_AfterArgs _afterUpdate;
private static void Update(On.ForceCameraAspectLite.orig_Update orig,ForceCameraAspectLite self)
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
internal static void HookAutoScaleViewport()
{
if (!HookedList.Contains("AutoScaleViewport"))
{
HookedList.Add("AutoScaleViewport");
On.ForceCameraAspectLite.AutoScaleViewport += AutoScaleViewport;

}
}
internal static event Delegates.AutoScaleViewport_BeforeArgs _beforeAutoScaleViewport;
internal static event Delegates.AutoScaleViewport_AfterArgs _afterAutoScaleViewport;
private static void AutoScaleViewport(On.ForceCameraAspectLite.orig_AutoScaleViewport orig,ForceCameraAspectLite self)
{
Delegates.Params_AutoScaleViewport @params = new() 
{
self = self
};
if (_beforeAutoScaleViewport != null)
{
foreach (Delegates.AutoScaleViewport_BeforeArgs toInvoke in _beforeAutoScaleViewport.GetInvocationList())
{
try
{
_beforeAutoScaleViewport?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterAutoScaleViewport != null)
{
foreach (Delegates.AutoScaleViewport_AfterArgs toInvoke in _afterAutoScaleViewport.GetInvocationList())
{
try
{
_afterAutoScaleViewport.Invoke(@params);
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
public ForceCameraAspectLite self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<ForceCameraAspectLite> orig, ForceCameraAspectLite self);
public sealed class Params_Update
{
public ForceCameraAspectLite self;
}
public delegate void Update_BeforeArgs(Params_Update args);
public delegate void Update_AfterArgs(Params_Update args);
public delegate void Update_WithArgs (Action<ForceCameraAspectLite> orig, ForceCameraAspectLite self);
public sealed class Params_AutoScaleViewport
{
public ForceCameraAspectLite self;
}
public delegate void AutoScaleViewport_BeforeArgs(Params_AutoScaleViewport args);
public delegate void AutoScaleViewport_AfterArgs(Params_AutoScaleViewport args);
public delegate void AutoScaleViewport_WithArgs (Action<ForceCameraAspectLite> orig, ForceCameraAspectLite self);
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
public static event Delegates.Update_BeforeArgs Update
{
add
{

HookHandler._beforeUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._beforeUpdate -= value;
}
public static event Delegates.AutoScaleViewport_BeforeArgs AutoScaleViewport
{
add
{

HookHandler._beforeAutoScaleViewport += value;
HookHandler.HookAutoScaleViewport();
}
remove => HookHandler._beforeAutoScaleViewport -= value;
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
public static event Delegates.Update_AfterArgs Update
{
add
{

HookHandler._afterUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._afterUpdate -= value;
}
public static event Delegates.AutoScaleViewport_AfterArgs AutoScaleViewport
{
add
{

HookHandler._afterAutoScaleViewport += value;
HookHandler.HookAutoScaleViewport();
}
remove => HookHandler._afterAutoScaleViewport -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.ForceCameraAspectLite.hook_Start Start
{
add => On.ForceCameraAspectLite.Start += value;
remove => On.ForceCameraAspectLite.Start -= value;
}
public static event On.ForceCameraAspectLite.hook_Update Update
{
add => On.ForceCameraAspectLite.Update += value;
remove => On.ForceCameraAspectLite.Update -= value;
}
public static event On.ForceCameraAspectLite.hook_AutoScaleViewport AutoScaleViewport
{
add => On.ForceCameraAspectLite.AutoScaleViewport += value;
remove => On.ForceCameraAspectLite.AutoScaleViewport -= value;
}
}

}
