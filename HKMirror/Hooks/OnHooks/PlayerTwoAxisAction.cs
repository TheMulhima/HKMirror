using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for PlayerTwoAxisAction class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayerTwoAxisAction
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hookget_InvertXAxis()
{
if (!HookedList.Contains("get_InvertXAxis"))
{
HookedList.Add("get_InvertXAxis");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_InvertXAxis", true), get_InvertXAxis);

}
}
internal static event Delegates.get_InvertXAxis_BeforeArgs _beforeget_InvertXAxis;
internal static event Delegates.get_InvertXAxis_AfterArgs _afterget_InvertXAxis;
private static bool get_InvertXAxis(Func<InControl.PlayerTwoAxisAction, bool> orig, InControl.PlayerTwoAxisAction self)
{
Delegates.Params_get_InvertXAxis @params = new() 
{
self = self
};
if (_beforeget_InvertXAxis != null)
{
foreach (Delegates.get_InvertXAxis_BeforeArgs toInvoke in _beforeget_InvertXAxis.GetInvocationList())
{
try
{
_beforeget_InvertXAxis?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_InvertXAxis != null)
{
foreach (Delegates.get_InvertXAxis_AfterArgs toInvoke in _afterget_InvertXAxis.GetInvocationList())
{
try
{
retVal = _afterget_InvertXAxis.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_InvertXAxis()
{
if (!HookedList.Contains("set_InvertXAxis"))
{
HookedList.Add("set_InvertXAxis");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_InvertXAxis", true), set_InvertXAxis);

}
}
internal static event Delegates.set_InvertXAxis_BeforeArgs _beforeset_InvertXAxis;
internal static event Delegates.set_InvertXAxis_AfterArgs _afterset_InvertXAxis;
private static void set_InvertXAxis(Action<InControl.PlayerTwoAxisAction,  bool> orig, InControl.PlayerTwoAxisAction self,  bool value)
{
Delegates.Params_set_InvertXAxis @params = new() 
{
self = self
, value = value
};
if (_beforeset_InvertXAxis != null)
{
foreach (Delegates.set_InvertXAxis_BeforeArgs toInvoke in _beforeset_InvertXAxis.GetInvocationList())
{
try
{
_beforeset_InvertXAxis?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_InvertXAxis != null)
{
foreach (Delegates.set_InvertXAxis_AfterArgs toInvoke in _afterset_InvertXAxis.GetInvocationList())
{
try
{
_afterset_InvertXAxis.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_InvertYAxis()
{
if (!HookedList.Contains("get_InvertYAxis"))
{
HookedList.Add("get_InvertYAxis");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_InvertYAxis", true), get_InvertYAxis);

}
}
internal static event Delegates.get_InvertYAxis_BeforeArgs _beforeget_InvertYAxis;
internal static event Delegates.get_InvertYAxis_AfterArgs _afterget_InvertYAxis;
private static bool get_InvertYAxis(Func<InControl.PlayerTwoAxisAction, bool> orig, InControl.PlayerTwoAxisAction self)
{
Delegates.Params_get_InvertYAxis @params = new() 
{
self = self
};
if (_beforeget_InvertYAxis != null)
{
foreach (Delegates.get_InvertYAxis_BeforeArgs toInvoke in _beforeget_InvertYAxis.GetInvocationList())
{
try
{
_beforeget_InvertYAxis?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_InvertYAxis != null)
{
foreach (Delegates.get_InvertYAxis_AfterArgs toInvoke in _afterget_InvertYAxis.GetInvocationList())
{
try
{
retVal = _afterget_InvertYAxis.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_InvertYAxis()
{
if (!HookedList.Contains("set_InvertYAxis"))
{
HookedList.Add("set_InvertYAxis");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_InvertYAxis", true), set_InvertYAxis);

}
}
internal static event Delegates.set_InvertYAxis_BeforeArgs _beforeset_InvertYAxis;
internal static event Delegates.set_InvertYAxis_AfterArgs _afterset_InvertYAxis;
private static void set_InvertYAxis(Action<InControl.PlayerTwoAxisAction,  bool> orig, InControl.PlayerTwoAxisAction self,  bool value)
{
Delegates.Params_set_InvertYAxis @params = new() 
{
self = self
, value = value
};
if (_beforeset_InvertYAxis != null)
{
foreach (Delegates.set_InvertYAxis_BeforeArgs toInvoke in _beforeset_InvertYAxis.GetInvocationList())
{
try
{
_beforeset_InvertYAxis?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_InvertYAxis != null)
{
foreach (Delegates.set_InvertYAxis_AfterArgs toInvoke in _afterset_InvertYAxis.GetInvocationList())
{
try
{
_afterset_InvertYAxis.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_UserData()
{
if (!HookedList.Contains("get_UserData"))
{
HookedList.Add("get_UserData");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_UserData", true), get_UserData);

}
}
internal static event Delegates.get_UserData_BeforeArgs _beforeget_UserData;
internal static event Delegates.get_UserData_AfterArgs _afterget_UserData;
private static System.Object get_UserData(Func<InControl.PlayerTwoAxisAction, System.Object> orig, InControl.PlayerTwoAxisAction self)
{
Delegates.Params_get_UserData @params = new() 
{
self = self
};
if (_beforeget_UserData != null)
{
foreach (Delegates.get_UserData_BeforeArgs toInvoke in _beforeget_UserData.GetInvocationList())
{
try
{
_beforeget_UserData?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_UserData != null)
{
foreach (Delegates.get_UserData_AfterArgs toInvoke in _afterget_UserData.GetInvocationList())
{
try
{
retVal = _afterget_UserData.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_UserData()
{
if (!HookedList.Contains("set_UserData"))
{
HookedList.Add("set_UserData");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_UserData", true), set_UserData);

}
}
internal static event Delegates.set_UserData_BeforeArgs _beforeset_UserData;
internal static event Delegates.set_UserData_AfterArgs _afterset_UserData;
private static void set_UserData(Action<InControl.PlayerTwoAxisAction,  System.Object> orig, InControl.PlayerTwoAxisAction self,  System.Object value)
{
Delegates.Params_set_UserData @params = new() 
{
self = self
, value = value
};
if (_beforeset_UserData != null)
{
foreach (Delegates.set_UserData_BeforeArgs toInvoke in _beforeset_UserData.GetInvocationList())
{
try
{
_beforeset_UserData?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_UserData != null)
{
foreach (Delegates.set_UserData_AfterArgs toInvoke in _afterset_UserData.GetInvocationList())
{
try
{
_afterset_UserData.Invoke(@params);
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "Update", true), Update);

}
}
internal static event Delegates.Update_BeforeArgs _beforeUpdate;
internal static event Delegates.Update_AfterArgs _afterUpdate;
private static void Update(Action<InControl.PlayerTwoAxisAction,  ulong,  float> orig, InControl.PlayerTwoAxisAction self,  ulong updateTick,  float deltaTime)
{
Delegates.Params_Update @params = new() 
{
self = self
, updateTick = updateTick
, deltaTime = deltaTime
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
updateTick = @params.updateTick;
deltaTime = @params.deltaTime;
orig(self, updateTick, deltaTime);
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
internal static void HookProcessActionUpdate()
{
if (!HookedList.Contains("ProcessActionUpdate"))
{
HookedList.Add("ProcessActionUpdate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "ProcessActionUpdate", true), ProcessActionUpdate);

}
}
internal static event Delegates.ProcessActionUpdate_BeforeArgs _beforeProcessActionUpdate;
internal static event Delegates.ProcessActionUpdate_AfterArgs _afterProcessActionUpdate;
private static void ProcessActionUpdate(Action<InControl.PlayerTwoAxisAction,  InControl.PlayerAction> orig, InControl.PlayerTwoAxisAction self,  InControl.PlayerAction action)
{
Delegates.Params_ProcessActionUpdate @params = new() 
{
self = self
, action = action
};
if (_beforeProcessActionUpdate != null)
{
foreach (Delegates.ProcessActionUpdate_BeforeArgs toInvoke in _beforeProcessActionUpdate.GetInvocationList())
{
try
{
_beforeProcessActionUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
action = @params.action;
orig(self, action);
if (_afterProcessActionUpdate != null)
{
foreach (Delegates.ProcessActionUpdate_AfterArgs toInvoke in _afterProcessActionUpdate.GetInvocationList())
{
try
{
_afterProcessActionUpdate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_LowerDeadZone()
{
if (!HookedList.Contains("get_LowerDeadZone"))
{
HookedList.Add("get_LowerDeadZone");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_LowerDeadZone", true), get_LowerDeadZone);

}
}
internal static event Delegates.get_LowerDeadZone_BeforeArgs _beforeget_LowerDeadZone;
internal static event Delegates.get_LowerDeadZone_AfterArgs _afterget_LowerDeadZone;
private static float get_LowerDeadZone(Func<InControl.PlayerTwoAxisAction, float> orig, InControl.PlayerTwoAxisAction self)
{
Delegates.Params_get_LowerDeadZone @params = new() 
{
self = self
};
if (_beforeget_LowerDeadZone != null)
{
foreach (Delegates.get_LowerDeadZone_BeforeArgs toInvoke in _beforeget_LowerDeadZone.GetInvocationList())
{
try
{
_beforeget_LowerDeadZone?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_LowerDeadZone != null)
{
foreach (Delegates.get_LowerDeadZone_AfterArgs toInvoke in _afterget_LowerDeadZone.GetInvocationList())
{
try
{
retVal = _afterget_LowerDeadZone.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_LowerDeadZone()
{
if (!HookedList.Contains("set_LowerDeadZone"))
{
HookedList.Add("set_LowerDeadZone");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_LowerDeadZone", true), set_LowerDeadZone);

}
}
internal static event Delegates.set_LowerDeadZone_BeforeArgs _beforeset_LowerDeadZone;
internal static event Delegates.set_LowerDeadZone_AfterArgs _afterset_LowerDeadZone;
private static void set_LowerDeadZone(Action<InControl.PlayerTwoAxisAction,  float> orig, InControl.PlayerTwoAxisAction self,  float value)
{
Delegates.Params_set_LowerDeadZone @params = new() 
{
self = self
, value = value
};
if (_beforeset_LowerDeadZone != null)
{
foreach (Delegates.set_LowerDeadZone_BeforeArgs toInvoke in _beforeset_LowerDeadZone.GetInvocationList())
{
try
{
_beforeset_LowerDeadZone?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_LowerDeadZone != null)
{
foreach (Delegates.set_LowerDeadZone_AfterArgs toInvoke in _afterset_LowerDeadZone.GetInvocationList())
{
try
{
_afterset_LowerDeadZone.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_UpperDeadZone()
{
if (!HookedList.Contains("get_UpperDeadZone"))
{
HookedList.Add("get_UpperDeadZone");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_UpperDeadZone", true), get_UpperDeadZone);

}
}
internal static event Delegates.get_UpperDeadZone_BeforeArgs _beforeget_UpperDeadZone;
internal static event Delegates.get_UpperDeadZone_AfterArgs _afterget_UpperDeadZone;
private static float get_UpperDeadZone(Func<InControl.PlayerTwoAxisAction, float> orig, InControl.PlayerTwoAxisAction self)
{
Delegates.Params_get_UpperDeadZone @params = new() 
{
self = self
};
if (_beforeget_UpperDeadZone != null)
{
foreach (Delegates.get_UpperDeadZone_BeforeArgs toInvoke in _beforeget_UpperDeadZone.GetInvocationList())
{
try
{
_beforeget_UpperDeadZone?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_UpperDeadZone != null)
{
foreach (Delegates.get_UpperDeadZone_AfterArgs toInvoke in _afterget_UpperDeadZone.GetInvocationList())
{
try
{
retVal = _afterget_UpperDeadZone.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_UpperDeadZone()
{
if (!HookedList.Contains("set_UpperDeadZone"))
{
HookedList.Add("set_UpperDeadZone");
new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_UpperDeadZone", true), set_UpperDeadZone);

}
}
internal static event Delegates.set_UpperDeadZone_BeforeArgs _beforeset_UpperDeadZone;
internal static event Delegates.set_UpperDeadZone_AfterArgs _afterset_UpperDeadZone;
private static void set_UpperDeadZone(Action<InControl.PlayerTwoAxisAction,  float> orig, InControl.PlayerTwoAxisAction self,  float value)
{
Delegates.Params_set_UpperDeadZone @params = new() 
{
self = self
, value = value
};
if (_beforeset_UpperDeadZone != null)
{
foreach (Delegates.set_UpperDeadZone_BeforeArgs toInvoke in _beforeset_UpperDeadZone.GetInvocationList())
{
try
{
_beforeset_UpperDeadZone?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_UpperDeadZone != null)
{
foreach (Delegates.set_UpperDeadZone_AfterArgs toInvoke in _afterset_UpperDeadZone.GetInvocationList())
{
try
{
_afterset_UpperDeadZone.Invoke(@params);
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
public sealed class Params_get_InvertXAxis
{
public InControl.PlayerTwoAxisAction self;
}
public delegate void get_InvertXAxis_BeforeArgs(Params_get_InvertXAxis args);
public delegate bool get_InvertXAxis_AfterArgs(Params_get_InvertXAxis args, bool ret);
public delegate bool get_InvertXAxis_WithArgs (Func<InControl.PlayerTwoAxisAction, bool> orig, InControl.PlayerTwoAxisAction self);
public sealed class Params_set_InvertXAxis
{
public InControl.PlayerTwoAxisAction self;
public bool value;
}
public delegate void set_InvertXAxis_BeforeArgs(Params_set_InvertXAxis args);
public delegate void set_InvertXAxis_AfterArgs(Params_set_InvertXAxis args);
public delegate void set_InvertXAxis_WithArgs (Action<InControl.PlayerTwoAxisAction,  bool> orig, InControl.PlayerTwoAxisAction self,  bool value);
public sealed class Params_get_InvertYAxis
{
public InControl.PlayerTwoAxisAction self;
}
public delegate void get_InvertYAxis_BeforeArgs(Params_get_InvertYAxis args);
public delegate bool get_InvertYAxis_AfterArgs(Params_get_InvertYAxis args, bool ret);
public delegate bool get_InvertYAxis_WithArgs (Func<InControl.PlayerTwoAxisAction, bool> orig, InControl.PlayerTwoAxisAction self);
public sealed class Params_set_InvertYAxis
{
public InControl.PlayerTwoAxisAction self;
public bool value;
}
public delegate void set_InvertYAxis_BeforeArgs(Params_set_InvertYAxis args);
public delegate void set_InvertYAxis_AfterArgs(Params_set_InvertYAxis args);
public delegate void set_InvertYAxis_WithArgs (Action<InControl.PlayerTwoAxisAction,  bool> orig, InControl.PlayerTwoAxisAction self,  bool value);
public sealed class Params_get_UserData
{
public InControl.PlayerTwoAxisAction self;
}
public delegate void get_UserData_BeforeArgs(Params_get_UserData args);
public delegate System.Object get_UserData_AfterArgs(Params_get_UserData args, System.Object ret);
public delegate System.Object get_UserData_WithArgs (Func<InControl.PlayerTwoAxisAction, System.Object> orig, InControl.PlayerTwoAxisAction self);
public sealed class Params_set_UserData
{
public InControl.PlayerTwoAxisAction self;
public System.Object value;
}
public delegate void set_UserData_BeforeArgs(Params_set_UserData args);
public delegate void set_UserData_AfterArgs(Params_set_UserData args);
public delegate void set_UserData_WithArgs (Action<InControl.PlayerTwoAxisAction,  System.Object> orig, InControl.PlayerTwoAxisAction self,  System.Object value);
public sealed class Params_Update
{
public InControl.PlayerTwoAxisAction self;
public ulong updateTick;
public float deltaTime;
}
public delegate void Update_BeforeArgs(Params_Update args);
public delegate void Update_AfterArgs(Params_Update args);
public delegate void Update_WithArgs (Action<InControl.PlayerTwoAxisAction,  ulong,  float> orig, InControl.PlayerTwoAxisAction self,  ulong updateTick,  float deltaTime);
public sealed class Params_ProcessActionUpdate
{
public InControl.PlayerTwoAxisAction self;
public InControl.PlayerAction action;
}
public delegate void ProcessActionUpdate_BeforeArgs(Params_ProcessActionUpdate args);
public delegate void ProcessActionUpdate_AfterArgs(Params_ProcessActionUpdate args);
public delegate void ProcessActionUpdate_WithArgs (Action<InControl.PlayerTwoAxisAction,  InControl.PlayerAction> orig, InControl.PlayerTwoAxisAction self,  InControl.PlayerAction action);
public sealed class Params_get_LowerDeadZone
{
public InControl.PlayerTwoAxisAction self;
}
public delegate void get_LowerDeadZone_BeforeArgs(Params_get_LowerDeadZone args);
public delegate float get_LowerDeadZone_AfterArgs(Params_get_LowerDeadZone args, float ret);
public delegate float get_LowerDeadZone_WithArgs (Func<InControl.PlayerTwoAxisAction, float> orig, InControl.PlayerTwoAxisAction self);
public sealed class Params_set_LowerDeadZone
{
public InControl.PlayerTwoAxisAction self;
public float value;
}
public delegate void set_LowerDeadZone_BeforeArgs(Params_set_LowerDeadZone args);
public delegate void set_LowerDeadZone_AfterArgs(Params_set_LowerDeadZone args);
public delegate void set_LowerDeadZone_WithArgs (Action<InControl.PlayerTwoAxisAction,  float> orig, InControl.PlayerTwoAxisAction self,  float value);
public sealed class Params_get_UpperDeadZone
{
public InControl.PlayerTwoAxisAction self;
}
public delegate void get_UpperDeadZone_BeforeArgs(Params_get_UpperDeadZone args);
public delegate float get_UpperDeadZone_AfterArgs(Params_get_UpperDeadZone args, float ret);
public delegate float get_UpperDeadZone_WithArgs (Func<InControl.PlayerTwoAxisAction, float> orig, InControl.PlayerTwoAxisAction self);
public sealed class Params_set_UpperDeadZone
{
public InControl.PlayerTwoAxisAction self;
public float value;
}
public delegate void set_UpperDeadZone_BeforeArgs(Params_set_UpperDeadZone args);
public delegate void set_UpperDeadZone_AfterArgs(Params_set_UpperDeadZone args);
public delegate void set_UpperDeadZone_WithArgs (Action<InControl.PlayerTwoAxisAction,  float> orig, InControl.PlayerTwoAxisAction self,  float value);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.get_InvertXAxis_BeforeArgs get_InvertXAxis
{
add
{

HookHandler._beforeget_InvertXAxis += value;
HookHandler.Hookget_InvertXAxis();
}
remove => HookHandler._beforeget_InvertXAxis -= value;
}
public static event Delegates.set_InvertXAxis_BeforeArgs set_InvertXAxis
{
add
{

HookHandler._beforeset_InvertXAxis += value;
HookHandler.Hookset_InvertXAxis();
}
remove => HookHandler._beforeset_InvertXAxis -= value;
}
public static event Delegates.get_InvertYAxis_BeforeArgs get_InvertYAxis
{
add
{

HookHandler._beforeget_InvertYAxis += value;
HookHandler.Hookget_InvertYAxis();
}
remove => HookHandler._beforeget_InvertYAxis -= value;
}
public static event Delegates.set_InvertYAxis_BeforeArgs set_InvertYAxis
{
add
{

HookHandler._beforeset_InvertYAxis += value;
HookHandler.Hookset_InvertYAxis();
}
remove => HookHandler._beforeset_InvertYAxis -= value;
}
public static event Delegates.get_UserData_BeforeArgs get_UserData
{
add
{

HookHandler._beforeget_UserData += value;
HookHandler.Hookget_UserData();
}
remove => HookHandler._beforeget_UserData -= value;
}
public static event Delegates.set_UserData_BeforeArgs set_UserData
{
add
{

HookHandler._beforeset_UserData += value;
HookHandler.Hookset_UserData();
}
remove => HookHandler._beforeset_UserData -= value;
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
public static event Delegates.ProcessActionUpdate_BeforeArgs ProcessActionUpdate
{
add
{

HookHandler._beforeProcessActionUpdate += value;
HookHandler.HookProcessActionUpdate();
}
remove => HookHandler._beforeProcessActionUpdate -= value;
}
public static event Delegates.get_LowerDeadZone_BeforeArgs get_LowerDeadZone
{
add
{

HookHandler._beforeget_LowerDeadZone += value;
HookHandler.Hookget_LowerDeadZone();
}
remove => HookHandler._beforeget_LowerDeadZone -= value;
}
public static event Delegates.set_LowerDeadZone_BeforeArgs set_LowerDeadZone
{
add
{

HookHandler._beforeset_LowerDeadZone += value;
HookHandler.Hookset_LowerDeadZone();
}
remove => HookHandler._beforeset_LowerDeadZone -= value;
}
public static event Delegates.get_UpperDeadZone_BeforeArgs get_UpperDeadZone
{
add
{

HookHandler._beforeget_UpperDeadZone += value;
HookHandler.Hookget_UpperDeadZone();
}
remove => HookHandler._beforeget_UpperDeadZone -= value;
}
public static event Delegates.set_UpperDeadZone_BeforeArgs set_UpperDeadZone
{
add
{

HookHandler._beforeset_UpperDeadZone += value;
HookHandler.Hookset_UpperDeadZone();
}
remove => HookHandler._beforeset_UpperDeadZone -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.get_InvertXAxis_AfterArgs get_InvertXAxis
{
add
{

HookHandler._afterget_InvertXAxis += value;
HookHandler.Hookget_InvertXAxis();
}
remove => HookHandler._afterget_InvertXAxis -= value;
}
public static event Delegates.set_InvertXAxis_AfterArgs set_InvertXAxis
{
add
{

HookHandler._afterset_InvertXAxis += value;
HookHandler.Hookset_InvertXAxis();
}
remove => HookHandler._afterset_InvertXAxis -= value;
}
public static event Delegates.get_InvertYAxis_AfterArgs get_InvertYAxis
{
add
{

HookHandler._afterget_InvertYAxis += value;
HookHandler.Hookget_InvertYAxis();
}
remove => HookHandler._afterget_InvertYAxis -= value;
}
public static event Delegates.set_InvertYAxis_AfterArgs set_InvertYAxis
{
add
{

HookHandler._afterset_InvertYAxis += value;
HookHandler.Hookset_InvertYAxis();
}
remove => HookHandler._afterset_InvertYAxis -= value;
}
public static event Delegates.get_UserData_AfterArgs get_UserData
{
add
{

HookHandler._afterget_UserData += value;
HookHandler.Hookget_UserData();
}
remove => HookHandler._afterget_UserData -= value;
}
public static event Delegates.set_UserData_AfterArgs set_UserData
{
add
{

HookHandler._afterset_UserData += value;
HookHandler.Hookset_UserData();
}
remove => HookHandler._afterset_UserData -= value;
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
public static event Delegates.ProcessActionUpdate_AfterArgs ProcessActionUpdate
{
add
{

HookHandler._afterProcessActionUpdate += value;
HookHandler.HookProcessActionUpdate();
}
remove => HookHandler._afterProcessActionUpdate -= value;
}
public static event Delegates.get_LowerDeadZone_AfterArgs get_LowerDeadZone
{
add
{

HookHandler._afterget_LowerDeadZone += value;
HookHandler.Hookget_LowerDeadZone();
}
remove => HookHandler._afterget_LowerDeadZone -= value;
}
public static event Delegates.set_LowerDeadZone_AfterArgs set_LowerDeadZone
{
add
{

HookHandler._afterset_LowerDeadZone += value;
HookHandler.Hookset_LowerDeadZone();
}
remove => HookHandler._afterset_LowerDeadZone -= value;
}
public static event Delegates.get_UpperDeadZone_AfterArgs get_UpperDeadZone
{
add
{

HookHandler._afterget_UpperDeadZone += value;
HookHandler.Hookget_UpperDeadZone();
}
remove => HookHandler._afterget_UpperDeadZone -= value;
}
public static event Delegates.set_UpperDeadZone_AfterArgs set_UpperDeadZone
{
add
{

HookHandler._afterset_UpperDeadZone += value;
HookHandler.Hookset_UpperDeadZone();
}
remove => HookHandler._afterset_UpperDeadZone -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.get_InvertXAxis_WithArgs get_InvertXAxis
{
add => HookEndpointManager.Add<Delegates.get_InvertXAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_InvertXAxis", true), value);
remove => HookEndpointManager.Remove<Delegates.get_InvertXAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_InvertXAxis", true), value);
}
public static event Delegates.set_InvertXAxis_WithArgs set_InvertXAxis
{
add => HookEndpointManager.Add<Delegates.set_InvertXAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_InvertXAxis", true), value);
remove => HookEndpointManager.Remove<Delegates.set_InvertXAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_InvertXAxis", true), value);
}
public static event Delegates.get_InvertYAxis_WithArgs get_InvertYAxis
{
add => HookEndpointManager.Add<Delegates.get_InvertYAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_InvertYAxis", true), value);
remove => HookEndpointManager.Remove<Delegates.get_InvertYAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_InvertYAxis", true), value);
}
public static event Delegates.set_InvertYAxis_WithArgs set_InvertYAxis
{
add => HookEndpointManager.Add<Delegates.set_InvertYAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_InvertYAxis", true), value);
remove => HookEndpointManager.Remove<Delegates.set_InvertYAxis_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_InvertYAxis", true), value);
}
public static event Delegates.get_UserData_WithArgs get_UserData
{
add => HookEndpointManager.Add<Delegates.get_UserData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_UserData", true), value);
remove => HookEndpointManager.Remove<Delegates.get_UserData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_UserData", true), value);
}
public static event Delegates.set_UserData_WithArgs set_UserData
{
add => HookEndpointManager.Add<Delegates.set_UserData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_UserData", true), value);
remove => HookEndpointManager.Remove<Delegates.set_UserData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_UserData", true), value);
}
public static event Delegates.Update_WithArgs Update
{
add => HookEndpointManager.Add<Delegates.Update_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "Update", true), value);
remove => HookEndpointManager.Remove<Delegates.Update_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "Update", true), value);
}
public static event Delegates.ProcessActionUpdate_WithArgs ProcessActionUpdate
{
add => HookEndpointManager.Add<Delegates.ProcessActionUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "ProcessActionUpdate", true), value);
remove => HookEndpointManager.Remove<Delegates.ProcessActionUpdate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "ProcessActionUpdate", true), value);
}
public static event Delegates.get_LowerDeadZone_WithArgs get_LowerDeadZone
{
add => HookEndpointManager.Add<Delegates.get_LowerDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_LowerDeadZone", true), value);
remove => HookEndpointManager.Remove<Delegates.get_LowerDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_LowerDeadZone", true), value);
}
public static event Delegates.set_LowerDeadZone_WithArgs set_LowerDeadZone
{
add => HookEndpointManager.Add<Delegates.set_LowerDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_LowerDeadZone", true), value);
remove => HookEndpointManager.Remove<Delegates.set_LowerDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_LowerDeadZone", true), value);
}
public static event Delegates.get_UpperDeadZone_WithArgs get_UpperDeadZone
{
add => HookEndpointManager.Add<Delegates.get_UpperDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_UpperDeadZone", true), value);
remove => HookEndpointManager.Remove<Delegates.get_UpperDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "get_UpperDeadZone", true), value);
}
public static event Delegates.set_UpperDeadZone_WithArgs set_UpperDeadZone
{
add => HookEndpointManager.Add<Delegates.set_UpperDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_UpperDeadZone", true), value);
remove => HookEndpointManager.Remove<Delegates.set_UpperDeadZone_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(InControl.PlayerTwoAxisAction), "set_UpperDeadZone", true), value);
}
}

}
