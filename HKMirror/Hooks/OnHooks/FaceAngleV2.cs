using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for FaceAngleV2 class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFaceAngleV2
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReset()
{
if (!HookedList.Contains("Reset"))
{
HookedList.Add("Reset");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "Reset", true), Reset);

}
}
internal static event Delegates.Reset_BeforeArgs _beforeReset;
internal static event Delegates.Reset_AfterArgs _afterReset;
private static void Reset(Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self)
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
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "Awake", true), Awake);

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self)
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
internal static void HookOnPreprocess()
{
if (!HookedList.Contains("OnPreprocess"))
{
HookedList.Add("OnPreprocess");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnPreprocess", true), OnPreprocess);

}
}
internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;
private static void OnPreprocess(Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self)
{
Delegates.Params_OnPreprocess @params = new() 
{
self = self
};
if (_beforeOnPreprocess != null)
{
foreach (Delegates.OnPreprocess_BeforeArgs toInvoke in _beforeOnPreprocess.GetInvocationList())
{
try
{
_beforeOnPreprocess?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnPreprocess != null)
{
foreach (Delegates.OnPreprocess_AfterArgs toInvoke in _afterOnPreprocess.GetInvocationList())
{
try
{
_afterOnPreprocess.Invoke(@params);
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnEnter", true), OnEnter);

}
}
internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;
private static void OnEnter(Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self)
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
internal static void HookOnFixedUpdate()
{
if (!HookedList.Contains("OnFixedUpdate"))
{
HookedList.Add("OnFixedUpdate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnFixedUpdate", true), OnFixedUpdate);

}
}
internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
internal static event Delegates.OnFixedUpdate_AfterArgs _afterOnFixedUpdate;
private static void OnFixedUpdate(Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self)
{
Delegates.Params_OnFixedUpdate @params = new() 
{
self = self
};
if (_beforeOnFixedUpdate != null)
{
foreach (Delegates.OnFixedUpdate_BeforeArgs toInvoke in _beforeOnFixedUpdate.GetInvocationList())
{
try
{
_beforeOnFixedUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnFixedUpdate != null)
{
foreach (Delegates.OnFixedUpdate_AfterArgs toInvoke in _afterOnFixedUpdate.GetInvocationList())
{
try
{
_afterOnFixedUpdate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookDoAngle()
{
if (!HookedList.Contains("DoAngle"))
{
HookedList.Add("DoAngle");
new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "DoAngle", true), DoAngle);

}
}
internal static event Delegates.DoAngle_BeforeArgs _beforeDoAngle;
internal static event Delegates.DoAngle_AfterArgs _afterDoAngle;
private static void DoAngle(Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self)
{
Delegates.Params_DoAngle @params = new() 
{
self = self
};
if (_beforeDoAngle != null)
{
foreach (Delegates.DoAngle_BeforeArgs toInvoke in _beforeDoAngle.GetInvocationList())
{
try
{
_beforeDoAngle?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDoAngle != null)
{
foreach (Delegates.DoAngle_AfterArgs toInvoke in _afterDoAngle.GetInvocationList())
{
try
{
_afterDoAngle.Invoke(@params);
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
public HutongGames.PlayMaker.Actions.FaceAngleV2 self;
}
public delegate void Reset_BeforeArgs(Params_Reset args);
public delegate void Reset_AfterArgs(Params_Reset args);
public delegate void Reset_WithArgs (Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self);
public sealed class Params_Awake
{
public HutongGames.PlayMaker.Actions.FaceAngleV2 self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self);
public sealed class Params_OnPreprocess
{
public HutongGames.PlayMaker.Actions.FaceAngleV2 self;
}
public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);
public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);
public delegate void OnPreprocess_WithArgs (Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self);
public sealed class Params_OnEnter
{
public HutongGames.PlayMaker.Actions.FaceAngleV2 self;
}
public delegate void OnEnter_BeforeArgs(Params_OnEnter args);
public delegate void OnEnter_AfterArgs(Params_OnEnter args);
public delegate void OnEnter_WithArgs (Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self);
public sealed class Params_OnFixedUpdate
{
public HutongGames.PlayMaker.Actions.FaceAngleV2 self;
}
public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);
public delegate void OnFixedUpdate_AfterArgs(Params_OnFixedUpdate args);
public delegate void OnFixedUpdate_WithArgs (Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self);
public sealed class Params_DoAngle
{
public HutongGames.PlayMaker.Actions.FaceAngleV2 self;
}
public delegate void DoAngle_BeforeArgs(Params_DoAngle args);
public delegate void DoAngle_AfterArgs(Params_DoAngle args);
public delegate void DoAngle_WithArgs (Action<HutongGames.PlayMaker.Actions.FaceAngleV2> orig, HutongGames.PlayMaker.Actions.FaceAngleV2 self);
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
public static event Delegates.Awake_BeforeArgs Awake
{
add
{

HookHandler._beforeAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._beforeAwake -= value;
}
public static event Delegates.OnPreprocess_BeforeArgs OnPreprocess
{
add
{

HookHandler._beforeOnPreprocess += value;
HookHandler.HookOnPreprocess();
}
remove => HookHandler._beforeOnPreprocess -= value;
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
public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
{
add
{

HookHandler._beforeOnFixedUpdate += value;
HookHandler.HookOnFixedUpdate();
}
remove => HookHandler._beforeOnFixedUpdate -= value;
}
public static event Delegates.DoAngle_BeforeArgs DoAngle
{
add
{

HookHandler._beforeDoAngle += value;
HookHandler.HookDoAngle();
}
remove => HookHandler._beforeDoAngle -= value;
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
public static event Delegates.Awake_AfterArgs Awake
{
add
{

HookHandler._afterAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._afterAwake -= value;
}
public static event Delegates.OnPreprocess_AfterArgs OnPreprocess
{
add
{

HookHandler._afterOnPreprocess += value;
HookHandler.HookOnPreprocess();
}
remove => HookHandler._afterOnPreprocess -= value;
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
public static event Delegates.OnFixedUpdate_AfterArgs OnFixedUpdate
{
add
{

HookHandler._afterOnFixedUpdate += value;
HookHandler.HookOnFixedUpdate();
}
remove => HookHandler._afterOnFixedUpdate -= value;
}
public static event Delegates.DoAngle_AfterArgs DoAngle
{
add
{

HookHandler._afterDoAngle += value;
HookHandler.HookDoAngle();
}
remove => HookHandler._afterDoAngle -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Reset_WithArgs Reset
{
add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "Reset", true), value);
remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "Reset", true), value);
}
public static event Delegates.Awake_WithArgs Awake
{
add => HookEndpointManager.Add<Delegates.Awake_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "Awake", true), value);
remove => HookEndpointManager.Remove<Delegates.Awake_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "Awake", true), value);
}
public static event Delegates.OnPreprocess_WithArgs OnPreprocess
{
add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnPreprocess", true), value);
remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnPreprocess", true), value);
}
public static event Delegates.OnEnter_WithArgs OnEnter
{
add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnEnter", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnEnter", true), value);
}
public static event Delegates.OnFixedUpdate_WithArgs OnFixedUpdate
{
add => HookEndpointManager.Add<Delegates.OnFixedUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnFixedUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "OnFixedUpdate", true), value);
}
public static event Delegates.DoAngle_WithArgs DoAngle
{
add => HookEndpointManager.Add<Delegates.DoAngle_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "DoAngle", true), value);
remove => HookEndpointManager.Remove<Delegates.DoAngle_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.FaceAngleV2), "DoAngle", true), value);
}
}

}
