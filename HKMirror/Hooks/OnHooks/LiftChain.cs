using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for LiftChain class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnLiftChain
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.LiftChain.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.LiftChain.orig_Awake orig,LiftChain self)
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
internal static void HookGoDown()
{
if (!HookedList.Contains("GoDown"))
{
HookedList.Add("GoDown");
On.LiftChain.GoDown += GoDown;

}
}
internal static event Delegates.GoDown_BeforeArgs _beforeGoDown;
internal static event Delegates.GoDown_AfterArgs _afterGoDown;
private static void GoDown(On.LiftChain.orig_GoDown orig,LiftChain self)
{
Delegates.Params_GoDown @params = new() 
{
self = self
};
if (_beforeGoDown != null)
{
foreach (Delegates.GoDown_BeforeArgs toInvoke in _beforeGoDown.GetInvocationList())
{
try
{
_beforeGoDown?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterGoDown != null)
{
foreach (Delegates.GoDown_AfterArgs toInvoke in _afterGoDown.GetInvocationList())
{
try
{
_afterGoDown.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookGoUp()
{
if (!HookedList.Contains("GoUp"))
{
HookedList.Add("GoUp");
On.LiftChain.GoUp += GoUp;

}
}
internal static event Delegates.GoUp_BeforeArgs _beforeGoUp;
internal static event Delegates.GoUp_AfterArgs _afterGoUp;
private static void GoUp(On.LiftChain.orig_GoUp orig,LiftChain self)
{
Delegates.Params_GoUp @params = new() 
{
self = self
};
if (_beforeGoUp != null)
{
foreach (Delegates.GoUp_BeforeArgs toInvoke in _beforeGoUp.GetInvocationList())
{
try
{
_beforeGoUp?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterGoUp != null)
{
foreach (Delegates.GoUp_AfterArgs toInvoke in _afterGoUp.GetInvocationList())
{
try
{
_afterGoUp.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookStop()
{
if (!HookedList.Contains("Stop"))
{
HookedList.Add("Stop");
On.LiftChain.Stop += Stop;

}
}
internal static event Delegates.Stop_BeforeArgs _beforeStop;
internal static event Delegates.Stop_AfterArgs _afterStop;
private static void Stop(On.LiftChain.orig_Stop orig,LiftChain self)
{
Delegates.Params_Stop @params = new() 
{
self = self
};
if (_beforeStop != null)
{
foreach (Delegates.Stop_BeforeArgs toInvoke in _beforeStop.GetInvocationList())
{
try
{
_beforeStop?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterStop != null)
{
foreach (Delegates.Stop_AfterArgs toInvoke in _afterStop.GetInvocationList())
{
try
{
_afterStop.Invoke(@params);
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
public LiftChain self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<LiftChain> orig, LiftChain self);
public sealed class Params_GoDown
{
public LiftChain self;
}
public delegate void GoDown_BeforeArgs(Params_GoDown args);
public delegate void GoDown_AfterArgs(Params_GoDown args);
public delegate void GoDown_WithArgs (Action<LiftChain> orig, LiftChain self);
public sealed class Params_GoUp
{
public LiftChain self;
}
public delegate void GoUp_BeforeArgs(Params_GoUp args);
public delegate void GoUp_AfterArgs(Params_GoUp args);
public delegate void GoUp_WithArgs (Action<LiftChain> orig, LiftChain self);
public sealed class Params_Stop
{
public LiftChain self;
}
public delegate void Stop_BeforeArgs(Params_Stop args);
public delegate void Stop_AfterArgs(Params_Stop args);
public delegate void Stop_WithArgs (Action<LiftChain> orig, LiftChain self);
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
public static event Delegates.GoDown_BeforeArgs GoDown
{
add
{

HookHandler._beforeGoDown += value;
HookHandler.HookGoDown();
}
remove => HookHandler._beforeGoDown -= value;
}
public static event Delegates.GoUp_BeforeArgs GoUp
{
add
{

HookHandler._beforeGoUp += value;
HookHandler.HookGoUp();
}
remove => HookHandler._beforeGoUp -= value;
}
public static event Delegates.Stop_BeforeArgs Stop
{
add
{

HookHandler._beforeStop += value;
HookHandler.HookStop();
}
remove => HookHandler._beforeStop -= value;
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
public static event Delegates.GoDown_AfterArgs GoDown
{
add
{

HookHandler._afterGoDown += value;
HookHandler.HookGoDown();
}
remove => HookHandler._afterGoDown -= value;
}
public static event Delegates.GoUp_AfterArgs GoUp
{
add
{

HookHandler._afterGoUp += value;
HookHandler.HookGoUp();
}
remove => HookHandler._afterGoUp -= value;
}
public static event Delegates.Stop_AfterArgs Stop
{
add
{

HookHandler._afterStop += value;
HookHandler.HookStop();
}
remove => HookHandler._afterStop -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.LiftChain.hook_Awake Awake
{
add => On.LiftChain.Awake += value;
remove => On.LiftChain.Awake -= value;
}
public static event On.LiftChain.hook_GoDown GoDown
{
add => On.LiftChain.GoDown += value;
remove => On.LiftChain.GoDown -= value;
}
public static event On.LiftChain.hook_GoUp GoUp
{
add => On.LiftChain.GoUp += value;
remove => On.LiftChain.GoUp -= value;
}
public static event On.LiftChain.hook_Stop Stop
{
add => On.LiftChain.Stop += value;
remove => On.LiftChain.Stop -= value;
}
}

}
